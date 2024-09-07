<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadiusTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LongitudeTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LatitudeTB = New System.Windows.Forms.TextBox()
        Me.Sphere = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TransX = New System.Windows.Forms.TextBox()
        Me.RBRotZ = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.STPRotBtn = New System.Windows.Forms.Button()
        Me.RBRotY = New System.Windows.Forms.RadioButton()
        Me.RBRotX = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TransZ = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.integerCB = New System.Windows.Forms.CheckBox()
        Me.TxtBoxLgtsrcx = New System.Windows.Forms.TextBox()
        Me.TxtBoxLgtsrcZ = New System.Windows.Forms.TextBox()
        Me.TxtBoxLgtsrcY = New System.Windows.Forms.TextBox()
        Me.TxtBoxKa = New System.Windows.Forms.TextBox()
        Me.TxtBoxKd = New System.Windows.Forms.TextBox()
        Me.TxtBoxKs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxExponent = New System.Windows.Forms.TextBox()
        Me.RdBttnFlatShading = New System.Windows.Forms.RadioButton()
        Me.RdBttnGouraud = New System.Windows.Forms.RadioButton()
        Me.RdBttnPhong = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(63, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "radius :"
        '
        'RadiusTB
        '
        Me.RadiusTB.Location = New System.Drawing.Point(95, 24)
        Me.RadiusTB.Name = "RadiusTB"
        Me.RadiusTB.Size = New System.Drawing.Size(100, 20)
        Me.RadiusTB.TabIndex = 6
        Me.RadiusTB.Text = "170"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 69)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Clear Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Default Values"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Longitude :"
        '
        'LongitudeTB
        '
        Me.LongitudeTB.Location = New System.Drawing.Point(95, 76)
        Me.LongitudeTB.Name = "LongitudeTB"
        Me.LongitudeTB.Size = New System.Drawing.Size(100, 20)
        Me.LongitudeTB.TabIndex = 10
        Me.LongitudeTB.Text = "50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Latitude :"
        '
        'LatitudeTB
        '
        Me.LatitudeTB.Location = New System.Drawing.Point(95, 50)
        Me.LatitudeTB.Name = "LatitudeTB"
        Me.LatitudeTB.Size = New System.Drawing.Size(100, 20)
        Me.LatitudeTB.TabIndex = 12
        Me.LatitudeTB.Text = "50"
        '
        'Sphere
        '
        Me.Sphere.Location = New System.Drawing.Point(14, 104)
        Me.Sphere.Name = "Sphere"
        Me.Sphere.Size = New System.Drawing.Size(75, 35)
        Me.Sphere.TabIndex = 14
        Me.Sphere.Text = "Change Sphere"
        Me.Sphere.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Y :"
        '
        'TransY
        '
        Me.TransY.Location = New System.Drawing.Point(33, 58)
        Me.TransY.Name = "TransY"
        Me.TransY.Size = New System.Drawing.Size(100, 20)
        Me.TransY.TabIndex = 25
        Me.TransY.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "X :"
        '
        'TransX
        '
        Me.TransX.Location = New System.Drawing.Point(33, 32)
        Me.TransX.Name = "TransX"
        Me.TransX.Size = New System.Drawing.Size(100, 20)
        Me.TransX.TabIndex = 21
        Me.TransX.Text = "0"
        '
        'RBRotZ
        '
        Me.RBRotZ.AutoSize = True
        Me.RBRotZ.Location = New System.Drawing.Point(8, 44)
        Me.RBRotZ.Name = "RBRotZ"
        Me.RBRotZ.Size = New System.Drawing.Size(115, 17)
        Me.RBRotZ.TabIndex = 27
        Me.RBRotZ.TabStop = True
        Me.RBRotZ.Text = "Rotation on Z axis "
        Me.RBRotZ.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(173, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Rotate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'STPRotBtn
        '
        Me.STPRotBtn.Location = New System.Drawing.Point(173, 37)
        Me.STPRotBtn.Name = "STPRotBtn"
        Me.STPRotBtn.Size = New System.Drawing.Size(75, 23)
        Me.STPRotBtn.TabIndex = 29
        Me.STPRotBtn.Text = "Stop"
        Me.STPRotBtn.UseVisualStyleBackColor = True
        '
        'RBRotY
        '
        Me.RBRotY.AutoSize = True
        Me.RBRotY.Location = New System.Drawing.Point(8, 67)
        Me.RBRotY.Name = "RBRotY"
        Me.RBRotY.Size = New System.Drawing.Size(115, 17)
        Me.RBRotY.TabIndex = 30
        Me.RBRotY.TabStop = True
        Me.RBRotY.Text = "Rotation on Y axis "
        Me.RBRotY.UseVisualStyleBackColor = True
        '
        'RBRotX
        '
        Me.RBRotX.AutoSize = True
        Me.RBRotX.Location = New System.Drawing.Point(8, 21)
        Me.RBRotX.Name = "RBRotX"
        Me.RBRotX.Size = New System.Drawing.Size(115, 17)
        Me.RBRotX.TabIndex = 31
        Me.RBRotX.TabStop = True
        Me.RBRotX.Text = "Rotation on X axis "
        Me.RBRotX.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.LongitudeTB)
        Me.GroupBox1.Controls.Add(Me.RadiusTB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LatitudeTB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Sphere)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(502, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 148)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shape"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TransZ)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TransY)
        Me.GroupBox2.Controls.Add(Me.TransX)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(500, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 120)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Translation"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Z:"
        '
        'TransZ
        '
        Me.TransZ.Location = New System.Drawing.Point(33, 84)
        Me.TransZ.Name = "TransZ"
        Me.TransZ.Size = New System.Drawing.Size(100, 20)
        Me.TransZ.TabIndex = 29
        Me.TransZ.Text = "0"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(139, 61)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 38)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Reset Position"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(139, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Translate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.STPRotBtn)
        Me.GroupBox3.Controls.Add(Me.RBRotZ)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.RBRotY)
        Me.GroupBox3.Controls.Add(Me.RBRotX)
        Me.GroupBox3.Location = New System.Drawing.Point(500, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 100)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotation"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(173, 66)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 34)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "Reset Rotation"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(692, 443)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 69)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Reset All"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'integerCB
        '
        Me.integerCB.AutoSize = True
        Me.integerCB.Location = New System.Drawing.Point(831, 32)
        Me.integerCB.Name = "integerCB"
        Me.integerCB.Size = New System.Drawing.Size(62, 17)
        Me.integerCB.TabIndex = 36
        Me.integerCB.Text = "Integer"
        Me.integerCB.UseVisualStyleBackColor = True
        '
        'TxtBoxLgtsrcx
        '
        Me.TxtBoxLgtsrcx.Location = New System.Drawing.Point(831, 55)
        Me.TxtBoxLgtsrcx.Name = "TxtBoxLgtsrcx"
        Me.TxtBoxLgtsrcx.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxLgtsrcx.TabIndex = 29
        Me.TxtBoxLgtsrcx.Text = "-1000"
        '
        'TxtBoxLgtsrcZ
        '
        Me.TxtBoxLgtsrcZ.Location = New System.Drawing.Point(831, 107)
        Me.TxtBoxLgtsrcZ.Name = "TxtBoxLgtsrcZ"
        Me.TxtBoxLgtsrcZ.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxLgtsrcZ.TabIndex = 37
        Me.TxtBoxLgtsrcZ.Text = "1000"
        '
        'TxtBoxLgtsrcY
        '
        Me.TxtBoxLgtsrcY.Location = New System.Drawing.Point(831, 81)
        Me.TxtBoxLgtsrcY.Name = "TxtBoxLgtsrcY"
        Me.TxtBoxLgtsrcY.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxLgtsrcY.TabIndex = 38
        Me.TxtBoxLgtsrcY.Text = "1000"
        '
        'TxtBoxKa
        '
        Me.TxtBoxKa.Location = New System.Drawing.Point(831, 160)
        Me.TxtBoxKa.Name = "TxtBoxKa"
        Me.TxtBoxKa.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxKa.TabIndex = 40
        Me.TxtBoxKa.Text = "0.1"
        '
        'TxtBoxKd
        '
        Me.TxtBoxKd.Location = New System.Drawing.Point(831, 188)
        Me.TxtBoxKd.Name = "TxtBoxKd"
        Me.TxtBoxKd.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxKd.TabIndex = 41
        Me.TxtBoxKd.Text = "0.5"
        '
        'TxtBoxKs
        '
        Me.TxtBoxKs.Location = New System.Drawing.Point(831, 214)
        Me.TxtBoxKs.Name = "TxtBoxKs"
        Me.TxtBoxKs.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxKs.TabIndex = 42
        Me.TxtBoxKs.Text = "0.7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(720, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Light source X:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(720, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Light source Z:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(720, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Light source Y:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(726, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Ka:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(726, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Kd:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(727, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Ks:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(727, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Exponent:"
        '
        'TextBoxExponent
        '
        Me.TextBoxExponent.Location = New System.Drawing.Point(831, 240)
        Me.TextBoxExponent.Name = "TextBoxExponent"
        Me.TextBoxExponent.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxExponent.TabIndex = 49
        Me.TextBoxExponent.Text = "1"
        '
        'RdBttnFlatShading
        '
        Me.RdBttnFlatShading.AutoSize = True
        Me.RdBttnFlatShading.Location = New System.Drawing.Point(956, 36)
        Me.RdBttnFlatShading.Name = "RdBttnFlatShading"
        Me.RdBttnFlatShading.Size = New System.Drawing.Size(84, 17)
        Me.RdBttnFlatShading.TabIndex = 51
        Me.RdBttnFlatShading.Text = "Flat Shading"
        Me.RdBttnFlatShading.UseVisualStyleBackColor = True
        '
        'RdBttnGouraud
        '
        Me.RdBttnGouraud.AutoSize = True
        Me.RdBttnGouraud.Checked = True
        Me.RdBttnGouraud.Location = New System.Drawing.Point(956, 59)
        Me.RdBttnGouraud.Name = "RdBttnGouraud"
        Me.RdBttnGouraud.Size = New System.Drawing.Size(107, 17)
        Me.RdBttnGouraud.TabIndex = 52
        Me.RdBttnGouraud.TabStop = True
        Me.RdBttnGouraud.Text = "Gouraud Shading"
        Me.RdBttnGouraud.UseVisualStyleBackColor = True
        '
        'RdBttnPhong
        '
        Me.RdBttnPhong.AutoSize = True
        Me.RdBttnPhong.Location = New System.Drawing.Point(956, 80)
        Me.RdBttnPhong.Name = "RdBttnPhong"
        Me.RdBttnPhong.Size = New System.Drawing.Size(96, 17)
        Me.RdBttnPhong.TabIndex = 53
        Me.RdBttnPhong.Text = "Phong Shading"
        Me.RdBttnPhong.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 550)
        Me.Controls.Add(Me.RdBttnPhong)
        Me.Controls.Add(Me.RdBttnGouraud)
        Me.Controls.Add(Me.RdBttnFlatShading)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxExponent)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxKs)
        Me.Controls.Add(Me.TxtBoxKd)
        Me.Controls.Add(Me.TxtBoxKa)
        Me.Controls.Add(Me.TxtBoxLgtsrcY)
        Me.Controls.Add(Me.TxtBoxLgtsrcZ)
        Me.Controls.Add(Me.TxtBoxLgtsrcx)
        Me.Controls.Add(Me.integerCB)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadiusTB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LongitudeTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LatitudeTB As TextBox
    Friend WithEvents Sphere As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TransY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TransX As TextBox
    Friend WithEvents RBRotZ As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents STPRotBtn As Button
    Friend WithEvents RBRotY As RadioButton
    Friend WithEvents RBRotX As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents integerCB As CheckBox
    Friend WithEvents TxtBoxLgtsrcx As TextBox
    Friend WithEvents TxtBoxLgtsrcZ As TextBox
    Friend WithEvents TxtBoxLgtsrcY As TextBox
    Friend WithEvents TxtBoxKa As TextBox
    Friend WithEvents TxtBoxKd As TextBox
    Friend WithEvents TxtBoxKs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxExponent As TextBox
    Friend WithEvents RdBttnFlatShading As RadioButton
    Friend WithEvents RdBttnGouraud As RadioButton
    Friend WithEvents RdBttnPhong As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents TransZ As TextBox
End Class
