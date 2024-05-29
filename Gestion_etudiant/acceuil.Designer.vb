<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acceuil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilieresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NiveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesFilieresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActeDeVenteDeTerrainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActeDeNaissancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActeDemariagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActeDeVentesDeTerrainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ListeDesFilieresToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FilieresToolStripMenuItem, Me.ToolStripMenuItem2, Me.NiveauToolStripMenuItem, Me.ToolStripMenuItem3, Me.ActeDeVenteDeTerrainsToolStripMenuItem, Me.ToolStripMenuItem5})
        Me.OuvrirToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!)
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.OuvrirToolStripMenuItem.Text = "AJOUTER"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(244, 6)
        '
        'FilieresToolStripMenuItem
        '
        Me.FilieresToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilieresToolStripMenuItem.Name = "FilieresToolStripMenuItem"
        Me.FilieresToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.FilieresToolStripMenuItem.Text = "Acte de Mariage"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(244, 6)
        '
        'NiveauToolStripMenuItem
        '
        Me.NiveauToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiveauToolStripMenuItem.Name = "NiveauToolStripMenuItem"
        Me.NiveauToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.NiveauToolStripMenuItem.Text = "Acte de Naissance"
        '
        'ListeDesFilieresToolStripMenuItem
        '
        Me.ListeDesFilieresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ActeDeNaissancesToolStripMenuItem, Me.ToolStripMenuItem6, Me.ActeDemariagesToolStripMenuItem, Me.ToolStripMenuItem7, Me.ActeDeVentesDeTerrainsToolStripMenuItem, Me.ToolStripMenuItem8})
        Me.ListeDesFilieresToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeDesFilieresToolStripMenuItem.Name = "ListeDesFilieresToolStripMenuItem"
        Me.ListeDesFilieresToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.ListeDesFilieresToolStripMenuItem.Text = "Les Listes + Modifications"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!)
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(244, 6)
        '
        'ActeDeVenteDeTerrainsToolStripMenuItem
        '
        Me.ActeDeVenteDeTerrainsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActeDeVenteDeTerrainsToolStripMenuItem.Name = "ActeDeVenteDeTerrainsToolStripMenuItem"
        Me.ActeDeVenteDeTerrainsToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.ActeDeVenteDeTerrainsToolStripMenuItem.Text = "Acte de Vente de terrains"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(200, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(244, 6)
        '
        'ActeDeNaissancesToolStripMenuItem
        '
        Me.ActeDeNaissancesToolStripMenuItem.Name = "ActeDeNaissancesToolStripMenuItem"
        Me.ActeDeNaissancesToolStripMenuItem.Size = New System.Drawing.Size(253, 24)
        Me.ActeDeNaissancesToolStripMenuItem.Text = "Acte de naissance"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(200, 6)
        '
        'ActeDemariagesToolStripMenuItem
        '
        Me.ActeDemariagesToolStripMenuItem.Name = "ActeDemariagesToolStripMenuItem"
        Me.ActeDemariagesToolStripMenuItem.Size = New System.Drawing.Size(253, 24)
        Me.ActeDemariagesToolStripMenuItem.Text = "Acte de mariage"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(250, 6)
        '
        'ActeDeVentesDeTerrainsToolStripMenuItem
        '
        Me.ActeDeVentesDeTerrainsToolStripMenuItem.Name = "ActeDeVentesDeTerrainsToolStripMenuItem"
        Me.ActeDeVentesDeTerrainsToolStripMenuItem.Size = New System.Drawing.Size(253, 24)
        Me.ActeDeVentesDeTerrainsToolStripMenuItem.Text = "Acte de Ventes de terrains"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(250, 6)
        '
        'acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 426)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "acceuil"
        Me.Text = "Acceuil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FilieresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents NiveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesFilieresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ActeDeVenteDeTerrainsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ActeDeNaissancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents ActeDemariagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents ActeDeVentesDeTerrainsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
End Class
