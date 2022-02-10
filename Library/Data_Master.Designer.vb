<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Master))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDataBuku = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDataAnggota = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDataAdmin = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.GunaGradientPanel1.TabIndex = 1
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.btnDataBuku)
        Me.Guna2Panel2.Location = New System.Drawing.Point(455, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel2.TabIndex = 4
        '
        'btnDataBuku
        '
        Me.btnDataBuku.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDataBuku.Animated = True
        Me.btnDataBuku.BackColor = System.Drawing.Color.Transparent
        Me.btnDataBuku.BorderRadius = 5
        Me.btnDataBuku.CheckedState.Parent = Me.btnDataBuku
        Me.btnDataBuku.CustomImages.Parent = Me.btnDataBuku
        Me.btnDataBuku.FillColor = System.Drawing.Color.Silver
        Me.btnDataBuku.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataBuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataBuku.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataBuku.HoverState.Image = Global.Library.My.Resources.Resources.buku1
        Me.btnDataBuku.HoverState.Parent = Me.btnDataBuku
        Me.btnDataBuku.Image = Global.Library.My.Resources.Resources.buku
        Me.btnDataBuku.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDataBuku.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDataBuku.Location = New System.Drawing.Point(42, 124)
        Me.btnDataBuku.Name = "btnDataBuku"
        Me.btnDataBuku.ShadowDecoration.BorderRadius = 5
        Me.btnDataBuku.ShadowDecoration.Enabled = True
        Me.btnDataBuku.ShadowDecoration.Parent = Me.btnDataBuku
        Me.btnDataBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDataBuku.Size = New System.Drawing.Size(150, 190)
        Me.btnDataBuku.TabIndex = 3
        Me.btnDataBuku.Text = "Buku"
        Me.btnDataBuku.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnDataAnggota)
        Me.Guna2Panel3.Location = New System.Drawing.Point(226, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(229, 455)
        Me.Guna2Panel3.TabIndex = 4
        '
        'btnDataAnggota
        '
        Me.btnDataAnggota.Animated = True
        Me.btnDataAnggota.BackColor = System.Drawing.Color.Transparent
        Me.btnDataAnggota.BorderRadius = 5
        Me.btnDataAnggota.CheckedState.Parent = Me.btnDataAnggota
        Me.btnDataAnggota.CustomImages.Parent = Me.btnDataAnggota
        Me.btnDataAnggota.FillColor = System.Drawing.Color.Silver
        Me.btnDataAnggota.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataAnggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataAnggota.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataAnggota.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataAnggota.HoverState.Image = Global.Library.My.Resources.Resources.anggota1
        Me.btnDataAnggota.HoverState.Parent = Me.btnDataAnggota
        Me.btnDataAnggota.Image = Global.Library.My.Resources.Resources.anggota
        Me.btnDataAnggota.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDataAnggota.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDataAnggota.Location = New System.Drawing.Point(39, 124)
        Me.btnDataAnggota.Name = "btnDataAnggota"
        Me.btnDataAnggota.ShadowDecoration.BorderRadius = 5
        Me.btnDataAnggota.ShadowDecoration.Enabled = True
        Me.btnDataAnggota.ShadowDecoration.Parent = Me.btnDataAnggota
        Me.btnDataAnggota.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDataAnggota.Size = New System.Drawing.Size(150, 190)
        Me.btnDataAnggota.TabIndex = 4
        Me.btnDataAnggota.Text = "Anggota"
        Me.btnDataAnggota.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.Controls.Add(Me.btnDataAdmin)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnDataAdmin
        '
        Me.btnDataAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDataAdmin.Animated = True
        Me.btnDataAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnDataAdmin.BorderRadius = 5
        Me.btnDataAdmin.CheckedState.Parent = Me.btnDataAdmin
        Me.btnDataAdmin.CustomImages.Parent = Me.btnDataAdmin
        Me.btnDataAdmin.FillColor = System.Drawing.Color.Silver
        Me.btnDataAdmin.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDataAdmin.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataAdmin.HoverState.Image = Global.Library.My.Resources.Resources.adminwhite
        Me.btnDataAdmin.HoverState.Parent = Me.btnDataAdmin
        Me.btnDataAdmin.Image = Global.Library.My.Resources.Resources.admin1
        Me.btnDataAdmin.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDataAdmin.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDataAdmin.Location = New System.Drawing.Point(35, 124)
        Me.btnDataAdmin.Name = "btnDataAdmin"
        Me.btnDataAdmin.ShadowDecoration.BorderRadius = 5
        Me.btnDataAdmin.ShadowDecoration.Enabled = True
        Me.btnDataAdmin.ShadowDecoration.Parent = Me.btnDataAdmin
        Me.btnDataAdmin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDataAdmin.Size = New System.Drawing.Size(150, 190)
        Me.btnDataAdmin.TabIndex = 2
        Me.btnDataAdmin.Text = "Admin"
        Me.btnDataAdmin.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Data_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents btnDataAdmin As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDataAnggota As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnDataBuku As Guna.UI2.WinForms.Guna2TileButton
End Class
