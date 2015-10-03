<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvrGrd
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
    Me.btnCompute = New System.Windows.Forms.Button()
    Me.txtAverage = New System.Windows.Forms.TextBox()
    Me.lblAvg = New System.Windows.Forms.Label()
    Me.lblName = New System.Windows.Forms.Label()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.lblAdd = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnCompute
    '
    Me.btnCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCompute.Location = New System.Drawing.Point(58, 25)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(204, 57)
    Me.btnCompute.TabIndex = 0
    Me.btnCompute.Text = "Get Five Grades and Compute Average"
    Me.btnCompute.UseVisualStyleBackColor = False
    '
    'txtAverage
    '
    Me.txtAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAverage.Location = New System.Drawing.Point(173, 114)
    Me.txtAverage.Multiline = True
    Me.txtAverage.Name = "txtAverage"
    Me.txtAverage.ReadOnly = True
    Me.txtAverage.Size = New System.Drawing.Size(63, 25)
    Me.txtAverage.TabIndex = 1
    '
    'lblAvg
    '
    Me.lblAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAvg.Location = New System.Drawing.Point(55, 104)
    Me.lblAvg.Name = "lblAvg"
    Me.lblAvg.Size = New System.Drawing.Size(69, 21)
    Me.lblAvg.TabIndex = 2
    Me.lblAvg.Text = "Average: "
    Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(3, 181)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(111, 13)
    Me.lblName.TabIndex = 3
    Me.lblName.Text = "by Nadiia Semenchuk"
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(232, 168)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(75, 23)
    Me.btnQuit.TabIndex = 4
    Me.btnQuit.Text = "Exit"
    Me.btnQuit.UseVisualStyleBackColor = True
    '
    'lblAdd
    '
    Me.lblAdd.Location = New System.Drawing.Point(55, 125)
    Me.lblAdd.Name = "lblAdd"
    Me.lblAdd.Size = New System.Drawing.Size(90, 31)
    Me.lblAdd.TabIndex = 5
    Me.lblAdd.Text = "(after dropping the lowest grade)"
    '
    'frmAvrGrd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(319, 203)
    Me.Controls.Add(Me.lblAdd)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.lblAvg)
    Me.Controls.Add(Me.txtAverage)
    Me.Controls.Add(Me.btnCompute)
    Me.Name = "frmAvrGrd"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Average Grade"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCompute As System.Windows.Forms.Button
  Friend WithEvents txtAverage As System.Windows.Forms.TextBox
  Friend WithEvents lblAvg As System.Windows.Forms.Label
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents btnQuit As System.Windows.Forms.Button
  Friend WithEvents lblAdd As System.Windows.Forms.Label

End Class
