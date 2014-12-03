<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.btnAdminReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQueryAll = New System.Windows.Forms.Button()
        Me.btnQueryByParcel = New System.Windows.Forms.Button()
        Me.btnQueryByAddress = New System.Windows.Forms.Button()
        Me.rchStatus = New System.Windows.Forms.RichTextBox()
        Me.PROP_DATADataSet = New propertyScout.PROP_DATADataSet()
        Me.PROP_DATABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROP_DATATableAdapter = New propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter()
        Me.TableAdapterManager = New propertyScout.PROP_DATADataSetTableAdapters.TableAdapterManager()
        Me.PROP_DATABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PROP_DATABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PROP_DATADataGridView = New System.Windows.Forms.DataGridView()
        Me.btnQueryByOwner = New System.Windows.Forms.Button()
        Me.btnAddExtent = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PROP_DATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROP_DATABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROP_DATABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PROP_DATABindingNavigator.SuspendLayout()
        CType(Me.PROP_DATADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdminReturn
        '
        Me.btnAdminReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminReturn.Location = New System.Drawing.Point(709, 395)
        Me.btnAdminReturn.Name = "btnAdminReturn"
        Me.btnAdminReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnAdminReturn.TabIndex = 6
        Me.btnAdminReturn.Text = "&Return"
        Me.btnAdminReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin"
        '
        'btnQueryAll
        '
        Me.btnQueryAll.Location = New System.Drawing.Point(12, 395)
        Me.btnQueryAll.Name = "btnQueryAll"
        Me.btnQueryAll.Size = New System.Drawing.Size(100, 30)
        Me.btnQueryAll.TabIndex = 1
        Me.btnQueryAll.Text = "&All"
        Me.btnQueryAll.UseVisualStyleBackColor = True
        '
        'btnQueryByParcel
        '
        Me.btnQueryByParcel.Location = New System.Drawing.Point(118, 395)
        Me.btnQueryByParcel.Name = "btnQueryByParcel"
        Me.btnQueryByParcel.Size = New System.Drawing.Size(100, 30)
        Me.btnQueryByParcel.TabIndex = 2
        Me.btnQueryByParcel.Text = "By &Parcel"
        Me.btnQueryByParcel.UseVisualStyleBackColor = True
        '
        'btnQueryByAddress
        '
        Me.btnQueryByAddress.Location = New System.Drawing.Point(224, 395)
        Me.btnQueryByAddress.Name = "btnQueryByAddress"
        Me.btnQueryByAddress.Size = New System.Drawing.Size(100, 30)
        Me.btnQueryByAddress.TabIndex = 3
        Me.btnQueryByAddress.Text = "By A&ddress"
        Me.btnQueryByAddress.UseVisualStyleBackColor = True
        '
        'rchStatus
        '
        Me.rchStatus.Location = New System.Drawing.Point(687, 57)
        Me.rchStatus.Name = "rchStatus"
        Me.rchStatus.Size = New System.Drawing.Size(114, 332)
        Me.rchStatus.TabIndex = 10
        Me.rchStatus.Text = ""
        '
        'PROP_DATADataSet
        '
        Me.PROP_DATADataSet.DataSetName = "PROP_DATADataSet"
        Me.PROP_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROP_DATABindingSource
        '
        Me.PROP_DATABindingSource.DataMember = "PROP_DATA"
        Me.PROP_DATABindingSource.DataSource = Me.PROP_DATADataSet
        '
        'PROP_DATATableAdapter
        '
        Me.PROP_DATATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PROP_DATATableAdapter = Me.PROP_DATATableAdapter
        Me.TableAdapterManager.UpdateOrder = propertyScout.PROP_DATADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PROP_DATABindingNavigator
        '
        Me.PROP_DATABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PROP_DATABindingNavigator.BindingSource = Me.PROP_DATABindingSource
        Me.PROP_DATABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PROP_DATABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PROP_DATABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PROP_DATABindingNavigatorSaveItem})
        Me.PROP_DATABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PROP_DATABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PROP_DATABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PROP_DATABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PROP_DATABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PROP_DATABindingNavigator.Name = "PROP_DATABindingNavigator"
        Me.PROP_DATABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PROP_DATABindingNavigator.Size = New System.Drawing.Size(821, 25)
        Me.PROP_DATABindingNavigator.TabIndex = 12
        Me.PROP_DATABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PROP_DATABindingNavigatorSaveItem
        '
        Me.PROP_DATABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PROP_DATABindingNavigatorSaveItem.Image = CType(resources.GetObject("PROP_DATABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PROP_DATABindingNavigatorSaveItem.Name = "PROP_DATABindingNavigatorSaveItem"
        Me.PROP_DATABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PROP_DATABindingNavigatorSaveItem.Text = "Save Data"
        '
        'PROP_DATADataGridView
        '
        Me.PROP_DATADataGridView.AutoGenerateColumns = False
        Me.PROP_DATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PROP_DATADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PROP_DATADataGridView.DataSource = Me.PROP_DATABindingSource
        Me.PROP_DATADataGridView.Location = New System.Drawing.Point(12, 57)
        Me.PROP_DATADataGridView.Name = "PROP_DATADataGridView"
        Me.PROP_DATADataGridView.Size = New System.Drawing.Size(669, 332)
        Me.PROP_DATADataGridView.TabIndex = 0
        '
        'btnQueryByOwner
        '
        Me.btnQueryByOwner.Location = New System.Drawing.Point(330, 395)
        Me.btnQueryByOwner.Name = "btnQueryByOwner"
        Me.btnQueryByOwner.Size = New System.Drawing.Size(100, 30)
        Me.btnQueryByOwner.TabIndex = 4
        Me.btnQueryByOwner.Text = "By &Owner"
        Me.btnQueryByOwner.UseVisualStyleBackColor = True
        '
        'btnAddExtent
        '
        Me.btnAddExtent.Location = New System.Drawing.Point(581, 395)
        Me.btnAddExtent.Name = "btnAddExtent"
        Me.btnAddExtent.Size = New System.Drawing.Size(100, 30)
        Me.btnAddExtent.TabIndex = 5
        Me.btnAddExtent.Text = "Add &Extent"
        Me.btnAddExtent.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(723, 35)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 18)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Status"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Parcel"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Parcel"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Owner"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Owner"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Acres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Acres"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Xmax"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Xmax"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Xmin"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Xmin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ymax"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ymax"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ymin"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ymin"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'frmAdmin
        '
        Me.AcceptButton = Me.btnQueryAll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 437)
        Me.Controls.Add(Me.btnAddExtent)
        Me.Controls.Add(Me.btnQueryByOwner)
        Me.Controls.Add(Me.PROP_DATADataGridView)
        Me.Controls.Add(Me.PROP_DATABindingNavigator)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rchStatus)
        Me.Controls.Add(Me.btnQueryByAddress)
        Me.Controls.Add(Me.btnQueryByParcel)
        Me.Controls.Add(Me.btnQueryAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdminReturn)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.PROP_DATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROP_DATABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROP_DATABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PROP_DATABindingNavigator.ResumeLayout(False)
        Me.PROP_DATABindingNavigator.PerformLayout()
        CType(Me.PROP_DATADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdminReturn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQueryAll As System.Windows.Forms.Button
    Friend WithEvents btnQueryByParcel As System.Windows.Forms.Button
    Friend WithEvents btnQueryByAddress As System.Windows.Forms.Button
    Friend WithEvents rchStatus As System.Windows.Forms.RichTextBox
    Friend WithEvents PROP_DATADataSet As propertyScout.PROP_DATADataSet
    Friend WithEvents PROP_DATABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROP_DATATableAdapter As propertyScout.PROP_DATADataSetTableAdapters.PROP_DATATableAdapter
    Friend WithEvents TableAdapterManager As propertyScout.PROP_DATADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROP_DATABindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PROP_DATABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PROP_DATADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnQueryByOwner As System.Windows.Forms.Button
    Friend WithEvents btnAddExtent As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
