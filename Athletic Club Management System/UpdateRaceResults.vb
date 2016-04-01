Imports System.Data.OleDb

Public Class UpdateRaceResults

    Function UpdateRace(eventname As String, finishH As Integer, finishM As Integer, finishS As Integer, memberNum As String)

        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "UPDATE tblRace SET [EventTitle]= '" & eventname & "', [FinishHour]= '" & finishH & "',[FinishMinutes]= '" & finishM & "', [FinishSeconds]= '" & finishS & "' WHERE [MemberNum] = '" & memberNum & "'"

        Dim myCommand As New OleDbCommand(query, connection)


        Try
            connection.Open()
            Dim count As String = myCommand.ExecuteNonQuery
            MessageBox.Show("Update successful")



        Catch ex As Exception
            MessageBox.Show("error" & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try


    End Function

End Class
