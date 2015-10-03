<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepairBill
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
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.txtHoursWorked = New System.Windows.Forms.TextBox()
    Me.txtPartsCost = New System.Windows.Forms.TextBox()
    Me.lstBill = New System.Windows.Forms.ListBox()
    Me.btnComputeBill = New System.Windows.Forms.Button()
    Me.lblCustomer = New System.Windows.Forms.Label()
    Me.lblHours = New System.Windows.Forms.Label()
    Me.lblParts = New System.Windows.Forms.Label()
    Me.lblProgrammer = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(135, 12)
    Me.txtName.Multiline = True
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(178, 20)
    Me.txtName.TabIndex = 0
    '
    'txtHoursWorked
    '
    Me.txtHoursWorked.Location = New System.Drawing.Point(135, 38)
    Me.txtHoursWorked.Multiline = True
    Me.txtHoursWorked.Name = "txtHoursWorked"
    Me.txtHoursWorked.Size = New System.Drawing.Size(74, 20)
    Me.txtHoursWorked.TabIndex = 1
    '
    'txtPartsCost
    '
    Me.txtPartsCost.Location = New System.Drawing.Point(135, 64)
    Me.txtPartsCost.Multiline = True
    Me.txtPartsCost.Name = "txtPartsCost"
    Me.txtPartsCost.Size = New System.Drawing.Size(74, 20)
    Me.txtPartsCost.TabIndex = 2
    '
    'lstBill
    '
    Me.lstBill.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstBill.FormattingEnabled = True
    Me.lstBill.ItemHeight = 16
    Me.lstBill.Location = New System.Drawing.Point(23, 153)
    Me.lstBill.Name = "lstBill"
    Me.lstBill.Size = New System.Drawing.Size(290, 84)
    Me.lstBill.TabIndex = 4
    '
    'btnComputeBill
    '
    Me.btnComputeBill.BackColor = System.Drawing.SystemColors.ActiveBorder
    Me.btnComputeBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnComputeBill.Location = New System.Drawing.Point(135, 103)
    Me.btnComputeBill.Name = "btnComputeBill"
    Me.btnComputeBill.Size = New System.Drawing.Size(114, 35)
    Me.btnComputeBill.TabIndex = 3
    Me.btnComputeBill.Text = "Display Bill"
    Me.btnComputeBill.UseVisualStyleBackColor = False
    '
    'lblCustomer
    '
    Me.lblCustomer.AutoSize = True
    Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCustomer.Location = New System.Drawing.Point(53, 13)
    Me.lblCustomer.Name = "lblCustomer"
    Me.lblCustomer.Size = New System.Drawing.Size(76, 15)
    Me.lblCustomer.TabIndex = 7
    Me.lblCustomer.Text = "Customer: "
    '
    'lblHours
    '
    Me.lblHours.AutoSize = True
    Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHours.Location = New System.Drawing.Point(23, 38)
    Me.lblHours.Name = "lblHours"
    Me.lblHours.Size = New System.Drawing.Size(106, 15)
    Me.lblHours.TabIndex = 6
    Me.lblHours.Text = "Hours of labor: "
    '
    'lblParts
    '
    Me.lblParts.AutoSize = True
    Me.lblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblParts.Location = New System.Drawing.Point(10, 65)
    Me.lblParts.Name = "lblParts"
    Me.lblParts.Size = New System.Drawing.Size(123, 15)
    Me.lblParts.TabIndex = 5
    Me.lblParts.Text = "Cost of materials: "
    '
    'lblProgrammer
    '
    Me.lblProgrammer.AutoSize = True
    Me.lblProgrammer.Location = New System.Drawing.Point(0, 248)
    Me.lblProgrammer.Name = "lblProgrammer"
    Me.lblProgrammer.Size = New System.Drawing.Size(111, 13)
    Me.lblProgrammer.TabIndex = 8
    Me.lblProgrammer.Text = "by Nadiia Semenchuk"
    '
    'frmRepairBill
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(337, 265)
    Me.Controls.Add(Me.lblProgrammer)
    Me.Controls.Add(Me.lblParts)
    Me.Controls.Add(Me.lblHours)
    Me.Controls.Add(Me.lblCustomer)
    Me.Controls.Add(Me.btnComputeBill)
    Me.Controls.Add(Me.lstBill)
    Me.Controls.Add(Me.txtPartsCost)
    Me.Controls.Add(Me.txtHoursWorked)
    Me.Controls.Add(Me.txtName)
    Me.Name = "frmRepairBill"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Auto Repair Bill"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
  Friend WithEvents txtPartsCost As System.Windows.Forms.TextBox
  Friend WithEvents lstBill As System.Windows.Forms.ListBox
  Friend WithEvents btnComputeBill As System.Windows.Forms.Button
  Friend WithEvents lblCustomer As System.Windows.Forms.Label
  Friend WithEvents lblHours As System.Windows.Forms.Label
  Friend WithEvents lblParts As System.Windows.Forms.Label
  Friend WithEvents lblProgrammer As System.Windows.Forms.Label

End Class
