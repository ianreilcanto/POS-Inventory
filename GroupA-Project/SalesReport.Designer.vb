<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReport
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_total_sales = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_toDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fromDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_sales_report = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_sales_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_total_sales)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_toDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_fromDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.grd_sales_report)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1309, 618)
        Me.Panel1.TabIndex = 0
        '
        'lbl_total_sales
        '
        Me.lbl_total_sales.AutoSize = True
        Me.lbl_total_sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_total_sales.Location = New System.Drawing.Point(146, 561)
        Me.lbl_total_sales.Name = "lbl_total_sales"
        Me.lbl_total_sales.Size = New System.Drawing.Size(45, 24)
        Me.lbl_total_sales.TabIndex = 6
        Me.lbl_total_sales.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 561)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Sales : "
        '
        'lbl_toDate
        '
        Me.lbl_toDate.AutoSize = True
        Me.lbl_toDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_toDate.Location = New System.Drawing.Point(350, 27)
        Me.lbl_toDate.Name = "lbl_toDate"
        Me.lbl_toDate.Size = New System.Drawing.Size(68, 24)
        Me.lbl_toDate.TabIndex = 4
        Me.lbl_toDate.Text = "Date to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(319, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "to"
        '
        'lbl_fromDate
        '
        Me.lbl_fromDate.AutoSize = True
        Me.lbl_fromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_fromDate.Location = New System.Drawing.Point(186, 27)
        Me.lbl_fromDate.Name = "lbl_fromDate"
        Me.lbl_fromDate.Size = New System.Drawing.Size(98, 24)
        Me.lbl_fromDate.TabIndex = 2
        Me.lbl_fromDate.Text = "Date From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales Report as of"
        '
        'grd_sales_report
        '
        Me.grd_sales_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_sales_report.Location = New System.Drawing.Point(13, 63)
        Me.grd_sales_report.Name = "grd_sales_report"
        Me.grd_sales_report.Size = New System.Drawing.Size(1281, 458)
        Me.grd_sales_report.TabIndex = 0
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 642)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_sales_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grd_sales_report As DataGridView
    Friend WithEvents lbl_toDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_fromDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_total_sales As Label
    Friend WithEvents Label3 As Label
End Class
