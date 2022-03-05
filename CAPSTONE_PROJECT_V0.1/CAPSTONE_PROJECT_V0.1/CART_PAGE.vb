Public Class CART_PAGE
    Private Sub Return_Product_Page_Button_Click(sender As Object, e As EventArgs) Handles Return_Product_Page_Button.Click
        Dim zone As New PRODUCTS_PAGE

        Hide()
        zone.ShowDialog()
    End Sub

    Private Sub CART_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class