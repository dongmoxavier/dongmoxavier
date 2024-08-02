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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_couleur = New System.Windows.Forms.CheckBox()
        Me.chk_style = New System.Windows.Forms.CheckBox()
        Me.tbx_text = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbn_blanc = New System.Windows.Forms.RadioButton()
        Me.rbn_bleu = New System.Windows.Forms.RadioButton()
        Me.rbn_vert = New System.Windows.Forms.RadioButton()
        Me.rbn_rouge = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_italic = New System.Windows.Forms.CheckBox()
        Me.chk_souligne = New System.Windows.Forms.CheckBox()
        Me.chk_gras = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Demonstration des cases à cocher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " et des boutons d'options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_couleur
        '
        Me.chk_couleur.AutoSize = True
        Me.chk_couleur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_couleur.Location = New System.Drawing.Point(44, 85)
        Me.chk_couleur.Name = "chk_couleur"
        Me.chk_couleur.Size = New System.Drawing.Size(110, 17)
        Me.chk_couleur.TabIndex = 1
        Me.chk_couleur.Text = "Modifier la couleur"
        Me.chk_couleur.UseVisualStyleBackColor = True
        '
        'chk_style
        '
        Me.chk_style.AutoSize = True
        Me.chk_style.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_style.Location = New System.Drawing.Point(44, 133)
        Me.chk_style.Name = "chk_style"
        Me.chk_style.Size = New System.Drawing.Size(96, 17)
        Me.chk_style.TabIndex = 2
        Me.chk_style.Text = "Modifier le style"
        Me.chk_style.UseVisualStyleBackColor = True
        '
        'tbx_text
        '
        Me.tbx_text.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_text.Location = New System.Drawing.Point(285, 82)
        Me.tbx_text.Multiline = True
        Me.tbx_text.Name = "tbx_text"
        Me.tbx_text.Size = New System.Drawing.Size(403, 68)
        Me.tbx_text.TabIndex = 3
        Me.tbx_text.Text = "Tapez votre texte"
        Me.tbx_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbn_blanc)
        Me.GroupBox1.Controls.Add(Me.rbn_bleu)
        Me.GroupBox1.Controls.Add(Me.rbn_vert)
        Me.GroupBox1.Controls.Add(Me.rbn_rouge)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 164)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Couleur du fond"
        '
        'rbn_blanc
        '
        Me.rbn_blanc.AutoSize = True
        Me.rbn_blanc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbn_blanc.Location = New System.Drawing.Point(7, 132)
        Me.rbn_blanc.Name = "rbn_blanc"
        Me.rbn_blanc.Size = New System.Drawing.Size(51, 17)
        Me.rbn_blanc.TabIndex = 3
        Me.rbn_blanc.TabStop = True
        Me.rbn_blanc.Text = "Blanc"
        Me.rbn_blanc.UseVisualStyleBackColor = True
        '
        'rbn_bleu
        '
        Me.rbn_bleu.AutoSize = True
        Me.rbn_bleu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbn_bleu.Location = New System.Drawing.Point(7, 97)
        Me.rbn_bleu.Name = "rbn_bleu"
        Me.rbn_bleu.Size = New System.Drawing.Size(45, 17)
        Me.rbn_bleu.TabIndex = 2
        Me.rbn_bleu.TabStop = True
        Me.rbn_bleu.Text = "Bleu"
        Me.rbn_bleu.UseVisualStyleBackColor = True
        '
        'rbn_vert
        '
        Me.rbn_vert.AutoSize = True
        Me.rbn_vert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbn_vert.Location = New System.Drawing.Point(7, 64)
        Me.rbn_vert.Name = "rbn_vert"
        Me.rbn_vert.Size = New System.Drawing.Size(43, 17)
        Me.rbn_vert.TabIndex = 1
        Me.rbn_vert.TabStop = True
        Me.rbn_vert.Text = "Vert"
        Me.rbn_vert.UseVisualStyleBackColor = True
        '
        'rbn_rouge
        '
        Me.rbn_rouge.AutoSize = True
        Me.rbn_rouge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbn_rouge.Location = New System.Drawing.Point(7, 30)
        Me.rbn_rouge.Name = "rbn_rouge"
        Me.rbn_rouge.Size = New System.Drawing.Size(56, 17)
        Me.rbn_rouge.TabIndex = 0
        Me.rbn_rouge.TabStop = True
        Me.rbn_rouge.Text = "Rouge"
        Me.rbn_rouge.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_italic)
        Me.GroupBox2.Controls.Add(Me.chk_souligne)
        Me.GroupBox2.Controls.Add(Me.chk_gras)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 164)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Style"
        '
        'chk_italic
        '
        Me.chk_italic.AutoSize = True
        Me.chk_italic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_italic.Location = New System.Drawing.Point(12, 71)
        Me.chk_italic.Name = "chk_italic"
        Me.chk_italic.Size = New System.Drawing.Size(46, 17)
        Me.chk_italic.TabIndex = 2
        Me.chk_italic.Text = "Italie"
        Me.chk_italic.UseVisualStyleBackColor = True
        '
        'chk_souligne
        '
        Me.chk_souligne.AutoSize = True
        Me.chk_souligne.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_souligne.Location = New System.Drawing.Point(12, 106)
        Me.chk_souligne.Name = "chk_souligne"
        Me.chk_souligne.Size = New System.Drawing.Size(65, 17)
        Me.chk_souligne.TabIndex = 1
        Me.chk_souligne.Text = "Souligné"
        Me.chk_souligne.UseVisualStyleBackColor = True
        '
        'chk_gras
        '
        Me.chk_gras.AutoSize = True
        Me.chk_gras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_gras.Location = New System.Drawing.Point(12, 37)
        Me.chk_gras.Name = "chk_gras"
        Me.chk_gras.Size = New System.Drawing.Size(46, 17)
        Me.chk_gras.TabIndex = 0
        Me.chk_gras.Text = "Gras"
        Me.chk_gras.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 421)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbx_text)
        Me.Controls.Add(Me.chk_style)
        Me.Controls.Add(Me.chk_couleur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Style&Couleurs"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_couleur As System.Windows.Forms.CheckBox
    Friend WithEvents chk_style As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_text As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_italic As System.Windows.Forms.CheckBox
    Friend WithEvents chk_souligne As System.Windows.Forms.CheckBox
    Friend WithEvents chk_gras As System.Windows.Forms.CheckBox
    Friend WithEvents rbn_blanc As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_bleu As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_vert As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_rouge As System.Windows.Forms.RadioButton

End Class
