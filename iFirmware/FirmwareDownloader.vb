Imports System.IO
Public Class FirmwareDownloader

    Private Sub FirmwareDownloader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.Enabled = False
        ComboBox1.Text = "Please select an iOS version and model"
    End Sub

    Private Sub FirmwareDownloader_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Welcome.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Text = "Downloading iOS - iFirmware"
        LabelX1.Text = "Downloading iOS - " & ComboBox1.Text.ToString
        LabelX2.Text = "Please be patient while we dowload the firmware"
        ComboBox1.Enabled = False
        Button1.Enabled = False
        Label1.Visible = True
        ProgressBar1.Visible = True

        ' We do this like a fine British chap.

        ' ########## Apple TV 2 (iOS 4.1) [8M89] ##########
        If ComboBox1.Text = "Apple TV 2 (iOS 4.1) [8M89]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.1_8M89_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()
            End If
        End If

        If ComboBox1.Text = "Apple TV 2 (iOS 4.2.1) [8C154]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.2.1_8C154_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()

            End If
        End If

        If ComboBox1.Text = "Apple TV 2 (iOS 4.3) [8F191m]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.3_8F191m_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()

            End If
        End If

        If ComboBox1.Text = "Apple TV 2 (iOS 5.1) [10A406e]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_5.1_10A406e_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()

            End If
        End If

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles iFirmwareBGRunner.DoWork
        ' The do nothing - thing
        If ComboBox1.Text = "Please select an iOS version and model" Then
        End If
        If ComboBox1.Text = "" Then
        End If
        ' #####################


        ' ######### The download process ##########

        If ComboBox1.Text = "Apple TV 2 (iOS 4.1) [8M89]" Then
            My.Computer.Network.DownloadFile("http://appldnld.apple.com/AppleTV/061-8940.20100926.Tvtnz/AppleTV2,1_4.1_8M89_Restore.ipsw", "C:\iFirmware\AppleTV2,1_4.1_8M89_Restore.ipsw")
        End If
        If ComboBox1.Text = "Apple TV 2 (iOS 4.2.1) [8C154]" Then
            My.Computer.Network.DownloadFile("http://appldnld.apple.com/AppleTV/061-9978.20101214.gmabr/AppleTV2,1_4.2.1_8C154_Restore.ipsw", "C:\iFirmware\AppleTV2,1_4.2.1_8C154_Restore.ipsw")
        End If



        If ComboBox1.Text = "Apple TV 2 (iOS 4.3) [8F191m]" Then
            My.Computer.Network.DownloadFile("http://appldnld.apple.com/AppleTV/061-9584.20110308.Cxdew/AppleTV2,1_4.3_8F191m_Restore.ipsw", "C:\iFirmware\AppleTV2,1_4.3_8F191m_Restore.ipsw")
        End If


        If ComboBox1.Text = "Apple TV 2 (iOS 5.1) [10A406e]" Then
            My.Computer.Network.DownloadFile("http://appldnld.apple.com/AppleTV/041-0803.20120924.LOop5/AppleTV2,1_5.1_10A406e_Restore.ipsw", "C:\iFirmware\AppleTV2,1_5.1_10A406e_Restore.ipsw")
        End If





    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles iFirmwareBGRunner.RunWorkerCompleted
        Me.Text = "Download completed - iFirmware"
        LabelX1.Text = "Download completed!"
        LabelX2.Text = "The selected iOS version was downloaded"
        Label1.Text = "Download completed!"
        MsgBox("Completed download for " & ComboBox1.Text.ToString & ". Saved to C:\iFirmware .")
        Me.Text = "Select iOS - iFirmware"
        LabelX1.Text = "Select iOS"
        LabelX2.Text = "Select a specific iOS version you wish to download"
        ComboBox1.Enabled = True
        Button1.Enabled = True
        Label1.Visible = False
        ProgressBar1.Visible = False
        Label1.Text = "Progress..."
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://iosdl.com")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "Please select an iOS version and model" Then
        Else
            LabelX3.Text = ComboBox1.Text.ToString
        End If
    End Sub

End Class
