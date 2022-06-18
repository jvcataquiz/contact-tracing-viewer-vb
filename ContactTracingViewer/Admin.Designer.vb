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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.RichTextBoxAdminDisplay = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBoxDisplayAll = New System.Windows.Forms.RichTextBox()
        Me.TimerAdmin = New System.Windows.Forms.Timer(Me.components)
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
        Me.TabControl1.Size = New System.Drawing.Size(478, 302)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LabelError)
        Me.TabPage1.Controls.Add(Me.TextBoxSearch)
        Me.TabPage1.Controls.Add(Me.RichTextBoxAdminDisplay)
        Me.TabPage1.ForeColor = System.Drawing.Color.Red
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(470, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FULLNAME: (LASTNAME, FIRSTNAME MI.)"
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
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.RichTextBoxAdminDisplay.Size = New System.Drawing.Size(436, 170)
        Me.RichTextBoxAdminDisplay.TabIndex = 5
        Me.RichTextBoxAdminDisplay.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBoxDisplayAll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(470, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "All Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBoxDisplayAll
        '
        Me.RichTextBoxDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxDisplayAll.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBoxDisplayAll.Name = "RichTextBoxDisplayAll"
        Me.RichTextBoxDisplayAll.Size = New System.Drawing.Size(464, 270)
        Me.RichTextBoxDisplayAll.TabIndex = 0
        Me.RichTextBoxDisplayAll.Text = ""
        '
        'TimerAdmin
        '
        Me.TimerAdmin.Enabled = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 300)
        Me.Controls.Add(Me.TabControl1)
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBoxDisplayAll As RichTextBox
    Friend WithEvents LabelError As Label
    Friend WithEvents TimerAdmin As Timer
    Friend WithEvents Label1 As Label
End Class
