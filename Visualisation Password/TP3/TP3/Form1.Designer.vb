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
        Me.tbxpassword = New System.Windows.Forms.TextBox()
        Me.tbxconfirmation = New System.Windows.Forms.TextBox()
        Me.btnvisualiser = New System.Windows.Forms.Button()
        Me.btneffacer = New System.Windows.Forms.Button()
        Me.btnquitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tapez votre mot de passe :"
        '
        'tbxpassword
        '
        Me.tbxpassword.Location = New System.Drawing.Point(34, 67)
        Me.tbxpassword.Name = "tbxpassword"
        Me.tbxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxpassword.Size = New System.Drawing.Size(131, 20)
        Me.tbxpassword.TabIndex = 1
        '
        'tbxconfirmation
        '
        Me.tbxconfirmation.Location = New System.Drawing.Point(34, 116)
        Me.tbxconfirmation.Name = "tbxconfirmation"
        Me.tbxconfirmation.Size = New System.Drawing.Size(131, 20)
        Me.tbxconfirmation.TabIndex = 2
        '
        'btnvisualiser
        '
        Me.btnvisualiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvisualiser.Location = New System.Drawing.Point(250, 63)
        Me.btnvisualiser.Name = "btnvisualiser"
        Me.btnvisualiser.Size = New System.Drawing.Size(182, 26)
        Me.btnvisualiser.TabIndex = 3
        Me.btnvisualiser.Text = "Visualer"
        Me.btnvisualiser.UseVisualStyleBackColor = True
        '
        'btneffacer
        '
        Me.btneffacer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneffacer.Location = New System.Drawing.Point(250, 112)
        Me.btneffacer.Name = "btneffacer"
        Me.btneffacer.Size = New System.Drawing.Size(182, 26)
        Me.btneffacer.TabIndex = 4
        Me.btneffacer.Text = "Effacer"
        Me.btneffacer.UseVisualStyleBackColor = True
        '
        'btnquitter
        '
        Me.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnquitter.Location = New System.Drawing.Point(34, 161)
        Me.btnquitter.Name = "btnquitter"
        Me.btnquitter.Size = New System.Drawing.Size(398, 32)
        Me.btnquitter.TabIndex = 5
        Me.btnquitter.Text = "Quitter"
        Me.btnquitter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 203)
        Me.Controls.Add(Me.btnquitter)
        Me.Controls.Add(Me.btneffacer)
        Me.Controls.Add(Me.btnvisualiser)
        Me.Controls.Add(Me.tbxconfirmation)
        Me.Controls.Add(Me.tbxpassword)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mot de Passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxpassword As System.Windows.Forms.TextBox
    Friend WithEvents tbxconfirmation As System.Windows.Forms.TextBox
    Friend WithEvents btnvisualiser As System.Windows.Forms.Button
    Friend WithEvents btneffacer As System.Windows.Forms.Button
    Friend WithEvents btnquitter As System.Windows.Forms.Button

End Class
