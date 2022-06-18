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
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAdmin = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(169, 123)
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
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(359, 20)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
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
        'ContactTracingViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 202)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.LabelDate)
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
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents Timer1 As Timer
End Class
