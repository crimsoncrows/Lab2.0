<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.closebtn = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeposit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnWithdraw = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearAmt = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_CurrentUser = New System.Windows.Forms.Label()
        Me.lbl_UserBal = New System.Windows.Forms.Label()
        Me.lblAccountBalance = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblStatMsg = New System.Windows.Forms.Label()
        Me.pictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.pictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        '
        'closebtn
        '
        Me.closebtn.AutoSize = True
        Me.closebtn.Font = New System.Drawing.Font("MADE TOMMY", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closebtn.Location = New System.Drawing.Point(796, 11)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(25, 25)
        Me.closebtn.TabIndex = 6
        Me.closebtn.Text = "✕"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("MADE TOMMY", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTB.ForeColor = System.Drawing.Color.White
        Me.lblTB.Location = New System.Drawing.Point(31, 14)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(163, 22)
        Me.lblTB.TabIndex = 8
        Me.lblTB.Text = "▢ Banco de Nomar"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.Coral
        Me.panelTitleBar.Controls.Add(Me.closebtn)
        Me.panelTitleBar.Controls.Add(Me.lblTB)
        Me.panelTitleBar.Controls.Add(Me.btnLogout)
        Me.panelTitleBar.Controls.Add(Me.lblTitle)
        Me.panelTitleBar.Location = New System.Drawing.Point(-11, -2)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(844, 159)
        Me.panelTitleBar.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MADE TOMMY", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 59)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "BANCO DE NOMAR"
        '
        'btnLogout
        '
        Me.btnLogout.AutoRoundedCorners = True
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.White
        Me.btnLogout.Font = New System.Drawing.Font("SF Pro Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogout.Location = New System.Drawing.Point(645, 75)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(176, 53)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        '
        'btnDeposit
        '
        Me.btnDeposit.AutoRoundedCorners = True
        Me.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeposit.FillColor = System.Drawing.Color.Coral
        Me.btnDeposit.Font = New System.Drawing.Font("SF Pro Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.White
        Me.btnDeposit.Location = New System.Drawing.Point(32, 466)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(151, 57)
        Me.btnDeposit.TabIndex = 12
        Me.btnDeposit.Text = "Deposit"
        '
        'txtAmount
        '
        Me.txtAmount.AutoRoundedCorners = True
        Me.txtAmount.BorderRadius = 29
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("SF Pro Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(32, 324)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = "Amount"
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(315, 60)
        Me.txtAmount.TabIndex = 11
        '
        'btnWithdraw
        '
        Me.btnWithdraw.AutoRoundedCorners = True
        Me.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWithdraw.FillColor = System.Drawing.Color.Coral
        Me.btnWithdraw.Font = New System.Drawing.Font("SF Pro Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.White
        Me.btnWithdraw.Location = New System.Drawing.Point(32, 403)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(151, 57)
        Me.btnWithdraw.TabIndex = 10
        Me.btnWithdraw.Text = "Withdraw"
        '
        'btnClearAmt
        '
        Me.btnClearAmt.BorderRadius = 35
        Me.btnClearAmt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearAmt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearAmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearAmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearAmt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearAmt.Font = New System.Drawing.Font("SF Pro Display", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAmt.ForeColor = System.Drawing.Color.White
        Me.btnClearAmt.Location = New System.Drawing.Point(189, 403)
        Me.btnClearAmt.Name = "btnClearAmt"
        Me.btnClearAmt.Size = New System.Drawing.Size(151, 120)
        Me.btnClearAmt.TabIndex = 13
        Me.btnClearAmt.Text = "Clear"
        '
        'lbl_CurrentUser
        '
        Me.lbl_CurrentUser.AutoSize = True
        Me.lbl_CurrentUser.Font = New System.Drawing.Font("SF Pro Display", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CurrentUser.ForeColor = System.Drawing.Color.Coral
        Me.lbl_CurrentUser.Location = New System.Drawing.Point(31, 191)
        Me.lbl_CurrentUser.Name = "lbl_CurrentUser"
        Me.lbl_CurrentUser.Size = New System.Drawing.Size(202, 33)
        Me.lbl_CurrentUser.TabIndex = 14
        Me.lbl_CurrentUser.Text = "Account Name"
        '
        'lbl_UserBal
        '
        Me.lbl_UserBal.AutoSize = True
        Me.lbl_UserBal.Font = New System.Drawing.Font("SF Pro Display", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UserBal.ForeColor = System.Drawing.Color.Coral
        Me.lbl_UserBal.Location = New System.Drawing.Point(31, 234)
        Me.lbl_UserBal.Name = "lbl_UserBal"
        Me.lbl_UserBal.Size = New System.Drawing.Size(117, 33)
        Me.lbl_UserBal.TabIndex = 15
        Me.lbl_UserBal.Text = "Balance"
        '
        'lblAccountBalance
        '
        Me.lblAccountBalance.AutoSize = True
        Me.lblAccountBalance.Font = New System.Drawing.Font("SF Pro Display", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAccountBalance.Location = New System.Drawing.Point(249, 234)
        Me.lblAccountBalance.Name = "lblAccountBalance"
        Me.lblAccountBalance.Size = New System.Drawing.Size(0, 33)
        Me.lblAccountBalance.TabIndex = 17
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("SF Pro Display", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(249, 191)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 33)
        Me.lblUser.TabIndex = 16
        '
        'lblStatMsg
        '
        Me.lblStatMsg.AutoSize = True
        Me.lblStatMsg.Font = New System.Drawing.Font("SF Pro Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatMsg.Location = New System.Drawing.Point(38, 540)
        Me.lblStatMsg.Name = "lblStatMsg"
        Me.lblStatMsg.Size = New System.Drawing.Size(293, 29)
        Me.lblStatMsg.TabIndex = 18
        Me.lblStatMsg.Text = "[Transaction Message Here]"
        Me.lblStatMsg.Visible = False
        '
        'pictureBoxUser
        '
        Me.pictureBoxUser.Image = CType(resources.GetObject("pictureBoxUser.Image"), System.Drawing.Image)
        Me.pictureBoxUser.Location = New System.Drawing.Point(539, 163)
        Me.pictureBoxUser.Name = "pictureBoxUser"
        Me.pictureBoxUser.Size = New System.Drawing.Size(282, 168)
        Me.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxUser.TabIndex = 20
        Me.pictureBoxUser.TabStop = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(833, 649)
        Me.Controls.Add(Me.pictureBoxUser)
        Me.Controls.Add(Me.lblStatMsg)
        Me.Controls.Add(Me.lblAccountBalance)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lbl_UserBal)
        Me.Controls.Add(Me.lbl_CurrentUser)
        Me.Controls.Add(Me.btnClearAmt)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.pictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents lblTB As Label
    Friend WithEvents closebtn As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClearAmt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeposit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnWithdraw As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_CurrentUser As Label
    Friend WithEvents lbl_UserBal As Label
    Friend WithEvents lblStatMsg As Label
    Friend WithEvents pictureBoxUser As PictureBox
    Public WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Public WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents lblAccountBalance As Label
    Public WithEvents lblUser As Label
End Class
