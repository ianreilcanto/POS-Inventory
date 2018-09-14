<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.fld_quantity = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.fld_search_product = New System.Windows.Forms.TextBox()
        Me.txt_remarks = New System.Windows.Forms.RichTextBox()
        Me.cmd_category = New System.Windows.Forms.ComboBox()
        Me.grd_productList = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fld_search = New System.Windows.Forms.TextBox()
        Me.grd_inventory_ex = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_productList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.grd_inventory_ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_qty)
        Me.Panel1.Controls.Add(Me.fld_quantity)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.fld_search_product)
        Me.Panel1.Controls.Add(Me.txt_remarks)
        Me.Panel1.Controls.Add(Me.cmd_category)
        Me.Panel1.Controls.Add(Me.grd_productList)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 626)
        Me.Panel1.TabIndex = 0
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_qty.Location = New System.Drawing.Point(386, 38)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(76, 20)
        Me.lbl_qty.TabIndex = 8
        Me.lbl_qty.Text = "Quantity :"
        '
        'fld_quantity
        '
        Me.fld_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_quantity.Location = New System.Drawing.Point(477, 32)
        Me.fld_quantity.Name = "fld_quantity"
        Me.fld_quantity.Size = New System.Drawing.Size(135, 26)
        Me.fld_quantity.TabIndex = 7
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_add.Location = New System.Drawing.Point(413, 577)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(199, 31)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'fld_search_product
        '
        Me.fld_search_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_search_product.Location = New System.Drawing.Point(13, 32)
        Me.fld_search_product.Name = "fld_search_product"
        Me.fld_search_product.Size = New System.Drawing.Size(330, 26)
        Me.fld_search_product.TabIndex = 3
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_remarks.Location = New System.Drawing.Point(13, 540)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(367, 68)
        Me.txt_remarks.TabIndex = 2
        Me.txt_remarks.Text = ""
        '
        'cmd_category
        '
        Me.cmd_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmd_category.FormattingEnabled = True
        Me.cmd_category.Items.AddRange(New Object() {"Returned", "Obsolete", "Defective", "Freebies"})
        Me.cmd_category.Location = New System.Drawing.Point(413, 540)
        Me.cmd_category.Name = "cmd_category"
        Me.cmd_category.Size = New System.Drawing.Size(199, 28)
        Me.cmd_category.TabIndex = 1
        '
        'grd_productList
        '
        Me.grd_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productList.Location = New System.Drawing.Point(13, 70)
        Me.grd_productList.Name = "grd_productList"
        Me.grd_productList.Size = New System.Drawing.Size(599, 429)
        Me.grd_productList.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.fld_search)
        Me.Panel2.Controls.Add(Me.grd_inventory_ex)
        Me.Panel2.Location = New System.Drawing.Point(680, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(677, 626)
        Me.Panel2.TabIndex = 1
        '
        'fld_search
        '
        Me.fld_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fld_search.Location = New System.Drawing.Point(16, 32)
        Me.fld_search.Name = "fld_search"
        Me.fld_search.Size = New System.Drawing.Size(643, 26)
        Me.fld_search.TabIndex = 8
        '
        'grd_inventory_ex
        '
        Me.grd_inventory_ex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_inventory_ex.Location = New System.Drawing.Point(16, 70)
        Me.grd_inventory_ex.Name = "grd_inventory_ex"
        Me.grd_inventory_ex.Size = New System.Drawing.Size(643, 538)
        Me.grd_inventory_ex.TabIndex = 8
        '
        'AdvanceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 676)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdvanceManagement"
        Me.Text = "AdvanceManagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_productList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grd_inventory_ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents fld_quantity As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents fld_search_product As TextBox
    Friend WithEvents txt_remarks As RichTextBox
    Friend WithEvents cmd_category As ComboBox
    Friend WithEvents grd_productList As DataGridView
    Friend WithEvents lbl_qty As Label
    Friend WithEvents fld_search As TextBox
    Friend WithEvents grd_inventory_ex As DataGridView
End Class
