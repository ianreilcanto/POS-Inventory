

Imports System.Globalization

Public Class Dashboard


    Private _orderList = New List(Of ProductOrder)




    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        main_container.Top = (Me.Height - main_container.Height) / 2
        main_container.Left = (Me.Width - main_container.Width) / 2

        cmd_cat.SelectedIndex = 0

        LoadGridViw()
        LoadProductList()

    End Sub

    Private Sub main_container_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles main_container.MouseClick

        If main_container.SelectedTab.Text = "Inventory" Then

            For i As Integer = 0 To grd_inventory.Rows.Count() - 1 Step +1

                'Dim row As DataGridViewRow = grd_inventory.Rows(i)
                Dim val As Integer
                val = grd_inventory.Rows(i).Cells(8).Value

                If val > 20 Then
                    grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf val <= 20 And val > 5 Then
                    grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                ElseIf val <= 5 Then
                    grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.Red
                End If

            Next

        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim productRepo = New ProductRepository()
        Dim inventoryRepo = New InventoryRepository()

        'need to add validation

        Dim product = New Product()
        Dim inventory = New Inventory()

        product.Code = fld_code.Text
        product.Name = fld_name.Text
        product.Price = fld_price.Text
        product.Model = fld_model.Text
        product.Brand = fld_brand.Text
        product.Category = cmd_cat.SelectedIndex + 1

        product.Id = productRepo.Insert(product)

        inventory.Quantity = Integer.Parse(fld_quantity.Text)

        inventory.Remarks = "Adding " & fld_quantity.Text & " on " & product.Name

        inventory.ProductId = product.Id
        inventory.UserId = 0

        Dim is_added As Boolean = inventoryRepo.Insert(inventory)

        If is_added Then
            MessageBox.Show(product.Name & " is added with " & inventory.Quantity)
        Else
            MessageBox.Show("Action Fail", "Entry Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        LoadGridViw()
        LoadProductList()
        ClearField()
    End Sub

    Private Sub grd_inventory_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_inventory.RowEnter

        grd_inventory.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        grd_inventory.Rows(e.RowIndex).Selected = True

        fld_inventory_id.Text = grd_inventory.Rows(e.RowIndex).Cells(0).Value
        fld_product_id.Text = grd_inventory.Rows(e.RowIndex).Cells(1).Value
        fld_code.Text = grd_inventory.Rows(e.RowIndex).Cells(2).Value
        fld_name.Text = grd_inventory.Rows(e.RowIndex).Cells(3).Value
        fld_price.Text = grd_inventory.Rows(e.RowIndex).Cells(4).Value
        fld_brand.Text = grd_inventory.Rows(e.RowIndex).Cells(5).Value
        fld_model.Text = grd_inventory.Rows(e.RowIndex).Cells(6).Value
        cmd_cat.SelectedIndex = GetAccesCatId(grd_inventory.Rows(e.RowIndex).Cells(7).Value)
        fld_quantity.Text = grd_inventory.Rows(e.RowIndex).Cells(8).Value
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim inventoryRepo = New InventoryRepository()
        Dim inventories = New Inventories()

        inventories = InvetoriesValue()

        If inventoryRepo.Update(inventories) Then
            MessageBox.Show("updated")
        End If


        LoadGridViw()
        LoadProductList()
        ClearField()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim inventoryRepo = New InventoryRepository()
        Dim inventories = New Inventories()

        inventories = InvetoriesValue()

        If inventoryRepo.Delete(inventories) Then
            MessageBox.Show("Deleted")
        End If


        LoadGridViw()
        ClearField()
    End Sub


    Private Sub fld_invetory_search_TextChanged(sender As Object, e As EventArgs) Handles fld_invetory_search.TextChanged
        Dim item As String = fld_invetory_search.Text

        If item = "" Then
            LoadGridViw()
        Else
            LoadGridSearch(item)
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        fld_name.Text = ""
        fld_price.Text = ""
        fld_code.Text = ""
        fld_brand.Text = ""
        fld_model.Text = ""
        cmd_cat.SelectedIndex = 0
        fld_quantity.Text = ""
        fld_inventory_id.Text = ""
        fld_product_id.Text = ""
    End Sub

    Public Sub LoadGridSearch(item As String)
        Dim inventoryRepo = New InventoryRepository()

        grd_inventory.DataSource = inventoryRepo.Search(item)
        grd_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub LoadGridViw()
        Dim inventoryRepo = New InventoryRepository()


        grd_inventory.DataSource = inventoryRepo.GetInventory()
        'add color on row


        For i As Integer = 0 To grd_inventory.Rows.Count() - 1 Step +1

            'Dim row As DataGridViewRow = grd_inventory.Rows(i)
            Dim val As Integer
            val = grd_inventory.Rows(i).Cells(8).Value

            If val > 20 Then
                grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf val <= 20 And val > 5 Then
                grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            ElseIf val <= 5 Then
                grd_inventory.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If

        Next

        grd_inventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Function GetAccesCatId(cat As String) As Int64
        Dim id As Integer

        If cat = "Accessories" Then
            id = 0
        ElseIf cat = "Mobile" Then
            id = 1
        ElseIf cat = "Tablet" Then
            id = 2
        End If

        Return id
    End Function

    Public Function InvetoriesValue() As Inventories
        Dim inventories = New Inventories()

        inventories.Id = fld_inventory_id.Text
        inventories.Product_Id = fld_product_id.Text
        inventories.Name = fld_name.Text
        inventories.Price = fld_price.Text
        inventories.Code = fld_code.Text
        inventories.Brand = fld_brand.Text
        inventories.Model = fld_model.Text
        inventories.Category = cmd_cat.SelectedItem
        inventories.Quantity = fld_quantity.Text

        Return inventories
    End Function

    Private Sub fld_product_search_TextChanged(sender As Object, e As EventArgs) Handles fld_product_search.TextChanged
        ProductSearch(fld_product_search.Text)
    End Sub


    Private Sub grd_product_list_DoubleClick(sender As Object, e As MouseEventArgs) Handles grd_product_list.DoubleClick
        Dim quantity As Integer
        Dim message As String = "Enter quantity"
        Dim title As String = "Quantity"
        Dim defaultValue As Integer = 1

        Dim product_id As Integer = grd_product_list.Item(0, grd_product_list.CurrentRow.Index).Value

        Try
            quantity = InputBox(message, title, defaultValue)
            AddOrder(quantity, product_id)
        Catch ex As Exception
            MessageBox.Show("Please Input accepted value")
        End Try



    End Sub

    Private Sub grd_product_list_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_product_list.KeyDown

        Dim quantity As Integer
        Dim message As String = "Enter quantity"
        Dim title As String = "Quantity"
        Dim defaultValue As Integer = 1

        If e.KeyCode = Keys.Enter Then

            Dim product_id As Integer = grd_product_list.Item(0, grd_product_list.CurrentRow.Index).Value

            Try
                quantity = InputBox(message, title, defaultValue)
                AddOrder(quantity, product_id)
            Catch ex As Exception
                MessageBox.Show("Please Input accepted value")
            End Try


            e.Handled = True

        End If
    End Sub


    Public Sub AddOrder(quantity As Integer, product_id As Integer)

        Dim productRepo = New ProductRepository()
        Dim product = New ProductOrder()

        Dim has_id As Boolean = False
        ''Dim product_id As Integer = cmd_search_product.SelectedValue

        For Each prod In _orderList
            If prod.Id = product_id Then
                prod.Quantity += quantity
                has_id = True
                Exit For
            End If
        Next

        If Not has_id Then
            product = productRepo.GetItem(product_id)
            product.Quantity = quantity

            _orderList.Add(product)
        End If

        OrderListView()



    End Sub

    Private Sub grd_order_list_DoubleClick(sender As Object, e As MouseEventArgs) Handles grd_order_list.DoubleClick
        Dim quantity As Integer
        Dim message As String = "Enter quantity"
        Dim title As String = "Remove Quantity"
        Dim defaultValue As Integer = 1
        Dim product_id As Integer


        Try
            quantity = InputBox(message, title, defaultValue)

            product_id = grd_order_list.Item(0, grd_order_list.CurrentRow.Index).Value

            For Each prod In _orderList
                If prod.Id = product_id Then
                    prod.Quantity -= quantity

                    If prod.Quantity <= 0 Then
                        _orderList.Remove(prod)
                    End If

                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Please Input accepted value")
        End Try

        OrderListView()

    End Sub

    Private Sub grd_order_list_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_order_list.KeyDown

        Dim quantity As Integer
        Dim message As String = "Enter quantity"
        Dim title As String = "Remove Quantity"
        Dim defaultValue As Integer = 1
        Dim product_id As Integer = Nothing

        If e.KeyCode = Keys.Enter Then

            Try
                quantity = InputBox(message, title, defaultValue)
                product_id = grd_order_list.Item(0, grd_order_list.CurrentRow.Index).Value
                For Each prod In _orderList
                    If prod.Id = product_id Then
                        prod.Quantity -= quantity

                        If prod.Quantity <= 0 Then
                            _orderList.Remove(prod)
                        End If

                        Exit For
                    End If
                Next


            Catch ex As Exception
                MessageBox.Show("Please Input accepted value")
            End Try

            e.Handled = True

        End If

        OrderListView()

    End Sub


    Private Sub fld_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fld_amount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1)))
    End Sub

    Private Sub fld_amount_TextChanged(sender As Object, e As EventArgs) Handles fld_amount.TextChanged

        Dim change As Double = 0.0

        If fld_amount.Text <> "" Then
            change = Double.Parse(fld_amount.Text) - Double.Parse(lbl_total.Text)
        End If

        lbl_change.Text = change
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        Dim order = New OrderRepository()

        Dim createdOrder As Integer = order.Create()

        If Double.Parse(fld_amount.Text) >= Double.Parse(lbl_total.Text) Then
            If order.AddOrders(createdOrder, _orderList) Then
                MessageBox.Show("Done Transaction")
                _orderList = New List(Of ProductOrder)
                OrderListView()
                lbl_total.Text = 0.00
                lbl_change.Text = 0.00
                fld_amount.Text = ""

                LoadGridViw()
                LoadProductList()
            End If
        Else
            MessageBox.Show("Insufficient Fund Cannot Process Transaction")
        End If


    End Sub

    Public Sub LoadProductList()
        Dim productRepo = New ProductRepository()


        grd_product_list.DataSource = productRepo.GetItems()
        grd_product_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Sub ProductSearch(item As String)

        Dim productRepo = New ProductRepository()

        grd_product_list.DataSource = productRepo.Search(item)
        grd_product_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Public Sub OrderListView()
        Dim totalPrice As Integer = 0
        grd_order_list.DataSource = Nothing
        grd_order_list.DataSource = _orderList
        grd_order_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        For Each product In _orderList
            totalPrice += (product.Price * product.Quantity)
        Next



        lbl_total.Text = totalPrice
    End Sub

    Private Sub btn_view_report_Click(sender As Object, e As EventArgs) Handles btn_view_report.Click


        Dim orderRepo = New OrderRepository()
        Dim fromDate As Date = dtp_from.Value
        Dim toDate As Date = dtp_to.Value

        Dim salesForm = New SalesReport(orderRepo.SalesReport(fromDate, toDate), fromDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), toDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
        salesForm.Show()
    End Sub

    Private Sub fld_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fld_price.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1)))
    End Sub

    Private Sub fld_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fld_quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub grd_product_list_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product_list.RowEnter

        grd_product_list.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        grd_product_list.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdvanceManagement.Show()
    End Sub

    Public Sub ClearField()
        fld_name.Text = ""
        fld_price.Text = ""
        fld_code.Text = ""
        fld_brand.Text = ""
        fld_model.Text = ""
        fld_quantity.Text = ""
        cmd_cat.SelectedIndex = 0
        fld_inventory_id.Text = ""
        fld_product_id.Text = ""
    End Sub

End Class


