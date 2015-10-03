<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderInvoice
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.txtCustName = New System.Windows.Forms.TextBox()
    Me.txtAddress = New System.Windows.Forms.TextBox()
    Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
    Me.mtbZip = New System.Windows.Forms.MaskedTextBox()
    Me.txtCity = New System.Windows.Forms.TextBox()
    Me.txtNumChairs = New System.Windows.Forms.TextBox()
    Me.lblCustomerName = New System.Windows.Forms.Label()
    Me.lblAddres1 = New System.Windows.Forms.Label()
    Me.lblPhone = New System.Windows.Forms.Label()
    Me.lblCity = New System.Windows.Forms.Label()
    Me.lblChairs = New System.Windows.Forms.Label()
    Me.lblSofas = New System.Windows.Forms.Label()
    Me.lblCompanyName = New System.Windows.Forms.Label()
    Me.lblMyName = New System.Windows.Forms.Label()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.lstInvoice = New System.Windows.Forms.ListBox()
    Me.radYes = New System.Windows.Forms.RadioButton()
    Me.lblDelivery = New System.Windows.Forms.Label()
    Me.radNo = New System.Windows.Forms.RadioButton()
    Me.txtNumSofas = New System.Windows.Forms.TextBox()
    Me.txtDistance = New System.Windows.Forms.TextBox()
    Me.lblMiles = New System.Windows.Forms.Label()
    Me.lblZip = New System.Windows.Forms.Label()
    Me.lblOrderInfo = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtCustName
    '
    Me.txtCustName.Location = New System.Drawing.Point(120, 67)
    Me.txtCustName.Name = "txtCustName"
    Me.txtCustName.Size = New System.Drawing.Size(174, 20)
    Me.txtCustName.TabIndex = 0
    '
    'txtAddress
    '
    Me.txtAddress.Location = New System.Drawing.Point(120, 107)
    Me.txtAddress.Name = "txtAddress"
    Me.txtAddress.Size = New System.Drawing.Size(174, 20)
    Me.txtAddress.TabIndex = 1
    '
    'mtbPhone
    '
    Me.mtbPhone.Location = New System.Drawing.Point(120, 206)
    Me.mtbPhone.Mask = "(999) 000-0000"
    Me.mtbPhone.Name = "mtbPhone"
    Me.mtbPhone.Size = New System.Drawing.Size(100, 20)
    Me.mtbPhone.TabIndex = 4
    '
    'mtbZip
    '
    Me.mtbZip.Location = New System.Drawing.Point(120, 159)
    Me.mtbZip.Mask = "00000"
    Me.mtbZip.Name = "mtbZip"
    Me.mtbZip.Size = New System.Drawing.Size(53, 20)
    Me.mtbZip.TabIndex = 3
    Me.mtbZip.ValidatingType = GetType(Integer)
    '
    'txtCity
    '
    Me.txtCity.Location = New System.Drawing.Point(120, 133)
    Me.txtCity.Name = "txtCity"
    Me.txtCity.Size = New System.Drawing.Size(118, 20)
    Me.txtCity.TabIndex = 2
    '
    'txtNumChairs
    '
    Me.txtNumChairs.Location = New System.Drawing.Point(171, 294)
    Me.txtNumChairs.Name = "txtNumChairs"
    Me.txtNumChairs.Size = New System.Drawing.Size(32, 20)
    Me.txtNumChairs.TabIndex = 5
    '
    'lblCustomerName
    '
    Me.lblCustomerName.Location = New System.Drawing.Point(32, 67)
    Me.lblCustomerName.Name = "lblCustomerName"
    Me.lblCustomerName.Size = New System.Drawing.Size(82, 31)
    Me.lblCustomerName.TabIndex = 7
    Me.lblCustomerName.Text = "Customer Name (Last, First):"
    '
    'lblAddres1
    '
    Me.lblAddres1.AutoSize = True
    Me.lblAddres1.Location = New System.Drawing.Point(66, 110)
    Me.lblAddres1.Name = "lblAddres1"
    Me.lblAddres1.Size = New System.Drawing.Size(51, 13)
    Me.lblAddres1.TabIndex = 8
    Me.lblAddres1.Text = "Address: "
    '
    'lblPhone
    '
    Me.lblPhone.AutoSize = True
    Me.lblPhone.Location = New System.Drawing.Point(34, 209)
    Me.lblPhone.Name = "lblPhone"
    Me.lblPhone.Size = New System.Drawing.Size(83, 13)
    Me.lblPhone.TabIndex = 10
    Me.lblPhone.Text = "Contact phone: "
    '
    'lblCity
    '
    Me.lblCity.AutoSize = True
    Me.lblCity.Location = New System.Drawing.Point(56, 136)
    Me.lblCity.Name = "lblCity"
    Me.lblCity.Size = New System.Drawing.Size(61, 13)
    Me.lblCity.TabIndex = 11
    Me.lblCity.Text = "City, State: "
    '
    'lblChairs
    '
    Me.lblChairs.AutoSize = True
    Me.lblChairs.Location = New System.Drawing.Point(32, 297)
    Me.lblChairs.Name = "lblChairs"
    Me.lblChairs.Size = New System.Drawing.Size(132, 13)
    Me.lblChairs.TabIndex = 12
    Me.lblChairs.Text = "Number of chairs ordered: "
    '
    'lblSofas
    '
    Me.lblSofas.AutoSize = True
    Me.lblSofas.Location = New System.Drawing.Point(35, 327)
    Me.lblSofas.Name = "lblSofas"
    Me.lblSofas.Size = New System.Drawing.Size(129, 13)
    Me.lblSofas.TabIndex = 13
    Me.lblSofas.Text = "Number of sofas ordered: "
    '
    'lblCompanyName
    '
    Me.lblCompanyName.AutoSize = True
    Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCompanyName.Location = New System.Drawing.Point(197, 23)
    Me.lblCompanyName.Name = "lblCompanyName"
    Me.lblCompanyName.Size = New System.Drawing.Size(231, 20)
    Me.lblCompanyName.TabIndex = 14
    Me.lblCompanyName.Text = "Better Home Furniture, LLC"
    '
    'lblMyName
    '
    Me.lblMyName.AutoSize = True
    Me.lblMyName.Location = New System.Drawing.Point(471, 504)
    Me.lblMyName.Name = "lblMyName"
    Me.lblMyName.Size = New System.Drawing.Size(111, 13)
    Me.lblMyName.TabIndex = 15
    Me.lblMyName.Text = "by Nadiia Semenchuk"
    '
    'btnDisplay
    '
    Me.btnDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption
    Me.btnDisplay.Location = New System.Drawing.Point(24, 462)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(149, 28)
    Me.btnDisplay.TabIndex = 9
    Me.btnDisplay.Text = "Process Order"
    Me.btnDisplay.UseVisualStyleBackColor = False
    '
    'btnClear
    '
    Me.btnClear.Location = New System.Drawing.Point(218, 462)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(149, 28)
    Me.btnClear.TabIndex = 10
    Me.btnClear.Text = "Clear Order Form"
    Me.btnClear.UseVisualStyleBackColor = True
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(412, 462)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(149, 28)
    Me.btnQuit.TabIndex = 11
    Me.btnQuit.Text = "Quit"
    Me.btnQuit.UseVisualStyleBackColor = True
    '
    'lstInvoice
    '
    Me.lstInvoice.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstInvoice.FormattingEnabled = True
    Me.lstInvoice.ItemHeight = 15
    Me.lstInvoice.Location = New System.Drawing.Point(323, 67)
    Me.lstInvoice.Name = "lstInvoice"
    Me.lstInvoice.Size = New System.Drawing.Size(250, 289)
    Me.lstInvoice.TabIndex = 12
    '
    'radYes
    '
    Me.radYes.AutoSize = True
    Me.radYes.Location = New System.Drawing.Point(130, 367)
    Me.radYes.Name = "radYes"
    Me.radYes.Size = New System.Drawing.Size(43, 17)
    Me.radYes.TabIndex = 8
    Me.radYes.TabStop = True
    Me.radYes.Text = "Yes"
    Me.radYes.UseVisualStyleBackColor = True
    '
    'lblDelivery
    '
    Me.lblDelivery.AutoSize = True
    Me.lblDelivery.Location = New System.Drawing.Point(21, 369)
    Me.lblDelivery.Name = "lblDelivery"
    Me.lblDelivery.Size = New System.Drawing.Size(99, 13)
    Me.lblDelivery.TabIndex = 21
    Me.lblDelivery.Text = "Add local delivery? "
    '
    'radNo
    '
    Me.radNo.AutoSize = True
    Me.radNo.Checked = True
    Me.radNo.Location = New System.Drawing.Point(191, 367)
    Me.radNo.Name = "radNo"
    Me.radNo.Size = New System.Drawing.Size(39, 17)
    Me.radNo.TabIndex = 7
    Me.radNo.TabStop = True
    Me.radNo.Text = "No"
    Me.radNo.UseVisualStyleBackColor = True
    '
    'txtNumSofas
    '
    Me.txtNumSofas.Location = New System.Drawing.Point(171, 324)
    Me.txtNumSofas.Name = "txtNumSofas"
    Me.txtNumSofas.Size = New System.Drawing.Size(32, 20)
    Me.txtNumSofas.TabIndex = 6
    '
    'txtDistance
    '
    Me.txtDistance.Location = New System.Drawing.Point(267, 407)
    Me.txtDistance.Name = "txtDistance"
    Me.txtDistance.Size = New System.Drawing.Size(42, 20)
    Me.txtDistance.TabIndex = 24
    Me.txtDistance.Visible = False
    '
    'lblMiles
    '
    Me.lblMiles.Location = New System.Drawing.Point(127, 395)
    Me.lblMiles.Name = "lblMiles"
    Me.lblMiles.Size = New System.Drawing.Size(134, 32)
    Me.lblMiles.TabIndex = 25
    Me.lblMiles.Text = "Enter approximate distance (up to 50 miles): "
    Me.lblMiles.Visible = False
    '
    'lblZip
    '
    Me.lblZip.AutoSize = True
    Me.lblZip.Location = New System.Drawing.Point(61, 162)
    Me.lblZip.Name = "lblZip"
    Me.lblZip.Size = New System.Drawing.Size(56, 13)
    Me.lblZip.TabIndex = 26
    Me.lblZip.Text = "Zip Code: "
    '
    'lblOrderInfo
    '
    Me.lblOrderInfo.AutoSize = True
    Me.lblOrderInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOrderInfo.Location = New System.Drawing.Point(16, 263)
    Me.lblOrderInfo.Name = "lblOrderInfo"
    Me.lblOrderInfo.Size = New System.Drawing.Size(116, 16)
    Me.lblOrderInfo.TabIndex = 27
    Me.lblOrderInfo.Text = "Order Information: "
    '
    'frmOrderInvoice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(585, 519)
    Me.Controls.Add(Me.lblOrderInfo)
    Me.Controls.Add(Me.lblZip)
    Me.Controls.Add(Me.lblMiles)
    Me.Controls.Add(Me.txtDistance)
    Me.Controls.Add(Me.txtNumSofas)
    Me.Controls.Add(Me.radNo)
    Me.Controls.Add(Me.lblDelivery)
    Me.Controls.Add(Me.radYes)
    Me.Controls.Add(Me.lstInvoice)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnClear)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lblMyName)
    Me.Controls.Add(Me.lblCompanyName)
    Me.Controls.Add(Me.lblSofas)
    Me.Controls.Add(Me.lblChairs)
    Me.Controls.Add(Me.lblCity)
    Me.Controls.Add(Me.lblPhone)
    Me.Controls.Add(Me.lblAddres1)
    Me.Controls.Add(Me.lblCustomerName)
    Me.Controls.Add(Me.txtNumChairs)
    Me.Controls.Add(Me.txtCity)
    Me.Controls.Add(Me.mtbZip)
    Me.Controls.Add(Me.mtbPhone)
    Me.Controls.Add(Me.txtAddress)
    Me.Controls.Add(Me.txtCustName)
    Me.Name = "frmOrderInvoice"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Furniture Order Form"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtCustName As System.Windows.Forms.TextBox
  Friend WithEvents txtAddress As System.Windows.Forms.TextBox
  Friend WithEvents mtbPhone As System.Windows.Forms.MaskedTextBox
  Friend WithEvents mtbZip As System.Windows.Forms.MaskedTextBox
  Friend WithEvents txtCity As System.Windows.Forms.TextBox
  Friend WithEvents txtNumChairs As System.Windows.Forms.TextBox
  Friend WithEvents lblCustomerName As System.Windows.Forms.Label
  Friend WithEvents lblAddres1 As System.Windows.Forms.Label
  Friend WithEvents lblPhone As System.Windows.Forms.Label
  Friend WithEvents lblCity As System.Windows.Forms.Label
  Friend WithEvents lblChairs As System.Windows.Forms.Label
  Friend WithEvents lblSofas As System.Windows.Forms.Label
  Friend WithEvents lblCompanyName As System.Windows.Forms.Label
  Friend WithEvents lblMyName As System.Windows.Forms.Label
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents btnQuit As System.Windows.Forms.Button
  Friend WithEvents lstInvoice As System.Windows.Forms.ListBox
  Friend WithEvents radYes As System.Windows.Forms.RadioButton
  Friend WithEvents lblDelivery As System.Windows.Forms.Label
  Friend WithEvents radNo As System.Windows.Forms.RadioButton
  Friend WithEvents txtNumSofas As System.Windows.Forms.TextBox
  Friend WithEvents txtDistance As System.Windows.Forms.TextBox
  Friend WithEvents lblMiles As System.Windows.Forms.Label
  Friend WithEvents lblZip As System.Windows.Forms.Label
  Friend WithEvents lblOrderInfo As System.Windows.Forms.Label

End Class
