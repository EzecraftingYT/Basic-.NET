Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = SaveFileDialog1.FileName
        End If
    End Sub
End Class