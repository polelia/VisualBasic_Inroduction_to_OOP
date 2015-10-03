'Project: 3_2
'Description: Calculates and displays automobile repair bill.
'Programmer: Nadiia Semenchuk
'Date: September 14, 2014

Public Class frmRepairBill
  Const SALES_TAX As Double = 0.05 'Declaration of constants
  Const LABOR_RATE As Double = 35

  Private Sub btnComputeBill_Click(sender As Object, e As EventArgs) Handles btnComputeBill.Click

    'Declaration of variables and conversion of input data from text boxes
    Dim name As String = CStr(txtName.Text)
    Dim hours As Double = CDbl(txtHoursWorked.Text)
    Dim parts As Double = CDbl(txtPartsCost.Text)
    Dim totalCost, partsTotal, laborCost As Double

    'Calculations of the cost of parts and supplies after sales taxes, 
    'total labor expenses and total cost
    partsTotal = parts + (parts * SALES_TAX)
    laborCost = hours * LABOR_RATE
    totalCost = partsTotal + laborCost

    'Display the repair bill in the list box
    lstBill.Items.Clear()
    lstBill.Items.Add("Customer:      " & name)
    lstBill.Items.Add(" ")
    lstBill.Items.Add("Labor cost:    " & laborCost.ToString("C"))
    lstBill.Items.Add("Parts cost:    " & partsTotal.ToString("C"))
    lstBill.Items.Add("Total:         " & totalCost.ToString("C"))
  End Sub

End Class
