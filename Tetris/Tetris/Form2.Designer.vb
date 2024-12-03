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
        EnemyBad = New PictureBox()
        Enemy2Bad = New PictureBox()
        Enemy3Bad = New PictureBox()
        ScoreLabel = New Label()
        PointsTimer = New Timer(components)
        Platform1 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Enemy4Bad = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Hellcat, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnemyBad, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2Bad, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3Bad, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy4Bad, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(12, 12)
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
        Hellcat.Location = New Point(670, 141)
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
        ' EnemyBad
        ' 
        EnemyBad.BackColor = Color.Chartreuse
        EnemyBad.Image = CType(resources.GetObject("EnemyBad.Image"), Image)
        EnemyBad.Location = New Point(198, 263)
        EnemyBad.Name = "EnemyBad"
        EnemyBad.Size = New Size(113, 83)
        EnemyBad.SizeMode = PictureBoxSizeMode.StretchImage
        EnemyBad.TabIndex = 2
        EnemyBad.TabStop = False
        EnemyBad.Tag = "-1"
        ' 
        ' Enemy2Bad
        ' 
        Enemy2Bad.Image = CType(resources.GetObject("Enemy2Bad.Image"), Image)
        Enemy2Bad.Location = New Point(550, 133)
        Enemy2Bad.Name = "Enemy2Bad"
        Enemy2Bad.Size = New Size(90, 121)
        Enemy2Bad.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2Bad.TabIndex = 3
        Enemy2Bad.TabStop = False
        Enemy2Bad.Tag = "-1"
        ' 
        ' Enemy3Bad
        ' 
        Enemy3Bad.Image = CType(resources.GetObject("Enemy3Bad.Image"), Image)
        Enemy3Bad.Location = New Point(630, 459)
        Enemy3Bad.Name = "Enemy3Bad"
        Enemy3Bad.Size = New Size(118, 94)
        Enemy3Bad.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3Bad.TabIndex = 4
        Enemy3Bad.TabStop = False
        Enemy3Bad.Tag = ""
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Location = New Point(464, 12)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(51, 20)
        ScoreLabel.TabIndex = 5
        ScoreLabel.Text = "Points:"
        ' 
        ' PointsTimer
        ' 
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
        ' Enemy4Bad
        ' 
        Enemy4Bad.Image = CType(resources.GetObject("Enemy4Bad.Image"), Image)
        Enemy4Bad.Location = New Point(170, 394)
        Enemy4Bad.Name = "Enemy4Bad"
        Enemy4Bad.Size = New Size(118, 94)
        Enemy4Bad.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy4Bad.TabIndex = 9
        Enemy4Bad.TabStop = False
        Enemy4Bad.Tag = ""
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Tan
        PictureBox3.Location = New Point(660, 226)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(290, 28)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        PictureBox3.Tag = "Wall"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(1027, 547)
        Controls.Add(PictureBox3)
        Controls.Add(Enemy4Bad)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Platform1)
        Controls.Add(ScoreLabel)
        Controls.Add(Enemy3Bad)
        Controls.Add(Enemy2Bad)
        Controls.Add(EnemyBad)
        Controls.Add(Hellcat)
        Controls.Add(Avatar)
        Name = "Form2"
        Text = "    "
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Hellcat, ComponentModel.ISupportInitialize).EndInit()
        CType(EnemyBad, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2Bad, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3Bad, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy4Bad, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Hellcat As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents EnemyBad As PictureBox
    Friend WithEvents Enemy2Bad As PictureBox
    Friend WithEvents Enemy3Bad As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PointsTimer As Timer
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy4Bad As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
