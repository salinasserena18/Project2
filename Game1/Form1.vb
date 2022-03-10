Public Class Form1
    Private character As Character
    Dim pictures As List(Of PictureBox) = New List(Of PictureBox)
    Const NumOfPics As Integer = 8
    Public Event KeyPr As KeyPressEventHandler

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            PictureBox1.Left += 10
        ElseIf e.KeyCode = Keys.Left Then
            PictureBox1.Left -= 10
        ElseIf e.KeyCode = Keys.Up Then
            PictureBox1.Top -= 10
        ElseIf e.KeyCode = Keys.Down Then
            PictureBox1.Top += 10
        End If

        If e.KeyCode = Keys.E AndAlso Me.PictureBox2.Bounds.Contains(Me.PointToClient(PictureBox1.Location)) Then
            MessageBox.Show("Search")
        End If
    End Sub

    Private Sub checkUnderItem()
        Dim bmp As Bitmap = PictureBox1.Image
        For x As Integer = 0 To bmp.Width - 1
            For y As Integer = 0 To bmp.Height - 1
                If bmp.GetPixel(x, y) = Color.FromArgb(48, 48, 48) Then
                    MessageBox.Show("Look under the Rock?")
                End If
            Next
        Next
    End Sub


End Class
