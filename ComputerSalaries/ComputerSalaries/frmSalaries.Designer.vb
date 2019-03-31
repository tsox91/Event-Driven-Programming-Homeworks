<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalaries))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblYearlyIncrease = New System.Windows.Forms.Label()
        Me.lblHourlyIncrease = New System.Windows.Forms.Label()
        Me.lblYearlyPay = New System.Windows.Forms.Label()
        Me.lblHourlyPay = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindPay = New System.Windows.Forms.Button()
        Me.cboOccupation = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 276)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblYearlyIncrease)
        Me.Panel1.Controls.Add(Me.lblHourlyIncrease)
        Me.Panel1.Controls.Add(Me.lblYearlyPay)
        Me.Panel1.Controls.Add(Me.lblHourlyPay)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindPay)
        Me.Panel1.Controls.Add(Me.cboOccupation)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(291, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 530)
        Me.Panel1.TabIndex = 2
        '
        'lblYearlyIncrease
        '
        Me.lblYearlyIncrease.AutoSize = True
        Me.lblYearlyIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyIncrease.Location = New System.Drawing.Point(85, 441)
        Me.lblYearlyIncrease.Name = "lblYearlyIncrease"
        Me.lblYearlyIncrease.Size = New System.Drawing.Size(178, 24)
        Me.lblYearlyIncrease.TabIndex = 7
        Me.lblYearlyIncrease.Text = "XXXXXXXXXXXX"
        Me.lblYearlyIncrease.Visible = False
        '
        'lblHourlyIncrease
        '
        Me.lblHourlyIncrease.AutoSize = True
        Me.lblHourlyIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyIncrease.Location = New System.Drawing.Point(85, 398)
        Me.lblHourlyIncrease.Name = "lblHourlyIncrease"
        Me.lblHourlyIncrease.Size = New System.Drawing.Size(178, 24)
        Me.lblHourlyIncrease.TabIndex = 6
        Me.lblHourlyIncrease.Text = "XXXXXXXXXXXX"
        Me.lblHourlyIncrease.Visible = False
        '
        'lblYearlyPay
        '
        Me.lblYearlyPay.AutoSize = True
        Me.lblYearlyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyPay.Location = New System.Drawing.Point(85, 354)
        Me.lblYearlyPay.Name = "lblYearlyPay"
        Me.lblYearlyPay.Size = New System.Drawing.Size(178, 24)
        Me.lblYearlyPay.TabIndex = 5
        Me.lblYearlyPay.Text = "XXXXXXXXXXXX"
        Me.lblYearlyPay.Visible = False
        '
        'lblHourlyPay
        '
        Me.lblHourlyPay.AutoSize = True
        Me.lblHourlyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyPay.Location = New System.Drawing.Point(85, 314)
        Me.lblHourlyPay.Name = "lblHourlyPay"
        Me.lblHourlyPay.Size = New System.Drawing.Size(178, 24)
        Me.lblHourlyPay.TabIndex = 4
        Me.lblHourlyPay.Text = "XXXXXXXXXXXX"
        Me.lblHourlyPay.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Location = New System.Drawing.Point(237, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnFindPay
        '
        Me.btnFindPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPay.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnFindPay.Location = New System.Drawing.Point(61, 233)
        Me.btnFindPay.Name = "btnFindPay"
        Me.btnFindPay.Size = New System.Drawing.Size(137, 38)
        Me.btnFindPay.TabIndex = 2
        Me.btnFindPay.Text = "Calculate Pay"
        Me.btnFindPay.UseVisualStyleBackColor = True
        Me.btnFindPay.Visible = False
        '
        'cboOccupation
        '
        Me.cboOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOccupation.FormattingEnabled = True
        Me.cboOccupation.Items.AddRange(New Object() {"Computer Developer", "Computer System Analyst", "Computer and Information Systems Manager", "Computer Software Engineer"})
        Me.cboOccupation.Location = New System.Drawing.Point(31, 85)
        Me.cboOccupation.Name = "cboOccupation"
        Me.cboOccupation.Size = New System.Drawing.Size(374, 32)
        Me.cboOccupation.TabIndex = 1
        Me.cboOccupation.Text = "Select Occupation:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(430, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Salaries For Computer Occupations"
        '
        'frmSalaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSalaries"
        Me.Text = "Computer Salaries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFindPay As Button
    Friend WithEvents cboOccupation As ComboBox
    Friend WithEvents lblHourlyIncrease As Label
    Friend WithEvents lblYearlyPay As Label
    Friend WithEvents lblHourlyPay As Label
    Friend WithEvents lblYearlyIncrease As Label
End Class
