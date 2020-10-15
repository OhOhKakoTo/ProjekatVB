Imports System.Data
Imports System.Data.SqlClient

Public Class obrisiStudenta
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prozor1 = New prozor
        prozor1.ShowDialog()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ime As String = TextBox1.Text


        Dim query As String = "delete from studenti where ime=@ime"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Downloads\projekatFakultet\projekatFakultet\projekatFakultet\bazaProjekat.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ime", ime)


                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Uspjesno ste obrisali studenta!")





            End Using
        End Using
    End Sub
End Class