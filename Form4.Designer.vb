<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnArgent = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(151, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisissez le type de revelé de transaction à imprimer"
        '
        'btnDebit
        '
        Me.btnDebit.Location = New System.Drawing.Point(254, 180)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(85, 36)
        Me.btnDebit.TabIndex = 1
        Me.btnDebit.Text = "Débit"
        Me.btnDebit.UseVisualStyleBackColor = True
        '
        'btnCredit
        '
        Me.btnCredit.Location = New System.Drawing.Point(432, 180)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(85, 36)
        Me.btnCredit.TabIndex = 2
        Me.btnCredit.Text = "Crédit"
        Me.btnCredit.UseVisualStyleBackColor = True
        '
        'btnArgent
        '
        Me.btnArgent.Location = New System.Drawing.Point(254, 231)
        Me.btnArgent.Name = "btnArgent"
        Me.btnArgent.Size = New System.Drawing.Size(85, 36)
        Me.btnArgent.TabIndex = 3
        Me.btnArgent.Text = "Argent"
        Me.btnArgent.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Location = New System.Drawing.Point(432, 231)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(85, 36)
        Me.btnCheque.TabIndex = 4
        Me.btnCheque.Text = "Chèque"
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(345, 288)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(85, 36)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(671, 415)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(97, 23)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.btnArgent)
        Me.Controls.Add(Me.btnCredit)
        Me.Controls.Add(Me.btnDebit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDebit As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnArgent As Button
    Friend WithEvents btnCheque As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnQuitter As Button
End Class
