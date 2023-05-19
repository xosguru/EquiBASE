Public Class ReportsForm
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MachineReliabilityButton As System.Windows.Forms.Button
    Friend WithEvents ServiceCallHistoryButton As System.Windows.Forms.Button
    Friend WithEvents EquipmentInventoryButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MachineReliabilityButton = New System.Windows.Forms.Button()
        Me.ServiceCallHistoryButton = New System.Windows.Forms.Button()
        Me.EquipmentInventoryButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MachineReliabilityButton
        '
        Me.MachineReliabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MachineReliabilityButton.Location = New System.Drawing.Point(15, 64)
        Me.MachineReliabilityButton.Name = "MachineReliabilityButton"
        Me.MachineReliabilityButton.Size = New System.Drawing.Size(120, 96)
        Me.MachineReliabilityButton.TabIndex = 7
        Me.MachineReliabilityButton.Text = "Machine Reliability Rate"
        '
        'ServiceCallHistoryButton
        '
        Me.ServiceCallHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ServiceCallHistoryButton.Location = New System.Drawing.Point(151, 64)
        Me.ServiceCallHistoryButton.Name = "ServiceCallHistoryButton"
        Me.ServiceCallHistoryButton.Size = New System.Drawing.Size(120, 96)
        Me.ServiceCallHistoryButton.TabIndex = 8
        Me.ServiceCallHistoryButton.Text = "Service Call History"
        '
        'EquipmentInventoryButton
        '
        Me.EquipmentInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EquipmentInventoryButton.Location = New System.Drawing.Point(287, 64)
        Me.EquipmentInventoryButton.Name = "EquipmentInventoryButton"
        Me.EquipmentInventoryButton.Size = New System.Drawing.Size(120, 96)
        Me.EquipmentInventoryButton.TabIndex = 9
        Me.EquipmentInventoryButton.Text = "Equipment Inventory"
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(48, 200)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(312, 24)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "CA&NCEL"
        '
        'ReportsForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(418, 245)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EquipmentInventoryButton)
        Me.Controls.Add(Me.ServiceCallHistoryButton)
        Me.Controls.Add(Me.MachineReliabilityButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Useful Reports"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub EquipmentInventoryButton_Click(sender As Object, e As EventArgs) Handles EquipmentInventoryButton.Click
        EquipmentInventoryForm.ShowDialog()
    End Sub

    Private Sub ServiceCallHistoryButton_Click(sender As Object, e As EventArgs) Handles ServiceCallHistoryButton.Click
        ServiceCallHistory.ShowDialog()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub
End Class
