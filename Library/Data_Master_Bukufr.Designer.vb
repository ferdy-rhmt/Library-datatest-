<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Bukufr
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Master_Bukufr))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvDaftarBuku = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.th_terbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.btneditstok = New Guna.UI2.WinForms.Guna2TileButton()
        Me.lblid = New Guna.UI.WinForms.GunaLabel()
        Me.txtcaribuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblpengganti = New Guna.UI.WinForms.GunaLabel()
        Me.btnAddBuku = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btnDelBuku = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        CType(Me.dgvDaftarBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.dgvDaftarBuku
        '
        'dgvDaftarBuku
        '
        Me.dgvDaftarBuku.AllowUserToAddRows = False
        Me.dgvDaftarBuku.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvDaftarBuku.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDaftarBuku.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvDaftarBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDaftarBuku.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarBuku.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDaftarBuku.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDaftarBuku.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarBuku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDaftarBuku.ColumnHeadersHeight = 21
        Me.dgvDaftarBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_buku, Me.nama_buku, Me.penerbit, Me.th_terbit, Me.stok})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDaftarBuku.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDaftarBuku.EnableHeadersVisualStyles = False
        Me.dgvDaftarBuku.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvDaftarBuku.Location = New System.Drawing.Point(110, 94)
        Me.dgvDaftarBuku.Name = "dgvDaftarBuku"
        Me.dgvDaftarBuku.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDaftarBuku.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDaftarBuku.RowHeadersVisible = False
        Me.dgvDaftarBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarBuku.Size = New System.Drawing.Size(558, 329)
        Me.dgvDaftarBuku.TabIndex = 8
        Me.dgvDaftarBuku.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvDaftarBuku.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvDaftarBuku.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDaftarBuku.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDaftarBuku.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDaftarBuku.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDaftarBuku.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarBuku.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDaftarBuku.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvDaftarBuku.ThemeStyle.ReadOnly = True
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.Height = 22
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson
        Me.dgvDaftarBuku.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_buku
        '
        Me.id_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_buku.FillWeight = 55.0!
        Me.id_buku.HeaderText = "ID"
        Me.id_buku.Name = "id_buku"
        Me.id_buku.ReadOnly = True
        '
        'nama_buku
        '
        Me.nama_buku.FillWeight = 115.0!
        Me.nama_buku.HeaderText = "Judul"
        Me.nama_buku.Name = "nama_buku"
        Me.nama_buku.ReadOnly = True
        '
        'penerbit
        '
        Me.penerbit.FillWeight = 115.0!
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.Name = "penerbit"
        Me.penerbit.ReadOnly = True
        '
        'th_terbit
        '
        Me.th_terbit.FillWeight = 45.0!
        Me.th_terbit.HeaderText = "Tahun"
        Me.th_terbit.Name = "th_terbit"
        Me.th_terbit.ReadOnly = True
        '
        'stok
        '
        Me.stok.FillWeight = 40.0!
        Me.stok.HeaderText = "Stok"
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.btneditstok)
        Me.GunaGradientPanel1.Controls.Add(Me.lblid)
        Me.GunaGradientPanel1.Controls.Add(Me.txtcaribuku)
        Me.GunaGradientPanel1.Controls.Add(Me.lblpengganti)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvDaftarBuku)
        Me.GunaGradientPanel1.Controls.Add(Me.btnAddBuku)
        Me.GunaGradientPanel1.Controls.Add(Me.btnDelBuku)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2TileButton2)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(680, 455)
        Me.GunaGradientPanel1.TabIndex = 7
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'btneditstok
        '
        Me.btneditstok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btneditstok.Animated = True
        Me.btneditstok.BackColor = System.Drawing.Color.Transparent
        Me.btneditstok.BorderRadius = 6
        Me.btneditstok.CheckedState.Parent = Me.btneditstok
        Me.btneditstok.CustomImages.Parent = Me.btneditstok
        Me.btneditstok.FillColor = System.Drawing.Color.Silver
        Me.btneditstok.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditstok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btneditstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btneditstok.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btneditstok.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.btneditstok.HoverState.Parent = Me.btneditstok
        Me.btneditstok.Image = Global.Library.My.Resources.Resources.add_rak
        Me.btneditstok.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btneditstok.ImageSize = New System.Drawing.Size(30, 30)
        Me.btneditstok.Location = New System.Drawing.Point(12, 180)
        Me.btneditstok.Name = "btneditstok"
        Me.btneditstok.ShadowDecoration.Depth = 31
        Me.btneditstok.ShadowDecoration.Enabled = True
        Me.btneditstok.ShadowDecoration.Parent = Me.btneditstok
        Me.btneditstok.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btneditstok.Size = New System.Drawing.Size(80, 80)
        Me.btneditstok.TabIndex = 17
        Me.btneditstok.Text = "Edit Stok"
        Me.btneditstok.TextOffset = New System.Drawing.Point(0, 6)
        '
        'lblid
        '
        Me.lblid.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblid.ForeColor = System.Drawing.Color.DarkGray
        Me.lblid.Location = New System.Drawing.Point(599, 431)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(12, 15)
        Me.lblid.TabIndex = 16
        Me.lblid.Text = "_"
        Me.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcaribuku
        '
        Me.txtcaribuku.BorderRadius = 6
        Me.txtcaribuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcaribuku.DefaultText = ""
        Me.txtcaribuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcaribuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcaribuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcaribuku.DisabledState.Parent = Me.txtcaribuku
        Me.txtcaribuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcaribuku.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtcaribuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcaribuku.FocusedState.Parent = Me.txtcaribuku
        Me.txtcaribuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcaribuku.HoverState.Parent = Me.txtcaribuku
        Me.txtcaribuku.Location = New System.Drawing.Point(110, 62)
        Me.txtcaribuku.Name = "txtcaribuku"
        Me.txtcaribuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcaribuku.PlaceholderText = "Cari buku..."
        Me.txtcaribuku.SelectedText = ""
        Me.txtcaribuku.ShadowDecoration.Parent = Me.txtcaribuku
        Me.txtcaribuku.Size = New System.Drawing.Size(219, 26)
        Me.txtcaribuku.TabIndex = 15
        '
        'lblpengganti
        '
        Me.lblpengganti.AutoEllipsis = True
        Me.lblpengganti.AutoSize = True
        Me.lblpengganti.BackColor = System.Drawing.Color.Transparent
        Me.lblpengganti.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpengganti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblpengganti.Location = New System.Drawing.Point(3, 0)
        Me.lblpengganti.Name = "lblpengganti"
        Me.lblpengganti.Size = New System.Drawing.Size(135, 29)
        Me.lblpengganti.TabIndex = 11
        Me.lblpengganti.Text = " - Rak Buku"
        Me.lblpengganti.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnAddBuku
        '
        Me.btnAddBuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddBuku.Animated = True
        Me.btnAddBuku.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBuku.BorderRadius = 6
        Me.btnAddBuku.CheckedState.Parent = Me.btnAddBuku
        Me.btnAddBuku.CustomImages.Parent = Me.btnAddBuku
        Me.btnAddBuku.FillColor = System.Drawing.Color.Silver
        Me.btnAddBuku.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddBuku.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBuku.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.btnAddBuku.HoverState.Parent = Me.btnAddBuku
        Me.btnAddBuku.Image = Global.Library.My.Resources.Resources.add_rak
        Me.btnAddBuku.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btnAddBuku.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAddBuku.Location = New System.Drawing.Point(12, 94)
        Me.btnAddBuku.Name = "btnAddBuku"
        Me.btnAddBuku.ShadowDecoration.Depth = 31
        Me.btnAddBuku.ShadowDecoration.Enabled = True
        Me.btnAddBuku.ShadowDecoration.Parent = Me.btnAddBuku
        Me.btnAddBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnAddBuku.Size = New System.Drawing.Size(80, 80)
        Me.btnAddBuku.TabIndex = 9
        Me.btnAddBuku.Text = "Add"
        Me.btnAddBuku.TextOffset = New System.Drawing.Point(0, 6)
        '
        'btnDelBuku
        '
        Me.btnDelBuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelBuku.Animated = True
        Me.btnDelBuku.BackColor = System.Drawing.Color.Transparent
        Me.btnDelBuku.BorderRadius = 6
        Me.btnDelBuku.CheckedState.Parent = Me.btnDelBuku
        Me.btnDelBuku.CustomImages.Parent = Me.btnDelBuku
        Me.btnDelBuku.FillColor = System.Drawing.Color.Silver
        Me.btnDelBuku.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelBuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelBuku.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelBuku.HoverState.Image = Global.Library.My.Resources.Resources.delete_rak1
        Me.btnDelBuku.HoverState.Parent = Me.btnDelBuku
        Me.btnDelBuku.Image = Global.Library.My.Resources.Resources.delete_rak
        Me.btnDelBuku.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btnDelBuku.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDelBuku.Location = New System.Drawing.Point(12, 266)
        Me.btnDelBuku.Name = "btnDelBuku"
        Me.btnDelBuku.ShadowDecoration.Depth = 31
        Me.btnDelBuku.ShadowDecoration.Enabled = True
        Me.btnDelBuku.ShadowDecoration.Parent = Me.btnDelBuku
        Me.btnDelBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDelBuku.Size = New System.Drawing.Size(80, 80)
        Me.btnDelBuku.TabIndex = 10
        Me.btnDelBuku.Text = "Delete"
        Me.btnDelBuku.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2TileButton2.Animated = True
        Me.Guna2TileButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.BorderRadius = 6
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton2.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TileButton2.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ImageOffset = New System.Drawing.Point(0, 15)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(110, 94)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Depth = 31
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(558, 329)
        Me.Guna2TileButton2.TabIndex = 13
        Me.Guna2TileButton2.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Data_Master_Bukufr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Bukufr"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgvDaftarBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dgvDaftarBuku As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents btnAddBuku As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnDelBuku As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents lblpengganti As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents id_buku As DataGridViewTextBoxColumn
    Friend WithEvents nama_buku As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents th_terbit As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents txtcaribuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btneditstok As Guna.UI2.WinForms.Guna2TileButton
End Class
