Imports System.Data.OleDb
Public Class actedemariage

    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\godwi\OneDrive\Documents\Visual Studio 2015\Projects\TP\bdd.accdb;Persist Security Info=False"

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub actedemariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomepx, prenomepx, temoinepoux1, nomepse, prenomepse, temoinepoux2, officier_mariant, commune_mariage, datemariage, refe As String

        nomepx = nomepoux.Text
        prenomepx = prenomepoux.Text
        temoinepoux1 = nomtemoin1.Text + " " + prenomtemoin1.Text
        nomepse = nomepouse.Text
        prenomepse = prenomepouse.Text
        temoinepoux2 = nomtemoin2.Text + prenomtemoin2.Text
        officier_mariant = ofiicier.Text
        commune_mariage = commune.Text
        datemariage = datedemariage.Text
        refe = reference.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "insert into actedemariage
                (
                    nomepoux, 
                    prenomepoux, 
                    nomepouse, 
                    prenomepouse, 
                    datemariage, 
                    commune, 
                    temoin1, 
                    temoin2, 
                    officier, 
                    numeroreference
                 )
                values
                (
                    '" & nomepx & "',
                    '" & prenomepx & "',
                    '" & nomepse & "',
                    '" & prenomepse & "',
                    '" & datemariage & "',
                    '" & commune_mariage & "',
                    '" & temoinepoux1 & "',
                    '" & temoinepoux2 & "',
                    '" & officier_mariant & "', 
                    '" & refe & "'
                 )"
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