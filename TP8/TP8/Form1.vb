Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        
    End Sub

    Private Sub btn_reinitialiser_Click(sender As Object, e As EventArgs) Handles btn_reinitialiser.Click
        tbx_addition.Text = ""
        chk_frit.Checked = False
        chk_fromage.Checked = False
        chk_salade.Checked = False
        rbn_carte.Checked = False
        rbn_complet.Checked = False
        rbn_menu.Checked = False
        cmb_payement.SelectedIndex = 0


    End Sub

    Private Sub btn_addition_Click(sender As Object, e As EventArgs) Handles btn_addition.Click

        If cmb_payement.SelectedIndex < 0 Then
            MessageBox.Show("Veuillez choisir un mode de payement", "Payement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If rbn_carte.Checked = False And rbn_complet.Checked = False And rbn_menu.Checked = False Then
                MessageBox.Show("Veuillez selectionner un plat", "Choix du plat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim AdditionPlat As Integer = 0
            Dim AdditionSupplement As Integer = 0
            Dim Addition As Integer
            If rbn_complet.Checked = True Then
                AdditionPlat = 3500
            ElseIf rbn_carte.Checked = True Then
                AdditionPlat = 5000
            ElseIf rbn_menu.Checked = True Then
                AdditionPlat = 4200
            End If

            If chk_frit.Checked = True Then
                AdditionSupplement = AdditionSupplement + 1000
            End If
            If chk_fromage.Checked = True Then
                AdditionSupplement = AdditionSupplement + 1500
            End If
            If chk_salade.Checked Then
                AdditionSupplement = AdditionSupplement + 1200
            End If

            Addition = AdditionPlat + AdditionSupplement
            tbx_addition.Text = Addition
        End If

        

    End Sub

    Private Sub tbx_addition_TextChanged(sender As Object, e As EventArgs) Handles tbx_addition.TextChanged
        tbx_addition.ReadOnly = True
    End Sub

    Private Sub cmb_payement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_payement.SelectedIndexChanged

    End Sub
End Class
