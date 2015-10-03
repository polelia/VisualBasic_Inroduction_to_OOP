
'Project: 4_5
'Description: Program allows user to place his fast-food order and displays its total cost
'Programmer: Nadiia Semenchuk
'Date: September 21, 2014


Public Class frmMenu


  Const SALES_TAX As Double = 0.07  'Declaration of a sales tax constant


  'Displays current date when the program is loaded
  Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    mtbDate.Text = Today.ToString("MM/dd/yyyy")

  End Sub


  'Makes GroupBoxes visible when corresponding check box is checked
  'And hides them when they are unchecked
  Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged, _
      chkDrinks.CheckedChanged, chkFries.CheckedChanged
    If chkBurgers.Checked Then
      grbChoicesBurgers.Visible = True
    Else
      grbChoicesBurgers.Visible = False
    End If
    If chkDrinks.Checked Then
      grbChoicesDrinks.Visible = True
    Else
      grbChoicesDrinks.Visible = False
    End If
    If chkFries.Checked Then
      grbChoicesFries.Visible = True
    Else
      grbChoicesFries.Visible = False
    End If

  End Sub

  Private Sub btnComputeCost_Click(sender As Object, e As EventArgs) Handles btnComputeCost.Click

    Dim totalCost As Double

    'Assigns selected option from Burgers menu to totalCost variable
    If chkBurgers.Checked Then
      If radRegular.Checked Then
        totalCost += 4.19
      ElseIf radCheese.Checked Or radBacon.Checked Then 'Radio buttons have XOR property
        totalCost += 4.79
      ElseIf radCheeseBacon.Checked Then
        totalCost += 5.39
      End If
    End If

    'Adds option from Fries menu if selected
    If chkFries.Checked Then
      If radFriesSmall.Checked Then
        totalCost += 2.39
      ElseIf radFriesMed.Checked Then
        totalCost += 3.09
      ElseIf radFriesLarge.Checked Then
        totalCost += 4.99
      End If
    End If

    'Adds option from Drinks menu if selected
    If chkDrinks.Checked Then
      If radSoda.Checked Then
        totalCost += 1.69
      ElseIf radWater.Checked Then
        totalCost += 1.49
      End If
    End If

    'Calculates sales tax and displays final result
    totalCost = totalCost + (totalCost * SALES_TAX)
    txtTotalCost.Text = totalCost.ToString("C")

  End Sub

End Class
