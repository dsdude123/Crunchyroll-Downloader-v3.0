<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anime_Add
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.initialSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.subfolderSelection = New System.Windows.Forms.ComboBox()
        Me.baseDirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.animeUrl = New System.Windows.Forms.TextBox()
        Me.animeName = New System.Windows.Forms.TextBox()
        Me.downloadButton = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.episodeSelectionGroup = New System.Windows.Forms.GroupBox()
        Me.cancelAddButton = New System.Windows.Forms.PictureBox()
        Me.Add_Display = New System.Windows.Forms.Label()
        Me.lastEpisodeSelector = New System.Windows.Forms.ComboBox()
        Me.seasonSelector = New System.Windows.Forms.ComboBox()
        Me.firstEpisodeSelector = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.animeQueue = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.initialSettingsGroup.SuspendLayout()
        CType(Me.downloadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.episodeSelectionGroup.SuspendLayout()
        CType(Me.cancelAddButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.initialSettingsGroup.BackColor = System.Drawing.Color.Transparent
        Me.initialSettingsGroup.Controls.Add(Me.StatusLabel)
        Me.initialSettingsGroup.Controls.Add(Me.subfolderSelection)
        Me.initialSettingsGroup.Controls.Add(Me.baseDirectoryTextBox)
        Me.initialSettingsGroup.Controls.Add(Me.animeUrl)
        Me.initialSettingsGroup.Controls.Add(Me.animeName)
        Me.initialSettingsGroup.Location = New System.Drawing.Point(5, 45)
        Me.initialSettingsGroup.Name = "initialSettingsGroup"
        Me.initialSettingsGroup.Size = New System.Drawing.Size(620, 162)
        Me.initialSettingsGroup.TabIndex = 33
        Me.initialSettingsGroup.TabStop = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.StatusLabel.Location = New System.Drawing.Point(18, 127)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(593, 29)
        Me.StatusLabel.TabIndex = 38
        Me.StatusLabel.Text = "Status: idle"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subfolderSelection
        '
        Me.subfolderSelection.BackColor = System.Drawing.Color.White
        Me.subfolderSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.subfolderSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subfolderSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subfolderSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.subfolderSelection.FormattingEnabled = True
        Me.subfolderSelection.Location = New System.Drawing.Point(18, 98)
        Me.subfolderSelection.Name = "subfolderSelection"
        Me.subfolderSelection.Size = New System.Drawing.Size(585, 23)
        Me.subfolderSelection.Sorted = True
        Me.subfolderSelection.TabIndex = 37
        '
        'baseDirectory
        '
        Me.baseDirectoryTextBox.BackColor = System.Drawing.Color.White
        Me.baseDirectoryTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.baseDirectoryTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baseDirectoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.baseDirectoryTextBox.Location = New System.Drawing.Point(18, 70)
        Me.baseDirectoryTextBox.Name = "baseDirectory"
        Me.baseDirectoryTextBox.ReadOnly = True
        Me.baseDirectoryTextBox.Size = New System.Drawing.Size(585, 22)
        Me.baseDirectoryTextBox.TabIndex = 36
        Me.baseDirectoryTextBox.TabStop = False
        Me.baseDirectoryTextBox.Text = "Main Directory"
        Me.baseDirectoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'animeUrl
        '
        Me.animeUrl.BackColor = System.Drawing.Color.White
        Me.animeUrl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animeUrl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.animeUrl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.animeUrl.Location = New System.Drawing.Point(18, 14)
        Me.animeUrl.Name = "animeUrl"
        Me.animeUrl.Size = New System.Drawing.Size(585, 22)
        Me.animeUrl.TabIndex = 4
        Me.animeUrl.TabStop = False
        Me.animeUrl.Text = "URL"
        Me.animeUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'animeName
        '
        Me.animeName.BackColor = System.Drawing.Color.White
        Me.animeName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animeName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.animeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.animeName.Location = New System.Drawing.Point(18, 42)
        Me.animeName.Name = "animeName"
        Me.animeName.Size = New System.Drawing.Size(585, 22)
        Me.animeName.TabIndex = 5
        Me.animeName.TabStop = False
        Me.animeName.Text = "Name of the Anime"
        Me.animeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'downloadButton
        '
        Me.downloadButton.BackColor = System.Drawing.Color.Transparent
        Me.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.downloadButton.Image = Global.Crunchyroll_Downloader.My.Resources.Resources.main_button_download_default
        Me.downloadButton.Location = New System.Drawing.Point(44, 213)
        Me.downloadButton.Name = "downloadButton"
        Me.downloadButton.Size = New System.Drawing.Size(537, 50)
        Me.downloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.downloadButton.TabIndex = 42
        Me.downloadButton.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Image = Global.Crunchyroll_Downloader.My.Resources.Resources.main_close
        Me.closeButton.Location = New System.Drawing.Point(579, 1)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(50, 40)
        Me.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.closeButton.TabIndex = 43
        Me.closeButton.TabStop = False
        '
        'groupBox2
        '
        Me.episodeSelectionGroup.BackColor = System.Drawing.Color.Transparent
        Me.episodeSelectionGroup.Controls.Add(Me.cancelAddButton)
        Me.episodeSelectionGroup.Controls.Add(Me.Add_Display)
        Me.episodeSelectionGroup.Controls.Add(Me.lastEpisodeSelector)
        Me.episodeSelectionGroup.Controls.Add(Me.seasonSelector)
        Me.episodeSelectionGroup.Controls.Add(Me.firstEpisodeSelector)
        Me.episodeSelectionGroup.Location = New System.Drawing.Point(5, 45)
        Me.episodeSelectionGroup.Name = "episodeSelectionGroup"
        Me.episodeSelectionGroup.Size = New System.Drawing.Size(620, 162)
        Me.episodeSelectionGroup.TabIndex = 44
        Me.episodeSelectionGroup.TabStop = False
        Me.episodeSelectionGroup.Visible = False
        '
        'PictureBox1
        '
        Me.cancelAddButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelAddButton.Image = Global.Crunchyroll_Downloader.My.Resources.Resources.add_mass_cancel
        Me.cancelAddButton.Location = New System.Drawing.Point(113, 117)
        Me.cancelAddButton.Name = "cancelAddButton"
        Me.cancelAddButton.Size = New System.Drawing.Size(403, 36)
        Me.cancelAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelAddButton.TabIndex = 45
        Me.cancelAddButton.TabStop = False
        '
        'Add_Display
        '
        Me.Add_Display.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Display.BackColor = System.Drawing.Color.Transparent
        Me.Add_Display.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Display.ForeColor = System.Drawing.Color.Black
        Me.Add_Display.Location = New System.Drawing.Point(20, 114)
        Me.Add_Display.Name = "Add_Display"
        Me.Add_Display.Size = New System.Drawing.Size(591, 38)
        Me.Add_Display.TabIndex = 36
        Me.Add_Display.Text = "..."
        Me.Add_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comboBox4
        '
        Me.lastEpisodeSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lastEpisodeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lastEpisodeSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastEpisodeSelector.FormattingEnabled = True
        Me.lastEpisodeSelector.Location = New System.Drawing.Point(24, 83)
        Me.lastEpisodeSelector.Name = "lastEpisodeSelector"
        Me.lastEpisodeSelector.Size = New System.Drawing.Size(585, 23)
        Me.lastEpisodeSelector.TabIndex = 2
        '
        'ComboBox1
        '
        Me.seasonSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.seasonSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seasonSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seasonSelector.FormattingEnabled = True
        Me.seasonSelector.Location = New System.Drawing.Point(24, 19)
        Me.seasonSelector.Name = "seasonSelector"
        Me.seasonSelector.Size = New System.Drawing.Size(585, 23)
        Me.seasonSelector.TabIndex = 1
        '
        'comboBox3
        '
        Me.firstEpisodeSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.firstEpisodeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.firstEpisodeSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstEpisodeSelector.FormattingEnabled = True
        Me.firstEpisodeSelector.Location = New System.Drawing.Point(24, 51)
        Me.firstEpisodeSelector.Name = "comboBox3"
        Me.firstEpisodeSelector.Size = New System.Drawing.Size(585, 23)
        Me.firstEpisodeSelector.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.animeQueue)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 162)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'ListBox1
        '
        Me.animeQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.animeQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.animeQueue.FormattingEnabled = True
        Me.animeQueue.Location = New System.Drawing.Point(3, 16)
        Me.animeQueue.Name = "animeQueue"
        Me.animeQueue.Size = New System.Drawing.Size(614, 143)
        Me.animeQueue.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2500
        '
        'Anime_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Crunchyroll_Downloader.My.Resources.Resources.add_background
        Me.ClientSize = New System.Drawing.Size(630, 275)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.downloadButton)
        Me.Controls.Add(Me.initialSettingsGroup)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.episodeSelectionGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Anime_Add"
        Me.Text = "Add"
        Me.initialSettingsGroup.ResumeLayout(False)
        Me.initialSettingsGroup.PerformLayout()
        CType(Me.downloadButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.episodeSelectionGroup.ResumeLayout(False)
        CType(Me.cancelAddButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents animeUrl As TextBox
    Public WithEvents subfolderSelection As ComboBox
    Public WithEvents baseDirectoryTextBox As TextBox
    Public WithEvents animeName As TextBox
    Private WithEvents closeButton As PictureBox
    Public WithEvents StatusLabel As Label
    Public WithEvents Add_Display As Label
    Public WithEvents lastEpisodeSelector As ComboBox
    Public WithEvents seasonSelector As ComboBox
    Public WithEvents firstEpisodeSelector As ComboBox
    Public WithEvents downloadButton As PictureBox
    Public WithEvents episodeSelectionGroup As GroupBox
    Public WithEvents cancelAddButton As PictureBox
    Public WithEvents initialSettingsGroup As GroupBox
    Public WithEvents GroupBox3 As GroupBox
    Friend WithEvents animeQueue As ListBox
    Friend WithEvents Timer1 As Timer
    Private WithEvents Timer2 As Timer
End Class
