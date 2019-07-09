Imports System.ComponentModel

Public Class GameOver

    Dim score As String

    ' gets the score from the game and saves it. the tetris game form will also be closed to the game will be ready next time the form is opened. This also checks to see if this is a new high score

    Private Sub GameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        score = TetrisGame.lblScore.Text
        YourScore.Text = score
        If Int(score) > Int(My.Settings.HighScore) Then
            My.Settings.HighScore = score
            My.Settings.Save()
        End If
        payerHighscore.Text = My.Settings.HighScore

        TetrisGame.Close()
    End Sub

    ' changing a setiting to make sure the gaame resets next time. Is this still needed??
    Private Sub GameOver_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.GameOver = False
        My.Settings.Save()
    End Sub

    ' restarts the game at the users request'
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click
        TetrisGame.Show()
        TetrisGame.Button1_Click(sender, e)
        Me.Close()
    End Sub
End Class