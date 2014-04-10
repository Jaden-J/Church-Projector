Imports System.Xml
Imports System.IO

Public Class ScriptureDisplay

    Dim close_on_timer As Boolean = False
    'Dim modifiedHtml As String

    Dim verseText1 As String
    Dim verseText2 As String
    Dim verseText3 As String
    Dim verseText4 As String

    Dim chapterCount As New Hashtable
    Dim chapterCount2 As New Hashtable
    Dim chapterCount3 As New Hashtable
    Dim chapterCount4 As New Hashtable

    Dim errorProvider As New ErrorProvider

    Dim dashboard As Dashboard = Nothing

    Private Sub ScriptureDisplay_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not dashboard Is Nothing Then
            dashboard.updateButton()
        End If
    End Sub

    Private Sub ScriptureDisplay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized

        ToolTip1.SetToolTip(CheckBox2, "Enable this button to send quick reference directly to projector. " + vbCrLf + _
                                        "By default, this will be clicked.")
        ToolTip1.SetToolTip(ComboBox1, "As you type, you get the available selections. Use arrow to quickly " + vbCrLf + _
                                        "select the book and type the chapter and verse seperated by space " + vbCrLf + _
                                        "and press enter. This will directly display the verse into projector." + vbCrLf + _
                                         "e.g., Exodus 3 4")
        Timer1.Enabled = True
    End Sub

    Private Sub loadInit()
        'Populate Bibles in popup...
        Bible1.Items.AddRange(GlobalMemory.getAvailableBibles.ToArray)
        Bible1.SelectedIndex = 0
        Bible2.Items.AddRange(GlobalMemory.getAvailableBibles.ToArray)
        Bible2.SelectedIndex = 0
        Bible3.Items.AddRange(GlobalMemory.getAvailableBibles.ToArray)
        Bible3.SelectedIndex = 0
        Bible4.Items.AddRange(GlobalMemory.getAvailableBibles.ToArray)
        Bible4.SelectedIndex = 0

        '
        Dim xmldoc As New Xml.XmlDocument
        If Bible1.Text = "King James Version (1769)" Then
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + Bible1.Text)
        End If

        Dim xmlnodes = xmldoc.SelectNodes("/XMLBIBLE/BIBLEBOOK")

        Dim bibleBooks(65) As String
        chapterCount = New Hashtable
        Dim i As Integer = 0
        For Each xmlnode As Xml.XmlNode In xmlnodes
            bibleBooks(i) = xmlnode.Attributes.GetNamedItem("bname").Value
            i = i + 1
            chapterCount.Add(xmlnode.Attributes.GetNamedItem("bname").Value.ToLower, xmlnode.SelectNodes("CHAPTER").Count)
        Next
        BibleBooksComboBox.Items.Clear()
        BibleBooksComboBox.Items.AddRange(bibleBooks)
        BibleBooksComboBox.SelectedIndex = 0
        dashboard.loadInit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Cursor = Cursors.WaitCursor
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
        '
        Dim i As Integer = 0
        For Each oo As Object In BibleBooksComboBox.Items
            If Not oo Is Nothing Then
                ComboBox1.Items.Add(oo)
            End If
        Next
        '
        MainWindow.setStatus("Ready", My.Resources.status_ok)
        Me.Enabled = True
        dashboard.doPreview()
        Me.Cursor = Cursors.Default
        Me.BringToFront()
    End Sub

    Private Sub BibleBooksComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BibleBooksComboBox.SelectedIndexChanged
        Dim count As Integer = chapterCount.Item(BibleBooksComboBox.Text.ToLower)
        ChapterComboBox.Items.Clear()
        For i As Integer = 1 To count
            ChapterComboBox.Items.Add(Str(i))
        Next
        ChapterComboBox.SelectedIndex = 0

        If Sync2.Checked And SecondVerseCheckBox.Checked Then
            Book2.SelectedIndex = BibleBooksComboBox.SelectedIndex
            Chapter2.SelectedIndex = 0
        End If
        If Sync3.Checked And ThirdVerseCheckBox.Checked Then
            Book3.SelectedIndex = BibleBooksComboBox.SelectedIndex
            Chapter3.SelectedIndex = 0
        End If
        If Sync4.Checked And FourthVerseCheckBox.Checked Then
            Book4.SelectedIndex = BibleBooksComboBox.SelectedIndex
            Chapter4.SelectedIndex = 0
        End If
    End Sub

    Private Sub Bible1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bible1.SelectedIndexChanged
        Dim xmldoc As New Xml.XmlDocument
        If Bible1.Text = "King James Version (1769)" Then            
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + Bible1.Text)
        End If
        Dim xmlnodes As Xml.XmlNodeList = xmldoc.SelectNodes("/XMLBIBLE/BIBLEBOOK")

        Dim bibleBooks(xmlnodes.Count - 1) As String
        chapterCount = New Hashtable
        Dim i As Integer = 0
        For Each xmlnode As Xml.XmlNode In xmlnodes
            bibleBooks(i) = xmlnode.Attributes.GetNamedItem("bname").Value
            i = i + 1
            chapterCount.Add(xmlnode.Attributes.GetNamedItem("bname").Value.ToLower, xmlnode.SelectNodes("CHAPTER").Count)
        Next
        BibleBooksComboBox.Items.Clear()
        BibleBooksComboBox.Items.AddRange(bibleBooks)
        BibleBooksComboBox.SelectedIndex = 0
    End Sub

    Private Sub Bible2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bible2.SelectedIndexChanged
        Dim xmldoc As New Xml.XmlDocument
        If Bible2.Text = "King James Version (1769)" Then
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + Bible2.Text)
        End If
        Dim xmlnodes As Xml.XmlNodeList = xmldoc.SelectNodes("/XMLBIBLE/BIBLEBOOK")

        Dim bibleBooks(xmlnodes.Count - 1) As String
        chapterCount2 = New Hashtable
        Dim i As Integer = 0
        For Each xmlnode As Xml.XmlNode In xmlnodes
            bibleBooks(i) = xmlnode.Attributes.GetNamedItem("bname").Value
            i = i + 1
            chapterCount2.Add(xmlnode.Attributes.GetNamedItem("bname").Value.ToLower, xmlnode.SelectNodes("CHAPTER").Count)
        Next
        Book2.Items.Clear()
        Book2.Items.AddRange(bibleBooks)
        Book2.SelectedIndex = 0
    End Sub

    Private Sub Book2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book2.SelectedIndexChanged
        Dim count As Integer = chapterCount2.Item(Book2.Text.ToLower)
        Chapter2.Items.Clear()
        For i As Integer = 1 To count
            Chapter2.Items.Add(Str(i))
        Next
        Chapter2.SelectedIndex = 0
    End Sub

    Private Sub SecondVerseCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondVerseCheckBox.CheckedChanged
        Bible2.Enabled = Not Bible2.Enabled
        Book2.Enabled = Not Book2.Enabled
        Chapter2.Enabled = Not Chapter2.Enabled
        Verse2.Enabled = Not Verse2.Enabled
        dashboard.doPreview()
    End Sub


    Private Sub Bible3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bible3.SelectedIndexChanged
        Dim xmldoc As New Xml.XmlDocument
        If Bible3.Text = "King James Version (1769)" Then
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + Bible3.Text)
        End If
        Dim xmlnodes = xmldoc.SelectNodes("/XMLBIBLE/BIBLEBOOK")

        Dim bibleBooks(65) As String
        chapterCount3 = New Hashtable
        Dim i As Integer = 0
        For Each xmlnode As Xml.XmlNode In xmlnodes
            bibleBooks(i) = xmlnode.Attributes.GetNamedItem("bname").Value
            i = i + 1
            chapterCount3.Add(xmlnode.Attributes.GetNamedItem("bname").Value.ToLower, xmlnode.SelectNodes("CHAPTER").Count)
        Next
        Book3.Items.Clear()
        Book3.Items.AddRange(bibleBooks)
        Book3.SelectedIndex = 0
    End Sub

    Private Sub Book3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book3.SelectedIndexChanged
        Dim count As Integer = chapterCount3.Item(Book3.Text.ToLower)
        Chapter3.Items.Clear()
        For i As Integer = 1 To count
            Chapter3.Items.Add(Str(i))
        Next
        Chapter3.SelectedIndex = 0
    End Sub

    Private Sub Bible4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bible4.SelectedIndexChanged
        Dim xmldoc As New Xml.XmlDocument
        If Bible4.Text = "King James Version (1769)" Then
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + Bible4.Text)
        End If
        Dim xmlnodes = xmldoc.SelectNodes("/XMLBIBLE/BIBLEBOOK")

        Dim bibleBooks(65) As String
        chapterCount4 = New Hashtable
        Dim i As Integer = 0
        For Each xmlnode As Xml.XmlNode In xmlnodes
            bibleBooks(i) = xmlnode.Attributes.GetNamedItem("bname").Value
            i = i + 1
            chapterCount4.Add(xmlnode.Attributes.GetNamedItem("bname").Value.ToLower, xmlnode.SelectNodes("CHAPTER").Count)
        Next
        Book4.Items.Clear()
        Book4.Items.AddRange(bibleBooks)
        Book4.SelectedIndex = 0
    End Sub

    Private Sub Book4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book4.SelectedIndexChanged
        Dim count As Integer = chapterCount4.Item(Book4.Text.ToLower)
        Chapter4.Items.Clear()
        For i As Integer = 1 To count
            Chapter4.Items.Add(Str(i))
        Next
        Chapter4.SelectedIndex = 0
    End Sub


    Private Sub ThirdVerseCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThirdVerseCheckBox.CheckedChanged
        Bible3.Enabled = Not Bible3.Enabled
        Book3.Enabled = Not Book3.Enabled
        Chapter3.Enabled = Not Chapter3.Enabled
        Verse3.Enabled = Not Verse3.Enabled
        dashboard.doPreview()
    End Sub

    Private Sub FourthVerseCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FourthVerseCheckBox.CheckedChanged
        Bible4.Enabled = Not Bible4.Enabled
        Book4.Enabled = Not Book4.Enabled
        Chapter4.Enabled = Not Chapter4.Enabled
        Verse4.Enabled = Not Verse4.Enabled
        dashboard.doPreview()
    End Sub


    'must be called from dashboard
    Public Function smartyTags(ByVal modifiedHtml As String)
        modifiedHtml = modifiedHtml.Replace("_VERSE_ONE_", verseText1)
        modifiedHtml = modifiedHtml.Replace("_VERSE_TWO_", verseText2)
        modifiedHtml = modifiedHtml.Replace("_VERSE_THREE_", verseText3)
        modifiedHtml = modifiedHtml.Replace("_VERSE_FOUR_", verseText4)

        If SecondVerseCheckBox.Checked Then
            modifiedHtml = modifiedHtml.Replace("<!--V2", "<!--V2_B-->")
            modifiedHtml = modifiedHtml.Replace("V2-->", "<!--V2_E-->")
        Else
            modifiedHtml = modifiedHtml.Replace("<!--V2_B-->", "<!--V2")
            modifiedHtml = modifiedHtml.Replace("<!--V2_E-->", "V2-->")
        End If

        If ThirdVerseCheckBox.Checked Then
            modifiedHtml = modifiedHtml.Replace("<!--V3", "<!--V3_B-->")
            modifiedHtml = modifiedHtml.Replace("V3-->", "<!--V3_E-->")
        Else
            modifiedHtml = modifiedHtml.Replace("<!--V3_B-->", "<!--V3")
            modifiedHtml = modifiedHtml.Replace("<!--V3_E-->", "V3-->")
        End If

        If FourthVerseCheckBox.Checked Then
            modifiedHtml = modifiedHtml.Replace("<!--V4", "<!--V4_B-->")
            modifiedHtml = modifiedHtml.Replace("V4-->", "<!--V4_E-->")
        Else
            modifiedHtml = modifiedHtml.Replace("<!--V4_B-->", "<!--V4")
            modifiedHtml = modifiedHtml.Replace("<!--V4_E-->", "V4-->")
        End If
        Return modifiedHtml
    End Function


    'must be called from dashboard
    Public Sub PreProcess()
        If Bible1.Text.Trim = "" Then
            'dont process
            Return
        End If

        Dim versetxt = GlobalMemory.getBibleVerse(BibleBooksComboBox.Text.Trim, ChapterComboBox.Text.Trim, Verse1.Text.Trim, Bible1.Text)
        verseText1 = versetxt
        verseText1 = verseText1 + " - " + BibleBooksComboBox.Text.Trim + " " + ChapterComboBox.Text.Trim + ":" + Verse1.Text.Trim
        '-----------------------------------------------------------------------
        If SecondVerseCheckBox.Checked Then
            versetxt = GlobalMemory.getBibleVerse(Book2.Text.Trim, Chapter2.Text.Trim, Verse2.Text.Trim, Bible2.Text)
            verseText2 = versetxt
            verseText2 = verseText2 + " - " + Book2.Text.Trim + " " + Chapter2.Text.Trim + ":" + Verse2.Text.Trim
        End If
        '-----------------------------------------------------------------------
        If ThirdVerseCheckBox.Checked Then
            versetxt = GlobalMemory.getBibleVerse(Book3.Text.Trim, Chapter3.Text.Trim, Verse3.Text.Trim, Bible3.Text)
            verseText3 = versetxt
            verseText3 = verseText3 + " - " + Book3.Text.Trim + " " + Chapter3.Text.Trim + ":" + Verse3.Text.Trim
        End If
        '-----------------------------------------------------------------------
        If FourthVerseCheckBox.Checked Then
            versetxt = GlobalMemory.getBibleVerse(Book4.Text.Trim, Chapter4.Text.Trim, Verse4.Text.Trim, Bible4.Text)
            verseText4 = versetxt
            verseText4 = verseText4 + " - " + Book4.Text.Trim + " " + Chapter4.Text.Trim + ":" + Verse4.Text.Trim
        End If
    End Sub



    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                ComboBox1.Text = ComboBox1.Text.Replace("  ", " ").Replace("  ", " ").Trim

                Dim codes() As String = ComboBox1.Text.Split(" ")

                Dim chp As String = codes(codes.Length - 2)
                Dim vrs As String = codes(codes.Length - 1)

                If codes.Length = 3 Then
                    BibleBooksComboBox.SelectedItem = codes(0)
                ElseIf codes.Length = 4 Then
                    BibleBooksComboBox.SelectedItem = codes(0) + " " + codes(1)
                ElseIf codes.Length = 5 Then
                    BibleBooksComboBox.SelectedItem = codes(0) + " " + codes(1) + " " + codes(2)
                ElseIf codes.Length = 6 Then
                    BibleBooksComboBox.SelectedItem = codes(0) + " " + codes(1) + " " + codes(2) + " " + codes(3)
                ElseIf codes.Length = 7 Then
                    BibleBooksComboBox.SelectedItem = codes(0) + " " + codes(1) + " " + codes(2) + " " + codes(3) + " " + codes(4)
                End If

                Try
                    ChapterComboBox.SelectedIndex = Integer.Parse(chp) - 1
                    errorProvider.SetError(ChapterComboBox, "")
                Catch ex As Exception
                    ChapterComboBox.SelectedIndex = ChapterComboBox.Items.Count - 1
                    errorProvider.SetError(ChapterComboBox, "Chapter out of range")
                End Try
                Verse1.Text = vrs
                errorProvider.SetError(ComboBox1, "")
                If CheckBox2.Checked = True Then
                    dashboard.sendOrUpdateProjector()
                Else
                    dashboard.doPreview()
                End If
            Catch
                errorProvider.SetError(ComboBox1, "Quick search did not find any relavant match!")
            End Try
        End If
    End Sub

    Private Sub ChapterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChapterComboBox.SelectedIndexChanged
        If Sync2.Checked And SecondVerseCheckBox.Checked Then
            Chapter2.SelectedIndex = ChapterComboBox.SelectedIndex
        End If
        If Sync3.Checked And ThirdVerseCheckBox.Checked Then
            Chapter3.SelectedIndex = ChapterComboBox.SelectedIndex
        End If
        If Sync4.Checked And FourthVerseCheckBox.Checked Then
            Chapter4.SelectedIndex = ChapterComboBox.SelectedIndex
        End If
    End Sub

    Private Sub Verse1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Verse1.TextChanged
        If Sync2.Checked And SecondVerseCheckBox.Checked Then
            Verse2.Text = Verse1.Text
        End If
        If Sync3.Checked And ThirdVerseCheckBox.Checked Then
            Verse3.Text = Verse1.Text
        End If
        If Sync4.Checked And FourthVerseCheckBox.Checked Then
            Verse4.Text = Verse1.Text
        End If
    End Sub

    Private Sub BtnAddVerse_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddVerse.Click
        Dim verse As Integer
        Dim diff As Integer
        If Integer.TryParse(Verse1.Text, verse) Then
            Verse1.Text = (verse + 1).ToString()
        Else
            Dim varray() As String = Verse1.Text.Split(New Char() {"-"})
            diff = Integer.Parse(varray(1)) - Integer.Parse(varray(0))
            Verse1.Text = (Integer.Parse(varray(1)) + 1).ToString() + "-" + (Integer.Parse(varray(1) + 1 + diff)).ToString()
        End If
    End Sub

    Private Sub BtnSubVerse_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubVerse.Click
        Dim verse As Integer
        If Integer.TryParse(Verse1.Text, verse) Then
            If verse - 1 <> 0 Then
                Verse1.Text = (verse - 1).ToString()
            End If
        Else
            Dim varray() As String = Verse1.Text.Split(New Char() {"-"})
            If Integer.Parse(varray(0)) - 1 <> 0 Then
                Verse1.Text = (Integer.Parse(varray(0)) - 1).ToString() + "-" + (Integer.Parse(varray(1)) - 1).ToString()
            Else
                Verse1.Text = "1-" + (Integer.Parse(varray(1)) - 1).ToString()
                If Verse1.Text = "1-1" Then
                    Verse1.Text = "1"
                End If
            End If
        End If
    End Sub
End Class