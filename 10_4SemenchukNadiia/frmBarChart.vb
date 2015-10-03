Public Class frmBarChart
    'Draws, prints and displays bar chart

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Displays
        BarChart()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Prints
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Sets up print dialog control
        BarChart()
    End Sub

    Sub BarChart()
        'Draws bar chart

        picBar.Refresh()

        Dim gr As Graphics = picBar.CreateGraphics
        'Creates array from function's inputs
        Dim quantities() As Single = {(frmAirplane.Search("R")), (frmAirplane.Search("L")), (frmAirplane.Search("V"))}


        gr.DrawLine(Pens.Black, 50, 145, 210, 145) 'x axis
        gr.DrawLine(Pens.Black, 50, 145, 50, 20)   'y axis
        gr.DrawLine(Pens.Black, 45, 110, 50, 110)  'mark

        For i As Integer = 0 To (quantities.Count - 1)
            'Draws bars in the graph
            gr.FillRectangle(Brushes.BlueViolet, 60 + i * 40, (145 - quantities(i)), 30, quantities(i))
        Next
        'Two strings with mark number and chart's legend
        gr.DrawString("Regular  LowCal  Vegetarian", Me.Font, Brushes.Black, 53, 150) 'legent
        gr.DrawString("35", Me.Font, Brushes.Black, 27, 100) 'mark
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes form
        Me.Close()
    End Sub
End Class