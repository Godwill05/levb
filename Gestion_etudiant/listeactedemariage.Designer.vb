<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listeactedemariage
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
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomenfat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenomenfant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datenaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.commune = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nompere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom_pere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_mere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenommere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hopital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.epouxname = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.epousename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.epouxsurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.epousesurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.communes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.temoin1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.temoin2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.officier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.references = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mariagedate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.id = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableau
        '
        Me.tableau.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.nomenfat, Me.prenomenfant, Me.datenaissance, Me.commune, Me.reference, Me.nompere, Me.prenom_pere, Me.nom_mere, Me.Prenommere, Me.hopital})
        Me.tableau.Location = New System.Drawing.Point(-2, -1)
        Me.tableau.Name = "tableau"
        Me.tableau.Size = New System.Drawing.Size(757, 188)
        Me.tableau.TabIndex = 19
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Width = 20
        '
        'nomenfat
        '
        Me.nomenfat.FillWeight = 70.0!
        Me.nomenfat.HeaderText = "Nom de l'epoux"
        Me.nomenfat.Name = "nomenfat"
        Me.nomenfat.ReadOnly = True
        Me.nomenfat.Width = 70
        '
        'prenomenfant
        '
        Me.prenomenfant.FillWeight = 70.0!
        Me.prenomenfant.HeaderText = "Prenom de l'epoux"
        Me.prenomenfant.Name = "prenomenfant"
        Me.prenomenfant.ReadOnly = True
        Me.prenomenfant.Width = 70
        '
        'datenaissance
        '
        Me.datenaissance.FillWeight = 70.0!
        Me.datenaissance.HeaderText = "Nom de l'epouse"
        Me.datenaissance.Name = "datenaissance"
        Me.datenaissance.ReadOnly = True
        Me.datenaissance.Width = 70
        '
        'commune
        '
        Me.commune.FillWeight = 70.0!
        Me.commune.HeaderText = "Prenom de l'epouse"
        Me.commune.Name = "commune"
        Me.commune.ReadOnly = True
        Me.commune.Width = 70
        '
        'reference
        '
        Me.reference.HeaderText = "Date de Mariage"
        Me.reference.Name = "reference"
        Me.reference.ReadOnly = True
        Me.reference.Width = 70
        '
        'nompere
        '
        Me.nompere.FillWeight = 70.0!
        Me.nompere.HeaderText = "Commune"
        Me.nompere.Name = "nompere"
        Me.nompere.ReadOnly = True
        Me.nompere.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nompere.Width = 70
        '
        'prenom_pere
        '
        Me.prenom_pere.FillWeight = 70.0!
        Me.prenom_pere.HeaderText = "Témoin epoux"
        Me.prenom_pere.Name = "prenom_pere"
        Me.prenom_pere.ReadOnly = True
        Me.prenom_pere.Width = 70
        '
        'nom_mere
        '
        Me.nom_mere.FillWeight = 70.0!
        Me.nom_mere.HeaderText = "Témoin epouse"
        Me.nom_mere.Name = "nom_mere"
        Me.nom_mere.ReadOnly = True
        Me.nom_mere.Width = 70
        '
        'Prenommere
        '
        Me.Prenommere.FillWeight = 70.0!
        Me.Prenommere.HeaderText = "Officier"
        Me.Prenommere.Name = "Prenommere"
        Me.Prenommere.ReadOnly = True
        Me.Prenommere.Width = 70
        '
        'hopital
        '
        Me.hopital.HeaderText = "Référence"
        Me.hopital.Name = "hopital"
        Me.hopital.ReadOnly = True
        Me.hopital.Width = 70
        '
        'epouxname
        '
        Me.epouxname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epouxname.Location = New System.Drawing.Point(134, 223)
        Me.epouxname.Name = "epouxname"
        Me.epouxname.Size = New System.Drawing.Size(194, 28)
        Me.epouxname.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 223)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 21)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Nom epoux"
        '
        'epousename
        '
        Me.epousename.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epousename.Location = New System.Drawing.Point(134, 335)
        Me.epousename.Name = "epousename"
        Me.epousename.Size = New System.Drawing.Size(194, 28)
        Me.epousename.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nom epouse"
        '
        'epouxsurname
        '
        Me.epouxsurname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epouxsurname.Location = New System.Drawing.Point(134, 280)
        Me.epouxsurname.Name = "epouxsurname"
        Me.epouxsurname.Size = New System.Drawing.Size(194, 28)
        Me.epouxsurname.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Prénom epoux"
        '
        'epousesurname
        '
        Me.epousesurname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epousesurname.Location = New System.Drawing.Point(148, 405)
        Me.epousesurname.Name = "epousesurname"
        Me.epousesurname.Size = New System.Drawing.Size(180, 28)
        Me.epousesurname.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Prénom épouse"
        '
        'communes
        '
        Me.communes.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.communes.Location = New System.Drawing.Point(507, 220)
        Me.communes.Name = "communes"
        Me.communes.Size = New System.Drawing.Size(194, 28)
        Me.communes.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Commune"
        '
        'temoin1
        '
        Me.temoin1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temoin1.Location = New System.Drawing.Point(519, 284)
        Me.temoin1.Name = "temoin1"
        Me.temoin1.Size = New System.Drawing.Size(182, 28)
        Me.temoin1.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Témoin epoux"
        '
        'temoin2
        '
        Me.temoin2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temoin2.Location = New System.Drawing.Point(507, 339)
        Me.temoin2.Name = "temoin2"
        Me.temoin2.Size = New System.Drawing.Size(194, 28)
        Me.temoin2.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Témoin épouse"
        '
        'officier
        '
        Me.officier.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officier.Location = New System.Drawing.Point(507, 409)
        Me.officier.Name = "officier"
        Me.officier.Size = New System.Drawing.Size(194, 28)
        Me.officier.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 21)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Officier"
        '
        'references
        '
        Me.references.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.references.Location = New System.Drawing.Point(583, 458)
        Me.references.Name = "references"
        Me.references.Size = New System.Drawing.Size(194, 28)
        Me.references.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(461, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Référence"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 21)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Date de mariage"
        '
        'mariagedate
        '
        Me.mariagedate.Location = New System.Drawing.Point(148, 465)
        Me.mariagedate.Name = "mariagedate"
        Me.mariagedate.Size = New System.Drawing.Size(180, 20)
        Me.mariagedate.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(783, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 520)
        Me.Panel1.TabIndex = 46
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(40, 19)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(86, 21)
        Me.id.TabIndex = 44
        Me.id.Text = "Reference"
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
        'listeactedemariage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mariagedate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.references)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.officier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.temoin2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.temoin1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.communes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.epousesurname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.epouxsurname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.epousename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.epouxname)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tableau)
        Me.Name = "listeactedemariage"
        Me.Text = "listeactedemariage"
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableau As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents nomenfat As DataGridViewTextBoxColumn
    Friend WithEvents prenomenfant As DataGridViewTextBoxColumn
    Friend WithEvents datenaissance As DataGridViewTextBoxColumn
    Friend WithEvents commune As DataGridViewTextBoxColumn
    Friend WithEvents reference As DataGridViewTextBoxColumn
    Friend WithEvents nompere As DataGridViewTextBoxColumn
    Friend WithEvents prenom_pere As DataGridViewTextBoxColumn
    Friend WithEvents nom_mere As DataGridViewTextBoxColumn
    Friend WithEvents Prenommere As DataGridViewTextBoxColumn
    Friend WithEvents hopital As DataGridViewTextBoxColumn
    Friend WithEvents epouxname As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents epousename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents epouxsurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents epousesurname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents communes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents temoin1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents temoin2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents officier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents references As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents mariagedate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents id As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
