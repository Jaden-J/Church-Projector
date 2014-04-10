<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.WebBrowserPreview = New System.Windows.Forms.WebBrowser()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProjectorHtmlEditor = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PreviewBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AdvancedEdit = New System.Windows.Forms.CheckBox()
        Me.DisplayToBtn = New System.Windows.Forms.CheckBox()
        Me.DisplayDeviceComboBox = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.InitZoomTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowserPreview
        '
        Me.WebBrowserPreview.AllowWebBrowserDrop = False
        Me.WebBrowserPreview.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserPreview.Location = New System.Drawing.Point(10, 8)
        Me.WebBrowserPreview.Name = "WebBrowserPreview"
        Me.WebBrowserPreview.ScriptErrorsSuppressed = True
        Me.WebBrowserPreview.ScrollBarsEnabled = False
        Me.WebBrowserPreview.Size = New System.Drawing.Size(212, 164)
        Me.WebBrowserPreview.TabIndex = 72
        Me.WebBrowserPreview.WebBrowserShortcutsEnabled = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(266, 296)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 23)
        Me.Button7.TabIndex = 71
        Me.Button7.Text = "Update Projector"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Blank"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProjectorHtmlEditor
        '
        Me.ProjectorHtmlEditor.Location = New System.Drawing.Point(13, 384)
        Me.ProjectorHtmlEditor.Multiline = True
        Me.ProjectorHtmlEditor.Name = "ProjectorHtmlEditor"
        Me.ProjectorHtmlEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProjectorHtmlEditor.Size = New System.Drawing.Size(455, 126)
        Me.ProjectorHtmlEditor.TabIndex = 55
        Me.ProjectorHtmlEditor.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 394)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(451, 91)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = resources.GetString("Label20.Text")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 259)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 68
        Me.CheckBox1.Text = "Use Background Image"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(443, 257)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = ".."
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(155, 257)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 20)
        Me.TextBox1.TabIndex = 66
        Me.TextBox1.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(299, 221)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Font Size"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(347, 212)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 25
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(121, 45)
        Me.TrackBar1.TabIndex = 64
        Me.TrackBar1.Value = 45
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(176, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 63
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(107, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Foreground"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(78, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(23, 23)
        Me.Button4.TabIndex = 61
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 220)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Background"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(78, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Defaults"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PreviewBtn
        '
        Me.PreviewBtn.Location = New System.Drawing.Point(156, 296)
        Me.PreviewBtn.Name = "PreviewBtn"
        Me.PreviewBtn.Size = New System.Drawing.Size(54, 23)
        Me.PreviewBtn.TabIndex = 58
        Me.PreviewBtn.Text = "Preview"
        Me.PreviewBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(370, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Send to Projector"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdvancedEdit
        '
        Me.AdvancedEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.AdvancedEdit.AutoSize = True
        Me.AdvancedEdit.Location = New System.Drawing.Point(11, 296)
        Me.AdvancedEdit.Name = "AdvancedEdit"
        Me.AdvancedEdit.Size = New System.Drawing.Size(66, 23)
        Me.AdvancedEdit.TabIndex = 56
        Me.AdvancedEdit.Text = "Advanced"
        Me.AdvancedEdit.UseVisualStyleBackColor = True
        '
        'DisplayToBtn
        '
        Me.DisplayToBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.DisplayToBtn.Enabled = False
        Me.DisplayToBtn.FlatAppearance.BorderSize = 0
        Me.DisplayToBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DisplayToBtn.Location = New System.Drawing.Point(10, 185)
        Me.DisplayToBtn.Name = "DisplayToBtn"
        Me.DisplayToBtn.Size = New System.Drawing.Size(67, 21)
        Me.DisplayToBtn.TabIndex = 54
        Me.DisplayToBtn.Text = "Display To"
        Me.DisplayToBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DisplayToBtn.UseVisualStyleBackColor = True
        '
        'DisplayDeviceComboBox
        '
        Me.DisplayDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayDeviceComboBox.FormattingEnabled = True
        Me.DisplayDeviceComboBox.Location = New System.Drawing.Point(83, 185)
        Me.DisplayDeviceComboBox.Name = "DisplayDeviceComboBox"
        Me.DisplayDeviceComboBox.Size = New System.Drawing.Size(385, 21)
        Me.DisplayDeviceComboBox.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Select Template:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 340)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(327, 21)
        Me.ComboBox1.TabIndex = 74
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(443, 340)
        Me.Browse.Margin = New System.Windows.Forms.Padding(2)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(25, 20)
        Me.Browse.TabIndex = 75
        Me.Browse.Text = ".."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'InitZoomTimer
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowserPreview)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProjectorHtmlEditor)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PreviewBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AdvancedEdit)
        Me.Controls.Add(Me.DisplayToBtn)
        Me.Controls.Add(Me.DisplayDeviceComboBox)
        Me.Name = "Dashboard"
        Me.Size = New System.Drawing.Size(480, 526)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowserPreview As WebBrowser
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProjectorHtmlEditor As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PreviewBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AdvancedEdit As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayToBtn As System.Windows.Forms.CheckBox
    Friend WithEvents DisplayDeviceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents InitZoomTimer As System.Windows.Forms.Timer

End Class
