<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBoxFilter = New System.Windows.Forms.ComboBox()
        Me.LabelNameandDate = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.RichTextBoxAdminDisplay = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBoxDisplayAll = New System.Windows.Forms.RichTextBox()
        Me.TimerAdmin = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(480, 302)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ComboBoxFilter)
        Me.TabPage1.Controls.Add(Me.LabelNameandDate)
        Me.TabPage1.Controls.Add(Me.LabelError)
        Me.TabPage1.Controls.Add(Me.TextBoxSearch)
        Me.TabPage1.Controls.Add(Me.RichTextBoxAdminDisplay)
        Me.TabPage1.ForeColor = System.Drawing.Color.Red
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(472, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search"
        '
        'ComboBoxFilter
        '
        Me.ComboBoxFilter.FormattingEnabled = True
        Me.ComboBoxFilter.Items.AddRange(New Object() {"By Name", "By Date"})
        Me.ComboBoxFilter.Location = New System.Drawing.Point(386, 12)
        Me.ComboBoxFilter.Name = "ComboBoxFilter"
        Me.ComboBoxFilter.Size = New System.Drawing.Size(78, 21)
        Me.ComboBoxFilter.TabIndex = 6
        '
        'LabelNameandDate
        '
        Me.LabelNameandDate.AutoSize = True
        Me.LabelNameandDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameandDate.ForeColor = System.Drawing.Color.White
        Me.LabelNameandDate.Location = New System.Drawing.Point(12, 204)
        Me.LabelNameandDate.Name = "LabelNameandDate"
        Me.LabelNameandDate.Size = New System.Drawing.Size(263, 16)
        Me.LabelNameandDate.TabIndex = 5
        Me.LabelNameandDate.Text = "FULLNAME: (LASTNAME, FIRSTNAME MI.)"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.Location = New System.Drawing.Point(11, 250)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(115, 16)
        Me.LabelError.TabIndex = 4
        Me.LabelError.Text = "No Data Found!!!"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(12, 224)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(436, 20)
        Me.TextBoxSearch.TabIndex = 0
        '
        'RichTextBoxAdminDisplay
        '
        Me.RichTextBoxAdminDisplay.Location = New System.Drawing.Point(11, 12)
        Me.RichTextBoxAdminDisplay.Name = "RichTextBoxAdminDisplay"
        Me.RichTextBoxAdminDisplay.ReadOnly = True
        Me.RichTextBoxAdminDisplay.Size = New System.Drawing.Size(359, 170)
        Me.RichTextBoxAdminDisplay.TabIndex = 5
        Me.RichTextBoxAdminDisplay.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.RichTextBoxDisplayAll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "All Data"
        '
        'RichTextBoxDisplayAll
        '
        Me.RichTextBoxDisplayAll.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxDisplayAll.Name = "RichTextBoxDisplayAll"
        Me.RichTextBoxDisplayAll.ReadOnly = True
        Me.RichTextBoxDisplayAll.Size = New System.Drawing.Size(472, 276)
        Me.RichTextBoxDisplayAll.TabIndex = 0
        Me.RichTextBoxDisplayAll.Text = ""
        '
        'TimerAdmin
        '
        Me.TimerAdmin.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(409, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 332)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents RichTextBoxAdminDisplay As RichTextBox
    Friend WithEvents LabelError As Label
    Friend WithEvents TimerAdmin As Timer
    Friend WithEvents LabelNameandDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBoxDisplayAll As RichTextBox
    Friend WithEvents ComboBoxFilter As ComboBox
End Class
