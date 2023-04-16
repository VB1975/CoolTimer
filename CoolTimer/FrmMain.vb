Public Class FrmMain

    Private timerHours As Integer = 0, timerMinutes As Integer = 0
    Private timerSeconds As Integer = 0, timerMilliseconds As Integer = 0

    Private Sub MnuFileStyleExit_Click(sender As Object, e As EventArgs) Handles MnuFileExit.Click

        Application.Exit()

    End Sub

    Private Sub TimTimer_Tick(sender As Object, e As EventArgs) Handles TimTimer.Tick

        timerHours = Val(Strings.Left(LblDisplay.Text, 2))
        timerMinutes = Val(Mid(LblDisplay.Text, 4, 2))

        If MnuFileStyleStopwatch.Checked Then
            TimTimer.Interval = 100
            timerSeconds = Val(Mid(LblDisplay.Text, 7, 2))
            timerMilliseconds = Val(Strings.Right(LblDisplay.Text, 2))
            timerMilliseconds += 1
            If timerMilliseconds > 9 Then
                timerMilliseconds = 0
                timerSeconds += 1
            End If
        Else
            TimTimer.Interval = 1000
            timerSeconds = Val(Strings.Right(LblDisplay.Text, 2))
            timerSeconds += 1
        End If

        If timerSeconds > 59 Then
            timerSeconds = 0 : timerMinutes += 1
        End If

        If timerMinutes > 59 Then
            timerMinutes = 0 : timerHours += 1
        End If

        Call FormatTimer()

    End Sub

    Private Sub FormatTimer()

        LblDisplay.Text = Format(timerHours, "00") & ":" & Format(timerMinutes, "00") & ":" & Format(timerSeconds, "00")
        If MnuFileStyleStopwatch.Checked Then
            LblDisplay.Text &= "." & Format(timerMilliseconds, "00")
        End If

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        TimTimer.Start()

    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click

        TimTimer.Stop()

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        timerHours = 0 : timerMinutes = 0 : timerSeconds = 0 : timerMilliseconds = 0
        Call FormatTimer()

    End Sub

    Private Sub SelectStyle(SelectedStyle As ToolStripMenuItem)

        Dim menuStrip As MenuStrip = MspTimer
        Dim fileMenuItem As ToolStripMenuItem = menuStrip.Items("MnuFile")

        If fileMenuItem.HasDropDownItems Then
            For Each subMenu As ToolStripMenuItem In fileMenuItem.DropDownItems
                If subMenu.Text = "&Style" Then
                    For Each menuItem As ToolStripMenuItem In subMenu.DropDownItems
                        menuItem.Checked = False
                    Next
                End If
            Next
        End If

        SelectedStyle.Checked = True
        Call FormatTimer()

    End Sub

    Private Sub MnuFileStyleStopwatch_Click(sender As Object, e As EventArgs) Handles MnuFileStyleStopwatch.Click

        SelectStyle(MnuFileStyleStopwatch)

    End Sub

    Private Sub MnuFileStyleTimer_Click(sender As Object, e As EventArgs) Handles MnuFileStyleTimer.Click

        SelectStyle(MnuFileStyleTimer)

    End Sub

    Private Sub MnuFileStyleCountdown_Click(sender As Object, e As EventArgs) Handles MnuFileStyleCountdown.Click

        SelectStyle(MnuFileStyleCountdown)

    End Sub
End Class
