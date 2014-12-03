'---------------------------------------------------------------
' Purpose: Captures the Password string for Administrative Validation
' Author: Mohammad Badrzadeh,  Sana Chatoor,  Thapanon Srisuwande,  David Titus,  Shangjun Wang 
' Date: 12/1/14
' Version: 2.079
' Input: Password String
' Output: N/A
'---------------------------------------------------------------

Public Class frmLogin

    Public Property val_XMin As String 'MainWindow coords
    Public Property val_YMin As String 'MainWindow coords
    Public Property val_XMax As String 'MainWindow coords
    Public Property val_YMax As String 'MainWindow coords

    'Login onButton Click
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        If txtLogin.Text = "password" Then
            'Hide Curremt, Show Admin Form, give coords
            Me.Hide()
            Dim frmAdmin As New frmAdmin
            frmAdmin.val_XMin = val_XMin
            frmAdmin.val_YMin = val_YMin
            frmAdmin.val_XMax = val_XMax
            frmAdmin.val_YMax = val_YMax
            frmAdmin.StartPosition = Forms.FormStartPosition.CenterScreen
            frmAdmin.Show()
        End If

    End Sub

    'Login onKey
    Private Sub txtLogin_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLogin.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If txtLogin.Text = "password" Then
            'Hide Curremt, Show Admin Form, give coords
                Me.Hide()
                Dim frmAdmin As New frmAdmin
                frmAdmin.val_XMin = val_XMin
                frmAdmin.val_YMin = val_YMin
                frmAdmin.val_XMax = val_XMax
                frmAdmin.val_YMax = val_YMax
                frmAdmin.StartPosition = Forms.FormStartPosition.CenterScreen
                frmAdmin.Show()
            End If

        End If

    End Sub

End Class