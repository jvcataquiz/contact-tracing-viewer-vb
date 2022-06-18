Public Class Admin
    Dim filereader As System.IO.StreamReader
    Dim checker As String

    Private Sub ButtonAdminSearch_Click(sender As Object, e As EventArgs) Handles ButtonAdminSearch.Click

    End Sub
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
        Else
            LabelError.Visible = True
            LabelError.ForeColor = System.Drawing.Color.Red
            LabelError.Text = "No Data Found!!!"
        End If
        MyData()
    End Sub
End Class