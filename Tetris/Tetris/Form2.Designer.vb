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
        Timer2 = New Timer(components)
        Enemy2 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Hellcat, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
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
        Hellcat.Location = New Point(259, 108)
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
        Enemy.Location = New Point(76, 299)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(113, 83)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        ' 
        ' Timer2
        ' 
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(476, 204)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(90, 121)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1027, 547)
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Hellcat As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Enemy2 As PictureBox

End Class
