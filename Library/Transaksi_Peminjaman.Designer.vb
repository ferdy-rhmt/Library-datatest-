<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi_Peminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi_Peminjaman))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.txtpjmsekarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnamabuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttahunterbit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpenerbitbuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvsedangpinjam = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txttotalpinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtidagt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttanggal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtidpinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbataspinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnrefresh = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnamaagt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPinjamBuku = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvInputPinjaman = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.th_terbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.txtIDBuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtjmlpinjam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtkelassis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.txtjurusansis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.dgvsedangpinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInputPinjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel11)
        Me.GunaGradientPanel1.Controls.Add(Me.txtjurusansis)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaGradientPanel1.Controls.Add(Me.txtkelassis)
        Me.GunaGradientPanel1.Controls.Add(Me.txtpjmsekarang)
        Me.GunaGradientPanel1.Controls.Add(Me.txtnamabuku)
        Me.GunaGradientPanel1.Controls.Add(Me.txttahunterbit)
        Me.GunaGradientPanel1.Controls.Add(Me.txtpenerbitbuku)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvsedangpinjam)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2TileButton3)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel9)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaGradientPanel1.Controls.Add(Me.txttotalpinjam)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradientPanel1.Controls.Add(Me.txtidagt)
        Me.GunaGradientPanel1.Controls.Add(Me.txttanggal)
        Me.GunaGradientPanel1.Controls.Add(Me.txtidpinjam)
        Me.GunaGradientPanel1.Controls.Add(Me.txtbataspinjam)
        Me.GunaGradientPanel1.Controls.Add(Me.btnrefresh)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.txtnamaagt)
        Me.GunaGradientPanel1.Controls.Add(Me.btnPinjamBuku)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvInputPinjaman)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2TileButton2)
        Me.GunaGradientPanel1.Controls.Add(Me.txtIDBuku)
        Me.GunaGradientPanel1.Controls.Add(Me.txtjmlpinjam)
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
        'txtpjmsekarang
        '
        Me.txtpjmsekarang.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpjmsekarang.BackColor = System.Drawing.Color.Transparent
        Me.txtpjmsekarang.BorderRadius = 5
        Me.txtpjmsekarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpjmsekarang.DefaultText = "0"
        Me.txtpjmsekarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpjmsekarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpjmsekarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpjmsekarang.DisabledState.Parent = Me.txtpjmsekarang
        Me.txtpjmsekarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpjmsekarang.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtpjmsekarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpjmsekarang.FocusedState.Parent = Me.txtpjmsekarang
        Me.txtpjmsekarang.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpjmsekarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpjmsekarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpjmsekarang.HoverState.Parent = Me.txtpjmsekarang
        Me.txtpjmsekarang.Location = New System.Drawing.Point(781, 364)
        Me.txtpjmsekarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpjmsekarang.Name = "txtpjmsekarang"
        Me.txtpjmsekarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpjmsekarang.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtpjmsekarang.PlaceholderText = ""
        Me.txtpjmsekarang.SelectedText = ""
        Me.txtpjmsekarang.SelectionStart = 1
        Me.txtpjmsekarang.ShadowDecoration.Enabled = True
        Me.txtpjmsekarang.ShadowDecoration.Parent = Me.txtpjmsekarang
        Me.txtpjmsekarang.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtpjmsekarang.Size = New System.Drawing.Size(70, 25)
        Me.txtpjmsekarang.TabIndex = 50
        Me.txtpjmsekarang.TabStop = False
        Me.txtpjmsekarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpjmsekarang.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtnamabuku
        '
        Me.txtnamabuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnamabuku.BackColor = System.Drawing.Color.Transparent
        Me.txtnamabuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamabuku.DefaultText = ""
        Me.txtnamabuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamabuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamabuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamabuku.DisabledState.Parent = Me.txtnamabuku
        Me.txtnamabuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamabuku.Enabled = False
        Me.txtnamabuku.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtnamabuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamabuku.FocusedState.Parent = Me.txtnamabuku
        Me.txtnamabuku.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamabuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnamabuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamabuku.HoverState.Parent = Me.txtnamabuku
        Me.txtnamabuku.Location = New System.Drawing.Point(166, 139)
        Me.txtnamabuku.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnamabuku.Name = "txtnamabuku"
        Me.txtnamabuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamabuku.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtnamabuku.PlaceholderText = ""
        Me.txtnamabuku.ReadOnly = True
        Me.txtnamabuku.SelectedText = ""
        Me.txtnamabuku.ShadowDecoration.Enabled = True
        Me.txtnamabuku.ShadowDecoration.Parent = Me.txtnamabuku
        Me.txtnamabuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtnamabuku.Size = New System.Drawing.Size(251, 25)
        Me.txtnamabuku.TabIndex = 23
        Me.txtnamabuku.TabStop = False
        '
        'txttahunterbit
        '
        Me.txttahunterbit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttahunterbit.BackColor = System.Drawing.Color.Transparent
        Me.txttahunterbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttahunterbit.DefaultText = ""
        Me.txttahunterbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttahunterbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttahunterbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttahunterbit.DisabledState.Parent = Me.txttahunterbit
        Me.txttahunterbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttahunterbit.Enabled = False
        Me.txttahunterbit.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txttahunterbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttahunterbit.FocusedState.Parent = Me.txttahunterbit
        Me.txttahunterbit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttahunterbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txttahunterbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttahunterbit.HoverState.Parent = Me.txttahunterbit
        Me.txttahunterbit.Location = New System.Drawing.Point(632, 139)
        Me.txttahunterbit.Margin = New System.Windows.Forms.Padding(4)
        Me.txttahunterbit.Name = "txttahunterbit"
        Me.txttahunterbit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttahunterbit.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txttahunterbit.PlaceholderText = ""
        Me.txttahunterbit.ReadOnly = True
        Me.txttahunterbit.SelectedText = ""
        Me.txttahunterbit.ShadowDecoration.Enabled = True
        Me.txttahunterbit.ShadowDecoration.Parent = Me.txttahunterbit
        Me.txttahunterbit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txttahunterbit.Size = New System.Drawing.Size(111, 25)
        Me.txttahunterbit.TabIndex = 47
        Me.txttahunterbit.TabStop = False
        '
        'txtpenerbitbuku
        '
        Me.txtpenerbitbuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpenerbitbuku.BackColor = System.Drawing.Color.Transparent
        Me.txtpenerbitbuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpenerbitbuku.DefaultText = ""
        Me.txtpenerbitbuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpenerbitbuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpenerbitbuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpenerbitbuku.DisabledState.Parent = Me.txtpenerbitbuku
        Me.txtpenerbitbuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpenerbitbuku.Enabled = False
        Me.txtpenerbitbuku.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtpenerbitbuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpenerbitbuku.FocusedState.Parent = Me.txtpenerbitbuku
        Me.txtpenerbitbuku.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpenerbitbuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpenerbitbuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpenerbitbuku.HoverState.Parent = Me.txtpenerbitbuku
        Me.txtpenerbitbuku.Location = New System.Drawing.Point(417, 139)
        Me.txtpenerbitbuku.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpenerbitbuku.Name = "txtpenerbitbuku"
        Me.txtpenerbitbuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpenerbitbuku.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtpenerbitbuku.PlaceholderText = ""
        Me.txtpenerbitbuku.ReadOnly = True
        Me.txtpenerbitbuku.SelectedText = ""
        Me.txtpenerbitbuku.ShadowDecoration.Enabled = True
        Me.txtpenerbitbuku.ShadowDecoration.Parent = Me.txtpenerbitbuku
        Me.txtpenerbitbuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtpenerbitbuku.Size = New System.Drawing.Size(216, 25)
        Me.txtpenerbitbuku.TabIndex = 46
        Me.txtpenerbitbuku.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel4.AutoEllipsis = True
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 401)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(106, 17)
        Me.GunaLabel4.TabIndex = 45
        Me.GunaLabel4.Text = "Sedang dipinjam"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'dgvsedangpinjam
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvsedangpinjam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsedangpinjam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvsedangpinjam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsedangpinjam.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvsedangpinjam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvsedangpinjam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvsedangpinjam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsedangpinjam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsedangpinjam.ColumnHeadersHeight = 25
        Me.dgvsedangpinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsedangpinjam.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvsedangpinjam.EnableHeadersVisualStyles = False
        Me.dgvsedangpinjam.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvsedangpinjam.Location = New System.Drawing.Point(15, 421)
        Me.dgvsedangpinjam.MultiSelect = False
        Me.dgvsedangpinjam.Name = "dgvsedangpinjam"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsedangpinjam.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsedangpinjam.RowHeadersVisible = False
        Me.dgvsedangpinjam.RowTemplate.Height = 25
        Me.dgvsedangpinjam.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsedangpinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsedangpinjam.Size = New System.Drawing.Size(836, 137)
        Me.dgvsedangpinjam.TabIndex = 43
        Me.dgvsedangpinjam.TabStop = False
        Me.dgvsedangpinjam.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvsedangpinjam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvsedangpinjam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvsedangpinjam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvsedangpinjam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvsedangpinjam.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvsedangpinjam.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvsedangpinjam.ThemeStyle.ReadOnly = False
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.Height = 25
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvsedangpinjam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2TileButton3
        '
        Me.Guna2TileButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2TileButton3.Animated = True
        Me.Guna2TileButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton3.BorderRadius = 6
        Me.Guna2TileButton3.CheckedState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.CustomImages.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.FillColor = System.Drawing.Color.Gray
        Me.Guna2TileButton3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton3.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TileButton3.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.Guna2TileButton3.HoverState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.ImageOffset = New System.Drawing.Point(0, 15)
        Me.Guna2TileButton3.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2TileButton3.Location = New System.Drawing.Point(15, 421)
        Me.Guna2TileButton3.Name = "Guna2TileButton3"
        Me.Guna2TileButton3.ShadowDecoration.Depth = 31
        Me.Guna2TileButton3.ShadowDecoration.Enabled = True
        Me.Guna2TileButton3.ShadowDecoration.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton3.Size = New System.Drawing.Size(836, 137)
        Me.Guna2TileButton3.TabIndex = 44
        Me.Guna2TileButton3.TabStop = False
        Me.Guna2TileButton3.TextOffset = New System.Drawing.Point(0, 6)
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel9.AutoEllipsis = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(296, 78)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(77, 23)
        Me.GunaLabel9.TabIndex = 42
        Me.GunaLabel9.Text = "Nama"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel8.AutoEllipsis = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(296, 47)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(77, 23)
        Me.GunaLabel8.TabIndex = 41
        Me.GunaLabel8.Text = "ID Anggota"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel7
        '
        Me.GunaLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel7.AutoEllipsis = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(19, 78)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel7.TabIndex = 40
        Me.GunaLabel7.Text = "Tanggal"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel6
        '
        Me.GunaLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel6.AutoEllipsis = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(19, 47)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel6.TabIndex = 39
        Me.GunaLabel6.Text = "ID Pinjam"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel5.AutoEllipsis = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(734, 47)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(40, 23)
        Me.GunaLabel5.TabIndex = 38
        Me.GunaLabel5.Text = "Total"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txttotalpinjam
        '
        Me.txttotalpinjam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttotalpinjam.Animated = True
        Me.txttotalpinjam.BackColor = System.Drawing.Color.Transparent
        Me.txttotalpinjam.BorderRadius = 6
        Me.txttotalpinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalpinjam.DefaultText = ""
        Me.txttotalpinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotalpinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotalpinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalpinjam.DisabledState.Parent = Me.txttotalpinjam
        Me.txttotalpinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalpinjam.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txttotalpinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalpinjam.FocusedState.Parent = Me.txttotalpinjam
        Me.txttotalpinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalpinjam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txttotalpinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalpinjam.HoverState.Parent = Me.txttotalpinjam
        Me.txttotalpinjam.Location = New System.Drawing.Point(780, 47)
        Me.txttotalpinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotalpinjam.Name = "txttotalpinjam"
        Me.txttotalpinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalpinjam.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txttotalpinjam.PlaceholderText = ""
        Me.txttotalpinjam.ReadOnly = True
        Me.txttotalpinjam.SelectedText = ""
        Me.txttotalpinjam.ShadowDecoration.Enabled = True
        Me.txttotalpinjam.ShadowDecoration.Parent = Me.txttotalpinjam
        Me.txttotalpinjam.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txttotalpinjam.Size = New System.Drawing.Size(71, 23)
        Me.txttotalpinjam.TabIndex = 37
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel3.AutoEllipsis = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(734, 78)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(40, 23)
        Me.GunaLabel3.TabIndex = 36
        Me.GunaLabel3.Text = "Batas"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtidagt
        '
        Me.txtidagt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtidagt.Animated = True
        Me.txtidagt.BackColor = System.Drawing.Color.Transparent
        Me.txtidagt.BorderRadius = 6
        Me.txtidagt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidagt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidagt.DefaultText = ""
        Me.txtidagt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidagt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidagt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidagt.DisabledState.Parent = Me.txtidagt
        Me.txtidagt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidagt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtidagt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidagt.FocusedState.Parent = Me.txtidagt
        Me.txtidagt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidagt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidagt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidagt.HoverState.Parent = Me.txtidagt
        Me.txtidagt.Location = New System.Drawing.Point(380, 47)
        Me.txtidagt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidagt.Name = "txtidagt"
        Me.txtidagt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidagt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtidagt.PlaceholderText = ""
        Me.txtidagt.SelectedText = ""
        Me.txtidagt.ShadowDecoration.Enabled = True
        Me.txtidagt.ShadowDecoration.Parent = Me.txtidagt
        Me.txtidagt.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtidagt.Size = New System.Drawing.Size(192, 23)
        Me.txtidagt.TabIndex = 35
        '
        'txttanggal
        '
        Me.txttanggal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttanggal.Animated = True
        Me.txttanggal.BackColor = System.Drawing.Color.Transparent
        Me.txttanggal.BorderRadius = 6
        Me.txttanggal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttanggal.DefaultText = "2021-02-09"
        Me.txttanggal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttanggal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttanggal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttanggal.DisabledState.Parent = Me.txttanggal
        Me.txttanggal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttanggal.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txttanggal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttanggal.FocusedState.Parent = Me.txttanggal
        Me.txttanggal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txttanggal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttanggal.HoverState.Parent = Me.txttanggal
        Me.txttanggal.Location = New System.Drawing.Point(95, 78)
        Me.txttanggal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttanggal.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txttanggal.PlaceholderText = "Tanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.SelectedText = ""
        Me.txttanggal.SelectionStart = 10
        Me.txttanggal.ShadowDecoration.Enabled = True
        Me.txttanggal.ShadowDecoration.Parent = Me.txttanggal
        Me.txttanggal.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txttanggal.Size = New System.Drawing.Size(194, 23)
        Me.txttanggal.TabIndex = 34
        '
        'txtidpinjam
        '
        Me.txtidpinjam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtidpinjam.Animated = True
        Me.txtidpinjam.BackColor = System.Drawing.Color.Transparent
        Me.txtidpinjam.BorderRadius = 6
        Me.txtidpinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidpinjam.DefaultText = ""
        Me.txtidpinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidpinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidpinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidpinjam.DisabledState.Parent = Me.txtidpinjam
        Me.txtidpinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidpinjam.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtidpinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidpinjam.FocusedState.Parent = Me.txtidpinjam
        Me.txtidpinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpinjam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidpinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidpinjam.HoverState.Parent = Me.txtidpinjam
        Me.txtidpinjam.Location = New System.Drawing.Point(95, 47)
        Me.txtidpinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidpinjam.Name = "txtidpinjam"
        Me.txtidpinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidpinjam.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtidpinjam.PlaceholderText = "ID Peminjaman"
        Me.txtidpinjam.ReadOnly = True
        Me.txtidpinjam.SelectedText = ""
        Me.txtidpinjam.ShadowDecoration.Enabled = True
        Me.txtidpinjam.ShadowDecoration.Parent = Me.txtidpinjam
        Me.txtidpinjam.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtidpinjam.Size = New System.Drawing.Size(194, 23)
        Me.txtidpinjam.TabIndex = 28
        '
        'txtbataspinjam
        '
        Me.txtbataspinjam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbataspinjam.Animated = True
        Me.txtbataspinjam.BackColor = System.Drawing.Color.Transparent
        Me.txtbataspinjam.BorderRadius = 6
        Me.txtbataspinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbataspinjam.DefaultText = ""
        Me.txtbataspinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbataspinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbataspinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbataspinjam.DisabledState.Parent = Me.txtbataspinjam
        Me.txtbataspinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbataspinjam.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtbataspinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbataspinjam.FocusedState.Parent = Me.txtbataspinjam
        Me.txtbataspinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbataspinjam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtbataspinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbataspinjam.HoverState.Parent = Me.txtbataspinjam
        Me.txtbataspinjam.Location = New System.Drawing.Point(780, 78)
        Me.txtbataspinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbataspinjam.Name = "txtbataspinjam"
        Me.txtbataspinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbataspinjam.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtbataspinjam.PlaceholderText = ""
        Me.txtbataspinjam.ReadOnly = True
        Me.txtbataspinjam.SelectedText = ""
        Me.txtbataspinjam.ShadowDecoration.Enabled = True
        Me.txtbataspinjam.ShadowDecoration.Parent = Me.txtbataspinjam
        Me.txtbataspinjam.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtbataspinjam.Size = New System.Drawing.Size(71, 23)
        Me.txtbataspinjam.TabIndex = 25
        '
        'btnrefresh
        '
        Me.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnrefresh.Animated = True
        Me.btnrefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnrefresh.BorderRadius = 6
        Me.btnrefresh.CheckedState.Parent = Me.btnrefresh
        Me.btnrefresh.CustomImages.Parent = Me.btnrefresh
        Me.btnrefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnrefresh.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnrefresh.HoverState.Parent = Me.btnrefresh
        Me.btnrefresh.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnrefresh.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnrefresh.Location = New System.Drawing.Point(264, 364)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.ShadowDecoration.Depth = 31
        Me.btnrefresh.ShadowDecoration.Enabled = True
        Me.btnrefresh.ShadowDecoration.Parent = Me.btnrefresh
        Me.btnrefresh.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnrefresh.Size = New System.Drawing.Size(243, 34)
        Me.btnrefresh.TabIndex = 24
        Me.btnrefresh.TabStop = False
        Me.btnrefresh.Text = "Refresh"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel1.AutoEllipsis = True
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(15, 114)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(111, 17)
        Me.GunaLabel1.TabIndex = 19
        Me.GunaLabel1.Text = "Input Peminjaman"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtnamaagt
        '
        Me.txtnamaagt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnamaagt.Animated = True
        Me.txtnamaagt.BackColor = System.Drawing.Color.Transparent
        Me.txtnamaagt.BorderRadius = 6
        Me.txtnamaagt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamaagt.DefaultText = ""
        Me.txtnamaagt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamaagt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamaagt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamaagt.DisabledState.Parent = Me.txtnamaagt
        Me.txtnamaagt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamaagt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtnamaagt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamaagt.FocusedState.Parent = Me.txtnamaagt
        Me.txtnamaagt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaagt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnamaagt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamaagt.HoverState.Parent = Me.txtnamaagt
        Me.txtnamaagt.Location = New System.Drawing.Point(380, 78)
        Me.txtnamaagt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnamaagt.Name = "txtnamaagt"
        Me.txtnamaagt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamaagt.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtnamaagt.PlaceholderText = "Nama"
        Me.txtnamaagt.ReadOnly = True
        Me.txtnamaagt.SelectedText = ""
        Me.txtnamaagt.ShadowDecoration.Enabled = True
        Me.txtnamaagt.ShadowDecoration.Parent = Me.txtnamaagt
        Me.txtnamaagt.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtnamaagt.Size = New System.Drawing.Size(189, 23)
        Me.txtnamaagt.TabIndex = 16
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
        Me.btnPinjamBuku.Location = New System.Drawing.Point(15, 364)
        Me.btnPinjamBuku.Name = "btnPinjamBuku"
        Me.btnPinjamBuku.ShadowDecoration.Depth = 31
        Me.btnPinjamBuku.ShadowDecoration.Enabled = True
        Me.btnPinjamBuku.ShadowDecoration.Parent = Me.btnPinjamBuku
        Me.btnPinjamBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnPinjamBuku.Size = New System.Drawing.Size(243, 34)
        Me.btnPinjamBuku.TabIndex = 15
        Me.btnPinjamBuku.TabStop = False
        Me.btnPinjamBuku.Text = "Pinjam Buku"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Product Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(159, 30)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = " - Peminjaman"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'dgvInputPinjaman
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvInputPinjaman.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInputPinjaman.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvInputPinjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInputPinjaman.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvInputPinjaman.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInputPinjaman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInputPinjaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInputPinjaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInputPinjaman.ColumnHeadersHeight = 24
        Me.dgvInputPinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInputPinjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_buku, Me.judul, Me.penerbit, Me.th_terbit, Me.jumlah})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInputPinjaman.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInputPinjaman.EnableHeadersVisualStyles = False
        Me.dgvInputPinjaman.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvInputPinjaman.Location = New System.Drawing.Point(15, 171)
        Me.dgvInputPinjaman.MultiSelect = False
        Me.dgvInputPinjaman.Name = "dgvInputPinjaman"
        Me.dgvInputPinjaman.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInputPinjaman.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInputPinjaman.RowHeadersVisible = False
        Me.dgvInputPinjaman.RowTemplate.Height = 25
        Me.dgvInputPinjaman.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInputPinjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInputPinjaman.Size = New System.Drawing.Size(836, 187)
        Me.dgvInputPinjaman.TabIndex = 8
        Me.dgvInputPinjaman.TabStop = False
        Me.dgvInputPinjaman.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvInputPinjaman.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInputPinjaman.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInputPinjaman.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInputPinjaman.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInputPinjaman.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInputPinjaman.ThemeStyle.HeaderStyle.Height = 24
        Me.dgvInputPinjaman.ThemeStyle.ReadOnly = True
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.Height = 25
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvInputPinjaman.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_buku
        '
        Me.id_buku.FillWeight = 70.0!
        Me.id_buku.HeaderText = "ID Buku"
        Me.id_buku.Name = "id_buku"
        Me.id_buku.ReadOnly = True
        '
        'judul
        '
        Me.judul.FillWeight = 115.0!
        Me.judul.HeaderText = "Judul"
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.Name = "penerbit"
        Me.penerbit.ReadOnly = True
        '
        'th_terbit
        '
        Me.th_terbit.FillWeight = 50.0!
        Me.th_terbit.HeaderText = "Tahun"
        Me.th_terbit.Name = "th_terbit"
        Me.th_terbit.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.FillWeight = 50.0!
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
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
        Me.Guna2TileButton2.Location = New System.Drawing.Point(15, 171)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Depth = 31
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(836, 187)
        Me.Guna2TileButton2.TabIndex = 13
        Me.Guna2TileButton2.TabStop = False
        Me.Guna2TileButton2.TextOffset = New System.Drawing.Point(0, 6)
        '
        'txtIDBuku
        '
        Me.txtIDBuku.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIDBuku.BackColor = System.Drawing.Color.Transparent
        Me.txtIDBuku.BorderRadius = 5
        Me.txtIDBuku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDBuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDBuku.DefaultText = ""
        Me.txtIDBuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIDBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIDBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDBuku.DisabledState.Parent = Me.txtIDBuku
        Me.txtIDBuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDBuku.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtIDBuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDBuku.FocusedState.Parent = Me.txtIDBuku
        Me.txtIDBuku.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDBuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtIDBuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDBuku.HoverState.Parent = Me.txtIDBuku
        Me.txtIDBuku.Location = New System.Drawing.Point(15, 139)
        Me.txtIDBuku.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDBuku.Name = "txtIDBuku"
        Me.txtIDBuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDBuku.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtIDBuku.PlaceholderText = "BK00001"
        Me.txtIDBuku.SelectedText = ""
        Me.txtIDBuku.ShadowDecoration.Enabled = True
        Me.txtIDBuku.ShadowDecoration.Parent = Me.txtIDBuku
        Me.txtIDBuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtIDBuku.Size = New System.Drawing.Size(157, 25)
        Me.txtIDBuku.TabIndex = 49
        Me.txtIDBuku.TabStop = False
        '
        'txtjmlpinjam
        '
        Me.txtjmlpinjam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtjmlpinjam.BackColor = System.Drawing.Color.Transparent
        Me.txtjmlpinjam.BorderRadius = 5
        Me.txtjmlpinjam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjmlpinjam.DefaultText = "0"
        Me.txtjmlpinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtjmlpinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtjmlpinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjmlpinjam.DisabledState.Parent = Me.txtjmlpinjam
        Me.txtjmlpinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjmlpinjam.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtjmlpinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjmlpinjam.FocusedState.Parent = Me.txtjmlpinjam
        Me.txtjmlpinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjmlpinjam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtjmlpinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjmlpinjam.HoverState.Parent = Me.txtjmlpinjam
        Me.txtjmlpinjam.Location = New System.Drawing.Point(739, 139)
        Me.txtjmlpinjam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjmlpinjam.Name = "txtjmlpinjam"
        Me.txtjmlpinjam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjmlpinjam.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtjmlpinjam.PlaceholderText = ""
        Me.txtjmlpinjam.SelectedText = ""
        Me.txtjmlpinjam.SelectionStart = 1
        Me.txtjmlpinjam.ShadowDecoration.Enabled = True
        Me.txtjmlpinjam.ShadowDecoration.Parent = Me.txtjmlpinjam
        Me.txtjmlpinjam.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtjmlpinjam.Size = New System.Drawing.Size(108, 25)
        Me.txtjmlpinjam.TabIndex = 48
        Me.txtjmlpinjam.TabStop = False
        Me.txtjmlpinjam.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvsedangpinjam
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.dgvInputPinjaman
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel10.AutoEllipsis = True
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(579, 47)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(51, 23)
        Me.GunaLabel10.TabIndex = 52
        Me.GunaLabel10.Text = "Kelas"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtkelassis
        '
        Me.txtkelassis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtkelassis.Animated = True
        Me.txtkelassis.BackColor = System.Drawing.Color.Transparent
        Me.txtkelassis.BorderRadius = 6
        Me.txtkelassis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkelassis.DefaultText = ""
        Me.txtkelassis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtkelassis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtkelassis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkelassis.DisabledState.Parent = Me.txtkelassis
        Me.txtkelassis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkelassis.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtkelassis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkelassis.FocusedState.Parent = Me.txtkelassis
        Me.txtkelassis.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkelassis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtkelassis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkelassis.HoverState.Parent = Me.txtkelassis
        Me.txtkelassis.Location = New System.Drawing.Point(637, 47)
        Me.txtkelassis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtkelassis.Name = "txtkelassis"
        Me.txtkelassis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkelassis.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtkelassis.PlaceholderText = ""
        Me.txtkelassis.ReadOnly = True
        Me.txtkelassis.SelectedText = ""
        Me.txtkelassis.ShadowDecoration.Enabled = True
        Me.txtkelassis.ShadowDecoration.Parent = Me.txtkelassis
        Me.txtkelassis.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtkelassis.Size = New System.Drawing.Size(90, 23)
        Me.txtkelassis.TabIndex = 51
        '
        'GunaLabel11
        '
        Me.GunaLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel11.AutoEllipsis = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(576, 78)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(54, 23)
        Me.GunaLabel11.TabIndex = 54
        Me.GunaLabel11.Text = "Jurusan"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel11.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtjurusansis
        '
        Me.txtjurusansis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtjurusansis.Animated = True
        Me.txtjurusansis.BackColor = System.Drawing.Color.Transparent
        Me.txtjurusansis.BorderRadius = 6
        Me.txtjurusansis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjurusansis.DefaultText = ""
        Me.txtjurusansis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtjurusansis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtjurusansis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjurusansis.DisabledState.Parent = Me.txtjurusansis
        Me.txtjurusansis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjurusansis.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtjurusansis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjurusansis.FocusedState.Parent = Me.txtjurusansis
        Me.txtjurusansis.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjurusansis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtjurusansis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjurusansis.HoverState.Parent = Me.txtjurusansis
        Me.txtjurusansis.Location = New System.Drawing.Point(637, 78)
        Me.txtjurusansis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtjurusansis.Name = "txtjurusansis"
        Me.txtjurusansis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjurusansis.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtjurusansis.PlaceholderText = ""
        Me.txtjurusansis.ReadOnly = True
        Me.txtjurusansis.SelectedText = ""
        Me.txtjurusansis.ShadowDecoration.Enabled = True
        Me.txtjurusansis.ShadowDecoration.Parent = Me.txtjurusansis
        Me.txtjurusansis.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.txtjurusansis.Size = New System.Drawing.Size(90, 23)
        Me.txtjurusansis.TabIndex = 53
        '
        'Transaksi_Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(860, 580)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi_Peminjaman"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.dgvsedangpinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInputPinjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvInputPinjaman As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtnamaagt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPinjamBuku As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtnamabuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnrefresh As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtidpinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbataspinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttotalpinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtidagt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txttanggal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txttahunterbit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpenerbitbuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgvsedangpinjam As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents id_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents th_terbit As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents txtIDBuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtjmlpinjam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpjmsekarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtjurusansis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtkelassis As Guna.UI2.WinForms.Guna2TextBox
End Class
