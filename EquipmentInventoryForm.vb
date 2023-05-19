Imports System.Data.SqlClient

Public Class EquipmentInventoryForm

    Dim connection As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim command As SqlCommand
    Dim FormDataSet As DataSet
    Dim connetionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"
    Dim getServiceCallsQuery As String = "Select tm.MachineID,tmf.ManufacturerName,tm.MachineName,tm.MachineNumber,tm.SerialNumber,
                                            (select top 1 ClickCount from tblServiceCalls tsc where tsc.MachineID = tm.MachineID) as ClickCount,
                                            tm.InServiceDate,tm.Status from tblMachines tm
                                            inner join tblManufacturers tmf on
                                            tmf.ManufacturerID = tm.ManufacturerID"
    Private Sub EquipmentInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDataSet = New DataSet()
        connection = New SqlConnection(connetionString)
        command = New SqlCommand(getServiceCallsQuery, connection)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(FormDataSet)

        EquipmentInventoryGridView.DataSource = FormDataSet.Tables(0)
        EquipmentInventoryGridView.EditMode = DataGridViewEditMode.EditProgrammatically

        command.Dispose()
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class