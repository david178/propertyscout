<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisReturn = New System.Windows.Forms.Button()
        Me.cboMaps = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.chkParcel = New System.Windows.Forms.CheckBox()
        Me.chkTransportation = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpUI = New System.Windows.Forms.GroupBox()
        Me.chkCoords = New System.Windows.Forms.CheckBox()
        Me.lblDefaultMap = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpUI.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Display"
        '
        'btnDisReturn
        '
        Me.btnDisReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisReturn.Location = New System.Drawing.Point(439, 300)
        Me.btnDisReturn.Name = "btnDisReturn"
        Me.btnDisReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnDisReturn.TabIndex = 4
        Me.btnDisReturn.Text = "&Return"
        Me.btnDisReturn.UseVisualStyleBackColor = True
        '
        'cboMaps
        '
        Me.cboMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMaps.FormattingEnabled = True
        Me.cboMaps.Location = New System.Drawing.Point(62, 33)
        Me.cboMaps.Name = "cboMaps"
        Me.cboMaps.Size = New System.Drawing.Size(138, 189)
        Me.cboMaps.Sorted = True
        Me.cboMaps.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(206, 157)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 30)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(206, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(206, 123)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "&Select Current"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(59, 225)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(132, 13)
        Me.lblRange.TabIndex = 8
        Me.lblRange.Text = "Available: Spr 2012 - 1990"
        '
        'chkParcel
        '
        Me.chkParcel.AutoSize = True
        Me.chkParcel.Location = New System.Drawing.Point(24, 35)
        Me.chkParcel.Name = "chkParcel"
        Me.chkParcel.Size = New System.Drawing.Size(56, 17)
        Me.chkParcel.TabIndex = 9
        Me.chkParcel.Text = "Parcel"
        Me.chkParcel.UseVisualStyleBackColor = True
        '
        'chkTransportation
        '
        Me.chkTransportation.AutoSize = True
        Me.chkTransportation.Location = New System.Drawing.Point(24, 58)
        Me.chkTransportation.Name = "chkTransportation"
        Me.chkTransportation.Size = New System.Drawing.Size(94, 17)
        Me.chkTransportation.TabIndex = 10
        Me.chkTransportation.Text = "Transportation"
        Me.chkTransportation.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkParcel)
        Me.GroupBox1.Controls.Add(Me.chkTransportation)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 107)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Layers"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.cboMaps)
        Me.GroupBox2.Controls.Add(Me.lblRange)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 259)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basemaps"
        '
        'grpUI
        '
        Me.grpUI.Controls.Add(Me.chkCoords)
        Me.grpUI.Location = New System.Drawing.Point(387, 197)
        Me.grpUI.Name = "grpUI"
        Me.grpUI.Size = New System.Drawing.Size(145, 76)
        Me.grpUI.TabIndex = 12
        Me.grpUI.TabStop = False
        Me.grpUI.Text = "UI"
        '
        'chkCoords
        '
        Me.chkCoords.AutoSize = True
        Me.chkCoords.Location = New System.Drawing.Point(24, 35)
        Me.chkCoords.Name = "chkCoords"
        Me.chkCoords.Size = New System.Drawing.Size(82, 17)
        Me.chkCoords.TabIndex = 9
        Me.chkCoords.Text = "Coordinates"
        Me.chkCoords.UseVisualStyleBackColor = True
        '
        'lblDefaultMap
        '
        Me.lblDefaultMap.AutoSize = True
        Me.lblDefaultMap.Location = New System.Drawing.Point(436, 11)
        Me.lblDefaultMap.Name = "lblDefaultMap"
        Me.lblDefaultMap.Size = New System.Drawing.Size(65, 13)
        Me.lblDefaultMap.TabIndex = 13
        Me.lblDefaultMap.Text = "Default Map"
        '
        'frmDisplay
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 342)
        Me.Controls.Add(Me.lblDefaultMap)
        Me.Controls.Add(Me.grpUI)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisReturn)
        Me.Name = "frmDisplay"
        Me.Text = "Display"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpUI.ResumeLayout(False)
        Me.grpUI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDisReturn As System.Windows.Forms.Button
    Friend WithEvents cboMaps As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents chkParcel As System.Windows.Forms.CheckBox
    Friend WithEvents chkTransportation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpUI As System.Windows.Forms.GroupBox
    Friend WithEvents chkCoords As System.Windows.Forms.CheckBox
    Friend WithEvents lblDefaultMap As System.Windows.Forms.Label
End Class
