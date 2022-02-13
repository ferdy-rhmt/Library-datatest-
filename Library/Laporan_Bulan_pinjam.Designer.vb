<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan_Bulan_pinjam
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
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbbulan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tahunnn = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.tahunnn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(223, 27)
        Me.Guna2Panel1.TabIndex = 1
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoEllipsis = True
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 42)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(155, 23)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Laporan Bulanan"
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
        Me.btnConfirm.Location = New System.Drawing.Point(26, 163)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.BorderRadius = 5
        Me.btnConfirm.ShadowDecoration.Enabled = True
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnConfirm.Size = New System.Drawing.Size(83, 33)
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
        Me.btnCancel.Location = New System.Drawing.Point(115, 163)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.BorderRadius = 5
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.btnCancel.Size = New System.Drawing.Size(83, 33)
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
        Me.GunaLabel9.Location = New System.Drawing.Point(70, 204)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 15)
        Me.GunaLabel9.TabIndex = 15
        Me.GunaLabel9.Text = "Manent 2021"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'cmbbulan
        '
        Me.cmbbulan.Animated = True
        Me.cmbbulan.BackColor = System.Drawing.Color.Transparent
        Me.cmbbulan.BorderRadius = 5
        Me.cmbbulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbbulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbulan.FocusedColor = System.Drawing.Color.Empty
        Me.cmbbulan.FocusedState.Parent = Me.cmbbulan
        Me.cmbbulan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbulan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbbulan.FormattingEnabled = True
        Me.cmbbulan.HoverState.Parent = Me.cmbbulan
        Me.cmbbulan.ItemHeight = 20
        Me.cmbbulan.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbbulan.ItemsAppearance.Parent = Me.cmbbulan
        Me.cmbbulan.Location = New System.Drawing.Point(102, 85)
        Me.cmbbulan.MaxDropDownItems = 4
        Me.cmbbulan.Name = "cmbbulan"
        Me.cmbbulan.ShadowDecoration.Parent = Me.cmbbulan
        Me.cmbbulan.Size = New System.Drawing.Size(96, 26)
        Me.cmbbulan.StartIndex = 0
        Me.cmbbulan.TabIndex = 23
        Me.cmbbulan.TextOffset = New System.Drawing.Point(5, 0)
        '
        'tahunnn
        '
        Me.tahunnn.BackColor = System.Drawing.Color.Transparent
        Me.tahunnn.BorderRadius = 5
        Me.tahunnn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tahunnn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tahunnn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tahunnn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tahunnn.DisabledState.Parent = Me.tahunnn
        Me.tahunnn.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.tahunnn.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tahunnn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tahunnn.FocusedState.Parent = Me.tahunnn
        Me.tahunnn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tahunnn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tahunnn.Location = New System.Drawing.Point(102, 118)
        Me.tahunnn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tahunnn.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.tahunnn.Name = "tahunnn"
        Me.tahunnn.ShadowDecoration.Parent = Me.tahunnn
        Me.tahunnn.Size = New System.Drawing.Size(96, 29)
        Me.tahunnn.TabIndex = 24
        Me.tahunnn.TextOffset = New System.Drawing.Point(5, 0)
        Me.tahunnn.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.tahunnn.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoEllipsis = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(26, 88)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(70, 23)
        Me.GunaLabel1.TabIndex = 25
        Me.GunaLabel1.Text = "Bulan"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoEllipsis = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(26, 118)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(70, 29)
        Me.GunaLabel3.TabIndex = 26
        Me.GunaLabel3.Text = "Tahun"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixelGridFit
        '
        'Laporan_Peminjaman_Bulan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(223, 228)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.tahunnn)
        Me.Controls.Add(Me.cmbbulan)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laporan_Peminjaman_Bulan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.tahunnn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbbulan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tahunnn As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
