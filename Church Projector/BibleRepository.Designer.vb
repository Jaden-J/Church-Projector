<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BibleRepository
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.buttonDownload = New System.Windows.Forms.Button()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.comboBoxLanguage = New System.Windows.Forms.ComboBox()
        Me.comboBoxTranslation = New System.Windows.Forms.ComboBox()
        Me.backgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonDownload
        '
        Me.buttonDownload.Location = New System.Drawing.Point(408, 120)
        Me.buttonDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDownload.Name = "buttonDownload"
        Me.buttonDownload.Size = New System.Drawing.Size(110, 29)
        Me.buttonDownload.TabIndex = 11
        Me.buttonDownload.Text = "Download"
        Me.buttonDownload.UseVisualStyleBackColor = True
        '
        'backgroundWorker1
        '
        Me.backgroundWorker1.WorkerSupportsCancellation = True
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(26, 120)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(374, 28)
        Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progressBar1.TabIndex = 12
        Me.progressBar1.Visible = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(26, 96)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(95, 17)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Please wait ..."
        Me.label6.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 27)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Language"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 64)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 17)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Translation"
        '
        'comboBoxLanguage
        '
        Me.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxLanguage.FormattingEnabled = True
        Me.comboBoxLanguage.Items.AddRange(New Object() {"Afrikaans", "Albanian", "Amharic", "Arabic", "Awadhi", "Basque", "Bengali", "Bulgarian", "Burmese", "Cebuano", "Chinese", "Coptic", "Croatian", "Czech", "Danish", "Dari", "Dutch", "English", "Esperanto", "Estonian", "Farsi", "Finnish", "French", "German", "Greek", "Gujarati", "Haitian Creole", "Hebrew", "Hindi", "Hungarian", "Icelandic", "Indonesian", "Italian", "Japanese", "Kabyle", "Kannada", "Kekchi", "Korean", "Latin", "Latvian", "Lithuanian", "Malagasy", "Malayalam", "Maori", "Marathi", "Mizo", "Nepali", "Norwegian", "Paite", "Persian", "Polish", "Portuguese", "Punjabi", "Romani", "Romanian", "Russian", "Serbian", "Slovakian", "Slovenian", "Somali", "Spanish", "Swahili", "Swedish", "Syriac", "Tagalog", "Tamil", "Telugu", "Thai", "Tigrigna", "Turkish", "Ukrainian", "Uma", "Urdu", "Vietnamese", "Welsh", "Wolof", "Xhosa", "Zarma"})
        Me.comboBoxLanguage.Location = New System.Drawing.Point(135, 23)
        Me.comboBoxLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxLanguage.Name = "comboBoxLanguage"
        Me.comboBoxLanguage.Size = New System.Drawing.Size(383, 24)
        Me.comboBoxLanguage.TabIndex = 18
        '
        'comboBoxTranslation
        '
        Me.comboBoxTranslation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxTranslation.FormattingEnabled = True
        Me.comboBoxTranslation.Location = New System.Drawing.Point(135, 60)
        Me.comboBoxTranslation.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxTranslation.Name = "comboBoxTranslation"
        Me.comboBoxTranslation.Size = New System.Drawing.Size(328, 24)
        Me.comboBoxTranslation.TabIndex = 19
        '
        'backgroundWorker2
        '
        Me.backgroundWorker2.WorkerSupportsCancellation = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(472, 64)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(35, 17)
        Me.lblSize.TabIndex = 20
        Me.lblSize.Text = "Size"
        Me.lblSize.Visible = False
        '
        'timer1
        '
        Me.timer1.Interval = 1000
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(26, 235)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(492, 315)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Available Bibles"
        '
        'BibleRepository
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.comboBoxTranslation)
        Me.Controls.Add(Me.comboBoxLanguage)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.buttonDownload)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BibleRepository"
        Me.Text = "Bible Repository"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents buttonDownload As System.Windows.Forms.Button
    Friend WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents comboBoxLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxTranslation As System.Windows.Forms.ComboBox
    Friend WithEvents backgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
