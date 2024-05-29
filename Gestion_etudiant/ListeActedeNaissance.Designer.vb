<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeActedeNaissance
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tableau = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomenfat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenomenfant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datenaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.commune = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nompere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom_pere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_mere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenommere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hopital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ref = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.TextBox()
        Me.referen = New System.Windows.Forms.TextBox()
        Me.commue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dadname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.hospital = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mumsurname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mumname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dadsurname = New System.Windows.Forms.TextBox()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableau
        '
        Me.tableau.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.nomenfat, Me.prenomenfant, Me.datenaissance, Me.commune, Me.nompere, Me.prenom_pere, Me.nom_mere, Me.Prenommere, Me.hopital, Me.reference})
        Me.tableau.Location = New System.Drawing.Point(0, 1)
        Me.tableau.Name = "tableau"
        Me.tableau.Size = New System.Drawing.Size(757, 188)
        Me.tableau.TabIndex = 18
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
        Me.nomenfat.HeaderText = "Nom de L'enfant"
        Me.nomenfat.Name = "nomenfat"
        Me.nomenfat.ReadOnly = True
        Me.nomenfat.Width = 70
        '
        'prenomenfant
        '
        Me.prenomenfant.FillWeight = 70.0!
        Me.prenomenfant.HeaderText = "Prenom de L'enfant"
        Me.prenomenfant.Name = "prenomenfant"
        Me.prenomenfant.ReadOnly = True
        Me.prenomenfant.Width = 70
        '
        'datenaissance
        '
        Me.datenaissance.FillWeight = 70.0!
        Me.datenaissance.HeaderText = "Date de Naissance"
        Me.datenaissance.Name = "datenaissance"
        Me.datenaissance.ReadOnly = True
        Me.datenaissance.Width = 70
        '
        'commune
        '
        Me.commune.FillWeight = 70.0!
        Me.commune.HeaderText = "Commune"
        Me.commune.Name = "commune"
        Me.commune.ReadOnly = True
        Me.commune.Width = 70
        '
        'nompere
        '
        Me.nompere.FillWeight = 70.0!
        Me.nompere.HeaderText = "Nom du Père"
        Me.nompere.Name = "nompere"
        Me.nompere.ReadOnly = True
        Me.nompere.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nompere.Width = 70
        '
        'prenom_pere
        '
        Me.prenom_pere.FillWeight = 70.0!
        Me.prenom_pere.HeaderText = "Prenom Père"
        Me.prenom_pere.Name = "prenom_pere"
        Me.prenom_pere.ReadOnly = True
        Me.prenom_pere.Width = 70
        '
        'nom_mere
        '
        Me.nom_mere.FillWeight = 70.0!
        Me.nom_mere.HeaderText = "Nom Mère"
        Me.nom_mere.Name = "nom_mere"
        Me.nom_mere.ReadOnly = True
        Me.nom_mere.Width = 70
        '
        'Prenommere
        '
        Me.Prenommere.FillWeight = 70.0!
        Me.Prenommere.HeaderText = "Prénom Mère"
        Me.Prenommere.Name = "Prenommere"
        Me.Prenommere.ReadOnly = True
        Me.Prenommere.Width = 70
        '
        'hopital
        '
        Me.hopital.HeaderText = "Hopital"
        Me.hopital.Name = "hopital"
        Me.hopital.ReadOnly = True
        Me.hopital.Width = 70
        '
        'reference
        '
        Me.reference.HeaderText = "Référence"
        Me.reference.Name = "reference"
        Me.reference.ReadOnly = True
        Me.reference.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Référence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Commune"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ref)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(763, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 520)
        Me.Panel1.TabIndex = 43
        '
        'ref
        '
        Me.ref.AutoSize = True
        Me.ref.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.Location = New System.Drawing.Point(50, 19)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(86, 21)
        Me.ref.TabIndex = 44
        Me.ref.Text = "Reference"
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 21)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Nom de l'enfant"
        '
        'name
        '
        Me.name.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(157, 194)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(194, 28)
        Me.name.TabIndex = 23
        '
        'referen
        '
        Me.referen.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referen.Location = New System.Drawing.Point(157, 419)
        Me.referen.Name = "referen"
        Me.referen.Size = New System.Drawing.Size(194, 28)
        Me.referen.TabIndex = 25
        '
        'commue
        '
        Me.commue.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commue.Location = New System.Drawing.Point(155, 357)
        Me.commue.Name = "commue"
        Me.commue.Size = New System.Drawing.Size(196, 28)
        Me.commue.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Date de naissance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Prénom de l'enfant"
        '
        'surname
        '
        Me.surname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(177, 236)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(174, 28)
        Me.surname.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nom du père"
        '
        'dadname
        '
        Me.dadname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadname.Location = New System.Drawing.Point(565, 194)
        Me.dadname.Name = "dadname"
        Me.dadname.Size = New System.Drawing.Size(194, 28)
        Me.dadname.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Hopital"
        '
        'hospital
        '
        Me.hospital.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hospital.Location = New System.Drawing.Point(565, 419)
        Me.hospital.Name = "hospital"
        Me.hospital.Size = New System.Drawing.Size(194, 28)
        Me.hospital.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Prénom de la mère"
        '
        'mumsurname
        '
        Me.mumsurname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mumsurname.Location = New System.Drawing.Point(577, 357)
        Me.mumsurname.Name = "mumsurname"
        Me.mumsurname.Size = New System.Drawing.Size(182, 28)
        Me.mumsurname.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Nom de la mère"
        '
        'mumname
        '
        Me.mumname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mumname.Location = New System.Drawing.Point(565, 296)
        Me.mumname.Name = "mumname"
        Me.mumname.Size = New System.Drawing.Size(194, 28)
        Me.mumname.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Prenom du Père"
        '
        'dadsurname
        '
        Me.dadsurname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadsurname.Location = New System.Drawing.Point(565, 236)
        Me.dadsurname.Name = "dadsurname"
        Me.dadsurname.Size = New System.Drawing.Size(194, 28)
        Me.dadsurname.TabIndex = 41
        '
        'birthday
        '
        Me.birthday.Location = New System.Drawing.Point(177, 303)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(174, 20)
        Me.birthday.TabIndex = 44
        '
        'ListeActedeNaissance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 520)
        Me.Controls.Add(Me.birthday)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dadsurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mumname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mumsurname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hospital)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dadname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.commue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.referen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tableau)
        Me.Text = "Acte de naissance"
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
    Friend WithEvents nompere As DataGridViewTextBoxColumn
    Friend WithEvents prenom_pere As DataGridViewTextBoxColumn
    Friend WithEvents nom_mere As DataGridViewTextBoxColumn
    Friend WithEvents Prenommere As DataGridViewTextBoxColumn
    Friend WithEvents hopital As DataGridViewTextBoxColumn
    Friend WithEvents reference As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents name As TextBox
    Friend WithEvents referen As TextBox
    Friend WithEvents commue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents surname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dadname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents hospital As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mumsurname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mumname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dadsurname As TextBox
    Friend WithEvents ref As Label
    Friend WithEvents birthday As DateTimePicker
End Class
