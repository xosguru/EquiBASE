<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EquipmentInventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EquipmentInventoryForm))
        Me.EquipmentInventoryLabel = New System.Windows.Forms.Label()
        Me.EquipmentInventoryGridView = New System.Windows.Forms.DataGridView()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        CType(Me.EquipmentInventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EquipmentInventoryLabel
        '
        Me.EquipmentInventoryLabel.AutoSize = True
        Me.EquipmentInventoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentInventoryLabel.Location = New System.Drawing.Point(10, 78)
        Me.EquipmentInventoryLabel.Name = "EquipmentInventoryLabel"
        Me.EquipmentInventoryLabel.Size = New System.Drawing.Size(231, 29)
        Me.EquipmentInventoryLabel.TabIndex = 0
        Me.EquipmentInventoryLabel.Text = "Equipment Inventory"
        '
        'EquipmentInventoryGridView
        '
        Me.EquipmentInventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EquipmentInventoryGridView.CausesValidation = False
        Me.EquipmentInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EquipmentInventoryGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.EquipmentInventoryGridView.Location = New System.Drawing.Point(10, 122)
        Me.EquipmentInventoryGridView.MultiSelect = False
        Me.EquipmentInventoryGridView.Name = "EquipmentInventoryGridView"
        Me.EquipmentInventoryGridView.ReadOnly = True
        Me.EquipmentInventoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.EquipmentInventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EquipmentInventoryGridView.Size = New System.Drawing.Size(1247, 600)
        Me.EquipmentInventoryGridView.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(1139, 29)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(120, 59)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'LogoBox
        '
        Me.LogoBox.Enabled = False
        Me.LogoBox.Image = CType(resources.GetObject("LogoBox.Image"), System.Drawing.Image)
        Me.LogoBox.Location = New System.Drawing.Point(10, 20)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(155, 40)
        Me.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoBox.TabIndex = 8
        Me.LogoBox.TabStop = False
        '
        'EquipmentInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 731)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.EquipmentInventoryGridView)
        Me.Controls.Add(Me.EquipmentInventoryLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EquipmentInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipment Inventory"
        CType(Me.EquipmentInventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EquipmentInventoryLabel As Label
    Friend WithEvents EquipmentInventoryGridView As DataGridView
    Friend WithEvents CloseButton As Button
    Friend WithEvents LogoBox As PictureBox
End Class
