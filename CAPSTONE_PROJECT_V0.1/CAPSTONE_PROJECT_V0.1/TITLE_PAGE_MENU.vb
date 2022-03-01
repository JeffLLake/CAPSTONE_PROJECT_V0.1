Public Class TITLE_PAGE_MENU

    Private Sub TITLE_PAGE_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Products_Page_Button_Click(sender As Object, e As EventArgs) Handles Products_Page_Button.Click
        Dim zone As New PRODUCTS_PAGE
        Hide()
        zone.ShowDialog()
    End Sub

    Private Sub About_Us_Page_Button_Click(sender As Object, e As EventArgs) Handles About_Us_Page_Button.Click
        Dim zone As New ABOUT_US_PAGE
        Hide()
        zone.ShowDialog()
    End Sub
End Class
