'---------------------------------------------------------------
' Purpose: Admin CRUD Operations
' Author: Mohammad Badrzadeh,  Sana Chatoor,  Thapanon Srisuwande,  David Titus,  Shangjun Wang 
' Date: 12/1/14
' Version: 2.079
' Input: Parcel #, Address, Owner, Acres, X / Y Max & Min, Property Description
' Output: Newly added property records committed to database, Success / Error Status Messages
'---------------------------------------------------------------

Imports System.Windows.Forms

Public Class frmAdmin

    'Declare
    Const strFORMAT As String = "{\rtf1\ansi\b"
    Const strSUCCESS As String = "[Success]: "
    Const strERROR As String = "[Error]: "
    Dim intParcelNumRandom As Integer
    Dim rng As New Random
    Public Property val_XMin As String 'MainWindow coords
    Public Property val_YMin As String 'MainWindow coords
    Public Property val_XMax As String 'MainWindow coords
    Public Property val_YMax As String 'MainWindow coords
    Dim strConvXmin As String
    Dim strConvYmin As String
    Dim strConvXmax As String
    Dim strConvYmax As String

    'onLoad: Populate the table with data from PROP_DATA
    Private Sub frmAdmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            'Load data into the 'PROP_DATADataSet.PROP_DATA' table
            Me.PROP_DATATableAdapter.Fill(Me.PROP_DATADataSet.PROP_DATA)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Load All Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Load All Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Show All Records
    Private Sub btnQueryAll_Click(sender As System.Object, e As System.EventArgs) Handles btnQueryAll.Click

        Try
            'loads data into the datagridview from the Data Set
            Me.PROP_DATATableAdapter.Fill(Me.PROP_DATADataSet.PROP_DATA)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Query All Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Query All Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Query by Parcel# 1 for 1 match
    Private Sub btnQueryByParcel_Click(sender As System.Object, e As System.EventArgs) Handles btnQueryByParcel.Click

        Try
            'declare Parcel
            Dim strParcel As String
            'Display InputBox to capture Parcel #
            strParcel = InputBox("Please enter the Parcel", "Query by Parcel")
            'Display corresponding db records whose Parcel field matches
            PROP_DATATableAdapter.FillByParcel(PROP_DATADataSet.PROP_DATA, strParcel)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Query Parcel Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Query Parcel Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Query by Address LIKE
    Private Sub btnQueryByAddress_Click(sender As System.Object, e As System.EventArgs) Handles btnQueryByAddress.Click

        Try
            'declare Address
            Dim strAddress As String
            'Display InputBox to capture Address characters
            strAddress = InputBox("Please enter the Address", "Query by Address")
            'Display corresponding db records whose Address field contains LIKE characters
            PROP_DATATableAdapter.FillByAddress(PROP_DATADataSet.PROP_DATA, strAddress)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Query Address Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Query Address Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Query by Owner LIKE
    Private Sub btnQueryByOwner_Click(sender As System.Object, e As System.EventArgs) Handles btnQueryByOwner.Click

        Try
            'declare Owner
            Dim strOwner As String
            'Display InputBox to capture Patron characters
            strOwner = InputBox("Please enter the Owner", "Query by Owner")
            'Display corresponding db records whose Owner field contains LIKE characters
            PROP_DATATableAdapter.FillByOwner(PROP_DATADataSet.PROP_DATA, strOwner)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Query Owner Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Query Owner Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Add New Record at Current Map Extent
    Public Sub btnAddExtent_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExtent.Click

        Try
            'Prompt for a Property Description to add for current location
            Dim strDescription As String = InputBox("Enter a Description for this location.", "Add at Current Extent", " ")

            If strDescription = " " Then 'If no description was entered
                MessageBox.Show("You must enter a Description.")
                Exit Sub
            ElseIf strDescription = "" Then 'If cancel was entered
                Exit Sub
            Else 'If a description was entered

                'Strip out non-numeric characters for 'Add Extent' pre-fill insertion calls
                strConvXmin = System.Text.RegularExpressions.Regex.Replace(val_XMin, "[^\d]", " ")
                strConvYmin = System.Text.RegularExpressions.Regex.Replace(val_YMin, "[^\d]", " ")
                strConvXmax = System.Text.RegularExpressions.Regex.Replace(val_XMax, "[^\d]", " ")
                strConvYmax = System.Text.RegularExpressions.Regex.Replace(val_YMax, "[^\d]", " ")

                'Generate Random Parcel #
                Generator()

                'Insert a pre-filled property record using the current map extent
                'Parcel | Owner | Address | Acres | Xmax | Xmin | Ymax | Ymin | Descr
                PROP_DATATableAdapter.Insert(intParcelNumRandom, "", "", 1, strConvXmax, strConvXmin, strConvYmax, strConvYmin, strDescription)

                'Update the DB records to reflect the new addition
                Me.PROP_DATATableAdapter.Fill(Me.PROP_DATADataSet.PROP_DATA)
                '[Status] Update
                rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Add Complete\par" & rchStatus.Rtf & "}"

            End If


        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Ad Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Generates the Random Parcel #: Used for new record pre-fill insertion (1234567891 - 1934567891)
    Private Sub Generator()
        intParcelNumRandom = rng.Next(1234567891, 1934567891)
    End Sub


    'Delete
    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Try
            'Validate for true
            If Me.Validate() = True Then
                '[Status] Update
                rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Delete Complete\par" & rchStatus.Rtf & "}"
            End If
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Delete Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Save
    Private Sub PROP_DATABindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PROP_DATABindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.PROP_DATABindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PROP_DATADataSet)
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strSUCCESS & "\b0 Save Complete\par" & rchStatus.Rtf & "}"
        Catch ex As Exception
            '[Status] Update
            rchStatus.Rtf = strFORMAT & strERROR & "\b0 Save Failed\par" & rchStatus.Rtf & "}"
        End Try

    End Sub

    'Return
    Private Sub btnAdminReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnAdminReturn.Click
        Me.Close()
    End Sub

End Class