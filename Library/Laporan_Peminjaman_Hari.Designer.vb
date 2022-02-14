<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan_Peminjaman_Hari
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan_Peminjaman_Hari))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cbjenis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnexport = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btnPinjamBuku = New Guna.UI2.WinForms.Guna2TileButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lap_pinjam1 = New Library.lap_pinjam()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(860, 580)
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel2.Controls.Add(Me.cbjenis)
        Me.Guna2Panel2.Controls.Add(Me.btnexport)
        Me.Guna2Panel2.Controls.Add(Me.btnPinjamBuku)
        Me.Guna2Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TileButton2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(860, 580)
        Me.Guna2Panel2.TabIndex = 4
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoEllipsis = True
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(35, 64)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(115, 17)
        Me.GunaLabel1.TabIndex = 22
        Me.GunaLabel1.Text = "Pilih Jenis Laporan"
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'cbjenis
        '
        Me.cbjenis.BackColor = System.Drawing.Color.Transparent
        Me.cbjenis.BorderRadius = 6
        Me.cbjenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjenis.FocusedColor = System.Drawing.Color.Empty
        Me.cbjenis.FocusedState.Parent = Me.cbjenis
        Me.cbjenis.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.HoverState.Parent = Me.cbjenis
        Me.cbjenis.ItemHeight = 30
        Me.cbjenis.Items.AddRange(New Object() {"Laporan Harian", "Laporan Bulanan"})
        Me.cbjenis.ItemsAppearance.Parent = Me.cbjenis
        Me.cbjenis.Location = New System.Drawing.Point(31, 84)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.ShadowDecoration.Parent = Me.cbjenis
        Me.cbjenis.Size = New System.Drawing.Size(276, 36)
        Me.cbjenis.StartIndex = 0
        Me.cbjenis.TabIndex = 21
        Me.cbjenis.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnexport
        '
        Me.btnexport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnexport.Animated = True
        Me.btnexport.BackColor = System.Drawing.Color.Transparent
        Me.btnexport.BorderRadius = 6
        Me.btnexport.CheckedState.Parent = Me.btnexport
        Me.btnexport.CustomImages.Parent = Me.btnexport
        Me.btnexport.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnexport.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnexport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnexport.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnexport.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnexport.HoverState.Parent = Me.btnexport
        Me.btnexport.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnexport.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnexport.Location = New System.Drawing.Point(713, 84)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.ShadowDecoration.Depth = 31
        Me.btnexport.ShadowDecoration.Enabled = True
        Me.btnexport.ShadowDecoration.Parent = Me.btnexport
        Me.btnexport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnexport.Size = New System.Drawing.Size(117, 34)
        Me.btnexport.TabIndex = 20
        Me.btnexport.TabStop = False
        Me.btnexport.Text = "Export"
        '
        'btnPinjamBuku
        '
        Me.btnPinjamBuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPinjamBuku.Animated = True
        Me.btnPinjamBuku.BackColor = System.Drawing.Color.Transparent
        Me.btnPinjamBuku.BorderRadius = 6
        Me.btnPinjamBuku.CheckedState.Parent = Me.btnPinjamBuku
        Me.btnPinjamBuku.CustomImages.Parent = Me.btnPinjamBuku
        Me.btnPinjamBuku.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnPinjamBuku.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPinjamBuku.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPinjamBuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnPinjamBuku.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnPinjamBuku.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnPinjamBuku.HoverState.Parent = Me.btnPinjamBuku
        Me.btnPinjamBuku.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnPinjamBuku.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnPinjamBuku.Location = New System.Drawing.Point(313, 86)
        Me.btnPinjamBuku.Name = "btnPinjamBuku"
        Me.btnPinjamBuku.ShadowDecoration.Depth = 31
        Me.btnPinjamBuku.ShadowDecoration.Enabled = True
        Me.btnPinjamBuku.ShadowDecoration.Parent = Me.btnPinjamBuku
        Me.btnPinjamBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnPinjamBuku.Size = New System.Drawing.Size(117, 34)
        Me.btnPinjamBuku.TabIndex = 19
        Me.btnPinjamBuku.TabStop = False
        Me.btnPinjamBuku.Text = "View"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(31, 126)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.lap_pinjam1
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(799, 442)
        Me.CrystalReportViewer1.TabIndex = 18
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(17, 15)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(208, 23)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = " - Laporan Peminjaman"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2TileButton2.Animated = True
        Me.Guna2TileButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.BorderRadius = 6
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.Gray
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton2.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TileButton2.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ImageOffset = New System.Drawing.Point(0, 15)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(31, 126)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Depth = 31
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(799, 442)
        Me.Guna2TileButton2.TabIndex = 15
        Me.Guna2TileButton2.TabStop = False
        Me.Guna2TileButton2.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.CrystalReportViewer1
        '
        'Laporan_Peminjaman_Hari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 580)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laporan_Peminjaman_Hari"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnexport As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnPinjamBuku As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cbjenis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lap_pinjam1 As lap_pinjam
End Class
