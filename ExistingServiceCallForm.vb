Imports System.Data.SqlClient
Imports System.Linq

Public Class ExistingServiceCallForm
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
    Friend WithEvents RequireAfterHoursCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CallNotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sqlComEquiBASE As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConnEquiBASE As System.Data.SqlClient.SqlConnection
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorCodeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OtherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SoftwareRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StreakingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JammingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClickCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ClickCountLabel As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents SerialNumberTextBox As System.Windows.Forms.Label
    Friend WithEvents daMachines As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SerialNumberLabel As System.Windows.Forms.Label
    Friend WithEvents SelectMachineLabel As System.Windows.Forms.Label
    Friend WithEvents ServiceCallIdLabel As System.Windows.Forms.Label
    Friend WithEvents MachineNameTextBox As TextBox
    Friend WithEvents ServiceCallDropDown As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExistingServiceCallForm))
        Me.RequireAfterHoursCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmployeeNameLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CallNotesTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorCodeCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton()
        Me.SoftwareRadioButton = New System.Windows.Forms.RadioButton()
        Me.StreakingRadioButton = New System.Windows.Forms.RadioButton()
        Me.JammingRadioButton = New System.Windows.Forms.RadioButton()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClickCountTextBox = New System.Windows.Forms.TextBox()
        Me.ClickCountLabel = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SerialNumberTextBox = New System.Windows.Forms.Label()
        Me.SerialNumberLabel = New System.Windows.Forms.Label()
        Me.SelectMachineLabel = New System.Windows.Forms.Label()
        Me.ServiceCallIdLabel = New System.Windows.Forms.Label()
        Me.ServiceCallDropDown = New System.Windows.Forms.ComboBox()
        Me.MachineNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequireAfterHoursCheckBox
        '
        Me.RequireAfterHoursCheckBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequireAfterHoursCheckBox.Location = New System.Drawing.Point(286, 194)
        Me.RequireAfterHoursCheckBox.Name = "RequireAfterHoursCheckBox"
        Me.RequireAfterHoursCheckBox.Size = New System.Drawing.Size(224, 30)
        Me.RequireAfterHoursCheckBox.TabIndex = 25
        Me.RequireAfterHoursCheckBox.Text = "Require after-hours service?"
        '
        'EmployeeNameLabel
        '
        Me.EmployeeNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameLabel.Location = New System.Drawing.Point(286, 78)
        Me.EmployeeNameLabel.Name = "EmployeeNameLabel"
        Me.EmployeeNameLabel.Size = New System.Drawing.Size(224, 20)
        Me.EmployeeNameLabel.TabIndex = 38
        Me.EmployeeNameLabel.Text = "Employee Name"
        Me.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 21)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Details of Problem (300 characters)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CallNotesTextBox
        '
        Me.CallNotesTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CallNotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CallNotesTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallNotesTextBox.Location = New System.Drawing.Point(14, 268)
        Me.CallNotesTextBox.MaxLength = 300
        Me.CallNotesTextBox.Multiline = True
        Me.CallNotesTextBox.Name = "CallNotesTextBox"
        Me.CallNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CallNotesTextBox.Size = New System.Drawing.Size(698, 197)
        Me.CallNotesTextBox.TabIndex = 34
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmployeeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeNameTextBox.Enabled = False
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(286, 98)
        Me.EmployeeNameTextBox.MaxLength = 20
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.EmployeeNameTextBox.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ErrorCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.ErrorCodeCheckBox)
        Me.GroupBox1.Controls.Add(Me.OtherRadioButton)
        Me.GroupBox1.Controls.Add(Me.SoftwareRadioButton)
        Me.GroupBox1.Controls.Add(Me.StreakingRadioButton)
        Me.GroupBox1.Controls.Add(Me.JammingRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(728, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 335)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QuickDiag"
        '
        'ErrorCodeTextBox
        '
        Me.ErrorCodeTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ErrorCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorCodeTextBox.Enabled = False
        Me.ErrorCodeTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorCodeTextBox.Location = New System.Drawing.Point(45, 276)
        Me.ErrorCodeTextBox.MaxLength = 15
        Me.ErrorCodeTextBox.Name = "ErrorCodeTextBox"
        Me.ErrorCodeTextBox.Size = New System.Drawing.Size(145, 20)
        Me.ErrorCodeTextBox.TabIndex = 11
        '
        'ErrorCodeCheckBox
        '
        Me.ErrorCodeCheckBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorCodeCheckBox.Location = New System.Drawing.Point(45, 250)
        Me.ErrorCodeCheckBox.Name = "ErrorCodeCheckBox"
        Me.ErrorCodeCheckBox.Size = New System.Drawing.Size(145, 30)
        Me.ErrorCodeCheckBox.TabIndex = 10
        Me.ErrorCodeCheckBox.Text = "Error Code"
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherRadioButton.Location = New System.Drawing.Point(45, 198)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.OtherRadioButton.TabIndex = 9
        Me.OtherRadioButton.Text = "Other"
        '
        'SoftwareRadioButton
        '
        Me.SoftwareRadioButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareRadioButton.Location = New System.Drawing.Point(45, 146)
        Me.SoftwareRadioButton.Name = "SoftwareRadioButton"
        Me.SoftwareRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.SoftwareRadioButton.TabIndex = 8
        Me.SoftwareRadioButton.Text = "Software"
        '
        'StreakingRadioButton
        '
        Me.StreakingRadioButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreakingRadioButton.Location = New System.Drawing.Point(45, 93)
        Me.StreakingRadioButton.Name = "StreakingRadioButton"
        Me.StreakingRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.StreakingRadioButton.TabIndex = 7
        Me.StreakingRadioButton.Text = "Streaking"
        '
        'JammingRadioButton
        '
        Me.JammingRadioButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JammingRadioButton.Location = New System.Drawing.Point(45, 39)
        Me.JammingRadioButton.Name = "JammingRadioButton"
        Me.JammingRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.JammingRadioButton.TabIndex = 6
        Me.JammingRadioButton.Text = "Jamming"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(858, 394)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(105, 69)
        Me.SaveButton.TabIndex = 35
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ClickCountTextBox
        '
        Me.ClickCountTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClickCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClickCountTextBox.Enabled = False
        Me.ClickCountTextBox.Location = New System.Drawing.Point(286, 168)
        Me.ClickCountTextBox.MaxLength = 7
        Me.ClickCountTextBox.Name = "ClickCountTextBox"
        Me.ClickCountTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ClickCountTextBox.TabIndex = 24
        '
        'ClickCountLabel
        '
        Me.ClickCountLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClickCountLabel.Location = New System.Drawing.Point(286, 146)
        Me.ClickCountLabel.Name = "ClickCountLabel"
        Me.ClickCountLabel.Size = New System.Drawing.Size(224, 20)
        Me.ClickCountLabel.TabIndex = 39
        Me.ClickCountLabel.Text = "Service Call Click Count"
        Me.ClickCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(728, 394)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(105, 69)
        Me.CancelButton.TabIndex = 36
        Me.CancelButton.Text = "Ca&ncel"
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNumberTextBox.Enabled = False
        Me.SerialNumberTextBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(11, 168)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberTextBox.TabIndex = 31
        Me.SerialNumberTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SerialNumberLabel
        '
        Me.SerialNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberLabel.Location = New System.Drawing.Point(11, 149)
        Me.SerialNumberLabel.Name = "SerialNumberLabel"
        Me.SerialNumberLabel.Size = New System.Drawing.Size(235, 19)
        Me.SerialNumberLabel.TabIndex = 28
        Me.SerialNumberLabel.Text = "Serial Number"
        Me.SerialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectMachineLabel
        '
        Me.SelectMachineLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectMachineLabel.Location = New System.Drawing.Point(11, 78)
        Me.SelectMachineLabel.Name = "SelectMachineLabel"
        Me.SelectMachineLabel.Size = New System.Drawing.Size(224, 21)
        Me.SelectMachineLabel.TabIndex = 22
        Me.SelectMachineLabel.Text = "Machine"
        Me.SelectMachineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServiceCallIdLabel
        '
        Me.ServiceCallIdLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceCallIdLabel.Location = New System.Drawing.Point(286, 16)
        Me.ServiceCallIdLabel.Name = "ServiceCallIdLabel"
        Me.ServiceCallIdLabel.Size = New System.Drawing.Size(224, 20)
        Me.ServiceCallIdLabel.TabIndex = 41
        Me.ServiceCallIdLabel.Text = "Select Service Call ID"
        Me.ServiceCallIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServiceCallDropDown
        '
        Me.ServiceCallDropDown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ServiceCallDropDown.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceCallDropDown.Items.AddRange(New Object() {"16156", "25567", "30934", "43895"})
        Me.ServiceCallDropDown.Location = New System.Drawing.Point(286, 35)
        Me.ServiceCallDropDown.Name = "ServiceCallDropDown"
        Me.ServiceCallDropDown.Size = New System.Drawing.Size(235, 24)
        Me.ServiceCallDropDown.TabIndex = 42
        '
        'MachineNameTextBox
        '
        Me.MachineNameTextBox.Enabled = False
        Me.MachineNameTextBox.Location = New System.Drawing.Point(11, 98)
        Me.MachineNameTextBox.Name = "MachineNameTextBox"
        Me.MachineNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.MachineNameTextBox.TabIndex = 43
        '
        'ExistingServiceCall
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.MachineNameTextBox)
        Me.Controls.Add(Me.ServiceCallDropDown)
        Me.Controls.Add(Me.ServiceCallIdLabel)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClickCountTextBox)
        Me.Controls.Add(Me.ClickCountLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SerialNumberTextBox)
        Me.Controls.Add(Me.SerialNumberLabel)
        Me.Controls.Add(Me.SelectMachineLabel)
        Me.Controls.Add(Me.RequireAfterHoursCheckBox)
        Me.Controls.Add(Me.EmployeeNameLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CallNotesTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExistingServiceCall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review/Edit Exisiting Service Call Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim selectServiceCallsQuery As String = "select *, te.FirstName + ' ' + te.LastName as EmployeeName, tsc.ClickCount as SCClickCount from tblServiceCalls tsc
                                                inner join tblMachines tm on
                                                tsc.MachineID = tm.MachineID

                                                inner join tblEmployees te on
                                                tsc.EmployeeID = te.EmployeeID"
    Dim updateServiceCallQuery As String = Nothing
    Dim FormDataSet As DataSet
    Dim connetionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"


    Private Sub ServiceCallDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServiceCallDropDown.SelectedIndexChanged
        Dim selectedServiceCallID As String = CType(ServiceCallDropDown.SelectedItem, DataRowView).Row.Item("ServiceCallID").ToString
        UpdateForm(selectedServiceCallID)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.Hide()

    End Sub

    Private Sub ExistingServiceCall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDataSet = New DataSet()
        connection = New SqlConnection(connetionString)
        command = New SqlCommand(selectServiceCallsQuery, connection)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(FormDataSet)

        command.Dispose()
        connection.Close()
        connection.Dispose()

        ServiceCallDropDown.DataSource = FormDataSet.Tables(0)
        ServiceCallDropDown.ValueMember = "ServiceCallID"
        ServiceCallDropDown.DisplayMember = "ServiceCallID"

        Dim selectedServiceCallID As String = CType(ServiceCallDropDown.SelectedItem, DataRowView).Row.Item("ServiceCallID").ToString
        UpdateForm(selectedServiceCallID)

    End Sub
    Private Sub UpdateForm(callID As Int32)
        Dim serialNo As String = Nothing
        Dim machineName As String = Nothing
        Dim employeeName As String = Nothing
        Dim clickCount As String = Nothing
        Dim details As String = Nothing
        Dim errorCode As String = Nothing
        Dim afterHours As String = Nothing
        Dim quickDiag As String = Nothing

        Dim row As DataRow() = FormDataSet.Tables(0).Select("ServiceCallID = " & callID)

        If row.Count > 0 Then
            serialNo = row(0).Item("SerialNumber")
            machineName = row(0).Item("MachineName")
            employeeName = row(0).Item("EmployeeName")
            clickCount = row(0).Item("SCClickCount")
            details = row(0).Item("Details")
            errorCode = row(0).Item("ErrorCode")
            afterHours = row(0).Item("AfterHours")
            quickDiag = row(0).Item("QuickDiagnostics")

        End If

        SerialNumberTextBox.Text = serialNo.Trim()
        EmployeeNameTextBox.Text = employeeName.Trim()
        MachineNameTextBox.Text = machineName.Trim()
        ClickCountTextBox.Text = clickCount.Trim()
        ErrorCodeTextBox.Text = errorCode.Trim()
        CallNotesTextBox.Text = details.Trim()

        If afterHours.Trim().Equals("Yes") Then
            RequireAfterHoursCheckBox.Checked = True
        Else
            RequireAfterHoursCheckBox.Checked = False
        End If

        If errorCode.Equals("N/A") Then
            ErrorCodeCheckBox.Checked = False
        ElseIf errorCode = Nothing Then
            ErrorCodeCheckBox.Checked = False
        Else
            ErrorCodeCheckBox.Checked = True
        End If

        Select Case quickDiag
            Case "Jamming"
                JammingRadioButton.Checked = True
            Case "Streaking"
                StreakingRadioButton.Checked = True
            Case "Software"
                SoftwareRadioButton.Checked = True
            Case "Other"
                OtherRadioButton.Checked = True
        End Select

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim updatedDetails As String = CallNotesTextBox.Text.Trim()
        Dim selectedServiceCallId As String = ServiceCallDropDown.SelectedValue

        updateServiceCallQuery = "update tblServiceCalls
                                            set Details = '" & updatedDetails & "' where ServiceCallID = " & selectedServiceCallId
        connection = New SqlConnection(connetionString)
        command = New SqlCommand(updateServiceCallQuery, connection)
        connection.Open()
        command.ExecuteNonQuery()
        command.Dispose()
        connection.Close()

        Me.Hide()

    End Sub
End Class
