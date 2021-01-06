Imports SlnUtils
Public Class Form1

#Region "Drag"

    Dim posX As Integer
    Dim posY As Integer
    Dim drag As Boolean

    Private Sub panel1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If maximized Then
                Me.WindowState = FormWindowState.Normal
                maximized = False
            Else
                Me.WindowState = FormWindowState.Maximized
                maximized = True
            End If
        End If
    End Sub

    Private Sub panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            drag = True
            posX = Cursor.Position.X - Me.Left
            posY = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        drag = False
    End Sub

    Private Sub panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If drag Then
            Me.Top = Cursor.Position.Y - posY
            Me.Left = Cursor.Position.X - posX
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub buttonMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub buttonClos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClos.Click
        Me.Close()
    End Sub

    Private Sub buttonMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMax.Click
        If maximized Then
            maximized = False
            Me.WindowState = FormWindowState.Normal
        Else
            maximized = True
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

#End Region

#Region "Resize"

    Dim onFullScreen As Boolean
    Dim maximized As Boolean
    Dim on_MinimumSize As Boolean
    Dim minimumWidth As Short = 733
    Dim minimumHeight As Short = 543
    Dim borderSpace As Short = 20
    Dim borderDiameter As Short = 3

    Dim onBorderRight As Boolean
    Dim onBorderLeft As Boolean
    Dim onBorderTop As Boolean
    Dim onBorderBottom As Boolean
    Dim onCornerTopRight As Boolean
    Dim onCornerTopLeft As Boolean
    Dim onCornerBottomRight As Boolean
    Dim onCornerBottomLeft As Boolean

    Dim movingRight As Boolean
    Dim movingLeft As Boolean
    Dim movingTop As Boolean
    Dim movingBottom As Boolean
    Dim movingCornerTopRight As Boolean
    Dim movingCornerTopLeft As Boolean
    Dim movingCornerBottomRight As Boolean
    Dim movingCornerBottomLeft As Boolean

    Private Sub Borderless_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If onBorderRight Then movingRight = True Else movingRight = False
            If onBorderLeft Then movingLeft = True Else movingLeft = False
            If onBorderTop Then movingTop = True Else movingTop = False
            If onBorderBottom Then movingBottom = True Else movingBottom = False
            If onCornerTopRight Then movingCornerTopRight = True Else movingCornerTopRight = False
            If onCornerTopLeft Then movingCornerTopLeft = True Else movingCornerTopLeft = False
            If onCornerBottomRight Then movingCornerBottomRight = True Else movingCornerBottomRight = False
            If onCornerBottomLeft Then movingCornerBottomLeft = True Else movingCornerBottomLeft = False
        End If
    End Sub

    Private Sub Borderless_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        stopResizer()
    End Sub

    Private Sub Borderless_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If onFullScreen Or maximized Then Exit Sub

        If Me.Width <= minimumWidth Then Me.Width = (minimumWidth + 5) : on_MinimumSize = True
        If Me.Height <= minimumHeight Then Me.Height = (minimumHeight + 5) : on_MinimumSize = True
        If on_MinimumSize Then stopResizer() Else startResizer()


        If (Cursor.Position.X > (Me.Location.X + Me.Width) - borderDiameter) _
            And (Cursor.Position.Y > (Me.Location.Y + borderSpace)) _
            And (Cursor.Position.Y < ((Me.Location.Y + Me.Height) - borderSpace)) Then
            Me.Cursor = Cursors.SizeWE
            onBorderRight = True

        ElseIf (Cursor.Position.X < (Me.Location.X + borderDiameter)) _
            And (Cursor.Position.Y > (Me.Location.Y + borderSpace)) _
            And (Cursor.Position.Y < ((Me.Location.Y + Me.Height) - borderSpace)) Then
            Me.Cursor = Cursors.SizeWE
            onBorderLeft = True

        ElseIf (Cursor.Position.Y < (Me.Location.Y + borderDiameter)) _
            And (Cursor.Position.X > (Me.Location.X + borderSpace)) _
            And (Cursor.Position.X < ((Me.Location.X + Me.Width) - borderSpace)) Then
            Me.Cursor = Cursors.SizeNS
            onBorderTop = True

        ElseIf (Cursor.Position.Y > ((Me.Location.Y + Me.Height) - borderDiameter)) _
            And (Cursor.Position.X > (Me.Location.X + borderSpace)) _
            And (Cursor.Position.X < ((Me.Location.X + Me.Width) - borderSpace)) Then
            Me.Cursor = Cursors.SizeNS
            onBorderBottom = True

        ElseIf (Cursor.Position.X = ((Me.Location.X + Me.Width) - 1)) _
            And (Cursor.Position.Y = Me.Location.Y) Then
            Me.Cursor = Cursors.SizeNESW
            onCornerTopRight = True

        ElseIf (Cursor.Position.X = Me.Location.X) _
            And (Cursor.Position.Y = Me.Location.Y) Then
            Me.Cursor = Cursors.SizeNWSE
            onCornerTopLeft = True

        ElseIf (Cursor.Position.X = ((Me.Location.X + Me.Width) - 1)) _
            And (Cursor.Position.Y = ((Me.Location.Y + Me.Height) - 1)) Then
            Me.Cursor = Cursors.SizeNWSE
            onCornerBottomRight = True

        ElseIf (Cursor.Position.X = Me.Location.X) _
            And (Cursor.Position.Y = ((Me.Location.Y + Me.Height) - 1)) Then
            Me.Cursor = Cursors.SizeNESW
            onCornerBottomLeft = True

        Else
            onBorderRight = False
            onBorderLeft = False
            onBorderTop = False
            onBorderBottom = False
            onCornerTopRight = False
            onCornerTopLeft = False
            onCornerBottomRight = False
            onCornerBottomLeft = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub startResizer()
        Select Case True

            Case movingRight
                Me.Width = (Cursor.Position.X - Me.Location.X)

            Case movingLeft
                Me.Width = ((Me.Width + Me.Location.X) - Cursor.Position.X)
                Me.Location = New Point(Cursor.Position.X, Me.Location.Y)

            Case movingTop
                Me.Height = ((Me.Height + Me.Location.Y) - Cursor.Position.Y)
                Me.Location = New Point(Me.Location.X, Cursor.Position.Y)

            Case movingBottom
                Me.Height = (Cursor.Position.Y - Me.Location.Y)

            Case movingCornerTopRight
                Me.Width = (Cursor.Position.X - Me.Location.X)
                Me.Height = ((Me.Location.Y - Cursor.Position.Y) + Me.Height)
                Me.Location = New Point(Me.Location.X, Cursor.Position.Y)

            Case movingCornerTopLeft
                Me.Width = ((Me.Width + Me.Location.X) - Cursor.Position.X)
                Me.Location = New Point(Cursor.Position.X, Me.Location.Y)
                Me.Height = ((Me.Height + Me.Location.Y) - Cursor.Position.Y)
                Me.Location = New Point(Me.Location.X, Cursor.Position.Y)

            Case movingCornerBottomRight
                Me.Size = New Point((Cursor.Position.X - Me.Location.X), (Cursor.Position.Y - Me.Location.Y))

            Case movingCornerBottomLeft
                Me.Width = ((Me.Width + Me.Location.X) - Cursor.Position.X)
                Me.Height = (Cursor.Position.Y - Me.Location.Y)
                Me.Location = New Point(Cursor.Position.X, Me.Location.Y)

        End Select
    End Sub

    Private Sub stopResizer()
        movingRight = False
        movingLeft = False
        movingTop = False
        movingBottom = False
        movingCornerTopRight = False
        movingCornerTopLeft = False
        movingCornerBottomRight = False
        movingCornerBottomLeft = False
        Me.Cursor = Cursors.Default
        Threading.Thread.Sleep(300)
        on_MinimumSize = False
    End Sub
#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel1.Width = Me.Width - 6
        Panel1.Location = New Point(3, 3)
        buttonClos.Location = New Point(Panel1.Width - 23, 3)
        buttonMax.Location = New Point(Panel1.Width - 43, 3)
        buttonMin.Location = New Point(Panel1.Width - 63, 3)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecentList.ItemHeight = 15
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        CreatePanel.Hide()
        MainPanel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' TODO Add project creation code
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub ChooseFolderButton_Click(sender As Object, e As EventArgs) Handles ChooseFolderButton.Click
        If ChooseFolderDialog.ShowDialog() = DialogResult.OK Then
            Dim readedSln = ReadSln(ChooseFolderDialog.SelectedPath)
            LoadSln(readedSln)
        End If
    End Sub
End Class
