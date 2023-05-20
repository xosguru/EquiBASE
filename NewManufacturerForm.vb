Imports System.Data.SqlClient

Public Class NewManufacturerForm

    Dim connectionString As String = "data source=DEVSQL;initial catalog=EquiBASE;integrated security=SSPI;persist security info=False;packet size=4096"

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim manufacturerName As String
        Dim manufacturerPhone As String
        Dim manufacturerSupportEmail As String

        manufacturerName = ManufacturerNameTextBox.Text.Trim()
        manufacturerPhone = ManufacturerPhoneTextBox.Text.Trim()
        manufacturerSupportEmail = ManufacturerSupportEmailTextBox.Text.Trim()

        If manufacturerName.Length > 0 Then
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim addManufacturerQuery As String = "insert into tblManufacturers (ManufacturerName, ManufacturerPhone, ManufacturerSupportEmail)
                                                values ('" & manufacturerName & "', '" & manufacturerPhone & "', '" & manufacturerSupportEmail & "')"
            Dim command As SqlCommand = New SqlCommand(addManufacturerQuery, connection)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            command.Dispose()
            connection.Dispose()

            Me.Hide()

        End If

    End Sub

    Private Sub NewManufacturerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManufacturerNameTextBox.Focus()
    End Sub
End Class