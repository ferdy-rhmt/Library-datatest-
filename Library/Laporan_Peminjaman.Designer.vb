<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan_peminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_peminjaman))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtsearchbar = New Bunifu.Framework.UI.BunifuTextbox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvDaftarPinjaman = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvDaftarPinjaman, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(680, 455)
        Me.GunaGradientPanel1.TabIndex = 3
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.txtsearchbar)
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel2)
        Me.Guna2Panel2.Controls.Add(Me.dgvDaftarPinjaman)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TileButton2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(681, 455)
        Me.Guna2Panel2.TabIndex = 4
        '
        'txtsearchbar
        '
        Me.txtsearchbar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtsearchbar.BackColor = System.Drawing.Color.Silver
        Me.txtsearchbar.BackgroundImage = CType(resources.GetObject("txtsearchbar.BackgroundImage"), System.Drawing.Image)
        Me.txtsearchbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtsearchbar.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txtsearchbar.Icon = CType(resources.GetObject("txtsearchbar.Icon"), System.Drawing.Image)
        Me.txtsearchbar.Location = New System.Drawing.Point(12, 62)
        Me.txtsearchbar.Name = "txtsearchbar"
        Me.txtsearchbar.Size = New System.Drawing.Size(243, 35)
        Me.txtsearchbar.TabIndex = 17
        Me.txtsearchbar.TabStop = False
        Me.txtsearchbar.text = ""
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(7, 1)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(208, 23)
        Me.GunaLabel2.TabIndex = 16
        Me.GunaLabel2.Text = " - Laporan Peminjaman"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'dgvDaftarPinjaman
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvDaftarPinjaman.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDaftarPinjaman.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvDaftarPinjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDaftarPinjaman.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarPinjaman.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDaftarPinjaman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDaftarPinjaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarPinjaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDaftarPinjaman.ColumnHeadersHeight = 21
        Me.dgvDaftarPinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDaftarPinjaman.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDaftarPinjaman.EnableHeadersVisualStyles = False
        Me.dgvDaftarPinjaman.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvDaftarPinjaman.Location = New System.Drawing.Point(12, 103)
        Me.dgvDaftarPinjaman.Name = "dgvDaftarPinjaman"
        Me.dgvDaftarPinjaman.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarPinjaman.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDaftarPinjaman.RowHeadersVisible = False
        Me.dgvDaftarPinjaman.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDaftarPinjaman.RowTemplate.Height = 35
        Me.dgvDaftarPinjaman.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDaftarPinjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarPinjaman.Size = New System.Drawing.Size(656, 302)
        Me.dgvDaftarPinjaman.TabIndex = 14
        Me.dgvDaftarPinjaman.TabStop = False
        Me.dgvDaftarPinjaman.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvDaftarPinjaman.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDaftarPinjaman.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDaftarPinjaman.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDaftarPinjaman.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDaftarPinjaman.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDaftarPinjaman.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvDaftarPinjaman.ThemeStyle.ReadOnly = True
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.Height = 35
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvDaftarPinjaman.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2TileButton2.Location = New System.Drawing.Point(12, 103)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Depth = 31
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(656, 302)
        Me.Guna2TileButton2.TabIndex = 15
        Me.Guna2TileButton2.TabStop = False
        Me.Guna2TileButton2.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvDaftarPinjaman
        '
        'laporan_peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "laporan_peminjaman"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgvDaftarPinjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvDaftarPinjaman As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtsearchbar As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
