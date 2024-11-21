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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        txtUN = New TextBox()
        txtPW = New TextBox()
        Username = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(548, 519)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(612, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 100)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtUN
        ' 
        txtUN.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtUN.BackColor = SystemColors.ControlLightLight
        txtUN.BorderStyle = BorderStyle.FixedSingle
        txtUN.Font = New Font("Arial", 9F)
        txtUN.Location = New Point(612, 234)
        txtUN.Multiline = True
        txtUN.Name = "txtUN"
        txtUN.Size = New Size(238, 35)
        txtUN.TabIndex = 2
        ' 
        ' txtPW
        ' 
        txtPW.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtPW.BackColor = SystemColors.ControlLightLight
        txtPW.BorderStyle = BorderStyle.FixedSingle
        txtPW.Font = New Font("Arial", 9F)
        txtPW.Location = New Point(612, 312)
        txtPW.Multiline = True
        txtPW.Name = "txtPW"
        txtPW.PasswordChar = "●"c
        txtPW.Size = New Size(238, 33)
        txtPW.TabIndex = 3
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Username.Location = New Point(612, 207)
        Username.Name = "Username"
        Username.Size = New Size(60, 15)
        Username.TabIndex = 4
        Username.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(612, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 5
        Label1.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(682, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 41)
        Button1.TabIndex = 6
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(635, 429)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 15)
        Label2.TabIndex = 7
        Label2.Text = "Don't Have an Account Yet?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Green
        LinkLabel1.Location = New Point(795, 429)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(48, 15)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign Up"
        LinkLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(743, 42)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(112, 100)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(251), CByte(244))
        ClientSize = New Size(901, 518)
        Controls.Add(PictureBox3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(txtPW)
        Controls.Add(txtUN)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox

End Class
