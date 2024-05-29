Imports System.Data.OleDb
Public Class actedenaissance
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub actedenaissance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub validate_Click(sender As Object, e As EventArgs) Handles validate.Click
        Dim nomenfant, prenomenfant, birthadays, communes, hopitals, nommere, prenonmere, nompere, prenompere, reference As String
        nomenfant = nameEnfant.Text
        prenomenfant = surname.Text
        birthadays = datetime.Text
        communes = commune.Text
        hopitals = hospital.Text
        prenonmere = prenomMere.Text
        nommere = nomMeres.Text
        nompere = nomPeres.Text
        prenompere = prenomPeres.Text
        reference = ref.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "insert into actedenaissance (nom, prenom, datenaissance, commune, hopital, nompere, prenompere, nommere, prenommere, numeroreference) values ('" & nomenfant & "', '" & prenomenfant & "', '" & birthadays & "', '" & communes & "', '" & hopitals & "', '" & nompere & "', '" & prenompere & "', '" & nommere & "', '" & prenonmere & "', '" & reference & "')"
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Enregistrement effectué")
            Else
                MessageBox.Show("Enregistrement non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class