Imports System.Data.OleDb

Public Class listeactedevente
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub listeactedevente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub

    Private Sub afficher()
        Using con As New OleDbConnection(Me.Provider)
            Try
                con.Open()
                Dim sel As String = "SELECT * FROM actedevente"
                Using command As New OleDbCommand(sel, con)
                    Using ret As OleDbDataReader = command.ExecuteReader()
                        tableau.Rows.Clear()
                        While ret.Read()
                            tableau.Rows.Add(
                                ret.Item("id"),
                                ret.Item("nomvendeur"),
                                ret.Item("prenomvendeur"),
                                ret.Item("temoin1"),
                                ret.Item("nomacheteur"),
                                ret.Item("prenomacheteur"),
                                ret.Item("temoin2"),
                                ret.Item("datevente"),
                                ret.Item("superficie"),
                                ret.Item("site"),
                                ret.Item("prixvente"),
                                ret.Item("reference")
                            )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tableau.CurrentRow IsNot Nothing Then
            id.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value.ToString()
            nomvendeur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value.ToString()
            prenomvendeur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(2).Value.ToString()
            temoinvendeur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(3).Value.ToString()
            nomacheteur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(4).Value.ToString()
            prenomacheteur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(5).Value.ToString()
            temoinacheteur.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value.ToString()
            datedevente.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(7).Value.ToString()
            supperficie.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(8).Value.ToString()
            site.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(9).Value.ToString()
            prixdevente.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(10).Value.ToString()
            refere.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(11).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim idd, nomduvendeur, prenomduvendeur, temoinduvendeur, nomdelacheteur, prenomdelacheteur, temoindelacheteur, datedelavente, superficie, sitesvendu, referess, prixdelavente As String
        idd = id.Text
        nomduvendeur = nomvendeur.Text
        prenomduvendeur = nomvendeur.Text
        temoinduvendeur = temoinvendeur.Text
        nomdelacheteur = nomacheteur.Text
        prenomdelacheteur = prenomacheteur.Text
        referess = refere.Text
        temoindelacheteur = temoinacheteur.Text
        datedelavente = datedevente.Text
        superficie = supperficie.Text
        sitesvendu = site.Text
        prixdelavente = prixdevente.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update actedevente set 
                                        nomvendeur = '" & nomduvendeur & "', 
                                        prenomvendeur = '" & prenomduvendeur & "', 
                                        nomacheteur = '" & nomdelacheteur & "', 
                                        prenomacheteur = '" & prenomdelacheteur & "', 
                                        site = '" & sitesvendu & "', 
                                        superficie = '" & superficie & "', 
                                        prixvente = '" & prixdelavente & "', 
                                        datevente = '" & datedelavente & "', 
                                        temoin1 = '" & temoindelacheteur & "', 
                                        temoin2 = '" & temoinduvendeur & "',
                                        reference = '" & referess & "'

                                        where id =" & idd
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
            Dim req As String = "Delete * from actedevente where id = " & id
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