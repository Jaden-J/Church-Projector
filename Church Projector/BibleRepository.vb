Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Reflection
Imports System.Diagnostics
Imports System.Net
Imports System.Xml
Imports System.Collections
Imports System.Web

Partial Public Class BibleRepository
    Inherits Form
    Private tmp_xml As String = Nothing
    Private dn_xml_url As String = Nothing

    Private progress_msg As String = ""
    Private tgt As String = GlobalMemory.getSharedDataPath + Path.DirectorySeparatorChar + "bibles"
    Private trans_list As New ArrayList()
    Private trans_size As New ArrayList()

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub backgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker2.DoWork
        Dim language As String = DirectCast(e.Argument, String)
        Dim htmlCode As String = Nothing
        Dim tableCode As String = Nothing
        Dim xdoc As New XmlDocument()
        Dim list As XmlNodeList = Nothing
        trans_list.Clear()
        trans_size.Clear()
        Dim trans_value As String = Nothing
        Using client As New WebClient()
            htmlCode = client.DownloadString("http://www.churchsw.org/repository/Bibles/" + language + "/")
            tableCode = htmlCode.Substring(htmlCode.IndexOf("<table"), htmlCode.IndexOf("</table") - htmlCode.IndexOf("<table") + 8)
            tableCode = tableCode.Replace("&nbsp;", "")
            xdoc.LoadXml(tableCode)
            list = xdoc.SelectNodes("/table/tr/td/a")
            For Each node As XmlNode In list
                trans_value = node.Attributes("href").Value
                If trans_value <> "/repository/Bibles/" Then
                    trans_value = trans_value.Replace("%20", " ")
                    trans_value = trans_value.Replace(".xml", "")
                    If Not trans_list.Contains(trans_value) Then
                        trans_list.Add(trans_value)
                        trans_size.Add(node.ParentNode.NextSibling.NextSibling.NextSibling.InnerText)
                    End If
                End If
            Next
        End Using
    End Sub

    Private Sub backgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorker2.RunWorkerCompleted
        comboBoxTranslation.Items.Clear()
        comboBoxTranslation.Items.AddRange(trans_list.ToArray())
        comboBoxTranslation.Enabled = True
        comboBoxTranslation.SelectedIndex = 0
        lblSize.Text = DirectCast(trans_size(0), String)
        lblSize.Visible = True
    End Sub

    Private Sub buttonDownload_Click(sender As System.Object, e As System.EventArgs) Handles buttonDownload.Click
        Dim selected_xml_file As String = comboBoxTranslation.SelectedItem.ToString().Replace(" ", "%20") + ".xml"
        dn_xml_url = "http://www.churchsw.org/repository/Bibles/" + comboBoxLanguage.SelectedItem + "/" + selected_xml_file

        buttonDownload.Enabled = False
        progressBar1.Visible = True
        label6.Visible = True
        progress_msg = "Please wait ..."
        timer1.Enabled = True

        If Not backgroundWorker1.IsBusy Then
            backgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BibleRepository_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        comboBoxLanguage.SelectedIndex = 17
        '
        refreshFolderView()
    End Sub

    Private Sub refreshFolderView()
        ListView1.Items.Clear()

        Dim files() As String = Directory.GetFiles(tgt)
        For Each file As String In files
            Dim fileName = Path.GetFileNameWithoutExtension(file)
            Dim item As ListViewItem = New ListViewItem(fileName)
            item.Tag = file
            ListView1.Items.Add(item)
        Next

    End Sub

    Private Sub backgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles backgroundWorker1.DoWork
        Dim process__1 As Process = DirectCast(e.Argument, Process)

        Dim exited As Boolean = False
        progress_msg = "Downloading ..."
        ' Download the XML...
        tmp_xml = Path.GetTempFileName()
        Using client As New WebClient()
            ' WebClient class inherits IDisposable
            client.DownloadFile(dn_xml_url, tmp_xml)
        End Using
        '''/        
        If File.Exists(tgt + Path.PathSeparator + Path.GetFileName(dn_xml_url)) Then
            File.Delete(tgt + Path.PathSeparator + Path.GetFileName(dn_xml_url))
        End If
        File.Move(tmp_xml, tgt + "\\" + HttpUtility.UrlDecode(Path.GetFileName(dn_xml_url)))
        If File.Exists(tmp_xml) Then
            File.Delete(tmp_xml)
        End If
    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        'change UI
        progress_msg = "Download Complete!"
        buttonDownload.Enabled = True
        progressBar1.Visible = False
        label6.Visible = False
        timer1.Enabled = False
        refreshFolderView()
    End Sub

    Private Sub comboBoxLanguage_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBoxLanguage.SelectedIndexChanged
        ' find all translations from the web...
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        comboBoxTranslation.Items.Add("Loading...")
        comboBoxTranslation.SelectedIndex = 0
        comboBoxTranslation.Enabled = False
        lblSize.Visible = False
        backgroundWorker2.RunWorkerAsync(cb.SelectedItem)
    End Sub

    Private Sub timer1_Tick(sender As System.Object, e As System.EventArgs) Handles timer1.Tick
        label6.Text = progress_msg
    End Sub

    Private Sub comboBoxTranslation_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBoxTranslation.SelectedIndexChanged
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        If cb.SelectedIndex >= 0 AndAlso trans_size.Count > 0 Then
            lblSize.Text = DirectCast(trans_size(cb.SelectedIndex), String)
        Else
            lblSize.Text = "Unknown"
        End If
    End Sub
End Class
