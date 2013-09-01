Imports System.IO
Public Class FirmwareDownloader

    Private Sub FirmwareDownloader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Disable the welcome form
        Welcome.Enabled = False
        'Set the Combobox1's text 'value/text' to "Please select an iOS version and model"
        ComboBox1.Text = "Please select an iOS version and model"
    End Sub

    Private Sub FirmwareDownloader_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Re-enable the welcome form
        Welcome.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadButton.Click
        'Doing some UI (User interface) things here. Gotta' look pretty.
        Me.Text = "Downloading iOS - iFirmware"
        Label1.Text = "Downloading iOS - " & ComboBox1.Text.ToString
        Label2.Text = "Please be patient while we dowload the firmware"
        ComboBox1.Enabled = False
        DownloadButton.Enabled = False
        ProgressLabel1.Visible = True
        ProgressBar1.Visible = True

        ' We do this like a fine British chap.

        ' ########## Apple TV 2 (iOS 4.1) [8M89] ##########

        '<<<<<< Apple TV 2 (iOS 4.1) [8M89] >>>>>>
        If ComboBox1.Text = "Apple TV 2 (iOS 4.1) [8M89]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.1_8M89_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()
            End If
        End If

        '<<<<<< Apple TV 2 (iOS 4.2.1) [8C154] >>>>>>
        If ComboBox1.Text = "Apple TV 2 (iOS 4.2.1) [8C154]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.2.1_8C154_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()
            End If
        End If

        '<<<<<< Apple TV 2 (iOS 4.3) [8F191m] >>>>>>
        If ComboBox1.Text = "Apple TV 2 (iOS 4.3) [8F191m]" Then
            If File.Exists("C:\iFirmware\AppleTV2,1_4.3_8F191m_Restore.ipsw") Then
                FileChecksNotifier.Show()
            Else
                iFirmwareBGRunner.RunWorkerAsync()
            End If
        End If

        '<<<<<< Apple TV 2 (iOS 5.1) [10A406e] >>>>>>
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
        'Doing some UI (User interface) things here. Gotta' look pretty.
        Me.Text = "Download completed - iFirmware"
        Label1.Text = "Download completed!"
        Label2.Text = "The selected iOS version was downloaded"
        ProgressLabel1.Text = "Download completed!"
        MsgBox("Completed download for " & ComboBox1.Text.ToString & ". Saved to C:\iFirmware .")
        Me.Text = "Select iOS - iFirmware"
        Label1.Text = "Select iOS"
        Label2.Text = "Select a specific iOS version you wish to download"
        ComboBox1.Enabled = True
        DownloadButton.Enabled = True
        ProgressLabel1.Visible = False
        ProgressBar1.Visible = False
        ProgressLabel1.Text = "Progress..."
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Opens the following URL = "http://iosdl.com"
        Process.Start("http://iosdl.com")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        'Whenever the Comboxbox1's 'value/text' changes we take the text in the Comboxbox1 and set it as the 'text/value' for 'Label3'
        If ComboBox1.Text = "Please select an iOS version and model" Then
        Else
            SelectedFirmwareLabel1.Text = ComboBox1.Text.ToString
        End If
    End Sub

End Class
