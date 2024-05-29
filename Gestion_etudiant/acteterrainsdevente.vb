Imports System.Data.OleDb

Public Class acteterrainsdevente
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"
    Private Sub acteterrainsdevente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomv, prenomv, temoin1, temoin2, noma, prenoma, si, super, prix, dateven, ref As String

        nomv = nomevendeur.Text
        prenomv = prenomvendeur.Text
        temoin1 = nomtemoin1.Text + " " + prenomtemoin1.Text
        temoin2 = nomtemoin2.Text + " " + prenomtemoin2.Text

        noma = nomacheteur.Text
        prenoma = prenomacheteur.Text
        si = site.Text
        super = superficie.Text
        prix = prixvente.Text
        dateven = datevente.Text
        ref = reference.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "insert into actedevente 
                                    (
                                        nomvendeur, 
                                        prenomvendeur,
                                        nomacheteur, 
                                        prenomacheteur, 
                                        site, 
                                        superficie, 
                                        prixvente, 
                                        datevente, 
                                        temoin1, 
                                        temoin2, 
                                        reference
                                    ) values 
                                            ('" & nomv & "',
                                            '" & prenomv & "',
                                            '" & noma & "',
                                            '" & prenoma & "',
                                            '" & si & "',
                                            '" & super & "',
                                            '" & prix & "',
                                            '" & dateven & "',
                                            '" & temoin1 & "',
                                            '" & temoin2 & "', 
                                            '" & ref & "')"
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