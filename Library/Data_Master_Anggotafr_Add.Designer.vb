<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Anggotafr_Add
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
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNamaAnggota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnConfirmAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtIDanggota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbkelas1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbkelas2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbjurusan = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 50)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(154, 29)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Add Anggota"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 145)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Nama"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(12, 182)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "Kelas"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 223)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel6.TabIndex = 6
        Me.GunaLabel6.Text = "Jurusan"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtNamaAnggota
        '
        Me.txtNamaAnggota.Animated = True
        Me.txtNamaAnggota.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaAnggota.BorderRadius = 5
        Me.txtNamaAnggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaAnggota.DefaultText = ""
        Me.txtNamaAnggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNamaAnggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNamaAnggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNamaAnggota.DisabledState.Parent = Me.txtNamaAnggota
        Me.txtNamaAnggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNamaAnggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaAnggota.FocusedState.Parent = Me.txtNamaAnggota
        Me.txtNamaAnggota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaAnggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNamaAnggota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaAnggota.HoverState.Parent = Me.txtNamaAnggota
        Me.txtNamaAnggota.Location = New System.Drawing.Point(98, 145)
        Me.txtNamaAnggota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaAnggota.Name = "txtNamaAnggota"
        Me.txtNamaAnggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaAnggota.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNamaAnggota.PlaceholderText = ""
        Me.txtNamaAnggota.SelectedText = ""
        Me.txtNamaAnggota.ShadowDecoration.BorderRadius = 5
        Me.txtNamaAnggota.ShadowDecoration.Enabled = True
        Me.txtNamaAnggota.ShadowDecoration.Parent = Me.txtNamaAnggota
        Me.txtNamaAnggota.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtNamaAnggota.Size = New System.Drawing.Size(185, 23)
        Me.txtNamaAnggota.TabIndex = 7
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(84, 145)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel4.TabIndex = 10
        Me.GunaLabel4.Text = ":"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(84, 184)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel7.TabIndex = 11
        Me.GunaLabel7.Text = ":"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel8
        '
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(84, 223)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel8.TabIndex = 12
        Me.GunaLabel8.Text = ":"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
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
        Me.btnConfirmAdd.Location = New System.Drawing.Point(26, 270)
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
        Me.btnCancelAdd.Location = New System.Drawing.Point(160, 270)
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
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Roboto Thin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel9.Location = New System.Drawing.Point(104, 333)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(84, 111)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel10.TabIndex = 20
        Me.GunaLabel10.Text = ":"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtIDanggota
        '
        Me.txtIDanggota.Animated = True
        Me.txtIDanggota.BackColor = System.Drawing.Color.Transparent
        Me.txtIDanggota.BorderRadius = 5
        Me.txtIDanggota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDanggota.DefaultText = ""
        Me.txtIDanggota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIDanggota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIDanggota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDanggota.DisabledState.Parent = Me.txtIDanggota
        Me.txtIDanggota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDanggota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDanggota.FocusedState.Parent = Me.txtIDanggota
        Me.txtIDanggota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDanggota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtIDanggota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDanggota.HoverState.Parent = Me.txtIDanggota
        Me.txtIDanggota.Location = New System.Drawing.Point(98, 111)
        Me.txtIDanggota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIDanggota.Name = "txtIDanggota"
        Me.txtIDanggota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDanggota.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtIDanggota.PlaceholderText = ""
        Me.txtIDanggota.SelectedText = ""
        Me.txtIDanggota.ShadowDecoration.BorderRadius = 5
        Me.txtIDanggota.ShadowDecoration.Enabled = True
        Me.txtIDanggota.ShadowDecoration.Parent = Me.txtIDanggota
        Me.txtIDanggota.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtIDanggota.Size = New System.Drawing.Size(185, 23)
        Me.txtIDanggota.TabIndex = 19
        '
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(12, 111)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel11.TabIndex = 18
        Me.GunaLabel11.Text = "ID"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel11.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'cmbkelas1
        '
        Me.cmbkelas1.Animated = True
        Me.cmbkelas1.AutoRoundedCorners = True
        Me.cmbkelas1.BackColor = System.Drawing.Color.Transparent
        Me.cmbkelas1.BorderRadius = 6
        Me.cmbkelas1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas1.FocusedColor = System.Drawing.Color.Empty
        Me.cmbkelas1.FocusedState.Parent = Me.cmbkelas1
        Me.cmbkelas1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbkelas1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbkelas1.FormattingEnabled = True
        Me.cmbkelas1.HoverState.Parent = Me.cmbkelas1
        Me.cmbkelas1.ItemHeight = 16
        Me.cmbkelas1.Items.AddRange(New Object() {"10", "11", "12"})
        Me.cmbkelas1.ItemsAppearance.Parent = Me.cmbkelas1
        Me.cmbkelas1.Location = New System.Drawing.Point(98, 181)
        Me.cmbkelas1.Name = "cmbkelas1"
        Me.cmbkelas1.ShadowDecoration.Parent = Me.cmbkelas1
        Me.cmbkelas1.Size = New System.Drawing.Size(87, 24)
        Me.cmbkelas1.StartIndex = 0
        Me.cmbkelas1.TabIndex = 21
        Me.cmbkelas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbkelas2
        '
        Me.cmbkelas2.Animated = True
        Me.cmbkelas2.AutoRoundedCorners = True
        Me.cmbkelas2.BackColor = System.Drawing.Color.Transparent
        Me.cmbkelas2.BorderRadius = 6
        Me.cmbkelas2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbkelas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas2.FocusedColor = System.Drawing.Color.Empty
        Me.cmbkelas2.FocusedState.Parent = Me.cmbkelas2
        Me.cmbkelas2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbkelas2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbkelas2.FormattingEnabled = True
        Me.cmbkelas2.HoverState.Parent = Me.cmbkelas2
        Me.cmbkelas2.ItemHeight = 20
        Me.cmbkelas2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"})
        Me.cmbkelas2.ItemsAppearance.Parent = Me.cmbkelas2
        Me.cmbkelas2.Location = New System.Drawing.Point(196, 181)
        Me.cmbkelas2.MaxDropDownItems = 3
        Me.cmbkelas2.Name = "cmbkelas2"
        Me.cmbkelas2.ShadowDecoration.Parent = Me.cmbkelas2
        Me.cmbkelas2.Size = New System.Drawing.Size(87, 26)
        Me.cmbkelas2.StartIndex = 0
        Me.cmbkelas2.TabIndex = 22
        Me.cmbkelas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbjurusan
        '
        Me.cmbjurusan.Animated = True
        Me.cmbjurusan.AutoRoundedCorners = True
        Me.cmbjurusan.BackColor = System.Drawing.Color.Transparent
        Me.cmbjurusan.BorderRadius = 5
        Me.cmbjurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbjurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjurusan.FocusedColor = System.Drawing.Color.Empty
        Me.cmbjurusan.FocusedState.Parent = Me.cmbjurusan
        Me.cmbjurusan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbjurusan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbjurusan.FormattingEnabled = True
        Me.cmbjurusan.HoverState.Parent = Me.cmbjurusan
        Me.cmbjurusan.ItemHeight = 20
        Me.cmbjurusan.Items.AddRange(New Object() {"T K J", "T K R", "T B S M"})
        Me.cmbjurusan.ItemsAppearance.Parent = Me.cmbjurusan
        Me.cmbjurusan.Location = New System.Drawing.Point(98, 222)
        Me.cmbjurusan.Name = "cmbjurusan"
        Me.cmbjurusan.ShadowDecoration.Parent = Me.cmbjurusan
        Me.cmbjurusan.Size = New System.Drawing.Size(185, 26)
        Me.cmbjurusan.StartIndex = 0
        Me.cmbjurusan.TabIndex = 23
        Me.cmbjurusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data_Master_Anggotafr_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(295, 357)
        Me.Controls.Add(Me.cmbjurusan)
        Me.Controls.Add(Me.cmbkelas2)
        Me.Controls.Add(Me.cmbkelas1)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.txtIDanggota)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.btnConfirmAdd)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtNamaAnggota)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Anggotafr_Add"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtNamaAnggota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancelAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtIDanggota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbjurusan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbkelas2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbkelas1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
