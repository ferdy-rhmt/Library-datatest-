<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Admin))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Silver
        Me.GunaPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GunaPanel1.Controls.Add(Me.btnExit)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(278, 30)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(8, 5)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 1
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(125, 15)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Login Manent Library"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Animated = True
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BaseColor = System.Drawing.Color.Firebrick
        Me.btnExit.BorderColor = System.Drawing.Color.White
        Me.btnExit.BorderSize = 1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnExit.Location = New System.Drawing.Point(246, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Red
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLogin.Animated = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.BorderThickness = 2
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.Silver
        Me.btnLogin.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLogin.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.ForestGreen
        Me.btnLogin.HoverState.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(45, 249)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.PressedColor = System.Drawing.Color.AliceBlue
        Me.btnLogin.ShadowDecoration.BorderRadius = 10
        Me.btnLogin.ShadowDecoration.Depth = 25
        Me.btnLogin.ShadowDecoration.Enabled = True
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnLogin.Size = New System.Drawing.Size(84, 27)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Silver
        Me.btnCancel.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.btnCancel.HoverState.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(150, 249)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedColor = System.Drawing.Color.AliceBlue
        Me.btnCancel.ShadowDecoration.BorderRadius = 10
        Me.btnCancel.ShadowDecoration.Depth = 25
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnCancel.Size = New System.Drawing.Size(84, 27)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto Thin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaLabel1.Location = New System.Drawing.Point(101, 307)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(78, 14)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Manent 2021"
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtpassword.Animated = True
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BorderRadius = 10
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.Parent = Me.txtpassword
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedState.Parent = Me.txtpassword
        Me.txtpassword.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.HoverState.Parent = Me.txtpassword
        Me.txtpassword.IconLeft = Global.Library.My.Resources.Resources.password1
        Me.txtpassword.IconLeftOffset = New System.Drawing.Point(4, -1)
        Me.txtpassword.Location = New System.Drawing.Point(40, 202)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.BorderRadius = 10
        Me.txtpassword.ShadowDecoration.Depth = 25
        Me.txtpassword.ShadowDecoration.Enabled = True
        Me.txtpassword.ShadowDecoration.Parent = Me.txtpassword
        Me.txtpassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpassword.Size = New System.Drawing.Size(200, 36)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.TextOffset = New System.Drawing.Point(6, 0)
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(170, 150)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = Global.Library.My.Resources.Resources.Logo_Manent2
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(170, 150)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(77, 45)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(170, 150)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(127, 100)
        Me.Guna2ImageButton1.TabIndex = 6
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtusername.Animated = True
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BorderRadius = 10
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.Parent = Me.txtusername
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedState.Parent = Me.txtusername
        Me.txtusername.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.txtusername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.HoverState.Parent = Me.txtusername
        Me.txtusername.IconLeft = Global.Library.My.Resources.Resources.id_card1
        Me.txtusername.IconLeftOffset = New System.Drawing.Point(5, -1)
        Me.txtusername.Location = New System.Drawing.Point(40, 155)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.PlaceholderText = "Username"
        Me.txtusername.SelectedText = ""
        Me.txtusername.ShadowDecoration.BorderRadius = 10
        Me.txtusername.ShadowDecoration.Depth = 25
        Me.txtusername.ShadowDecoration.Enabled = True
        Me.txtusername.ShadowDecoration.Parent = Me.txtusername
        Me.txtusername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtusername.Size = New System.Drawing.Size(200, 36)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        '
        'Login_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(278, 328)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
