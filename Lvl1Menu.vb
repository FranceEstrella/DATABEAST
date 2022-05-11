Public Class Lvl1Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Receipt.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs) Handles btninventory.Click
        Me.Hide()
        Inventory.Show()
    End Sub
End Class