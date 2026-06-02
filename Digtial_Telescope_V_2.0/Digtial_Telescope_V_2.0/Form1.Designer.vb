<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lbl_Mars = New System.Windows.Forms.Label()
        Me.lbl_Jupiter = New System.Windows.Forms.Label()
        Me.lbl_Mercury = New System.Windows.Forms.Label()
        Me.lbl_Neptune = New System.Windows.Forms.Label()
        Me.lbl_Moon = New System.Windows.Forms.Label()
        Me.lbl_Pluto = New System.Windows.Forms.Label()
        Me.lbl_Venus = New System.Windows.Forms.Label()
        Me.lbl_Uranus = New System.Windows.Forms.Label()
        Me.lbl_Saturn = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_DisConnect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFetch
        '
        Me.btnFetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.Location = New System.Drawing.Point(22, 492)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(433, 37)
        Me.btnFetch.TabIndex = 3
        Me.btnFetch.Text = "Connect Server and Fetch Data"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(749, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(362, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Find My Planet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Moon
        Me.PictureBox1.Location = New System.Drawing.Point(367, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Neptune.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Mars.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Sun.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Uranus.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Saturn.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Moon.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Jupiter.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Pluto.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Mercury.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Venus.jpg")
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Mars
        Me.PictureBox2.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Mercury
        Me.PictureBox3.Location = New System.Drawing.Point(727, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Jupiter
        Me.PictureBox4.Location = New System.Drawing.Point(367, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Saturn
        Me.PictureBox5.Location = New System.Drawing.Point(13, 287)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Neptune
        Me.PictureBox6.Location = New System.Drawing.Point(13, 151)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Venus
        Me.PictureBox7.Location = New System.Drawing.Point(727, 286)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Uranus
        Me.PictureBox8.Location = New System.Drawing.Point(367, 287)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Image = Global.Digtial_Telescope_V_2._0.My.Resources.Resources.Pluto
        Me.PictureBox10.Location = New System.Drawing.Point(727, 150)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(116, 113)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        '
        'lbl_Mars
        '
        Me.lbl_Mars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mars.Location = New System.Drawing.Point(135, 15)
        Me.lbl_Mars.Name = "lbl_Mars"
        Me.lbl_Mars.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Mars.TabIndex = 17
        Me.lbl_Mars.Text = "No Data Available"
        '
        'lbl_Jupiter
        '
        Me.lbl_Jupiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Jupiter.Location = New System.Drawing.Point(489, 16)
        Me.lbl_Jupiter.Name = "lbl_Jupiter"
        Me.lbl_Jupiter.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Jupiter.TabIndex = 18
        Me.lbl_Jupiter.Text = "No Data Available"
        '
        'lbl_Mercury
        '
        Me.lbl_Mercury.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mercury.Location = New System.Drawing.Point(849, 12)
        Me.lbl_Mercury.Name = "lbl_Mercury"
        Me.lbl_Mercury.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Mercury.TabIndex = 19
        Me.lbl_Mercury.Text = "No Data Available"
        '
        'lbl_Neptune
        '
        Me.lbl_Neptune.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Neptune.Location = New System.Drawing.Point(135, 152)
        Me.lbl_Neptune.Name = "lbl_Neptune"
        Me.lbl_Neptune.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Neptune.TabIndex = 20
        Me.lbl_Neptune.Text = "No Data Available"
        '
        'lbl_Moon
        '
        Me.lbl_Moon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Moon.Location = New System.Drawing.Point(489, 151)
        Me.lbl_Moon.Name = "lbl_Moon"
        Me.lbl_Moon.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Moon.TabIndex = 21
        Me.lbl_Moon.Text = "No Data Available"
        '
        'lbl_Pluto
        '
        Me.lbl_Pluto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pluto.Location = New System.Drawing.Point(849, 151)
        Me.lbl_Pluto.Name = "lbl_Pluto"
        Me.lbl_Pluto.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Pluto.TabIndex = 22
        Me.lbl_Pluto.Text = "No Data Available"
        '
        'lbl_Venus
        '
        Me.lbl_Venus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Venus.Location = New System.Drawing.Point(849, 288)
        Me.lbl_Venus.Name = "lbl_Venus"
        Me.lbl_Venus.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Venus.TabIndex = 25
        Me.lbl_Venus.Text = "No Data Available"
        '
        'lbl_Uranus
        '
        Me.lbl_Uranus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Uranus.Location = New System.Drawing.Point(489, 288)
        Me.lbl_Uranus.Name = "lbl_Uranus"
        Me.lbl_Uranus.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Uranus.TabIndex = 24
        Me.lbl_Uranus.Text = "No Data Available"
        '
        'lbl_Saturn
        '
        Me.lbl_Saturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Saturn.Location = New System.Drawing.Point(135, 289)
        Me.lbl_Saturn.Name = "lbl_Saturn"
        Me.lbl_Saturn.Size = New System.Drawing.Size(226, 110)
        Me.lbl_Saturn.TabIndex = 23
        Me.lbl_Saturn.Text = "No Data Available"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_Venus)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_Uranus)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.lbl_Saturn)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lbl_Pluto)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.lbl_Moon)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.lbl_Neptune)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.lbl_Mercury)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.lbl_Jupiter)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.lbl_Mars)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(22, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 412)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Longitude:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Latitude:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 455)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 26)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Text = "21.0048611"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(325, 455)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 26)
        Me.TextBox2.TabIndex = 30
        Me.TextBox2.Text = "79.0484949"
        '
        'btn_DisConnect
        '
        Me.btn_DisConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DisConnect.Location = New System.Drawing.Point(995, 452)
        Me.btn_DisConnect.Name = "btn_DisConnect"
        Me.btn_DisConnect.Size = New System.Drawing.Size(116, 27)
        Me.btn_DisConnect.TabIndex = 34
        Me.btn_DisConnect.Text = "Dis-Connect"
        Me.btn_DisConnect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(745, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Port No.:"
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(815, 453)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(48, 26)
        Me.txtPort.TabIndex = 32
        '
        'btn_Connect
        '
        Me.btn_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Connect.Location = New System.Drawing.Point(873, 452)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(116, 27)
        Me.btn_Connect.TabIndex = 33
        Me.btn_Connect.Text = "Connect"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1134, 550)
        Me.Controls.Add(Me.btn_DisConnect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFetch)
        Me.Name = "Form1"
        Me.Text = "Find My Planet"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFetch As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents lbl_Mars As Label
    Friend WithEvents lbl_Jupiter As Label
    Friend WithEvents lbl_Mercury As Label
    Friend WithEvents lbl_Neptune As Label
    Friend WithEvents lbl_Moon As Label
    Friend WithEvents lbl_Pluto As Label
    Friend WithEvents lbl_Venus As Label
    Friend WithEvents lbl_Uranus As Label
    Friend WithEvents lbl_Saturn As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_DisConnect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btn_Connect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
