Public Class ABOUT_US_PAGE
    Private Sub Return_Main_Menu_AboutUs_Button_Click(sender As Object, e As EventArgs) Handles Return_Main_Menu_AboutUs_Button.Click
        Dim zone As New TITLE_PAGE_MENU

        Hide()
        zone.ShowDialog()
    End Sub
End Class