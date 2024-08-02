<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbx_phrase3 = New System.Windows.Forms.TextBox()
        Me.tbx_phrase2 = New System.Windows.Forms.TextBox()
        Me.tbx_phrase1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_phrase3 = New System.Windows.Forms.CheckBox()
        Me.chk_phrase2 = New System.Windows.Forms.CheckBox()
        Me.chk_phrase1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_recherche = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_resultat = New System.Windows.Forms.TextBox()
        Me.btn_rechercher = New System.Windows.Forms.Button()
        Me.btn_NouvelleRecherche = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbx_phrase3)
        Me.GroupBox1.Controls.Add(Me.tbx_phrase2)
        Me.GroupBox1.Controls.Add(Me.tbx_phrase1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phrases"
        '
        'tbx_phrase3
        '
        Me.tbx_phrase3.Location = New System.Drawing.Point(132, 148)
        Me.tbx_phrase3.Name = "tbx_phrase3"
        Me.tbx_phrase3.Size = New System.Drawing.Size(367, 27)
        Me.tbx_phrase3.TabIndex = 5
        Me.tbx_phrase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_phrase2
        '
        Me.tbx_phrase2.Location = New System.Drawing.Point(132, 94)
        Me.tbx_phrase2.Name = "tbx_phrase2"
        Me.tbx_phrase2.Size = New System.Drawing.Size(367, 27)
        Me.tbx_phrase2.TabIndex = 4
        Me.tbx_phrase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_phrase1
        '
        Me.tbx_phrase1.Location = New System.Drawing.Point(132, 45)
        Me.tbx_phrase1.Name = "tbx_phrase1"
        Me.tbx_phrase1.Size = New System.Drawing.Size(367, 27)
        Me.tbx_phrase1.TabIndex = 3
        Me.tbx_phrase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(19, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phrase 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(19, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phrase 3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(19, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phrase 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_phrase3)
        Me.GroupBox2.Controls.Add(Me.chk_phrase2)
        Me.GroupBox2.Controls.Add(Me.chk_phrase1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 197)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher dans :"
        '
        'chk_phrase3
        '
        Me.chk_phrase3.AutoSize = True
        Me.chk_phrase3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_phrase3.ForeColor = System.Drawing.Color.Gray
        Me.chk_phrase3.Location = New System.Drawing.Point(22, 149)
        Me.chk_phrase3.Name = "chk_phrase3"
        Me.chk_phrase3.Size = New System.Drawing.Size(74, 19)
        Me.chk_phrase3.TabIndex = 2
        Me.chk_phrase3.Text = "Phrase 3"
        Me.chk_phrase3.UseVisualStyleBackColor = True
        '
        'chk_phrase2
        '
        Me.chk_phrase2.AutoSize = True
        Me.chk_phrase2.Checked = True
        Me.chk_phrase2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_phrase2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_phrase2.ForeColor = System.Drawing.Color.Gray
        Me.chk_phrase2.Location = New System.Drawing.Point(22, 92)
        Me.chk_phrase2.Name = "chk_phrase2"
        Me.chk_phrase2.Size = New System.Drawing.Size(74, 19)
        Me.chk_phrase2.TabIndex = 1
        Me.chk_phrase2.Text = "Phrase 2"
        Me.chk_phrase2.UseVisualStyleBackColor = True
        '
        'chk_phrase1
        '
        Me.chk_phrase1.AutoSize = True
        Me.chk_phrase1.Checked = True
        Me.chk_phrase1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_phrase1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_phrase1.ForeColor = System.Drawing.Color.Gray
        Me.chk_phrase1.Location = New System.Drawing.Point(22, 39)
        Me.chk_phrase1.Name = "chk_phrase1"
        Me.chk_phrase1.Size = New System.Drawing.Size(74, 19)
        Me.chk_phrase1.TabIndex = 0
        Me.chk_phrase1.Text = "Phrase 1"
        Me.chk_phrase1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(305, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "La Lettre à Rechercher "
        '
        'tbx_recherche
        '
        Me.tbx_recherche.Location = New System.Drawing.Point(438, 265)
        Me.tbx_recherche.Name = "tbx_recherche"
        Me.tbx_recherche.Size = New System.Drawing.Size(124, 20)
        Me.tbx_recherche.TabIndex = 3
        Me.tbx_recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Resultat de la Recherche"
        '
        'tbx_resultat
        '
        Me.tbx_resultat.Location = New System.Drawing.Point(438, 372)
        Me.tbx_resultat.Name = "tbx_resultat"
        Me.tbx_resultat.Size = New System.Drawing.Size(124, 20)
        Me.tbx_resultat.TabIndex = 6
        Me.tbx_resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_rechercher
        '
        Me.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rechercher.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercher.ForeColor = System.Drawing.Color.White
        Me.btn_rechercher.Location = New System.Drawing.Point(244, 303)
        Me.btn_rechercher.Name = "btn_rechercher"
        Me.btn_rechercher.Size = New System.Drawing.Size(318, 38)
        Me.btn_rechercher.TabIndex = 7
        Me.btn_rechercher.Text = " Lancer la recherche"
        Me.btn_rechercher.UseVisualStyleBackColor = False
        '
        'btn_NouvelleRecherche
        '
        Me.btn_NouvelleRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_NouvelleRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_NouvelleRecherche.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NouvelleRecherche.ForeColor = System.Drawing.Color.White
        Me.btn_NouvelleRecherche.Location = New System.Drawing.Point(244, 410)
        Me.btn_NouvelleRecherche.Name = "btn_NouvelleRecherche"
        Me.btn_NouvelleRecherche.Size = New System.Drawing.Size(318, 38)
        Me.btn_NouvelleRecherche.TabIndex = 8
        Me.btn_NouvelleRecherche.Text = "Nouvelle recherche"
        Me.btn_NouvelleRecherche.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 460)
        Me.Controls.Add(Me.btn_NouvelleRecherche)
        Me.Controls.Add(Me.btn_rechercher)
        Me.Controls.Add(Me.tbx_resultat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbx_recherche)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Compter un caractère donné"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_phrase3 As System.Windows.Forms.TextBox
    Friend WithEvents tbx_phrase2 As System.Windows.Forms.TextBox
    Friend WithEvents tbx_phrase1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_phrase3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_phrase2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_phrase1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_recherche As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbx_resultat As System.Windows.Forms.TextBox
    Friend WithEvents btn_rechercher As System.Windows.Forms.Button
    Friend WithEvents btn_NouvelleRecherche As System.Windows.Forms.Button

End Class
