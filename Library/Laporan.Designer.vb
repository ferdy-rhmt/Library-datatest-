<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLaporanDataM = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLaporandenda = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLaporanPeminjaman = New Guna.UI2.WinForms.Guna2TileButton()
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
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.btnLaporanDataM)
        Me.Guna2Panel2.Location = New System.Drawing.Point(455, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel2.TabIndex = 4
        '
        'btnLaporanDataM
        '
        Me.btnLaporanDataM.Animated = True
        Me.btnLaporanDataM.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporanDataM.BorderRadius = 5
        Me.btnLaporanDataM.CheckedState.Parent = Me.btnLaporanDataM
        Me.btnLaporanDataM.CustomImages.Parent = Me.btnLaporanDataM
        Me.btnLaporanDataM.FillColor = System.Drawing.Color.Silver
        Me.btnLaporanDataM.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanDataM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporanDataM.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporanDataM.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLaporanDataM.HoverState.Image = Global.Library.My.Resources.Resources.lap_data_master1
        Me.btnLaporanDataM.HoverState.Parent = Me.btnLaporanDataM
        Me.btnLaporanDataM.Image = Global.Library.My.Resources.Resources.lap_data_master
        Me.btnLaporanDataM.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnLaporanDataM.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnLaporanDataM.Location = New System.Drawing.Point(40, 121)
        Me.btnLaporanDataM.Name = "btnLaporanDataM"
        Me.btnLaporanDataM.ShadowDecoration.BorderRadius = 5
        Me.btnLaporanDataM.ShadowDecoration.Enabled = True
        Me.btnLaporanDataM.ShadowDecoration.Parent = Me.btnLaporanDataM
        Me.btnLaporanDataM.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnLaporanDataM.Size = New System.Drawing.Size(150, 190)
        Me.btnLaporanDataM.TabIndex = 3
        Me.btnLaporanDataM.Text = "Lap. Data Master"
        Me.btnLaporanDataM.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnLaporandenda)
        Me.Guna2Panel3.Location = New System.Drawing.Point(226, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(229, 455)
        Me.Guna2Panel3.TabIndex = 4
        '
        'btnLaporandenda
        '
        Me.btnLaporandenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaporandenda.Animated = True
        Me.btnLaporandenda.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporandenda.BorderRadius = 5
        Me.btnLaporandenda.CheckedState.Parent = Me.btnLaporandenda
        Me.btnLaporandenda.CustomImages.Parent = Me.btnLaporandenda
        Me.btnLaporandenda.FillColor = System.Drawing.Color.Silver
        Me.btnLaporandenda.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporandenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporandenda.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporandenda.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLaporandenda.HoverState.Image = Global.Library.My.Resources.Resources.lap_denda1
        Me.btnLaporandenda.HoverState.Parent = Me.btnLaporandenda
        Me.btnLaporandenda.Image = Global.Library.My.Resources.Resources.lap_denda
        Me.btnLaporandenda.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnLaporandenda.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnLaporandenda.Location = New System.Drawing.Point(42, 121)
        Me.btnLaporandenda.Name = "btnLaporandenda"
        Me.btnLaporandenda.ShadowDecoration.BorderRadius = 5
        Me.btnLaporandenda.ShadowDecoration.Enabled = True
        Me.btnLaporandenda.ShadowDecoration.Parent = Me.btnLaporandenda
        Me.btnLaporandenda.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnLaporandenda.Size = New System.Drawing.Size(150, 190)
        Me.btnLaporandenda.TabIndex = 2
        Me.btnLaporandenda.Text = "Lap. Denda"
        Me.btnLaporandenda.TextOffset = New System.Drawing.Point(0, 8)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnLaporanPeminjaman)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnLaporanPeminjaman
        '
        Me.btnLaporanPeminjaman.Animated = True
        Me.btnLaporanPeminjaman.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporanPeminjaman.BorderRadius = 5
        Me.btnLaporanPeminjaman.CheckedState.Parent = Me.btnLaporanPeminjaman
        Me.btnLaporanPeminjaman.CustomImages.Parent = Me.btnLaporanPeminjaman
        Me.btnLaporanPeminjaman.FillColor = System.Drawing.Color.Silver
        Me.btnLaporanPeminjaman.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanPeminjaman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporanPeminjaman.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLaporanPeminjaman.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLaporanPeminjaman.HoverState.Image = Global.Library.My.Resources.Resources.lap_peminjaman1
        Me.btnLaporanPeminjaman.HoverState.Parent = Me.btnLaporanPeminjaman
        Me.btnLaporanPeminjaman.Image = Global.Library.My.Resources.Resources.lap_peminjaman
        Me.btnLaporanPeminjaman.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnLaporanPeminjaman.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnLaporanPeminjaman.Location = New System.Drawing.Point(38, 121)
        Me.btnLaporanPeminjaman.Name = "btnLaporanPeminjaman"
        Me.btnLaporanPeminjaman.ShadowDecoration.BorderRadius = 5
        Me.btnLaporanPeminjaman.ShadowDecoration.Enabled = True
        Me.btnLaporanPeminjaman.ShadowDecoration.Parent = Me.btnLaporanPeminjaman
        Me.btnLaporanPeminjaman.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnLaporanPeminjaman.Size = New System.Drawing.Size(150, 190)
        Me.btnLaporanPeminjaman.TabIndex = 4
        Me.btnLaporanPeminjaman.Text = "Lap. Peminjaman"
        Me.btnLaporanPeminjaman.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laporan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLaporandenda As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLaporanDataM As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLaporanPeminjaman As Guna.UI2.WinForms.Guna2TileButton
End Class
