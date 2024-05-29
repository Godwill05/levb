Imports System.Data.OleDb
Public Class listeactedemariage
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub listeactedemariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
    End Sub

    Private Sub afficher()
        Using con As New OleDbConnection(Me.Provider)
            Try
                con.Open()
                Dim sel As String = "SELECT * FROM actedemariage"
                Using command As New OleDbCommand(sel, con)
                    Using ret As OleDbDataReader = command.ExecuteReader()
                        tableau.Rows.Clear()
                        While ret.Read()
                            tableau.Rows.Add(
                                ret.Item("id"),
                                ret.Item("nomepoux"),
                                ret.Item("prenomepoux"),
                                ret.Item("nomepouse"),
                                ret.Item("prenomepouse"),
                                ret.Item("datemariage"),
                                ret.Item("commune"),
                                ret.Item("temoin1"),
                                ret.Item("temoin2"),
                                ret.Item("officier"),
                                ret.Item("numeroreference")
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
            epouxname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value.ToString()
            epouxsurname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(2).Value.ToString()
            epousename.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(3).Value.ToString()
            epousesurname.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(4).Value.ToString()
            mariagedate.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(5).Value.ToString()
            communes.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value.ToString()
            temoin1.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(7).Value.ToString()
            temoin2.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(8).Value.ToString()
            officier.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(9).Value.ToString()
            references.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(10).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim idd, nomepoux, prenomepoux, nomepouse, prenomepouse, datedemariage, communesdemariage, temoinss1, temoinss2, officiers, refere As String
        idd = id.Text
        nomepoux = epouxname.Text
        prenomepoux = epouxsurname.Text
        nomepouse = epousename.Text
        prenomepouse = epousesurname.Text
        refere = references.Text
        communesdemariage = communes.Text
        temoinss1 = temoin1.Text
        temoinss2 = temoin2.Text
        officiers = officier.Text
        datedemariage = mariagedate.Text
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update actedemariage set 
                                        nomepoux = '" & nomepoux & "', 
                                        prenomepoux = '" & prenomepoux & "', 
                                        nomepouse = '" & nomepouse & "', 
                                        prenomepouse = '" & prenomepouse & "', 
                                        datemariage = '" & datedemariage & "', 
                                        commune = '" & communesdemariage & "', 
                                        temoin1 = '" & temoinss1 & "', 
                                        temoin2 = '" & temoinss2 & "', 
                                        officier = '" & officiers & "', 
                                        numeroreference = '" & refere & "'

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
            Dim req As String = "Delete * from actedemariage where id = " & id
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