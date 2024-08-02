<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini_Calculatrice
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxnbre1 = New System.Windows.Forms.TextBox()
        Me.tbxnbre2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxoperation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndifference = New System.Windows.Forms.Button()
        Me.btnquotient = New System.Windows.Forms.Button()
        Me.btnproduit = New System.Windows.Forms.Button()
        Me.btnaddition = New System.Windows.Forms.Button()
        Me.btnquitter = New System.Windows.Forms.Button()
        Me.btneffacer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opérations Arithmétiques"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre 1 :"
        '
        'tbxnbre1
        '
        Me.tbxnbre1.Location = New System.Drawing.Point(202, 67)
        Me.tbxnbre1.Multiline = True
        Me.tbxnbre1.Name = "tbxnbre1"
        Me.tbxnbre1.Size = New System.Drawing.Size(100, 25)
        Me.tbxnbre1.TabIndex = 2
        Me.tbxnbre1.Text = "600"
        Me.tbxnbre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxnbre2
        '
        Me.tbxnbre2.Location = New System.Drawing.Point(202, 114)
        Me.tbxnbre2.Multiline = True
        Me.tbxnbre2.Name = "tbxnbre2"
        Me.tbxnbre2.Size = New System.Drawing.Size(100, 25)
        Me.tbxnbre2.TabIndex = 4
        Me.tbxnbre2.Text = "300"
        Me.tbxnbre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre 2 :"
        '
        'tbxoperation
        '
        Me.tbxoperation.Location = New System.Drawing.Point(202, 200)
        Me.tbxoperation.Multiline = True
        Me.tbxoperation.Name = "tbxoperation"
        Me.tbxoperation.Size = New System.Drawing.Size(100, 25)
        Me.tbxoperation.TabIndex = 6
        Me.tbxoperation.Text = "900"
        Me.tbxoperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Resultat :"
        '
        'btndifference
        '
        Me.btndifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndifference.Location = New System.Drawing.Point(418, 86)
        Me.btndifference.Name = "btndifference"
        Me.btndifference.Size = New System.Drawing.Size(57, 30)
        Me.btndifference.TabIndex = 7
        Me.btndifference.Text = "-"
        Me.btndifference.UseVisualStyleBackColor = True
        '
        'btnquotient
        '
        Me.btnquotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquotient.Location = New System.Drawing.Point(473, 114)
        Me.btnquotient.Name = "btnquotient"
        Me.btnquotient.Size = New System.Drawing.Size(57, 30)
        Me.btnquotient.TabIndex = 8
        Me.btnquotient.Text = "/"
        Me.btnquotient.UseVisualStyleBackColor = True
        '
        'btnproduit
        '
        Me.btnproduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduit.Location = New System.Drawing.Point(418, 114)
        Me.btnproduit.Name = "btnproduit"
        Me.btnproduit.Size = New System.Drawing.Size(57, 30)
        Me.btnproduit.TabIndex = 9
        Me.btnproduit.Text = "*"
        Me.btnproduit.UseVisualStyleBackColor = True
        '
        'btnaddition
        '
        Me.btnaddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddition.Location = New System.Drawing.Point(473, 86)
        Me.btnaddition.Name = "btnaddition"
        Me.btnaddition.Size = New System.Drawing.Size(57, 30)
        Me.btnaddition.TabIndex = 10
        Me.btnaddition.Text = "+"
        Me.btnaddition.UseVisualStyleBackColor = True
        '
        'btnquitter
        '
        Me.btnquitter.Location = New System.Drawing.Point(413, 195)
        Me.btnquitter.Name = "btnquitter"
        Me.btnquitter.Size = New System.Drawing.Size(120, 30)
        Me.btnquitter.TabIndex = 11
        Me.btnquitter.Text = "Quitter"
        Me.btnquitter.UseVisualStyleBackColor = True
        '
        'btneffacer
        '
        Me.btneffacer.Location = New System.Drawing.Point(413, 159)
        Me.btneffacer.Name = "btneffacer"
        Me.btneffacer.Size = New System.Drawing.Size(120, 30)
        Me.btneffacer.TabIndex = 12
        Me.btneffacer.Text = "Nouveau"
        Me.btneffacer.UseVisualStyleBackColor = True
        '
        'Mini_Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 248)
        Me.Controls.Add(Me.btneffacer)
        Me.Controls.Add(Me.btnquitter)
        Me.Controls.Add(Me.btnaddition)
        Me.Controls.Add(Me.btnproduit)
        Me.Controls.Add(Me.btnquotient)
        Me.Controls.Add(Me.btndifference)
        Me.Controls.Add(Me.tbxoperation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxnbre2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxnbre1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mini_Calculatrice"
        Me.Text = "Mini Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxnbre1 As System.Windows.Forms.TextBox
    Friend WithEvents tbxnbre2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxoperation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btndifference As System.Windows.Forms.Button
    Friend WithEvents btnquotient As System.Windows.Forms.Button
    Friend WithEvents btnproduit As System.Windows.Forms.Button
    Friend WithEvents btnaddition As System.Windows.Forms.Button
    Friend WithEvents btnquitter As System.Windows.Forms.Button
    Friend WithEvents btneffacer As System.Windows.Forms.Button

End Class
