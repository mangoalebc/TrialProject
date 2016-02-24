
Imports System.IO                               'references to the System Input Output classes
Public Class MainMenu
    Private Const Dir As String = "D:\VB 2012\Files\"     'reference to the directory where file is stored
    Private Const Path As String = Dir & "EventsFile.txt" 'check if file is available, if so it deletes it





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' If Not Directory.Exists(dir) Then       'check if the directory exists, if not it is created
        'Directory.CreateDirectory(dir)
        ' End If


        ' If File.Exists(path) Then
        ' File.Delete(path)
        'End If


        Dim eventName As String
        Dim eventDate As Date
        Dim eventLocation As String
        Dim regFee As Decimal
        Dim eventDistance As String

        eventName = txtEvent_Name.Text
        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        regFee = txtEvent_Reg_Fee.Text
        eventDistance = cbxEvent_distance.SelectedItem
        MessageBox.Show(eventName)
        Dim fs As FileStream
        fs = New FileStream(Path, FileMode.Append, FileAccess.Write) 'filestream for writing

        Try

            Dim textOut As New StreamWriter(fs)

            'For Each product As Product In products
            textOut.Write(eventName & "|")
            textOut.Write(eventDate & "|")
            textOut.Write(regFee & "|")
            textOut.Write(eventLocation & "|")
            textOut.WriteLine(eventDistance)
            'Next
            textOut.Close()

        Catch ex As FileNotFoundException
            MessageBox.Show(Path & " not found.", "File Not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(Dir & " not found.", "Directory Not Found")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try


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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class
