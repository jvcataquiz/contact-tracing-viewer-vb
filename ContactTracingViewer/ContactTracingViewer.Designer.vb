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
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(170, 108)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "SEARCH"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonAdmin
        '
        Me.ButtonAdmin.Location = New System.Drawing.Point(39, 166)
        Me.ButtonAdmin.Name = "ButtonAdmin"
        Me.ButtonAdmin.Size = New System.Drawing.Size(69, 23)
        Me.ButtonAdmin.TabIndex = 2
        Me.ButtonAdmin.TabStop = False
        Me.ButtonAdmin.Text = "ADMIN"
        Me.ButtonAdmin.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(39, 75)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(336, 20)
        Me.TextBoxSearch.TabIndex = 0
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Location = New System.Drawing.Point(36, 52)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(67, 13)
        Me.LabelFullname.TabIndex = 3
        Me.LabelFullname.Text = "FULLNAME:"
        '
        'ContactTracingViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 214)
        Me.Controls.Add(Me.LabelFullname)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonAdmin)
        Me.Controls.Add(Me.ButtonSearch)
        Me.MaximizeBox = False
        Me.Name = "ContactTracingViewer"
        Me.Text = "ContactTracingViewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonAdmin As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents LabelFullname As Label
End Class
