<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Process1 = New Process()
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.OrangeRed
        Label1.Location = New Point(198, 72)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(553, 43)
        Label1.TabIndex = 0
        Label1.Text = "LIBRARY MANAGEMENT SYSTEM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(378, 158)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 141)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = SystemColors.MenuHighlight
        ProgressBar1.Location = New Point(13, 370)
        ProgressBar1.Margin = New Padding(4)
        ProgressBar1.MarqueeAnimationSpeed = 75
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(912, 16)
        ProgressBar1.Step = 25
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(406, 405)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 41)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Process1
        ' 
        Process1.StartInfo.Domain = ""
        Process1.StartInfo.LoadUserProfile = False
        Process1.StartInfo.Password = Nothing
        Process1.StartInfo.StandardErrorEncoding = Nothing
        Process1.StartInfo.StandardInputEncoding = Nothing
        Process1.StartInfo.StandardOutputEncoding = Nothing
        Process1.StartInfo.UseCredentialsForNetworkingOnly = False
        Process1.StartInfo.UserName = ""
        Process1.SynchronizingObject = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(933, 476)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        ForeColor = Color.OrangeRed
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Process1 As Process
    Friend WithEvents Timer2 As Timer

End Class
