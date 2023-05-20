Imports System.Data.SqlClient

Public Class ServiceCallHistory

    Dim connection As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim command As SqlCommand
    Dim FormDataSet As DataSet
    Dim connectionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"
    Dim getServiceCallsQuery As String = "select ServiceCallID, ServiceCallDate, tm.MachineName, tm.MachineNumber, ErrorCode, Details,
                                            AfterHours, QuickDiagnostics, tsc.ClickCount, te.FirstName + ' ' + te.LastName as EmployeeName from tblServiceCalls tsc
                                            inner join tblMachines tm on
                                            tsc.MachineID = tm.MachineID

                                            inner join tblEmployees te on
                                            tsc.EmployeeID = te.EmployeeID"

    Private Sub ServiceCallHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormDataSet = New DataSet()
        connection = New SqlConnection(connectionString)
        command = New SqlCommand(getServiceCallsQuery, connection)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(FormDataSet)

        ExistingCallsGridView.DataSource = FormDataSet.Tables(0)
        ExistingCallsGridView.EditMode = DataGridViewEditMode.EditProgrammatically

        command.Dispose()
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub

End Class