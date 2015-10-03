Public Class frmAnimation
    'airplain flies
    Private Sub frmAnimation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        picAirplane.Visible = True
        Timer2.Enabled = True
        Timer2.Interval = 1800

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer = 2
        Dim y As Integer = 1

        picAirplane.Left += x
        picAirplane.Top -= y


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Me.Close()
    End Sub
End Class