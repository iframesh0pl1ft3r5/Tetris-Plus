' this code is used to display the IframeShoplifters splash screen.
' If you dont want to see the splash screen then change the load form to Welcome.vb




Imports System.ComponentModel
Imports System.IO.Compression
Public Class load

    ' save the video so it is ready
    Private Sub load_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        Timer1.Start()

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\ifs-load.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ifs-load.zip")
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\ifs-load.mp4") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ifs-load.mp4")
        End If
        savefromresources(Application.StartupPath & "\ifs-load.zip", My.Resources.ifs_load)
        ZipFile.ExtractToDirectory(Application.StartupPath & "\ifs-load.zip", Application.StartupPath & "\")
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\ifs-load.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ifs-load.zip")
        End If
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "\ifs-load.mp4"
    End Sub

    ' allows the video to be saved from the resources
    Public Sub savefromresources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    ' closes the form after 6s evven if the video hasn't played.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Welcome.Show()
        Me.Close()
    End Sub

    ' tidies up the files saved before
    Private Sub load_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\ifs-load.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\ifs-load.zip")
        End If
    End Sub
End Class