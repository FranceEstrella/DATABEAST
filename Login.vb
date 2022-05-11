Public Class Login
    Dim Username As String = "Admin"
    Dim Password As String = "1234"
    Dim Tries As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Tries = 3 Then
            MessageBox.Show("Too many attempts, application will now close.")
            Me.Close()
        End If

        Do While Tries <= 2
            If txt1.Text = Username And txt2.Text = Password Then
                Me.Hide()
                txt1.Clear()
                txt2.Clear()
                txt1.Focus()
                Lvl1Menu.Show()
                Return
            Else
                MessageBox.Show("Credentials Incorrect, Please try again.")
                Tries = Tries + 1
                txt1.Clear()
                txt2.Clear()
                txt1.Focus()
                Return
            End If
        Loop
    End Sub
End Class
