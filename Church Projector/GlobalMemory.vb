Imports System.Xml
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class GlobalMemory

    Private Shared projectorDisplay = New ProjectorDisplay()
    Private Shared availableBibles As New ArrayList

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Private Const Olecmdf_supported = 1
    Private Const olecmdf_enabled = 2

    Shared _tmpDisplay As String = Path.GetTempPath + "display.html"

    Public Shared Function getProjectorDisplay() As ProjectorDisplay
        If projectorDisplay Is Nothing Or projectorDisplay.IsDisposed Then
            projectorDisplay = New ProjectorDisplay()
        End If
        Return projectorDisplay
    End Function

    Public Shared Function getSharedDataPath() As String
        Return Path.GetDirectoryName(Application.ExecutablePath)
    End Function

    Public Shared Sub Navigate(ByVal browser As WebBrowser, ByVal text As String)
        Dim displayStream As New StreamWriter(_tmpDisplay, False, System.Text.UTF8Encoding.UTF8)
        displayStream.Write(text)
        displayStream.Close()

        Dim u As New Uri(_tmpDisplay)

        If Not browser.IsHandleCreated Then
            browser.CreateControl()
        End If
        browser.Navigate(u.ToString)
    End Sub

    Public Shared Sub doZoom(ByVal browser As WebBrowser, ByVal scale_ratio As String)
        Dim size As New Drawing.SizeF(browser.Width, browser.Height)
        'browser.ActiveXInstance.Window.TextZoom = scale_ratio / 100      
        browser.ActiveXInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, Integer.Parse(scale_ratio) * 2, IntPtr.Zero)
    End Sub

    Public Shared Sub doInit()
        availableBibles.Clear()
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(getSharedDataPath() + Path.DirectorySeparatorChar + "bibles")
        If Not di.Exists Then
            di.Create()
        End If
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.xml")

        'If aryFi.Length = 0 Then
        '    MsgBox("Download the bibles you require from churchsw.org and copy them into the below folder and restart the application." + vbCrLf + vbCrLf + getSharedDataPath() + "\bibles")
        '    MainWindow.noBiblesExit = True
        '    Application.Exit()
        'End If

        Dim fi As IO.FileInfo
        'King James Version (1769)
        availableBibles.Add("King James Version (1769)")
        For Each fi In aryFi
            availableBibles.Add(fi.Name)
        Next
    End Sub

    Public Shared Function getBibleVerse(ByVal book As String, ByVal chapter As String, ByVal verse As String, ByVal biblefile As String) As String
        Dim xmldoc As New Xml.XmlDocument

        If biblefile = "King James Version (1769)" Then
            xmldoc.LoadXml(GlobalMemory.UnZip(My.Resources.KJV))
        Else
            xmldoc.Load(GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles" + Path.DirectorySeparatorChar + biblefile)
        End If


        Dim node As XmlNode = xmldoc.SelectSingleNode("/XMLBIBLE/BIBLEBOOK[@bname='" + book.Trim + "']/CHAPTER[@cnumber='" + chapter.Trim + "']/VERS[@vnumber='" + verse.Trim + "']")
        If node Is Nothing Then
            Dim varray() As String = verse.Split(New Char() {"-"})
            Dim i As Integer = 0
            Dim versetxt As String = ""
            For i = Integer.Parse(varray(0)) To Integer.Parse(varray(1))
                node = xmldoc.SelectSingleNode("/XMLBIBLE/BIBLEBOOK[@bname='" + book.Trim + "']/CHAPTER[@cnumber='" + chapter.Trim + "']/VERS[@vnumber='" + i.ToString().Trim + "']")
                If Not node Is Nothing Then
                    versetxt = versetxt + node.InnerText + " "
                End If
            Next
            Return versetxt
        Else
            Return node.InnerText
        End If

    End Function

    Public Shared Function getAvailableBibles() As ArrayList
        Return availableBibles
    End Function

    Public Shared Function getLexiconsList() As Object()
        Dim xmldoc As New Xml.XmlDocument
        xmldoc.Load("strongs_lexicon.xml")
        Dim nodeList As XmlNodeList = xmldoc.SelectNodes("/dictionary/item/@id")
        Dim array As New ArrayList
        For Each n As XmlNode In nodeList
            array.Add(n.InnerText)
        Next
        Return array.ToArray()
    End Function

    Public Shared Function getLexicon(ByVal lexicon As String) As String()
        Dim xmldoc As New Xml.XmlDocument
        xmldoc.Load("strongs_lexicon.xml")
        Dim node As XmlNode = xmldoc.SelectSingleNode("/dictionary/item[@id='" + lexicon.Trim + "']")
        Dim value(4) As String

        value(0) = node.SelectSingleNode("title").InnerText
        value(1) = node.SelectSingleNode("transliteration").InnerText
        value(2) = node.SelectSingleNode("pronunciation").InnerText
        value(3) = node.SelectSingleNode("description").InnerText

        Return value
    End Function

    Public Shared Function UnZip(ByVal bytes() As Byte) As String
        Dim ms As New MemoryStream(bytes)
        Dim gz As New GZipStream(ms, CompressionMode.Decompress)
        Dim bt(3) As Byte
        ms.Position = ms.Length - 4
        ms.Read(bt, 0, 4)
        ms.Position = 0
        Dim size As Integer = BitConverter.ToInt32(bt, 0)
        Dim buffer(size + 100) As Byte
        Dim offset As Integer = 0
        Dim total As Integer = 0
        While (True)
            Dim j As Integer = gz.Read(buffer, offset, 100)
            If j = 0 Then Exit While
            offset += j
            total += j
        End While
        gz.Close()
        gz.Dispose()
        ms.Close()
        ms.Dispose()
        Dim ra(total - 1) As Byte
        Array.ConstrainedCopy(buffer, 0, ra, 0, total)
        Dim sB As New System.Text.StringBuilder(ra.Length)
        For i As Integer = 0 To ra.Length - 1
            sB.Append(ChrW(ra(i)))
        Next
        Return sB.ToString()
    End Function
End Class
