<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lainnya
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lainnya))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnpengaturan = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDataUbahKS = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2Panel3)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(680, 455)
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(455, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnpengaturan)
        Me.Guna2Panel3.Location = New System.Drawing.Point(226, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(229, 455)
        Me.Guna2Panel3.TabIndex = 4
        '
        'btnpengaturan
        '
        Me.btnpengaturan.Animated = True
        Me.btnpengaturan.BackColor = System.Drawing.Color.Transparent
        Me.btnpengaturan.BorderRadius = 5
        Me.btnpengaturan.CheckedState.Parent = Me.btnpengaturan
        Me.btnpengaturan.CustomImages.Parent = Me.btnpengaturan
        Me.btnpengaturan.FillColor = System.Drawing.Color.Silver
        Me.btnpengaturan.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpengaturan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnpengaturan.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnpengaturan.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnpengaturan.HoverState.Image = Global.Library.My.Resources.Resources.settings__1_
        Me.btnpengaturan.HoverState.Parent = Me.btnpengaturan
        Me.btnpengaturan.Image = Global.Library.My.Resources.Resources.settings
        Me.btnpengaturan.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnpengaturan.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnpengaturan.Location = New System.Drawing.Point(47, 103)
        Me.btnpengaturan.Name = "btnpengaturan"
        Me.btnpengaturan.ShadowDecoration.BorderRadius = 5
        Me.btnpengaturan.ShadowDecoration.Enabled = True
        Me.btnpengaturan.ShadowDecoration.Parent = Me.btnpengaturan
        Me.btnpengaturan.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnpengaturan.Size = New System.Drawing.Size(150, 190)
        Me.btnpengaturan.TabIndex = 7
        Me.btnpengaturan.Text = "Pengaturan"
        Me.btnpengaturan.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnDataUbahKS)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnDataUbahKS
        '
        Me.btnDataUbahKS.Animated = True
        Me.btnDataUbahKS.BackColor = System.Drawing.Color.Transparent
        Me.btnDataUbahKS.BorderRadius = 5
        Me.btnDataUbahKS.CheckedState.Parent = Me.btnDataUbahKS
        Me.btnDataUbahKS.CustomImages.Parent = Me.btnDataUbahKS
        Me.btnDataUbahKS.FillColor = System.Drawing.Color.Silver
        Me.btnDataUbahKS.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataUbahKS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataUbahKS.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataUbahKS.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataUbahKS.HoverState.Image = Global.Library.My.Resources.Resources.ubah_kata_sandi1
        Me.btnDataUbahKS.HoverState.Parent = Me.btnDataUbahKS
        Me.btnDataUbahKS.Image = Global.Library.My.Resources.Resources.ubah_kata_sandi
        Me.btnDataUbahKS.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDataUbahKS.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDataUbahKS.Location = New System.Drawing.Point(38, 103)
        Me.btnDataUbahKS.Name = "btnDataUbahKS"
        Me.btnDataUbahKS.ShadowDecoration.BorderRadius = 5
        Me.btnDataUbahKS.ShadowDecoration.Enabled = True
        Me.btnDataUbahKS.ShadowDecoration.Parent = Me.btnDataUbahKS
        Me.btnDataUbahKS.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDataUbahKS.Size = New System.Drawing.Size(150, 190)
        Me.btnDataUbahKS.TabIndex = 6
        Me.btnDataUbahKS.Text = "Ubah Kata Sandi"
        Me.btnDataUbahKS.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Lainnya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lainnya"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Lainnya"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDataUbahKS As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnpengaturan As Guna.UI2.WinForms.Guna2TileButton
End Class
