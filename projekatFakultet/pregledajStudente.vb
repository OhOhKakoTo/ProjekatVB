Public Class pregledajStudente
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prozor1 = New prozor
        prozor1.ShowDialog()
        Close()
    End Sub

    Private Sub pregledajStudente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BazaProjekatDataSet.studenti' table. You can move, or remove it, as needed.
        Me.StudentiTableAdapter.Fill(Me.BazaProjekatDataSet.studenti)
        'TODO: This line of code loads data into the 'ApeironStudentiDataSet.studenti' table. You can move, or remove it, as needed.

    End Sub
End Class