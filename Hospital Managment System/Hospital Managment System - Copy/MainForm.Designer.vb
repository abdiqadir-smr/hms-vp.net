<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DischareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WardToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.UsersToolStripMenuItem, Me.DoctorToolStripMenuItem, Me.PatientToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1258, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WardToolStripMenuItem, Me.RoomToolStripMenuItem, Me.NarseToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry"
        '
        'WardToolStripMenuItem
        '
        Me.WardToolStripMenuItem.Name = "WardToolStripMenuItem"
        Me.WardToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.WardToolStripMenuItem.Text = "Ward"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'NarseToolStripMenuItem
        '
        Me.NarseToolStripMenuItem.Name = "NarseToolStripMenuItem"
        Me.NarseToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.NarseToolStripMenuItem.Text = "Nurse/Wardboy"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterationToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.UserDetailToolStripMenuItem})
        Me.UsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'RegisterationToolStripMenuItem
        '
        Me.RegisterationToolStripMenuItem.Name = "RegisterationToolStripMenuItem"
        Me.RegisterationToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.RegisterationToolStripMenuItem.Text = "Registeration"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'UserDetailToolStripMenuItem
        '
        Me.UserDetailToolStripMenuItem.Name = "UserDetailToolStripMenuItem"
        Me.UserDetailToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.UserDetailToolStripMenuItem.Text = "Login Details"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailEntryToolStripMenuItem})
        Me.DoctorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'DetailEntryToolStripMenuItem
        '
        Me.DetailEntryToolStripMenuItem.Name = "DetailEntryToolStripMenuItem"
        Me.DetailEntryToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.DetailEntryToolStripMenuItem.Text = "Profile Entry"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterationToolStripMenuItem1, Me.ServicesToolStripMenuItem, Me.AdminToolStripMenuItem1, Me.DischareToolStripMenuItem, Me.BillingToolStripMenuItem})
        Me.PatientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'RegisterationToolStripMenuItem1
        '
        Me.RegisterationToolStripMenuItem1.Name = "RegisterationToolStripMenuItem1"
        Me.RegisterationToolStripMenuItem1.Size = New System.Drawing.Size(166, 24)
        Me.RegisterationToolStripMenuItem1.Text = "Registeration"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem1, Me.WardToolStripMenuItem1})
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(166, 24)
        Me.AdminToolStripMenuItem1.Text = "Admin"
        '
        'RoomToolStripMenuItem1
        '
        Me.RoomToolStripMenuItem1.Name = "RoomToolStripMenuItem1"
        Me.RoomToolStripMenuItem1.Size = New System.Drawing.Size(118, 24)
        Me.RoomToolStripMenuItem1.Text = "Room"
        '
        'WardToolStripMenuItem1
        '
        Me.WardToolStripMenuItem1.Name = "WardToolStripMenuItem1"
        Me.WardToolStripMenuItem1.Size = New System.Drawing.Size(118, 24)
        Me.WardToolStripMenuItem1.Text = "Ward"
        '
        'DischareToolStripMenuItem
        '
        Me.DischareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem2, Me.WardToolStripMenuItem2})
        Me.DischareToolStripMenuItem.Name = "DischareToolStripMenuItem"
        Me.DischareToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.DischareToolStripMenuItem.Text = "Dischare"
        '
        'RoomToolStripMenuItem2
        '
        Me.RoomToolStripMenuItem2.Name = "RoomToolStripMenuItem2"
        Me.RoomToolStripMenuItem2.Size = New System.Drawing.Size(118, 24)
        Me.RoomToolStripMenuItem2.Text = "Room"
        '
        'WardToolStripMenuItem2
        '
        Me.WardToolStripMenuItem2.Name = "WardToolStripMenuItem2"
        Me.WardToolStripMenuItem2.Size = New System.Drawing.Size(118, 24)
        Me.WardToolStripMenuItem2.Text = "Ward"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem3, Me.WardToolStripMenuItem3})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'RoomToolStripMenuItem3
        '
        Me.RoomToolStripMenuItem3.Name = "RoomToolStripMenuItem3"
        Me.RoomToolStripMenuItem3.Size = New System.Drawing.Size(118, 24)
        Me.RoomToolStripMenuItem3.Text = "Room"
        '
        'WardToolStripMenuItem3
        '
        Me.WardToolStripMenuItem3.Name = "WardToolStripMenuItem3"
        Me.WardToolStripMenuItem3.Size = New System.Drawing.Size(118, 24)
        Me.WardToolStripMenuItem3.Text = "Ward"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1126, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 659)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NarseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DischareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WardToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
