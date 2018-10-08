Public Class Action_CTRL
    Public SQL As New Sqlcon


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If SQL.HasConnection = True Then
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
