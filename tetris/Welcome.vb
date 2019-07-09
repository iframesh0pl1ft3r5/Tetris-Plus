Imports System.ComponentModel
Imports System.IO.Compression
Public Class Welcome

    ' deletes the ifs-load mp4 file and makes sure the gameover setting is false. 
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.GameOver = False
        My.Settings.Save()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\ifs-load.mp4") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ifs-load.mp4")
        End If

    End Sub

    ' opens the tetris game form and runs the game
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        TetrisGame.Show()
        TetrisGame.Button1_Click(sender, e)
        Me.Close()
    End Sub
End Class