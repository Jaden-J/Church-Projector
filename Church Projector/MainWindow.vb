Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class MainWindow

    Public Shared bibleDisplay As New ScriptureDisplay
    Public Shared lyricsDisplay As New LyricsDisplay
    Public Shared bibRepository As New BibleRepository

    Public noBiblesExit As Boolean = False

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not noBiblesExit Then
            If MsgBox("Are you sure, you want to exit?", vbYesNo, "Exit Prompt?") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Church Projector " + Application.ProductVersion
        GlobalMemory.doInit()
    End Sub

    Sub setStatus(ByVal status As String, ByVal icon As Image)
        StatusBar.Text = status
        StatusBar.Image = icon
        StatusStrip1.Refresh()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If bibleDisplay Is Nothing Or bibleDisplay.IsDisposed Then
            bibleDisplay = New ScriptureDisplay
        End If
        bibleDisplay.MdiParent = Me
        bibleDisplay.Show()
        bibleDisplay.BringToFront()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If lyricsDisplay Is Nothing Or lyricsDisplay.IsDisposed Then
            lyricsDisplay = New LyricsDisplay
        End If
        lyricsDisplay.MdiParent = Me
        lyricsDisplay.Show()
        lyricsDisplay.BringToFront()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        System.Diagnostics.Process.Start("http://www.churchsw.org/church-projector-project")
    End Sub

    Private Sub MainWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        System.Diagnostics.Process.Start(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles")
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        If bibRepository Is Nothing Or bibRepository.IsDisposed Then
            bibRepository = New BibleRepository
        End If
        bibRepository.MdiParent = Me
        bibRepository.Show()
        bibRepository.BringToFront()
    End Sub
End Class
