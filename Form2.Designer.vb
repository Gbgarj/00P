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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        LastName = New TextBox()
        Firstname = New TextBox()
        Label3 = New Label()
        CreatePass = New TextBox()
        Label5 = New Label()
        ValidPassword = New TextBox()
        Label6 = New Label()
        ValidUsername = New TextBox()
        Label7 = New Label()
        Button2 = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 27)
        Label1.TabIndex = 2
        Label1.Text = "SIGN UP"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 3
        Label2.Text = "Last Name"
        ' 
        ' LastName
        ' 
        LastName.BorderStyle = BorderStyle.FixedSingle
        LastName.Location = New Point(32, 132)
        LastName.Multiline = True
        LastName.Name = "LastName"
        LastName.Size = New Size(145, 29)
        LastName.TabIndex = 4
        ' 
        ' Firstname
        ' 
        Firstname.BorderStyle = BorderStyle.FixedSingle
        Firstname.Location = New Point(185, 132)
        Firstname.Multiline = True
        Firstname.Name = "Firstname"
        Firstname.Size = New Size(145, 29)
        Firstname.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "First Name"
        ' 
        ' CreatePass
        ' 
        CreatePass.BorderStyle = BorderStyle.FixedSingle
        CreatePass.Location = New Point(32, 245)
        CreatePass.Multiline = True
        CreatePass.Name = "CreatePass"
        CreatePass.PasswordChar = "*"c
        CreatePass.Size = New Size(298, 29)
        CreatePass.TabIndex = 10
        CreatePass.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 9
        Label5.Text = "Create Password"
        ' 
        ' ValidPassword
        ' 
        ValidPassword.BorderStyle = BorderStyle.FixedSingle
        ValidPassword.Location = New Point(32, 305)
        ValidPassword.Multiline = True
        ValidPassword.Name = "ValidPassword"
        ValidPassword.PasswordChar = "*"c
        ValidPassword.Size = New Size(298, 29)
        ValidPassword.TabIndex = 12
        ValidPassword.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 15)
        Label6.TabIndex = 11
        Label6.Text = "Confirm Password"
        ' 
        ' ValidUsername
        ' 
        ValidUsername.BorderStyle = BorderStyle.FixedSingle
        ValidUsername.Location = New Point(32, 191)
        ValidUsername.Multiline = True
        ValidUsername.Name = "ValidUsername"
        ValidUsername.Size = New Size(298, 29)
        ValidUsername.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(32, 173)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 13
        Label7.Text = "Username"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Blue
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(118, 358)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 39)
        Button2.TabIndex = 15
        Button2.Text = "SIGN UP"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(368, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(510, 499)
        Panel1.TabIndex = 16
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(251), CByte(244))
        ClientSize = New Size(873, 501)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(ValidUsername)
        Controls.Add(Label7)
        Controls.Add(ValidPassword)
        Controls.Add(Label6)
        Controls.Add(CreatePass)
        Controls.Add(Label5)
        Controls.Add(Firstname)
        Controls.Add(Label3)
        Controls.Add(LastName)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CreatePass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ValidPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ValidUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
