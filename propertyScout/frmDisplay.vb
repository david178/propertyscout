'---------------------------------------------------------------
' Purpose: Updates the Map and UI Display
' Author: Mohammad Badrzadeh,  Sana Chatoor,  Thapanon Srisuwande,  David Titus,  Shangjun Wang 
' Date: 12/1/14
' Version: 2.079
' Input: Map Date
' Output: New Map Date Added to Collection, Map Date label
'---------------------------------------------------------------

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.IO
Imports ESRI.ArcGIS.Client
Imports ESRI.ArcGIS.Client.Tasks
Imports System.Windows.Forms

Public Class frmDisplay

    'Declare
    Dim strMap As String
    Dim arrText As New ArrayList()
    Dim selectedMap As String
    'Map
    Public Property theMap As Map
    Public Property extentCoords As StackPanel
    Public Property lblDate As System.Windows.Controls.Label
    Dim graphicsLayer As ESRI.ArcGIS.Client.Layer
    Dim parcelLayer As ESRI.ArcGIS.Client.Layer
    Dim transportLayer As ESRI.ArcGIS.Client.Layer

    'Commit changes to text file in bin/debug
    Private Sub frmDisplay_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        '--------------------------------
        '--------------------------------
        'onClose: Write to mapDisplay_Stripped

        'Declare
        Dim i As Integer
        'Declare a new StreamWriter as outFile
        Dim outFile As IO.StreamWriter

        Try
            outFile = IO.File.CreateText("mapDisplay_Stripped.txt")

            'For each of the items now in cboMovies, write the new items to save
            For i = 0 To cboMaps.Items.Count - 1

                'Write each line item of the cboMovies array
                outFile.WriteLine(cboMaps.Items(i))

            Next

            'Close
            outFile.Close()

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------
        '--------------------------------

    End Sub

    'Load map layers text file on load from bin/debug
    Private Sub frmDisplay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '--------------------------------
        '--------------------------------
        'onLoad: Get and Display current default map (enRoute label update)
        Try

            If System.IO.File.Exists("default.txt") = True Then

                Dim objReader As New System.IO.StreamReader("default.txt")
                lblDefaultMap.Text = objReader.ReadToEnd 'current map
                objReader.Close()

            Else
                lblDefaultMap.Text = "File Does Not Exist"
            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------
        '--------------------------------


        'Set the Parcel & Assessor variables
        graphicsLayer = theMap.Layers("graphicsLayer")
        parcelLayer = theMap.Layers("AssessorLayer")
        transportLayer = theMap.Layers("TransportationLayer")

        'Update default map layer checkbox values according to object current visibility
        If extentCoords.IsVisible = True Then
            chkCoords.Checked = True
        End If
        If parcelLayer.Visible = True Then
            chkParcel.Checked = True
        End If

        If transportLayer.Visible = True Then
            chkTransportation.Checked = True
        End If




        '--------------------------------
        '--------------------------------
        'onLoad: Open and Populate drop down with current maps by date

        'Declare
        Dim inFile As IO.StreamReader

        Try

            'Check if exists
            If IO.File.Exists("mapDisplay_Stripped.txt") Then

                'Open the mapDisplay_Stripped.txt
                inFile = IO.File.OpenText("mapDisplay_Stripped.txt")

                'Read and construct the array of strings from start to end of movie items in MyMovie.txt
                Do Until inFile.Peek = -1
                    strMap = inFile.ReadLine()
                    arrText.Add(strMap)
                Loop

                'Close
                inFile.Close()

                'Add each Movie in the array as an item in cboMovies
                For Each strMap In arrText
                    cboMaps.Items.Add(strMap)
                Next

            Else

                'Alert the error
                MessageBox.Show("Unable to Locate file", "Maps",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------
        '--------------------------------

    End Sub

    'Add a new map layer to the list and text file
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Try

            'Check if entry is empty
            If cboMaps.Text = "" Then

                'Alert the error
                MessageBox.Show("Please enter a Map by Date.", "Maps",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                'Check if attempted entry is a duplicate
                For Each cboItem As Object In cboMaps.Items
                    If cboItem.ToString().Contains(cboMaps.Text) Then

                        'Alert the error
                        MessageBox.Show("Duplicate title", "Maps",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Exit
                        Return
                    End If
                Next

                'Add text entry to combobox list 
                cboMaps.Items.Add(cboMaps.Text)

                'Clear
                cboMaps.Text = ""

            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Remove the current layer from the Combobox & commit changes to text file
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        'Remove the currently selected entry from the cboMovies items
        cboMaps.Items.Remove(cboMaps.Text)

    End Sub

    'Select current map layer to update the map
    Public Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click

        '--------------------------------
        '--------------------------------
        'onSelect: Update the saved map to -default.txt-
        Try

            'Check if entry is empty
            If cboMaps.Text = "" Then

                'Alert the error
                MessageBox.Show("Please enter a Map by Date.", "Maps",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                'Declare a new StreamWriter as outFile
                Dim outFile As IO.StreamWriter
                outFile = IO.File.CreateText("default.txt")

                'Write each line item of the cboMovies array
                outFile.WriteLine(cboMaps.Text)

                'Close
                outFile.Close()

            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try
        '--------------------------------
        '--------------------------------



        Try
            'Instantiate and set maps
            Dim basemap As New ESRI.ArcGIS.Client.ArcGISTiledMapServiceLayer


            'Set selectedMap as the drop down selected item
            selectedMap = cboMaps.SelectedItem.ToString()
            'Update the current map date label on both the Current Display Form and MainWindow
            lblDefaultMap.Text = selectedMap
            lblDate.Content = selectedMap

            'Clear out current layers, set new layer url & add to map
            Select Case selectedMap
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
                Case Else 'Alert an Invalid Map Selection
                    MessageBox.Show("Please select a Valid Map.", "Map Change",
                                    Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information)
            End Select

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Parcel check state evaluation to update map layer
    Private Sub chkParcel_Click(sender As System.Object, e As System.EventArgs) Handles chkParcel.Click

        Try
            If chkParcel.Checked = True Then
                parcelLayer.Visible = True
            Else
                parcelLayer.Visible = False
            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Transporation check state evaluation to update map layer
    Private Sub chkTransportation_Click(sender As System.Object, e As System.EventArgs) Handles chkTransportation.Click

        Try
            If chkTransportation.Checked = True Then
                transportLayer.Visible = True
            Else
                transportLayer.Visible = False
            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Show / Hide the map coordinates
    Private Sub chkCoords_Click(sender As System.Object, e As System.EventArgs) Handles chkCoords.Click

        Try
            'Set if checkbox checked
            If chkCoords.Checked = True Then
                extentCoords.Visibility = Visibility.Visible
            Else
                extentCoords.Visibility = Visibility.Hidden
            End If

        Catch ex As Exception 'Alert Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Return
    Private Sub btnDisReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnDisReturn.Click
        Me.Close()
    End Sub

End Class