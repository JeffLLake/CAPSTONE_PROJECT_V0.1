Public Class CART_PAGE

    Private Sub Return_Product_Page_Button_Click(sender As Object, e As EventArgs) Handles Return_Product_Page_Button.Click
        Dim zone As New PRODUCTS_PAGE

        Hide()
        zone.ShowDialog()
    End Sub

    Private Sub CART_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Total_Amount_Label.Text = PRODUCTS_PAGE.Total_Test_Label.Text
        'Total_Amount_Label.Text = products.Total_Test_Label.Refresh()

        'Total_Amount_Label.Text = "Total Is: " & (PRODUCTS_PAGE.Total_Test_Label.Text.show())
        'PRODUCTS_PAGE.ComputeCosts1()
        'Total_Amount_Label.Text = "Total Is: " & (PRODUCTS_PAGE.finalComputeCost.ToString("C2")) & " Total is: " & (PRODUCTS_PAGE.Total_Test_Label.Text)

    End Sub

    Private Sub Proceed_Checkout_Button_Click(sender As Object, e As EventArgs) Handles Proceed_Checkout_Button.Click


    End Sub

    Public Sub Total_Amount_Label_Click(sender As Object, e As EventArgs)



    End Sub
End Class