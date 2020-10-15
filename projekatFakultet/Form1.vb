Imports System.Data.SqlClient

Public Class Form1
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Downloads\projekatFakultet\projekatFakultet\projekatFakultet\bazaProjekat.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = " select korisnickoIme, lozinka from korisnici where korisnickoIme = '" & textBox1.Text & "' and lozinka = '" & textBox2.Text & "'"

        rd = cmd.ExecuteReader

        If rd.HasRows Then

            prozor.ShowDialog()
            Me.Hide()
        Else
            MessageBox.Show("Neuspješna prijava!")
        End If




    End Sub
End Class
