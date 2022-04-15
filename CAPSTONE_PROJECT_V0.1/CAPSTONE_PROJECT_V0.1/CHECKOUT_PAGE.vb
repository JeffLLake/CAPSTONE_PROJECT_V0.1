Public Class CHECKOUT_PAGE
    Private fileLocation As String = "C:\Users\jeffl\source\repos\CAPSTONE_PROJECT_V0.1\datafile.txt"
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lastname_label.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Security_Code_Label.Click

    End Sub

    Private Sub Return_to_Product_Page_button_Click(sender As Object, e As EventArgs) Handles Return_to_Product_Page_button.Click
        Dim zone As New PRODUCTS_PAGE

        Hide()
        zone.ShowDialog()
    End Sub

    Private Sub PayNow_Button_Click(sender As Object, e As EventArgs) Handles PayNow_Button.Click
        Dim fileWriter As System.IO.StreamWriter
        Dim firstname As String = firstname_textbox.Text.ToString()
        Dim lastname As String = lastname_textbox.Text.ToString()
        Dim email As String = email_textbox.Text.ToString()
        Dim address As String = address_textbox.Text.ToString()
        Dim creditcard As String = cardNumber_textbox.Text.ToString()
        Dim securityCode As String = SecurityCode_textbox.Text.ToString()

        IO.File.Exists(fileLocation)
        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(fileLocation, True)
        fileWriter.Write("; ")
        fileWriter.Write(firstname)
        fileWriter.Write("; ")
        fileWriter.Write(lastname)
        fileWriter.Write("; ")
        fileWriter.Write(email)
        fileWriter.Write("; ")
        fileWriter.Write(address)
        fileWriter.Write("; ")
        fileWriter.Write(creditcard)
        fileWriter.Write("; ")
        fileWriter.Write(securityCode)
        fileWriter.WriteLine()
        fileWriter.Close()


    End Sub
End Class