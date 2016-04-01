Imports System.Data.OleDb

Public Class DeleteFromEvents

    Function DeleteRow(EventName As String)



        Dim connetionString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\bokang\Documents\49310410\Athletic Club Management System\AthleticsDB.accdb"
        Dim connection As New OleDbConnection(connetionString)

        Dim query As String = "DELETE * FROM tblEvents" & " WHERE EventTitle = @EventName"

        Dim myCommand As New OleDbCommand(query, connection)
        myCommand.Parameters.AddWithValue("@EventName", EventName)

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
