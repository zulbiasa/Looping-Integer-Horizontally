Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        For n = 50 To 0 Step -5
            TextBox1.Text = TextBox1.Text & n & vbCr & vbCrLf
        Next n
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
