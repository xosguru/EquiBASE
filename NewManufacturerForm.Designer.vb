<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewManufacturerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewManufacturerForm))
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ManufacturerEmailLabel = New System.Windows.Forms.Label()
        Me.ManufacturerPhoneLabel = New System.Windows.Forms.Label()
        Me.ManufactuerNameLabel = New System.Windows.Forms.Label()
        Me.ManufacturerSupportEmailTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(290, 274)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(105, 70)
        Me.CancelButton.TabIndex = 34
        Me.CancelButton.Text = "Ca&ncel"
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(416, 274)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(105, 70)
        Me.SaveButton.TabIndex = 31
        Me.SaveButton.Text = "S&ave"
        '
        'ManufacturerEmailLabel
        '
        Me.ManufacturerEmailLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerEmailLabel.Location = New System.Drawing.Point(286, 156)
        Me.ManufacturerEmailLabel.Name = "ManufacturerEmailLabel"
        Me.ManufacturerEmailLabel.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerEmailLabel.TabIndex = 35
        Me.ManufacturerEmailLabel.Text = "Support Email"
        '
        'ManufacturerPhoneLabel
        '
        Me.ManufacturerPhoneLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerPhoneLabel.Location = New System.Drawing.Point(10, 159)
        Me.ManufacturerPhoneLabel.Name = "ManufacturerPhoneLabel"
        Me.ManufacturerPhoneLabel.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerPhoneLabel.TabIndex = 33
        Me.ManufacturerPhoneLabel.Text = "Phone Number"
        '
        'ManufactuerNameLabel
        '
        Me.ManufactuerNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufactuerNameLabel.Location = New System.Drawing.Point(10, 88)
        Me.ManufactuerNameLabel.Name = "ManufactuerNameLabel"
        Me.ManufactuerNameLabel.Size = New System.Drawing.Size(235, 20)
        Me.ManufactuerNameLabel.TabIndex = 32
        Me.ManufactuerNameLabel.Text = "Manufacturer Name"
        '
        'ManufacturerSupportEmailTextBox
        '
        Me.ManufacturerSupportEmailTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ManufacturerSupportEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ManufacturerSupportEmailTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerSupportEmailTextBox.Location = New System.Drawing.Point(286, 178)
        Me.ManufacturerSupportEmailTextBox.MaxLength = 20
        Me.ManufacturerSupportEmailTextBox.Name = "ManufacturerSupportEmailTextBox"
        Me.ManufacturerSupportEmailTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerSupportEmailTextBox.TabIndex = 30
        '
        'ManufacturerPhoneTextBox
        '
        Me.ManufacturerPhoneTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ManufacturerPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ManufacturerPhoneTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerPhoneTextBox.Location = New System.Drawing.Point(10, 176)
        Me.ManufacturerPhoneTextBox.MaxLength = 20
        Me.ManufacturerPhoneTextBox.Name = "ManufacturerPhoneTextBox"
        Me.ManufacturerPhoneTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerPhoneTextBox.TabIndex = 29
        '
        'ManufacturerNameTextBox
        '
        Me.ManufacturerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ManufacturerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ManufacturerNameTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerNameTextBox.Location = New System.Drawing.Point(10, 108)
        Me.ManufacturerNameTextBox.MaxLength = 30
        Me.ManufacturerNameTextBox.Name = "ManufacturerNameTextBox"
        Me.ManufacturerNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerNameTextBox.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'NewManufacturerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ManufacturerEmailLabel)
        Me.Controls.Add(Me.ManufacturerPhoneLabel)
        Me.Controls.Add(Me.ManufactuerNameLabel)
        Me.Controls.Add(Me.ManufacturerSupportEmailTextBox)
        Me.Controls.Add(Me.ManufacturerPhoneTextBox)
        Me.Controls.Add(Me.ManufacturerNameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewManufacturerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Manufacturer Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ManufacturerEmailLabel As Label
    Friend WithEvents ManufacturerPhoneLabel As Label
    Friend WithEvents ManufactuerNameLabel As Label
    Friend WithEvents ManufacturerSupportEmailTextBox As TextBox
    Friend WithEvents ManufacturerPhoneTextBox As TextBox
    Friend WithEvents ManufacturerNameTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
