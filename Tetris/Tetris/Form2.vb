Public Class Form2
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PaceY(Enemy2Bad, PictureBox1, 4)
        PaceX(EnemyBad, Platform1, 4)
        follow(Enemy3Bad, Avatar, 3, 3)
        follow(Enemy4Bad, Avatar, 3, 3)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width / 2 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
        End If
    End Sub


    Sub follow(e As PictureBox, a As PictureBox, xspeed As Integer, yspeed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, yspeed)
        Else
            move(e, 0, -yspeed)
        End If

        If e.Location.X < a.Location.X Then
            move(e, xspeed, 0)
        Else
            move(e, -xspeed, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 30, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -30, 0)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -30)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 30)
        End If
        Avatar.Refresh()
        If Avatar.Bounds.IntersectsWith(Hellcat.Bounds) Then
            Hellcat.Visible = False
            PointsTimer.Enabled = True
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        If IntersectsWith(Avatar, "Bad") Then
            EnemyBad.Location = New Point(198, 263)
            Enemy2Bad.Location = New Point(550, 133)
            Enemy3Bad.Location = New Point(877, 12)
            Enemy4Bad.Location = New Point(12, 374)
            ScoreLabel.Text = 0
            Hellcat.Visible = True
            Avatar.Location = New Point(12, 12)
        End If
    End Sub
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function



    Private Sub PointsTimer_Tick(sender As Object, e As EventArgs) Handles PointsTimer.Tick
        score += 1
        ScoreLabel.Text = score
        If score = 30 Then
            EnemyBad.Location = New Point(198, 263)
            Enemy2Bad.Location = New Point(550, 133)
            Enemy3Bad.Location = New Point(877, 12)
            Enemy4Bad.Location = New Point(12, 374)
            ScoreLabel.Text = 0
            Hellcat.Visible = True
            Avatar.Location = New Point(12, 12)

        End If
    End Sub



End Class

