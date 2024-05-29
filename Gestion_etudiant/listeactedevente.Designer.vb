<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listeactedevente
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
        Me.tableau = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.id = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.datedevente = New System.Windows.Forms.DateTimePicker()
        Me.site = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.supperficie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.temoinacheteur = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prenomacheteur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomacheteur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prenomvendeur = New System.Windows.Forms.TextBox()
        Me.temoinvendeur = New System.Windows.Forms.TextBox()
        Me.nomvendeur = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.prixdevente = New System.Windows.Forms.TextBox()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenomenfant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datenaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.commune = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nompere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datedeventes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom_pere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_mere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenommere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hopital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refere = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableau
        '
        Me.tableau.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.n, Me.prenomenfant, Me.datenaissance, Me.commune, Me.reference, Me.nompere, Me.datedeventes, Me.prenom_pere, Me.nom_mere, Me.Prenommere, Me.hopital})
        Me.tableau.Location = New System.Drawing.Point(-1, 0)
        Me.tableau.Name = "tableau"
        Me.tableau.Size = New System.Drawing.Size(721, 188)
        Me.tableau.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(756, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 529)
        Me.Panel1.TabIndex = 63
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(40, 19)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(24, 21)
        Me.id.TabIndex = 44
        Me.id.Text = "id"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 38)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Supprimmer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(12, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 38)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(12, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 38)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Chargé pour modification"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'datedevente
        '
        Me.datedevente.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datedevente.Location = New System.Drawing.Point(171, 432)
        Me.datedevente.Name = "datedevente"
        Me.datedevente.Size = New System.Drawing.Size(180, 20)
        Me.datedevente.TabIndex = 62
        '
        'site
        '
        Me.site.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.site.Location = New System.Drawing.Point(556, 469)
        Me.site.Name = "site"
        Me.site.Size = New System.Drawing.Size(194, 28)
        Me.site.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(391, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Site"
        '
        'supperficie
        '
        Me.supperficie.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supperficie.Location = New System.Drawing.Point(556, 416)
        Me.supperficie.Name = "supperficie"
        Me.supperficie.Size = New System.Drawing.Size(194, 28)
        Me.supperficie.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(387, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Superficie"
        '
        'temoinacheteur
        '
        Me.temoinacheteur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temoinacheteur.Location = New System.Drawing.Point(556, 353)
        Me.temoinacheteur.Name = "temoinacheteur"
        Me.temoinacheteur.Size = New System.Drawing.Size(194, 28)
        Me.temoinacheteur.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 21)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Témoin Acheteur"
        '
        'prenomacheteur
        '
        Me.prenomacheteur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomacheteur.Location = New System.Drawing.Point(556, 299)
        Me.prenomacheteur.Name = "prenomacheteur"
        Me.prenomacheteur.Size = New System.Drawing.Size(194, 28)
        Me.prenomacheteur.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Prénom Acheteur"
        '
        'nomacheteur
        '
        Me.nomacheteur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomacheteur.Location = New System.Drawing.Point(556, 234)
        Me.nomacheteur.Name = "nomacheteur"
        Me.nomacheteur.Size = New System.Drawing.Size(194, 28)
        Me.nomacheteur.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Nom Acheteur"
        '
        'prenomvendeur
        '
        Me.prenomvendeur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomvendeur.Location = New System.Drawing.Point(171, 295)
        Me.prenomvendeur.Name = "prenomvendeur"
        Me.prenomvendeur.Size = New System.Drawing.Size(180, 28)
        Me.prenomvendeur.TabIndex = 50
        '
        'temoinvendeur
        '
        Me.temoinvendeur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temoinvendeur.Location = New System.Drawing.Point(171, 353)
        Me.temoinvendeur.Name = "temoinvendeur"
        Me.temoinvendeur.Size = New System.Drawing.Size(180, 28)
        Me.temoinvendeur.TabIndex = 49
        '
        'nomvendeur
        '
        Me.nomvendeur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomvendeur.Location = New System.Drawing.Point(171, 238)
        Me.nomvendeur.Name = "nomvendeur"
        Me.nomvendeur.Size = New System.Drawing.Size(180, 28)
        Me.nomvendeur.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 241)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 21)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Nom Vendeur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Prénom Vendeur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Témoin Vendeur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Date de Vente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 21)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Prix de Vente"
        '
        'prixdevente
        '
        Me.prixdevente.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prixdevente.Location = New System.Drawing.Point(171, 488)
        Me.prixdevente.Name = "prixdevente"
        Me.prixdevente.Size = New System.Drawing.Size(180, 28)
        Me.prixdevente.TabIndex = 68
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Width = 20
        '
        'n
        '
        Me.n.FillWeight = 70.0!
        Me.n.HeaderText = "Nom du Vendeur"
        Me.n.Name = "n"
        Me.n.ReadOnly = True
        Me.n.Width = 60
        '
        'prenomenfant
        '
        Me.prenomenfant.FillWeight = 70.0!
        Me.prenomenfant.HeaderText = "Prenom du Vendeur"
        Me.prenomenfant.Name = "prenomenfant"
        Me.prenomenfant.ReadOnly = True
        Me.prenomenfant.Width = 60
        '
        'datenaissance
        '
        Me.datenaissance.FillWeight = 70.0!
        Me.datenaissance.HeaderText = "Témoin Vendeur"
        Me.datenaissance.Name = "datenaissance"
        Me.datenaissance.ReadOnly = True
        Me.datenaissance.Width = 60
        '
        'commune
        '
        Me.commune.FillWeight = 70.0!
        Me.commune.HeaderText = "Nom Acheteur"
        Me.commune.Name = "commune"
        Me.commune.ReadOnly = True
        Me.commune.Width = 60
        '
        'reference
        '
        Me.reference.HeaderText = "Prénom Acheteur"
        Me.reference.Name = "reference"
        Me.reference.ReadOnly = True
        Me.reference.Width = 60
        '
        'nompere
        '
        Me.nompere.FillWeight = 70.0!
        Me.nompere.HeaderText = "Témoin Acheteur"
        Me.nompere.Name = "nompere"
        Me.nompere.ReadOnly = True
        Me.nompere.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nompere.Width = 60
        '
        'datedeventes
        '
        Me.datedeventes.HeaderText = "Date de Vente"
        Me.datedeventes.Name = "datedeventes"
        Me.datedeventes.ReadOnly = True
        Me.datedeventes.Width = 60
        '
        'prenom_pere
        '
        Me.prenom_pere.FillWeight = 70.0!
        Me.prenom_pere.HeaderText = "Superficie"
        Me.prenom_pere.Name = "prenom_pere"
        Me.prenom_pere.ReadOnly = True
        Me.prenom_pere.Width = 60
        '
        'nom_mere
        '
        Me.nom_mere.FillWeight = 70.0!
        Me.nom_mere.HeaderText = "Site"
        Me.nom_mere.Name = "nom_mere"
        Me.nom_mere.ReadOnly = True
        Me.nom_mere.Width = 60
        '
        'Prenommere
        '
        Me.Prenommere.FillWeight = 70.0!
        Me.Prenommere.HeaderText = "Prix de Vente"
        Me.Prenommere.Name = "Prenommere"
        Me.Prenommere.ReadOnly = True
        Me.Prenommere.Width = 60
        '
        'hopital
        '
        Me.hopital.HeaderText = "Référence"
        Me.hopital.Name = "hopital"
        Me.hopital.ReadOnly = True
        Me.hopital.Width = 60
        '
        'refere
        '
        Me.refere.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refere.Location = New System.Drawing.Point(253, 194)
        Me.refere.Name = "refere"
        Me.refere.Size = New System.Drawing.Size(194, 28)
        Me.refere.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Référence"
        '
        'listeactedevente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 541)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.refere)
        Me.Controls.Add(Me.prixdevente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datedevente)
        Me.Controls.Add(Me.site)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.supperficie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.temoinacheteur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prenomacheteur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nomacheteur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prenomvendeur)
        Me.Controls.Add(Me.temoinvendeur)
        Me.Controls.Add(Me.nomvendeur)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tableau)
        Me.Name = "listeactedevente"
        Me.Text = "listeactedevente"
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableau As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents id As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents datedevente As DateTimePicker
    Friend WithEvents site As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents supperficie As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents temoinacheteur As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents prenomacheteur As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nomacheteur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents prenomvendeur As TextBox
    Friend WithEvents temoinvendeur As TextBox
    Friend WithEvents nomvendeur As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents prixdevente As TextBox
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents n As DataGridViewTextBoxColumn
    Friend WithEvents prenomenfant As DataGridViewTextBoxColumn
    Friend WithEvents datenaissance As DataGridViewTextBoxColumn
    Friend WithEvents commune As DataGridViewTextBoxColumn
    Friend WithEvents reference As DataGridViewTextBoxColumn
    Friend WithEvents nompere As DataGridViewTextBoxColumn
    Friend WithEvents datedeventes As DataGridViewTextBoxColumn
    Friend WithEvents prenom_pere As DataGridViewTextBoxColumn
    Friend WithEvents nom_mere As DataGridViewTextBoxColumn
    Friend WithEvents Prenommere As DataGridViewTextBoxColumn
    Friend WithEvents hopital As DataGridViewTextBoxColumn
    Friend WithEvents refere As TextBox
    Friend WithEvents Label10 As Label
End Class
