<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHECKOUT_PAGE
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
        Me.firstname_label = New System.Windows.Forms.Label()
        Me.lastname_label = New System.Windows.Forms.Label()
        Me.email_label = New System.Windows.Forms.Label()
        Me.address_label = New System.Windows.Forms.Label()
        Me.firstname_textbox = New System.Windows.Forms.TextBox()
        Me.lastname_textbox = New System.Windows.Forms.TextBox()
        Me.email_textbox = New System.Windows.Forms.TextBox()
        Me.address_textbox = New System.Windows.Forms.TextBox()
        Me.Cardnumber_label = New System.Windows.Forms.Label()
        Me.cardNumber_textbox = New System.Windows.Forms.TextBox()
        Me.SecurityCode_textbox = New System.Windows.Forms.TextBox()
        Me.Security_Code_Label = New System.Windows.Forms.Label()
        Me.PayNow_Button = New System.Windows.Forms.Button()
        Me.Return_to_Product_Page_button = New System.Windows.Forms.Button()
        Me.pay_now_label = New System.Windows.Forms.Label()
        Me.return_to_product_page_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstname_label
        '
        Me.firstname_label.AutoSize = True
        Me.firstname_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.firstname_label.Location = New System.Drawing.Point(173, 126)
        Me.firstname_label.Name = "firstname_label"
        Me.firstname_label.Size = New System.Drawing.Size(75, 19)
        Me.firstname_label.TabIndex = 0
        Me.firstname_label.Text = "First name"
        '
        'lastname_label
        '
        Me.lastname_label.AutoSize = True
        Me.lastname_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lastname_label.Location = New System.Drawing.Point(395, 136)
        Me.lastname_label.Name = "lastname_label"
        Me.lastname_label.Size = New System.Drawing.Size(74, 19)
        Me.lastname_label.TabIndex = 1
        Me.lastname_label.Text = "Last name"
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_label.Location = New System.Drawing.Point(173, 239)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(43, 19)
        Me.email_label.TabIndex = 2
        Me.email_label.Text = "Email"
        '
        'address_label
        '
        Me.address_label.AutoSize = True
        Me.address_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.address_label.Location = New System.Drawing.Point(395, 239)
        Me.address_label.Name = "address_label"
        Me.address_label.Size = New System.Drawing.Size(60, 19)
        Me.address_label.TabIndex = 3
        Me.address_label.Text = "address"
        '
        'firstname_textbox
        '
        Me.firstname_textbox.Location = New System.Drawing.Point(173, 170)
        Me.firstname_textbox.Name = "firstname_textbox"
        Me.firstname_textbox.Size = New System.Drawing.Size(110, 26)
        Me.firstname_textbox.TabIndex = 4
        '
        'lastname_textbox
        '
        Me.lastname_textbox.Location = New System.Drawing.Point(395, 170)
        Me.lastname_textbox.Name = "lastname_textbox"
        Me.lastname_textbox.Size = New System.Drawing.Size(110, 26)
        Me.lastname_textbox.TabIndex = 5
        '
        'email_textbox
        '
        Me.email_textbox.Location = New System.Drawing.Point(173, 277)
        Me.email_textbox.Name = "email_textbox"
        Me.email_textbox.Size = New System.Drawing.Size(110, 26)
        Me.email_textbox.TabIndex = 6
        '
        'address_textbox
        '
        Me.address_textbox.Location = New System.Drawing.Point(395, 277)
        Me.address_textbox.Name = "address_textbox"
        Me.address_textbox.Size = New System.Drawing.Size(110, 26)
        Me.address_textbox.TabIndex = 7
        '
        'Cardnumber_label
        '
        Me.Cardnumber_label.AutoSize = True
        Me.Cardnumber_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cardnumber_label.Location = New System.Drawing.Point(173, 332)
        Me.Cardnumber_label.Name = "Cardnumber_label"
        Me.Cardnumber_label.Size = New System.Drawing.Size(90, 19)
        Me.Cardnumber_label.TabIndex = 8
        Me.Cardnumber_label.Text = "Card number"
        '
        'cardNumber_textbox
        '
        Me.cardNumber_textbox.Location = New System.Drawing.Point(173, 362)
        Me.cardNumber_textbox.MaxLength = 16
        Me.cardNumber_textbox.Name = "cardNumber_textbox"
        Me.cardNumber_textbox.Size = New System.Drawing.Size(110, 26)
        Me.cardNumber_textbox.TabIndex = 9
        '
        'SecurityCode_textbox
        '
        Me.SecurityCode_textbox.Location = New System.Drawing.Point(395, 362)
        Me.SecurityCode_textbox.MaxLength = 3
        Me.SecurityCode_textbox.Name = "SecurityCode_textbox"
        Me.SecurityCode_textbox.Size = New System.Drawing.Size(110, 26)
        Me.SecurityCode_textbox.TabIndex = 10
        '
        'Security_Code_Label
        '
        Me.Security_Code_Label.AutoSize = True
        Me.Security_Code_Label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Security_Code_Label.Location = New System.Drawing.Point(395, 332)
        Me.Security_Code_Label.Name = "Security_Code_Label"
        Me.Security_Code_Label.Size = New System.Drawing.Size(96, 19)
        Me.Security_Code_Label.TabIndex = 11
        Me.Security_Code_Label.Text = "Security Code"
        '
        'PayNow_Button
        '
        Me.PayNow_Button.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PayNow_Button.Location = New System.Drawing.Point(296, 476)
        Me.PayNow_Button.Name = "PayNow_Button"
        Me.PayNow_Button.Size = New System.Drawing.Size(82, 28)
        Me.PayNow_Button.TabIndex = 12
        Me.PayNow_Button.Text = "Enter"
        Me.PayNow_Button.UseVisualStyleBackColor = True
        '
        'Return_to_Product_Page_button
        '
        Me.Return_to_Product_Page_button.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Return_to_Product_Page_button.Location = New System.Drawing.Point(30, 39)
        Me.Return_to_Product_Page_button.Name = "Return_to_Product_Page_button"
        Me.Return_to_Product_Page_button.Size = New System.Drawing.Size(82, 28)
        Me.Return_to_Product_Page_button.TabIndex = 13
        Me.Return_to_Product_Page_button.Text = "Enter"
        Me.Return_to_Product_Page_button.UseVisualStyleBackColor = True
        '
        'pay_now_label
        '
        Me.pay_now_label.AutoSize = True
        Me.pay_now_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pay_now_label.Location = New System.Drawing.Point(309, 438)
        Me.pay_now_label.Name = "pay_now_label"
        Me.pay_now_label.Size = New System.Drawing.Size(62, 19)
        Me.pay_now_label.TabIndex = 14
        Me.pay_now_label.Text = "Pay now"
        '
        'return_to_product_page_label
        '
        Me.return_to_product_page_label.AutoSize = True
        Me.return_to_product_page_label.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.return_to_product_page_label.Location = New System.Drawing.Point(4, 5)
        Me.return_to_product_page_label.Name = "return_to_product_page_label"
        Me.return_to_product_page_label.Size = New System.Drawing.Size(154, 19)
        Me.return_to_product_page_label.TabIndex = 15
        Me.return_to_product_page_label.Text = "Return to product page"
        '
        'CHECKOUT_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(700, 559)
        Me.Controls.Add(Me.return_to_product_page_label)
        Me.Controls.Add(Me.pay_now_label)
        Me.Controls.Add(Me.Return_to_Product_Page_button)
        Me.Controls.Add(Me.PayNow_Button)
        Me.Controls.Add(Me.Security_Code_Label)
        Me.Controls.Add(Me.SecurityCode_textbox)
        Me.Controls.Add(Me.cardNumber_textbox)
        Me.Controls.Add(Me.Cardnumber_label)
        Me.Controls.Add(Me.address_textbox)
        Me.Controls.Add(Me.email_textbox)
        Me.Controls.Add(Me.lastname_textbox)
        Me.Controls.Add(Me.firstname_textbox)
        Me.Controls.Add(Me.address_label)
        Me.Controls.Add(Me.email_label)
        Me.Controls.Add(Me.lastname_label)
        Me.Controls.Add(Me.firstname_label)
        Me.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "CHECKOUT_PAGE"
        Me.Text = "Checkout Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstname_label As Label
    Friend WithEvents lastname_label As Label
    Friend WithEvents email_label As Label
    Friend WithEvents address_label As Label
    Friend WithEvents firstname_textbox As TextBox
    Friend WithEvents lastname_textbox As TextBox
    Friend WithEvents email_textbox As TextBox
    Friend WithEvents address_textbox As TextBox
    Friend WithEvents Cardnumber_label As Label
    Friend WithEvents cardNumber_textbox As TextBox
    Friend WithEvents SecurityCode_textbox As TextBox
    Friend WithEvents Security_Code_Label As Label
    Friend WithEvents PayNow_Button As Button
    Friend WithEvents Return_to_Product_Page_button As Button
    Friend WithEvents pay_now_label As Label
    Friend WithEvents return_to_product_page_label As Label
End Class
