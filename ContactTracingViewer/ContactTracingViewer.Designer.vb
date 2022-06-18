<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactTracingViewer
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
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelNAME = New System.Windows.Forms.Label()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonOpen
        '
        Me.ButtonOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ButtonOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOpen.FlatAppearance.BorderSize = 0
        Me.ButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpen.ForeColor = System.Drawing.Color.LightYellow
        Me.ButtonOpen.Location = New System.Drawing.Point(318, 110)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(57, 27)
        Me.ButtonOpen.TabIndex = 1
        Me.ButtonOpen.Text = "OPEN"
        Me.ButtonOpen.UseVisualStyleBackColor = False
        Me.ButtonOpen.Visible = False
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.BackColor = System.Drawing.Color.Yellow
        Me.ButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdmin.FlatAppearance.BorderSize = 0
        Me.ButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdmin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdmin.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdmin.Location = New System.Drawing.Point(39, 195)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(60, 31)
        Me.ButtonAdmin.TabIndex = 2
        Me.ButtonAdmin.TabStop = False
        Me.ButtonAdmin.Text = "ADMIN"
        Me.ButtonAdmin.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxSearch.Location = New System.Drawing.Point(39, 75)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(336, 20)
        Me.TextBoxSearch.TabIndex = 0
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFullname.ForeColor = System.Drawing.Color.Yellow
        Me.LabelFullname.Location = New System.Drawing.Point(36, 59)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(84, 15)
        Me.LabelFullname.TabIndex = 3
        Me.LabelFullname.Text = "FULLNAME:"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelDate.ForeColor = System.Drawing.Color.LightGray
        Me.LabelDate.Location = New System.Drawing.Point(13, 8)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(38, 15)
        Me.LabelDate.TabIndex = 4
        Me.LabelDate.Text = "Date"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(38, 98)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(105, 13)
        Me.LabelError.TabIndex = 5
        Me.LabelError.Text = "No Data Found!!!"
        Me.LabelError.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.LightGray
        Me.LabelTime.Location = New System.Drawing.Point(306, 8)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(39, 15)
        Me.LabelTime.TabIndex = 6
        Me.LabelTime.Text = "Time"
        '
        'LabelNAME
        '
        Me.LabelNAME.AutoSize = True
        Me.LabelNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNAME.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelNAME.Location = New System.Drawing.Point(116, 58)
        Me.LabelNAME.Name = "LabelNAME"
        Me.LabelNAME.Size = New System.Drawing.Size(195, 15)
        Me.LabelNAME.TabIndex = 7
        Me.LabelNAME.Text = "(SURNAME, FIRSTNAME MI.)"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelAdmin.Controls.Add(Me.Label1)
        Me.PanelAdmin.Controls.Add(Me.ButtonLogin)
        Me.PanelAdmin.Controls.Add(Me.TextBoxPassword)
        Me.PanelAdmin.Controls.Add(Me.TextBoxUsername)
        Me.PanelAdmin.Controls.Add(Me.LabelPassword)
        Me.PanelAdmin.Controls.Add(Me.LabelUsername)
        Me.PanelAdmin.Location = New System.Drawing.Point(39, 42)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(345, 147)
        Me.PanelAdmin.TabIndex = 8
        Me.PanelAdmin.Visible = False
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelUsername.Location = New System.Drawing.Point(20, 16)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(58, 13)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelPassword.Location = New System.Drawing.Point(23, 58)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(56, 13)
        Me.LabelPassword.TabIndex = 1
        Me.LabelPassword.Text = "Password:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(80, 33)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxUsername.TabIndex = 2
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(80, 76)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxPassword.TabIndex = 3
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.Black
        Me.ButtonLogin.FlatAppearance.BorderSize = 0
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.Color.Yellow
        Me.ButtonLogin.Location = New System.Drawing.Point(149, 107)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(59, 33)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(295, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ADMIN"
        '
        'ContactTracingViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 238)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.LabelNAME)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelFullname)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonAdmin)
        Me.Controls.Add(Me.ButtonOpen)
        Me.MaximizeBox = False
        Me.Name = "ContactTracingViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContactTracingViewer"
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonAdmin As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelFullname As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelNAME As Label
    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents Label1 As Label
End Class
