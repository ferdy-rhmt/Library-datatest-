<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Master_Adminfr_Add
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
        Me.txtNameAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpassw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtretypepassw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.btnConfirmAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.btnshowpass1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnshowpass2 = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtidadmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
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
        Me.GunaLabel2.Size = New System.Drawing.Size(133, 29)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Add Admin"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 146)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Name"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(12, 183)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "Password"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 224)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel6.TabIndex = 6
        Me.GunaLabel6.Text = "Re-type"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtNameAdmin
        '
        Me.txtNameAdmin.Animated = True
        Me.txtNameAdmin.BackColor = System.Drawing.Color.Transparent
        Me.txtNameAdmin.BorderRadius = 5
        Me.txtNameAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameAdmin.DefaultText = ""
        Me.txtNameAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNameAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNameAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNameAdmin.DisabledState.Parent = Me.txtNameAdmin
        Me.txtNameAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNameAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNameAdmin.FocusedState.Parent = Me.txtNameAdmin
        Me.txtNameAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNameAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNameAdmin.HoverState.Parent = Me.txtNameAdmin
        Me.txtNameAdmin.Location = New System.Drawing.Point(98, 146)
        Me.txtNameAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNameAdmin.Name = "txtNameAdmin"
        Me.txtNameAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameAdmin.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtNameAdmin.PlaceholderText = ""
        Me.txtNameAdmin.SelectedText = ""
        Me.txtNameAdmin.ShadowDecoration.BorderRadius = 5
        Me.txtNameAdmin.ShadowDecoration.Enabled = True
        Me.txtNameAdmin.ShadowDecoration.Parent = Me.txtNameAdmin
        Me.txtNameAdmin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtNameAdmin.Size = New System.Drawing.Size(185, 23)
        Me.txtNameAdmin.TabIndex = 7
        '
        'txtpassw
        '
        Me.txtpassw.Animated = True
        Me.txtpassw.BackColor = System.Drawing.Color.Transparent
        Me.txtpassw.BorderRadius = 5
        Me.txtpassw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassw.DefaultText = ""
        Me.txtpassw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassw.DisabledState.Parent = Me.txtpassw
        Me.txtpassw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassw.FocusedState.Parent = Me.txtpassw
        Me.txtpassw.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassw.HoverState.Parent = Me.txtpassw
        Me.txtpassw.Location = New System.Drawing.Point(98, 185)
        Me.txtpassw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassw.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtpassw.PlaceholderText = ""
        Me.txtpassw.SelectedText = ""
        Me.txtpassw.ShadowDecoration.Enabled = True
        Me.txtpassw.ShadowDecoration.Parent = Me.txtpassw
        Me.txtpassw.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtpassw.Size = New System.Drawing.Size(160, 23)
        Me.txtpassw.TabIndex = 8
        Me.txtpassw.UseSystemPasswordChar = True
        '
        'txtretypepassw
        '
        Me.txtretypepassw.Animated = True
        Me.txtretypepassw.BackColor = System.Drawing.Color.Transparent
        Me.txtretypepassw.BorderRadius = 5
        Me.txtretypepassw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtretypepassw.DefaultText = ""
        Me.txtretypepassw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtretypepassw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtretypepassw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtretypepassw.DisabledState.Parent = Me.txtretypepassw
        Me.txtretypepassw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtretypepassw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtretypepassw.FocusedState.Parent = Me.txtretypepassw
        Me.txtretypepassw.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretypepassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtretypepassw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtretypepassw.HoverState.Parent = Me.txtretypepassw
        Me.txtretypepassw.Location = New System.Drawing.Point(98, 224)
        Me.txtretypepassw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtretypepassw.Name = "txtretypepassw"
        Me.txtretypepassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtretypepassw.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtretypepassw.PlaceholderText = ""
        Me.txtretypepassw.SelectedText = ""
        Me.txtretypepassw.ShadowDecoration.Enabled = True
        Me.txtretypepassw.ShadowDecoration.Parent = Me.txtretypepassw
        Me.txtretypepassw.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtretypepassw.Size = New System.Drawing.Size(160, 23)
        Me.txtretypepassw.TabIndex = 9
        Me.txtretypepassw.UseSystemPasswordChar = True
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(84, 146)
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
        Me.GunaLabel7.Location = New System.Drawing.Point(84, 185)
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
        Me.GunaLabel8.Location = New System.Drawing.Point(84, 224)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel8.TabIndex = 12
        Me.GunaLabel8.Text = ":"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnConfirmAdd
        '
        Me.btnConfirmAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.btnConfirmAdd.Location = New System.Drawing.Point(26, 284)
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
        Me.btnCancelAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.btnCancelAdd.Location = New System.Drawing.Point(160, 284)
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
        Me.GunaLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Roboto Thin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel9.Location = New System.Drawing.Point(106, 342)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'btnshowpass1
        '
        Me.btnshowpass1.Animated = True
        Me.btnshowpass1.BorderRadius = 15
        Me.btnshowpass1.CheckedState.Parent = Me.btnshowpass1
        Me.btnshowpass1.CustomImages.Parent = Me.btnshowpass1
        Me.btnshowpass1.FillColor = System.Drawing.Color.Transparent
        Me.btnshowpass1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnshowpass1.ForeColor = System.Drawing.Color.White
        Me.btnshowpass1.HoverState.Parent = Me.btnshowpass1
        Me.btnshowpass1.Image = Global.Library.My.Resources.Resources.eye
        Me.btnshowpass1.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnshowpass1.Location = New System.Drawing.Point(260, 185)
        Me.btnshowpass1.Name = "btnshowpass1"
        Me.btnshowpass1.PressedDepth = 20
        Me.btnshowpass1.ShadowDecoration.Parent = Me.btnshowpass1
        Me.btnshowpass1.Size = New System.Drawing.Size(23, 23)
        Me.btnshowpass1.TabIndex = 16
        '
        'btnshowpass2
        '
        Me.btnshowpass2.Animated = True
        Me.btnshowpass2.BorderRadius = 15
        Me.btnshowpass2.CheckedState.Parent = Me.btnshowpass2
        Me.btnshowpass2.CustomImages.Parent = Me.btnshowpass2
        Me.btnshowpass2.FillColor = System.Drawing.Color.Transparent
        Me.btnshowpass2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnshowpass2.ForeColor = System.Drawing.Color.White
        Me.btnshowpass2.HoverState.Parent = Me.btnshowpass2
        Me.btnshowpass2.Image = Global.Library.My.Resources.Resources.eye
        Me.btnshowpass2.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnshowpass2.Location = New System.Drawing.Point(260, 224)
        Me.btnshowpass2.Name = "btnshowpass2"
        Me.btnshowpass2.PressedDepth = 20
        Me.btnshowpass2.ShadowDecoration.Parent = Me.btnshowpass2
        Me.btnshowpass2.Size = New System.Drawing.Size(23, 23)
        Me.btnshowpass2.TabIndex = 17
        '
        'GunaLabel10
        '
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(84, 115)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(10, 23)
        Me.GunaLabel10.TabIndex = 20
        Me.GunaLabel10.Text = ":"
        Me.GunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'txtidadmin
        '
        Me.txtidadmin.Animated = True
        Me.txtidadmin.BackColor = System.Drawing.Color.Transparent
        Me.txtidadmin.BorderRadius = 5
        Me.txtidadmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidadmin.DefaultText = ""
        Me.txtidadmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidadmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidadmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidadmin.DisabledState.Parent = Me.txtidadmin
        Me.txtidadmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidadmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidadmin.FocusedState.Parent = Me.txtidadmin
        Me.txtidadmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidadmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidadmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidadmin.HoverState.Parent = Me.txtidadmin
        Me.txtidadmin.Location = New System.Drawing.Point(98, 115)
        Me.txtidadmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidadmin.Name = "txtidadmin"
        Me.txtidadmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidadmin.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtidadmin.PlaceholderText = ""
        Me.txtidadmin.SelectedText = ""
        Me.txtidadmin.ShadowDecoration.BorderRadius = 5
        Me.txtidadmin.ShadowDecoration.Enabled = True
        Me.txtidadmin.ShadowDecoration.Parent = Me.txtidadmin
        Me.txtidadmin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txtidadmin.Size = New System.Drawing.Size(185, 23)
        Me.txtidadmin.TabIndex = 19
        '
        'GunaLabel11
        '
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(12, 115)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(69, 23)
        Me.GunaLabel11.TabIndex = 18
        Me.GunaLabel11.Text = "ID"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel11.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Data_Master_Adminfr_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(295, 366)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.txtidadmin)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.btnshowpass2)
        Me.Controls.Add(Me.btnshowpass1)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.btnConfirmAdd)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtretypepassw)
        Me.Controls.Add(Me.txtpassw)
        Me.Controls.Add(Me.txtNameAdmin)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Master_Adminfr_Add"
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
    Friend WithEvents txtNameAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtretypepassw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancelAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirmAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnshowpass2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnshowpass1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtidadmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
End Class
