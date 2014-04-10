<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectorDisplay
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
        Me.WebBrowserProjector = New System.Windows.Forms.WebBrowser()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'WebBrowserProjector
        '
        Me.WebBrowserProjector.AllowWebBrowserDrop = False
        Me.WebBrowserProjector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserProjector.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserProjector.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserProjector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WebBrowserProjector.Name = "WebBrowserProjector"
        Me.WebBrowserProjector.ScriptErrorsSuppressed = True
        Me.WebBrowserProjector.ScrollBarsEnabled = False
        Me.WebBrowserProjector.Size = New System.Drawing.Size(389, 336)
        Me.WebBrowserProjector.TabIndex = 0
        Me.WebBrowserProjector.WebBrowserShortcutsEnabled = False
        '
        'Timer2
        '
        '
        'ProjectorDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.WebBrowserProjector)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProjectorDisplay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowserProjector As WebBrowser
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
