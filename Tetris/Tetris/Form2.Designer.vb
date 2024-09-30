<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Avatar = New PictureBox()
        Hellcat = New PictureBox()
        Timer1 = New Timer(components)
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy3 = New PictureBox()
        ScoreLabel = New Label()
        PointsTimer = New Timer(components)
        Platform1 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Hellcat, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(12, 27)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(112, 106)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Hellcat
        ' 
        Hellcat.BackColor = SystemColors.ButtonFace
        Hellcat.Image = CType(resources.GetObject("Hellcat.Image"), Image)
        Hellcat.Location = New Point(253, 124)
        Hellcat.Name = "Hellcat"
        Hellcat.Size = New Size(96, 79)
        Hellcat.SizeMode = PictureBoxSizeMode.StretchImage
        Hellcat.TabIndex = 1
        Hellcat.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Enemy
        ' 
        Enemy.BackColor = Color.Chartreuse
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(198, 263)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(113, 83)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        Enemy.Tag = "-1"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(550, 124)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(90, 121)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        Enemy2.Tag = "1"
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(877, 12)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(118, 94)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Location = New Point(343, 44)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(51, 20)
        ScoreLabel.TabIndex = 5
        ScoreLabel.Text = "Points:"
        ' 
        ' PointsTimer
        ' 
        PointsTimer.Enabled = True
        PointsTimer.Interval = 1000
        ' 
        ' Platform1
        ' 
        Platform1.BackColor = Color.DimGray
        Platform1.Location = New Point(66, 342)
        Platform1.Name = "Platform1"
        Platform1.Size = New Size(351, 13)
        Platform1.TabIndex = 6
        Platform1.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.CadetBlue
        PictureBox1.Location = New Point(646, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(18, 282)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        PictureBox1.Tag = "Wall"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Azure
        PictureBox2.Location = New Point(132, 494)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(462, 21)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        PictureBox2.Tag = "wall"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1027, 547)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Platform1)
        Controls.Add(ScoreLabel)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(Hellcat)
        Controls.Add(Avatar)
        Name = "Form2"
        Text = "    "
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Hellcat, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Hellcat As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PointsTimer As Timer
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
