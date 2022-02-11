<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTransaksiPengembalian = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTransaksiPeminjaman = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2TileButton()
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
        Me.GunaGradientPanel1.TabIndex = 2
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.btnTransaksiPengembalian)
        Me.Guna2Panel2.Location = New System.Drawing.Point(455, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel2.TabIndex = 4
        '
        'btnTransaksiPengembalian
        '
        Me.btnTransaksiPengembalian.Animated = True
        Me.btnTransaksiPengembalian.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksiPengembalian.BorderRadius = 5
        Me.btnTransaksiPengembalian.CheckedState.Parent = Me.btnTransaksiPengembalian
        Me.btnTransaksiPengembalian.CustomImages.Parent = Me.btnTransaksiPengembalian
        Me.btnTransaksiPengembalian.FillColor = System.Drawing.Color.Silver
        Me.btnTransaksiPengembalian.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksiPengembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnTransaksiPengembalian.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnTransaksiPengembalian.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransaksiPengembalian.HoverState.Image = Global.Library.My.Resources.Resources.pengembalian1
        Me.btnTransaksiPengembalian.HoverState.Parent = Me.btnTransaksiPengembalian
        Me.btnTransaksiPengembalian.Image = Global.Library.My.Resources.Resources.pengembalian
        Me.btnTransaksiPengembalian.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnTransaksiPengembalian.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnTransaksiPengembalian.Location = New System.Drawing.Point(40, 121)
        Me.btnTransaksiPengembalian.Name = "btnTransaksiPengembalian"
        Me.btnTransaksiPengembalian.ShadowDecoration.BorderRadius = 5
        Me.btnTransaksiPengembalian.ShadowDecoration.Enabled = True
        Me.btnTransaksiPengembalian.ShadowDecoration.Parent = Me.btnTransaksiPengembalian
        Me.btnTransaksiPengembalian.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnTransaksiPengembalian.Size = New System.Drawing.Size(150, 190)
        Me.btnTransaksiPengembalian.TabIndex = 3
        Me.btnTransaksiPengembalian.Text = "Pengembalian"
        Me.btnTransaksiPengembalian.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.btnTransaksiPeminjaman)
        Me.Guna2Panel3.Location = New System.Drawing.Point(226, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(229, 455)
        Me.Guna2Panel3.TabIndex = 4
        '
        'btnTransaksiPeminjaman
        '
        Me.btnTransaksiPeminjaman.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransaksiPeminjaman.Animated = True
        Me.btnTransaksiPeminjaman.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksiPeminjaman.BorderRadius = 5
        Me.btnTransaksiPeminjaman.CheckedState.Parent = Me.btnTransaksiPeminjaman
        Me.btnTransaksiPeminjaman.CustomImages.Parent = Me.btnTransaksiPeminjaman
        Me.btnTransaksiPeminjaman.FillColor = System.Drawing.Color.Silver
        Me.btnTransaksiPeminjaman.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksiPeminjaman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnTransaksiPeminjaman.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnTransaksiPeminjaman.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransaksiPeminjaman.HoverState.Image = Global.Library.My.Resources.Resources.peminjaman1
        Me.btnTransaksiPeminjaman.HoverState.Parent = Me.btnTransaksiPeminjaman
        Me.btnTransaksiPeminjaman.Image = Global.Library.My.Resources.Resources.peminjaman
        Me.btnTransaksiPeminjaman.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnTransaksiPeminjaman.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnTransaksiPeminjaman.Location = New System.Drawing.Point(42, 121)
        Me.btnTransaksiPeminjaman.Name = "btnTransaksiPeminjaman"
        Me.btnTransaksiPeminjaman.ShadowDecoration.BorderRadius = 5
        Me.btnTransaksiPeminjaman.ShadowDecoration.Enabled = True
        Me.btnTransaksiPeminjaman.ShadowDecoration.Parent = Me.btnTransaksiPeminjaman
        Me.btnTransaksiPeminjaman.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnTransaksiPeminjaman.Size = New System.Drawing.Size(150, 190)
        Me.btnTransaksiPeminjaman.TabIndex = 2
        Me.btnTransaksiPeminjaman.Text = "Peminjaman"
        Me.btnTransaksiPeminjaman.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.btnHistory)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(226, 455)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnHistory.BorderRadius = 5
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.CustomImages.Parent = Me.btnHistory
        Me.btnHistory.FillColor = System.Drawing.Color.Silver
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnHistory.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistory.HoverState.Image = Global.Library.My.Resources.Resources.file__1_
        Me.btnHistory.HoverState.Parent = Me.btnHistory
        Me.btnHistory.Image = Global.Library.My.Resources.Resources.file
        Me.btnHistory.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnHistory.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnHistory.Location = New System.Drawing.Point(38, 121)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.BorderRadius = 5
        Me.btnHistory.ShadowDecoration.Enabled = True
        Me.btnHistory.ShadowDecoration.Parent = Me.btnHistory
        Me.btnHistory.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnHistory.Size = New System.Drawing.Size(150, 190)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTransaksiPeminjaman As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnTransaksiPengembalian As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
