<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Bukufr_Editstok
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
        Me.txtidbuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConfirmAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnamabuku = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpenerbit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtterbit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtstok = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.txtstok, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(295, 27)
        Me.Guna2Panel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.GunaLabel1.Location = New System.Drawing.Point(95, 7)
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
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 46)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(111, 29)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Edit Stok"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtidbuku
        '
        Me.txtidbuku.BackColor = System.Drawing.Color.Transparent
        Me.txtidbuku.BorderRadius = 5
        Me.txtidbuku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidbuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidbuku.DefaultText = ""
        Me.txtidbuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidbuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidbuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidbuku.DisabledState.Parent = Me.txtidbuku
        Me.txtidbuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidbuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidbuku.FocusedState.Parent = Me.txtidbuku
        Me.txtidbuku.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidbuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidbuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidbuku.HoverState.Parent = Me.txtidbuku
        Me.txtidbuku.Location = New System.Drawing.Point(26, 111)
        Me.txtidbuku.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidbuku.Name = "txtidbuku"
        Me.txtidbuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidbuku.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidbuku.PlaceholderText = ""
        Me.txtidbuku.SelectedText = ""
        Me.txtidbuku.ShadowDecoration.BorderRadius = 5
        Me.txtidbuku.ShadowDecoration.Enabled = True
        Me.txtidbuku.ShadowDecoration.Parent = Me.txtidbuku
        Me.txtidbuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtidbuku.Size = New System.Drawing.Size(244, 34)
        Me.txtidbuku.TabIndex = 1
        Me.txtidbuku.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnConfirmAdd
        '
        Me.btnConfirmAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.btnConfirmAdd.Location = New System.Drawing.Point(26, 366)
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
        Me.btnCancelAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.btnCancelAdd.Location = New System.Drawing.Point(160, 366)
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
        Me.GunaLabel9.Location = New System.Drawing.Point(106, 418)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtnamabuku
        '
        Me.txtnamabuku.Animated = True
        Me.txtnamabuku.BackColor = System.Drawing.Color.Transparent
        Me.txtnamabuku.BorderRadius = 5
        Me.txtnamabuku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamabuku.DefaultText = ""
        Me.txtnamabuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamabuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamabuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamabuku.DisabledState.Parent = Me.txtnamabuku
        Me.txtnamabuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamabuku.Enabled = False
        Me.txtnamabuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamabuku.FocusedState.Parent = Me.txtnamabuku
        Me.txtnamabuku.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamabuku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnamabuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamabuku.HoverState.Parent = Me.txtnamabuku
        Me.txtnamabuku.Location = New System.Drawing.Point(26, 157)
        Me.txtnamabuku.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnamabuku.Name = "txtnamabuku"
        Me.txtnamabuku.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamabuku.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnamabuku.PlaceholderText = "Nama Buku"
        Me.txtnamabuku.SelectedText = ""
        Me.txtnamabuku.ShadowDecoration.BorderRadius = 5
        Me.txtnamabuku.ShadowDecoration.Enabled = True
        Me.txtnamabuku.ShadowDecoration.Parent = Me.txtnamabuku
        Me.txtnamabuku.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtnamabuku.Size = New System.Drawing.Size(244, 32)
        Me.txtnamabuku.TabIndex = 16
        '
        'txtpenerbit
        '
        Me.txtpenerbit.Animated = True
        Me.txtpenerbit.BackColor = System.Drawing.Color.Transparent
        Me.txtpenerbit.BorderRadius = 5
        Me.txtpenerbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpenerbit.DefaultText = ""
        Me.txtpenerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpenerbit.DisabledState.Parent = Me.txtpenerbit
        Me.txtpenerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpenerbit.Enabled = False
        Me.txtpenerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpenerbit.FocusedState.Parent = Me.txtpenerbit
        Me.txtpenerbit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpenerbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpenerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpenerbit.HoverState.Parent = Me.txtpenerbit
        Me.txtpenerbit.Location = New System.Drawing.Point(26, 197)
        Me.txtpenerbit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpenerbit.Name = "txtpenerbit"
        Me.txtpenerbit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpenerbit.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpenerbit.PlaceholderText = "Penerbit"
        Me.txtpenerbit.SelectedText = ""
        Me.txtpenerbit.ShadowDecoration.BorderRadius = 5
        Me.txtpenerbit.ShadowDecoration.Enabled = True
        Me.txtpenerbit.ShadowDecoration.Parent = Me.txtpenerbit
        Me.txtpenerbit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpenerbit.Size = New System.Drawing.Size(244, 32)
        Me.txtpenerbit.TabIndex = 17
        '
        'txtterbit
        '
        Me.txtterbit.Animated = True
        Me.txtterbit.BackColor = System.Drawing.Color.Transparent
        Me.txtterbit.BorderRadius = 5
        Me.txtterbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtterbit.DefaultText = ""
        Me.txtterbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtterbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtterbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtterbit.DisabledState.Parent = Me.txtterbit
        Me.txtterbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtterbit.Enabled = False
        Me.txtterbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtterbit.FocusedState.Parent = Me.txtterbit
        Me.txtterbit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtterbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtterbit.HoverState.Parent = Me.txtterbit
        Me.txtterbit.Location = New System.Drawing.Point(26, 237)
        Me.txtterbit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtterbit.Name = "txtterbit"
        Me.txtterbit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtterbit.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtterbit.PlaceholderText = "Tahun Terbit"
        Me.txtterbit.SelectedText = ""
        Me.txtterbit.ShadowDecoration.BorderRadius = 5
        Me.txtterbit.ShadowDecoration.Enabled = True
        Me.txtterbit.ShadowDecoration.Parent = Me.txtterbit
        Me.txtterbit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtterbit.Size = New System.Drawing.Size(244, 32)
        Me.txtterbit.TabIndex = 18
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(29, 92)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(115, 15)
        Me.GunaLabel3.TabIndex = 20
        Me.GunaLabel3.Text = "Masukkan ID Buku"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(29, 286)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel4.TabIndex = 21
        Me.GunaLabel4.Text = "Ubah Stok"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtstok
        '
        Me.txtstok.BackColor = System.Drawing.Color.Transparent
        Me.txtstok.BorderRadius = 5
        Me.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstok.DisabledState.Parent = Me.txtstok
        Me.txtstok.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.txtstok.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstok.FocusedState.Parent = Me.txtstok
        Me.txtstok.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtstok.Location = New System.Drawing.Point(26, 305)
        Me.txtstok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtstok.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtstok.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstok.Name = "txtstok"
        Me.txtstok.ShadowDecoration.BorderRadius = 5
        Me.txtstok.ShadowDecoration.Enabled = True
        Me.txtstok.ShadowDecoration.Parent = Me.txtstok
        Me.txtstok.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtstok.Size = New System.Drawing.Size(244, 32)
        Me.txtstok.TabIndex = 22
        Me.txtstok.TextOffset = New System.Drawing.Point(20, 0)
        Me.txtstok.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtstok.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtstok.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Data_Master_Bukufr_Editstok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(295, 445)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txtterbit)
        Me.Controls.Add(Me.txtpenerbit)
        Me.Controls.Add(Me.txtnamabuku)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.btnConfirmAdd)
        Me.Controls.Add(Me.txtidbuku)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Bukufr_Editstok"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.txtstok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtidbuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancelAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtterbit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpenerbit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnamabuku As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtstok As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
