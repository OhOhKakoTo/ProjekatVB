Public Class prozor
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim login = New Form1
        login.ShowDialog()
        Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dodajStudenta1 = New dodajStudenta
        dodajStudenta1.ShowDialog
        Me.Hide()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim azuriraj1 = New azuriraj
        azuriraj1.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pregledajStudente = New pregledajStudente
        pregledajStudente.ShowDialog()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim obrisiPodatke1 = New obrisiStudenta
        obrisiPodatke1.ShowDialog()
        Me.Hide()


    End Sub
End Class