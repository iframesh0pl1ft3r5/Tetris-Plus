' iframeshoplifers team 2019
Imports System.IO
Imports System.ComponentModel
Imports System.IO.Compression
Public Class TetrisGame

    Private score As Integer = 0

    'sets up DGVs
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\music.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\music.zip")
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\tetris.wav") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\tetris.wav")
        End If
        savefromresources(Application.StartupPath & "\music.zip", My.Resources.tetris1)
        ZipFile.ExtractToDirectory(Application.StartupPath & "\music.zip", Application.StartupPath & "\")
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\music.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\music.zip")
        End If
        If My.Settings.PlayMusic = True Then
            My.Computer.Audio.Play(Application.StartupPath & "\tetris.wav", AudioPlayMode.BackgroundLoop)
        End If

        For x As Integer = 1 To 20
            game.Columns.Add(New DataGridViewTextBoxColumn())
            game.Columns(x - 1).Width = 15
            If x < 7 Then
                ShapePreview1.Columns.Add(New DataGridViewTextBoxColumn())
                ShapePreview1.Columns(x - 1).Width = 15
            End If
        Next
        ShapePreview1.Rows.Add(6)
        game.Rows.Add(30)
        For x As Integer = 1 To 30
            game.Rows(x - 1).Height = 15
            If x < 7 Then
                ShapePreview1.Rows(x - 1).Height = 15
            End If
        Next
        'TextBox1.BackColor = Color.FromArgb(255, 55, 71, 79)
        'TextBox1.ForeColor = Color.White
        PlayMusic.Checked = My.Settings.PlayMusic
    End Sub

    'removes focus from DGVs
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShapePreview1.CurrentCell = Nothing
        ShapePreview1.ShowCellToolTips = False
        game.CurrentCell = Nothing
        game.ShowCellToolTips = False
    End Sub

    'renders game form
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim points() As Point = {game.Location, New Point(game.Left, game.Bottom), New Point(game.Right, game.Bottom), New Point(game.Right, game.Top)}
        Dim silverPen As New Pen(Color.Silver, 2)
        e.Graphics.DrawLines(silverPen, points)
        e.Graphics.DrawLine(silverPen, game.Right + 2, game.Bottom - 212, game.Right + 2, game.Bottom + 1) 'left
        e.Graphics.DrawLine(silverPen, game.Right + 1, game.Bottom - 213, game.Right + 126, game.Bottom - 213) 'top
        e.Graphics.DrawLine(silverPen, game.Right + 2, game.Bottom, game.Right + 125, game.Bottom) 'bottom
        e.Graphics.DrawLine(silverPen, game.Right + 125, game.Bottom - 212, game.Right + 125, game.Bottom + 1) 'right
        Dim xPosition As Integer = game.Right + 4
        Dim yPosition As Integer = game.Bottom - 16
        Dim cellLines() As Integer = {1, 2, 9, 10, 13, 14}
        For y As Integer = 1 To 14
            If cellLines.Contains(y) Then
                For x As Integer = 0 To 7
                    e.Graphics.FillRectangle(Brushes.Silver, New Rectangle(xPosition + (x * 15), yPosition, 14, 14))
                Next
            Else
                e.Graphics.FillRectangle(Brushes.Silver, New Rectangle(xPosition, yPosition, 14, 14))
                e.Graphics.FillRectangle(Brushes.Silver, New Rectangle(xPosition + (7 * 15), yPosition, 14, 14))
            End If
            yPosition -= 15
        Next
    End Sub

    'initiates new game
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        lblScore.Text = score.ToString("000000")
        game.newGame()
    End Sub

    'increases score and updates score display
    Private Sub game_IncrementScore(newPoints As Integer) Handles game.IncrementScore
        score += newPoints
        lblScore.Text = score.ToString("000000")
    End Sub

    'updates shape preview
    Private Sub game_ShapeChanged(shapePoints() As Point, shapeColor As String) Handles game.ShapeChanged
        Dim pts() As Point = DirectCast(shapePoints.Clone, Point())
        For y As Integer = 0 To 5
            For x As Integer = 0 To 5
                ShapePreview1.Rows(y).Cells(x).Style.BackColor = Color.FromArgb(255, 55, 71, 79)
            Next
        Next
        Dim minX As Integer = pts.Min(Function(p) p.X)
        Dim minY As Integer = pts.Min(Function(p) p.Y)
        For x As Integer = 0 To pts.GetUpperBound(0)
            pts(x).Offset(-minX, -minY)
        Next
        Dim w As Integer = pts.Max(Function(p) p.X) - pts.Min(Function(p) p.X)
        Dim h As Integer = pts.Max(Function(p) p.Y) - pts.Min(Function(p) p.Y)
        Dim offSetX As Integer = Math.Floor((6 - w) / 2)
        Dim offSetY As Integer = Math.Floor((6 - h) / 2)
        Dim colors As New Dictionary(Of String, Color) From {{"R", Color.Red}, {"G", Color.Green}, {"B", Color.Blue}, {"Y", Color.Yellow}}
        For x As Integer = 0 To pts.GetUpperBound(0)
            pts(x).Offset(offSetX, offSetY)
            ShapePreview1.Rows(pts(x).Y).Cells(pts(x).X).Style.BackColor = colors(shapeColor)
        Next
        game.Focus()
        game.CurrentCell = Nothing
    End Sub


    ' allows the music stored In the exe To be saved To a file so it can be played.
    Public Sub savefromresources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    ' tidies up the gaame so there are not many files left behind
    Private Sub TetrisGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\music.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\music.zip")
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\tetris.wav") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\tetris.wav")
        End If
        My.Computer.Audio.Stop()
    End Sub

    ' enables or disables the music depending on the users preference. This is saved in a setting so the next time the program loads it can remember the users choice.
    Private Sub PlayMusic_CheckedChanged(sender As Object, e As EventArgs) Handles PlayMusic.CheckedChanged
        If PlayMusic.CheckState = 1 Then
            My.Settings.PlayMusic = True
            My.Computer.Audio.Play(Application.StartupPath & "\tetris.wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Settings.PlayMusic = False
            My.Computer.Audio.Stop()
        End If
        My.Settings.Save()
    End Sub
End Class
