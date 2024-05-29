Public Class acceuil
    Private Sub acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FilieresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilieresToolStripMenuItem.Click
        Dim actedemariageadd As New actedemariage
        actedemariageadd.MdiParent = Me
        actedemariageadd.Show()

    End Sub

    Private Sub NiveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NiveauToolStripMenuItem.Click
        Dim actedenaissanceadd As New actedenaissance
        actedenaissanceadd.MdiParent = Me
        actedenaissanceadd.Show()
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click

    End Sub

    Private Sub ListeEtudiantToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim list_etu As New listeactedemariage
        list_etu.MdiParent = Me
        list_etu.Show()
    End Sub

    Private Sub ListeDesFilieresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesFilieresToolStripMenuItem.Click

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click

    End Sub

    Private Sub ActeDeVenteDeTerrainsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActeDeVenteDeTerrainsToolStripMenuItem.Click
        Dim actedeventeadd As New acteterrainsdevente
        actedeventeadd.MdiParent = Me
        actedeventeadd.Show()
    End Sub

    Private Sub ActeDeNaissancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActeDeNaissancesToolStripMenuItem.Click
        Dim admin As New admin
        admin.MdiParent = Me
        admin.Show()
    End Sub
End Class
