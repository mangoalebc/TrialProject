
Imports System.IO                               'references to the System Input Output classes
Public Class MainMenu
    Private Const Dir As String = "D:\VB 2012\Files\"     'reference to the directory where file is stored
    Private Const Path As String = Dir & "EventsFile.txt" 'check if file is available, if so it deletes it



    Dim nameStack As New Stack(Of String)
    Dim dateStack As New Stack(Of String)
    Dim regfeeStack As New Stack(Of String)
    Dim locationStack As New Stack(Of String)
    Dim distanceStack As New Stack(Of String)

    Dim eventName As String
    Dim eventDate As Date
    Dim eventLocation As String
    Dim regFee As Decimal
    Dim eventDistance As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))

        Dim namestackstring As String = ""
        Dim eventExists As Boolean
        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)

            'For display purpose
            eventDate = columns(1)
            regFee = columns(2)
            eventLocation = columns(3)
            eventDistance = columns(4)
            'end

            If eventName = txtEvent_Name.Text Then
                eventExists = True
                MessageBox.Show(eventName & " event already exists, please recapture unique event title!")

            End If
            'For display purpose
            nameStack.Push(eventName)
            dateStack.Push(eventDate)
            regfeeStack.Push(regFee)
            locationStack.Push(eventLocation)
            distanceStack.Push(eventDistance)

            namestackstring &= nameStack.Pop & " " & dateStack.Pop & " " & regfeeStack.Pop & " " & locationStack.Pop & " " & distanceStack.Pop & " " & vbCrLf
            'end
        Loop
        textIn.Close()
        'For display purpose
        MessageBox.Show(namestackstring, "Stack")
        'end


        eventName = txtEvent_Name.Text
        eventDate = dtpEvent_Date.Value
        eventLocation = txtEvent_Location.Text
        regFee = txtEvent_Reg_Fee.Text
        eventDistance = cbxEvent_distance.SelectedItem

        If eventExists = False Then

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

        End If

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
        If Not Directory.Exists(Dir) Then       'check if the directory exists, if not it is created
            Directory.CreateDirectory(Dir)
        End If
        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
        Dim namestackstring As String = ""

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            eventName = columns(0)
            eventDate = columns(1)
            regFee = columns(2)
            eventLocation = columns(3)
            eventDistance = columns(4)

            nameStack.Push(eventName)
            dateStack.Push(eventDate)
            regfeeStack.Push(regFee)
            locationStack.Push(eventLocation)
            distanceStack.Push(eventDistance)

            namestackstring &= nameStack.Pop & " " & dateStack.Pop & " " & regfeeStack.Pop & " " & locationStack.Pop & " " & distanceStack.Pop & " " & vbCrLf
        Loop
        textIn.Close()
        MessageBox.Show(namestackstring, "Stack")
        ' MessageBox.Show(eventName & " " & eventDate & " " & regFee & " " & eventLocation & " " & eventDistance)

        ' If File.Exists(path) Then
        ' File.Delete(path)
        'End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class
