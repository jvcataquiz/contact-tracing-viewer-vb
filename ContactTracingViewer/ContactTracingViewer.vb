Imports System.IO
Imports System.Text
Public Class ContactTracingViewer
    Dim filereader As System.IO.StreamReader
    Dim checker As String
    Dim date_Now() As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_Now = Split(DateTime.Now.ToString())
        LabelDate.Text = date_Now(0)
        LabelTime.Text = date_Now(1) & " " & date_Now(2)

        If TextBoxSearch.Text.Equals("") Then
            LabelError.Visible = False
            LabelError.Text = ""
        Else
            LabelError.Visible = True
            LabelError.ForeColor = System.Drawing.Color.Red
            LabelError.Text = "No Data Found!!!"
        End If
        MyData()
        mybtn()
    End Sub
    Sub MyData()
        filereader = My.Computer.FileSystem.OpenTextFileReader("contacttracing.txt")
        While Not filereader.EndOfStream
            checker = filereader.ReadLine()
            If checker.Contains(TextBoxSearch.Text) And checker.Equals("Fullname:  " & TextBoxSearch.Text) Then
                LabelError.Text = "DATA FOUND!!"
                LabelError.ForeColor = System.Drawing.Color.Green
            End If
        End While
    End Sub
    Sub mybtn()
        If LabelError.Text.Equals("DATA FOUND!!") Then
            ButtonOpen.Visible = True
        Else
            ButtonOpen.Visible = False
            RichTextBoxDisplay.Visible = False
            Me.ClientSize = New System.Drawing.Size(430, 239)
        End If
    End Sub
    Private Sub ButtonAdmin_Click_1(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        If ButtonAdmin.Text.Equals("ADMIN") Then
            PanelAdmin.Visible = True
            ButtonAdmin.Text = "USER"
            Me.ButtonAdmin.Location = New System.Drawing.Point(39, 190)
            Me.ClientSize = New System.Drawing.Size(432, 230)
        Else
            PanelAdmin.Visible = False
            ButtonAdmin.Text = "ADMIN"
            Me.ClientSize = New System.Drawing.Size(432, 200)
            Me.ButtonAdmin.Location = New System.Drawing.Point(39, 135)
        End If
        Me.ClientSize = New System.Drawing.Size(430, 239)
        RichTextBoxDisplay.Visible = False
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim stringPass As String
        stringPass = MyEncrypt(TextBoxPassword.Text)
        If TextBoxUsername.Text.Equals("Admin") And stringPass.Equals("YWRtaW4xMDE=") Then
            MessageBox.Show("Welcome Admin")
        Else
            MessageBox.Show("Wrong Username / Password")
        End If
    End Sub
    Function MyEncrypt(Encrytpt As String) As String
        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(Encrytpt.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encrytpt)
        msg = Convert.ToBase64String(encode)
        Return msg
    End Function
    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        RichTextBoxDisplay.Visible = True
        Me.ClientSize = New System.Drawing.Size(775, 239)

    End Sub
End Class
