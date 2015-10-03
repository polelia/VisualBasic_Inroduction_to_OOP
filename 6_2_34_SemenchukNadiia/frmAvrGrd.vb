'Project: 6_2_34
'Description: Program asks user for five grades and returns their average. 
'Programmer: Nadiia Semenchuk
'Date: October 5, 2014

'I promise that I created this code and I did not copy from someone else or the internet.


Public Class frmAvrGrd

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
    'Closes form
    Me.Close()
  End Sub

  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
    'Asks user for five grades using loops and computes grade's average. 
    Dim gradeSum As Integer = 0
    Dim gradeAvg As Double = 0
    Dim num As Integer = 0
    Dim min As Integer = 100

    For i As Integer = 1 To 5
      'Main loop, asks user 5 times for a grade
      Dim msg As String = "Enter your grade # " & i.ToString & " please: "
      Dim title As String = "Grade"
      Dim response As String = ""

      response = InputBox(msg, title)

      Do While IsNumeric(response) = False
        'First inner loop, checks if user's input is numeric
        MessageBox.Show("Sorry, please enter only numbers.")
        response = InputBox(msg, title)
      Loop

      num = CInt(response)

      Do While num < 0 Or num > 100
        'Second inner loop, checks if user's input is in valid grade's range
        MessageBox.Show("Please enter your grade value from 1 to 100.")
        response = InputBox(msg, title)
        num = CInt(response)
      Loop

      If num < min Then
        'looks for the smallest entered number
        min = num
      End If

      gradeSum += num 'Adds all entered numbers
    Next

    'Computes and displays average grade. Value of variable min is substracted 
    'from the total sum. That difference is the sum without the lowest grade. 
    gradeAvg = (gradeSum - min) / 4
    txtAverage.Text = gradeAvg.ToString("n2")

  End Sub
End Class
