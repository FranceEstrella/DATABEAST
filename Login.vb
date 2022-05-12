Public Class Login
    Dim lvl1 As String = "User"
    Dim lvl2 As String = "Admin"
    Dim password As String = "1234"
    Dim Tries As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Tries = 3 Then
            MessageBox.Show("Too many attempts, application will now close.")
            Me.Close()
        End If

        Do While Tries <= 2
            If txt1.Text = lvl1 And txt2.Text = password Then
                Me.Hide()
                txt1.Clear()
                txt2.Clear()
                txt1.Focus()
                Lvl1Menu.Show()
                Return
            ElseIf txt1.Text = lvl2 And txt2.Text = password Then
                Me.Hide()
                txt1.Clear()
                txt2.Clear()
                txt1.Focus()
                Lvl2Menu.Show()
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
