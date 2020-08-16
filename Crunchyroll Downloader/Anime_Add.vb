Imports Microsoft.Win32
Imports Gecko
Imports System.IO
Imports Crunchyroll_Downloader.Common

Public Class Anime_Add
    Public Mass_DL_Cancel As Boolean = False
    Public List_DL_Cancel As Boolean = False

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subfolderSelection.SelectedIndexChanged
        Try
            SetRegistryValue("SubFolder_Value", subfolderSelection.Text, RegistryValueKind.String)
        Catch ex As Exception
            subfolderSelection.Text = Main.SubFolder_Nothing
        End Try
    End Sub

    Private Sub Anime_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Try
            For i As Integer = 0 To Main.ListBoxList.Count - 1
                animeQueue.Items.Add(Main.ListBoxList.Item(i))

            Next
        Catch ex As Exception

        End Try
        Try
            Main.waveOutSetVolume(0, 0)
        Catch ex As Exception

        End Try
        Me.Location = New Point(Main.Location.X + Main.Width / 2 - Me.Width / 2, Main.Location.Y + Main.Height / 2 - Me.Height / 2)
        Me.baseDirectoryTextBox.Text = Main.baseDirectory

        Dim SubFolder_Value As String

        subfolderSelection.Items.Add(Main.SubFolder_automatic)
        subfolderSelection.Items.Add(Main.SubFolder_Nothing)

        SubFolder_Value = GetRegistryValue("SubFolder_Value")

        If (SubFolder_Value IsNot Nothing) And (SubFolder_Value IsNot Main.SubFolder_Nothing) And (SubFolder_Value IsNot Main.SubFolder_automatic) Then
            subfolderSelection.Items.Add(SubFolder_Value)
        Else
            subfolderSelection.SelectedItem = Main.SubFolder_Nothing
            SubFolder_Value = Main.SubFolder_Nothing
        End If


        Try
            For Each subDirectory In Main.baseDirectory.EnumerateDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly)
                If subDirectory.Attributes.HasFlag(System.IO.FileAttributes.Hidden) = False Then
                    subfolderSelection.Items.Add(subDirectory.Name)
                End If
            Next
            Dim Result As New List(Of String)
            'Jeder Eintrag in der Combobox durchgehen
            For Each item As String In subfolderSelection.Items
                'Wenn der Combobox-Eintrag noch nicht in der Result-List vorhanden ist, Eintrag der Result-List hinzufügen
                If Result.Contains(item) = False Then
                    Result.Add(item)
                End If
            Next
            'In der Result-List sind jetzt alle Einträge einmal vorhanden
            'Combobox leeren
            subfolderSelection.Items.Clear()
            'Die Result-List der Combobox hinzufügen
            subfolderSelection.Items.AddRange(Result.ToArray)
            subfolderSelection.SelectedItem = SubFolder_Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox4_DoubleClick(sender As Object, e As EventArgs) Handles baseDirectoryTextBox.DoubleClick
        Dim FolderBrowserDialog1 As New FolderBrowserDialog()

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            subfolderSelection.Items.Clear()
            Main.baseDirectory = FolderBrowserDialog1.SelectedPath
            SetRegistryValue("Ordner", Main.baseDirectory, RegistryValueKind.String)

            subfolderSelection.Items.Add(Main.SubFolder_automatic)
            subfolderSelection.Items.Add(Main.SubFolder_Nothing)
            subfolderSelection.SelectedItem = Main.SubFolder_Nothing
            baseDirectoryTextBox.Text = Main.baseDirectory
            Try
                For Each subDirectory As System.IO.DirectoryInfo In Main.baseDirectory.EnumerateDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly)
                    If subDirectory.Attributes.HasFlag(System.IO.FileAttributes.Hidden) Then
                    Else
                        subfolderSelection.Items.Add(subDirectory.Name)
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub

#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub


#End Region
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles closeButton.MouseEnter
        closeButton.BackColor = SystemColors.Control
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles closeButton.MouseLeave
        closeButton.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        If animeQueue.Items.Count > 0 Then
            Main.ListBoxList.Clear()
            For i As Integer = 0 To animeQueue.Items.Count - 1
                Main.ListBoxList.Add(animeQueue.Items.Item(i))
            Next
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles downloadButton.Click
        Main.LoginOnly = LoginMode.DOWNLOAD_MODE
        If initialSettingsGroup.Visible = True Then
            Try
                If InStr(animeUrl.Text, "crunchyroll.com") Or InStr(animeUrl.Text, "funimation.com") Then
                    If StatusLabel.Text = "Status: waiting for episode selection" Then
                        If MessageBox.Show("Are you sure you want cancel the advanced download?", "confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            StatusLabel.Text = "Status: idle"
                        Else
                            Exit Sub
                        End If
                    Else
                        If Main.RunningDownloads >= Main.MaxDL Then
                            animeQueue.Items.Add(animeUrl.Text)
                            animeUrl.ForeColor = Color.FromArgb(9248044)
                            Main.Pause(1)
                            animeUrl.ForeColor = Color.Black
                            animeUrl.Text = "URL"
                        Else
                            If Main.Grapp_RDY = True Then
                                GeckoFX.WebBrowser1.Navigate(animeUrl.Text)
                                StatusLabel.Text = "Status: looking for video file"
                                Main.b = False
                            End If
                        End If
                    End If
                ElseIf InStr(animeUrl.Text, "Test=true") Then
                    GeckoFX.WebBrowser1.Navigate(animeUrl.Text)
                Else
                    If MessageBox.Show("This in NOT a Crunchyroll or Funimation URL, try anyway?", "confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim FileLocation As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
                        Dim CurrentFile As String = Nothing
                        If File.Exists(Path.Combine(Application.StartupPath, "gecko-network.txt")) Then
                            CurrentFile = Path.Combine(Application.StartupPath, "gecko-network.txt")
                        End If


                        If CurrentFile IsNot Nothing Then
                            File.Delete(CurrentFile)
                        End If
                        Main.LogBrowserData = True
                        GeckoPreferences.Default("logging.config.LOG_FILE") = "gecko-network.txt"
                        GeckoPreferences.Default("logging.nsHttp") = 3
                        GeckoFX.WebBrowser1.Navigate(animeUrl.Text)
                        StatusLabel.Text = "Status: looking for non CR video file"
                        Main.b = False
                    Else
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.ToString)
                Main.b = True
                MsgBox(Main.URL_Invaild, MsgBoxStyle.OkOnly)
            End Try
        ElseIf episodeSelectionGroup.Visible = True Then
            If Mass_DL_Cancel = True Then
                Mass_DL_Cancel = False
                GroupBox3.Visible = False
                episodeSelectionGroup.Visible = False
                Main.Grapp_Abord = True
                Main.b = True
                initialSettingsGroup.Visible = True
                downloadButton.Image = My.Resources.main_button_download_default
            Else
                StatusLabel.Text = "Status: idle"
                downloadButton.Image = My.Resources.add_mass_running_cancel
                Mass_DL_Cancel = True
                cancelAddButton.Enabled = False
                cancelAddButton.Visible = False
                Main.MassDL()
                lastEpisodeSelector.Enabled = False
                firstEpisodeSelector.Enabled = False
                seasonSelector.Enabled = False
            End If
        ElseIf GroupBox3.Visible = True Then
            GroupBox3.Visible = False
            episodeSelectionGroup.Visible = False
            initialSettingsGroup.Visible = True
            List_DL_Cancel = False
            downloadButton.Image = My.Resources.main_button_download_default
        End If
        If InStr(My.Computer.Info.OSFullName, "Server") Then
            MsgBox("Windows Server is not supported!", MsgBoxStyle.Critical)
            Me.Close()
        End If
        downloadButton.Enabled = True
    End Sub



    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles seasonSelector.DrawItem, subfolderSelection.DrawItem, firstEpisodeSelector.DrawItem, lastEpisodeSelector.DrawItem
        sender.BackColor = Color.White
        If e.Index >= 0 Then
            Using st As New StringFormat With {.Alignment = StringAlignment.Center}
                ' e.DrawBackground()
                ' e.DrawFocusRectangle()
                e.Graphics.FillRectangle(SystemBrushes.ControlLightLight, e.Bounds)
                e.Graphics.DrawString(sender.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, st)

            End Using
        End If
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles downloadButton.MouseEnter
        If Mass_DL_Cancel = True Then
            downloadButton.Image = My.Resources.add_mass_running_cancel_hover
        ElseIf List_DL_Cancel = True Then
            downloadButton.Image = My.Resources.add_mass_running_cancel_hover

        Else
            downloadButton.Image = My.Resources.main_button_download_hovert
        End If

    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles downloadButton.MouseLeave
        If Mass_DL_Cancel = True Then
            downloadButton.Image = My.Resources.add_mass_running_cancel
        ElseIf List_DL_Cancel = True Then
            downloadButton.Image = My.Resources.add_mass_running_cancel
        Else
            downloadButton.Image = My.Resources.main_button_download_default
        End If

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles animeUrl.Click
        If animeUrl.Text = "URL" Then
            animeUrl.Text = Nothing
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles cancelAddButton.Click
        initialSettingsGroup.Visible = True
        episodeSelectionGroup.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seasonSelector.SelectedIndexChanged
        firstEpisodeSelector.Items.Clear()
        lastEpisodeSelector.Items.Clear()
        Dim SeasonDropdownAnzahl As String() = Main.WebbrowserText.Split(New String() {"season-dropdown content-menu block"}, System.StringSplitOptions.RemoveEmptyEntries)
        Array.Reverse(SeasonDropdownAnzahl)
        Dim SDV As Integer = 0
        For i As Integer = 0 To SeasonDropdownAnzahl.Count - 1
            If InStr(SeasonDropdownAnzahl(i), Chr(34) + ">" + seasonSelector.SelectedItem.ToString + "</a>") Then
                SDV = i
            End If
        Next
        Dim Anzahl As String() = SeasonDropdownAnzahl(SDV).Split(New String() {"wrapper container-shadow hover-classes"}, System.StringSplitOptions.RemoveEmptyEntries)
        Array.Reverse(Anzahl)
        For i As Integer = 0 To Anzahl.Count - 2
            Dim URLGrapp As String() = Anzahl(i).Split(New String() {"title=" + Chr(34)}, System.StringSplitOptions.RemoveEmptyEntries)

            Dim URLGrapp2 As String() = URLGrapp(1).Split(New String() {Chr(34)}, System.StringSplitOptions.RemoveEmptyEntries)

            firstEpisodeSelector.Items.Add(URLGrapp2(0))
            lastEpisodeSelector.Items.Add(URLGrapp2(0))
        Next
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles cancelAddButton.MouseEnter
        cancelAddButton.Image = My.Resources.add_mass_cancel_hover
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles cancelAddButton.MouseLeave
        cancelAddButton.Image = My.Resources.add_mass_cancel
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If animeQueue.Items.Count > 0 Then
            If StatusLabel.Text = "Status: idle" Then
                StatusLabel.Text = "Status: items in queue, click to work off."
            End If
        End If
    End Sub


#Region "Listbox"

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (GroupBox3.Visible = True) And (animeQueue.Items.Count = 0) Then
            GroupBox3.Visible = False
            episodeSelectionGroup.Visible = False
            initialSettingsGroup.Visible = True
            List_DL_Cancel = False
            downloadButton.Image = My.Resources.main_button_download_default
        End If
        If (Main.RunningDownloads < Main.MaxDL) And (animeQueue.Items.Count > 0) And (GroupBox3.Visible = True) Then
            If InStr(animeQueue.GetItemText(animeQueue.Items(0)), "funimation.com") Then
                If Main.Funimation_Grapp_RDY = True Then
                    GeckoFX.WebBrowser1.Navigate(animeQueue.GetItemText(animeQueue.Items(0)))
                    animeQueue.Items.Remove(animeQueue.Items(0))
                    Main.Funimation_Grapp_RDY = False
                    Main.b = False
                End If

            Else
                If Main.Grapp_RDY = True Then
                    GeckoFX.WebBrowser1.Navigate(animeQueue.GetItemText(animeQueue.Items(0)))
                    animeQueue.Items.Remove(animeQueue.Items(0))
                    Main.Grapp_RDY = False
                    Main.b = False
                End If
            End If
        End If

    End Sub
    Private Sub StatusLabel_Click(sender As Object, e As EventArgs) Handles StatusLabel.Click
        If StatusLabel.Text = "Status: items in queue, click to work off." Then
            initialSettingsGroup.Visible = False
            episodeSelectionGroup.Visible = False
            GroupBox3.Visible = True
            downloadButton.Image = My.Resources.add_mass_running_cancel
            List_DL_Cancel = True
        End If

    End Sub


    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles animeName.Click
        If animeName.Text = "Name of the Anime" Then
            animeName.Text = Nothing
        End If
    End Sub


    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles animeQueue.DoubleClick
        animeQueue.Items.Remove(animeQueue.SelectedItem)
    End Sub
#End Region

End Class