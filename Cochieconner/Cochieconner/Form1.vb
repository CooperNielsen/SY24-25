Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 0 To 99
            Controls("b" & index).BackColor = Color.Red
            Controls("b" & index).Text = index
        Next

    End Sub
End Class
