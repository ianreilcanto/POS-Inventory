Public Class AdvanceManagement
    Private Sub AdvanceManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        cmd_category.SelectedIndex = 0
        fld_quantity.Text = 1
        LoadProductList()
        LoadInventory()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim inventoryRepo = New InventoryOutRepository()
        Dim inventory = New Inventory_out()

        Dim rowIndex As Integer = grd_productList.CurrentRow.Index
        Dim productId As Integer = grd_productList.Item(0, rowIndex).Value

        inventory.Quantity = fld_quantity.Text
        inventory.Category = cmd_category.SelectedItem
        inventory.Remarks = txt_remarks.Text
        inventory.ProductId = productId
        inventory.UserId = 0

        If inventoryRepo.Insert(inventory) Then
            MessageBox.Show("Transaction Successful")
            LoadInventory()
        End If



    End Sub

    Private Sub grd_inventory_ex_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_inventory_ex.KeyDown

        Dim inventoryRepo = New InventoryOutRepository()
        Dim inventory = New InventoriesOut()

        Dim row As Integer = grd_inventory_ex.CurrentRow.Index
        Dim inventory_id As Integer = GetValue(row, 0)
        If e.KeyCode = Keys.Delete Then

            Dim result As Integer = MessageBox.Show("Are you sure you want to delete this Item ?", "Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                inventoryRepo.Delete(inventory_id)
                MessageBox.Show("Completed")
                LoadInventory()
            End If

        End If

        If e.KeyCode = Keys.Enter Then

            Try
                inventory.Id = inventory_id
                inventory.Remarks = GetValue(row, 8)
                inventory.Quantity = GetValue(row, 7)

                If inventoryRepo.Update(inventory) Then
                    MessageBox.Show("Updated")
                End If
            Catch ex As Exception
                MessageBox.Show("Field Error")
            End Try

            LoadInventory()
        End If

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grd_inventory_ex.DataError

        MessageBox.Show("Check the field, Row not updated")

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
            .ErrorText = "an error"

            e.ThrowException = False
        End If
    End Sub

    Public Function GetValue(row As Integer, col As Integer) As String
        Return grd_inventory_ex.Item(col, row).Value
    End Function

    Public Sub LoadInventory()
        Dim inventoryRepo = New InventoryOutRepository()

        grd_inventory_ex.DataSource = inventoryRepo.GetInventory()
        grd_inventory_ex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Sub LoadProductList()
        Dim productRepo = New ProductRepository()


        grd_productList.DataSource = productRepo.GetItems()
        grd_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub fld_search_product_TextChanged(sender As Object, e As EventArgs) Handles fld_search_product.TextChanged
        ProductSearch(fld_search_product.Text)
    End Sub
    'InventorySearch
    Public Sub InventorySearch(item As String)

        Dim inventoryRepo = New InventoryOutRepository()

        grd_inventory_ex.DataSource = inventoryRepo.Search(item)
        grd_inventory_ex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Public Sub ProductSearch(item As String)

        Dim productRepo = New ProductRepository()

        grd_productList.DataSource = productRepo.Search(item)
        grd_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub fld_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fld_quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub grd_productList_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productList.RowEnter
        grd_productList.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        grd_productList.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub grd_inventory_ex_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_inventory_ex.RowEnter
        grd_inventory_ex.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        grd_inventory_ex.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub fld_search_TextChanged(sender As Object, e As EventArgs) Handles fld_search.TextChanged
        If fld_search.Text = String.Empty Then
            LoadInventory()
        Else
            InventorySearch(fld_search.Text)
        End If
    End Sub
End Class