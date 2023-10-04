Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim pi As Double
        Dim r As Double

        pi = 3.14
        r = Val(TextBox1.Text)
        A = pi * r * r

        TextBox2.Text = A
    End Sub
End Class
