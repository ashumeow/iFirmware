Imports System.IO
Public Class Welcome

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelX2.Text = My.Application.Info.Version.ToString
        LabelX3.Text = My.Application.Info.Copyright.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FirmwareDownloader.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://deavmi.github.io/Deavmi")
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles GetFirmwaresListAndDisplay.DoWork
        If File.Exists("firmwares_list.txt") Then
            File.Delete("firmwares_list.txt")
            My.Computer.Network.DownloadFile("https://deavmi.github.io/iFirmware/firmwares/list.txt", "firmwares_list.txt")
            Process.Start("firmwares_list.txt")
        Else
            My.Computer.Network.DownloadFile("https://deavmi.github.io/iFirmware/firmwares/list.txt", "firmwares_list.txt")
            Process.Start("firmwares_list.txt")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GetFirmwaresListAndDisplay.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("https://deavmi.github.io/iFirmware")
    End Sub
End Class

