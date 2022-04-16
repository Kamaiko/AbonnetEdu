Public Class Form5
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        DataGridView1.Rows.Add(txtNoEmploye.Text, txtPrenom.Text, txtNom.Text, txtTelephone.Text)
        If (txtNewPass.Text <> txtConfirmPass) Then
            MessageBox.Show("Veuillez entrer des Mots de Passe identiques", "Attention!", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        txtPrenom.Text = ""
        txtNom.Text = ""
        txtAdresse.Text = ""
        txtTelephone.Text = ""
        txtNAS.Text = ""
        txtNoEmploye.Text = ""
        txtNewPass.Text = ""
        txtConfirmPass.Text = ""
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        Dim resultat As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette rangée?", "Attention!", MessageBoxButtons.YesNo)

        If DataGridView1.SelectedRows.Count > 0 Then
            If resultat = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MessageBox.Show("Sélectionner une colonne à supprimer avant de cliquer sur Effacer")
        End If
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub
End Class