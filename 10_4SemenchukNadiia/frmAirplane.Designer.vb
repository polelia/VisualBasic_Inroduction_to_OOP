<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirplane
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
        Me.lstSeats = New System.Windows.Forms.ListBox()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstStats = New System.Windows.Forms.ListBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnPieChart = New System.Windows.Forms.Button()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblRowA = New System.Windows.Forms.Label()
        Me.lblRowB = New System.Windows.Forms.Label()
        Me.lblRowC = New System.Windows.Forms.Label()
        Me.lblRowD = New System.Windows.Forms.Label()
        Me.lblRowE = New System.Windows.Forms.Label()
        Me.lblRowF = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintBarChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSeats
        '
        Me.lstSeats.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeats.FormattingEnabled = True
        Me.lstSeats.ItemHeight = 21
        Me.lstSeats.Location = New System.Drawing.Point(215, 12)
        Me.lstSeats.Name = "lstSeats"
        Me.lstSeats.Size = New System.Drawing.Size(166, 340)
        Me.lstSeats.TabIndex = 0
        '
        'txtRow
        '
        Me.txtRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRow.Location = New System.Drawing.Point(12, 407)
        Me.txtRow.Multiline = True
        Me.txtRow.Name = "txtRow"
        Me.txtRow.ReadOnly = True
        Me.txtRow.Size = New System.Drawing.Size(41, 36)
        Me.txtRow.TabIndex = 1
        Me.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(248, 407)
        Me.txtD.Multiline = True
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(41, 36)
        Me.txtD.TabIndex = 2
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtE
        '
        Me.txtE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE.Location = New System.Drawing.Point(295, 407)
        Me.txtE.Multiline = True
        Me.txtE.Name = "txtE"
        Me.txtE.ReadOnly = True
        Me.txtE.Size = New System.Drawing.Size(41, 36)
        Me.txtE.TabIndex = 3
        Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(342, 407)
        Me.txtF.Multiline = True
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(41, 36)
        Me.txtF.TabIndex = 4
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(184, 407)
        Me.txtC.Multiline = True
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(41, 36)
        Me.txtC.TabIndex = 5
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(90, 407)
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(41, 36)
        Me.txtA.TabIndex = 6
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(137, 407)
        Me.txtB.Multiline = True
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(41, 36)
        Me.txtB.TabIndex = 7
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(281, 458)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "by Semenchuk Nadiia"
        '
        'lstStats
        '
        Me.lstStats.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStats.FormattingEnabled = True
        Me.lstStats.ItemHeight = 16
        Me.lstStats.Location = New System.Drawing.Point(15, 42)
        Me.lstStats.Name = "lstStats"
        Me.lstStats.Size = New System.Drawing.Size(184, 148)
        Me.lstStats.TabIndex = 9
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(25, 216)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(162, 40)
        Me.btnStats.TabIndex = 10
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnPieChart
        '
        Me.btnPieChart.Location = New System.Drawing.Point(25, 311)
        Me.btnPieChart.Name = "btnPieChart"
        Me.btnPieChart.Size = New System.Drawing.Size(162, 41)
        Me.btnPieChart.TabIndex = 11
        Me.btnPieChart.Text = "View Pie Chart"
        Me.btnPieChart.UseVisualStyleBackColor = True
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow.Location = New System.Drawing.Point(12, 386)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(42, 15)
        Me.lblRow.TabIndex = 13
        Me.lblRow.Text = "Row #"
        '
        'lblRowA
        '
        Me.lblRowA.AutoSize = True
        Me.lblRowA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowA.Location = New System.Drawing.Point(98, 377)
        Me.lblRowA.Name = "lblRowA"
        Me.lblRowA.Size = New System.Drawing.Size(23, 24)
        Me.lblRowA.TabIndex = 14
        Me.lblRowA.Text = "A"
        '
        'lblRowB
        '
        Me.lblRowB.AutoSize = True
        Me.lblRowB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowB.Location = New System.Drawing.Point(146, 377)
        Me.lblRowB.Name = "lblRowB"
        Me.lblRowB.Size = New System.Drawing.Size(22, 24)
        Me.lblRowB.TabIndex = 15
        Me.lblRowB.Text = "B"
        '
        'lblRowC
        '
        Me.lblRowC.AutoSize = True
        Me.lblRowC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowC.Location = New System.Drawing.Point(193, 377)
        Me.lblRowC.Name = "lblRowC"
        Me.lblRowC.Size = New System.Drawing.Size(23, 24)
        Me.lblRowC.TabIndex = 16
        Me.lblRowC.Text = "C"
        '
        'lblRowD
        '
        Me.lblRowD.AutoSize = True
        Me.lblRowD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowD.Location = New System.Drawing.Point(257, 377)
        Me.lblRowD.Name = "lblRowD"
        Me.lblRowD.Size = New System.Drawing.Size(23, 24)
        Me.lblRowD.TabIndex = 17
        Me.lblRowD.Text = "D"
        '
        'lblRowE
        '
        Me.lblRowE.AutoSize = True
        Me.lblRowE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowE.Location = New System.Drawing.Point(304, 377)
        Me.lblRowE.Name = "lblRowE"
        Me.lblRowE.Size = New System.Drawing.Size(23, 24)
        Me.lblRowE.TabIndex = 18
        Me.lblRowE.Text = "E"
        '
        'lblRowF
        '
        Me.lblRowF.AutoSize = True
        Me.lblRowF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowF.Location = New System.Drawing.Point(352, 377)
        Me.lblRowF.Name = "lblRowF"
        Me.lblRowF.Size = New System.Drawing.Size(22, 24)
        Me.lblRowF.TabIndex = 19
        Me.lblRowF.Text = "F"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBarChartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(393, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintBarChartToolStripMenuItem
        '
        Me.PrintBarChartToolStripMenuItem.Name = "PrintBarChartToolStripMenuItem"
        Me.PrintBarChartToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.PrintBarChartToolStripMenuItem.Text = "&Print Bar Chart"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'frmAirplane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 480)
        Me.Controls.Add(Me.lblRowF)
        Me.Controls.Add(Me.lblRowE)
        Me.Controls.Add(Me.lblRowD)
        Me.Controls.Add(Me.lblRowC)
        Me.Controls.Add(Me.lblRowB)
        Me.Controls.Add(Me.lblRowA)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.btnPieChart)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.lstStats)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.lstSeats)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAirplane"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airplane Seating Chart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSeats As System.Windows.Forms.ListBox
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtE As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lstStats As System.Windows.Forms.ListBox
    Friend WithEvents btnStats As System.Windows.Forms.Button
    Friend WithEvents btnPieChart As System.Windows.Forms.Button
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents lblRowA As System.Windows.Forms.Label
    Friend WithEvents lblRowB As System.Windows.Forms.Label
    Friend WithEvents lblRowC As System.Windows.Forms.Label
    Friend WithEvents lblRowD As System.Windows.Forms.Label
    Friend WithEvents lblRowE As System.Windows.Forms.Label
    Friend WithEvents lblRowF As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrintBarChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
