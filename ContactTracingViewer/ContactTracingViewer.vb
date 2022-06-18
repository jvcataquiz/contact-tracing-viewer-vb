Imports System.IO

Public Class ContactTracingViewer
    Dim filereader As System.IO.StreamReader
    Dim checker As String
    Dim flag As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        'This if else statement is for Email to validate the input of the user
        If TextBoxSearch.Text.Equals("") Then
            LabelError.Visible = False
            LabelError.Text = ""
        Else
            LabelError.Visible = True
            LabelError.Text = "No Data Found!!!"
        End If
        MyData()

    End Sub

    Sub MyData()
        filereader = My.Computer.FileSystem.OpenTextFileReader("contacttracing.txt")
        While Not filereader.EndOfStream
            checker = filereader.ReadLine()
            'if the checker cointains a fullname of the user this code will count how many data will found
            If checker.Contains(TextBoxSearch.Text) And checker.Equals("Fullname:  " & TextBoxSearch.Text) Then
                'if checker detect a data in the textfile a change the value of flag
                flag = True
                LabelError.Text = "DATA FOUND!!"
                LabelError.Visible = True

            End If
        End While
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If File.Exists("contacttracing.txt") Then
            MessageBox.Show("Yes")
        End If
    End Sub
End Class
