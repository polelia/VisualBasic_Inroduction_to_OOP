<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPie
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
        Me.picPie = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.picPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPie
        '
        Me.picPie.Location = New System.Drawing.Point(15, 12)
        Me.picPie.Name = "picPie"
        Me.picPie.Size = New System.Drawing.Size(331, 206)
        Me.picPie.TabIndex = 0
        Me.picPie.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(90, 224)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(151, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Chart"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmPie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 255)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picPie)
        Me.Name = "frmPie"
        Me.Text = "Seats Statistics"
        CType(Me.picPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPie As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
