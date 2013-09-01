Public Class Welcome

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelX2.Text = My.Application.Info.Version.ToString
        LabelX3.Text = My.Application.Info.Copyright.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FirmwareDownloader.Show()
    End Sub
End Class
