Public Class Lvl2Menu

    Private Sub btnreceipt_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Receipt2.Show()
    End Sub

    Private Sub btninventory2_Click(sender As Object, e As EventArgs) Handles btninventory2.Click
        Me.Hide()
        Inventory2.Show()
    End Sub

    Private Sub btnlogout2_Click(sender As Object, e As EventArgs) Handles btnlogout2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnemployee.Click
        Me.Hide()
        Employee.Show()
    End Sub

End Class