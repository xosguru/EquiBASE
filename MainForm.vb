Public Class MainForm

    Inherits System.Windows.Forms.Form

    'Forms are handled as classes.  In order to access another form, you must dimension a variable/reference to it
    'as a New Form and then call it using the Show method.

    'Forms should also be initiated outside of procedures, otherwise each time a user initiates that procedure
    'a new instance of the form is created.

    Public Shared frmNewCall As New NewServiceCallForm()
    Public Shared frmMachMaint As New MachineMaintenanceForm()
    Public Shared frmExCall As New ExistingServiceCallForm()
    Public Shared frmReports As New ReportsForm()

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents NewServiceCallButton As System.Windows.Forms.Button
    Friend WithEvents ExistingServiceCallButton As System.Windows.Forms.Button
    Friend WithEvents MachineMaintenanceButton As System.Windows.Forms.Button
    Friend WithEvents ReportsButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.NewServiceCallButton = New System.Windows.Forms.Button()
        Me.ExistingServiceCallButton = New System.Windows.Forms.Button()
        Me.MachineMaintenanceButton = New System.Windows.Forms.Button()
        Me.ReportsButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewServiceCallButton
        '
        Me.NewServiceCallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewServiceCallButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewServiceCallButton.Location = New System.Drawing.Point(18, 23)
        Me.NewServiceCallButton.Name = "NewServiceCallButton"
        Me.NewServiceCallButton.Size = New System.Drawing.Size(168, 118)
        Me.NewServiceCallButton.TabIndex = 1
        Me.NewServiceCallButton.Text = "New Service Call"
        '
        'ExistingServiceCallButton
        '
        Me.ExistingServiceCallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExistingServiceCallButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExistingServiceCallButton.Location = New System.Drawing.Point(242, 23)
        Me.ExistingServiceCallButton.Name = "ExistingServiceCallButton"
        Me.ExistingServiceCallButton.Size = New System.Drawing.Size(168, 118)
        Me.ExistingServiceCallButton.TabIndex = 2
        Me.ExistingServiceCallButton.Text = "Existing Service Call"
        '
        'MachineMaintenanceButton
        '
        Me.MachineMaintenanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MachineMaintenanceButton.Location = New System.Drawing.Point(18, 147)
        Me.MachineMaintenanceButton.Name = "MachineMaintenanceButton"
        Me.MachineMaintenanceButton.Size = New System.Drawing.Size(168, 119)
        Me.MachineMaintenanceButton.TabIndex = 3
        Me.MachineMaintenanceButton.Text = "Machine Maintenance"
        '
        'ReportsButton
        '
        Me.ReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReportsButton.Location = New System.Drawing.Point(242, 147)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(168, 119)
        Me.ReportsButton.TabIndex = 4
        Me.ReportsButton.Text = "Reports"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ExistingServiceCallButton)
        Me.Panel1.Controls.Add(Me.NewServiceCallButton)
        Me.Panel1.Controls.Add(Me.MachineMaintenanceButton)
        Me.Panel1.Controls.Add(Me.ReportsButton)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(22, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 295)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitButton.Location = New System.Drawing.Point(22, 384)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(437, 30)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&XIT SYSTEM"
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(490, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose a Task"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewServiceCallButton.Click

        frmNewCall.ShowDialog()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistingServiceCallButton.Click

        frmExCall.ShowDialog()

    End Sub

    Private Sub btnMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineMaintenanceButton.Click

        frmMachMaint.ShowDialog()

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsButton.Click

        frmReports.ShowDialog()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
