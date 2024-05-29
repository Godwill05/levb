Imports System.Data.OleDb

Public Class admin
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminusername, adminpssword As String
        adminusername = username.Text
        adminpssword = password.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Select * from admin where username = '" & adminusername & "' and password = '" & adminpssword & "'"
            Dim command As New OleDbCommand(req, con)
            Dim ret As OleDbDataReader
            ret = command.ExecuteReader

            Do While ret.Read
                MessageBox.Show("Connexion réussie en tant que" + " " + ret.Item("username"))
            Loop
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class