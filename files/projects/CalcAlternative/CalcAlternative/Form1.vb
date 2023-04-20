Public Class Form1



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double = TextBox1.Text
        Dim b As Double = TextBox2.Text
        If RadioButton1.Checked Then
            Label3.Text = a + b
        ElseIf RadioButton2.Checked Then
            Label3.Text = a - b
        ElseIf RadioButton3.Checked Then
            Label3.Text = a * b
        ElseIf RadioButton4.Checked Then
            Label3.Text = a / b
        Else
            MessageBox.Show("Írj be egy számot a rublikába vagy válaszd ki a számolási módot!")
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
