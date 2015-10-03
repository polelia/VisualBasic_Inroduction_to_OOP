<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeatStatus
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
        Me.radEmpty = New System.Windows.Forms.RadioButton()
        Me.radDiet = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radVegeterian = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'radEmpty
        '
        Me.radEmpty.AutoSize = True
        Me.radEmpty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEmpty.Location = New System.Drawing.Point(23, 21)
        Me.radEmpty.Name = "radEmpty"
        Me.radEmpty.Size = New System.Drawing.Size(101, 19)
        Me.radEmpty.TabIndex = 0
        Me.radEmpty.TabStop = True
        Me.radEmpty.Text = "Unoccupied"
        Me.radEmpty.UseVisualStyleBackColor = True
        '
        'radDiet
        '
        Me.radDiet.AutoSize = True
        Me.radDiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiet.Location = New System.Drawing.Point(23, 65)
        Me.radDiet.Name = "radDiet"
        Me.radDiet.Size = New System.Drawing.Size(101, 19)
        Me.radDiet.TabIndex = 1
        Me.radDiet.TabStop = True
        Me.radDiet.Text = "Low Calorie"
        Me.radDiet.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegular.Location = New System.Drawing.Point(154, 21)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(76, 19)
        Me.radRegular.TabIndex = 2
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radVegeterian
        '
        Me.radVegeterian.AutoSize = True
        Me.radVegeterian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVegeterian.Location = New System.Drawing.Point(154, 65)
        Me.radVegeterian.Name = "radVegeterian"
        Me.radVegeterian.Size = New System.Drawing.Size(94, 19)
        Me.radVegeterian.TabIndex = 3
        Me.radVegeterian.TabStop = True
        Me.radVegeterian.Text = "Vegeterian"
        Me.radVegeterian.UseVisualStyleBackColor = True
        '
        'frmSeatStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 108)
        Me.Controls.Add(Me.radVegeterian)
        Me.Controls.Add(Me.radRegular)
        Me.Controls.Add(Me.radDiet)
        Me.Controls.Add(Me.radEmpty)
        Me.Name = "frmSeatStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airplane Seat Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radEmpty As System.Windows.Forms.RadioButton
    Friend WithEvents radDiet As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radVegeterian As System.Windows.Forms.RadioButton
End Class
