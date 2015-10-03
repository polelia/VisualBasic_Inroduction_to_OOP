Public Class frmSeatStatus
    'takes user input and updates variable "status"
    Public status As String = ""

    Private Sub frmSeatStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clears checked buttons
        radDiet.Checked = False
        radEmpty.Checked = False
        radRegular.Checked = False
        radVegeterian.Checked = False
    End Sub

    Private Sub radEmpty_CheckedChanged(sender As Object, e As EventArgs) Handles radEmpty.CheckedChanged
        'selected button assigns related value to status and closes form. 
        If radEmpty.Checked Then
            Me.Close()
            status = "." 'empty seats
        End If
    End Sub

    Private Sub radDiet_CheckedChanged(sender As Object, e As EventArgs) Handles radDiet.CheckedChanged
        If radDiet.Checked Then
            Me.Close()
            status = "L" 'low calorie food
        End If
    End Sub

    Private Sub radRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radRegular.CheckedChanged
        If radRegular.Checked Then
            Me.Close()
            status = "R" 'regular meals
        End If
    End Sub

    Private Sub radVegeterian_CheckedChanged(sender As Object, e As EventArgs) Handles radVegeterian.CheckedChanged
        If radVegeterian.Checked Then
            Me.Close()
            status = "V" 'vegeterian food
        End If
    End Sub
End Class