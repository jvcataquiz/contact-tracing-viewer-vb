<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.RichTextBoxAdminDisplay = New System.Windows.Forms.RichTextBox()
        Me.ButtonAdminSearch = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBoxDisplayAll = New System.Windows.Forms.RichTextBox()
        Me.LabelError = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(478, 273)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.LabelError)
        Me.TabPage1.Controls.Add(Me.TextBoxSearch)
        Me.TabPage1.Controls.Add(Me.RichTextBoxAdminDisplay)
        Me.TabPage1.Controls.Add(Me.ButtonAdminSearch)
        Me.TabPage1.ForeColor = System.Drawing.Color.Red
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(470, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(98, 216)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(349, 20)
        Me.TextBoxSearch.TabIndex = 3
        '
        'RichTextBoxAdminDisplay
        '
        Me.RichTextBoxAdminDisplay.Location = New System.Drawing.Point(11, 12)
        Me.RichTextBoxAdminDisplay.Name = "RichTextBoxAdminDisplay"
        Me.RichTextBoxAdminDisplay.Size = New System.Drawing.Size(436, 175)
        Me.RichTextBoxAdminDisplay.TabIndex = 2
        Me.RichTextBoxAdminDisplay.Text = ""
        '
        'ButtonAdminSearch
        '
        Me.ButtonAdminSearch.ForeColor = System.Drawing.Color.Black
        Me.ButtonAdminSearch.Location = New System.Drawing.Point(14, 215)
        Me.ButtonAdminSearch.Name = "ButtonAdminSearch"
        Me.ButtonAdminSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdminSearch.TabIndex = 0
        Me.ButtonAdminSearch.Text = "Search"
        Me.ButtonAdminSearch.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBoxDisplayAll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(470, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "All Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBoxDisplayAll
        '
        Me.RichTextBoxDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxDisplayAll.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBoxDisplayAll.Name = "RichTextBoxDisplayAll"
        Me.RichTextBoxDisplayAll.Size = New System.Drawing.Size(464, 241)
        Me.RichTextBoxDisplayAll.TabIndex = 0
        Me.RichTextBoxDisplayAll.Text = ""
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(103, 199)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(89, 13)
        Me.LabelError.TabIndex = 4
        Me.LabelError.Text = "No Data Found!!!"
        '
        'TimerAdmin
        '
        Me.TimerAdmin.Enabled = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 274)
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
    Friend WithEvents ButtonAdminSearch As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBoxDisplayAll As RichTextBox
    Friend WithEvents LabelError As Label
    Friend WithEvents TimerAdmin As Timer
End Class
