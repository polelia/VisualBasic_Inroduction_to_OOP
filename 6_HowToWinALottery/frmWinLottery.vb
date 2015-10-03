'GroupProject: 6_HowToWinALottery
'Description: Program asks a user if he/her wishes to win a lottery, takes his/her input,
'             and returns info about user's order.
'Date: October 12, 2014



Public Class frmWinLottery

  Dim change As Integer = 0
  Dim ticket1, ticket2, ticket3 As Integer
  Dim amount As Integer = 0
  Dim checkedScratchTotal As Integer = 0
  Dim input As String = ""

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
    'Closes form
    Me.Close()
  End Sub


  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    'Clears previously selected controls
    mtbAmount.Clear()
    chkDraw.Checked = False
    chkScratchOff.Checked = False
    chkBingo.Checked = False
    chkFlorida.Checked = False
    chkInferno.Checked = False
    chkMega.Checked = False
    chkPowerball.Checked = False
        chkRoyal.Checked = False
        ticket1 = 0
        ticket2 = 0
        ticket3 = 0
    lstDisplay.Items.Clear()

  End Sub

  Private Sub frmWinLottery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'Asks user if he/her wants to win a lottery and checks his/her inputs
    Dim title As String = "Your Choice"
    Dim msg As String = "Do you wish to have a shot at winning a lottery? Answer (Yes or No)"
    Dim ans As String = InputBox(msg, title).ToUpper

    Do Until ans = "YES" Or ans = "NO" Or ans = "Y" Or ans = "N"
      MessageBox.Show("Please, enter Yes or No.")
      ans = InputBox(msg, title).ToUpper
    Loop

    If ans = "NO" Or ans = "N" Then
      MessageBox.Show("If so, go back to work/study.")
      Me.Close()
    End If

  End Sub
  Private Sub chkScratchOff_CheckedChanged(sender As Object, e As EventArgs) Handles chkScratchOff.CheckedChanged
    'Makes controls visible when checkboxes are checked
    If chkScratchOff.Checked Then
      grbScratch.Visible = True
    Else
      grbScratch.Visible = False
    End If
  End Sub


  Private Sub chkDraw_CheckedChanged(sender As Object, e As EventArgs) Handles chkDraw.CheckedChanged
    'Makes controls visible when checkboxes are checked
    If chkDraw.Checked Then
      grbDraw.Visible = True
    Else
      grbDraw.Visible = False
    End If
  End Sub
 
 
  Private Sub btnGetTickets_Click(sender As Object, e As EventArgs) Handles btnGetTickets.Click

    input = mtbAmount.Text.Trim
    'Cheks if user entered dolar amount
    If input = "" Then
      MessageBox.Show("Please enter dollar amount.")
    Else
      amount = CInt(input)

      'User input validation lower level
      If amount <= 0 Then
        MessageBox.Show("Please check if you have enough money for purchase.")
      End If

      'User input validation upper level
      If amount > 10000 Then
        MessageBox.Show("Please don't spend more than you should on lotteries. Seek help. ")
      End If


      If chkScratchOff.Checked Or chkDraw.Checked Then
        Games(amount)
      Else
        MessageBox.Show("Please, make your choice.")
      End If

      'Royal's 8 = 1
      'Cash inferno = 2
      'Bingo Gold = 5
      'Florida lotto = 1
      'Powerball = 2
      'Mega Millions = 5
      
      ListOutput()
    End If
  End Sub

    Sub Games(ByRef am As Integer)
    'Calculates number of selected tickets that can be bought on user's input
    If chkBingo.Checked Or chkMega.Checked Then '$5 tickets

      'Makes sure that, if selected, at least one ticket for $2 will be bought.
      If chkInferno.Checked Or chkPowerball.Checked Then
        am -= 2
        ticket2 = 1
      End If
      'If $1 ticket is selected at least 1 will be bought.
      If chkFlorida.Checked Or chkRoyal.Checked Then
        am -= 1
        ticket3 = 1
      End If

      Do While am >= 5
        am -= 5  'looks how many $5 tickets can be bought
        ticket1 += 1 'counter
        change = am  'assigns change that is left
      Loop
    End If

    If chkInferno.Checked Or chkPowerball.Checked Then '$2 tickets

      'In a case when $5 tickets weren't selected and 1$ tickets where selected it reserves one $1 ticket.
      If (chkFlorida.Checked Or chkRoyal.Checked) And
          ((chkBingo.Checked = False) Or (chkMega.Checked = False)) Then
        am -= 1
        ticket3 = 1
      End If

      'takes what is left (if previous chkboxes were selected) and looks how many $2 tickets can be bought. 
      Do While am >= 2
        am -= 2
        ticket2 += 1
        change = am
      Loop
    End If

    If chkRoyal.Checked Or chkFlorida.Checked Then '$1 tickets
      'if something was left (or if these boxes are the only one selected) calculates 1$ tickets
      Do While am > 0
        am -= 1
        ticket3 += 1
        change = 0
      Loop
    End If

    End Sub

  
  Sub ListOutput()
        'Prints info about user's choices
        Dim r As Random = New Random
        Dim num As Integer = r.Next(99)

    lstDisplay.Items.Clear()
    lstDisplay.Items.Add("")
    lstDisplay.Items.Add("Date: " & Today)
    lstDisplay.Items.Add("")
    lstDisplay.Items.Add("You can buy with your $" & input & ":")

    'Prints info about $5 tickets only if they were selected by user.
    If chkBingo.Checked Or chkMega.Checked Then
      lstDisplay.Items.Add(ticket1.ToString &
                           " Bingo Gold or Mega Millions lottery tickets.")
    End If

    'Prints info about $2 tickets only if they were selected by user.
    If chkInferno.Checked Or chkPowerball.Checked Then
      lstDisplay.Items.Add(ticket2 &
                           " Cash Inferno and/or Powerball lottery tickets.")
    End If

    'Prints info about $1 tickets only if they were selected by user.
    If chkFlorida.Checked Or chkRoyal.Checked Then
      lstDisplay.Items.Add(ticket3.ToString &
                           " Royal 8's or Florida Lottery tickets.")
    End If

    'Prints change info only if there is any.
    If change > 0 Then
            lstDisplay.Items.Add("Your change is: $" & change.ToString("n"))
    End If

    lstDisplay.Items.Add("")

    'Creates a loop to generate i amount of lucky numbers with the amount of tickets you can buy
    For i = 1 To Math.Max(Math.Max(ticket1, ticket2), ticket3)
      lstDisplay.Items.Add("Lucky numbers: " & r.Next(99) & ", " & r.Next(99) &
                           ", " & r.Next(99) & ", " & r.Next(99) & ", " & r.Next(99))
    Next i

    lstDisplay.Items.Add("")
    lstDisplay.Items.Add("Good Luck!")

    End Sub

End Class
