Imports MySql.Data.MySqlClient

Public Class ProductRepository

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

    Public Function Insert(product As Product) As Integer

        Dim insertedId As Integer
        Dim query As String = "INSERT INTO `inventory_db`.`Product` (`code`, `name`,`price`, `brand`, `model`, `Product_Cat_id`) "
        query &= "VALUES ('" & product.Code & "', '" & product.Name & "'," & product.Price & ",'" & product.Brand & "', '" & product.Model & "', " & product.Category & ");"

        Try

            sqlCommand = New MySqlCommand(query, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            insertedId = sqlCommand.LastInsertedId

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show("product" & ex.Message)
        End Try

        Return insertedId
    End Function

    Public Function GetItem(id As Integer) As ProductOrder
        Dim product = New ProductOrder()

        Dim query As String = "SELECT `id`,`code`,`name`, `price` FROM `product` Where id= " & id

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                product.Id = reader("id")
                product.Code = reader("code")
                product.Name = reader("name")
                product.Price = reader("price")

            End While

            reader.Close()

            MysqlConn.Close()

        Catch ex As Exception

        End Try
        Return product
    End Function

    Public Function GetItems() As List(Of ProductSearch)
        Dim product As ProductSearch = Nothing
        Dim searchItem = New List(Of ProductSearch)


        Dim query As String = "SELECT `id`,`code`,`name`, `price` FROM `product`"



        Try

            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                product = New ProductSearch() With {.Id = reader("id"), .Code = reader("code"), .Name = reader("name"), .Price = reader("price")}
                searchItem.Add(product)
            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception
            Dim test = ex
        End Try

        Return searchItem
    End Function

    Public Function Search(item As String) As List(Of ProductSearch)
        Dim product As ProductSearch = Nothing
        Dim searchItem = New List(Of ProductSearch)


        Dim query As String = "SELECT `id`,`code`,`name`, `price` FROM `product` WHERE (`name` LIKE '%" & item & "%' || `code` LIKE '%" & item & "%')"



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                product = New ProductSearch() With {.Id = reader("id"), .Code = reader("code"), .Name = reader("name"), .Price = reader("price")}
                searchItem.Add(product)
            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception

        End Try

        Return searchItem
    End Function



End Class
