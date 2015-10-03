'GroupProject: 8_2_Lucky4_LLC
'Description: Program displays the best Jacksonville Restaurant that fits user's selection using 
'             structured arrays and LINQ queries. Also it uses 2D array for statistics display. 
'Programmers: Lucky 4, LLC. Nadiia Semenchuk
'Date: November 3, 2014

'Lucky 4, LLC. promises that we created this code and we did not copy from someone else or the internet.


Public Class frmRestaurants

  Structure JaxDinneries
    Dim name As String
    Dim cuisine As String
    Dim price As String
    Dim reviews As String
    Dim street As String
    Dim local As String
  End Structure

    Dim restaurants(64) As JaxDinneries
  Dim type As String = ""
  Dim area As String = ""

  Private Sub frmRestaurants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Loads array

    Dim line As String
    Dim data() As String
    Dim input() As String = IO.File.ReadAllLines("Restaurants.txt")
        For i As Integer = 0 To 64
            line = input(i) 'reads each new line of txt file
            data = line.Split(","c) 'splits each line into separate parts, using coma delimeter
            restaurants(i).name = data(0) 'assigns values to each column in the structured array
            restaurants(i).cuisine = data(1)
            restaurants(i).price = data(2)
            restaurants(i).reviews = data(3)
            restaurants(i).street = data(4)
            restaurants(i).local = data(5)
        Next

   
  End Sub


  Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
    'Processes user selection and displays it

    'Assigns selected type of food to a single variable
    If radAmerican.Checked Then
      type = "American"
    ElseIf radAsian.Checked Then
      type = "Asian"
    ElseIf radEuropean.Checked Then
      type = "European"
    ElseIf radIndian.Checked Then
      type = "Indian"
    ElseIf radItalian.Checked Then
      type = "Italian"
    ElseIf radMexican.Checked Then
      type = "Mexican"
    ElseIf radPubs.Checked Then
      type = "Pub"
    ElseIf radSubs.Checked Then
      type = "Subs"
    Else 'Displays error message when user does;t selec type of food
      MessageBox.Show("Please select your favorite quizine.")
    End If

    'Assigns selected area to a single variable
    Select Case lstAreas.Text
      Case "Beaches"
        area = "Beaches"
      Case "Southside"
        area = "Southside"
      Case "San Marco"
        area = "San Marco"
      Case "Riverside"
        area = "Riverside"
      Case Is = "Mandarin"
        area = "Mandarin"
      Case Else
        MessageBox.Show("Please select neighborhood.") 'Error message when "location" wasn't selected
    End Select

    'Searches throghout structured array using parameters specified by user
    Dim search = From element In restaurants
                 Where element.local = area And element.cuisine = type
                 Select element.name, element.cuisine, element.price, element.reviews, element.street, element.local
   
    'Displays results of search
    dgvOutput.DataSource = search.ToList
    dgvOutput.CurrentCell = Nothing
    DataGrid()


  End Sub

  Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
    'Displays all data from array

    radAmerican.Checked = False 'clears all previous selected controls
    radAsian.Checked = False
    radEuropean.Checked = False
    radIndian.Checked = False
    radItalian.Checked = False
    radMexican.Checked = False
    radPubs.Checked = False
    radSubs.Checked = False
    lstAreas.ClearSelected()

    'Searches for all data to display in the data grid view
    Dim query = From scan In restaurants
                Where scan.local = "Southside" Or scan.local = "Mandarin" Or scan.local = "Riverside" _
                Or scan.local = "San Marco" Or scan.local = "Beaches"
                Select scan.name, scan.cuisine, scan.price, scan.reviews, scan.street, scan.local

    dgvOutput.DataSource = query.ToList
    dgvOutput.CurrentCell = Nothing
    DataGrid()

  End Sub

  Sub DataGrid()
    'Sets up columns titles
    dgvOutput.Columns("name").HeaderText = "Restaurant"
    dgvOutput.Columns("cuisine").HeaderText = "Type of Cuisine"
    dgvOutput.Columns("price").HeaderText = "Prices"
    dgvOutput.Columns("reviews").HeaderText = "Reviews"
    dgvOutput.Columns("street").HeaderText = "Address"
    dgvOutput.Columns("local").HeaderText = "Area"
  End Sub

  

  Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ' Populates a 2D array with returned values form GetNum function, which looks for the of number restaurants
        ' with specific cuisines in the determined location. 
        Dim sum As Integer

        Dim statistics(,) As Integer = {{(GetNum("Beaches", "American")), (GetNum("Beaches", "Italian")), (GetNum("Beaches", "Mexican")), _
                                        (GetNum("Beaches", "Asian")), (GetNum("Beaches", "European")), (GetNum("Beaches", "Indian")), _
                                        (GetNum("Beaches", "Pub")), (GetNum("Beaches", "Subs"))}, {(GetNum("Mandarin", "American")), _
                                        (GetNum("Mandarin", "Italian")), (GetNum("Mandarin", "Mexican")), (GetNum("Mandarin", "Asian")), _
                                        (GetNum("Mandarin", "European")), (GetNum("Mandarin", "Indian")), (GetNum("Mandarin", "Pub")), _
                                        (GetNum("Mandarin", "Subs"))}, {(GetNum("Riverside", "American")), (GetNum("Riverside", "Italian")), _
                                        (GetNum("Riverside", "Mexican")), (GetNum("Riverside", "Asian")), (GetNum("Riverside", "European")), _
                                        (GetNum("Riverside", "Indian")), (GetNum("Riverside", "Pub")), (GetNum("Riverside", "Subs"))}, _
                                        {(GetNum("San Marco", "American")), (GetNum("San Marco", "Italian")), (GetNum("San Marco", "Mexican")), _
                                        (GetNum("San Marco", "Asian")), (GetNum("SanMarco", "European")), (GetNum("San Marco", "Indian")), _
                                        (GetNum("San Marco", "Pub")), (GetNum("San Marco", "Subs"))}, {(GetNum("Southside", "American")), _
                                        (GetNum("Southside", "Italian")), (GetNum("Southside", "Mexican")), (GetNum("Southside", "Asian")), _
                                        (GetNum("Southside", "European")), (GetNum("Southside", "Indian")), (GetNum("Southside", "Pub")), _
                                        (GetNum("Southside", "Subs"))}}

        'Selects all values in 2D array
        Dim queryFind = From num In statistics.Cast(Of Integer)()
                        Select num
        'Adds all values from query
        sum = queryFind.Sum
        MessageBox.Show("There are total of " & sum & " restaurants in our database.")


    End Sub

  Function GetNum(n As String, m As String) As Integer

    'Checks structured array for a specified parameters and returns number of their occurenses. 
    Dim number As Integer = 0
        For i As Integer = 0 To 64
            If restaurants(i).local = n And restaurants(i).cuisine = m Then
                number += 1
            End If
        Next
    Return number
  End Function

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    'Closes program.
    Me.Close()
  End Sub
End Class

