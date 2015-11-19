<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.sheepbox = New System.Windows.Forms.TextBox
        Me.ImageSheep = New System.Windows.Forms.RadioButton
        Me.BlueSheep = New System.Windows.Forms.RadioButton
        Me.OrangeSheep = New System.Windows.Forms.RadioButton
        Me.Redsheep = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DogBox = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.sheepstatus2 = New System.Windows.Forms.Label
        Me.sheepstatus = New System.Windows.Forms.Label
        Me.QUITbutton = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Green", "Brown", "Yellow", "Image"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sheepbox)
        Me.GroupBox1.Controls.Add(Me.ImageSheep)
        Me.GroupBox1.Controls.Add(Me.BlueSheep)
        Me.GroupBox1.Controls.Add(Me.OrangeSheep)
        Me.GroupBox1.Controls.Add(Me.Redsheep)
        Me.GroupBox1.Location = New System.Drawing.Point(554, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 152)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Sheep Color"
        '
        'sheepbox
        '
        Me.sheepbox.Location = New System.Drawing.Point(16, 116)
        Me.sheepbox.Name = "sheepbox"
        Me.sheepbox.Size = New System.Drawing.Size(100, 20)
        Me.sheepbox.TabIndex = 4
        '
        'ImageSheep
        '
        Me.ImageSheep.AutoSize = True
        Me.ImageSheep.Location = New System.Drawing.Point(16, 92)
        Me.ImageSheep.Name = "ImageSheep"
        Me.ImageSheep.Size = New System.Drawing.Size(54, 17)
        Me.ImageSheep.TabIndex = 3
        Me.ImageSheep.TabStop = True
        Me.ImageSheep.Text = "Image"
        Me.ImageSheep.UseVisualStyleBackColor = True
        '
        'BlueSheep
        '
        Me.BlueSheep.AutoSize = True
        Me.BlueSheep.Location = New System.Drawing.Point(16, 68)
        Me.BlueSheep.Name = "BlueSheep"
        Me.BlueSheep.Size = New System.Drawing.Size(46, 17)
        Me.BlueSheep.TabIndex = 2
        Me.BlueSheep.TabStop = True
        Me.BlueSheep.Text = "Blue"
        Me.BlueSheep.UseVisualStyleBackColor = True
        '
        'OrangeSheep
        '
        Me.OrangeSheep.AutoSize = True
        Me.OrangeSheep.Location = New System.Drawing.Point(16, 44)
        Me.OrangeSheep.Name = "OrangeSheep"
        Me.OrangeSheep.Size = New System.Drawing.Size(60, 17)
        Me.OrangeSheep.TabIndex = 1
        Me.OrangeSheep.TabStop = True
        Me.OrangeSheep.Text = "Orange"
        Me.OrangeSheep.UseVisualStyleBackColor = True
        '
        'Redsheep
        '
        Me.Redsheep.AutoSize = True
        Me.Redsheep.Location = New System.Drawing.Point(16, 20)
        Me.Redsheep.Name = "Redsheep"
        Me.Redsheep.Size = New System.Drawing.Size(45, 17)
        Me.Redsheep.TabIndex = 0
        Me.Redsheep.TabStop = True
        Me.Redsheep.Text = "Red"
        Me.Redsheep.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DogBox)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(554, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 71)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Dog Color"
        '
        'DogBox
        '
        Me.DogBox.Location = New System.Drawing.Point(16, 47)
        Me.DogBox.Name = "DogBox"
        Me.DogBox.Size = New System.Drawing.Size(100, 20)
        Me.DogBox.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.sheepstatus2)
        Me.GroupBox3.Controls.Add(Me.sheepstatus)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 35)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'sheepstatus2
        '
        Me.sheepstatus2.AutoSize = True
        Me.sheepstatus2.Location = New System.Drawing.Point(230, 16)
        Me.sheepstatus2.Name = "sheepstatus2"
        Me.sheepstatus2.Size = New System.Drawing.Size(63, 13)
        Me.sheepstatus2.TabIndex = 1
        Me.sheepstatus2.Text = "Good Luck!"
        '
        'sheepstatus
        '
        Me.sheepstatus.AutoSize = True
        Me.sheepstatus.Location = New System.Drawing.Point(73, 16)
        Me.sheepstatus.Name = "sheepstatus"
        Me.sheepstatus.Size = New System.Drawing.Size(0, 13)
        Me.sheepstatus.TabIndex = 0
        '
        'QUITbutton
        '
        Me.QUITbutton.Location = New System.Drawing.Point(440, 337)
        Me.QUITbutton.Name = "QUITbutton"
        Me.QUITbutton.Size = New System.Drawing.Size(75, 23)
        Me.QUITbutton.TabIndex = 5
        Me.QUITbutton.Text = "QUIT"
        Me.QUITbutton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto2.My.Resources.Resources.mirandoovejas
        Me.PictureBox2.Location = New System.Drawing.Point(570, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 113)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto2.My.Resources.Resources.hierba
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 318)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 370)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.QUITbutton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sheepbox As System.Windows.Forms.TextBox
    Friend WithEvents ImageSheep As System.Windows.Forms.RadioButton
    Friend WithEvents BlueSheep As System.Windows.Forms.RadioButton
    Friend WithEvents OrangeSheep As System.Windows.Forms.RadioButton
    Friend WithEvents Redsheep As System.Windows.Forms.RadioButton
    Friend WithEvents DogBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents sheepstatus As System.Windows.Forms.Label
    Friend WithEvents sheepstatus2 As System.Windows.Forms.Label
    Friend WithEvents QUITbutton As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
