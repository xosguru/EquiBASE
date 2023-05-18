Imports System.Data.SqlClient
Imports System.Linq

Public Class NewServiceCallForm

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
    Friend WithEvents SelectMachineLabel As System.Windows.Forms.Label
    Friend WithEvents LogoBox As System.Windows.Forms.PictureBox
    Friend WithEvents SerialNumberLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents MachinesDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents QuickDiagnosticsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents JammingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StreakingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SoftwareRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OtherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CallNotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProblemDetailsLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorCodeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentClickCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentClickCountLabel As System.Windows.Forms.Label
    Friend WithEvents RequireAfterHoursCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeNameDropDown As Windows.Forms.ComboBox
    Friend WithEvents SerialNumberTextLabel As Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewServiceCallForm))
        Me.MachinesDropDown = New System.Windows.Forms.ComboBox()
        Me.SelectMachineLabel = New System.Windows.Forms.Label()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.SerialNumberLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.QuickDiagnosticsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ErrorCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorCodeCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton()
        Me.SoftwareRadioButton = New System.Windows.Forms.RadioButton()
        Me.StreakingRadioButton = New System.Windows.Forms.RadioButton()
        Me.JammingRadioButton = New System.Windows.Forms.RadioButton()
        Me.CallNotesTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemDetailsLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameLabel = New System.Windows.Forms.Label()
        Me.CurrentClickCountTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentClickCountLabel = New System.Windows.Forms.Label()
        Me.RequireAfterHoursCheckBox = New System.Windows.Forms.CheckBox()
        Me.SerialNumberTextLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameDropDown = New System.Windows.Forms.ComboBox()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuickDiagnosticsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MachinesDropDown
        '
        Me.MachinesDropDown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MachinesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MachinesDropDown.Location = New System.Drawing.Point(11, 98)
        Me.MachinesDropDown.Name = "MachinesDropDown"
        Me.MachinesDropDown.Size = New System.Drawing.Size(235, 24)
        Me.MachinesDropDown.TabIndex = 1
        '
        'SelectMachineLabel
        '
        Me.SelectMachineLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectMachineLabel.Location = New System.Drawing.Point(11, 78)
        Me.SelectMachineLabel.Name = "SelectMachineLabel"
        Me.SelectMachineLabel.Size = New System.Drawing.Size(224, 21)
        Me.SelectMachineLabel.TabIndex = 20
        Me.SelectMachineLabel.Text = "Select a Machine"
        Me.SelectMachineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoBox
        '
        Me.LogoBox.Enabled = False
        Me.LogoBox.Image = CType(resources.GetObject("LogoBox.Image"), System.Drawing.Image)
        Me.LogoBox.Location = New System.Drawing.Point(11, 20)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(155, 39)
        Me.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoBox.TabIndex = 6
        Me.LogoBox.TabStop = False
        '
        'SerialNumberLabel
        '
        Me.SerialNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberLabel.Location = New System.Drawing.Point(11, 149)
        Me.SerialNumberLabel.Name = "SerialNumberLabel"
        Me.SerialNumberLabel.Size = New System.Drawing.Size(235, 19)
        Me.SerialNumberLabel.TabIndex = 11
        Me.SerialNumberLabel.Text = "Serial Number"
        Me.SerialNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(858, 394)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(105, 69)
        Me.SaveButton.TabIndex = 13
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(728, 394)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(105, 69)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "Ca&ncel"
        '
        'QuickDiagnosticsGroupBox
        '
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.ErrorCodeTextBox)
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.ErrorCodeCheckBox)
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.OtherRadioButton)
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.SoftwareRadioButton)
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.StreakingRadioButton)
        Me.QuickDiagnosticsGroupBox.Controls.Add(Me.JammingRadioButton)
        Me.QuickDiagnosticsGroupBox.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickDiagnosticsGroupBox.Location = New System.Drawing.Point(728, 39)
        Me.QuickDiagnosticsGroupBox.Name = "QuickDiagnosticsGroupBox"
        Me.QuickDiagnosticsGroupBox.Size = New System.Drawing.Size(235, 335)
        Me.QuickDiagnosticsGroupBox.TabIndex = 5
        Me.QuickDiagnosticsGroupBox.TabStop = False
        Me.QuickDiagnosticsGroupBox.Text = "QuickDiag"
        '
        'ErrorCodeTextBox
        '
        Me.ErrorCodeTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ErrorCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorCodeTextBox.Enabled = False
        Me.ErrorCodeTextBox.Location = New System.Drawing.Point(45, 276)
        Me.ErrorCodeTextBox.MaxLength = 15
        Me.ErrorCodeTextBox.Name = "ErrorCodeTextBox"
        Me.ErrorCodeTextBox.Size = New System.Drawing.Size(145, 20)
        Me.ErrorCodeTextBox.TabIndex = 11
        '
        'ErrorCodeCheckBox
        '
        Me.ErrorCodeCheckBox.Location = New System.Drawing.Point(45, 250)
        Me.ErrorCodeCheckBox.Name = "ErrorCodeCheckBox"
        Me.ErrorCodeCheckBox.Size = New System.Drawing.Size(145, 30)
        Me.ErrorCodeCheckBox.TabIndex = 10
        Me.ErrorCodeCheckBox.Text = "Error Code"
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.Location = New System.Drawing.Point(45, 198)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.OtherRadioButton.TabIndex = 9
        Me.OtherRadioButton.Text = "Other"
        '
        'SoftwareRadioButton
        '
        Me.SoftwareRadioButton.Location = New System.Drawing.Point(45, 146)
        Me.SoftwareRadioButton.Name = "SoftwareRadioButton"
        Me.SoftwareRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.SoftwareRadioButton.TabIndex = 8
        Me.SoftwareRadioButton.Text = "Software"
        '
        'StreakingRadioButton
        '
        Me.StreakingRadioButton.Location = New System.Drawing.Point(45, 93)
        Me.StreakingRadioButton.Name = "StreakingRadioButton"
        Me.StreakingRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.StreakingRadioButton.TabIndex = 7
        Me.StreakingRadioButton.Text = "Streaking"
        '
        'JammingRadioButton
        '
        Me.JammingRadioButton.Location = New System.Drawing.Point(45, 39)
        Me.JammingRadioButton.Name = "JammingRadioButton"
        Me.JammingRadioButton.Size = New System.Drawing.Size(145, 30)
        Me.JammingRadioButton.TabIndex = 6
        Me.JammingRadioButton.Text = "Jamming"
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
        Me.CallNotesTextBox.TabIndex = 5
        '
        'ProblemDetailsLabel
        '
        Me.ProblemDetailsLabel.Location = New System.Drawing.Point(12, 245)
        Me.ProblemDetailsLabel.Name = "ProblemDetailsLabel"
        Me.ProblemDetailsLabel.Size = New System.Drawing.Size(227, 21)
        Me.ProblemDetailsLabel.TabIndex = 17
        Me.ProblemDetailsLabel.Text = "Details of Problem (300 characters)"
        Me.ProblemDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmployeeNameLabel
        '
        Me.EmployeeNameLabel.Location = New System.Drawing.Point(286, 78)
        Me.EmployeeNameLabel.Name = "EmployeeNameLabel"
        Me.EmployeeNameLabel.Size = New System.Drawing.Size(224, 20)
        Me.EmployeeNameLabel.TabIndex = 18
        Me.EmployeeNameLabel.Text = "Employee Name"
        Me.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurrentClickCountTextBox
        '
        Me.CurrentClickCountTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CurrentClickCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentClickCountTextBox.Location = New System.Drawing.Point(286, 168)
        Me.CurrentClickCountTextBox.MaxLength = 7
        Me.CurrentClickCountTextBox.Name = "CurrentClickCountTextBox"
        Me.CurrentClickCountTextBox.Size = New System.Drawing.Size(235, 20)
        Me.CurrentClickCountTextBox.TabIndex = 3
        '
        'CurrentClickCountLabel
        '
        Me.CurrentClickCountLabel.Location = New System.Drawing.Point(286, 146)
        Me.CurrentClickCountLabel.Name = "CurrentClickCountLabel"
        Me.CurrentClickCountLabel.Size = New System.Drawing.Size(224, 20)
        Me.CurrentClickCountLabel.TabIndex = 20
        Me.CurrentClickCountLabel.Text = "Current Click Count"
        Me.CurrentClickCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RequireAfterHoursCheckBox
        '
        Me.RequireAfterHoursCheckBox.Location = New System.Drawing.Point(286, 194)
        Me.RequireAfterHoursCheckBox.Name = "RequireAfterHoursCheckBox"
        Me.RequireAfterHoursCheckBox.Size = New System.Drawing.Size(224, 30)
        Me.RequireAfterHoursCheckBox.TabIndex = 4
        Me.RequireAfterHoursCheckBox.Text = "Require after-hours service?"
        '
        'SerialNumberTextLabel
        '
        Me.SerialNumberTextLabel.AccessibleDescription = "Displays the serial number for the selected machine."
        Me.SerialNumberTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialNumberTextLabel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialNumberTextLabel.Location = New System.Drawing.Point(11, 168)
        Me.SerialNumberTextLabel.Name = "SerialNumberTextLabel"
        Me.SerialNumberTextLabel.Size = New System.Drawing.Size(235, 20)
        Me.SerialNumberTextLabel.TabIndex = 21
        Me.SerialNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmployeeNameDropDown
        '
        Me.EmployeeNameDropDown.FormattingEnabled = True
        Me.EmployeeNameDropDown.Location = New System.Drawing.Point(286, 98)
        Me.EmployeeNameDropDown.Name = "EmployeeNameDropDown"
        Me.EmployeeNameDropDown.Size = New System.Drawing.Size(235, 24)
        Me.EmployeeNameDropDown.TabIndex = 2
        '
        'NewServiceCallForm
        '
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.EmployeeNameDropDown)
        Me.Controls.Add(Me.SerialNumberTextLabel)
        Me.Controls.Add(Me.RequireAfterHoursCheckBox)
        Me.Controls.Add(Me.CurrentClickCountTextBox)
        Me.Controls.Add(Me.CurrentClickCountLabel)
        Me.Controls.Add(Me.EmployeeNameLabel)
        Me.Controls.Add(Me.ProblemDetailsLabel)
        Me.Controls.Add(Me.CallNotesTextBox)
        Me.Controls.Add(Me.QuickDiagnosticsGroupBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.SerialNumberLabel)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.SelectMachineLabel)
        Me.Controls.Add(Me.MachinesDropDown)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewServiceCallForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Service Call"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuickDiagnosticsGroupBox.ResumeLayout(False)
        Me.QuickDiagnosticsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public NewServiceCallDataSet As DataSet
    Dim connetionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Dim connection As SqlConnection
        Dim command As SqlCommand

        Dim selectedMachineID As String = CType(MachinesDropDown.SelectedItem, DataRowView).Row.Item("MachineID").ToString
        Dim selectedEmployeeID As String = CType(EmployeeNameDropDown.SelectedItem, DataRowView).Row.Item("EmployeeID").ToString
        Dim enteredClickCount As String = CurrentClickCountTextBox.Text.Trim()
        Dim errorCode As String = Nothing
        Dim afterHours As String = Nothing
        Dim errorCodeEntered As Boolean = ErrorCodeCheckBox.Checked
        Dim details As String = CallNotesTextBox.Text.Trim()
        Dim quickDiag As String = Nothing

        If JammingRadioButton.Checked Then
            quickDiag = JammingRadioButton.Text
        ElseIf StreakingRadioButton.Checked Then
            quickDiag = StreakingRadioButton.Text
        ElseIf SoftwareRadioButton.Checked Then
            quickDiag = SoftwareRadioButton.Text
        ElseIf OtherRadioButton.Checked Then
            quickDiag = OtherRadioButton.Text
        Else
            quickDiag = "N/A"
        End If

        If ErrorCodeCheckBox.Checked Then
            If ErrorCodeTextBox.Text.Trim().Length > 0 Then
                errorCode = ErrorCodeTextBox.Text.Trim()
            Else
                errorCode = "N/A"
            End If
        Else
            errorCode = "N/A"
        End If

        If details.Length = 0 Then
            details = "N/A"
        End If

        Dim machineID As Int32 = Int32.Parse(selectedMachineID)
        Dim employeeID As Int32 = Int32.Parse(selectedEmployeeID)
        Dim clickCount As Int32 = 0

        If enteredClickCount.Length > 0 Then
            clickCount = Int32.Parse(enteredClickCount)
        End If

        If RequireAfterHoursCheckBox.Checked Then
            afterHours = "Yes"
        Else
            afterHours = "No"
        End If


        Dim insertServiceCallSql As String = "insert into tblServiceCalls (MachineID,EmployeeID,ClickCount,ErrorCode,AfterHours,QuickDiagnostics,Details) " &
                                                "values (" & machineID &
                                                "," & employeeID &
                                                "," & clickCount &
                                                ",'" & errorCode & "'" &
                                                ",'" & afterHours & "'" &
                                                ",'" & quickDiag & "'" &
                                                ",'" & details & "')"

        Dim updateMachineClickCountSql As String = "update tblMachines set ClickCount = " & clickCount & "Where MachineID = " & machineID & " And ClickCount < " & clickCount

        connection = New SqlConnection(connetionString)

        Try
            connection.Open()
            command = New SqlCommand(insertServiceCallSql, connection)
            command.ExecuteNonQuery()

            command = New SqlCommand(updateMachineClickCountSql, connection)
            command.ExecuteNonQuery()

            command.Dispose()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ResetForm()

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        ResetForm()
        Me.Hide()
    End Sub

    Private Sub chkErrorCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorCodeCheckBox.CheckedChanged

        If ErrorCodeCheckBox.Checked = True Then
            ErrorCodeTextBox.Enabled = True
            ErrorCodeTextBox.Focus()
        Else
            ErrorCodeTextBox.Clear()
            ErrorCodeTextBox.Enabled = False
        End If

    End Sub


    Private Sub cboMachines_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachinesDropDown.SelectedIndexChanged
        Dim selectedMachineID As String = CType(MachinesDropDown.SelectedItem, DataRowView).Row.Item("MachineID").ToString
        UpdateMachineSerialNumber(Int32.Parse(selectedMachineID))
    End Sub

    Private Sub frmNewCall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        NewServiceCallDataSet = New DataSet()
        Dim SelectMachinesSql As String = Nothing
        Dim SelectEmployeesSql As String = Nothing
        Dim SelectServiceCallsSql As String = Nothing
        SelectMachinesSql = "select * from tblManufacturers tman inner join tblMachines tmach on tman.ManufacturerID = tmach.ManufacturerID"
        SelectEmployeesSql = "select *, FirstName + ' ' + LastName as EmployeeName from tblEmployees"
        SelectServiceCallsSql = "select * from tblServiceCalls tmc inner join tblMachines tm on tmc.MachineID = tm.MachineID order by ServiceCallDate desc"
        connection = New SqlConnection(connetionString)

        Try
            connection.Open()
            command = New SqlCommand(SelectMachinesSql, connection)
            adapter.SelectCommand = command
            adapter.Fill(NewServiceCallDataSet.Tables().Add("Machines"))
            command = New SqlCommand(SelectEmployeesSql, connection)
            adapter.SelectCommand = command
            adapter.Fill(NewServiceCallDataSet.Tables().Add("Employees"))
            command = New SqlCommand(SelectServiceCallsSql, connection)
            adapter.SelectCommand = command
            adapter.Fill(NewServiceCallDataSet.Tables().Add("Service_Calls"))
            adapter.Dispose()
            command.Dispose()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MachinesDropDown.DataSource = NewServiceCallDataSet.Tables(0)
        MachinesDropDown.ValueMember = "MachineID"
        MachinesDropDown.DisplayMember = "MachineName"
        EmployeeNameDropDown.DataSource = NewServiceCallDataSet.Tables(1)
        EmployeeNameDropDown.ValueMember = "EmployeeID"
        EmployeeNameDropDown.DisplayMember = "EmployeeName"

        Dim selectedMachineID As Int32 = MachinesDropDown.SelectedValue
        Dim selectedEmployeeID As Int32 = EmployeeNameDropDown.SelectedValue

        UpdateMachineSerialNumber(selectedMachineID)

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub UpdateMachineSerialNumber(machineID As Int32)

        Dim serialNo As String = Nothing
        Dim row As DataRow() = NewServiceCallDataSet.Tables("Machines").Select("MachineID = " & machineID)

        If row.Count > 0 Then
            serialNo = row(0).Item("SerialNumber")
        End If

        SerialNumberTextLabel.Text = serialNo
    End Sub

    Private Sub ResetForm()
        CurrentClickCountTextBox.Text = ""
        CallNotesTextBox.Text = ""
        ErrorCodeTextBox.Text = ""
        ErrorCodeCheckBox.Checked = False
        RequireAfterHoursCheckBox.Checked = False
        MachinesDropDown.SelectedIndex = 0
        EmployeeNameDropDown.SelectedIndex = 0
        JammingRadioButton.Checked = False
        StreakingRadioButton.Checked = False
        SoftwareRadioButton.Checked = False
        OtherRadioButton.Checked = False
    End Sub
End Class
