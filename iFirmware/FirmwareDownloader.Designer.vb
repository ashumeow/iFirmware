<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirmwareDownloader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirmwareDownloader))
        Me.Label2 = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SelectedFirmwareLabel1 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.ProgressLabel1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.iFirmwareBGRunner = New System.ComponentModel.BackgroundWorker()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        '
        '
        '
        Me.Label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(98, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select a specific iOS version you wish to download"
        Me.Label2.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'Label1
        '
        '
        '
        '
        Me.Label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(98, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select iOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SelectedFirmwareLabel1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 97)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'SelectedFirmwareLabel1
        '
        '
        '
        '
        Me.SelectedFirmwareLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SelectedFirmwareLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedFirmwareLabel1.ForeColor = System.Drawing.Color.Black
        Me.SelectedFirmwareLabel1.Location = New System.Drawing.Point(6, 12)
        Me.SelectedFirmwareLabel1.Name = "SelectedFirmwareLabel1"
        Me.SelectedFirmwareLabel1.Size = New System.Drawing.Size(344, 23)
        Me.SelectedFirmwareLabel1.TabIndex = 11
        Me.SelectedFirmwareLabel1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Apple TV 2 (iOS 4.1) [8M89]", "Apple TV 2 (iOS 4.2.1) [8C154]", "Apple TV 2 (iOS 4.3) [F191m]", "Apple TV 2 (iOS 5.1) [10A406e]"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(344, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(348, 279)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(116, 23)
        Me.DownloadButton.TabIndex = 7
        Me.DownloadButton.Text = "&Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'ProgressLabel1
        '
        Me.ProgressLabel1.AutoSize = True
        Me.ProgressLabel1.Location = New System.Drawing.Point(105, 305)
        Me.ProgressLabel1.Name = "ProgressLabel1"
        Me.ProgressLabel1.Size = New System.Drawing.Size(57, 13)
        Me.ProgressLabel1.TabIndex = 8
        Me.ProgressLabel1.Text = "Progress..."
        Me.ProgressLabel1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(108, 321)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(356, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'iFirmwareBGRunner
        '
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 375)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(184, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Download links provided by iosdl.com"
        '
        'FirmwareDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 397)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ProgressLabel1)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirmwareDownloader"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select iOS - iFirmware"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents ProgressLabel1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents iFirmwareBGRunner As System.ComponentModel.BackgroundWorker
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SelectedFirmwareLabel1 As DevComponents.DotNetBar.LabelX
End Class
