'---------------------------------------------------------------
' Purpose: Displays Quick Reference Material
' Author: Mohammad Badrzadeh,  Sana Chatoor,  Thapanon Srisuwande,  David Titus,  Shangjun Wang 
' Date: 12/1/14
' Version: 2.079
' Input: N/A
' Output: Quick Reference Guide
'---------------------------------------------------------------

Public Class frmResources

    'View Quick Reference Guide
    Private Sub btnQuickGuide_Click(sender As System.Object, e As System.EventArgs) Handles btnQuickGuide.Click

        System.Diagnostics.Process.Start("Quick_Guide.pdf")

    End Sub

    'Return
    Private Sub btnResReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnResReturn.Click
        Me.Close()
    End Sub

End Class