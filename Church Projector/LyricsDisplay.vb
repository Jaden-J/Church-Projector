Imports System.Xml

Public Class LyricsDisplay

    Dim modifiedHtml As String
    Dim OriginalHtml As String
    Dim m_paragraph As ArrayList
    Dim selected_paragraph As String = ""

    Dim close_on_timer As Boolean = False
    Dim dimention_ratio As Double
    Public scale_ratio As Integer

    Dim background As String = "#000000"
    Dim foreground As String = "#FFFFFF"
    Dim fontsize As String = "45"
    Dim backimage As String = ""
    Dim paragraphs()
    Dim dashboard As Dashboard = Nothing

    Private Sub LyricsDisplay_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not dashboard Is Nothing Then
            dashboard.updateButton()
        End If
    End Sub

    Private Sub ScriptureDisplay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Timer1.Start()
    End Sub

    Private Sub loadInit()
        dashboard.loadInit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If (close_on_timer) Then
            Me.Dispose()
            Return
        End If

        dashboard = New Dashboard(Me)
        Me.Controls.Add(dashboard)
        Dim tmp_i As Integer = GroupBox1.Location.X + GroupBox1.Width
        dashboard.Location = New Point(tmp_i + 10, 10)

        Me.Enabled = False
        MainWindow.setStatus("Working...", My.Resources.status_loading)
        loadInit()
        MainWindow.setStatus("Ready", My.Resources.status_ok)
        Me.Enabled = True
        dashboard.doPreview()
        Me.BringToFront()
    End Sub

    'must be called from dashboard
    Public Function smartyTags(ByVal modifiedHtml As String)
        modifiedHtml = modifiedHtml.Replace("_PARAGRAPH_", selected_paragraph)
        Return modifiedHtml
    End Function

    'must be called from dashboard
    Public Sub PreProcess()
        'does nothing here... but must exist
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a = OpenFileDialog2.ShowDialog()
        If a = Windows.Forms.DialogResult.OK Then
            Dim filename = OpenFileDialog2.FileName
            TextBox2.Text = OpenFileDialog2.FileName

            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(filename)
            Dim linein As String
            m_paragraph = New ArrayList
            Dim mpara As String = ""
            While oRead.Peek <> -1
                linein = oRead.ReadLine()
                If (linein.Trim.Equals("")) Then
                    m_paragraph.Add(mpara.Trim)
                    mpara = ""
                Else
                    mpara = mpara + vbCrLf + linein.Trim
                End If
            End While

            If (Not mpara.Trim.Equals("")) Then
                m_paragraph.Add(mpara.Trim)
            End If

            oRead.Close()
            For Each para As String In m_paragraph
                Dim radioPara As RadioButton = New RadioButton
                radioPara.Text = para
                radioPara.Appearance = Appearance.Button
                radioPara.FlatStyle = FlatStyle.Flat
                radioPara.FlatAppearance.BorderSize = 0
                radioPara.Width = LyricFlowPanel.Width - 30
                radioPara.Height = radioPara.Height * 2
                LyricFlowPanel.Controls.Add(radioPara)
                AddHandler radioPara.Click, AddressOf ParagraphSelected
            Next
        End If
    End Sub

    Private Sub ParagraphSelected(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim radio As RadioButton = DirectCast(sender, RadioButton)
        selected_paragraph = radio.Text.Replace(vbCrLf, "<br>")
        dashboard.doPreview()
        If CheckBox2.Checked Then
            dashboard.sendOrUpdateProjector()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim a = OpenFileDialog2.ShowDialog()
        If a = Windows.Forms.DialogResult.OK Then
            Dim filename = OpenFileDialog2.FileName
            TextBox2.Text = OpenFileDialog2.FileName

            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(filename)
            Dim linein As String
            m_paragraph = New ArrayList
            Dim mpara As String = ""
            While oRead.Peek <> -1
                linein = oRead.ReadLine()
                If (linein.Trim.Equals("")) Then
                    m_paragraph.Add(mpara.Trim)
                    mpara = ""
                Else
                    mpara = mpara + vbCrLf + linein.Trim
                End If
            End While

            If (Not mpara.Trim.Equals("")) Then
                m_paragraph.Add(mpara.Trim)
            End If

            oRead.Close()

            LyricFlowPanel.Controls.Clear()

            For Each para As String In m_paragraph
                Dim radioPara As RadioButton = New RadioButton
                radioPara.Text = para
                radioPara.Appearance = Appearance.Button
                radioPara.FlatStyle = FlatStyle.Flat
                radioPara.FlatAppearance.BorderSize = 0
                radioPara.Width = LyricFlowPanel.Width - 30
                radioPara.Height = radioPara.Height * 2
                LyricFlowPanel.Controls.Add(radioPara)
                AddHandler radioPara.Click, AddressOf ParagraphSelected
            Next
        End If
    End Sub
End Class