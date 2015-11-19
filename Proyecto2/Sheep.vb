Public Class Sheep
    Dim mysheep As Image 'take the image of the sheep
    Private mypen As Drawing.Pen 'pen used to draw the circles
    Private posx As Integer 'position in which the circle is drawed
    Private posy As Integer 'position in which the circle is drawed
    Dim srcsheep, dstsheep As Rectangle 'rectangle of the picture and rectangle in which we put the image
    Dim dirsheep As String 'direction of the image of the sheep
    Dim capt As Boolean 'controle if the sheep status is capture or free

    Public Sub New()
        capt = True 'capture initial value true, indicate that isn't captured already
    End Sub

    Public Sub randomMe() 'set the x and y position as random
        Randomize() 'make the random process start with no consecutive computer random consecutives actions
        posx = Rnd() * 475 'limitate the position of the sheep to the picture box in the right size
        posy = Rnd() * 285 'limitate the position of the sheep to the picture box in the bottom
        posx = posx + 5 'limitate the position of the sheep to the picture box in the left
        posy = posy + 5 'limitate the position of the sheep to the picture box in the top
    End Sub

    Public Sub Moveawayfrom(ByVal dogpos As Point) 'move the sheep when the dog is too close
        If Math.Abs(dogpos.X - posx) < 40 And Math.Abs(dogpos.Y - posy) < 40 Then 'measure the distance with the dog
            'too close MOVE AWAYY!
            If (posx < dogpos.X) And posx > 5 Then 'move the sheep to the left, if the dog is in the right
                posx = posx - 1
            ElseIf posx < 505 Then 'move the sheep to the right, if the dog is in the left
                posx = posx + 1
            End If
            If (posy < dogpos.Y) And posy > 5 Then 'move the sheep to the top, if the dog is in the bottom
                posy = posy - 1
            ElseIf posy < 300 Then 'move the sheep to the bottom, if the dog is in the top
                posy = posy + 1
            End If

        End If
    End Sub


    Public Sub DrawMEE(ByRef on_me As Graphics, ByVal controsheep As Integer, ByVal direcsheep As String, ByVal i As Integer)


        dirsheep = direcsheep 'take the direction of the sheep, from the form to this class
        If controsheep = 1 Then 'draw the red sheep
            mypen = New Drawing.Pen(Color.Red, 2)
            on_me.DrawEllipse(mypen, posx, posy, 10, 10)
        ElseIf controsheep = 2 Then 'draw the orange sheep
            mypen = New Drawing.Pen(Color.Orange, 2)
            on_me.DrawEllipse(mypen, posx, posy, 10, 10)
        ElseIf controsheep = 3 Then 'draw the blue sheep
            mypen = New Drawing.Pen(Color.Blue, 2)
            on_me.DrawEllipse(mypen, posx, posy, 10, 10)
        ElseIf controsheep = 4 Then 'draw the image sheep

            If dirsheep <> Nothing Then 'see if the label have a direction




                mysheep = Image.FromFile(dirsheep) 'take the image from the direction

                srcsheep = New Rectangle(0, 0, mysheep.Width, mysheep.Height) 'make the rectangle to put the image on
                dstsheep = New Rectangle(posx, posy, 15, 15) 'rectangle that is the destination of the image
                on_me.DrawImage(mysheep, dstsheep, srcsheep, GraphicsUnit.Pixel) 'draw the image of the picture
            ElseIf dirsheep = Nothing Then 'if there is nothing in the label, change and put the sheeps again like circles
                on_me.DrawEllipse(mypen, posx, posy, 10, 10) 'draw the circle
                If i = 1 Then
                    MsgBox("There is no Image in this Direction", MsgBoxStyle.OkOnly, "Image Error") 'error, only presentate one time, instead of ten cause of the if
                End If
            End If
        End If
    End Sub

    Public Function capture(ByVal dogpos As Point) 'controle if the sheep is captured or not
        If Math.Abs(dogpos.X - posx) < 20 And Math.Abs(dogpos.Y - posy) < 20 Then 'check the distance to the sheep
            capt = False 'in this case the sheep is capture
        End If
        Return capt
    End Function

End Class
