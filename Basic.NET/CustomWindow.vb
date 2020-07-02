Public Class CustomWindow
    Public newForm As Form
    Private Sub CustomWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Dim mPanel As New Panel
        Me.Controls.Add(mPanel)
        mPanel.Dock = DockStyle.Fill
        mPanel.Controls.Add(newForm)
    End Sub
End Class