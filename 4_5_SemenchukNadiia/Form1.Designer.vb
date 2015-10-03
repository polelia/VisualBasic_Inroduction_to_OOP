<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
    Me.chkBurgers = New System.Windows.Forms.CheckBox()
    Me.chkFries = New System.Windows.Forms.CheckBox()
    Me.chkDrinks = New System.Windows.Forms.CheckBox()
    Me.grbChoicesBurgers = New System.Windows.Forms.GroupBox()
    Me.radCheeseBacon = New System.Windows.Forms.RadioButton()
    Me.radBacon = New System.Windows.Forms.RadioButton()
    Me.radCheese = New System.Windows.Forms.RadioButton()
    Me.radRegular = New System.Windows.Forms.RadioButton()
    Me.grbChoicesFries = New System.Windows.Forms.GroupBox()
    Me.radFriesLarge = New System.Windows.Forms.RadioButton()
    Me.radFriesMed = New System.Windows.Forms.RadioButton()
    Me.radFriesSmall = New System.Windows.Forms.RadioButton()
    Me.grbChoicesDrinks = New System.Windows.Forms.GroupBox()
    Me.radWater = New System.Windows.Forms.RadioButton()
    Me.radSoda = New System.Windows.Forms.RadioButton()
    Me.btnComputeCost = New System.Windows.Forms.Button()
    Me.txtTotalCost = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblName = New System.Windows.Forms.Label()
    Me.lblDate = New System.Windows.Forms.Label()
    Me.mtbDate = New System.Windows.Forms.MaskedTextBox()
    Me.grbChoicesBurgers.SuspendLayout()
    Me.grbChoicesFries.SuspendLayout()
    Me.grbChoicesDrinks.SuspendLayout()
    Me.SuspendLayout()
    '
    'chkBurgers
    '
    Me.chkBurgers.AutoSize = True
    Me.chkBurgers.Location = New System.Drawing.Point(15, 82)
    Me.chkBurgers.Name = "chkBurgers"
    Me.chkBurgers.Size = New System.Drawing.Size(62, 17)
    Me.chkBurgers.TabIndex = 0
    Me.chkBurgers.Text = "Burgers"
    Me.chkBurgers.UseVisualStyleBackColor = True
    '
    'chkFries
    '
    Me.chkFries.AutoSize = True
    Me.chkFries.Location = New System.Drawing.Point(18, 232)
    Me.chkFries.Name = "chkFries"
    Me.chkFries.Size = New System.Drawing.Size(48, 17)
    Me.chkFries.TabIndex = 1
    Me.chkFries.Text = "Fries"
    Me.chkFries.UseVisualStyleBackColor = True
    '
    'chkDrinks
    '
    Me.chkDrinks.AutoSize = True
    Me.chkDrinks.Location = New System.Drawing.Point(18, 347)
    Me.chkDrinks.Name = "chkDrinks"
    Me.chkDrinks.Size = New System.Drawing.Size(56, 17)
    Me.chkDrinks.TabIndex = 2
    Me.chkDrinks.Text = "Drinks"
    Me.chkDrinks.UseVisualStyleBackColor = True
    '
    'grbChoicesBurgers
    '
    Me.grbChoicesBurgers.Controls.Add(Me.radCheeseBacon)
    Me.grbChoicesBurgers.Controls.Add(Me.radBacon)
    Me.grbChoicesBurgers.Controls.Add(Me.radCheese)
    Me.grbChoicesBurgers.Controls.Add(Me.radRegular)
    Me.grbChoicesBurgers.Location = New System.Drawing.Point(95, 40)
    Me.grbChoicesBurgers.Name = "grbChoicesBurgers"
    Me.grbChoicesBurgers.Size = New System.Drawing.Size(171, 128)
    Me.grbChoicesBurgers.TabIndex = 3
    Me.grbChoicesBurgers.TabStop = False
    Me.grbChoicesBurgers.Text = "Choices for Burgers"
    Me.grbChoicesBurgers.Visible = False
    '
    'radCheeseBacon
    '
    Me.radCheeseBacon.AutoSize = True
    Me.radCheeseBacon.Location = New System.Drawing.Point(6, 98)
    Me.radCheeseBacon.Name = "radCheeseBacon"
    Me.radCheeseBacon.Size = New System.Drawing.Size(166, 17)
    Me.radCheeseBacon.TabIndex = 3
    Me.radCheeseBacon.Text = "w/ bacon and cheese ($5.39)"
    Me.radCheeseBacon.UseVisualStyleBackColor = True
    '
    'radBacon
    '
    Me.radBacon.AutoSize = True
    Me.radBacon.Location = New System.Drawing.Point(6, 75)
    Me.radBacon.Name = "radBacon"
    Me.radBacon.Size = New System.Drawing.Size(107, 17)
    Me.radBacon.TabIndex = 2
    Me.radBacon.Text = "w/ bacon ($4.79)"
    Me.radBacon.UseVisualStyleBackColor = True
    '
    'radCheese
    '
    Me.radCheese.AutoSize = True
    Me.radCheese.Location = New System.Drawing.Point(6, 52)
    Me.radCheese.Name = "radCheese"
    Me.radCheese.Size = New System.Drawing.Size(112, 17)
    Me.radCheese.TabIndex = 1
    Me.radCheese.Text = "w/ cheese ($4.79)"
    Me.radCheese.UseVisualStyleBackColor = True
    '
    'radRegular
    '
    Me.radRegular.AutoSize = True
    Me.radRegular.Checked = True
    Me.radRegular.Location = New System.Drawing.Point(6, 29)
    Me.radRegular.Name = "radRegular"
    Me.radRegular.Size = New System.Drawing.Size(98, 17)
    Me.radRegular.TabIndex = 0
    Me.radRegular.TabStop = True
    Me.radRegular.Text = "Regular ($4.19)"
    Me.radRegular.UseVisualStyleBackColor = True
    '
    'grbChoicesFries
    '
    Me.grbChoicesFries.Controls.Add(Me.radFriesLarge)
    Me.grbChoicesFries.Controls.Add(Me.radFriesMed)
    Me.grbChoicesFries.Controls.Add(Me.radFriesSmall)
    Me.grbChoicesFries.Location = New System.Drawing.Point(95, 190)
    Me.grbChoicesFries.Name = "grbChoicesFries"
    Me.grbChoicesFries.Size = New System.Drawing.Size(135, 100)
    Me.grbChoicesFries.TabIndex = 4
    Me.grbChoicesFries.TabStop = False
    Me.grbChoicesFries.Text = "Choices for Fries"
    Me.grbChoicesFries.Visible = False
    '
    'radFriesLarge
    '
    Me.radFriesLarge.AutoSize = True
    Me.radFriesLarge.Location = New System.Drawing.Point(6, 77)
    Me.radFriesLarge.Name = "radFriesLarge"
    Me.radFriesLarge.Size = New System.Drawing.Size(88, 17)
    Me.radFriesLarge.TabIndex = 2
    Me.radFriesLarge.Text = "Large ($4.99)"
    Me.radFriesLarge.UseVisualStyleBackColor = True
    '
    'radFriesMed
    '
    Me.radFriesMed.AutoSize = True
    Me.radFriesMed.Location = New System.Drawing.Point(6, 53)
    Me.radFriesMed.Name = "radFriesMed"
    Me.radFriesMed.Size = New System.Drawing.Size(98, 17)
    Me.radFriesMed.TabIndex = 1
    Me.radFriesMed.Text = "Medium ($3.09)"
    Me.radFriesMed.UseVisualStyleBackColor = True
    '
    'radFriesSmall
    '
    Me.radFriesSmall.AutoSize = True
    Me.radFriesSmall.Checked = True
    Me.radFriesSmall.Location = New System.Drawing.Point(6, 30)
    Me.radFriesSmall.Name = "radFriesSmall"
    Me.radFriesSmall.Size = New System.Drawing.Size(86, 17)
    Me.radFriesSmall.TabIndex = 0
    Me.radFriesSmall.TabStop = True
    Me.radFriesSmall.Text = "Small ($2.39)"
    Me.radFriesSmall.UseVisualStyleBackColor = True
    '
    'grbChoicesDrinks
    '
    Me.grbChoicesDrinks.Controls.Add(Me.radWater)
    Me.grbChoicesDrinks.Controls.Add(Me.radSoda)
    Me.grbChoicesDrinks.Location = New System.Drawing.Point(95, 316)
    Me.grbChoicesDrinks.Name = "grbChoicesDrinks"
    Me.grbChoicesDrinks.Size = New System.Drawing.Size(135, 79)
    Me.grbChoicesDrinks.TabIndex = 5
    Me.grbChoicesDrinks.TabStop = False
    Me.grbChoicesDrinks.Text = "Choices for Drinks"
    Me.grbChoicesDrinks.Visible = False
    '
    'radWater
    '
    Me.radWater.AutoSize = True
    Me.radWater.Location = New System.Drawing.Point(6, 42)
    Me.radWater.Name = "radWater"
    Me.radWater.Size = New System.Drawing.Size(123, 17)
    Me.radWater.TabIndex = 1
    Me.radWater.Text = "Bottled water ($1.49)"
    Me.radWater.UseVisualStyleBackColor = True
    '
    'radSoda
    '
    Me.radSoda.AutoSize = True
    Me.radSoda.Checked = True
    Me.radSoda.Location = New System.Drawing.Point(6, 19)
    Me.radSoda.Name = "radSoda"
    Me.radSoda.Size = New System.Drawing.Size(86, 17)
    Me.radSoda.TabIndex = 0
    Me.radSoda.TabStop = True
    Me.radSoda.Text = "Soda ($1.69)"
    Me.radSoda.UseVisualStyleBackColor = True
    '
    'btnComputeCost
    '
    Me.btnComputeCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnComputeCost.Location = New System.Drawing.Point(284, 337)
    Me.btnComputeCost.Name = "btnComputeCost"
    Me.btnComputeCost.Size = New System.Drawing.Size(118, 58)
    Me.btnComputeCost.TabIndex = 6
    Me.btnComputeCost.Text = "Total"
    Me.btnComputeCost.UseVisualStyleBackColor = True
    '
    'txtTotalCost
    '
    Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotalCost.Location = New System.Drawing.Point(297, 418)
    Me.txtTotalCost.Name = "txtTotalCost"
    Me.txtTotalCost.ReadOnly = True
    Me.txtTotalCost.Size = New System.Drawing.Size(95, 22)
    Me.txtTotalCost.TabIndex = 7
    '
    'lblTotal
    '
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(203, 421)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(88, 16)
    Me.lblTotal.TabIndex = 8
    Me.lblTotal.Text = "Cost of meal: "
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(12, 443)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(111, 13)
    Me.lblName.TabIndex = 9
    Me.lblName.Text = "by Nadiia Semenchuk"
    '
    'lblDate
    '
    Me.lblDate.AutoSize = True
    Me.lblDate.Location = New System.Drawing.Point(270, 16)
    Me.lblDate.Name = "lblDate"
    Me.lblDate.Size = New System.Drawing.Size(73, 13)
    Me.lblDate.TabIndex = 10
    Me.lblDate.Text = "Today's Date:"
    '
    'mtbDate
    '
    Me.mtbDate.Location = New System.Drawing.Point(349, 13)
    Me.mtbDate.Mask = "00/00/0000"
    Me.mtbDate.Name = "mtbDate"
    Me.mtbDate.Size = New System.Drawing.Size(66, 20)
    Me.mtbDate.TabIndex = 11
    Me.mtbDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
    Me.mtbDate.ValidatingType = GetType(Date)
    '
    'frmMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(423, 465)
    Me.Controls.Add(Me.mtbDate)
    Me.Controls.Add(Me.lblDate)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.txtTotalCost)
    Me.Controls.Add(Me.btnComputeCost)
    Me.Controls.Add(Me.grbChoicesDrinks)
    Me.Controls.Add(Me.grbChoicesFries)
    Me.Controls.Add(Me.grbChoicesBurgers)
    Me.Controls.Add(Me.chkDrinks)
    Me.Controls.Add(Me.chkFries)
    Me.Controls.Add(Me.chkBurgers)
    Me.Name = "frmMenu"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Menu"
    Me.grbChoicesBurgers.ResumeLayout(False)
    Me.grbChoicesBurgers.PerformLayout()
    Me.grbChoicesFries.ResumeLayout(False)
    Me.grbChoicesFries.PerformLayout()
    Me.grbChoicesDrinks.ResumeLayout(False)
    Me.grbChoicesDrinks.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents chkBurgers As System.Windows.Forms.CheckBox
  Friend WithEvents chkFries As System.Windows.Forms.CheckBox
  Friend WithEvents chkDrinks As System.Windows.Forms.CheckBox
  Friend WithEvents grbChoicesBurgers As System.Windows.Forms.GroupBox
  Friend WithEvents radCheeseBacon As System.Windows.Forms.RadioButton
  Friend WithEvents radBacon As System.Windows.Forms.RadioButton
  Friend WithEvents radCheese As System.Windows.Forms.RadioButton
  Friend WithEvents radRegular As System.Windows.Forms.RadioButton
  Friend WithEvents grbChoicesFries As System.Windows.Forms.GroupBox
  Friend WithEvents radFriesLarge As System.Windows.Forms.RadioButton
  Friend WithEvents radFriesMed As System.Windows.Forms.RadioButton
  Friend WithEvents radFriesSmall As System.Windows.Forms.RadioButton
  Friend WithEvents grbChoicesDrinks As System.Windows.Forms.GroupBox
  Friend WithEvents radWater As System.Windows.Forms.RadioButton
  Friend WithEvents radSoda As System.Windows.Forms.RadioButton
  Friend WithEvents btnComputeCost As System.Windows.Forms.Button
  Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblDate As System.Windows.Forms.Label
  Friend WithEvents mtbDate As System.Windows.Forms.MaskedTextBox

End Class
