Public Class Calculatrice
    Dim nbre1 As Double
    Dim nbre2 As Double
    Dim operation As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbx_ecran.TextChanged
        tbx_ecran.ReadOnly = True
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        Dim button As Button = CType(sender, Button)
        tbx_ecran.Text &= button.Text
    End Sub

    Private Sub Operation_Click(sender As Object, e As EventArgs) Handles btn_quotient.Click, btn_somme.Click, btn_difference.Click, btn_produit.Click, btn_modulo.Click
        Dim button As Button = CType(sender, Button)
        nbre1 = Decimal.Parse(tbx_ecran.Text)
        operation = button.Text
        tbx_ecran.Clear()
    End Sub

    Private Sub btn_egal_Click(sender As Object, e As EventArgs) Handles btn_egal.Click
        nbre2 = Decimal.Parse(tbx_ecran.Text)
        Select Case operation
            Case "+"
                tbx_ecran.Text = (nbre1 + nbre2).ToString()
            Case "-"
                tbx_ecran.Text = (nbre1 - nbre2).ToString()
            Case "*"
                tbx_ecran.Text = (nbre1 * nbre2).ToString()
            Case "%"
                If nbre2 <> 0 Then
                    tbx_ecran.Text = (nbre1 Mod nbre2).ToString()
                Else
                    'tbx_ecran.Text = "Erreur"
                    MessageBox.Show("Opération Impossible", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case "/"
                If nbre2 <> 0 Then
                    tbx_ecran.Text = (nbre1 / nbre2).ToString()
                Else
                    'tbx_ecran.Text = "Erreur"
                    MessageBox.Show("Opération Impossible", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
    End Sub

    Private Sub btn_virgule_Click(sender As Object, e As EventArgs) Handles btn_virgule.Click
        If Not tbx_ecran.Text.Contains(",") Then
            tbx_ecran.Text &= ","
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_clear.Click
        tbx_ecran.Text = ""
        tbx_ecran.Focus()
    End Sub
End Class