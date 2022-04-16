Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim FormNouveauContrat As New Form2
        FormNouveauContrat.Show()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click

    End Sub

    Private Sub ConsulterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsulterToolStripMenuItem.Click

    End Sub

    Private Sub RésilierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RésilierToolStripMenuItem.Click

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CreerClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreerClientToolStripMenuItem.Click
        Dim FormCreerClient As New Form3
        FormCreerClient.Show()
    End Sub

    Private Sub DuJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuJourToolStripMenuItem.Click
        MessageBox.Show("Les factures du jour sont envoyées à l'imprimante", "Impression", MessageBoxButtons.OK)
    End Sub

    Private Sub AutreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutreToolStripMenuItem.Click

    End Sub

    Private Sub TaxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxesToolStripMenuItem.Click

    End Sub

    Private Sub DébitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DébitToolStripMenuItem.Click

    End Sub

    Private Sub NouvelEmployéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelEmployéToolStripMenuItem.Click

    End Sub

    Private Sub ÀProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposToolStripMenuItem.Click

        MessageBox.Show("Version 1.0", "Version de l'application", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub IndexeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexeToolStripMenuItem.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub


End Class
