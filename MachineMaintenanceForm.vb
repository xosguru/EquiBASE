Public Class MachineMaintenanceForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtMachineName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblMachineName As System.Windows.Forms.Label
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents cboManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents txtMNum As System.Windows.Forms.TextBox
    Friend WithEvents lblMNum As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachineMaintenanceForm))
        Me.txtMachineName = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtMNum = New System.Windows.Forms.TextBox()
        Me.lblMachineName = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblMNum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboManufacturer = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMachineName
        '
        Me.txtMachineName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMachineName.Location = New System.Drawing.Point(16, 96)
        Me.txtMachineName.MaxLength = 30
        Me.txtMachineName.Name = "txtMachineName"
        Me.txtMachineName.Size = New System.Drawing.Size(225, 20)
        Me.txtMachineName.TabIndex = 1
        '
        'txtSerial
        '
        Me.txtSerial.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerial.Location = New System.Drawing.Point(16, 176)
        Me.txtSerial.MaxLength = 20
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(232, 20)
        Me.txtSerial.TabIndex = 3
        '
        'txtMNum
        '
        Me.txtMNum.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMNum.Location = New System.Drawing.Point(320, 176)
        Me.txtMNum.MaxLength = 5
        Me.txtMNum.Name = "txtMNum"
        Me.txtMNum.Size = New System.Drawing.Size(232, 20)
        Me.txtMNum.TabIndex = 4
        '
        'lblMachineName
        '
        Me.lblMachineName.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachineName.Location = New System.Drawing.Point(16, 72)
        Me.lblMachineName.Name = "lblMachineName"
        Me.lblMachineName.Size = New System.Drawing.Size(224, 23)
        Me.lblMachineName.TabIndex = 5
        Me.lblMachineName.Text = "Machine Name"
        '
        'lblSerial
        '
        Me.lblSerial.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.Location = New System.Drawing.Point(16, 144)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(224, 23)
        Me.lblSerial.TabIndex = 6
        Me.lblSerial.Text = "Serial Number"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(320, 72)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(232, 23)
        Me.lblManufacturer.TabIndex = 7
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'lblMNum
        '
        Me.lblMNum.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMNum.Location = New System.Drawing.Point(320, 144)
        Me.lblMNum.Name = "lblMNum"
        Me.lblMNum.Size = New System.Drawing.Size(232, 23)
        Me.lblMNum.TabIndex = 9
        Me.lblMNum.Text = "Machine Number"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(16, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 80)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&ADD"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(160, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 80)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "MO&DIFY"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(304, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 80)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "DE&LETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cboManufacturer
        '
        Me.cboManufacturer.DisplayMember = "ManufacturerName"
        Me.cboManufacturer.Location = New System.Drawing.Point(320, 96)
        Me.cboManufacturer.Name = "cboManufacturer"
        Me.cboManufacturer.Size = New System.Drawing.Size(232, 21)
        Me.cboManufacturer.TabIndex = 2
        Me.cboManufacturer.ValueMember = "ManufacturerID"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(448, 264)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 80)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CA&NCEL"
        '
        'frmMachMaint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 406)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboManufacturer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMNum)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblMachineName)
        Me.Controls.Add(Me.txtMNum)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtMachineName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMachMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit Machine Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMachMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()

    End Sub

    Private Sub cboManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboManufacturer.SelectedIndexChanged

    End Sub
End Class
