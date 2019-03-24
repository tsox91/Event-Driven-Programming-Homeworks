<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMetrics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMetrics))
        Me.Website = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.lblAverageTime = New System.Windows.Forms.Label()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.lstSeconds = New System.Windows.Forms.ListBox()
        CType(Me.Website, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Website
        '
        Me.Website.Image = CType(resources.GetObject("Website.Image"), System.Drawing.Image)
        Me.Website.Location = New System.Drawing.Point(48, 331)
        Me.Website.Name = "Website"
        Me.Website.Size = New System.Drawing.Size(428, 234)
        Me.Website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Website.TabIndex = 0
        Me.Website.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(68, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(369, 34)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Website Traffic Estimate "
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(454, 574)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 2
        '
        'lblAverageTime
        '
        Me.lblAverageTime.AutoSize = True
        Me.lblAverageTime.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTime.Location = New System.Drawing.Point(69, 288)
        Me.lblAverageTime.Name = "lblAverageTime"
        Me.lblAverageTime.Size = New System.Drawing.Size(389, 25)
        Me.lblAverageTime.TabIndex = 3
        Me.lblAverageTime.Text = "Average Time Spent: XX.XX Seconds"
        Me.lblAverageTime.Visible = False
        '
        'btnAnalytics
        '
        Me.btnAnalytics.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAnalytics.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalytics.ForeColor = System.Drawing.Color.GreenYellow
        Me.btnAnalytics.Location = New System.Drawing.Point(109, 80)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(229, 59)
        Me.btnAnalytics.TabIndex = 4
        Me.btnAnalytics.Text = "Enter Visitor Analytics"
        Me.btnAnalytics.UseVisualStyleBackColor = False
        '
        'lstSeconds
        '
        Me.lstSeconds.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeconds.FormattingEnabled = True
        Me.lstSeconds.ItemHeight = 18
        Me.lstSeconds.Location = New System.Drawing.Point(368, 80)
        Me.lstSeconds.Name = "lstSeconds"
        Me.lstSeconds.Size = New System.Drawing.Size(90, 184)
        Me.lstSeconds.TabIndex = 5
        '
        'FrmMetrics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(509, 577)
        Me.Controls.Add(Me.lstSeconds)
        Me.Controls.Add(Me.btnAnalytics)
        Me.Controls.Add(Me.lblAverageTime)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Website)
        Me.Name = "FrmMetrics"
        Me.Text = "Website Traffic Metrics"
        CType(Me.Website, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Website As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents lblAverageTime As Label
    Friend WithEvents btnAnalytics As Button
    Friend WithEvents lstSeconds As ListBox
End Class
