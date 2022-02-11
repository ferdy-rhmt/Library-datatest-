<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Adminfr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Master_Adminfr))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvAddAdmin = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_admin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Admin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pwd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.lblidadmin = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnDelAdmin = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btnAddAdmin = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        CType(Me.dgvAddAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvAddAdmin
        '
        'dgvAddAdmin
        '
        Me.dgvAddAdmin.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvAddAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAddAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvAddAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddAdmin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAddAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAddAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAddAdmin.ColumnHeadersHeight = 21
        Me.dgvAddAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_admin, Me.Name_Admin, Me.pwd, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAddAdmin.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAddAdmin.EnableHeadersVisualStyles = False
        Me.dgvAddAdmin.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvAddAdmin.Location = New System.Drawing.Point(239, 38)
        Me.dgvAddAdmin.Name = "dgvAddAdmin"
        Me.dgvAddAdmin.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAddAdmin.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAddAdmin.RowHeadersVisible = False
        Me.dgvAddAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAddAdmin.Size = New System.Drawing.Size(428, 353)
        Me.dgvAddAdmin.TabIndex = 0
        Me.dgvAddAdmin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple
        Me.dgvAddAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAddAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAddAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAddAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAddAdmin.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAddAdmin.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvAddAdmin.ThemeStyle.ReadOnly = True
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvAddAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_admin
        '
        Me.id_admin.HeaderText = "ID Admin"
        Me.id_admin.Name = "id_admin"
        Me.id_admin.ReadOnly = True
        '
        'Name_Admin
        '
        Me.Name_Admin.HeaderText = "Name"
        Me.Name_Admin.Name = "Name_Admin"
        Me.Name_Admin.ReadOnly = True
        '
        'pwd
        '
        Me.pwd.HeaderText = "Password"
        Me.pwd.Name = "pwd"
        Me.pwd.ReadOnly = True
        Me.pwd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column1
        '
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "Level"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.lblidadmin)
        Me.GunaGradientPanel1.Controls.Add(Me.dgvAddAdmin)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.btnDelAdmin)
        Me.GunaGradientPanel1.Controls.Add(Me.btnAddAdmin)
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
        'lblidadmin
        '
        Me.lblidadmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblidadmin.AutoEllipsis = True
        Me.lblidadmin.AutoSize = True
        Me.lblidadmin.BackColor = System.Drawing.Color.Transparent
        Me.lblidadmin.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidadmin.ForeColor = System.Drawing.Color.Gray
        Me.lblidadmin.Location = New System.Drawing.Point(664, 440)
        Me.lblidadmin.Name = "lblidadmin"
        Me.lblidadmin.Size = New System.Drawing.Size(13, 15)
        Me.lblidadmin.TabIndex = 14
        Me.lblidadmin.Text = "_"
        Me.lblidadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblidadmin.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
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
        Me.GunaLabel2.Size = New System.Drawing.Size(104, 29)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = " - Admin"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnDelAdmin
        '
        Me.btnDelAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelAdmin.Animated = True
        Me.btnDelAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnDelAdmin.BorderRadius = 5
        Me.btnDelAdmin.CheckedState.Parent = Me.btnDelAdmin
        Me.btnDelAdmin.CustomImages.Parent = Me.btnDelAdmin
        Me.btnDelAdmin.FillColor = System.Drawing.Color.Silver
        Me.btnDelAdmin.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDelAdmin.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelAdmin.HoverState.Image = Global.Library.My.Resources.Resources.delete_user1
        Me.btnDelAdmin.HoverState.Parent = Me.btnDelAdmin
        Me.btnDelAdmin.Image = Global.Library.My.Resources.Resources.delete_user
        Me.btnDelAdmin.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnDelAdmin.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDelAdmin.Location = New System.Drawing.Point(57, 233)
        Me.btnDelAdmin.Name = "btnDelAdmin"
        Me.btnDelAdmin.ShadowDecoration.BorderRadius = 5
        Me.btnDelAdmin.ShadowDecoration.Enabled = True
        Me.btnDelAdmin.ShadowDecoration.Parent = Me.btnDelAdmin
        Me.btnDelAdmin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnDelAdmin.Size = New System.Drawing.Size(150, 151)
        Me.btnDelAdmin.TabIndex = 4
        Me.btnDelAdmin.Text = "Delete"
        Me.btnDelAdmin.TextOffset = New System.Drawing.Point(0, 6)
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddAdmin.Animated = True
        Me.btnAddAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAdmin.BorderRadius = 5
        Me.btnAddAdmin.CheckedState.Parent = Me.btnAddAdmin
        Me.btnAddAdmin.CustomImages.Parent = Me.btnAddAdmin
        Me.btnAddAdmin.FillColor = System.Drawing.Color.Silver
        Me.btnAddAdmin.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddAdmin.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAdmin.HoverState.Image = Global.Library.My.Resources.Resources.add_friend1
        Me.btnAddAdmin.HoverState.Parent = Me.btnAddAdmin
        Me.btnAddAdmin.Image = Global.Library.My.Resources.Resources.add_friend
        Me.btnAddAdmin.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btnAddAdmin.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnAddAdmin.Location = New System.Drawing.Point(57, 44)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.ShadowDecoration.BorderRadius = 5
        Me.btnAddAdmin.ShadowDecoration.Enabled = True
        Me.btnAddAdmin.ShadowDecoration.Parent = Me.btnAddAdmin
        Me.btnAddAdmin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.btnAddAdmin.Size = New System.Drawing.Size(150, 151)
        Me.btnAddAdmin.TabIndex = 3
        Me.btnAddAdmin.Text = "Add"
        Me.btnAddAdmin.TextOffset = New System.Drawing.Point(0, 6)
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
        Me.Guna2TileButton1.Location = New System.Drawing.Point(239, 38)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Depth = 31
        Me.Guna2TileButton1.ShadowDecoration.Enabled = True
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2TileButton1.Size = New System.Drawing.Size(428, 353)
        Me.Guna2TileButton1.TabIndex = 13
        Me.Guna2TileButton1.TextOffset = New System.Drawing.Point(0, 6)
        '
        'Data_Master_Adminfr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(680, 455)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Adminfr"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvAddAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents dgvAddAdmin As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnDelAdmin As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnAddAdmin As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents lblidadmin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents id_admin As DataGridViewTextBoxColumn
    Friend WithEvents Name_Admin As DataGridViewTextBoxColumn
    Friend WithEvents pwd As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
