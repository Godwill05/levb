<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acteterrainsdevente
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reference = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.nomtemoin1 = New System.Windows.Forms.TextBox()
        Me.prenomtemoin1 = New System.Windows.Forms.TextBox()
        Me.prenomvendeur = New System.Windows.Forms.TextBox()
        Me.nomevendeur = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datevente = New System.Windows.Forms.DateTimePicker()
        Me.prixvente = New System.Windows.Forms.TextBox()
        Me.superficie = New System.Windows.Forms.TextBox()
        Me.site = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nomtemoin2 = New System.Windows.Forms.TextBox()
        Me.prenomtemoin2 = New System.Windows.Forms.TextBox()
        Me.prenomacheteur = New System.Windows.Forms.TextBox()
        Me.nomacheteur = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.reference)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Location = New System.Drawing.Point(-2, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(941, 144)
        Me.Panel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(267, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 46)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Acte de vente de terrain"
        '
        'reference
        '
        Me.reference.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reference.Location = New System.Drawing.Point(161, 116)
        Me.reference.Name = "reference"
        Me.reference.Size = New System.Drawing.Size(206, 28)
        Me.reference.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(86, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 21)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "N°Réf : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-7, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Le Vendeur"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.nomtemoin1)
        Me.Panel4.Controls.Add(Me.prenomtemoin1)
        Me.Panel4.Controls.Add(Me.prenomvendeur)
        Me.Panel4.Controls.Add(Me.nomevendeur)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel4.Location = New System.Drawing.Point(-2, 183)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(261, 293)
        Me.Panel4.TabIndex = 5
        '
        'nomtemoin1
        '
        Me.nomtemoin1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomtemoin1.Location = New System.Drawing.Point(94, 182)
        Me.nomtemoin1.Name = "nomtemoin1"
        Me.nomtemoin1.Size = New System.Drawing.Size(143, 28)
        Me.nomtemoin1.TabIndex = 8
        '
        'prenomtemoin1
        '
        Me.prenomtemoin1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomtemoin1.Location = New System.Drawing.Point(94, 231)
        Me.prenomtemoin1.Name = "prenomtemoin1"
        Me.prenomtemoin1.Size = New System.Drawing.Size(143, 28)
        Me.prenomtemoin1.TabIndex = 7
        '
        'prenomvendeur
        '
        Me.prenomvendeur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomvendeur.Location = New System.Drawing.Point(94, 86)
        Me.prenomvendeur.Name = "prenomvendeur"
        Me.prenomvendeur.Size = New System.Drawing.Size(143, 28)
        Me.prenomvendeur.TabIndex = 6
        '
        'nomevendeur
        '
        Me.nomevendeur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomevendeur.Location = New System.Drawing.Point(94, 32)
        Me.nomevendeur.Name = "nomevendeur"
        Me.nomevendeur.Size = New System.Drawing.Size(143, 28)
        Me.nomevendeur.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Prénom : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nom : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Informations Témoin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Prénom : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nom : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(664, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Informations complémentaire"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.datevente)
        Me.Panel1.Controls.Add(Me.prixvente)
        Me.Panel1.Controls.Add(Me.superficie)
        Me.Panel1.Controls.Add(Me.site)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel1.Location = New System.Drawing.Point(678, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 293)
        Me.Panel1.TabIndex = 9
        '
        'datevente
        '
        Me.datevente.Location = New System.Drawing.Point(135, 238)
        Me.datevente.Name = "datevente"
        Me.datevente.Size = New System.Drawing.Size(116, 20)
        Me.datevente.TabIndex = 9
        '
        'prixvente
        '
        Me.prixvente.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prixvente.Location = New System.Drawing.Point(121, 161)
        Me.prixvente.Name = "prixvente"
        Me.prixvente.Size = New System.Drawing.Size(130, 28)
        Me.prixvente.TabIndex = 8
        '
        'superficie
        '
        Me.superficie.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superficie.Location = New System.Drawing.Point(108, 86)
        Me.superficie.Name = "superficie"
        Me.superficie.Size = New System.Drawing.Size(143, 28)
        Me.superficie.TabIndex = 6
        '
        'site
        '
        Me.site.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.site.Location = New System.Drawing.Point(108, 32)
        Me.site.Name = "site"
        Me.site.Size = New System.Drawing.Size(143, 28)
        Me.site.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date de vente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Prix de vente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 21)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Superficie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Site"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(338, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 25)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "L'acheteur"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.nomtemoin2)
        Me.Panel2.Controls.Add(Me.prenomtemoin2)
        Me.Panel2.Controls.Add(Me.prenomacheteur)
        Me.Panel2.Controls.Add(Me.nomacheteur)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel2.Location = New System.Drawing.Point(343, 183)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 293)
        Me.Panel2.TabIndex = 9
        '
        'nomtemoin2
        '
        Me.nomtemoin2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomtemoin2.Location = New System.Drawing.Point(94, 182)
        Me.nomtemoin2.Name = "nomtemoin2"
        Me.nomtemoin2.Size = New System.Drawing.Size(143, 28)
        Me.nomtemoin2.TabIndex = 8
        '
        'prenomtemoin2
        '
        Me.prenomtemoin2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomtemoin2.Location = New System.Drawing.Point(94, 231)
        Me.prenomtemoin2.Name = "prenomtemoin2"
        Me.prenomtemoin2.Size = New System.Drawing.Size(143, 28)
        Me.prenomtemoin2.TabIndex = 7
        '
        'prenomacheteur
        '
        Me.prenomacheteur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomacheteur.Location = New System.Drawing.Point(94, 86)
        Me.prenomacheteur.Name = "prenomacheteur"
        Me.prenomacheteur.Size = New System.Drawing.Size(143, 28)
        Me.prenomacheteur.TabIndex = 6
        '
        'nomacheteur
        '
        Me.nomacheteur.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomacheteur.Location = New System.Drawing.Point(94, 32)
        Me.nomacheteur.Name = "nomacheteur"
        Me.nomacheteur.Size = New System.Drawing.Size(143, 28)
        Me.nomacheteur.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 21)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Prénom : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 21)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Nom : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(36, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(170, 21)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Informations Témoin"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 21)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Prénom : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nom : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(423, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'acteterrainsdevente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "acteterrainsdevente"
        Me.Text = "acteterrainsdevente"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents reference As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents nomtemoin1 As TextBox
    Friend WithEvents prenomtemoin1 As TextBox
    Friend WithEvents prenomvendeur As TextBox
    Friend WithEvents nomevendeur As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datevente As DateTimePicker
    Friend WithEvents prixvente As TextBox
    Friend WithEvents superficie As TextBox
    Friend WithEvents site As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nomtemoin2 As TextBox
    Friend WithEvents prenomtemoin2 As TextBox
    Friend WithEvents prenomacheteur As TextBox
    Friend WithEvents nomacheteur As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button1 As Button
End Class
