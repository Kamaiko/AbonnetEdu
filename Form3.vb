Public Class Form3
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        txtClientID.Text = getCLientID()
        DataGridView1.Rows.Add(txtClientID.Text, txtPrenom.Text, txtNom.Text, txtCourriel.Text, txtTelephone.Text, txtAdresse.Text, txtVille.Text, txtCodePostal.Text)

    End Sub

    ' Retourne 2 lettres du nom du client suivi par les 4 derniers caractères du code postal
    Private Function getCLientID() As String
        Dim endOfZipCode, str As String
        endOfZipCode = txtCodePostal.Text.Substring(txtVille.Text.Length - 4)
        str = txtNom.Text.Substring(0, 2).ToUpper & endOfZipCode
        Return str
    End Function

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        txtClientID.Text = ""
        txtPrenom.Text = ""
        txtNom.Text = ""
        txtCourriel.Text = ""
        txtTelephone.Text = ""
        txtAdresse.Text = ""
        txtVille.Text = ""
        txtCodePostal.Text = ""
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click


        If DataGridView1.SelectedRows.Count > 0 Then
            Dim resultat As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette rangée?", "Attention!", MessageBoxButtons.YesNo)
            If resultat = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MessageBox.Show("Sélectionner une colonne à supprimer avant de cliquer sur Effacer")
        End If
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
End Class