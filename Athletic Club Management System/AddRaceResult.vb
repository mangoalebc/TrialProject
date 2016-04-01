Imports System.Data.OleDb

Public Class AddRaceResult

    'add race results
    Function AddNewEntry(eventName As String, memberNum As String, finishHour As Integer, finishMin As Integer, finishSec As Integer)

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "INSERT INTO tblRace" & "(EventTitle,MemberNum,FinishHour,FinishMinutes,FinishSeconds)" & "VALUES(@eventName, @memberNum, @finishHour,@finishMin,@finishSec)"

        Dim myCommand As New OleDbCommand(query, connection)

        myCommand.Parameters.AddWithValue("@eventName", eventName)
        myCommand.Parameters.AddWithValue("@memberNum", memberNum)
        myCommand.Parameters.AddWithValue("@finishHour", finishHour)
        myCommand.Parameters.AddWithValue("@finishMin", finishMin)
        myCommand.Parameters.AddWithValue("@finishSec", finishSec)

        Try
            connection.Open()

            myCommand.ExecuteNonQuery()

            MessageBox.Show("Entry successful")



        Catch ex As Exception

            MessageBox.Show("error  " & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try
    End Function
End Class
