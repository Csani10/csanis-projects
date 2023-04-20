Public Class Csinálnivaló
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addtolist = TextBox2.Text
        CheckedListBox1.Items.Add(addtolist)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
            CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(i))
        Next
    End Sub
End Class
