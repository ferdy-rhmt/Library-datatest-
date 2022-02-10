<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Anggotafr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Master_Anggotafr))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvAddAnggota = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.txtcarinama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnDelAnggota = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btnAddAnggota = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        CType(Me.dgvAddAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvAddAnggota
        '
        'dgvAddAnggota
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvAddAnggota.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAddAnggota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvAddAnggota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddAnggota.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAnggota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAddAnggota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAddAnggota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddAnggota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAddAnggota.ColumnHeadersHeight = 21
        Me.dgvAddAnggota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_siswa, Me.nama_siswa, Me.kelas_siswa, Me.jurusan_siswa})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAddAnggota.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAddAnggota.EnableHeadersVisualStyles = False
        Me.dgvAddAnggota.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvAddAnggota.Location = New System.Drawing.Point(134, 92)
        Me.dgvAddAnggota.Name = "dgvAddAnggota"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddAnggota.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAddAnggota.RowHeadersVisible = False
        Me.dgvAddAnggota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAddAnggota.Size = New System.Drawing.Size(533, 338)
        Me.dgvAddAnggota.TabIndex = 0
        Me.dgvAddAnggota.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvAddAnggota.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAddAnggota.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAddAnggota.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAddAnggota.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAddAnggota.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAddAnggota.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvAddAnggota.ThemeStyle.ReadOnly = False
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvAddAnggota.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_siswa
        '
        Me.id_siswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_siswa.FillWeight = 55.0!
        Me.id_siswa.HeaderText = "ID"
        Me.id_siswa.Name = "id_siswa"
        '
        'nama_siswa
        '
        Me.nama_siswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_siswa.FillWeight = 125.0!
        Me.nama_siswa.HeaderText = "Nama Siswa"
        Me.nama_siswa.Name = "nama_siswa"
        Me.nama_siswa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'kelas_siswa
        '
        Me.kelas_siswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kelas_siswa.FillWeight = 50.0!
        Me.kelas_siswa.HeaderText = "Kelas"
        Me.kelas_siswa.Name = "kelas_siswa"
        '
        'jurusan_siswa
        '
        Me.jurusan_siswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jurusan_siswa.FillWeight = 135.0!
        Me.jurusan_siswa.HeaderText = "Jurusan"
        Me.jurusan_siswa.Name = "jurusan_siswa"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.txtcarinama)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvAddAnggota)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.btnDelAnggota)
        Me.GunaGradientPanel1.Controls.Add(Me.btnAddAnggota)
        Me.GunaGradientPanel1.Controls.Add(Me.Guna2TileButton1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(1, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(680, 455)
        Me.GunaGradientPanel1.TabIndex = 2
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'txtcarinama
        '
        Me.txtcarinama.BorderRadius = 6
        Me.txtcarinama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcarinama.DefaultText = ""
        Me.txtcarinama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcarinama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcarinama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcarinama.DisabledState.Parent = Me.txtcarinama
        Me.txtcarinama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcarinama.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtcarinama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcarinama.FocusedState.Parent = Me.txtcarinama
        Me.txtcarinama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcarinama.HoverState.Parent = Me.txtcarinama
        Me.txtcarinama.Location = New System.Drawing.Point(134, 60)
        Me.txtcarinama.Name = "txtcarinama"
        Me.txtcarinama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcarinama.PlaceholderText = "Cari Nama..."
        Me.txtcarinama.SelectedText = ""
        Me.txtcarinama.ShadowDecoration.Parent = Me.txtcarinama
        Me.txtcarinama.Size = New System.Drawing.Size(219, 26)
        Me.txtcarinama.TabIndex = 14
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(125, 29)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = " - Anggota"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnDelAnggota
        '
        Me.btnDelAnggota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelAnggota.Animated = True
        Me.btnDelAnggota.BackColor = System.Drawing.Color.Transparent
        Me.btnDelAnggota.BorderRadius = 5
        Me.btnDelAnggota.CheckedState.Parent = Me.btnDelAnggota
        Me.btnDelAnggota.CustomImages.Parent = Me.btnDelAnggota
        Me.btnDelAnggota.FillColor = System.Drawing.Color.Silver
        Me.btnDelAnggota.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAnggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelAnggota.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelAnggota.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelAnggota.HoverState.Image = Global.Library.My.Resources.Resources.delete_user1
        Me.btnDelAnggota.HoverState.Parent = Me.btnDelAnggota
        Me.btnDelAnggota.Image = Global.Library.My.Resources.Resources.delete_user
        Me.btnDelAnggota.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDelAnggota.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDelAnggota.Location = New System.Drawing.Point(13, 223)
        Me.btnDelAnggota.Name = "btnDelAnggota"
        Me.btnDelAnggota.ShadowDecoration.BorderRadius = 5
        Me.btnDelAnggota.ShadowDecoration.Enabled = True
        Me.btnDelAnggota.ShadowDecoration.Parent = Me.btnDelAnggota
        Me.btnDelAnggota.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDelAnggota.Size = New System.Drawing.Size(115, 125)
        Me.btnDelAnggota.TabIndex = 4
        Me.btnDelAnggota.Text = "Delete"
        Me.btnDelAnggota.TextOffset = New System.Drawing.Point(0, 6)
        '
        'btnAddAnggota
        '
        Me.btnAddAnggota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddAnggota.Animated = True
        Me.btnAddAnggota.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAnggota.BorderRadius = 5
        Me.btnAddAnggota.CheckedState.Parent = Me.btnAddAnggota
        Me.btnAddAnggota.CustomImages.Parent = Me.btnAddAnggota
        Me.btnAddAnggota.FillColor = System.Drawing.Color.Silver
        Me.btnAddAnggota.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAnggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddAnggota.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddAnggota.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAnggota.HoverState.Image = Global.Library.My.Resources.Resources.add_friend1
        Me.btnAddAnggota.HoverState.Parent = Me.btnAddAnggota
        Me.btnAddAnggota.Image = Global.Library.My.Resources.Resources.add_friend
        Me.btnAddAnggota.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnAddAnggota.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnAddAnggota.Location = New System.Drawing.Point(13, 92)
        Me.btnAddAnggota.Name = "btnAddAnggota"
        Me.btnAddAnggota.ShadowDecoration.BorderRadius = 5
        Me.btnAddAnggota.ShadowDecoration.Enabled = True
        Me.btnAddAnggota.ShadowDecoration.Parent = Me.btnAddAnggota
        Me.btnAddAnggota.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnAddAnggota.Size = New System.Drawing.Size(115, 125)
        Me.btnAddAnggota.TabIndex = 3
        Me.btnAddAnggota.Text = "Add"
        Me.btnAddAnggota.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2TileButton1.Animated = True
        Me.Guna2TileButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton1.BorderRadius = 6
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2TileButton1.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TileButton1.HoverState.Image = Global.Library.My.Resources.Resources.add_rak1
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.ImageOffset = New System.Drawing.Point(0, 15)
        Me.Guna2TileButton1.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2TileButton1.Location = New System.Drawing.Point(134, 92)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Depth = 31
        Me.Guna2TileButton1.ShadowDecoration.Enabled = True
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton1.Size = New System.Drawing.Size(533, 338)
        Me.Guna2TileButton1.TabIndex = 13
        Me.Guna2TileButton1.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Data_Master_Anggotafr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Anggotafr"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvAddAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents dgvAddAnggota As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnDelAnggota As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnAddAnggota As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcarinama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents id_siswa As DataGridViewTextBoxColumn
    Friend WithEvents nama_siswa As DataGridViewTextBoxColumn
    Friend WithEvents kelas_siswa As DataGridViewTextBoxColumn
    Friend WithEvents jurusan_siswa As DataGridViewTextBoxColumn
End Class
