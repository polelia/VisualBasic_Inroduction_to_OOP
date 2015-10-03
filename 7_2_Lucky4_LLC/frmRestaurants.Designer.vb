<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurants
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
        Me.lblPromt = New System.Windows.Forms.Label()
        Me.grbType = New System.Windows.Forms.GroupBox()
        Me.radPubs = New System.Windows.Forms.RadioButton()
        Me.radIndian = New System.Windows.Forms.RadioButton()
        Me.radMexican = New System.Windows.Forms.RadioButton()
        Me.radSubs = New System.Windows.Forms.RadioButton()
        Me.radEuropean = New System.Windows.Forms.RadioButton()
        Me.radAsian = New System.Windows.Forms.RadioButton()
        Me.radItalian = New System.Windows.Forms.RadioButton()
        Me.radAmerican = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.lstAreas = New System.Windows.Forms.ListBox()
        Me.lblAreas = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.grbType.SuspendLayout()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPromt
        '
        Me.lblPromt.AutoSize = True
        Me.lblPromt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromt.ForeColor = System.Drawing.Color.Black
        Me.lblPromt.Location = New System.Drawing.Point(170, 9)
        Me.lblPromt.Name = "lblPromt"
        Me.lblPromt.Size = New System.Drawing.Size(297, 32)
        Me.lblPromt.TabIndex = 9
        Me.lblPromt.Text = "Now with Lucky4 LLC," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " choosing a restaurant is easier than ever!"
        Me.lblPromt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbType
        '
        Me.grbType.Controls.Add(Me.radPubs)
        Me.grbType.Controls.Add(Me.radIndian)
        Me.grbType.Controls.Add(Me.radMexican)
        Me.grbType.Controls.Add(Me.radSubs)
        Me.grbType.Controls.Add(Me.radEuropean)
        Me.grbType.Controls.Add(Me.radAsian)
        Me.grbType.Controls.Add(Me.radItalian)
        Me.grbType.Controls.Add(Me.radAmerican)
        Me.grbType.Location = New System.Drawing.Point(390, 85)
        Me.grbType.Name = "grbType"
        Me.grbType.Size = New System.Drawing.Size(218, 107)
        Me.grbType.TabIndex = 1
        Me.grbType.TabStop = False
        '
        'radPubs
        '
        Me.radPubs.AutoSize = True
        Me.radPubs.Location = New System.Drawing.Point(127, 84)
        Me.radPubs.Name = "radPubs"
        Me.radPubs.Size = New System.Drawing.Size(49, 17)
        Me.radPubs.TabIndex = 7
        Me.radPubs.TabStop = True
        Me.radPubs.Text = "Pubs"
        Me.radPubs.UseVisualStyleBackColor = True
        '
        'radIndian
        '
        Me.radIndian.AutoSize = True
        Me.radIndian.Location = New System.Drawing.Point(127, 61)
        Me.radIndian.Name = "radIndian"
        Me.radIndian.Size = New System.Drawing.Size(54, 17)
        Me.radIndian.TabIndex = 6
        Me.radIndian.TabStop = True
        Me.radIndian.Text = "Indian"
        Me.radIndian.UseVisualStyleBackColor = True
        '
        'radMexican
        '
        Me.radMexican.AutoSize = True
        Me.radMexican.Location = New System.Drawing.Point(127, 35)
        Me.radMexican.Name = "radMexican"
        Me.radMexican.Size = New System.Drawing.Size(65, 17)
        Me.radMexican.TabIndex = 5
        Me.radMexican.TabStop = True
        Me.radMexican.Text = "Mexican"
        Me.radMexican.UseVisualStyleBackColor = True
        '
        'radSubs
        '
        Me.radSubs.AutoSize = True
        Me.radSubs.Location = New System.Drawing.Point(127, 12)
        Me.radSubs.Name = "radSubs"
        Me.radSubs.Size = New System.Drawing.Size(49, 17)
        Me.radSubs.TabIndex = 4
        Me.radSubs.TabStop = True
        Me.radSubs.Text = "Subs"
        Me.radSubs.UseVisualStyleBackColor = True
        '
        'radEuropean
        '
        Me.radEuropean.AutoSize = True
        Me.radEuropean.Location = New System.Drawing.Point(6, 84)
        Me.radEuropean.Name = "radEuropean"
        Me.radEuropean.Size = New System.Drawing.Size(71, 17)
        Me.radEuropean.TabIndex = 3
        Me.radEuropean.TabStop = True
        Me.radEuropean.Text = "European"
        Me.radEuropean.UseVisualStyleBackColor = True
        '
        'radAsian
        '
        Me.radAsian.AutoSize = True
        Me.radAsian.Location = New System.Drawing.Point(6, 59)
        Me.radAsian.Name = "radAsian"
        Me.radAsian.Size = New System.Drawing.Size(51, 17)
        Me.radAsian.TabIndex = 2
        Me.radAsian.TabStop = True
        Me.radAsian.Text = "Asian"
        Me.radAsian.UseVisualStyleBackColor = True
        '
        'radItalian
        '
        Me.radItalian.AutoSize = True
        Me.radItalian.Location = New System.Drawing.Point(6, 36)
        Me.radItalian.Name = "radItalian"
        Me.radItalian.Size = New System.Drawing.Size(59, 17)
        Me.radItalian.TabIndex = 1
        Me.radItalian.TabStop = True
        Me.radItalian.Text = "Italiano"
        Me.radItalian.UseVisualStyleBackColor = True
        '
        'radAmerican
        '
        Me.radAmerican.AutoSize = True
        Me.radAmerican.Location = New System.Drawing.Point(6, 12)
        Me.radAmerican.Name = "radAmerican"
        Me.radAmerican.Size = New System.Drawing.Size(69, 17)
        Me.radAmerican.TabIndex = 0
        Me.radAmerican.Text = "American"
        Me.radAmerican.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Silver
        Me.btnDisplay.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(3, 183)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(135, 60)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Get Your Ideal Jacksonville Restaurant!"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice.Location = New System.Drawing.Point(0, 65)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(219, 15)
        Me.lblChoice.TabIndex = 8
        Me.lblChoice.Text = "To start, please pick from below: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(566, 390)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 13)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "by Lucky 4, LLC"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(3, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(3, 319)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(135, 34)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(153, 212)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.Size = New System.Drawing.Size(489, 175)
        Me.dgvOutput.TabIndex = 6
        '
        'lstAreas
        '
        Me.lstAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAreas.FormattingEnabled = True
        Me.lstAreas.ItemHeight = 16
        Me.lstAreas.Items.AddRange(New Object() {"Beaches", "Mandarin", "Riverside", "San Marco", "Southside"})
        Me.lstAreas.Location = New System.Drawing.Point(172, 98)
        Me.lstAreas.Name = "lstAreas"
        Me.lstAreas.Size = New System.Drawing.Size(116, 84)
        Me.lstAreas.TabIndex = 0
        '
        'lblAreas
        '
        Me.lblAreas.AutoSize = True
        Me.lblAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreas.Location = New System.Drawing.Point(27, 98)
        Me.lblAreas.Name = "lblAreas"
        Me.lblAreas.Size = New System.Drawing.Size(139, 13)
        Me.lblAreas.TabIndex = 7
        Me.lblAreas.Text = "Jacksonville's location:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(327, 98)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(56, 13)
        Me.lblType.TabIndex = 10
        Me.lblType.Text = "Cuisine: "
        '
        'btnAll
        '
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(3, 264)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(135, 38)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "Display All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmRestaurants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 403)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblAreas)
        Me.Controls.Add(Me.lstAreas)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grbType)
        Me.Controls.Add(Me.lblPromt)
        Me.Name = "frmRestaurants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jacksonville Restaurants Information"
        Me.grbType.ResumeLayout(False)
        Me.grbType.PerformLayout()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents lblPromt As System.Windows.Forms.Label
  Friend WithEvents grbType As System.Windows.Forms.GroupBox
  Friend WithEvents btnDisplay As System.Windows.Forms.Button
  Friend WithEvents lblChoice As System.Windows.Forms.Label
  Friend WithEvents radAsian As System.Windows.Forms.RadioButton
  Friend WithEvents radItalian As System.Windows.Forms.RadioButton
  Friend WithEvents radAmerican As System.Windows.Forms.RadioButton
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents btnStatistics As System.Windows.Forms.Button
  Friend WithEvents dgvOutput As System.Windows.Forms.DataGridView
  Friend WithEvents lstAreas As System.Windows.Forms.ListBox
  Friend WithEvents lblAreas As System.Windows.Forms.Label
  Friend WithEvents lblType As System.Windows.Forms.Label
  Friend WithEvents radPubs As System.Windows.Forms.RadioButton
  Friend WithEvents radIndian As System.Windows.Forms.RadioButton
  Friend WithEvents radMexican As System.Windows.Forms.RadioButton
  Friend WithEvents radSubs As System.Windows.Forms.RadioButton
  Friend WithEvents radEuropean As System.Windows.Forms.RadioButton
  Friend WithEvents btnAll As System.Windows.Forms.Button

End Class
