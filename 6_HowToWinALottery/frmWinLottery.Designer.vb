<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinLottery
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
        Me.chkScratchOff = New System.Windows.Forms.CheckBox()
        Me.chkDraw = New System.Windows.Forms.CheckBox()
        Me.btnGetTickets = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.mtbAmount = New System.Windows.Forms.MaskedTextBox()
        Me.grbScratch = New System.Windows.Forms.GroupBox()
        Me.chkBingo = New System.Windows.Forms.CheckBox()
        Me.chkInferno = New System.Windows.Forms.CheckBox()
        Me.chkRoyal = New System.Windows.Forms.CheckBox()
        Me.grbDraw = New System.Windows.Forms.GroupBox()
        Me.chkMega = New System.Windows.Forms.CheckBox()
        Me.chkPowerball = New System.Windows.Forms.CheckBox()
        Me.chkFlorida = New System.Windows.Forms.CheckBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grbScratch.SuspendLayout()
        Me.grbDraw.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkScratchOff
        '
        Me.chkScratchOff.AutoSize = True
        Me.chkScratchOff.Location = New System.Drawing.Point(65, 137)
        Me.chkScratchOff.Name = "chkScratchOff"
        Me.chkScratchOff.Size = New System.Drawing.Size(85, 17)
        Me.chkScratchOff.TabIndex = 1
        Me.chkScratchOff.Text = "Scratch-Offs"
        Me.chkScratchOff.UseVisualStyleBackColor = True
        '
        'chkDraw
        '
        Me.chkDraw.AutoSize = True
        Me.chkDraw.Location = New System.Drawing.Point(65, 224)
        Me.chkDraw.Name = "chkDraw"
        Me.chkDraw.Size = New System.Drawing.Size(87, 17)
        Me.chkDraw.TabIndex = 2
        Me.chkDraw.Text = "Draw Games"
        Me.chkDraw.UseVisualStyleBackColor = True
        '
        'btnGetTickets
        '
        Me.btnGetTickets.Location = New System.Drawing.Point(1, 279)
        Me.btnGetTickets.Name = "btnGetTickets"
        Me.btnGetTickets.Size = New System.Drawing.Size(105, 51)
        Me.btnGetTickets.TabIndex = 5
        Me.btnGetTickets.Text = "Get my tickets!"
        Me.btnGetTickets.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(36, 21)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(160, 52)
        Me.lblQuestion.TabIndex = 7
        Me.lblQuestion.Text = "How much money do you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wish to spend" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on lottery tickets?"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 525)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "by Nadiia"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(26, 90)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(124, 15)
        Me.lblOptions.TabIndex = 9
        Me.lblOptions.Text = "Choose your options: "
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 427)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'mtbAmount
        '
        Me.mtbAmount.Location = New System.Drawing.Point(202, 37)
        Me.mtbAmount.Mask = "00000"
        Me.mtbAmount.Name = "mtbAmount"
        Me.mtbAmount.Size = New System.Drawing.Size(59, 20)
        Me.mtbAmount.TabIndex = 14
        '
        'grbScratch
        '
        Me.grbScratch.Controls.Add(Me.chkBingo)
        Me.grbScratch.Controls.Add(Me.chkInferno)
        Me.grbScratch.Controls.Add(Me.chkRoyal)
        Me.grbScratch.Location = New System.Drawing.Point(202, 96)
        Me.grbScratch.Name = "grbScratch"
        Me.grbScratch.Size = New System.Drawing.Size(235, 83)
        Me.grbScratch.TabIndex = 15
        Me.grbScratch.TabStop = False
        Me.grbScratch.Text = "Scratch-Off"
        Me.grbScratch.Visible = False
        '
        'chkBingo
        '
        Me.chkBingo.AutoSize = True
        Me.chkBingo.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBingo.Location = New System.Drawing.Point(9, 56)
        Me.chkBingo.Name = "chkBingo"
        Me.chkBingo.Size = New System.Drawing.Size(202, 21)
        Me.chkBingo.TabIndex = 2
        Me.chkBingo.Text = "Bingo Gold (win up to $50,000)"
        Me.chkBingo.UseVisualStyleBackColor = True
        '
        'chkInferno
        '
        Me.chkInferno.AutoSize = True
        Me.chkInferno.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInferno.Location = New System.Drawing.Point(9, 35)
        Me.chkInferno.Name = "chkInferno"
        Me.chkInferno.Size = New System.Drawing.Size(212, 21)
        Me.chkInferno.TabIndex = 1
        Me.chkInferno.Text = "Cash Inferno (win up to $30,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkInferno.UseVisualStyleBackColor = True
        '
        'chkRoyal
        '
        Me.chkRoyal.AutoSize = True
        Me.chkRoyal.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoyal.Location = New System.Drawing.Point(9, 16)
        Me.chkRoyal.Name = "chkRoyal"
        Me.chkRoyal.Size = New System.Drawing.Size(195, 21)
        Me.chkRoyal.TabIndex = 0
        Me.chkRoyal.Text = "Royal 8's  (win up to $10,000)"
        Me.chkRoyal.UseVisualStyleBackColor = True
        '
        'grbDraw
        '
        Me.grbDraw.Controls.Add(Me.chkMega)
        Me.grbDraw.Controls.Add(Me.chkPowerball)
        Me.grbDraw.Controls.Add(Me.chkFlorida)
        Me.grbDraw.Location = New System.Drawing.Point(202, 185)
        Me.grbDraw.Name = "grbDraw"
        Me.grbDraw.Size = New System.Drawing.Size(247, 87)
        Me.grbDraw.TabIndex = 16
        Me.grbDraw.TabStop = False
        Me.grbDraw.Text = "Draw Games"
        Me.grbDraw.Visible = False
        '
        'chkMega
        '
        Me.chkMega.AutoSize = True
        Me.chkMega.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMega.Location = New System.Drawing.Point(9, 60)
        Me.chkMega.Name = "chkMega"
        Me.chkMega.Size = New System.Drawing.Size(244, 21)
        Me.chkMega.TabIndex = 2
        Me.chkMega.Text = "Mega Millions (jackpot $150,000,000)"
        Me.chkMega.UseVisualStyleBackColor = True
        '
        'chkPowerball
        '
        Me.chkPowerball.AutoSize = True
        Me.chkPowerball.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPowerball.Location = New System.Drawing.Point(9, 39)
        Me.chkPowerball.Name = "chkPowerball"
        Me.chkPowerball.Size = New System.Drawing.Size(215, 21)
        Me.chkPowerball.TabIndex = 1
        Me.chkPowerball.Text = "Powerball (jackpot $80,000,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkPowerball.UseVisualStyleBackColor = True
        '
        'chkFlorida
        '
        Me.chkFlorida.AutoSize = True
        Me.chkFlorida.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlorida.Location = New System.Drawing.Point(9, 19)
        Me.chkFlorida.Name = "chkFlorida"
        Me.chkFlorida.Size = New System.Drawing.Size(229, 21)
        Me.chkFlorida.TabIndex = 0
        Me.chkFlorida.Text = "Florida Lotto (jackpot $34,000,000)"
        Me.chkFlorida.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 15
        Me.lstDisplay.Location = New System.Drawing.Point(123, 279)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(355, 259)
        Me.lstDisplay.TabIndex = 17
        '
        'frmWinLottery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 544)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.grbDraw)
        Me.Controls.Add(Me.grbScratch)
        Me.Controls.Add(Me.mtbAmount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnGetTickets)
        Me.Controls.Add(Me.chkDraw)
        Me.Controls.Add(Me.chkScratchOff)
        Me.Name = "frmWinLottery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Win a Lottery"
        Me.grbScratch.ResumeLayout(False)
        Me.grbScratch.PerformLayout()
        Me.grbDraw.ResumeLayout(False)
        Me.grbDraw.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents chkScratchOff As System.Windows.Forms.CheckBox
  Friend WithEvents chkDraw As System.Windows.Forms.CheckBox
  Friend WithEvents btnGetTickets As System.Windows.Forms.Button
  Friend WithEvents lblQuestion As System.Windows.Forms.Label
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblOptions As System.Windows.Forms.Label
  Friend WithEvents btnQuit As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents mtbAmount As System.Windows.Forms.MaskedTextBox
  Friend WithEvents grbScratch As System.Windows.Forms.GroupBox
  Friend WithEvents chkBingo As System.Windows.Forms.CheckBox
  Friend WithEvents chkInferno As System.Windows.Forms.CheckBox
  Friend WithEvents chkRoyal As System.Windows.Forms.CheckBox
  Friend WithEvents grbDraw As System.Windows.Forms.GroupBox
  Friend WithEvents chkMega As System.Windows.Forms.CheckBox
  Friend WithEvents chkPowerball As System.Windows.Forms.CheckBox
  Friend WithEvents chkFlorida As System.Windows.Forms.CheckBox
  Friend WithEvents lstDisplay As System.Windows.Forms.ListBox

End Class
