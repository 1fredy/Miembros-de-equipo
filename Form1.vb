Public Class integrantes

    Private Sub integrantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Gustavo Cerna"
        Label2.Text = "Monica Campos"
        Label3.Text = "Lorena Rodriguez"
        Label4.Text = "Ivania Matas"
        Label5.Text = "Fredy Campos"
        Label6.Text = "Cristian Herrera"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = " "
        Label2.Text = " "
        Label3.Text = " "
        Label4.Text = " "
        Label5.Text = " "
        Label6.Text = " "
    End Sub
End Class


