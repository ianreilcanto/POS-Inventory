Imports MySql.Data.MySqlClient

Public Class InventoryOutRepository
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

    Public Function Insert(inventory As Inventory_out) As Boolean

        Dim is_added As Boolean

        Dim query As String = "INSERT INTO `inventory_out`( `quantity`, `category`, `remarks`, `date_updated`, `Product_id`, `User_id`) "
        query &= "VALUES (" & inventory.Quantity & " ,'" & inventory.Category & "','" & inventory.Remarks & "',now()," & inventory.ProductId & "," & inventory.UserId & ")"

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            is_added = True
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)
            is_added = False

        End Try

        Return is_added

    End Function

    Public Function GetInventory() As List(Of InventoriesOut)
        Dim inventories As InventoriesOut = Nothing
        Dim inventoryData = New List(Of InventoriesOut)

        Dim query As String = "SELECT i.id as `Id`,p.Id as `Product Id`, p.code as `Code`, p.name as `Name`, p.price as `Product Price` ,"
        query &= "i.category as `Category`,i.date_updated as `Date`,i.remarks as `Remarks`,i.quantity as `Quantity` FROM `product` as p ,`inventory_out` as i"
        query &= " WHERE i.Product_id = p.Id"



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                inventories = New InventoriesOut() With {.Id = reader("Id"), .ProductId = reader("Product Id"), .Code = reader("Code"), .Name = reader("Name"), .Price = reader("Product Price"),
                   .DateUpdated = reader("Date"), .Category = reader("Category"), .Remarks = reader("Remarks"), .Quantity = reader("Quantity")}

                inventoryData.Add(inventories)

            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception

        End Try

        Return inventoryData

    End Function

    Public Function Delete(id As Integer) As Boolean
        Dim is_updated As Boolean

        Dim query As String = "DELETE FROM `inventory_out` WHERE id=" & id

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            is_updated = True
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)
            is_updated = False

        End Try

        Return is_updated
    End Function

    Public Function Update(inventory As InventoriesOut) As Boolean
        Dim is_updated As Boolean


        Dim query As String = "UPDATE `inventory_out` "
        query &= "SET `quantity`=" & inventory.Quantity & ",`date_updated`= now(),`remarks`='" & inventory.Remarks & "' WHERE id=" & inventory.Id



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            is_updated = True
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)
            is_updated = False

        End Try

        Return is_updated

    End Function

    Public Function Search(item As String) As List(Of InventoriesOut)
        Dim inventories As InventoriesOut = Nothing
        Dim inventoryData = New List(Of InventoriesOut)


        Dim query As String = "SELECT i.id as `Id`,p.Id as `Product Id`, p.code as `Code`, p.name as `Name`, p.price as `Product Price` ,"
        query &= "i.category as `Category`,i.date_updated as `Date`,i.remarks as `Remarks`,i.quantity as `Quantity` FROM `product` as p ,`inventory_out` as i"
        query &= " WHERE i.Product_id = p.Id"
        query &= "&& (p.code LIKE '%" & item & "%' || p.name LIKE '%" & item & "%' || i.category LIKE '%" & item & "%')  GROUP BY `Product Id`"



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                inventories = New InventoriesOut() With {.Id = reader("Id"), .ProductId = reader("Product Id"), .Code = reader("Code"), .Name = reader("Name"), .Price = reader("Product Price"),
                   .DateUpdated = reader("Date"), .Category = reader("Category"), .Remarks = reader("Remarks"), .Quantity = reader("Quantity")}

                inventoryData.Add(inventories)


            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception

        End Try

        Return inventoryData
    End Function

End Class
