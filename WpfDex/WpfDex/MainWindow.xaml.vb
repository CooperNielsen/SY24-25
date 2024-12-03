Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        FortniteBox.Visibility = Visibility.Visible
        FortnitePic.Visibility = Visibility.Visible
        SandcarBox.Visibility = Visibility.Hidden
        SandcarPic.Visibility = Visibility.Hidden
        K10Box.Visibility = Visibility.Hidden
        K10Pic.Visibility = Visibility.Hidden
    End Sub

    Private Sub Sand_Click(sender As Object, e As RoutedEventArgs) Handles Sand.Click
        FortniteBox.Visibility = Visibility.Hidden
        FortnitePic.Visibility = Visibility.Hidden
        SandcarBox.Visibility = Visibility.Visible
        SandcarPic.Visibility = Visibility.Visible
        K10Box.Visibility = Visibility.Hidden
        K10Pic.Visibility = Visibility.Hidden
    End Sub

    Private Sub K10_Click(sender As Object, e As RoutedEventArgs) Handles K10.Click
        FortniteBox.Visibility = Visibility.Hidden
        FortnitePic.Visibility = Visibility.Hidden
        SandcarBox.Visibility = Visibility.Hidden
        SandcarPic.Visibility = Visibility.Hidden
        K10Box.Visibility = Visibility.Visible
        K10Pic.Visibility = Visibility.Visible
    End Sub
End Class
