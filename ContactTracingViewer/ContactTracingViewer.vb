﻿Imports System.IO

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
            'if the checker cointains a fullname of the user this code will count how many data will found
            If checker.Contains(TextBoxSearch.Text) And checker.Equals("Fullname:  " & TextBoxSearch.Text) Then
                'if checker detect a data in the textfile a change the value of flag

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
        End If
    End Sub

    Private Sub ContactTracingViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mybtn()
    End Sub

    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonAdmin_Click_1(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        If ButtonAdmin.Text.Equals("ADMIN") Then
            PanelAdmin.Visible = True
            ButtonAdmin.Text = "USER"
        Else
            PanelAdmin.Visible = False
            ButtonAdmin.Text = "ADMIN"
        End If
    End Sub
End Class
