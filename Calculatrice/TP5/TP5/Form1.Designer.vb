<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrice
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
        Me.tbx_ecran = New System.Windows.Forms.TextBox()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_egal = New System.Windows.Forms.Button()
        Me.btn_virgule = New System.Windows.Forms.Button()
        Me.btn_difference = New System.Windows.Forms.Button()
        Me.btn_produit = New System.Windows.Forms.Button()
        Me.btn_somme = New System.Windows.Forms.Button()
        Me.btn_quotient = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_modulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbx_ecran
        '
        Me.tbx_ecran.BackColor = System.Drawing.Color.White
        Me.tbx_ecran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ecran.ForeColor = System.Drawing.Color.Black
        Me.tbx_ecran.Location = New System.Drawing.Point(12, 12)
        Me.tbx_ecran.Multiline = True
        Me.tbx_ecran.Name = "tbx_ecran"
        Me.tbx_ecran.Size = New System.Drawing.Size(339, 33)
        Me.tbx_ecran.TabIndex = 0
        Me.tbx_ecran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_7
        '
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(12, 68)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(40, 40)
        Me.btn_7.TabIndex = 1
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(75, 68)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(40, 40)
        Me.btn_8.TabIndex = 2
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(75, 126)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(40, 40)
        Me.btn_5.TabIndex = 3
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(139, 68)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(40, 40)
        Me.btn_9.TabIndex = 4
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(75, 184)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(40, 40)
        Me.btn_2.TabIndex = 5
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(139, 126)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(40, 40)
        Me.btn_6.TabIndex = 6
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(12, 242)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(40, 40)
        Me.btn_0.TabIndex = 7
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(139, 184)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(40, 40)
        Me.btn_3.TabIndex = 8
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_egal
        '
        Me.btn_egal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_egal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_egal.Location = New System.Drawing.Point(139, 242)
        Me.btn_egal.Name = "btn_egal"
        Me.btn_egal.Size = New System.Drawing.Size(40, 40)
        Me.btn_egal.TabIndex = 9
        Me.btn_egal.Text = "="
        Me.btn_egal.UseVisualStyleBackColor = True
        '
        'btn_virgule
        '
        Me.btn_virgule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_virgule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_virgule.Location = New System.Drawing.Point(75, 242)
        Me.btn_virgule.Name = "btn_virgule"
        Me.btn_virgule.Size = New System.Drawing.Size(40, 40)
        Me.btn_virgule.TabIndex = 10
        Me.btn_virgule.Text = ","
        Me.btn_virgule.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_virgule.UseVisualStyleBackColor = True
        '
        'btn_difference
        '
        Me.btn_difference.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_difference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_difference.Location = New System.Drawing.Point(298, 126)
        Me.btn_difference.Name = "btn_difference"
        Me.btn_difference.Size = New System.Drawing.Size(40, 98)
        Me.btn_difference.TabIndex = 11
        Me.btn_difference.Text = "-"
        Me.btn_difference.UseVisualStyleBackColor = True
        '
        'btn_produit
        '
        Me.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produit.Location = New System.Drawing.Point(232, 184)
        Me.btn_produit.Name = "btn_produit"
        Me.btn_produit.Size = New System.Drawing.Size(40, 40)
        Me.btn_produit.TabIndex = 12
        Me.btn_produit.Text = "*"
        Me.btn_produit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_produit.UseVisualStyleBackColor = True
        '
        'btn_somme
        '
        Me.btn_somme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_somme.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_somme.Location = New System.Drawing.Point(232, 242)
        Me.btn_somme.Name = "btn_somme"
        Me.btn_somme.Size = New System.Drawing.Size(106, 40)
        Me.btn_somme.TabIndex = 13
        Me.btn_somme.Text = "+"
        Me.btn_somme.UseVisualStyleBackColor = True
        '
        'btn_quotient
        '
        Me.btn_quotient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quotient.Location = New System.Drawing.Point(232, 68)
        Me.btn_quotient.Name = "btn_quotient"
        Me.btn_quotient.Size = New System.Drawing.Size(40, 40)
        Me.btn_quotient.TabIndex = 14
        Me.btn_quotient.Text = "/"
        Me.btn_quotient.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(12, 184)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(40, 40)
        Me.btn_1.TabIndex = 15
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(12, 126)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(40, 40)
        Me.btn_4.TabIndex = 16
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(363, 320)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 204
        Me.LineShape1.X2 = 204
        Me.LineShape1.Y1 = 67
        Me.LineShape1.Y2 = 283
        '
        'btn_clear
        '
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(298, 68)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(40, 40)
        Me.btn_clear.TabIndex = 18
        Me.btn_clear.Text = "AC"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_modulo
        '
        Me.btn_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modulo.Location = New System.Drawing.Point(232, 126)
        Me.btn_modulo.Name = "btn_modulo"
        Me.btn_modulo.Size = New System.Drawing.Size(40, 40)
        Me.btn_modulo.TabIndex = 19
        Me.btn_modulo.Text = "%"
        Me.btn_modulo.UseVisualStyleBackColor = True
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 320)
        Me.Controls.Add(Me.btn_modulo)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_quotient)
        Me.Controls.Add(Me.btn_somme)
        Me.Controls.Add(Me.btn_produit)
        Me.Controls.Add(Me.btn_difference)
        Me.Controls.Add(Me.btn_virgule)
        Me.Controls.Add(Me.btn_egal)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.tbx_ecran)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_ecran As System.Windows.Forms.TextBox
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_egal As System.Windows.Forms.Button
    Friend WithEvents btn_virgule As System.Windows.Forms.Button
    Friend WithEvents btn_difference As System.Windows.Forms.Button
    Friend WithEvents btn_produit As System.Windows.Forms.Button
    Friend WithEvents btn_somme As System.Windows.Forms.Button
    Friend WithEvents btn_quotient As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_modulo As System.Windows.Forms.Button

End Class
