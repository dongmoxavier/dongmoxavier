Public Class Form1

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tbx_resultat.TextChanged
        tbx_resultat.ReadOnly = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Recherche()

        Dim ph As String = ""
        If chk_phrase1.Checked = False And chk_phrase2.Checked = False And chk_phrase3.Checked = False Then
            MessageBox.Show("Veuillez choisir dans quelle(s) phrase(s) rechercher", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If chk_phrase1.Checked = True Then
                If tbx_phrase1.Text <> "" Then
                    ph = tbx_phrase1.Text
                Else
                    MessageBox.Show("Veuillez entrer du texte dans la phrase 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            If chk_phrase2.Checked = True Then
                If tbx_phrase2.Text <> "" Then
                    ph &= tbx_phrase2.Text
                Else
                    MessageBox.Show("Veuillez entrer du texte dans la phrase 2", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            If chk_phrase3.Checked = True Then
                If tbx_phrase3.Text <> "" Then
                    ph &= tbx_phrase3.Text
                Else
                    MessageBox.Show("Veuillez entrer du texte dans la phrase 3", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            Dim count As Integer = 0
            Dim i As Integer = 0
            Dim lettre As String = ""
            If tbx_recherche.Text <> "" Then
                lettre = tbx_recherche.Text
                While i < ph.Length()
                    If ph.Substring(i, 1) = lettre Then
                        count += 1
                    End If
                    i += 1
                End While
                tbx_resultat.Text = count
            Else
                MessageBox.Show("Veuillez entrer une lettre à rechercher", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub chk_phrase1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_phrase1.CheckedChanged

    End Sub

    Private Sub chk_phrase2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_phrase2.CheckedChanged

    End Sub

    Private Sub chk_phrase3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_phrase3.CheckedChanged

    End Sub

    Private Sub tbx_phrase1_TextChanged(sender As Object, e As EventArgs) Handles tbx_phrase1.TextChanged

    End Sub

    Private Sub tbx_phrase2_TextChanged(sender As Object, e As EventArgs) Handles tbx_phrase2.TextChanged

    End Sub

    Private Sub tbx_phrase3_TextChanged(sender As Object, e As EventArgs) Handles tbx_phrase3.TextChanged

    End Sub

    Private Sub tbx_recherche_TextChanged(sender As Object, e As EventArgs) Handles tbx_recherche.TextChanged

    End Sub

    Private Sub btn_rechercher_Click(sender As Object, e As EventArgs) Handles btn_rechercher.Click
        Recherche()

    End Sub

    Private Sub btn_NouvelleRecherche_Click(sender As Object, e As EventArgs) Handles btn_NouvelleRecherche.Click
        tbx_phrase1.Text = ""
        tbx_phrase1.Focus()
        tbx_phrase2.Text = ""
        tbx_phrase3.Text = ""
        tbx_recherche.Text = ""
        tbx_resultat.Text = ""
        chk_phrase1.Checked = False
        chk_phrase2.Checked = False
        chk_phrase3.Checked = False

    End Sub
End Class
