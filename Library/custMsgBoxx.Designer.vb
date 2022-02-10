<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custMsgBoxx
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lblMessage = New Guna.UI.WinForms.GunaLabel()
        Me.IconMessage = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Guna2Panel1.Controls.Add(Me.btnExit)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(290, 27)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Animated = True
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BaseColor = System.Drawing.Color.Firebrick
        Me.btnExit.BorderColor = System.Drawing.Color.White
        Me.btnExit.BorderSize = 1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnExit.Location = New System.Drawing.Point(258, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Red
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(95, 7)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(101, 14)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Manent Library"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.DimGray
        Me.lblMessage.Location = New System.Drawing.Point(97, 37)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(165, 75)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message Here!"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconMessage
        '
        Me.IconMessage.BackColor = System.Drawing.Color.Transparent
        Me.IconMessage.CheckedState.Parent = Me.IconMessage
        Me.IconMessage.HoverState.Parent = Me.IconMessage
        Me.IconMessage.Image = Global.Library.My.Resources.Resources.cancel
        Me.IconMessage.ImageSize = New System.Drawing.Size(50, 50)
        Me.IconMessage.Location = New System.Drawing.Point(16, 37)
        Me.IconMessage.Name = "IconMessage"
        Me.IconMessage.PressedState.Parent = Me.IconMessage
        Me.IconMessage.Size = New System.Drawing.Size(75, 75)
        Me.IconMessage.TabIndex = 2
        '
        'custMsgBoxx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(290, 130)
        Me.Controls.Add(Me.IconMessage)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "custMsgBoxx"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custMsgBoxx"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblMessage As Guna.UI.WinForms.GunaLabel
    Friend WithEvents IconMessage As Guna.UI2.WinForms.Guna2ImageButton
End Class
