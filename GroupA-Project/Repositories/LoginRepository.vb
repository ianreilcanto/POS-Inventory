Imports MySql.Data.MySqlClient

Public Class LoginRepository
    Dim connectionString As String = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;"

    Dim MysqlConn As New MySqlConnection
    Dim sqlCommand As MySqlCommand

    Public Sub New()
        If Not MysqlConn Is Nothing Then MysqlConn.Close()
        MysqlConn.ConnectionString = connectionString

        Try
            MysqlConn.Open()
        Catch ex As Exception

        End Try
    End Sub

    Public Function IsLogin(username As String, password As String) As Boolean
        Dim is_login As Boolean = False

        Dim query As String = "SELECT * from `user` WHERE username='" & username & "' AND password=md5('" & password & "')"

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                is_login = True

            End While

            MysqlConn.Close()

        Catch ex As Exception
            is_login = False
        End Try

        Return is_login
    End Function
End Class
