'This is the about us page it only contains text
Public Class ABOUT_US_PAGE
    'Returns you to the title page
    Private Sub Return_Main_Menu_AboutUs_Button_Click(sender As Object, e As EventArgs) Handles Return_Main_Menu_AboutUs_Button.Click
        Dim zone As New TITLE_PAGE_MENU

        Hide()
        zone.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ABOUT_US_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class