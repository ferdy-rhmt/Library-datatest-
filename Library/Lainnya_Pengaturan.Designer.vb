<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lainnya_Pengaturan
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnConfirmAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtdenda = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtbatasbuku = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtbatashari = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.txtbatasbuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbatashari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(379, 27)
        Me.Guna2Panel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.GunaLabel1.Location = New System.Drawing.Point(137, 5)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(101, 14)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Manent Library"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 42)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(137, 29)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Pengaturan"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnConfirmAdd
        '
        Me.btnConfirmAdd.Animated = True
        Me.btnConfirmAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmAdd.BorderRadius = 5
        Me.btnConfirmAdd.BorderThickness = 2
        Me.btnConfirmAdd.CheckedState.Parent = Me.btnConfirmAdd
        Me.btnConfirmAdd.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirmAdd.CustomImages.Parent = Me.btnConfirmAdd
        Me.btnConfirmAdd.FillColor = System.Drawing.Color.Silver
        Me.btnConfirmAdd.Font = New System.Drawing.Font("Roboto Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirmAdd.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnConfirmAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirmAdd.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfirmAdd.HoverState.Parent = Me.btnConfirmAdd
        Me.btnConfirmAdd.Location = New System.Drawing.Point(128, 237)
        Me.btnConfirmAdd.Name = "btnConfirmAdd"
        Me.btnConfirmAdd.ShadowDecoration.BorderRadius = 5
        Me.btnConfirmAdd.ShadowDecoration.Enabled = True
        Me.btnConfirmAdd.ShadowDecoration.Parent = Me.btnConfirmAdd
        Me.btnConfirmAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnConfirmAdd.Size = New System.Drawing.Size(110, 33)
        Me.btnConfirmAdd.TabIndex = 13
        Me.btnConfirmAdd.Text = "Confirm"
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.Animated = True
        Me.btnCancelAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelAdd.BorderRadius = 5
        Me.btnCancelAdd.BorderThickness = 2
        Me.btnCancelAdd.CheckedState.Parent = Me.btnCancelAdd
        Me.btnCancelAdd.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancelAdd.CustomImages.Parent = Me.btnCancelAdd
        Me.btnCancelAdd.FillColor = System.Drawing.Color.Silver
        Me.btnCancelAdd.Font = New System.Drawing.Font("Roboto Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancelAdd.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancelAdd.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelAdd.HoverState.Parent = Me.btnCancelAdd
        Me.btnCancelAdd.Location = New System.Drawing.Point(244, 237)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.ShadowDecoration.BorderRadius = 5
        Me.btnCancelAdd.ShadowDecoration.Enabled = True
        Me.btnCancelAdd.ShadowDecoration.Parent = Me.btnCancelAdd
        Me.btnCancelAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnCancelAdd.Size = New System.Drawing.Size(110, 33)
        Me.btnCancelAdd.TabIndex = 14
        Me.btnCancelAdd.Text = "Cancel"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Roboto Thin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel9.Location = New System.Drawing.Point(145, 292)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtdenda
        '
        Me.txtdenda.Animated = True
        Me.txtdenda.BackColor = System.Drawing.Color.Transparent
        Me.txtdenda.BorderRadius = 5
        Me.txtdenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdenda.DefaultText = "0"
        Me.txtdenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdenda.DisabledState.Parent = Me.txtdenda
        Me.txtdenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdenda.FocusedState.Parent = Me.txtdenda
        Me.txtdenda.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtdenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdenda.HoverState.Parent = Me.txtdenda
        Me.txtdenda.Location = New System.Drawing.Point(203, 182)
        Me.txtdenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdenda.Name = "txtdenda"
        Me.txtdenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdenda.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtdenda.PlaceholderText = ""
        Me.txtdenda.SelectedText = ""
        Me.txtdenda.SelectionStart = 1
        Me.txtdenda.ShadowDecoration.BorderRadius = 5
        Me.txtdenda.ShadowDecoration.Enabled = True
        Me.txtdenda.ShadowDecoration.Parent = Me.txtdenda
        Me.txtdenda.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtdenda.Size = New System.Drawing.Size(83, 32)
        Me.txtdenda.TabIndex = 17
        Me.txtdenda.TextOffset = New System.Drawing.Point(5, 0)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 102)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(155, 32)
        Me.GunaLabel3.TabIndex = 20
        Me.GunaLabel3.Text = "Batas Peminjaman Buku"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtbatasbuku
        '
        Me.txtbatasbuku.BackColor = System.Drawing.Color.Transparent
        Me.txtbatasbuku.BorderRadius = 5
        Me.txtbatasbuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbatasbuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbatasbuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbatasbuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbatasbuku.DisabledState.Parent = Me.txtbatasbuku
        Me.txtbatasbuku.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtbatasbuku.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.txtbatasbuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbatasbuku.FocusedState.Parent = Me.txtbatasbuku
        Me.txtbatasbuku.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatasbuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtbatasbuku.Location = New System.Drawing.Point(168, 102)
        Me.txtbatasbuku.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbatasbuku.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtbatasbuku.Name = "txtbatasbuku"
        Me.txtbatasbuku.ShadowDecoration.BorderRadius = 5
        Me.txtbatasbuku.ShadowDecoration.Enabled = True
        Me.txtbatasbuku.ShadowDecoration.Parent = Me.txtbatasbuku
        Me.txtbatasbuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtbatasbuku.Size = New System.Drawing.Size(118, 32)
        Me.txtbatasbuku.TabIndex = 23
        Me.txtbatasbuku.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtbatasbuku.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtbatasbuku.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(293, 102)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(61, 32)
        Me.GunaLabel5.TabIndex = 24
        Me.GunaLabel5.Text = "Buku"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 142)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(155, 32)
        Me.GunaLabel6.TabIndex = 25
        Me.GunaLabel6.Text = "Batas Hari Peminjaman"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtbatashari
        '
        Me.txtbatashari.BackColor = System.Drawing.Color.Transparent
        Me.txtbatashari.BorderRadius = 5
        Me.txtbatashari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbatashari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbatashari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbatashari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbatashari.DisabledState.Parent = Me.txtbatashari
        Me.txtbatashari.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtbatashari.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.txtbatashari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbatashari.FocusedState.Parent = Me.txtbatashari
        Me.txtbatashari.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatashari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtbatashari.Location = New System.Drawing.Point(168, 142)
        Me.txtbatashari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbatashari.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtbatashari.Name = "txtbatashari"
        Me.txtbatashari.ShadowDecoration.BorderRadius = 5
        Me.txtbatashari.ShadowDecoration.Enabled = True
        Me.txtbatashari.ShadowDecoration.Parent = Me.txtbatashari
        Me.txtbatashari.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtbatashari.Size = New System.Drawing.Size(118, 32)
        Me.txtbatashari.TabIndex = 26
        Me.txtbatashari.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtbatashari.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtbatashari.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(293, 142)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(61, 32)
        Me.GunaLabel7.TabIndex = 27
        Me.GunaLabel7.Text = "Hari"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(12, 182)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(115, 32)
        Me.GunaLabel8.TabIndex = 28
        Me.GunaLabel8.Text = "Denda Terlambat"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(293, 182)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(61, 32)
        Me.GunaLabel10.TabIndex = 29
        Me.GunaLabel10.Text = "perHari"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(164, 181)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(34, 32)
        Me.GunaLabel11.TabIndex = 30
        Me.GunaLabel11.Text = "Rp."
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GunaLabel11.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Lainnya_Pengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(379, 316)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.txtbatashari)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txtbatasbuku)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtdenda)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.btnConfirmAdd)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lainnya_Pengaturan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.txtbatasbuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbatashari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancelAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtdenda As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtbatashari As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtbatasbuku As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
