Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim urlString As String = TextBox1.Text
        Dim uri As Uri
        If Uri.TryCreate(urlString, UriKind.Absolute, uri) Then
            WebBrowser1.Url = uri ' outputs "https://www.example.com/"
        Else
            TextBox1.Text = "Invalid URL"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoHome()
    End Sub
    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        AddHandler WebBrowser1.Document.Window.Error, AddressOf Window_Error 'subscribe to the Error event
    End Sub

    Private Sub Window_Error(sender As Object, e As HtmlElementErrorEventArgs)
        e.Handled = True 'handle the script error
        Dim okButtons As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        For Each btn As HtmlElement In okButtons
            If btn.GetAttribute("type") = "button" And btn.GetAttribute("value") = "Igen" Then
                btn.InvokeMember("click") 'click the OK button
                Exit For
            End If
        Next
    End Sub



End Class
