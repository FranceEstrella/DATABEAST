Public Class Form1
    Dim Username As String = "Admin"
    Dim Password As String = "1234"
    Dim Tries As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tries = 3 Then
            MessageBox.Show("Too many attempts, application will now close.")
            Me.Close()
        End If

        Do While Tries <= 2
            If TextBox1.Text = Username And TextBox2.Text = Password Then
                MessageBox.Show("Welcome", "Login Interface")
                Return
            Else
                MessageBox.Show("Credentials Incorrect, Please try again.")
                Tries = Tries + 1
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
                Return
            End If
        Loop
    End Sub
End Class
