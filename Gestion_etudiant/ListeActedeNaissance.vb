Imports System.Data.OleDb
Public Class ListeActedeNaissance
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub afficher()
        Using con As New OleDbConnection(Me.Provider)
            Try
                con.Open()
                Dim sel As String = "SELECT * FROM actedenaissance"
                Using command As New OleDbCommand(sel, con)
                    Using ret As OleDbDataReader = command.ExecuteReader()
                        tableau.Rows.Clear()
                        While ret.Read()
                            tableau.Rows.Add(
                                ret.Item("id"),
                                ret.Item("nom"),
                                ret.Item("prenom"),
                                ret.Item("datenaissance"),
                                ret.Item("commune"),
                                ret.Item("nompere"),
                                ret.Item("prenompere"),
                                ret.Item("nommere"),
                                ret.Item("prenommere"),
                                ret.Item("numeroreference"),
                                ret.Item("hopital")
                            )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using

    End Sub


    Private Sub ListeActedeNaissance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tableau.CurrentRow IsNot Nothing Then
            ref.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value.ToString()
            name.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value.ToString()
            surname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(2).Value.ToString()
            birthday.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(3).Value.ToString()
            commue.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(4).Value.ToString()
            referen.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(10).Value.ToString()
            dadname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(5).Value.ToString()
            dadsurname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value.ToString()
            mumname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(7).Value.ToString()
            mumsurname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(8).Value.ToString()
            hospital.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(9).Value.ToString()
        End If


    End Sub

    Private Sub name_TextChanged(sender As Object, e As EventArgs) Handles name.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim refs, names, surnames, birthdays, communes, refrens, dadnames, dadsurnames, mumnames, mumsurnames, hospitals As String
        refs = ref.Text
        names = name.Text
        surnames = surname.Text
        birthdays = birthday.Text
        communes = commue.Text
        refrens = referen.Text
        dadnames = dadname.Text
        dadsurnames = dadsurname.Text
        mumnames = mumname.Text
        mumsurnames = mumsurname.Text
        hospitals = hospital.Text
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update actedenaissance set 
                                        nom = '" & names & "', 
                                        prenom = '" & surnames & "', 
                                        datenaissance = '" & birthdays & "', 
                                        commune = '" & communes & "', 
                                        nompere = '" & dadnames & "', 
                                        prenompere = '" & dadsurnames & "', 
                                        nommere = '" & mumnames & "', 
                                        prenommere = '" & mumsurnames & "', 
                                        numeroreference = '" & refrens & "', 
                                        hopital = '" & hospitals & "'

                                        where id =" & refs
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Modificaton effectué")
                Call afficher()
            Else
                MessageBox.Show("Modificaton non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String
        id = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from actedenaissance where id = " & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Suppression effectué")
                Call afficher()
            Else
                MessageBox.Show("Suppression non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class