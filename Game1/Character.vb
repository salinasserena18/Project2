Public Class Character
    Private intPieces As Integer
    Private searching As Boolean
    Private images As PictureBox
    Private x As Integer
    Private y As Integer

    Public Sub New()
        intPieces = 0
    End Sub

    Public Property pieces As Integer
        Get
            Return intPieces
        End Get
        Set(value As Integer)
            If value > 0 Then
                intPieces = value
            Else
                intPieces = 0
            End If
        End Set
    End Property
    Public Property person As Bitmap
        Get
            Return My.Resources.map
        End Get
        Set(value As Bitmap)

        End Set
    End Property

    Public Sub positionImages()
        Me.images.Show()
    End Sub
    Public Property imagesShown As PictureBox
        Get
            Return images
        End Get
        Set(value As PictureBox)
            images = value

        End Set
    End Property

    Public Property look As Boolean
        Get
            Return "You Found a peice of the map" & searching
        End Get
        Set(value As Boolean)
            If searching = True Then
                searching = value
                images.SendToBack()
            End If
        End Set
    End Property
End Class
