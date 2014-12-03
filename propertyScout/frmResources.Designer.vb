<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResources
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnQuickGuide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuickGuide
        '
        Me.btnQuickGuide.Location = New System.Drawing.Point(81, 85)
        Me.btnQuickGuide.Name = "btnQuickGuide"
        Me.btnQuickGuide.Size = New System.Drawing.Size(123, 30)
        Me.btnQuickGuide.TabIndex = 0
        Me.btnQuickGuide.Text = "&QuickGuide.pdf"
        Me.btnQuickGuide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Resources"
        '
        'btnResReturn
        '
        Me.btnResReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResReturn.Location = New System.Drawing.Point(172, 165)
        Me.btnResReturn.Name = "btnResReturn"
        Me.btnResReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnResReturn.TabIndex = 1
        Me.btnResReturn.Text = "Return"
        Me.btnResReturn.UseVisualStyleBackColor = True
        '
        'frmResources
        '
        Me.AcceptButton = Me.btnQuickGuide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 207)
        Me.Controls.Add(Me.btnQuickGuide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnResReturn)
        Me.Name = "frmResources"
        Me.Text = "Resources"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuickGuide As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnResReturn As System.Windows.Forms.Button
End Class
