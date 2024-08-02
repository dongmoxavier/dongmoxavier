Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbxconfirmation.TextChanged
        tbxconfirmation.ReadOnly = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxpassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnvisualiser.Click
        Dim password As String = tbxpassword.Text
        tbxconfirmation.Text = password

        If tbxpassword.Text = "" Then
            MessageBox.Show("Texte Introuvable", "IGL1B", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            tbxpassword.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btneffacer.Click
        If tbxpassword.Text = "" Then
            MessageBox.Show("Texte Introuvable", "IGL1B", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            tbxpassword.Text = ""
            tbxpassword.Focus()
        End If

        tbxconfirmation.Text = ""
    End Sub

    Private Sub btnquitter_Click(sender As Object, e As EventArgs) Handles btnquitter.Click
        If MessageBox.Show("Voulez vous quitter l'application ?", "Mot de passe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
