<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSciFiBooks
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
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.pbxPicture = New System.Windows.Forms.PictureBox()
        Me.lstOptions = New System.Windows.Forms.ListBox()
        Me.lbDisplay = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooks
        '
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(12, 220)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.Size = New System.Drawing.Size(475, 172)
        Me.dgvBooks.TabIndex = 4
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(25, 110)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(134, 32)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Selected"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'pbxPicture
        '
        Me.pbxPicture.ErrorImage = Nothing
        Me.pbxPicture.Image = Global._8._3._26NadiiaSemenchuk.My.Resources.Resources.darth_vader_reading_harry_potter1
        Me.pbxPicture.InitialImage = Nothing
        Me.pbxPicture.Location = New System.Drawing.Point(192, 2)
        Me.pbxPicture.Name = "pbxPicture"
        Me.pbxPicture.Size = New System.Drawing.Size(295, 202)
        Me.pbxPicture.TabIndex = 4
        Me.pbxPicture.TabStop = False
        '
        'lstOptions
        '
        Me.lstOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.ItemHeight = 15
        Me.lstOptions.Items.AddRange(New Object() {"highest upvotes", "lowest downvotes", "titles descending", "authors ascending"})
        Me.lstOptions.Location = New System.Drawing.Point(25, 27)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(134, 64)
        Me.lstOptions.TabIndex = 0
        '
        'lbDisplay
        '
        Me.lbDisplay.AutoSize = True
        Me.lbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisplay.Location = New System.Drawing.Point(0, 2)
        Me.lbDisplay.Name = "lbDisplay"
        Me.lbDisplay.Size = New System.Drawing.Size(80, 15)
        Me.lbDisplay.TabIndex = 5
        Me.lbDisplay.Text = "Display by: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(388, 395)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "by Nadiia Semenchuk"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(25, 148)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(134, 32)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert to CSV"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(25, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSciFiBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 408)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbDisplay)
        Me.Controls.Add(Me.lstOptions)
        Me.Controls.Add(Me.pbxPicture)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.dgvBooks)
        Me.Name = "frmSciFiBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Top 25 Sci-Fi Books"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents pbxPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lstOptions As System.Windows.Forms.ListBox
    Friend WithEvents lbDisplay As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
