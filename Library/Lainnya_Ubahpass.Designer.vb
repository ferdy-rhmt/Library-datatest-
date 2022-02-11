<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lainnya_Ubahpass
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
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpasslama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpassbaru = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpassbaruretype = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(320, 27)
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
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 47)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(160, 25)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Ubah Password"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BorderRadius = 5
        Me.btnConfirm.BorderThickness = 2
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.Silver
        Me.btnConfirm.Font = New System.Drawing.Font("Roboto Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirm.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnConfirm.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(43, 292)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.BorderRadius = 5
        Me.btnConfirm.ShadowDecoration.Enabled = True
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnConfirm.Size = New System.Drawing.Size(110, 33)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Silver
        Me.btnCancel.Font = New System.Drawing.Font("Roboto Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(159, 292)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.BorderRadius = 5
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnCancel.Size = New System.Drawing.Size(110, 33)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Roboto Thin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel9.Location = New System.Drawing.Point(116, 356)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 100)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(110, 23)
        Me.GunaLabel3.TabIndex = 20
        Me.GunaLabel3.Text = "ID Admin"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 131)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(110, 23)
        Me.GunaLabel6.TabIndex = 25
        Me.GunaLabel6.Text = "Nama"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(12, 162)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(110, 23)
        Me.GunaLabel8.TabIndex = 28
        Me.GunaLabel8.Text = "Password  lama"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(12, 210)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(110, 23)
        Me.GunaLabel4.TabIndex = 31
        Me.GunaLabel4.Text = "Password  baru"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtid
        '
        Me.txtid.Animated = True
        Me.txtid.BackColor = System.Drawing.Color.Transparent
        Me.txtid.BorderRadius = 5
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.DefaultText = ""
        Me.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.DisabledState.Parent = Me.txtid
        Me.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.Enabled = False
        Me.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedState.Parent = Me.txtid
        Me.txtid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.HoverState.Parent = Me.txtid
        Me.txtid.Location = New System.Drawing.Point(147, 100)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtid.PlaceholderText = ""
        Me.txtid.ReadOnly = True
        Me.txtid.SelectedText = ""
        Me.txtid.ShadowDecoration.Enabled = True
        Me.txtid.ShadowDecoration.Parent = Me.txtid
        Me.txtid.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtid.Size = New System.Drawing.Size(160, 23)
        Me.txtid.TabIndex = 33
        Me.txtid.UseSystemPasswordChar = True
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(129, 100)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(11, 23)
        Me.GunaLabel5.TabIndex = 36
        Me.GunaLabel5.Text = ":"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtnama
        '
        Me.txtnama.Animated = True
        Me.txtnama.BackColor = System.Drawing.Color.Transparent
        Me.txtnama.BorderRadius = 5
        Me.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnama.DefaultText = ""
        Me.txtnama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnama.DisabledState.Parent = Me.txtnama
        Me.txtnama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnama.Enabled = False
        Me.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnama.FocusedState.Parent = Me.txtnama
        Me.txtnama.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnama.HoverState.Parent = Me.txtnama
        Me.txtnama.Location = New System.Drawing.Point(147, 131)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnama.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtnama.PlaceholderText = ""
        Me.txtnama.ReadOnly = True
        Me.txtnama.SelectedText = ""
        Me.txtnama.ShadowDecoration.Enabled = True
        Me.txtnama.ShadowDecoration.Parent = Me.txtnama
        Me.txtnama.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtnama.Size = New System.Drawing.Size(160, 23)
        Me.txtnama.TabIndex = 37
        Me.txtnama.UseSystemPasswordChar = True
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(129, 131)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(11, 23)
        Me.GunaLabel7.TabIndex = 38
        Me.GunaLabel7.Text = ":"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(129, 162)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(11, 23)
        Me.GunaLabel10.TabIndex = 39
        Me.GunaLabel10.Text = ":"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtpasslama
        '
        Me.txtpasslama.Animated = True
        Me.txtpasslama.BackColor = System.Drawing.Color.Transparent
        Me.txtpasslama.BorderRadius = 5
        Me.txtpasslama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpasslama.DefaultText = ""
        Me.txtpasslama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpasslama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpasslama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpasslama.DisabledState.Parent = Me.txtpasslama
        Me.txtpasslama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpasslama.Enabled = False
        Me.txtpasslama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpasslama.FocusedState.Parent = Me.txtpasslama
        Me.txtpasslama.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasslama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpasslama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpasslama.HoverState.Parent = Me.txtpasslama
        Me.txtpasslama.Location = New System.Drawing.Point(147, 162)
        Me.txtpasslama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpasslama.Name = "txtpasslama"
        Me.txtpasslama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpasslama.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpasslama.PlaceholderText = ""
        Me.txtpasslama.ReadOnly = True
        Me.txtpasslama.SelectedText = ""
        Me.txtpasslama.ShadowDecoration.Enabled = True
        Me.txtpasslama.ShadowDecoration.Parent = Me.txtpasslama
        Me.txtpasslama.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpasslama.Size = New System.Drawing.Size(160, 23)
        Me.txtpasslama.TabIndex = 40
        Me.txtpasslama.UseSystemPasswordChar = True
        '
        'txtpassbaru
        '
        Me.txtpassbaru.Animated = True
        Me.txtpassbaru.BackColor = System.Drawing.Color.Transparent
        Me.txtpassbaru.BorderRadius = 5
        Me.txtpassbaru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassbaru.DefaultText = ""
        Me.txtpassbaru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassbaru.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassbaru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassbaru.DisabledState.Parent = Me.txtpassbaru
        Me.txtpassbaru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassbaru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassbaru.FocusedState.Parent = Me.txtpassbaru
        Me.txtpassbaru.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassbaru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassbaru.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassbaru.HoverState.Parent = Me.txtpassbaru
        Me.txtpassbaru.Location = New System.Drawing.Point(147, 210)
        Me.txtpassbaru.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassbaru.Name = "txtpassbaru"
        Me.txtpassbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassbaru.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassbaru.PlaceholderText = ""
        Me.txtpassbaru.SelectedText = ""
        Me.txtpassbaru.ShadowDecoration.Enabled = True
        Me.txtpassbaru.ShadowDecoration.Parent = Me.txtpassbaru
        Me.txtpassbaru.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpassbaru.Size = New System.Drawing.Size(160, 23)
        Me.txtpassbaru.TabIndex = 42
        Me.txtpassbaru.UseSystemPasswordChar = True
        '
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(129, 210)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(11, 23)
        Me.GunaLabel11.TabIndex = 41
        Me.GunaLabel11.Text = ":"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel11.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtpassbaruretype
        '
        Me.txtpassbaruretype.Animated = True
        Me.txtpassbaruretype.BackColor = System.Drawing.Color.Transparent
        Me.txtpassbaruretype.BorderRadius = 5
        Me.txtpassbaruretype.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassbaruretype.DefaultText = ""
        Me.txtpassbaruretype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassbaruretype.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassbaruretype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassbaruretype.DisabledState.Parent = Me.txtpassbaruretype
        Me.txtpassbaruretype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassbaruretype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassbaruretype.FocusedState.Parent = Me.txtpassbaruretype
        Me.txtpassbaruretype.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassbaruretype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassbaruretype.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassbaruretype.HoverState.Parent = Me.txtpassbaruretype
        Me.txtpassbaruretype.Location = New System.Drawing.Point(147, 241)
        Me.txtpassbaruretype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassbaruretype.Name = "txtpassbaruretype"
        Me.txtpassbaruretype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassbaruretype.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassbaruretype.PlaceholderText = ""
        Me.txtpassbaruretype.SelectedText = ""
        Me.txtpassbaruretype.ShadowDecoration.Enabled = True
        Me.txtpassbaruretype.ShadowDecoration.Parent = Me.txtpassbaruretype
        Me.txtpassbaruretype.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpassbaruretype.Size = New System.Drawing.Size(160, 23)
        Me.txtpassbaruretype.TabIndex = 45
        Me.txtpassbaruretype.UseSystemPasswordChar = True
        '
        'GunaLabel12
        '
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(129, 241)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(11, 23)
        Me.GunaLabel12.TabIndex = 44
        Me.GunaLabel12.Text = ":"
        Me.GunaLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel12.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel13
        '
        Me.GunaLabel13.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel13.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel13.Location = New System.Drawing.Point(12, 241)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(110, 23)
        Me.GunaLabel13.TabIndex = 43
        Me.GunaLabel13.Text = "retype password"
        Me.GunaLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel13.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Lainnya_Ubahpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(320, 380)
        Me.Controls.Add(Me.txtpassbaruretype)
        Me.Controls.Add(Me.GunaLabel12)
        Me.Controls.Add(Me.GunaLabel13)
        Me.Controls.Add(Me.txtpassbaru)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.txtpasslama)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lainnya_Ubahpass"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpassbaruretype As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpassbaru As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpasslama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtnama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
End Class
