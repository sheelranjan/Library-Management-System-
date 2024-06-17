<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Label7 = New Label()
        Role = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Role)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1289, 534)
        Panel1.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SeaGreen
        Label7.Location = New Point(83, 372)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 35)
        Label7.TabIndex = 7
        Label7.Text = "Address -"
        ' 
        ' Role
        ' 
        Role.FormattingEnabled = True
        Role.Items.AddRange(New Object() {"Librarian ", "Student"})
        Role.Location = New Point(922, 378)
        Role.Name = "Role"
        Role.Size = New Size(182, 33)
        Role.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SeaGreen
        Label6.Location = New Point(592, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(268, 35)
        Label6.TabIndex = 5
        Label6.Text = "Confirm Password - "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SeaGreen
        Label5.Location = New Point(686, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 35)
        Label5.TabIndex = 4
        Label5.Text = "Password - "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SeaGreen
        Label4.Location = New Point(689, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 35)
        Label4.TabIndex = 3
        Label4.Text = "Username -"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SeaGreen
        Label3.Location = New Point(92, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 35)
        Label3.TabIndex = 2
        Label3.Text = "Email -"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SeaGreen
        Label2.Location = New Point(65, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 35)
        Label2.TabIndex = 1
        Label2.Text = "Last Name -"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SeaGreen
        Label1.Location = New Point(59, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 35)
        Label1.TabIndex = 0
        Label1.Text = "First Name -"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightSteelBlue
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.WindowText
        TextBox1.Location = New Point(245, 86)
        TextBox1.MaxLength = 25
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(285, 39)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightSteelBlue
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.WindowText
        TextBox2.Location = New Point(245, 164)
        TextBox2.MaxLength = 25
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(285, 39)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.LightSteelBlue
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.WindowText
        TextBox3.Location = New Point(245, 372)
        TextBox3.MaxLength = 25
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(285, 39)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.LightSteelBlue
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = SystemColors.WindowText
        TextBox4.Location = New Point(245, 255)
        TextBox4.MaxLength = 25
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(285, 39)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.LightSteelBlue
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = SystemColors.WindowText
        TextBox5.Location = New Point(922, 90)
        TextBox5.MaxLength = 25
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(285, 39)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.LightSteelBlue
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Cursor = Cursors.IBeam
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.ForeColor = SystemColors.WindowText
        TextBox6.Location = New Point(922, 284)
        TextBox6.MaxLength = 25
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(285, 39)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.LightSteelBlue
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.ForeColor = SystemColors.WindowText
        TextBox7.Location = New Point(922, 180)
        TextBox7.MaxLength = 25
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(285, 39)
        TextBox7.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Small", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SeaGreen
        Label8.Location = New Point(752, 376)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 35)
        Label8.TabIndex = 15
        Label8.Text = "Role - "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(1313, 526)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Role As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
