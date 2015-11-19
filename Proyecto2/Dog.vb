Public Class Dog
    Dim _position As Point 'position of the dog
    Dim mydog As Image 'image of the dog
    Dim srcdog, dstdog As Rectangle 'two rectangles that controle the image display in the picture box
    Dim dirdog As String 'take the direction where is the picture

    Public Sub New()
        _position = New Point 'set a new point
    End Sub


    Public Sub Draw(ByRef on_me As Graphics, ByVal contrdog As Integer, ByVal direcdog As String)

        dirdog = direcdog 'get the direction of the picture of the dog
        If contrdog = 0 Then 'make the green dog
            on_me.DrawString("X", New Font("Comic Sans", 10, FontStyle.Bold), Brushes.Green, _position.X, _position.Y) 'draw the green dog
        ElseIf contrdog = 1 Then 'make the brown dog
            on_me.DrawString("X", New Font("Comic Sans", 10, FontStyle.Bold), Brushes.Brown, _position.X, _position.Y) 'draw the brown dog
        ElseIf contrdog = 2 Then 'make the yellow dog
            on_me.DrawString("X", New Font("Comic Sans", 10, FontStyle.Bold), Brushes.Yellow, _position.X, _position.Y) 'draw the yellow dog
        ElseIf contrdog = 3 Then 'make the image dog
            If dirdog <> Nothing Then 'check if there is something in the direction of the text box
                mydog = Image.FromFile(dirdog) 'take the image from the direction
                srcdog = New Rectangle(0, 0, mydog.Width, mydog.Height) 'make the rectangle of the image
                dstdog = New Rectangle(_position.X, _position.Y, 20, 20) 'make the rectangle where is going to be put the image
                on_me.DrawImage(mydog, dstdog, srcdog, GraphicsUnit.Pixel) 'draw the image dog
            ElseIf dirdog = Nothing Then 'if there is a not valid location
                on_me.DrawString("X", New Font("Comic Sans", 10, FontStyle.Bold), Brushes.Yellow, _position.X, _position.Y) 'draw the yellow dog, if there is a wrong image direction
                MsgBox("There is no Image in this Direction", MsgBoxStyle.OkOnly, "Image Error") 'show this message if there is not a image
            End If
        End If
    End Sub

    Public Property Pos() As Point 'check the position of the dog
        Get
            Return _position
        End Get
        Set(ByVal value As Point)
            _position = value
        End Set
    End Property

End Class
