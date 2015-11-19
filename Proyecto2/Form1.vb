Public Class Form1
    Dim oveja(10) As Sheep 'declarying each sheep like an object
    Dim perro As New Dog 'declaren the object of the class Dog
    Dim newloc As New Point 'take the location of the mouse (or more property the dog)
    Dim colsheep As Integer 'control the selection on the radio buttom of the sheeps
    Dim coldog As Integer 'control the selection on the combo box of the dog
    Dim dirdog As String 'Take the direction of the image of the dog
    Dim dirsheep As String 'Take the direction of the image of the sheep
    Dim switch(10) As Boolean 'control if a sheep is capture or not
    Dim numcapt As Integer 'control the total of sheeps capturate
    Dim numclick As Integer 'control the number of click maked


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 10 'create 10 new object of the class sheep, each one is one sheep in the game
            oveja(i) = New Sheep
        Next

        For i As Integer = 1 To 10
            oveja(i).randomMe() 'select the random position of the sheep, calling the subrutine
            switch(i) = True 'make the switch to say that the sheep hasn't being capture yet
        Next
        dirdog = Nothing 'set the starting direction of the dog
        dirsheep = Nothing 'set the starting direction of the sheep
        sheepbox.Text = Nothing 'set the starting code of the image text box
        DogBox.Text = Nothing 'set the starting code of the image text box
        numcapt = 0 'set the default number of sheep capture to 0
        numclick = 0 'set the default number of clicks to 0
        sheepstatus.Text = "Good Luck!!!" 'text the default words of the status of the sheeps
    End Sub



    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        dirdog = DogBox.Text 'take the direction of the picture from the text box
        dirsheep = sheepbox.Text 'take the direction of the picture from the text box
        perro.Draw(e.Graphics, coldog, dirdog) 'draw the dog
        numcapt = 0 'set the number of capture to 0, to calculate it again

        For i As Integer = 1 To 10
            If switch(i) Then 'verifyed if the sheep is capture or no, if it's not them draw it
                numcapt = numcapt + 1 'set the sheep as captured and add 1 to the number of sheep captured
                oveja(i).DrawMEE(e.Graphics, colsheep, dirsheep, i) 'draw the sheep
            End If
        Next
        sheepstatus.Text = "Still -> " + CStr(numcapt) + " <-Sheep Remaining in" 'set the message of the status
        If numcapt = 0 Then 'verifyed if there is not sheep remaining
            MsgBox("You Make It In " & numclick & " Clicks!!!", MsgBoxStyle.Information, "CONGRATULATION!!!") 'set the final message of the game
            End
        End If
    End Sub
    '                                       "MOUSE"
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        newloc.X = e.X 'take the actual location of the mouse and set it to the dog direction
        newloc.Y = e.Y 'take the actual location of the mouse and set it to the dog direction
        perro.Pos() = newloc 'take the position of the dog
        For i As Integer = 1 To 10
            oveja(i).Moveawayfrom(newloc) 'check if the sheeps are too near of the dog and move them
        Next
        Refresh() 'repaint all the picture box
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        Cursor.Hide() 'hide the cursor when mouse enter the game zone
        Refresh() 'repaint all the picture box
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Cursor.Show() 'show the mouse when it go out of the picture box 
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Redsheep.CheckedChanged
        colsheep = 1 'take the selection on the radio buttom to red
        Refresh()
    End Sub

    Private Sub OrangeSheep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrangeSheep.CheckedChanged
        colsheep = 2 'take the selection on the radio buttom to orange
        Refresh()
    End Sub

    Private Sub BlueSheep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueSheep.CheckedChanged
        colsheep = 3 'take the selection on the radio buttom to blue
        Refresh()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSheep.CheckedChanged
        colsheep = 4 'take the selection on the radio buttom to image
        Refresh()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        coldog = ComboBox1.SelectedIndex 'take the dog style we choose (which color or image)
        Refresh()

    End Sub


  
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        sheepstatus2.Text = " -> " + CStr(numclick + 1) + " <- Clicks" 'check the number of clicks we have make
        numclick = numclick + 1 'update the number of clicks
        For i As Integer = 1 To 10
            If Not oveja(i).capture(newloc) Then 'call the function that verified if the sheep is capture or not, depending on the dog position (newloc)
                numcapt = numcapt + 1 'add 1 to the sheep not capturate number, everytime it say that the sheep osn't captured what means that the boolean part before return false
                sheepstatus.Text = "Still -> " + CStr(numcapt) + " <-Sheep Remaining!" 'display the number of sheeps remaining
                switch(i) = False 'set the sheep like capture in the array that control the sheep that has to be drawed
            End If
        Next
        Refresh()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUITbutton.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "QUIT") 'put the message to make sure we want to quit the game
        If result = MsgBoxResult.Yes Then 'quit the program if we put yes in the are you sure question
            End
        End If

    End Sub
End Class
