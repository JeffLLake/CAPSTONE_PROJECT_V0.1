<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABOUT_US_PAGE
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
        Me.Return_Main_Menu_AboutUs_Button = New System.Windows.Forms.Button()
        Me.About_Us_return_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Return_Main_Menu_AboutUs_Button
        '
        Me.Return_Main_Menu_AboutUs_Button.Location = New System.Drawing.Point(12, 32)
        Me.Return_Main_Menu_AboutUs_Button.Name = "Return_Main_Menu_AboutUs_Button"
        Me.Return_Main_Menu_AboutUs_Button.Size = New System.Drawing.Size(94, 29)
        Me.Return_Main_Menu_AboutUs_Button.TabIndex = 0
        Me.Return_Main_Menu_AboutUs_Button.Text = "Enter"
        Me.Return_Main_Menu_AboutUs_Button.UseVisualStyleBackColor = True
        '
        'About_Us_return_Label
        '
        Me.About_Us_return_Label.AutoSize = True
        Me.About_Us_return_Label.Location = New System.Drawing.Point(12, 9)
        Me.About_Us_return_Label.Name = "About_Us_return_Label"
        Me.About_Us_return_Label.Size = New System.Drawing.Size(173, 20)
        Me.About_Us_return_Label.TabIndex = 1
        Me.About_Us_return_Label.Text = "Return to the Main Menu"
        '
        'ABOUT_US_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.About_Us_return_Label)
        Me.Controls.Add(Me.Return_Main_Menu_AboutUs_Button)
        Me.Name = "ABOUT_US_PAGE"
        Me.Text = "About Us Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Return_Main_Menu_AboutUs_Button As Button
    Friend WithEvents About_Us_return_Label As Label
End Class
