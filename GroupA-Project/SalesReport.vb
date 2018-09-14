Imports System.Globalization

Public Class SalesReport

    Private _sales As List(Of Sales)
    Private _fromDate As Date
    Private _toDate As Date

    Public Sub New(sales As List(Of Sales), fromDate As Date, toDate As Date)

        InitializeComponent()


        _sales = sales
        _fromDate = fromDate
        _toDate = toDate

    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim total As Double

        grd_sales_report.DataSource = _sales
        grd_sales_report.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        lbl_fromDate.Text = GetMonthName(_fromDate) & " " & _fromDate.Day & ", " & _fromDate.Year
        lbl_toDate.Text = GetMonthName(_toDate) & " " & _toDate.Day & ", " & _toDate.Year

        For Each sale In _sales

            total += sale.Total
        Next

        lbl_total_sales.Text = "₱ " & total.ToString("N", CultureInfo.InvariantCulture)

    End Sub

    Public Function GetMonthName(dat As Date) As String

        Dim iMonth As Integer = Month(dat)
        GetMonthName = MonthName(iMonth)

    End Function

    Private Sub grd_sales_report_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grd_sales_report.RowEnter

        grd_sales_report.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        grd_sales_report.Rows(e.RowIndex).Selected = True
    End Sub

End Class