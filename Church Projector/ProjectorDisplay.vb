Public Class ProjectorDisplay

    Dim html As String = "<html><body bgcolor='black'/><font color='white'>[projector_cs7]</font></html>"

    Sub setHtmlContent(ByVal _html As String)
        html = _html
        Me.Show()
        GlobalMemory.Navigate(Me.WebBrowserProjector, html)
        Timer2.Enabled = True
    End Sub

    Private Sub ProjectorDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Show()
        GlobalMemory.Navigate(Me.WebBrowserProjector, html)        
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        MainWindow.Focus()
    End Sub

End Class