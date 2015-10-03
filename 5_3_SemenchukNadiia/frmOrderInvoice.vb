'Project: 5_3
'Description: Program allows user to place his furniture order and receive its invoice
'Programmer: Nadiia Semenchuk
'Date: September 28, 2014

'I promise that I created this code and I did not copy from someone else or the internet.


Public Class frmOrderInvoice

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
    'Form closes when the user clicks Quit button.
    Me.Close()
  End Sub


  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    'Clears previously entered information
    txtCustName.Clear()
    txtAddress.Clear()
    txtCity.Clear()
    txtDistance.Clear()
    txtNumChairs.Clear()
    txtNumSofas.Clear()
    lstInvoice.Items.Clear()
    mtbPhone.Clear()
    mtbZip.Clear()
    radYes.Checked = False

  End Sub

  Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
    'Makes delivery option textbox visible
    If radYes.Checked Then
      lblMiles.Visible = True
      txtDistance.Visible = True
    Else
      lblMiles.Visible = False
      txtDistance.Visible = False
    End If
  End Sub

  Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
    'Validates user input and calculates total price of the order

    Dim chairs, sofas As Integer
    Dim custName As String = ""
    Dim streetName As String = ""
    Dim cityName As String = ""
    Dim zipCode As String = ""
    Dim phoneNumber As String = ""
    Dim totalSofas, totalChairs, totalCost, tax, totalPrice, delivery, distMiles As Double
    
    'Utilizes a function, which checks user input
    If DataValidation() = False Then

      Dim message As String = "At least one peace of required information is improper " &
                            "or missing."
      MessageBox.Show(message)

    Else
      'Asigning values to variables
      chairs = CInt(txtNumChairs.Text)
      sofas = CInt(txtNumSofas.Text)
      custName = txtCustName.Text
      streetName = txtAddress.Text
      cityName = txtCity.Text
      zipCode = mtbZip.Text
      phoneNumber = mtbPhone.Text
      If radYes.Checked Then ' delivery value is asigned only when radio button is checked
        distMiles = CDbl(txtDistance.Text)
      End If

      'Displays error messages when order load is too big for our delivey
      If radYes.Checked And chairs > 4 And sofas > 4 Then
        MessageBox.Show("Sorry, but your order exeeds our delivery capacity.")
      ElseIf radYes.Checked And chairs > 8 And sofas >= 0 Then
        MessageBox.Show("Sorry, but your order exeeds our delivery capacity.")
      ElseIf radYes.Checked And sofas > 6 And chairs >= 0 Then
        MessageBox.Show("Sorry, but your order exceeds our delivery capacity.")
      End If

      'total cost of order
      totalChairs = chairs * 350
      totalSofas = sofas * 925
      totalCost = totalChairs + totalSofas

      'calculates the sales tax, delivery, and a final price of the order
      tax = totalCost * 0.05
      delivery = DeliveryCost(distMiles)
      totalPrice = totalCost + tax + delivery

      'Displays invoice in the list box
      DisplayInvoice(InvoiceNumber(custName, zipCode), ReorderName(custName), streetName, cityName, _
                      zipCode, phoneNumber, chairs, sofas, totalCost, delivery, tax, totalPrice)
    End If

  End Sub

  Function DataValidation() As Boolean
    'checks user input using boolean operators
    If ((txtCustName.Text = "") Or (Not txtCustName.Text.Contains(","))) Or (txtAddress.Text = "") _
        Or (txtCity.Text = "") Or (mtbZip.Text = "") Or (mtbPhone.Text = "") _
        Or (Not IsNumeric(txtNumChairs.Text)) Or (Not IsNumeric(txtNumSofas.Text)) _
        Or (radYes.Checked And (Not IsNumeric(txtDistance.Text))) Then
      Return False
    Else
      Return True
    End If
  End Function

  Function InvoiceNumber(c As String, z As String) As String
    'generates invoice number from user's last name and zip code
    Dim lastName, invNum As String
    lastName = c.ToUpper()
    invNum = lastName.Substring(0, 2) & z.Substring(1)
    Return invNum
  End Function

  Function ReorderName(c As String) As String
    'swaps user name (first name then last)
    Dim lastName, firstName, newName As String
    Dim firstComma As Integer
    firstComma = c.IndexOf(",")
    lastName = c.Substring(0, firstComma)
    firstName = c.Substring(firstComma + 1)
    newName = firstName & " " & lastName
    Return newName
  End Function

  Function DeliveryCost(ByRef d As Double) As Double
    'returns cost of delivery based on miles value
    Dim locDel As Double = 0
    If radYes.Checked Then
      Dim msg As String
      Select Case d
        Case 0 To 25
          locDel = 200
        Case 25 To 50
          locDel = 400
        Case Else
          msg = "Sorry, we deliver only within 50 miles."
          MessageBox.Show(msg)
          locDel = 0
      End Select
      Return locDel
    Else
      Return locDel
    End If
  End Function

  'displays invoice output in the listbox
  Sub DisplayInvoice(inv As String, name As String, address As String, city As String, _
                      zip As String, phone As String, numc As Integer, nums As Integer, _
                      price As Double, deliv As Double, tax As Double, totalPrice As Double)
    lstInvoice.Items.Clear()
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("Date:  " & "          " & Today)
    lstInvoice.Items.Add("Invoice number:  " & inv)
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("Name:         " & name)
    lstInvoice.Items.Add("Address:       " & address)
    lstInvoice.Items.Add("City:          " & city & " " & zip)
    lstInvoice.Items.Add("Contact phone: " & phone)
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("Number of chairs: " & numc)
    lstInvoice.Items.Add("Number of sofas:  " & nums)
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("")
    lstInvoice.Items.Add("                " & "Price: " & price.ToString("c"))
    lstInvoice.Items.Add("            " & "Sales Tax: " & tax.ToString("c"))
    lstInvoice.Items.Add("             " & "Delivery: " & deliv.ToString("c"))
    lstInvoice.Items.Add("                  " & "-----------------")
    lstInvoice.Items.Add("          " & "Total Price: " & totalPrice.ToString("c"))
  End Sub
End Class
