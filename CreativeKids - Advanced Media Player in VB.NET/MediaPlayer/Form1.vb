Public Class Form1
    Public IsMediaPlaying As Boolean 'This will be used to determine whether our media file is playng or not

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If IsMediaPlaying = False Then
            ButtoPlayPause.Image = My.Resources.icon_play_48 'Sets the Play/Pause button to a play icon
        Else
            ButtoPlayPause.Image = My.Resources.icon_pause_48 'Sets the Play/Pause button to a pause icon
            LabelPos.Text = Player1.MediaElement1.Position.Duration.ToString 'Sets the labels text to the position of the media file
        End If
    End Sub

    Private Sub ButtoPlayPause_Click(sender As System.Object, e As System.EventArgs) Handles ButtoPlayPause.Click
        If IsMediaPlaying = False Then
            Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Plays the media file
            IsMediaPlaying = True 'Sets our "IsMediaPlaying" boolean to true because the mediastate has been set to play
        Else
            Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Pauses the media file
            IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to pause
        End If
    End Sub

    Private Sub ButtonStop_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStop.Click
        Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop 'Stops the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to stop
    End Sub

    Private Sub ButtonRew_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRew.Click
        Player1.MediaElement1.Position = Player1.MediaElement1.Position - TimeSpan.FromSeconds(10) 'Subtracts 10 seconds to the position of the media file
    End Sub

    Private Sub ButtonFstFrwrd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFstFrwrd.Click
        Player1.MediaElement1.Position = Player1.MediaElement1.Position + TimeSpan.FromSeconds(10) 'Adds 10 seconds to the position of the media file
    End Sub

    Private Sub ButtonOpen_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpen.Click
        Player1.OpenFile() 'Executes our "OpenFile" sub
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play 'Plays the media file
        IsMediaPlaying = True 'Sets our "IsMediaPlaying" boolean to true because the mediastate has been set to play
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause 'Pauses the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to pause
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Player1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop 'Stops the media file
        IsMediaPlaying = False 'Sets our "IsMediaPlaying" boolean to false because the mediastate has been set to stop
    End Sub

    Private Sub RewindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RewindToolStripMenuItem.Click
        Player1.MediaElement1.Position = Player1.MediaElement1.Position - TimeSpan.FromSeconds(10) 'Subtracts 10 seconds to the position of the media file
    End Sub

    Private Sub FastforwardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FastforwardToolStripMenuItem.Click
        Player1.MediaElement1.Position = Player1.MediaElement1.Position + TimeSpan.FromSeconds(10) 'Adds 10 seconds to the position of the media file
    End Sub

    Private Sub ExitMediaPlayerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitMediaPlayerToolStripMenuItem.Click
        End 'Ends the program (duh)
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Player1.OpenFile() 'Executes our "OpenFile" sub
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Player1.MediaElement1.SpeedRatio = TrackBar1.Value 'Sets the media file playing speed according to the value of the trackbar
        Speedvaluelabel.Text = "x" + TrackBar1.Value.ToString 'Displays the speed in string/text form
    End Sub

    Private Sub SpeedSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeedSettingsToolStripMenuItem.Click
        SpeedPanel.Show() 'Shows the panel to control the speed of the media file
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SpeedPanel.Hide() 'Hides the panel to control the speed of the media file
    End Sub

    'TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog() 'Shows the about dialog
    End Sub
    'TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD
End Class


'TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD

'I hope you enjoyed this project, please use this wisely and make sure you leave a back-link to my YouTube channel or website.
'Please SUBSCRIBE to my YouTube Channel : http://www.youtube.com/user/HDTechView

'TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD ----------- TECHVIEWHD