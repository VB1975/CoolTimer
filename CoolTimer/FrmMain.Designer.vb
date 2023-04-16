<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MspTimer = New System.Windows.Forms.MenuStrip()
        Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileStyle = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileStyleTimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileStyleStopwatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileStyleCountdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlDisplay = New System.Windows.Forms.Panel()
        Me.LblDisplay = New System.Windows.Forms.Label()
        Me.TimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.MspTimer.SuspendLayout()
        Me.PnlDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'MspTimer
        '
        Me.MspTimer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile})
        Me.MspTimer.Location = New System.Drawing.Point(0, 0)
        Me.MspTimer.Name = "MspTimer"
        Me.MspTimer.Size = New System.Drawing.Size(368, 24)
        Me.MspTimer.TabIndex = 0
        Me.MspTimer.Text = "MenuStrip1"
        '
        'MnuFile
        '
        Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFileStyle, Me.MnuFileOptions, Me.MnuFileExit})
        Me.MnuFile.Name = "MnuFile"
        Me.MnuFile.Size = New System.Drawing.Size(37, 20)
        Me.MnuFile.Text = "&File"
        '
        'MnuFileStyle
        '
        Me.MnuFileStyle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFileStyleTimer, Me.MnuFileStyleStopwatch, Me.MnuFileStyleCountdown})
        Me.MnuFileStyle.Name = "MnuFileStyle"
        Me.MnuFileStyle.Size = New System.Drawing.Size(116, 22)
        Me.MnuFileStyle.Text = "&Style"
        '
        'MnuFileStyleTimer
        '
        Me.MnuFileStyleTimer.Checked = True
        Me.MnuFileStyleTimer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MnuFileStyleTimer.Name = "MnuFileStyleTimer"
        Me.MnuFileStyleTimer.Size = New System.Drawing.Size(137, 22)
        Me.MnuFileStyleTimer.Text = "&Timer"
        '
        'MnuFileStyleStopwatch
        '
        Me.MnuFileStyleStopwatch.Name = "MnuFileStyleStopwatch"
        Me.MnuFileStyleStopwatch.Size = New System.Drawing.Size(137, 22)
        Me.MnuFileStyleStopwatch.Text = "&Stopwatch"
        '
        'MnuFileStyleCountdown
        '
        Me.MnuFileStyleCountdown.Name = "MnuFileStyleCountdown"
        Me.MnuFileStyleCountdown.Size = New System.Drawing.Size(137, 22)
        Me.MnuFileStyleCountdown.Text = "&Countdown"
        '
        'MnuFileOptions
        '
        Me.MnuFileOptions.Name = "MnuFileOptions"
        Me.MnuFileOptions.Size = New System.Drawing.Size(116, 22)
        Me.MnuFileOptions.Text = "&Options"
        '
        'MnuFileExit
        '
        Me.MnuFileExit.Name = "MnuFileExit"
        Me.MnuFileExit.Size = New System.Drawing.Size(116, 22)
        Me.MnuFileExit.Text = "E&xit"
        '
        'PnlDisplay
        '
        Me.PnlDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDisplay.Controls.Add(Me.LblDisplay)
        Me.PnlDisplay.Location = New System.Drawing.Point(0, 27)
        Me.PnlDisplay.Name = "PnlDisplay"
        Me.PnlDisplay.Size = New System.Drawing.Size(368, 76)
        Me.PnlDisplay.TabIndex = 1
        '
        'LblDisplay
        '
        Me.LblDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.Location = New System.Drawing.Point(0, 0)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(364, 72)
        Me.LblDisplay.TabIndex = 0
        Me.LblDisplay.Text = "00:00:00"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimTimer
        '
        Me.TimTimer.Interval = 1000
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.Green
        Me.BtnStart.Location = New System.Drawing.Point(44, 130)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(280, 72)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStop.Location = New System.Drawing.Point(44, 208)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(280, 72)
        Me.BtnStop.TabIndex = 3
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Blue
        Me.BtnReset.Location = New System.Drawing.Point(44, 286)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(280, 72)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 601)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PnlDisplay)
        Me.Controls.Add(Me.MspTimer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MspTimer
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(384, 640)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cool Timer"
        Me.MspTimer.ResumeLayout(False)
        Me.MspTimer.PerformLayout()
        Me.PnlDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MspTimer As MenuStrip
    Friend WithEvents MnuFile As ToolStripMenuItem
    Friend WithEvents MnuFileStyle As ToolStripMenuItem
    Friend WithEvents MnuFileStyleTimer As ToolStripMenuItem
    Friend WithEvents MnuFileStyleStopwatch As ToolStripMenuItem
    Friend WithEvents MnuFileOptions As ToolStripMenuItem
    Friend WithEvents MnuFileExit As ToolStripMenuItem
    Friend WithEvents PnlDisplay As Panel
    Friend WithEvents LblDisplay As Label
    Friend WithEvents TimTimer As Timer
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents MnuFileStyleCountdown As ToolStripMenuItem
End Class
