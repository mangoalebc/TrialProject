
Imports System.IO                               'references to the System Input Output classes
Public Class MainMenu
    Dim dir As String = "D:\VB 2012\Files\"     'reference to the directory where file is stored
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not Directory.Exists(dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(dir)
        End If

        Dim path As String = dir & " Events.txt" 'check if file is available, if so it deletes it
        If File.Exists(path) Then
            ' File.Delete(path)
        End If
        Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write) 'filestream for writing
        Dim eventName As Char
        Dim eventDate As Date
        Dim eventLocation As Char
        Dim regFee As Integer
        Dim eventDistance As Char

        eventName = txtEvent_Name.Text
        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        regFee = txtEvent_Reg_Fee.Text
        eventDistance = cbxEvent_distance.SelectedItem

        Try
            fs = New FileStream(path, FileMode.Open) 'filestream for writing
            Dim textOut As New StreamWriter(fs)

            For Each raceEvent As REvent In REvents
                textOut.Write(raceEvent.eventName & "|")
                textOut.Write(raceEvent.eventLocation & "|")
                textOut.WriteLine(raceEvent.regFee)
            Next
            textOut.Close()


        Catch ex As FileNotFoundException
            MessageBox.Show(path & " not found.", "File Not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(dir & " not found.", "Directory Not Found")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try


        

        txtEvent_Location.Text = eventDistance


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEvent_Name.Text = ""
        dtpEvent_Date.Refresh()
        txtEvent_Reg_Fee.Text = ""
        txtEvent_Location.Clear()
        cbxEvent_distance.ResetText()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
