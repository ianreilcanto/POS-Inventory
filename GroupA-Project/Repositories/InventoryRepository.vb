Imports MySql.Data.MySqlClient

Public Class InventoryRepository

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

    Public Function Insert(inventory As Inventory) As Boolean

        Dim is_added As Boolean

        Dim query As String = "INSERT INTO `inventory`( `quantity`, `date _added`, `date_updated`, `updated_remarks`, `Product_id`, `User_id`) "
        query &= "VALUES (" & inventory.Quantity & " ,now(),now(),'" & inventory.Remarks & "'," & inventory.ProductId & "," & inventory.UserId & ")"

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

    Public Function Update(product As Product) As Boolean
        Dim is_updated As Boolean

        Return is_updated
    End Function

    Public Function GetInventory() As List(Of Inventories)
        Dim inventories As Inventories = Nothing
        Dim inventoryData = New List(Of Inventories)

        Dim query As String = "SELECT i.id as `Id`,p.Id as `Product Id`, p.code as `Code`, p.name as `Name`, p.price as `Product Price` ,p.brand as `Brand`,"
        query &= "p.model as `Model`, p.Product_Cat_id as `Category`, i.quantity as `Quantity` FROM `product` as p ,`inventory` as i"
        query &= " WHERE i.Product_id = p.Id"



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                inventories = New Inventories() With {.Id = reader("Id"), .Product_Id = reader("Product Id"), .Code = reader("Code"), .Name = reader("Name"), .Price = reader("Product Price"),
                    .Brand = reader("Brand"), .Model = reader("Model"), .Category = Me.GetCat(reader("Category")), .Quantity = reader("Quantity")}

                inventoryData.Add(inventories)

            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception

        End Try

        Return inventoryData

    End Function

    Public Function Update(inventories As Inventories) As Boolean
        Dim is_updated As Boolean

        Dim query As String = "UPDATE `product`"
        query &= "SET `code`='" & inventories.Code & "', `name`='" & inventories.Name & "',`price` = " & inventories.Price & ",`brand`='" & inventories.Brand & "',"
        query &= "`model`='" & inventories.Model & "',`Product_Cat_id`='" & GetCatId(inventories.Category) & "' WHERE id =" & inventories.Product_Id

        Dim query2 As String = "UPDATE `inventory` "
        query2 &= "SET `quantity`=" & inventories.Quantity & ",`date_updated`= now(),`updated_remarks`='quantity is now " & inventories.Quantity & "' WHERE id=" & inventories.Id

        Dim queryString As String = String.Concat(query, ";", query2)

        Try
            sqlCommand = New MySqlCommand(queryString, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            is_updated = True
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)
            is_updated = False

        End Try

        Return is_updated

    End Function

    Public Function Delete(inventories As Inventories) As Boolean
        Dim is_updated As Boolean

        Dim query As String = "DELETE FROM `inventory` WHERE id=" & inventories.Id

        Dim query2 As String = "DELETE FROM `product` WHERE id=" & inventories.Product_Id

        Dim queryString As String = String.Concat(query, ";", query2)

        Try
            sqlCommand = New MySqlCommand(queryString, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            is_updated = True
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)
            is_updated = False

        End Try

        Return is_updated
    End Function

    Public Function Search(item As String) As List(Of Inventories)
        Dim inventories As Inventories = Nothing
        Dim inventoryData = New List(Of Inventories)


        Dim query As String = "SELECT i.id as `Id`,p.Id as `Product Id`, p.code as `Code`, p.name as `Name`, p.price as `Product Price` ,p.brand as `Brand`,"
        query &= "p.model as `Model`, p.Product_Cat_id as `Category`, i.quantity as `Quantity` FROM `product` as p ,`inventory` as i"
        query &= " WHERE i.Product_id = p.Id "
        query &= "&& (p.code LIKE '%" & item & "%' || p.name LIKE '%" & item & "%' || p.brand LIKE '%" & item & "%' || p.model LIKE '%" & item & "%') GROUP BY `Product Id`"



        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                inventories = New Inventories() With {.Id = reader("Id"), .Product_Id = reader("Product Id"), .Code = reader("Code"), .Name = reader("Name"), .Price = reader("Product Price"),
                    .Brand = reader("Brand"), .Model = reader("Model"), .Category = Me.GetCat(reader("Category")), .Quantity = reader("Quantity")}

                inventoryData.Add(inventories)

            End While

            reader.Close()




            MysqlConn.Close()

        Catch ex As Exception

        End Try

        Return inventoryData
    End Function

    Public Function GetCat(cat As Integer) As String

        Dim category As String = ""

        If cat = 1 Then
            category = "Accessories"
        ElseIf cat = 2 Then
            category = "Mobile"
        ElseIf cat = 3 Then
            category = "Tablet"
        End If

        Return category
    End Function

    Public Function GetCatId(cat As String) As Integer
        Dim id As Integer

        If cat = "Accessories" Then
            id = 1
        ElseIf cat = "Mobile" Then
            id = 2
        ElseIf cat = "Tablet" Then
            id = 3
        End If

        Return id
    End Function

End Class
