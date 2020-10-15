Imports System.Data
Imports System.Data.SqlClient

Public Class azuriraj
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prozor1 = New prozor
        prozor1.ShowDialog()
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ime As String = TextBox1.Text
        Dim maticniBroj As String = TextBox2.Text
        Dim imeRoditelja As String = TextBox3.Text
        Dim adresa As String = TextBox4.Text
        Dim indeks As String = TextBox5.Text

        Dim query As String = "update studenti set maticniBroj= @maticniBroj,imeRoditelja = @imeRoditelja, adresa = @adresa,indeks = @indeks where ime=@ime"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Downloads\projekatFakultet\projekatFakultet\projekatFakultet\bazaProjekat.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ime", ime)
                cmd.Parameters.AddWithValue("@maticniBroj", maticniBroj)
                cmd.Parameters.AddWithValue("@imeRoditelja", imeRoditelja)
                cmd.Parameters.AddWithValue("@adresa", adresa)
                cmd.Parameters.AddWithValue("@indeks", indeks)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Uspjesno ste ažurirali studenta!")





            End Using
        End Using
    End Sub
End Class