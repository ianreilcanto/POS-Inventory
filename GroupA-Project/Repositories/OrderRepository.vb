Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class OrderRepository
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

    Public Function Create() As Integer
        Dim id As Integer
        Dim query As String = "INSERT INTO `order`(`date_ordered`, `User_id`) VALUES (now(),0)"

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            sqlCommand.ExecuteNonQuery()

            id = sqlCommand.LastInsertedId
            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show("inventory" & ex.Message)

        End Try

        Return id
    End Function

    Public Function AddOrders(orderId As Integer, orderList As List(Of ProductOrder)) As Boolean
        Dim is_added As Boolean

        Try



            For Each product In orderList

                Dim quantity As Integer = 0
                Dim query = "SELECT quantity FROM `inventory` WHERE Product_id = " & product.Id

                MysqlConn.Open()

                sqlCommand = New MySqlCommand(query, MysqlConn)
                Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                While reader.Read()

                    quantity = reader("quantity")

                End While

                reader.Close()

                MysqlConn.Close()

                '== updating orderlist table 

                Dim query1 As String = "INSERT INTO `order_deatails`(`selling_price`, `quantity`, `Order_id`, `Product_id`)"
                query1 &= "VALUES (" & product.Price & "," & product.Quantity & "," & orderId & "," & product.Id & ")"

                Dim query2 As String = "UPDATE `inventory` SET `quantity`=" & (quantity - product.Quantity) & ",`date_updated`= now() ,"
                query2 &= "`updated_remarks`='deducted from sales' WHERE Product_id =" & product.Id

                Dim queryString As String = String.Concat(query1, ";", query2)

                MysqlConn.Open()

                sqlCommand = New MySqlCommand(queryString, MysqlConn)
                sqlCommand.ExecuteNonQuery()

                MysqlConn.Close()
            Next
            is_added = True


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

        Return is_added
    End Function

    Public Function SalesReport(fromDate As Date, toDate As Date) As List(Of Sales)

        Dim product As Sales = Nothing
        Dim sales = New List(Of Sales)



        Dim query As String = "SELECT o.date_ordered as `Order Date`, p.id as `Product Id`, p.name as `Product Name`, p.code as `Product Code`, "
        query &= "od.selling_price as `Price`, sum(od.quantity) as `Quantity`, sum( od.selling_price * od.quantity) as `Total` FROM `order` as o,"
        query &= " `order_deatails` as od, `product` as p "
        query &= "WHERE o.id = od.Order_id AND p.id = od.Product_id AND (o.date_ordered >= '" & fromDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) & "' AND o.date_ordered <= '" & toDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) & "')"
        query &= "Group BY p.id,o.date_ordered, od.selling_price"

        Try
            sqlCommand = New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()

                product = New Sales() With {.Id = reader("Product Id"), .Product_Code = reader("Product Code"), .Date_Ordered = reader("Order Date"),
                .Product_Name = reader("Product Name"), .Price = reader("Price"), .Quantity = reader("Quantity"), .Total = reader("Total")}

                sales.Add(product)

            End While

            reader.Close()

            MysqlConn.Close()


        Catch ex As Exception

        End Try

        Return sales

    End Function

End Class
