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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_salade = New System.Windows.Forms.CheckBox()
        Me.chk_fromage = New System.Windows.Forms.CheckBox()
        Me.chk_frit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbn_menu = New System.Windows.Forms.RadioButton()
        Me.rbn_carte = New System.Windows.Forms.RadioButton()
        Me.rbn_complet = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_payement = New System.Windows.Forms.ComboBox()
        Me.btn_addition = New System.Windows.Forms.Button()
        Me.btn_reinitialiser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbx_addition = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_salade)
        Me.GroupBox2.Controls.Add(Me.chk_fromage)
        Me.GroupBox2.Controls.Add(Me.chk_frit)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 159)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplément"
        '
        'chk_salade
        '
        Me.chk_salade.AutoSize = True
        Me.chk_salade.Location = New System.Drawing.Point(21, 109)
        Me.chk_salade.Name = "chk_salade"
        Me.chk_salade.Size = New System.Drawing.Size(92, 17)
        Me.chk_salade.TabIndex = 9
        Me.chk_salade.Text = "Salade - 1200"
        Me.chk_salade.UseVisualStyleBackColor = True
        '
        'chk_fromage
        '
        Me.chk_fromage.AutoSize = True
        Me.chk_fromage.Location = New System.Drawing.Point(21, 67)
        Me.chk_fromage.Name = "chk_fromage"
        Me.chk_fromage.Size = New System.Drawing.Size(100, 17)
        Me.chk_fromage.TabIndex = 8
        Me.chk_fromage.Text = "Fromage - 1500"
        Me.chk_fromage.UseVisualStyleBackColor = True
        '
        'chk_frit
        '
        Me.chk_frit.AutoSize = True
        Me.chk_frit.Location = New System.Drawing.Point(21, 28)
        Me.chk_frit.Name = "chk_frit"
        Me.chk_frit.Size = New System.Drawing.Size(73, 17)
        Me.chk_frit.TabIndex = 7
        Me.chk_frit.Text = "Frit - 1000"
        Me.chk_frit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbn_menu)
        Me.GroupBox1.Controls.Add(Me.rbn_carte)
        Me.GroupBox1.Controls.Add(Me.rbn_complet)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plat"
        '
        'rbn_menu
        '
        Me.rbn_menu.AutoSize = True
        Me.rbn_menu.Location = New System.Drawing.Point(17, 85)
        Me.rbn_menu.Name = "rbn_menu"
        Me.rbn_menu.Size = New System.Drawing.Size(120, 17)
        Me.rbn_menu.TabIndex = 2
        Me.rbn_menu.Text = "Menu du jour - 4200"
        Me.rbn_menu.UseVisualStyleBackColor = True
        '
        'rbn_carte
        '
        Me.rbn_carte.AutoSize = True
        Me.rbn_carte.Location = New System.Drawing.Point(17, 137)
        Me.rbn_carte.Name = "rbn_carte"
        Me.rbn_carte.Size = New System.Drawing.Size(103, 17)
        Me.rbn_carte.TabIndex = 1
        Me.rbn_carte.Text = "A la carte - 5000"
        Me.rbn_carte.UseVisualStyleBackColor = True
        '
        'rbn_complet
        '
        Me.rbn_complet.AutoSize = True
        Me.rbn_complet.Checked = True
        Me.rbn_complet.Location = New System.Drawing.Point(17, 37)
        Me.rbn_complet.Name = "rbn_complet"
        Me.rbn_complet.Size = New System.Drawing.Size(93, 17)
        Me.rbn_complet.TabIndex = 0
        Me.rbn_complet.TabStop = True
        Me.rbn_complet.Text = "Complet -3500"
        Me.rbn_complet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Payement"
        '
        'cmb_payement
        '
        Me.cmb_payement.FormattingEnabled = True
        Me.cmb_payement.Items.AddRange(New Object() {"Especes", "Bon", "Cheque", "Carte credit"})
        Me.cmb_payement.Location = New System.Drawing.Point(314, 87)
        Me.cmb_payement.Name = "cmb_payement"
        Me.cmb_payement.Size = New System.Drawing.Size(145, 21)
        Me.cmb_payement.TabIndex = 10
        '
        'btn_addition
        '
        Me.btn_addition.Location = New System.Drawing.Point(314, 237)
        Me.btn_addition.Name = "btn_addition"
        Me.btn_addition.Size = New System.Drawing.Size(130, 32)
        Me.btn_addition.TabIndex = 11
        Me.btn_addition.Text = "Addition"
        Me.btn_addition.UseVisualStyleBackColor = True
        '
        'btn_reinitialiser
        '
        Me.btn_reinitialiser.Location = New System.Drawing.Point(450, 237)
        Me.btn_reinitialiser.Name = "btn_reinitialiser"
        Me.btn_reinitialiser.Size = New System.Drawing.Size(130, 32)
        Me.btn_reinitialiser.TabIndex = 12
        Me.btn_reinitialiser.Text = "Réintialiser"
        Me.btn_reinitialiser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Votre addition est :"
        '
        'tbx_addition
        '
        Me.tbx_addition.BackColor = System.Drawing.Color.White
        Me.tbx_addition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_addition.Location = New System.Drawing.Point(314, 378)
        Me.tbx_addition.Multiline = True
        Me.tbx_addition.Name = "tbx_addition"
        Me.tbx_addition.Size = New System.Drawing.Size(145, 30)
        Me.tbx_addition.TabIndex = 14
        Me.tbx_addition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 500)
        Me.Controls.Add(Me.tbx_addition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_reinitialiser)
        Me.Controls.Add(Me.btn_addition)
        Me.Controls.Add(Me.cmb_payement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_salade As System.Windows.Forms.CheckBox
    Friend WithEvents chk_fromage As System.Windows.Forms.CheckBox
    Friend WithEvents chk_frit As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_menu As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_carte As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_complet As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_payement As System.Windows.Forms.ComboBox
    Friend WithEvents btn_addition As System.Windows.Forms.Button
    Friend WithEvents btn_reinitialiser As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_addition As System.Windows.Forms.TextBox

End Class
