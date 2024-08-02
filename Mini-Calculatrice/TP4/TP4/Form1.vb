Public Class Mini_Calculatrice

    Private Sub btnquitter_Click(sender As Object, e As EventArgs) Handles btnquitter.Click
        If MessageBox.Show("Voulez vraiment quitter cette fenetre ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Application.Exit() ou
            Me.Close()
        End If
    End Sub

    Private Sub btneffacer_Click(sender As Object, e As EventArgs) Handles btneffacer.Click
        tbxnbre1.Text = ""
        tbxnbre1.Focus()
        tbxnbre2.Text = ""
        tbxoperation.Text = ""
    End Sub

    Private Sub btnaddition_Click(sender As Object, e As EventArgs) Handles btnaddition.Click

        Dim number1 As Decimal
        Dim number2 As Decimal

        If Decimal.TryParse(tbxnbre1.Text, number1) AndAlso Decimal.TryParse(tbxnbre2.Text, number2) Then
            Dim result As Decimal = number1 + number2
            tbxoperation.Text = result.ToString()
        Else
            MessageBox.Show("Veuillez entrer des valeurs valides dans les deux champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndifference_Click(sender As Object, e As EventArgs) Handles btndifference.Click

        Dim number1 As Decimal
        Dim number2 As Decimal

        If Decimal.TryParse(tbxnbre1.Text, number1) AndAlso Decimal.TryParse(tbxnbre2.Text, number2) Then
            Dim result As Decimal = number1 - number2
            tbxoperation.Text = result.ToString()
        Else
            MessageBox.Show("Veuillez entrer des valeurs valides dans les deux champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnquotient_Click(sender As Object, e As EventArgs) Handles btnquotient.Click
        Dim number1 As Decimal
        Dim number2 As Decimal

        If Decimal.TryParse(tbxnbre1.Text, number1) AndAlso Decimal.TryParse(tbxnbre2.Text, number2) Then
            Dim result As Decimal
            If number2 <> 0 Then
                result = number1 / number2
                tbxoperation.Text = result.ToString()
            Else
                tbxoperation.Text = "Erreur"
            End If
        Else
            MessageBox.Show("Veuillez entrer des valeurs valides dans les deux champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnproduit_Click(sender As Object, e As EventArgs) Handles btnproduit.Click
        Dim number1 As Decimal
        Dim number2 As Decimal

        If Decimal.TryParse(tbxnbre1.Text, number1) AndAlso Decimal.TryParse(tbxnbre2.Text, number2) Then
            Dim result As Decimal = number1 * number2
            tbxoperation.Text = result.ToString()
        Else
            MessageBox.Show("Veuillez entrer des valeurs valides dans les deux champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tbxoperation_TextChanged(sender As Object, e As EventArgs) Handles tbxoperation.TextChanged
        tbxoperation.ReadOnly = True
    End Sub
End Class
