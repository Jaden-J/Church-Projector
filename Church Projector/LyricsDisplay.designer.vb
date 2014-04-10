<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LyricsDisplay
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.LyricFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All files|*.*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Select Lyric"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 22)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(217, 22)
        Me.TextBox2.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Image = Global.Church_Projector.My.Resources.Resources.icon_add
        Me.Button1.Location = New System.Drawing.Point(373, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 28)
        Me.Button1.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.Button1, "Open a new lyrics or text and append to existing")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "All files|*.*"
        '
        'Button9
        '
        Me.Button9.Image = Global.Church_Projector.My.Resources.Resources.open
        Me.Button9.Location = New System.Drawing.Point(333, 18)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 28)
        Me.Button9.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.Button9, "Open a new lyrics to replace existing")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'LyricFlowPanel
        '
        Me.LyricFlowPanel.AutoScroll = True
        Me.LyricFlowPanel.AutoSize = True
        Me.LyricFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LyricFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LyricFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.LyricFlowPanel.Location = New System.Drawing.Point(4, 19)
        Me.LyricFlowPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LyricFlowPanel.Name = "LyricFlowPanel"
        Me.LyricFlowPanel.Size = New System.Drawing.Size(381, 541)
        Me.LyricFlowPanel.TabIndex = 0
        Me.LyricFlowPanel.WrapContents = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.LyricFlowPanel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(389, 564)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select lyrics paragraph to display"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(240, 0)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(109, 21)
        Me.CheckBox2.TabIndex = 49
        Me.CheckBox2.Text = "Auto Update"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'LyricsDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1061, 728)
        Me.Name = "LyricsDisplay"
        Me.Text = "Lyrics Projector Display"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents LyricFlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
