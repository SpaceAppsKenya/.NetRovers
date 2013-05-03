Class Window1

    Dim theCon As New connection

    Private response As String


    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnStop.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/5")
    End Sub

    Private Sub btnStop_GotFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnStop.GotFocus
        Me.btnStop.Background = Brushes.Red
    End Sub

    Private Sub btnStop_LostFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnStop.LostFocus
        Me.btnStop.Background = Brushes.BurlyWood
    End Sub

    Private Sub btnStop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles btnStop.MouseUp
        Me.btnStop.Background = Brushes.Blue
    End Sub


    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnReverse.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/2")
    End Sub

    Private Sub btnReverse_GotFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnReverse.GotFocus
        Me.btnReverse.Background = Brushes.Red
    End Sub

    Private Sub btnReverse_LostFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnReverse.LostFocus
        Me.btnReverse.Background = Brushes.BurlyWood
    End Sub

    Private Sub btnReverse_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles btnReverse.MouseUp
        Me.btnReverse.Background = Brushes.Blue
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnForward.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/1")
    End Sub

    Private Sub btnForward_GotFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnForward.GotFocus
        Me.btnForward.Background = Brushes.Red
    End Sub

    Private Sub btnForward_LostFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnForward.LostFocus
        Me.btnForward.Background = Brushes.BurlyWood
    End Sub

    Private Sub btnForward_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles btnForward.MouseUp
        Me.btnForward.Background = Brushes.Blue
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnLeft.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/3")
    End Sub

    Private Sub btnLeft_GotFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnLeft.GotFocus
        Me.btnLeft.Background = Brushes.Red
    End Sub

    Private Sub btnLeft_LostFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnLeft.LostFocus
        Me.btnLeft.Background = Brushes.BurlyWood
    End Sub

    Private Sub btnLeft_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles btnLeft.MouseUp
        Me.btnLeft.Background = Brushes.Blue
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRight.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/4")
    End Sub

    Private Sub btnRight_GotFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRight.GotFocus
        Me.btnRight.Background = Brushes.Red
    End Sub

    Private Sub btnRight_LostFocus(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRight.LostFocus
        Me.btnRight.Background = Brushes.BurlyWood
    End Sub

    Private Sub btnRight_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles btnRight.MouseUp
        Me.btnRight.Background = Brushes.Blue
    End Sub

    Private Sub CheckBox1_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles CheckBox1.Checked
        Me.Label6.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Me.response = theCon.HttpGet("http://192.168.11.173:12345/cmd/6")
    End Sub

    Private Sub Window1_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

    End Sub
End Class
