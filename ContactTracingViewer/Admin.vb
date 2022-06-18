Public Class Admin
    Dim filereader As System.IO.StreamReader
    Dim filereaderall As System.IO.StreamReader
    Dim checker As String


    Public Sub MyData()
        filereader = My.Computer.FileSystem.OpenTextFileReader("contacttracing.txt")
        While Not filereader.EndOfStream
            checker = filereader.ReadLine()

            If checker.Contains(TextBoxSearch.Text) And checker.Equals("Fullname:  " & TextBoxSearch.Text) Then
                LabelError.Text = "DATA FOUND!!"
                LabelError.ForeColor = System.Drawing.Color.Green

                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                checker &= vbCrLf & filereader.ReadLine()
                RichTextBoxAdminDisplay.Text = checker
            End If
        End While
    End Sub
    Private Sub TimerAdmin_Tick(sender As Object, e As EventArgs) Handles TimerAdmin.Tick

        If TextBoxSearch.Text.Equals("") Then
            LabelError.Visible = False
            LabelError.Text = ""
            RichTextBoxAdminDisplay.Text = ""
        Else
            LabelError.Visible = True
            LabelError.ForeColor = System.Drawing.Color.Red
            LabelError.Text = "No Data Found!!!"
            RichTextBoxAdminDisplay.Text = ""
        End If
        MyData()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filereaderall = My.Computer.FileSystem.OpenTextFileReader("contacttracing.txt")
        RichTextBoxDisplayAll.Text = filereaderall.ReadToEnd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backtohome As New ContactTracingViewer
        backtohome.Show()
        Me.Hide()
    End Sub
End Class