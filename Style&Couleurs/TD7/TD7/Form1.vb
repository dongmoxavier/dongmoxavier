Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chk_style_CheckedChanged(sender As Object, e As EventArgs) Handles chk_style.CheckedChanged
        ApplyStyle()
    End Sub

    Private Sub CheckBoxBold_CheckedChanged(sender As Object, e As EventArgs) Handles chk_gras.CheckedChanged
        ApplyStyle()
    End Sub

    Private Sub CheckBoxItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chk_italic.CheckedChanged
        ApplyStyle()
    End Sub

    Private Sub CheckBoxUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles chk_souligne.CheckedChanged
        ApplyStyle()
    End Sub

    Private Sub ApplyStyle()
        If chk_style.Checked Then
            Dim fontStyle As FontStyle = fontStyle.Regular

            If chk_gras.Checked Then
                fontStyle = fontStyle.Bold Or fontStyle
            End If
            If chk_italic.Checked Then
                fontStyle = fontStyle.Italic Or fontStyle
            End If
            If chk_souligne.Checked Then
                fontStyle = fontStyle.Underline Or fontStyle
            End If

            tbx_text.Font = New Font(tbx_text.Font.FontFamily, tbx_text.Font.Size, fontStyle)
        Else
            tbx_text.Font = New Font(tbx_text.Font.FontFamily, tbx_text.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub chk_couleur_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_rouge.CheckedChanged, rbn_blanc.CheckedChanged, rbn_bleu.CheckedChanged, rbn_vert.CheckedChanged
        ApplyColor()
    End Sub

    Private Sub ApplyColor()
        If chk_couleur.Checked = False Then
            tbx_text.BackColor = Color.White
        Else
            If rbn_blanc.Checked = True Then
                tbx_text.BackColor = Color.White
            ElseIf rbn_bleu.Checked = True Then
                tbx_text.BackColor = Color.Blue
            ElseIf rbn_rouge.Checked = True Then
                tbx_text.BackColor = Color.Red
            Else
                tbx_text.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub chk_couleur_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_couleur.CheckedChanged
        ApplyColor()
    End Sub
End Class