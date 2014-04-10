Imports System.Reflection
Imports System.IO

Public Class Dashboard

    Dim dimention_ratio As Double
    Public scale_ratio As Integer

    Dim OriginalHtml As String
    Dim modifiedHtml As String

    Dim background As String = "#000000"
    Dim foreground As String = "#FFFFFF"
    Dim fontsize As String = "45"
    Dim backimage As String = ""

    Dim callingForm As Form = Nothing

    Public Sub New(ByRef _callingForm As Form)
        callingForm = _callingForm
        InitializeComponent()
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While True
            If (Screen.AllScreens.Length < 2) Then
                Dim result = MsgBox("Only one display device detected. You can connect and retry if you are using projector as your extended secondary display, ignore this warning if you use projector as a primary display or abort to close.", MsgBoxStyle.RetryCancel, "Church Projector - Display/Projector Device")
                If (result = MsgBoxResult.Retry) Then
                    Continue While
                End If
            End If
            Exit While
        End While

        For Each scr As Screen In Screen.AllScreens
            DisplayDeviceComboBox.Items.Add(scr.DeviceName + " - " + Str(scr.Bounds.Width) + "x" + Str(scr.Bounds.Height) + " (" + Str(scr.BitsPerPixel) + " bits)")
        Next
        If Screen.AllScreens.Length > 1 Then
            DisplayDeviceComboBox.SelectedIndex = 1
        Else
            DisplayDeviceComboBox.SelectedIndex = 0
        End If

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Plain and Simple")
        ComboBox1.Items.Add("Typewritter Animation")
        
        If ComboBox1.Items.Contains("Plain and Simple") Then
            ComboBox1.SelectedIndex = ComboBox1.Items.IndexOf("Plain and Simple")
        Else
            ComboBox1.SelectedIndex = 0
        End If

        If Me.ParentForm.Name = "ScriptureDisplay" Then
            ProjectorHtmlEditor.Text = "<!doctype html> " + My.Resources.ScriptureDisplay_Plain_and_Simple
        Else
            ProjectorHtmlEditor.Text = "<!doctype html> " + My.Resources.LyricsDisplay_Plain_and_Simple
        End If


        GlobalMemory.Navigate(WebBrowserPreview, ProjectorHtmlEditor.Text)
    End Sub

    Public Sub updateButton()
        If GlobalMemory.getProjectorDisplay().Visible = True Then
            Button2.Text = "Stop Projector"
        Else
            Button2.Text = "Send to Projector"
        End If
    End Sub

    Private Sub DisplayDeviceComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayDeviceComboBox.SelectedIndexChanged
        Dim scr As Screen = Screen.AllScreens(DisplayDeviceComboBox.SelectedIndex)
        dimention_ratio = scr.Bounds.Width / scr.Bounds.Height
        WebBrowserPreview.Width = WebBrowserPreview.Height * dimention_ratio
        scale_ratio = WebBrowserPreview.Width * 100 / scr.Bounds.Width
        DisplayToBtn.Checked = False
    End Sub

    Public Sub loadInit()
        fontsize = Str(TrackBar1.Value)
        OriginalHtml = ProjectorHtmlEditor.Text
        modifiedHtml = ProjectorHtmlEditor.Text
        'Zoom
        InitZoomTimer.Start()
    End Sub

    Public Sub doPreview()
        Try
            callParentFunction("PreProcess", New Object() {})
            smartyTags()
            GlobalMemory.Navigate(WebBrowserPreview, modifiedHtml)
        Catch ex As Exception
            MsgBox(ex.ToString + vbCrLf + vbCrLf + "Tip: Selected option e.g, Verse may not be in range.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DisplayToBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToBtn.CheckedChanged
        If DisplayToBtn.Checked Then
            callParentFunction("PreProcess", New Object() {})
            smartyTags()
            Dim scr As Screen = Screen.AllScreens(DisplayDeviceComboBox.SelectedIndex)
            GlobalMemory.getProjectorDisplay().StartPosition = FormStartPosition.Manual
            GlobalMemory.getProjectorDisplay().Location = scr.Bounds.Location
            GlobalMemory.getProjectorDisplay().setHtmlContent(modifiedHtml)
        Else
            GlobalMemory.getProjectorDisplay().Dispose()
        End If
    End Sub

    Private Sub AdvancedEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedEdit.CheckedChanged
        If AdvancedEdit.Checked = True Then
            ProjectorHtmlEditor.Visible = True
        Else
            ProjectorHtmlEditor.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DisplayToBtn.Checked = Not DisplayToBtn.Checked
        If Button2.Text = "Send to Projector" Then
            doPreview()
            Button2.Text = "Stop Projector"
        Else
            Button2.Text = "Send to Projector"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ProjectorHtmlEditor.Text = OriginalHtml
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a = ColorDialog1.ShowDialog
        If a = Windows.Forms.DialogResult.OK Then
            background = ColorTranslator.ToHtml(ColorDialog1.Color)
            Button4.BackColor = ColorDialog1.Color
            doPreview()
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a = ColorDialog1.ShowDialog
        If a = Windows.Forms.DialogResult.OK Then
            foreground = ColorTranslator.ToHtml(ColorDialog1.Color)
            Button5.BackColor = ColorDialog1.Color
            doPreview()
        End If
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        fontsize = Str(TrackBar1.Value)
        doPreview()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileDialog1.InitialDirectory = GlobalMemory.getSharedDataPath() + "\Backgrounds"
        Dim a = OpenFileDialog1.ShowDialog()
        If a = Windows.Forms.DialogResult.OK Then
            Dim filename = OpenFileDialog1.FileName
            TextBox1.Text = OpenFileDialog1.FileName
            backimage = New Uri(filename).ToString
            doPreview()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Visible = True
            Button6.Enabled = True
            Button6.Visible = True
            Button4.Enabled = False
            Label17.Enabled = False
        Else
            TextBox1.Visible = False
            Button6.Enabled = False
            Button6.Visible = False
            Button4.Enabled = True
            Label17.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim blankHtml As String = "<!doctype html> <html><body style=""background:_BACKGROUND_; background-image: url('_BACKIMAGE_')""> </body></html>"
        smartyTags()
        If GlobalMemory.getProjectorDisplay().Visible = True Then
            GlobalMemory.getProjectorDisplay().setHtmlContent(blankHtml)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        doPreview()
        If GlobalMemory.getProjectorDisplay().Visible = True Then
            GlobalMemory.getProjectorDisplay().setHtmlContent(modifiedHtml)
        End If
    End Sub

    Sub smartyTags()
        modifiedHtml = ProjectorHtmlEditor.Text
        modifiedHtml = callParentFunction("smartyTags", New Object() {modifiedHtml})
        If CheckBox1.Checked Then
            modifiedHtml = modifiedHtml.Replace("_BACKIMAGE_", backimage)
        Else
            modifiedHtml = modifiedHtml.Replace("_BACKGROUND_", background)
        End If
        modifiedHtml = modifiedHtml.Replace("_FOREGROUND_", foreground)
        modifiedHtml = modifiedHtml.Replace("_SIZE_", fontsize)
    End Sub

    Public Sub sendOrUpdateProjector()
        If Button2.Text = "Send to Projector" Then
            Button2.PerformClick()
        Else
            Button7.PerformClick()
        End If
    End Sub

    Private Sub ProjectorHtmlEditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectorHtmlEditor.TextChanged
        doPreview()
    End Sub

    Private Sub PreviewBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewBtn.Click
        doPreview()
    End Sub

    Function callParentFunction(ByVal fn As String, ByVal param() As Object) As Object
        Dim formType As Type = callingForm.GetType()
        Dim formMethod As MethodInfo = formType.GetMethod(fn)
        Return formMethod.Invoke(callingForm, param)
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        CheckBox1.Checked = False
        Dim combo As ComboBox = DirectCast(sender, ComboBox)
        If Me.ParentForm.Name = "ScriptureDisplay" Then
            If combo.SelectedItem.ToString = "Plain and Simple" Then
                OriginalHtml = "<!doctype html> " + My.Resources.ScriptureDisplay_Plain_and_Simple
            Else
                OriginalHtml = "<!doctype html> " + My.Resources.ScriptureDisplay_Typewritter_Animation
            End If
        Else
            If combo.SelectedItem.ToString = "Plain and Simple" Then
                OriginalHtml = "<!doctype html> " + My.Resources.LyricsDisplay_Plain_and_Simple
            Else
                OriginalHtml = "<!doctype html> " + My.Resources.LyricsDisplay_Typewritter_Animation
            End If
        End If

        ProjectorHtmlEditor.Text = OriginalHtml
        modifiedHtml = OriginalHtml

        'Parse and find out forced settings
        Dim startIdx = modifiedHtml.IndexOf("<!--SETTINGS") + "<!--SETTINGS".Length
        Dim settings_length = modifiedHtml.IndexOf("SETTINGS-->") - startIdx
        Try
            Dim settings_str As String = modifiedHtml.Substring(startIdx, settings_length)
            Dim settings() As String = settings_str.Split(";")

            For Each str As String In settings
                If str.Trim = "" Then
                    Continue For
                End If
                Dim param_value() As String = str.Split("=")

                'background
                If param_value(0).Trim = "_BACKGROUND_" Then
                    Dim clr As Color = ColorTranslator.FromHtml(param_value(1).Trim)
                    Button4.BackColor = clr
                    background = param_value(1).Trim
                End If

                'foreground
                If param_value(0).Trim = "_FOREGROUND_" Then
                    Dim clr As Color = ColorTranslator.FromHtml(param_value(1).Trim)
                    Button5.BackColor = clr
                    foreground = param_value(1).Trim
                End If

                'backimage
                'If param_value(0).Trim = "_BACKIMAGE_" Then
                '    TextBox1.Text = GlobalMemory.getSharedDataPath() + "\Backgrounds\" + param_value(1).Trim
                '    CheckBox1.Checked = True
                '    backimage = New Uri(TextBox1.Text).ToString
                'End If
            Next
        Catch ex As Exception
            'ignore
        End Try
        doPreview()
    End Sub

    Private Sub Browse_Click(sender As System.Object, e As System.EventArgs) Handles Browse.Click
        CheckBox1.Checked = False

        OpenFileDialog1.InitialDirectory = GlobalMemory.getSharedDataPath()
        Dim a = OpenFileDialog1.ShowDialog()
        If a = Windows.Forms.DialogResult.OK Then
            Dim filename = OpenFileDialog1.FileName

            OriginalHtml = "<!doctype html>" + File.ReadAllText(filename)

            ProjectorHtmlEditor.Text = OriginalHtml
            modifiedHtml = OriginalHtml

            'Parse and find out forced settings
            Dim startIdx = modifiedHtml.IndexOf("<!--SETTINGS") + "<!--SETTINGS".Length
            Dim settings_length = modifiedHtml.IndexOf("SETTINGS-->") - startIdx
            Try
                Dim settings_str As String = modifiedHtml.Substring(startIdx, settings_length)
                Dim settings() As String = settings_str.Split(";")

                For Each str As String In settings
                    If str.Trim = "" Then
                        Continue For
                    End If
                    Dim param_value() As String = str.Split("=")

                    'background
                    If param_value(0).Trim = "_BACKGROUND_" Then
                        Dim clr As Color = ColorTranslator.FromHtml(param_value(1).Trim)
                        Button4.BackColor = clr
                        background = param_value(1).Trim
                    End If

                    'foreground
                    If param_value(0).Trim = "_FOREGROUND_" Then
                        Dim clr As Color = ColorTranslator.FromHtml(param_value(1).Trim)
                        Button5.BackColor = clr
                        foreground = param_value(1).Trim
                    End If

                    'backimage
                    'If param_value(0).Trim = "_BACKIMAGE_" Then
                    '    TextBox1.Text = GlobalMemory.getSharedDataPath() + "\Backgrounds\" + param_value(1).Trim
                    '    CheckBox1.Checked = True
                    '    backimage = New Uri(TextBox1.Text).ToString
                    'End If
                Next
            Catch ex As Exception
                'ignore
            End Try
            doPreview()
        End If
    End Sub

    Private Sub InitZoomTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitZoomTimer.Tick
        If WebBrowserPreview.ReadyState = WebBrowserReadyState.Complete Then
            GlobalMemory.doZoom(WebBrowserPreview, scale_ratio)
            InitZoomTimer.Stop()
        End If
    End Sub
End Class
