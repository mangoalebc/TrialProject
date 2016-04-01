Imports System.Data.OleDb

Public Class DeleteFromAthletes

    Function DeleteRowA(MemberNum As String)



        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "DELETE * FROM tblAthletes" & " WHERE MemberNum = @MemberNum"

        Dim myCommand As New OleDbCommand(query, connection)
        myCommand.Parameters.AddWithValue("@MemberNum", MemberNum)

        Try
            connection.Open()
            Dim count As String = myCommand.ExecuteNonQuery
            MessageBox.Show("Delete successful")



        Catch ex As Exception
            MessageBox.Show("error" & ex.Message & ex.GetType.ToString)

        Finally
            connection.Close()

        End Try
    End Function

End Class
