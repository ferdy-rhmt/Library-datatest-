<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi_History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi_History))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_keterangan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvhistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.lbljenis = New Guna.UI.WinForms.GunaLabel()
        Me.txtcari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.idpinjam_idkembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pinjam_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_keterangan)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvhistory)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2TileButton2)
        Me.GunaGradientPanel1.Controls.Add(Me.lbljenis)
        Me.GunaGradientPanel1.Controls.Add(Me.txtcari)
        Me.GunaGradientPanel1.Controls.Add(Me.txttotal)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(860, 580)
        Me.GunaGradientPanel1.TabIndex = 8
        Me.GunaGradientPanel1.TabStop = False
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel3.AutoEllipsis = True
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(256, 72)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(79, 17)
        Me.GunaLabel3.TabIndex = 59
        Me.GunaLabel3.Text = "Cari Riwayat"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel1.AutoEllipsis = True
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 72)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(124, 17)
        Me.GunaLabel1.TabIndex = 58
        Me.GunaLabel1.Text = "Cari Nama Anggota"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txt_keterangan
        '
        Me.txt_keterangan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_keterangan.Animated = True
        Me.txt_keterangan.BackColor = System.Drawing.Color.Transparent
        Me.txt_keterangan.BorderRadius = 5
        Me.txt_keterangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_keterangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_keterangan.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_keterangan.FocusedColor = System.Drawing.Color.Empty
        Me.txt_keterangan.FocusedState.Parent = Me.txt_keterangan
        Me.txt_keterangan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txt_keterangan.FormattingEnabled = True
        Me.txt_keterangan.HoverState.Parent = Me.txt_keterangan
        Me.txt_keterangan.ItemHeight = 30
        Me.txt_keterangan.Items.AddRange(New Object() {"Peminjaman", "Pengembalian"})
        Me.txt_keterangan.ItemsAppearance.Parent = Me.txt_keterangan
        Me.txt_keterangan.Location = New System.Drawing.Point(252, 93)
        Me.txt_keterangan.Name = "txt_keterangan"
        Me.txt_keterangan.ShadowDecoration.Parent = Me.txt_keterangan
        Me.txt_keterangan.Size = New System.Drawing.Size(165, 36)
        Me.txt_keterangan.TabIndex = 57
        '
        'dgvhistory
        '
        Me.dgvhistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvhistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvhistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvhistory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvhistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvhistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvhistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvhistory.ColumnHeadersHeight = 24
        Me.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvhistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpinjam_idkembali, Me.penerbit, Me.jumlah, Me.Column1, Me.id_buku, Me.judul, Me.pinjam_kembali})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvhistory.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvhistory.EnableHeadersVisualStyles = False
        Me.dgvhistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvhistory.Location = New System.Drawing.Point(12, 136)
        Me.dgvhistory.MultiSelect = False
        Me.dgvhistory.Name = "dgvhistory"
        Me.dgvhistory.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvhistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvhistory.RowHeadersVisible = False
        Me.dgvhistory.RowTemplate.Height = 30
        Me.dgvhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvhistory.Size = New System.Drawing.Size(836, 408)
        Me.dgvhistory.TabIndex = 55
        Me.dgvhistory.TabStop = False
        Me.dgvhistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvhistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvhistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvhistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvhistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvhistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvhistory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvhistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvhistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvhistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvhistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvhistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvhistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvhistory.ThemeStyle.HeaderStyle.Height = 24
        Me.dgvhistory.ThemeStyle.ReadOnly = True
        Me.dgvhistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvhistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dgvhistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvhistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvhistory.ThemeStyle.RowsStyle.Height = 30
        Me.dgvhistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvhistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2TileButton2.Location = New System.Drawing.Point(12, 136)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Depth = 31
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(836, 408)
        Me.Guna2TileButton2.TabIndex = 56
        Me.Guna2TileButton2.TabStop = False
        Me.Guna2TileButton2.TextOffset = New System.Drawing.Point(0, 6)
        '
        'lbljenis
        '
        Me.lbljenis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbljenis.AutoEllipsis = True
        Me.lbljenis.AutoSize = True
        Me.lbljenis.BackColor = System.Drawing.Color.Transparent
        Me.lbljenis.Font = New System.Drawing.Font("Segoe UI", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljenis.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbljenis.Location = New System.Drawing.Point(846, 9)
        Me.lbljenis.Name = "lbljenis"
        Me.lbljenis.Size = New System.Drawing.Size(5, 6)
        Me.lbljenis.TabIndex = 54
        Me.lbljenis.Text = "_"
        Me.lbljenis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbljenis.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtcari
        '
        Me.txtcari.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcari.Animated = True
        Me.txtcari.BackColor = System.Drawing.Color.Transparent
        Me.txtcari.BorderRadius = 6
        Me.txtcari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcari.DefaultText = ""
        Me.txtcari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcari.DisabledState.Parent = Me.txtcari
        Me.txtcari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcari.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtcari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcari.FocusedState.Parent = Me.txtcari
        Me.txtcari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtcari.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcari.HoverState.Parent = Me.txtcari
        Me.txtcari.Location = New System.Drawing.Point(12, 93)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcari.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtcari.PlaceholderText = "Masukkan nama..."
        Me.txtcari.SelectedText = ""
        Me.txtcari.ShadowDecoration.Enabled = True
        Me.txtcari.ShadowDecoration.Parent = Me.txtcari
        Me.txtcari.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtcari.Size = New System.Drawing.Size(233, 36)
        Me.txtcari.TabIndex = 51
        '
        'txttotal
        '
        Me.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttotal.BackColor = System.Drawing.Color.Transparent
        Me.txttotal.BorderRadius = 5
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.DefaultText = "0"
        Me.txttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.DisabledState.Parent = Me.txttotal
        Me.txttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.FocusedState.Parent = Me.txttotal
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.HoverState.Parent = Me.txttotal
        Me.txttotal.Location = New System.Drawing.Point(781, 551)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txttotal.PlaceholderText = ""
        Me.txttotal.SelectedText = ""
        Me.txttotal.SelectionStart = 1
        Me.txttotal.ShadowDecoration.Enabled = True
        Me.txttotal.ShadowDecoration.Parent = Me.txttotal
        Me.txttotal.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txttotal.Size = New System.Drawing.Size(70, 25)
        Me.txttotal.TabIndex = 50
        Me.txttotal.TabStop = False
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttotal.TextOffset = New System.Drawing.Point(5, 0)
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Product Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 9)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(319, 24)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = " - Riwayat Peminjaman/Pengembalian"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'idpinjam_idkembali
        '
        Me.idpinjam_idkembali.FillWeight = 50.0!
        Me.idpinjam_idkembali.HeaderText = "ID Pinjam"
        Me.idpinjam_idkembali.Name = "idpinjam_idkembali"
        Me.idpinjam_idkembali.ReadOnly = True
        '
        'penerbit
        '
        Me.penerbit.FillWeight = 50.0!
        Me.penerbit.HeaderText = "Tanggal Pinjam"
        Me.penerbit.Name = "penerbit"
        Me.penerbit.ReadOnly = True
        '
        'jumlah
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.DefaultCellStyle = DataGridViewCellStyle3
        Me.jumlah.FillWeight = 40.0!
        Me.jumlah.HeaderText = "ID Anggota"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 90.0!
        Me.Column1.HeaderText = "Nama Anggota"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'id_buku
        '
        Me.id_buku.FillWeight = 40.0!
        Me.id_buku.HeaderText = "ID Buku"
        Me.id_buku.Name = "id_buku"
        Me.id_buku.ReadOnly = True
        '
        'judul
        '
        Me.judul.FillWeight = 110.0!
        Me.judul.HeaderText = "Judul"
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        '
        'pinjam_kembali
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pinjam_kembali.DefaultCellStyle = DataGridViewCellStyle4
        Me.pinjam_kembali.FillWeight = 30.0!
        Me.pinjam_kembali.HeaderText = "Dipinjam"
        Me.pinjam_kembali.Name = "pinjam_kembali"
        Me.pinjam_kembali.ReadOnly = True
        '
        'Transaksi_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 580)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi_History"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbljenis As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvhistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txt_keterangan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents idpinjam_idkembali As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents id_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents pinjam_kembali As DataGridViewTextBoxColumn
End Class
