'---------------------------------------------------------------
' Purpose: Displays Property Information and Census Data
' Author: Mohammad Badrzadeh,  Sana Chatoor,  Thapanon Srisuwande,  David Titus,  Shangjun Wang 
' Date: 12/1/14
' Version: 2.079
' Input: Address, Parcel #, X & Y Mouse Click Point
' Output: Property Description / Address / Parcel # / Owner / Acres, Census Data by State / County / Block
'---------------------------------------------------------------

Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports ESRI.ArcGIS.Client
Imports ESRI.ArcGIS.Client.Tasks
Imports ESRI.ArcGIS.Client.Geometry

Class MainWindow

    'Declare
    Private _dataItems As List(Of DataItem) = Nothing
    Dim searchEnvelope As New ESRI.ArcGIS.Client.Geometry.Envelope
    Dim initExtent As New ESRI.ArcGIS.Client.Geometry.Envelope
    Dim graphicsLayer As GraphicsLayer
    Dim defaultMap As String
    Dim strSearch As String
    Dim numericCheck As Boolean
    Dim XmaxParcelReturn As Integer
    Dim XminParcelReturn As Integer
    Dim YmaxParcelReturn As Integer
    Dim YminParcelReturn As Integer
    Dim XmaxAddressReturn As Integer
    Dim XminAddressReturn As Integer
    Dim YmaxAddressReturn As Integer
    Dim YminAddressReturn As Integer
    Public XMin As Double
    Public YMin As Double
    Public XMax As Double
    Public YMax As Double

    'onLoad
    Private Sub mapWindow_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        'Check default map and layers to load (defaults.txt)
        mapDefaults()

        'Load data into the table PROP_DATA
        Dim PROP_DATADataSet As propertyScout.PROP_DATADataSet = CType(Me.FindResource("PROP_DATADataSet"), propertyScout.PROP_DATADataSet)
        Dim PROP_DATADataSetPROP_DATATableAdapter As propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter = New propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter()
        Dim PROP_DATAViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("PROP_DATAViewSource"), System.Windows.Data.CollectionViewSource)

    End Sub

    'Search Button - onClick
    Private Sub btnSearch_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSearch.Click

        Try

            'Check if search param is empty
            If txtMainSearch.Text = "" Then

                'Alert the error
                MessageBox.Show("Please enter a Valid Address or Parcel Number.", "Search",
                                Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information)

            Else 'There is a search param

                'Get the search string
                strSearch = txtMainSearch.Text
                'Check if search contains numbers
                numericCheck = IsNumeric(strSearch)


                'Instantiate a new call to load property data
                Dim PROP_DATADataSet As propertyScout.PROP_DATADataSet = CType(Me.FindResource("PROP_DATADataSet"), propertyScout.PROP_DATADataSet)
                'Load data into the table PROP_DATA
                Dim PROP_DATADataSetPROP_DATATableAdapter As propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter = New propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter()


                If numericCheck = True Then 'Search By Parcel

                    'Populate DataGrid Table: Retrieve Record by Parcel--------------------------------
                    PROP_DATADataSetPROP_DATATableAdapter.FillByParcel(PROP_DATADataSet.PROP_DATA, strSearch)

                    'Set New location------------------------------------------------------------------

                    'Query for XY Max / Min
                    Dim propQueriesTableAdapter As propertyScout.PROP_DATADataSetTableAdapters.QueriesTableAdapter = New propertyScout.PROP_DATADataSetTableAdapters.QueriesTableAdapter()

                    XmaxParcelReturn = CType(propQueriesTableAdapter.XmaxParcelQuery(strSearch), Integer)
                    XminParcelReturn = CType(propQueriesTableAdapter.XminParcelQuery(strSearch), Integer)
                    YmaxParcelReturn = CType(propQueriesTableAdapter.YmaxParcelQuery(strSearch), Integer)
                    YminParcelReturn = CType(propQueriesTableAdapter.YminParcelQuery(strSearch), Integer)

                    'Construct envelope
                    searchEnvelope.XMax = XmaxParcelReturn
                    searchEnvelope.XMin = XminParcelReturn
                    searchEnvelope.YMax = YmaxParcelReturn
                    searchEnvelope.YMin = YminParcelReturn

                    'Check if valid locale: Show the record, pan to location and set down a pin
                    If XmaxParcelReturn > 0 Then

                        'Show the datagrid containing the property record, and update coords formatting
                        propertyGrid.Visibility = Windows.Visibility.Visible
                        stkCoords.Margin = New System.Windows.Thickness(0, 0, 12, 70)

                        'Pan to it
                        map.Extent = searchEnvelope

                        'Set graphicsLayer (pinpoint)
                        Dim graphicsLayer As GraphicsLayer = TryCast(map.Layers("graphicsLayer"), GraphicsLayer)
                        graphicsLayer.Graphics.Clear()
                        Dim graphic As New ESRI.ArcGIS.Client.Graphic() With { _
                         .Geometry = map.Extent.GetCenter(), _
                         .Symbol = TryCast(LayoutRoot.Resources("DefaultPictureSymbol"), ESRI.ArcGIS.Client.Symbols.Symbol) _
                        }
                        graphicsLayer.Graphics.Add(graphic)

                        ''Zoom in
                        'map.Zoom(1)

                    Else
                        'Alert the Invalid Parcel Search
                        MessageBox.Show("This is not a valid Parcel")
                    End If


                Else 'Search By Address

                    'Populate DataGrid Table: Retrieve Record by Address--------------------------------
                    PROP_DATADataSetPROP_DATATableAdapter.FillByAddress(PROP_DATADataSet.PROP_DATA, strSearch)

                    'Set New location--------------------------------

                    'Query for XY Max / Min
                    Dim propQueriesTableAdapter As propertyScout.PROP_DATADataSetTableAdapters.QueriesTableAdapter = New propertyScout.PROP_DATADataSetTableAdapters.QueriesTableAdapter()

                    XmaxAddressReturn = CType(propQueriesTableAdapter.XmaxAddressQuery(strSearch), Integer)
                    XminAddressReturn = CType(propQueriesTableAdapter.XminAddressQuery(strSearch), Integer)
                    YmaxAddressReturn = CType(propQueriesTableAdapter.YmaxAddressQuery(strSearch), Integer)
                    YminAddressReturn = CType(propQueriesTableAdapter.YminAddressQuery(strSearch), Integer)

                    'Construct envelope
                    searchEnvelope.XMax = XmaxAddressReturn
                    searchEnvelope.XMin = XminAddressReturn
                    searchEnvelope.YMax = YmaxAddressReturn
                    searchEnvelope.YMin = YminAddressReturn

                    'Check if valid locale: Show the record, pan to location and set down a pin
                    If XmaxAddressReturn > 0 Then

                        'Show the datagrid containing the property record, and update coords formatting
                        propertyGrid.Visibility = Windows.Visibility.Visible
                        stkCoords.Margin = New System.Windows.Thickness(0, 0, 12, 70)

                        'Pan to it
                        map.Extent = searchEnvelope

                        'Set graphicsLayer (pinpoint)
                        Dim graphicsLayer As GraphicsLayer = TryCast(map.Layers("graphicsLayer"), GraphicsLayer)
                        graphicsLayer.Graphics.Clear()
                        Dim graphic As New ESRI.ArcGIS.Client.Graphic() With { _
                         .Geometry = map.Extent.GetCenter(), _
                         .Symbol = TryCast(LayoutRoot.Resources("DefaultPictureSymbol"), ESRI.ArcGIS.Client.Symbols.Symbol) _
                        }
                        graphicsLayer.Graphics.Add(graphic)

                        ''Zoom in
                        'map.Zoom(1)

                    Else
                        'Alert the Invalid Address Search
                        MessageBox.Show("This is not a valid Address")
                    End If

                End If

                'Move Most Current Data to First
                Dim PROP_DATAViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("PROP_DATAViewSource"), System.Windows.Data.CollectionViewSource)
                PROP_DATAViewSource.View.MoveCurrentToFirst()

            End If

        Catch ex As Exception
            'Alert any errors with Property Search
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'onMouseMove, capture the map extent, format and populate the coordinates display
    Private Sub map_MouseMove(sender As System.Object, e As System.Windows.Input.MouseEventArgs) Handles map.MouseMove

        XMin = Format(Double.Parse(map.Extent.XMin), "F0")
        YMin = Format(Double.Parse(map.Extent.YMin), "F0")
        XMax = Format(Double.Parse(map.Extent.XMax), "F0")
        YMax = Format(Double.Parse(map.Extent.YMax), "F0")

        txtExtent_XMin.Content = "XMin: " & XMin.ToString("F0")
        txtExtent_YMin.Content = "YMin: " & YMin.ToString("F0")
        txtExtent_XMax.Content = "XMax: " & XMax.ToString("F0")
        txtExtent_YMax.Content = "YMax: " & YMax.ToString("F0")

    End Sub

    'Map - onClick
    Private Sub map_MouseClick(sender As System.Object, e As ESRI.ArcGIS.Client.Map.MouseEventArgs) Handles map.MouseClick

        'Set clickPoint as map point X and Y
        Dim clickPoint As ESRI.ArcGIS.Client.Geometry.MapPoint = e.MapPoint

        'Set identifyParams 
        Dim identifyParams As ESRI.ArcGIS.Client.Tasks.IdentifyParameters = New IdentifyParameters() With { _
         .Geometry = clickPoint, _
         .MapExtent = map.Extent, _
         .Width = CInt(Math.Truncate(map.ActualWidth)), _
         .Height = CInt(Math.Truncate(map.ActualHeight)), _
         .LayerOption = LayerOption.visible, _
         .SpatialReference = map.SpatialReference _
        }

        'Set identifyTask to point to ESRI Census Service 
        Dim identifyTask As New IdentifyTask("http://sampleserver1.arcgisonline.com/ArcGIS/rest/services/" & "Demographics/ESRI_Census_USA/MapServer")
        AddHandler identifyTask.ExecuteCompleted, AddressOf identifyTaskExecuteCompleted
        AddHandler identifyTask.Failed, AddressOf identifyTaskFailed
        identifyTask.ExecuteAsync(identifyParams)

        'Set graphicsLayer (pinpoint)
        ' Dim graphicsLayer As GraphicsLayer = TryCast(map.Layers("graphicsLayer"), GraphicsLayer)
        graphicsLayer = TryCast(map.Layers("graphicsLayer"), GraphicsLayer)
        graphicsLayer.Graphics.Clear()
        Dim graphic As New ESRI.ArcGIS.Client.Graphic() With { _
         .Geometry = clickPoint, _
         .Symbol = TryCast(LayoutRoot.Resources("DefaultPictureSymbol"), ESRI.ArcGIS.Client.Symbols.Symbol) _
        }
        graphicsLayer.Graphics.Add(graphic)

    End Sub

    'Show features - gets called by the -IdentifyTask_ExecuteCompleted- method to add resulting data
    'items to the data grid contol
    Public Sub showFeatures(results As List(Of IdentifyResult))
        _dataItems = New List(Of DataItem)()

        If results IsNot Nothing AndAlso results.Count > 0 Then
            cmbIdentify.Items.Clear()
            For Each result As IdentifyResult In results
                Dim feature As Graphic = result.Feature
                Dim title As String = result.Value.ToString() & " (" & result.LayerName & ")"
                _dataItems.Add(New DataItem() With { _
                 .Title = title, _
                 .Data = feature.Attributes _
                })
                cmbIdentify.Items.Add(title)
            Next

            ' Workaround for bug with ComboBox 
            cmbIdentify.UpdateLayout()
            cmbIdentify.SelectedIndex = 0
        End If
    End Sub

    'Identify combo box item change
    Private Sub cmbIdentify_SelectionChanged(sender As System.Object, e As System.Windows.Controls.SelectionChangedEventArgs) Handles cmbIdentify.SelectionChanged
        Dim index As Integer = cmbIdentify.SelectedIndex
        If index > -1 Then
            IdentifyDetailsDataGrid.ItemsSource = _dataItems(index).Data
        End If
    End Sub

    'If Select Property Succeeds (show results)
    Private Sub identifyTaskExecuteCompleted(sender As Object, args As IdentifyEventArgs)
        IdentifyDetailsDataGrid.ItemsSource = Nothing

        If args.IdentifyResults IsNot Nothing AndAlso args.IdentifyResults.Count > 0 Then
            IdentifyResultsPanel.Visibility = Visibility.Visible

            showFeatures(args.IdentifyResults)
        Else
            cmbIdentify.Items.Clear()
            cmbIdentify.UpdateLayout()

            IdentifyResultsPanel.Visibility = Visibility.Collapsed
        End If
    End Sub

    'If Select Property Fails
    Private Sub identifyTaskFailed(sender As Object, e As TaskFailedEventArgs)
        System.Windows.MessageBox.Show("Identify failed. Error: " & Convert.ToString(e.[Error]))
    End Sub

    'Updates the map layers to last user selections (gets called onLoad)
    Private Sub mapDefaults()

        '--------------------------------
        '--------------------------------
        'onLoad: Get and Display current default map (enRoute map update)
        Try
            'Check for default.txt in bin/debug
            If System.IO.File.Exists("default.txt") = True Then

                Dim objReader As New System.IO.StreamReader("default.txt")
                lblCurrentMap.Content = objReader.ReadToEnd 'current map
                objReader.Close()

            Else
                MsgBox("File Does Not Exist")
            End If

        Catch ex As Exception
            'Alert any errors
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------
        '--------------------------------


        'Set defaultMap to the current Map label content, trim any whitespace
        defaultMap = lblCurrentMap.Content.ToString().Trim()

        'Instantiate and set maps
        Dim basemap As New ESRI.ArcGIS.Client.ArcGISTiledMapServiceLayer
        Dim graphicsLayer As ESRI.ArcGIS.Client.Layer = map.Layers("graphicsLayer")
        Dim parcelLayer As ESRI.ArcGIS.Client.Layer = map.Layers("AssessorLayer")
        Dim transportLayer As ESRI.ArcGIS.Client.Layer = map.Layers("TransportationLayer")

        'Clear out current layers, set new layer url & add to map (according to saved map as string in default.txt)
        Select Case defaultMap
            Case "Fall 07"
                'Service Removed
            Case "Fall 08"
                'Service Removed
            Case "Fall 09"
                'Service Removed
            Case "Most Current Flight"
                'Service Removed
            Case "NAIP 2010"
                'Service Removed
            Case "Ortho 90"
                'Service Removed
            Case "Ortho 96"
                'Service Removed
            Case "SNWA Fall 10"
                'Service Removed
            Case "SNWA Spring 11"
                'Service Removed
            Case "Spring 00"
                'Service Removed
            Case "Spring 01"
                'Service Removed
            Case "Spring 02"
                'Service Removed
            Case "Spring 03"
                'Service Removed
            Case "Spring 04"
                'Service Removed
            Case "Spring 05"
                'Service Removed
            Case "Spring 06"
                'Service Removed
            Case "Spring 07"
                'Service Removed
            Case "Spring 08"
                'Service Removed
            Case "Spring 2009"
                'Service Removed
            Case "Spring 2012"
                'Service Removed
            Case Else
                'Alert
                MessageBox.Show("Please select a Valid Map.", "Map Change",
                                Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information)
        End Select

    End Sub

    'Custom class for DataItem---------------
    Public Class DataItem
        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = value
            End Set
        End Property
        Private m_Title As String
        Public Property Data() As IDictionary(Of String, Object)
            Get
                Return m_Data
            End Get
            Set(value As IDictionary(Of String, Object))
                m_Data = value
            End Set
        End Property
        Private m_Data As IDictionary(Of String, Object)
    End Class

    'Navigation------------------------------
    'Show the Display Form
    Private Sub btnDisplay_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnDisplay.Click
        'Show Display Form, give map | coords | map date
        Dim frmDisplay As New frmDisplay
        frmDisplay.theMap = map
        frmDisplay.extentCoords = stkCoords
        frmDisplay.lblDate = lblCurrentMap
        frmDisplay.StartPosition = Forms.FormStartPosition.CenterScreen
        frmDisplay.Show()
    End Sub
    'Show the Resources Form
    Private Sub btnResources_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnResources.Click
        Dim frmResources = New frmResources()
        frmResources.StartPosition = Forms.FormStartPosition.CenterScreen
        frmResources.Show()
    End Sub
    'Show the Login (en route to Admin) Form
    Private Sub btnAdmin_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnAdmin.Click
        'Show Admin Form, give coords
        Dim frmLogin As New frmLogin
        frmLogin.val_XMin = Me.txtExtent_XMin.Content
        frmLogin.val_YMin = Me.txtExtent_YMin.Content
        frmLogin.val_XMax = Me.txtExtent_XMax.Content
        frmLogin.val_YMax = Me.txtExtent_YMax.Content
        frmLogin.StartPosition = Forms.FormStartPosition.CenterScreen
        frmLogin.Show()
    End Sub
End Class