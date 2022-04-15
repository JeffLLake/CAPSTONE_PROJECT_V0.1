<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CART_PAGE
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
        Me.Return_Product_Page_Label = New System.Windows.Forms.Label()
        Me.Return_Product_Page_Button = New System.Windows.Forms.Button()
        Me.Total_Label = New System.Windows.Forms.Label()
        Me.Total_Amount_Label = New System.Windows.Forms.Label()
        Me.Proceed_Checkout_Label = New System.Windows.Forms.Label()
        Me.Proceed_Checkout_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Return_Product_Page_Label
        '
        Me.Return_Product_Page_Label.AutoSize = True
        Me.Return_Product_Page_Label.Location = New System.Drawing.Point(12, 9)
        Me.Return_Product_Page_Label.Name = "Return_Product_Page_Label"
        Me.Return_Product_Page_Label.Size = New System.Drawing.Size(165, 20)
        Me.Return_Product_Page_Label.TabIndex = 0
        Me.Return_Product_Page_Label.Text = "Return to Product Page"
        '
        'Return_Product_Page_Button
        '
        Me.Return_Product_Page_Button.Location = New System.Drawing.Point(12, 32)
        Me.Return_Product_Page_Button.Name = "Return_Product_Page_Button"
        Me.Return_Product_Page_Button.Size = New System.Drawing.Size(94, 29)
        Me.Return_Product_Page_Button.TabIndex = 1
        Me.Return_Product_Page_Button.Text = "Enter"
        Me.Return_Product_Page_Button.UseVisualStyleBackColor = True
        '
        'Total_Label
        '
        Me.Total_Label.AutoSize = True
        Me.Total_Label.Location = New System.Drawing.Point(273, 163)
        Me.Total_Label.Name = "Total_Label"
        Me.Total_Label.Size = New System.Drawing.Size(51, 20)
        Me.Total_Label.TabIndex = 2
        Me.Total_Label.Text = "Total :"
        '
        'Total_Amount_Label
        '
        Me.Total_Amount_Label.AutoSize = True
        Me.Total_Amount_Label.Location = New System.Drawing.Point(343, 163)
        Me.Total_Amount_Label.Name = "Total_Amount_Label"
        Me.Total_Amount_Label.Size = New System.Drawing.Size(37, 20)
        Me.Total_Amount_Label.TabIndex = 3
        Me.Total_Amount_Label.Text = "0.00"
        '
        'Proceed_Checkout_Label
        '
        Me.Proceed_Checkout_Label.AutoSize = True
        Me.Proceed_Checkout_Label.Location = New System.Drawing.Point(318, 213)
        Me.Proceed_Checkout_Label.Name = "Proceed_Checkout_Label"
        Me.Proceed_Checkout_Label.Size = New System.Drawing.Size(147, 20)
        Me.Proceed_Checkout_Label.TabIndex = 4
        Me.Proceed_Checkout_Label.Text = "Proceed to Checkout"
        '
        'Proceed_Checkout_Button
        '
        Me.Proceed_Checkout_Button.Location = New System.Drawing.Point(343, 249)
        Me.Proceed_Checkout_Button.Name = "Proceed_Checkout_Button"
        Me.Proceed_Checkout_Button.Size = New System.Drawing.Size(94, 29)
        Me.Proceed_Checkout_Button.TabIndex = 5
        Me.Proceed_Checkout_Button.Text = "Enter"
        Me.Proceed_Checkout_Button.UseVisualStyleBackColor = True
        '
        'CART_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Proceed_Checkout_Button)
        Me.Controls.Add(Me.Proceed_Checkout_Label)
        Me.Controls.Add(Me.Total_Amount_Label)
        Me.Controls.Add(Me.Total_Label)
        Me.Controls.Add(Me.Return_Product_Page_Button)
        Me.Controls.Add(Me.Return_Product_Page_Label)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "CART_PAGE"
        Me.Text = "Cart Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Return_Product_Page_Label As Label
    Friend WithEvents Return_Product_Page_Button As Button
    Friend WithEvents Total_Label As Label
    Friend WithEvents Total_Amount_Label As Label
    Friend WithEvents Proceed_Checkout_Label As Label
    Friend WithEvents Proceed_Checkout_Button As Button
End Class
