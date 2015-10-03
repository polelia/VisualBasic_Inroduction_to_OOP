'Project: 10_4
'Description: Program interacts with a user in a way that he/she is able to reserve airplane seats 
'             and request type of meal. Also program displays different kind of statistics utilising
'             bar and pie charts and query searches. Contains hard coded animation, whucj is displayed 
'             when user clicks display statistics button.
'Author: Nadiia Semenchuk
'Date: November 26, 2014

'I promise that I created this code and I did not copy from someone else or the internet.


Public Class frmAirplane

    '    Dim seatsList() As String = IO.File.ReadAllLines("Seats.txt")
    Structure Airplane
        Dim A As String
        Dim B As String
        Dim C As String
        Dim space As String
        Dim D As String
        Dim E As String
        Dim F As String
    End Structure

    Dim airSeats(15) As Airplane
    Dim totalWindow As Integer = 0    'windows available
    Dim totalEmpty As Integer = 0     'seats available
    Dim totalReserved As Integer = 0  'reserved seats
    Dim ttlRegular As Integer = 0     '# of regular meals
    Dim ttlVegeterian As Integer = 0  ' vegeterian
    Dim ttlDiet As Integer = 0        ' low calorie

    Private Sub frmAirplane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        Dim ln As String
        Dim datum() As String
        Dim input() As String = IO.File.ReadAllLines("Seats.txt")
        For i As Integer = 0 To 15
            ln = input(i) 'reads each new line of txt file
            datum = ln.Split(","c) 'splits each line into separate parts, using coma delimeter
            airSeats(i).A = datum(0)
            airSeats(i).B = datum(1)
            airSeats(i).C = datum(2)
            airSeats(i).space = datum(3)
            airSeats(i).D = datum(4)
            airSeats(i).E = datum(5)
            airSeats(i).F = datum(6)

        Next

        'populates listbox
        For j As Integer = 0 To airSeats.Count - 1
            lstSeats.Items.Add("   " & airSeats(j).A & airSeats(j).B & airSeats(j).C & _
                               "  " & airSeats(j).D & airSeats(j).E & airSeats(j).F)

        Next

    End Sub

    Private Sub lstSeats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSeats.SelectedIndexChanged

        'Splits array and populates correspondint text boxes
        If lstSeats.SelectedIndex > 0 Then
            Dim ind As Integer
            ind = lstSeats.SelectedIndex
            txtRow.Text = ind.ToString

            txtA.Text = airSeats(ind).A
            txtB.Text = airSeats(ind).B
            txtC.Text = airSeats(ind).C
            txtD.Text = airSeats(ind).D
            txtE.Text = airSeats(ind).E
            txtF.Text = airSeats(ind).F

        Else
            MessageBox.Show("Please select your row in the list box.")
        End If

    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtA.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & frmSeatStatus.status & txtB.Text & txtC.Text & "  " _
                                    & txtD.Text & txtE.Text & txtF.Text

        LstReplace(findLine, replaceLine)

        airSeats(findLine).A = frmSeatStatus.status
    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtB.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & txtA.Text & frmSeatStatus.status & txtC.Text & "  " _
                                    & txtD.Text & txtE.Text & txtF.Text

        LstReplace(findLine, replaceLine)

        airSeats(findLine).B = frmSeatStatus.status
    End Sub


    Private Sub txtC_Click(sender As Object, e As EventArgs) Handles txtC.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtC.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & txtA.Text & txtB.Text & frmSeatStatus.status & "  " _
                                    & txtD.Text & txtE.Text & txtF.Text

        LstReplace(findLine, replaceLine)

        airSeats(findLine).C = frmSeatStatus.status
    End Sub


    Private Sub txtD_Click(sender As Object, e As EventArgs) Handles txtD.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtD.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & txtA.Text & txtB.Text & txtC.Text & "  " _
                                    & frmSeatStatus.status & txtE.Text & txtF.Text

        LstReplace(findLine, replaceLine)

        airSeats(findLine).D = frmSeatStatus.status
    End Sub

    Private Sub txtE_Click(sender As Object, e As EventArgs) Handles txtE.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtE.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & txtA.Text & txtB.Text & txtC.Text & "  " _
                                    & txtD.Text & frmSeatStatus.status & txtF.Text

        LstReplace(findLine, replaceLine)

        airSeats(findLine).E = frmSeatStatus.status
    End Sub

    Private Sub txtF_Click(sender As Object, e As EventArgs) Handles txtF.Click
        'Replaces values in the txt boxes, list box and array
        frmSeatStatus.status = ""
        frmSeatStatus.ShowDialog()
        txtF.Text = frmSeatStatus.status

        Dim findLine As Integer = CInt(txtRow.Text)
        Dim replaceLine As String = "   " & txtA.Text & txtB.Text & txtC.Text & "  " _
                                    & txtD.Text & txtE.Text & frmSeatStatus.status

        LstReplace(findLine, replaceLine)

        airSeats(findLine).F = frmSeatStatus.status
    End Sub

    Sub LstReplace(fd As Integer, rpc As String)
        'Replaces row in the lstbox
        If fd > 0 Then
            lstSeats.Items.RemoveAt(fd)
            lstSeats.Items.Insert(fd, rpc)
        Else
            MessageBox.Show("Pleace select your row.")
        End If
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
       
        'Displays statistics and loads animation
        lstStats.Items.Clear()
        lstStats.Items.Add("")
        lstStats.Items.Add("Seats available: " & Search("."))
        lstStats.Items.Add("Windows available: " & Windows())
        lstStats.Items.Add("Seats filled: " & (90 - Search(".")))
        lstStats.Items.Add("")
        lstStats.Items.Add("Regular meals: " & Search("R"))
        lstStats.Items.Add("Low Calorie meals: " & Search("L"))
        lstStats.Items.Add("Vegeterian meals: " & Search("V"))

        frmAnimation.ShowDialog()
       

    End Sub

    Function Search(sgn As String) As Integer
        'Searches for specific values in array
        Dim vacA, vacB, vacC, vacD, vacE, vacF As Integer
        Dim totalNum As Integer = 0
        Dim sign As String = sgn

        Dim queryA = From lines In airSeats
                     Where lines.A = sign
                     Select lines

        For Each i In queryA
            vacA += 1
        Next

        Dim queryB = From lines In airSeats
                     Where lines.B = sign
                     Select lines

        For Each i In queryB
            vacB += 1
        Next

        Dim queryC = From lines In airSeats
                     Where lines.C = sign
                     Select lines

        For Each i In queryC
            vacC += 1
        Next

        Dim queryD = From lines In airSeats
                     Where lines.D = sign
                     Select lines

        For Each i In queryD
            vacD += 1
        Next

        Dim queryE = From lines In airSeats
                     Where lines.E = sign
                     Select lines

        For Each i In queryE
            vacE += 1
        Next
        Dim queryF = From lines In airSeats
                     Where lines.F = sign
                     Select lines

        For Each i In queryF
            vacF += 1
        Next

        totalNum = vacA + vacB + vacC + vacD + vacE + vacF
        'returns total number of the searched value occurences
        Return totalNum
    End Function

    Function Windows()
        'searches for vacant window seats
        Dim windAvail As Integer
        Dim a, f As Integer

        Dim qEmptyF = From lines In airSeats
                    Where lines.F = "."
                    Select lines

        For Each i In qEmptyF
            f += 1
        Next
        Dim qEmptyA = From lines In airSeats
                    Where lines.A = "."
                    Select lines

        For Each i In qEmptyA
            a += 1
        Next

        windAvail = a + f

        Return windAvail

    End Function

    Private Sub btnPieChart_Click(sender As Object, e As EventArgs) Handles btnPieChart.Click
        'Calls form with the pie chart
        frmPie.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes form
        Me.Close()
    End Sub

    Private Sub PrintBarChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBarChartToolStripMenuItem.Click
        'Calls form that prints bar chart
        frmBarChart.ShowDialog()
    End Sub

    Private Sub frmAirplane_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Saves all changes during for closing event
        Dim querySave = From elem In airSeats
                         Let line = elem.A & "," & elem.B & "," & elem.C & "," & " " & "," & elem.D & "," & elem.E & "," & elem.F
                         Select line

        IO.File.WriteAllLines(("Seats.txt"), querySave)
        MessageBox.Show("All changed are saved.", "Update")
    End Sub


    
End Class
