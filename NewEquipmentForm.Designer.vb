<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEquipmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewEquipmentForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ManufacturerDropDown = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.MachineNumberLabel = New System.Windows.Forms.Label()
        Me.ManufacturerLabel = New System.Windows.Forms.Label()
        Me.SerialNumberLabel = New System.Windows.Forms.Label()
        Me.MachineNameLabel = New System.Windows.Forms.Label()
        Me.MachineNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MachineNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddManufacturerButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(290, 274)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(105, 70)
        Me.CancelButton.TabIndex = 25
        Me.CancelButton.Text = "Ca&ncel"
        '
        'ManufacturerDropDown
        '
        Me.ManufacturerDropDown.DisplayMember = "ManufacturerName"
        Me.ManufacturerDropDown.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerDropDown.Location = New System.Drawing.Point(286, 108)
        Me.ManufacturerDropDown.Name = "ManufacturerDropDown"
        Me.ManufacturerDropDown.Size = New System.Drawing.Size(235, 24)
        Me.ManufacturerDropDown.TabIndex = 16
        Me.ManufacturerDropDown.ValueMember = "ManufacturerID"
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(416, 274)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(105, 70)
        Me.SaveButton.TabIndex = 19
        Me.SaveButton.Text = "S&ave"
        '
        'MachineNumberLabel
        '
        Me.MachineNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNumberLabel.Location = New System.Drawing.Point(286, 156)
        Me.MachineNumberLabel.Name = "MachineNumberLabel"
        Me.MachineNumberLabel.Size = New System.Drawing.Size(235, 20)
        Me.MachineNumberLabel.TabIndex = 26
        Me.MachineNumberLabel.Text = "Machine Number"
        '
        'ManufacturerLabel
        '
        Me.ManufacturerLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerLabel.Location = New System.Drawing.Point(286, 88)
        Me.ManufacturerLabel.Name = "ManufacturerLabel"
        Me.ManufacturerLabel.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerLabel.TabIndex = 24
        Me.ManufacturerLabel.Text = "Manufacturer"
        '
        'SerialNumberLabel
        '
        Me.SerialNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberLabel.Location = New System.Drawing.Point(10, 159)
        Me.SerialNumberLabel.Name = "SerialNumberLabel"
        Me.SerialNumberLabel.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberLabel.TabIndex = 22
        Me.SerialNumberLabel.Text = "Serial Number"
        '
        'MachineNameLabel
        '
        Me.MachineNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNameLabel.Location = New System.Drawing.Point(10, 88)
        Me.MachineNameLabel.Name = "MachineNameLabel"
        Me.MachineNameLabel.Size = New System.Drawing.Size(235, 20)
        Me.MachineNameLabel.TabIndex = 20
        Me.MachineNameLabel.Text = "Machine Name"
        '
        'MachineNumberTextBox
        '
        Me.MachineNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MachineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MachineNumberTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNumberTextBox.Location = New System.Drawing.Point(286, 178)
        Me.MachineNumberTextBox.MaxLength = 20
        Me.MachineNumberTextBox.Name = "MachineNumberTextBox"
        Me.MachineNumberTextBox.Size = New System.Drawing.Size(235, 20)
        Me.MachineNumberTextBox.TabIndex = 18
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SerialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNumberTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(10, 176)
        Me.SerialNumberTextBox.MaxLength = 20
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberTextBox.TabIndex = 17
        '
        'MachineNameTextBox
        '
        Me.MachineNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MachineNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MachineNameTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNameTextBox.Location = New System.Drawing.Point(10, 108)
        Me.MachineNameTextBox.MaxLength = 30
        Me.MachineNameTextBox.Name = "MachineNameTextBox"
        Me.MachineNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.MachineNameTextBox.TabIndex = 15
        '
        'AddManufacturerButton
        '
        Me.AddManufacturerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddManufacturerButton.Location = New System.Drawing.Point(10, 274)
        Me.AddManufacturerButton.Name = "AddManufacturerButton"
        Me.AddManufacturerButton.Size = New System.Drawing.Size(105, 70)
        Me.AddManufacturerButton.TabIndex = 27
        Me.AddManufacturerButton.Text = "Add &Manufacturer"
        '
        'NewEquipmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.AddManufacturerButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ManufacturerDropDown)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.MachineNumberLabel)
        Me.Controls.Add(Me.ManufacturerLabel)
        Me.Controls.Add(Me.SerialNumberLabel)
        Me.Controls.Add(Me.MachineNameLabel)
        Me.Controls.Add(Me.MachineNumberTextBox)
        Me.Controls.Add(Me.SerialNumberTextBox)
        Me.Controls.Add(Me.MachineNameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewEquipmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Equipment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents ManufacturerDropDown As ComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents MachineNumberLabel As Label
    Friend WithEvents ManufacturerLabel As Label
    Friend WithEvents SerialNumberLabel As Label
    Friend WithEvents MachineNameLabel As Label
    Friend WithEvents MachineNumberTextBox As TextBox
    Friend WithEvents SerialNumberTextBox As TextBox
    Friend WithEvents MachineNameTextBox As TextBox
    Friend WithEvents AddManufacturerButton As Button
End Class
