Imports System.Data.SqlClient

Public Class NewEquipmentForm

    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim FormDataSet As DataSet
    Dim getManufacturersQuery As String = "select * from tblManufacturers tmf"

    Dim connectionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub

    Private Sub NewEquipmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDataSet = New DataSet()
        connection = New SqlConnection(connectionString)
        command = New SqlCommand(getManufacturersQuery, connection)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(FormDataSet)

        connection.Close()
        command.Dispose()
        connection.Dispose()
        adapter.Dispose()

        ManufacturerDropDown.DataSource = FormDataSet.Tables(0)
        ManufacturerDropDown.ValueMember = "ManufacturerID"
        ManufacturerDropDown.DisplayMember = "ManufacturerName"

        MachineNameTextBox.Focus()

    End Sub

    Private Sub AddManufacturerButton_Click(sender As Object, e As EventArgs) Handles AddManufacturerButton.Click
        NewManufacturerForm.ShowDialog()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim selectedManufacturerID As String
        Dim machineName As String
        Dim machineNumber As String
        Dim serialNumber As String

        selectedManufacturerID = CType(ManufacturerDropDown.SelectedItem, DataRowView).Row.Item("ManufacturerID")

        machineName = MachineNameTextBox.Text.Trim()
        machineNumber = MachineNumberTextBox.Text.Trim()
        serialNumber = SerialNumberTextBox.Text.Trim()

        If machineName.Length > 0 And machineNumber.Length > 0 And serialNumber.Length > 0 Then
            Dim addEquipmentQuery As String = "insert into tblMachines (MachineName,
                                                    MachineNumber, SerialNumber,
                                                    Status, ManufacturerID)
                                                values ('" &
                                                machineName & "', '" &
                                                machineNumber & "', " & "'" &
                                                serialNumber & "', 'A', " &
                                                selectedManufacturerID & ")"

            connection = New SqlConnection(connectionString)
            command = New SqlCommand(addEquipmentQuery, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            command.Dispose()
            connection.Dispose()

            Me.Hide()

        End If

    End Sub
End Class