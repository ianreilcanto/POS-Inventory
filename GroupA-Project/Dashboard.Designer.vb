<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.main_container = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnl2_sales = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_view_report = New System.Windows.Forms.Button()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.fld_amount = New System.Windows.Forms.TextBox()
        Me.grd_order_list = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.pnl1_sales = New System.Windows.Forms.Panel()
        Me.fld_product_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_product_list = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_graph = New System.Windows.Forms.Button()
        Me.grd_inventory = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fld_invetory_search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.fld_price = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.fld_product_id = New System.Windows.Forms.TextBox()
        Me.fld_inventory_id = New System.Windows.Forms.TextBox()
        Me.fld_quantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_cat = New System.Windows.Forms.ComboBox()
        Me.fld_model = New System.Windows.Forms.TextBox()
        Me.fld_brand = New System.Windows.Forms.TextBox()
        Me.fld_code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fld_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.main_container.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnl2_sales.SuspendLayout()
        CType(Me.grd_order_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1_sales.SuspendLayout()
        CType(Me.grd_product_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grd_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_container
        '
        Me.main_container.Controls.Add(Me.TabPage1)
        Me.main_container.Controls.Add(Me.TabPage2)
        Me.main_container.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.main_container.Location = New System.Drawing.Point(47, 94)
        Me.main_container.Margin = New System.Windows.Forms.Padding(0)
        Me.main_container.Name = "main_container"
        Me.main_container.Padding = New System.Drawing.Point(0, 0)
        Me.main_container.SelectedIndex = 0
        Me.main_container.Size = New System.Drawing.Size(1299, 676)
        Me.main_container.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnl2_sales)
        Me.TabPage1.Controls.Add(Me.pnl1_sales)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1291, 643)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnl2_sales
        '
        Me.pnl2_sales.Controls.Add(Me.Label15)
        Me.pnl2_sales.Controls.Add(Me.Label2)
        Me.pnl2_sales.Controls.Add(Me.btn_view_report)
        Me.pnl2_sales.Controls.Add(Me.lbl_change)
        Me.pnl2_sales.Controls.Add(Me.dtp_to)
        Me.pnl2_sales.Controls.Add(Me.Label14)
        Me.pnl2_sales.Controls.Add(Me.dtp_from)
        Me.pnl2_sales.Controls.Add(Me.Label12)
        Me.pnl2_sales.Controls.Add(Me.lbl_total)
        Me.pnl2_sales.Controls.Add(Me.fld_amount)
        Me.pnl2_sales.Controls.Add(Me.grd_order_list)
        Me.pnl2_sales.Controls.Add(Me.Label13)
        Me.pnl2_sales.Controls.Add(Me.btn_pay)
        Me.pnl2_sales.Location = New System.Drawing.Point(649, 6)
        Me.pnl2_sales.Name = "pnl2_sales"
        Me.pnl2_sales.Size = New System.Drawing.Size(636, 620)
        Me.pnl2_sales.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(32, 563)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From:"
        '
        'btn_view_report
        '
        Me.btn_view_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_view_report.Location = New System.Drawing.Point(452, 523)
        Me.btn_view_report.Name = "btn_view_report"
        Me.btn_view_report.Size = New System.Drawing.Size(167, 69)
        Me.btn_view_report.TabIndex = 3
        Me.btn_view_report.Text = "View Report"
        Me.btn_view_report.UseVisualStyleBackColor = True
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_change.Location = New System.Drawing.Point(150, 461)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(67, 31)
        Me.lbl_change.TabIndex = 11
        Me.lbl_change.Text = "0.00"
        '
        'dtp_to
        '
        Me.dtp_to.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_to.Location = New System.Drawing.Point(99, 563)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(259, 26)
        Me.dtp_to.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label14.Location = New System.Drawing.Point(11, 461)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 31)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Change:"
        '
        'dtp_from
        '
        Me.dtp_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_from.Location = New System.Drawing.Point(99, 520)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(259, 26)
        Me.dtp_from.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(13, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Amount:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_total.Location = New System.Drawing.Point(552, 393)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(67, 31)
        Me.lbl_total.TabIndex = 9
        Me.lbl_total.Text = "0.00"
        '
        'fld_amount
        '
        Me.fld_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_amount.Location = New System.Drawing.Point(99, 400)
        Me.fld_amount.Name = "fld_amount"
        Me.fld_amount.Size = New System.Drawing.Size(341, 26)
        Me.fld_amount.TabIndex = 6
        Me.fld_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grd_order_list
        '
        Me.grd_order_list.BackgroundColor = System.Drawing.Color.White
        Me.grd_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grd_order_list.Location = New System.Drawing.Point(17, 19)
        Me.grd_order_list.Name = "grd_order_list"
        Me.grd_order_list.ReadOnly = True
        Me.grd_order_list.Size = New System.Drawing.Size(602, 347)
        Me.grd_order_list.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label13.Location = New System.Drawing.Point(446, 393)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 31)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total:"
        '
        'btn_pay
        '
        Me.btn_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_pay.Location = New System.Drawing.Point(452, 442)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(167, 72)
        Me.btn_pay.TabIndex = 2
        Me.btn_pay.Text = "Pay"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'pnl1_sales
        '
        Me.pnl1_sales.Controls.Add(Me.fld_product_search)
        Me.pnl1_sales.Controls.Add(Me.Label1)
        Me.pnl1_sales.Controls.Add(Me.grd_product_list)
        Me.pnl1_sales.Location = New System.Drawing.Point(6, 6)
        Me.pnl1_sales.Name = "pnl1_sales"
        Me.pnl1_sales.Size = New System.Drawing.Size(637, 620)
        Me.pnl1_sales.TabIndex = 0
        '
        'fld_product_search
        '
        Me.fld_product_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_product_search.Location = New System.Drawing.Point(116, 19)
        Me.fld_product_search.Name = "fld_product_search"
        Me.fld_product_search.Size = New System.Drawing.Size(507, 26)
        Me.fld_product_search.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product: "
        '
        'grd_product_list
        '
        Me.grd_product_list.AllowUserToAddRows = False
        Me.grd_product_list.AllowUserToDeleteRows = False
        Me.grd_product_list.AllowUserToResizeColumns = False
        Me.grd_product_list.AllowUserToResizeRows = False
        Me.grd_product_list.BackgroundColor = System.Drawing.Color.White
        Me.grd_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product_list.Location = New System.Drawing.Point(14, 61)
        Me.grd_product_list.Name = "grd_product_list"
        Me.grd_product_list.ReadOnly = True
        Me.grd_product_list.ShowEditingIcon = False
        Me.grd_product_list.Size = New System.Drawing.Size(609, 542)
        Me.grd_product_list.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1291, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inventory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_graph)
        Me.Panel2.Controls.Add(Me.grd_inventory)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.fld_invetory_search)
        Me.Panel2.Location = New System.Drawing.Point(461, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 616)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Orange
        Me.Panel4.Location = New System.Drawing.Point(158, 581)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(27, 20)
        Me.Panel4.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(51, 581)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 20)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "High"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.Location = New System.Drawing.Point(21, 581)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 20)
        Me.Panel3.TabIndex = 18
        '
        'btn_graph
        '
        Me.btn_graph.Location = New System.Drawing.Point(697, 540)
        Me.btn_graph.Name = "btn_graph"
        Me.btn_graph.Size = New System.Drawing.Size(112, 29)
        Me.btn_graph.TabIndex = 16
        Me.btn_graph.Text = "View Graph"
        Me.btn_graph.UseVisualStyleBackColor = True
        Me.btn_graph.Visible = False
        '
        'grd_inventory
        '
        Me.grd_inventory.BackgroundColor = System.Drawing.Color.White
        Me.grd_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_inventory.GridColor = System.Drawing.SystemColors.Control
        Me.grd_inventory.Location = New System.Drawing.Point(21, 137)
        Me.grd_inventory.Margin = New System.Windows.Forms.Padding(0)
        Me.grd_inventory.Name = "grd_inventory"
        Me.grd_inventory.ReadOnly = True
        Me.grd_inventory.Size = New System.Drawing.Size(788, 377)
        Me.grd_inventory.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 31)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Product Review:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(17, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Product Search:"
        '
        'fld_invetory_search
        '
        Me.fld_invetory_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_invetory_search.Location = New System.Drawing.Point(146, 96)
        Me.fld_invetory_search.Name = "fld_invetory_search"
        Me.fld_invetory_search.Size = New System.Drawing.Size(663, 26)
        Me.fld_invetory_search.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.fld_price)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.fld_product_id)
        Me.Panel1.Controls.Add(Me.fld_inventory_id)
        Me.Panel1.Controls.Add(Me.fld_quantity)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmd_cat)
        Me.Panel1.Controls.Add(Me.fld_model)
        Me.Panel1.Controls.Add(Me.fld_brand)
        Me.Panel1.Controls.Add(Me.fld_code)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.fld_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 616)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button1.Location = New System.Drawing.Point(15, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 36)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Advance Management"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(341, 428)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 29)
        Me.btn_clear.TabIndex = 20
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'fld_price
        '
        Me.fld_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_price.Location = New System.Drawing.Point(155, 155)
        Me.fld_price.Name = "fld_price"
        Me.fld_price.Size = New System.Drawing.Size(261, 26)
        Me.fld_price.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(19, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 20)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Product Price :"
        '
        'fld_product_id
        '
        Me.fld_product_id.Location = New System.Drawing.Point(155, 470)
        Me.fld_product_id.Name = "fld_product_id"
        Me.fld_product_id.Size = New System.Drawing.Size(100, 26)
        Me.fld_product_id.TabIndex = 17
        Me.fld_product_id.Visible = False
        '
        'fld_inventory_id
        '
        Me.fld_inventory_id.Location = New System.Drawing.Point(155, 431)
        Me.fld_inventory_id.Name = "fld_inventory_id"
        Me.fld_inventory_id.Size = New System.Drawing.Size(100, 26)
        Me.fld_inventory_id.TabIndex = 16
        Me.fld_inventory_id.Visible = False
        '
        'fld_quantity
        '
        Me.fld_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_quantity.Location = New System.Drawing.Point(155, 383)
        Me.fld_quantity.Name = "fld_quantity"
        Me.fld_quantity.Size = New System.Drawing.Size(261, 26)
        Me.fld_quantity.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(63, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Quntity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 31)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Product Management:"
        '
        'cmd_cat
        '
        Me.cmd_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_cat.FormattingEnabled = True
        Me.cmd_cat.Items.AddRange(New Object() {"Accessories", "Mobile", "Tablet"})
        Me.cmd_cat.Location = New System.Drawing.Point(155, 333)
        Me.cmd_cat.Name = "cmd_cat"
        Me.cmd_cat.Size = New System.Drawing.Size(261, 28)
        Me.cmd_cat.TabIndex = 12
        '
        'fld_model
        '
        Me.fld_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_model.Location = New System.Drawing.Point(155, 285)
        Me.fld_model.Name = "fld_model"
        Me.fld_model.Size = New System.Drawing.Size(261, 26)
        Me.fld_model.TabIndex = 11
        '
        'fld_brand
        '
        Me.fld_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_brand.Location = New System.Drawing.Point(155, 241)
        Me.fld_brand.Name = "fld_brand"
        Me.fld_brand.Size = New System.Drawing.Size(261, 26)
        Me.fld_brand.TabIndex = 10
        '
        'fld_code
        '
        Me.fld_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_code.Location = New System.Drawing.Point(155, 199)
        Me.fld_code.Name = "fld_code"
        Me.fld_code.Size = New System.Drawing.Size(261, 26)
        Me.fld_code.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(49, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(11, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Product Model:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(11, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product Brand:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Code:"
        '
        'fld_name
        '
        Me.fld_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_name.Location = New System.Drawing.Point(155, 115)
        Me.fld_name.Name = "fld_name"
        Me.fld_name.Size = New System.Drawing.Size(261, 26)
        Me.fld_name.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Name:"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(180, 533)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 36)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(263, 533)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 36)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(355, 533)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 36)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(188, 582)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 20)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Mid"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(289, 582)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(27, 20)
        Me.Panel5.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(319, 583)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Low"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 545)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 20)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Stock Indicator "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GroupA_Project.My.Resources.Resource1.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(642, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 63)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 791)
        Me.Controls.Add(Me.main_container)
        Me.Name = "Dashboard"
        Me.Text = "Admin"
        Me.main_container.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnl2_sales.ResumeLayout(False)
        Me.pnl2_sales.PerformLayout()
        CType(Me.grd_order_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1_sales.ResumeLayout(False)
        Me.pnl1_sales.PerformLayout()
        CType(Me.grd_product_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grd_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents main_container As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnl2_sales As Panel
    Friend WithEvents btn_view_report As Button
    Friend WithEvents dtp_to As DateTimePicker
    Friend WithEvents dtp_from As DateTimePicker
    Friend WithEvents grd_order_list As DataGridView
    Friend WithEvents pnl1_sales As Panel
    Friend WithEvents btn_pay As Button
    Friend WithEvents grd_product_list As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmd_cat As ComboBox
    Friend WithEvents fld_model As TextBox
    Friend WithEvents fld_brand As TextBox
    Friend WithEvents fld_code As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fld_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fld_quantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents fld_invetory_search As TextBox
    Friend WithEvents grd_inventory As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_graph As Button
    Friend WithEvents fld_amount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_change As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents fld_inventory_id As TextBox
    Friend WithEvents fld_product_id As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents fld_price As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents fld_product_search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
