Public Class frmPie
    'Draws pie chart
    

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes form
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picPie.Refresh() 'refreshes picture box from previous graphics

        Dim legend() As String = {"Reserved", "Vacant", "Windows Avail"} 'legend
        'creates array with elements that are oututs from search functions
        Dim quantities() As Single = {(90 - frmAirplane.Search(".")), (frmAirplane.Search(".")), (frmAirplane.Windows())}
        Dim perc(quantities.Count - 1) As Single
        Dim sumOfQuant As Single = 0
        Dim sumOfSwAngl As Single = 0

        Dim br() As Brush = {Brushes.Coral, Brushes.LawnGreen, Brushes.BlueViolet}
        Dim gr As Graphics = picPie.CreateGraphics

        Dim r As Integer = 90 'radius
        Dim c As Integer = 95  'center

        For i As Integer = 0 To (quantities.Count - 1) 'calculates total sum of all values
            sumOfQuant += quantities(i)
        Next

        For i As Integer = 0 To (quantities.Count - 1) 'computed percentage
            perc(i) = quantities(i) / sumOfQuant
        Next
        'draws circle and calculates sweep angles. 
        For i As Integer = 0 To (quantities.Count - 1)
            gr.FillPie(br(i), c - r, c - r, 2 * r, 2 * r, sumOfSwAngl, perc(i) * 360)
            sumOfSwAngl += perc(i) * 360

            gr.FillRectangle(br(i), 220, 20 + 30 * i, 20, 20)
            gr.DrawString(legend(i), Me.Font, Brushes.Black, 250, 22 + 30 * i)
        Next
    End Sub
End Class