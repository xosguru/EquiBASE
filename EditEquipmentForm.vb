Imports System.Data.SqlClient
Imports System.Linq

Public Class EditEquipmentForm
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
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ManufacturerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MachineNameLabel As System.Windows.Forms.Label
    Friend WithEvents SerialNumberLabel As System.Windows.Forms.Label
    Friend WithEvents ManufacturerLabel As System.Windows.Forms.Label
    Friend WithEvents MachineDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents MachineNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MachineNumberLabel As System.Windows.Forms.Label
    Friend WithEvents AddEquipmentButton As Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEquipmentForm))
        Me.ManufacturerNameTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MachineNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MachineNameLabel = New System.Windows.Forms.Label()
        Me.SerialNumberLabel = New System.Windows.Forms.Label()
        Me.ManufacturerLabel = New System.Windows.Forms.Label()
        Me.MachineNumberLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MachineDropDown = New System.Windows.Forms.ComboBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddEquipmentButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManufacturerNameTextBox
        '
        Me.ManufacturerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ManufacturerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ManufacturerNameTextBox.Enabled = False
        Me.ManufacturerNameTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerNameTextBox.Location = New System.Drawing.Point(286, 98)
        Me.ManufacturerNameTextBox.MaxLength = 30
        Me.ManufacturerNameTextBox.Name = "ManufacturerNameTextBox"
        Me.ManufacturerNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerNameTextBox.TabIndex = 1
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SerialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNumberTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(10, 168)
        Me.SerialNumberTextBox.MaxLength = 20
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberTextBox.TabIndex = 3
        '
        'MachineNumberTextBox
        '
        Me.MachineNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MachineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MachineNumberTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNumberTextBox.Location = New System.Drawing.Point(286, 168)
        Me.MachineNumberTextBox.MaxLength = 20
        Me.MachineNumberTextBox.Name = "MachineNumberTextBox"
        Me.MachineNumberTextBox.Size = New System.Drawing.Size(235, 20)
        Me.MachineNumberTextBox.TabIndex = 4
        '
        'MachineNameLabel
        '
        Me.MachineNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNameLabel.Location = New System.Drawing.Point(10, 78)
        Me.MachineNameLabel.Name = "MachineNameLabel"
        Me.MachineNameLabel.Size = New System.Drawing.Size(235, 20)
        Me.MachineNameLabel.TabIndex = 5
        Me.MachineNameLabel.Text = "Machine Name"
        '
        'SerialNumberLabel
        '
        Me.SerialNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberLabel.Location = New System.Drawing.Point(10, 149)
        Me.SerialNumberLabel.Name = "SerialNumberLabel"
        Me.SerialNumberLabel.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberLabel.TabIndex = 6
        Me.SerialNumberLabel.Text = "Serial Number"
        '
        'ManufacturerLabel
        '
        Me.ManufacturerLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerLabel.Location = New System.Drawing.Point(286, 78)
        Me.ManufacturerLabel.Name = "ManufacturerLabel"
        Me.ManufacturerLabel.Size = New System.Drawing.Size(235, 20)
        Me.ManufacturerLabel.TabIndex = 7
        Me.ManufacturerLabel.Text = "Manufacturer"
        '
        'MachineNumberLabel
        '
        Me.MachineNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineNumberLabel.Location = New System.Drawing.Point(286, 146)
        Me.MachineNumberLabel.Name = "MachineNumberLabel"
        Me.MachineNumberLabel.Size = New System.Drawing.Size(235, 20)
        Me.MachineNumberLabel.TabIndex = 9
        Me.MachineNumberLabel.Text = "Machine Number"
        '
        'UpdateButton
        '
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateButton.Location = New System.Drawing.Point(416, 264)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(105, 70)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "&Update"
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(137, 264)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(105, 70)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "De&lete"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'MachineDropDown
        '
        Me.MachineDropDown.DisplayMember = "ManufacturerName"
        Me.MachineDropDown.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineDropDown.Location = New System.Drawing.Point(10, 98)
        Me.MachineDropDown.Name = "MachineDropDown"
        Me.MachineDropDown.Size = New System.Drawing.Size(235, 24)
        Me.MachineDropDown.TabIndex = 2
        Me.MachineDropDown.ValueMember = "ManufacturerID"
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(286, 264)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(105, 70)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Ca&ncel"
        '
        'AddEquipmentButton
        '
        Me.AddEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddEquipmentButton.Location = New System.Drawing.Point(10, 264)
        Me.AddEquipmentButton.Name = "AddEquipmentButton"
        Me.AddEquipmentButton.Size = New System.Drawing.Size(105, 70)
        Me.AddEquipmentButton.TabIndex = 14
        Me.AddEquipmentButton.Text = "A&dd New"
        '
        'EditEquipmentForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.AddEquipmentButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.MachineDropDown)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.MachineNumberLabel)
        Me.Controls.Add(Me.ManufacturerLabel)
        Me.Controls.Add(Me.SerialNumberLabel)
        Me.Controls.Add(Me.MachineNameLabel)
        Me.Controls.Add(Me.MachineNumberTextBox)
        Me.Controls.Add(Me.SerialNumberTextBox)
        Me.Controls.Add(Me.ManufacturerNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EditEquipmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Equipment Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Dim connection As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim command As SqlCommand
    Dim FormDataSet As DataSet
    Dim getEquipmentQuery As String = "select tm.*, tmf.ManufacturerName from tblMachines tm
                                        inner join tblManufacturers tmf on
                                        tm.ManufacturerID = tmf.ManufacturerID
                                        where tm.Status = 'A'"

    Dim connectionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim confirmDelete As DialogResult = MessageBox.Show(Me, "Are you sure?", "Delete the record.", MessageBoxButtons.OKCancel)

        If confirmDelete = DialogResult.OK Then
            Dim machineID As Int32

            machineID = CType(MachineDropDown.SelectedItem, DataRowView).Row.Item("MachineID")

            If machineID > 0 Then
                Dim updateEquipmentQuery As String = "update tblMachines
                                                set
                                                Status = 'I'
                                                where MachineID = " & machineID

                connection = New SqlConnection(connectionString)
                command = New SqlCommand(updateEquipmentQuery, connection)

                connection.Open()
                command.ExecuteNonQuery()
                command.Dispose()
                connection.Close()

                Me.Hide()
            End If
        End If

    End Sub

    Private Sub AddEquipmentButton_Click(sender As Object, e As EventArgs) Handles AddEquipmentButton.Click
        NewEquipmentForm.ShowDialog()
    End Sub

    Private Sub UpdateForm(machineID As Int32)
        Dim serialNumber As String = Nothing
        Dim machineNumber As String = Nothing
        Dim manufacturerName As String = Nothing
        Dim clickCount As String = Nothing


        Dim row As DataRow() = FormDataSet.Tables(0).Select("MachineID = " & machineID)

        If row.Count > 0 Then
            serialNumber = row(0).Item("SerialNumber")
            machineNumber = row(0).Item("MachineNumber")
            manufacturerName = row(0).Item("ManufacturerName")

        End If

        SerialNumberTextBox.Text = serialNumber.Trim()
        ManufacturerNameTextBox.Text = manufacturerName.Trim()
        MachineNumberTextBox.Text = machineNumber.Trim()

    End Sub

    Private Sub MachineDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MachineDropDown.SelectedIndexChanged
        Dim selectedMachineID As String = "0"
        selectedMachineID = CType(MachineDropDown.SelectedItem, DataRowView).Row.Item("MachineID")
        UpdateForm(Int32.Parse(selectedMachineID))
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim machineNumber As String = Nothing
        Dim serialNumber As String = Nothing
        Dim machineID As Int32 = 0

        machineNumber = MachineNumberTextBox.Text.Trim()
        serialNumber = SerialNumberTextBox.Text.Trim()

        If machineNumber.Length > 0 And serialNumber.Length > 0 Then

            machineID = CType(MachineDropDown.SelectedItem, DataRowView).Row.Item("MachineID")

            Dim updateEquipmentQuery As String = "update tblMachines
                                                set
                                                MachineNumber = '" & machineNumber & "', " &
                                                            "SerialNumber = '" & serialNumber & "'" &
                                                            "where MachineID = " & machineID

            connection = New SqlConnection(connectionString)
            command = New SqlCommand(updateEquipmentQuery, connection)

            connection.Open()
            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()

            Me.Hide()
        End If
    End Sub

    Private Sub EditEquipmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selectedMachineID As String = Nothing
        FormDataSet = New DataSet()
        connection = New SqlConnection(connectionString)
        command = New SqlCommand(getEquipmentQuery, connection)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(FormDataSet)

        connection.Close()
        command.Dispose()
        connection.Dispose()
        adapter.Dispose()

        MachineDropDown.DataSource = FormDataSet.Tables(0)
        MachineDropDown.ValueMember = "MachineID"
        MachineDropDown.DisplayMember = "MachineName"

        selectedMachineID = CType(MachineDropDown.SelectedItem, DataRowView).Row.Item("MachineID")
        UpdateForm(Int32.Parse(selectedMachineID))

        MachineDropDown.Select()

    End Sub
End Class
