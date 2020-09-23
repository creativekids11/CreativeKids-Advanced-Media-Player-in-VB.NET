Public Class UserControl1
    Public opendlg As New OpenFileDialog 'An openfiledialog (duh)
    Public Sub OpenFile()
        Form1.Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Sets the mediastate to pause
        Form1.IsMediaPlaying = False 'Sets the boolean to false because the media file is no longer playing
        Form1.Refresh() 'Helps keep it fresh ;)
        If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Form1.Refresh() 'Again ^^^
            Form1.Player1.MediaElement1.Source = New Uri(opendlg.FileName) 'Loads the media file selected by the user
            Form1.Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Sets the mediastate to play
            Form1.IsMediaPlaying = True 'Sets the boolean to true because the media file is now playing
            Dim NameSongTxt As String = IO.Path.GetFileNameWithoutExtension(opendlg.FileName) 'Gets the name of the file (which is most likely to be the name of the song)
            Form1.LabelMediaName.Text = NameSongTxt 'Sets the label on Form1 to the name of the song
            Form1.LabelPos.Text = "00:00:00" 'Sets the text of the label on Form1 to nothing, just to refresh ;)
        End If
    End Sub

    Private Sub MediaElement1_BufferingEnded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingEnded
        Form1.LabelStatus.Hide() 'Hides our status label
    End Sub

    Private Sub MediaElement1_BufferingStarted(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingStarted
        Form1.LabelStatus.Text = "Buffering..." 'Sets our status text to buffering ^^^ you know why :|
        Form1.LabelStatus.Show() 'Shows our status label
    End Sub

    Private Sub MediaElement1_MediaFailed(sender As Object, e As System.Windows.ExceptionRoutedEventArgs) Handles MediaElement1.MediaFailed
        Form1.LabelStatus.Text = "Media failed to open..." 'Sets our status label text to Media file opened because...well...it opened? :P
        Form1.LabelStatus.Show() 'Shows our status label
    End Sub

    Private Sub MediaElement1_MediaOpened(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.MediaOpened
        Form1.LabelStatus.Hide() 'Hides our status label
    End Sub
End Class
