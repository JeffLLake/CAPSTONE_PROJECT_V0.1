Public Class ABOUT_US_PAGE
    Private Sub Return_Menu_Button_Click(sender As Object, e As EventArgs) Handles Return_Menu_Button.Click
        Dim ABOUT_US_PAGE As New TITLE_PAGE_MENU

        Hide()
        ABOUT_US_PAGE.ShowDialog()
    End Sub
End Class