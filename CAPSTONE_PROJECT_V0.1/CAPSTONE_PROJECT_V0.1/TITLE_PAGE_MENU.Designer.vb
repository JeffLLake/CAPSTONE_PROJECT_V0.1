<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TITLE_PAGE_MENU
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
        Me.Menu_Title_Label = New System.Windows.Forms.Label()
        Me.Products_Page_Label = New System.Windows.Forms.Label()
        Me.About_Us_Page_Label = New System.Windows.Forms.Label()
        Me.Products_Page_Picture = New System.Windows.Forms.PictureBox()
        Me.About_Us_Page_Picture = New System.Windows.Forms.PictureBox()
        Me.Products_Page_Button = New System.Windows.Forms.Button()
        Me.About_Us_Page_Button = New System.Windows.Forms.Button()
        CType(Me.Products_Page_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.About_Us_Page_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu_Title_Label
        '
        Me.Menu_Title_Label.AutoSize = True
        Me.Menu_Title_Label.Font = New System.Drawing.Font("Book Antiqua", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Menu_Title_Label.Location = New System.Drawing.Point(301, 50)
        Me.Menu_Title_Label.Name = "Menu_Title_Label"
        Me.Menu_Title_Label.Size = New System.Drawing.Size(198, 28)
        Me.Menu_Title_Label.TabIndex = 0
        Me.Menu_Title_Label.Text = "Title Place Holder"
        '
        'Products_Page_Label
        '
        Me.Products_Page_Label.AutoSize = True
        Me.Products_Page_Label.Location = New System.Drawing.Point(175, 156)
        Me.Products_Page_Label.Name = "Products_Page_Label"
        Me.Products_Page_Label.Size = New System.Drawing.Size(66, 20)
        Me.Products_Page_Label.TabIndex = 1
        Me.Products_Page_Label.Text = "Products"
        '
        'About_Us_Page_Label
        '
        Me.About_Us_Page_Label.AutoSize = True
        Me.About_Us_Page_Label.Location = New System.Drawing.Point(568, 156)
        Me.About_Us_Page_Label.Name = "About_Us_Page_Label"
        Me.About_Us_Page_Label.Size = New System.Drawing.Size(70, 20)
        Me.About_Us_Page_Label.TabIndex = 2
        Me.About_Us_Page_Label.Text = "About Us"
        '
        'Products_Page_Picture
        '
        Me.Products_Page_Picture.BackgroundImage = Global.CAPSTONE_PROJECT_V0._1.My.Resources.Resources.computer_parts
        Me.Products_Page_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Products_Page_Picture.Image = Global.CAPSTONE_PROJECT_V0._1.My.Resources.Resources.computer_parts
        Me.Products_Page_Picture.Location = New System.Drawing.Point(118, 179)
        Me.Products_Page_Picture.Name = "Products_Page_Picture"
        Me.Products_Page_Picture.Size = New System.Drawing.Size(207, 167)
        Me.Products_Page_Picture.TabIndex = 3
        Me.Products_Page_Picture.TabStop = False
        '
        'About_Us_Page_Picture
        '
        Me.About_Us_Page_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.About_Us_Page_Picture.Image = Global.CAPSTONE_PROJECT_V0._1.My.Resources.Resources.about_us
        Me.About_Us_Page_Picture.Location = New System.Drawing.Point(502, 179)
        Me.About_Us_Page_Picture.Name = "About_Us_Page_Picture"
        Me.About_Us_Page_Picture.Size = New System.Drawing.Size(204, 167)
        Me.About_Us_Page_Picture.TabIndex = 4
        Me.About_Us_Page_Picture.TabStop = False
        '
        'Products_Page_Button
        '
        Me.Products_Page_Button.Location = New System.Drawing.Point(161, 352)
        Me.Products_Page_Button.Name = "Products_Page_Button"
        Me.Products_Page_Button.Size = New System.Drawing.Size(94, 29)
        Me.Products_Page_Button.TabIndex = 5
        Me.Products_Page_Button.Text = "Products"
        Me.Products_Page_Button.UseVisualStyleBackColor = True
        '
        'About_Us_Page_Button
        '
        Me.About_Us_Page_Button.Image = Global.CAPSTONE_PROJECT_V0._1.My.Resources.Resources.computer_parts
        Me.About_Us_Page_Button.Location = New System.Drawing.Point(556, 352)
        Me.About_Us_Page_Button.Name = "About_Us_Page_Button"
        Me.About_Us_Page_Button.Size = New System.Drawing.Size(94, 29)
        Me.About_Us_Page_Button.TabIndex = 6
        Me.About_Us_Page_Button.Text = "About Us"
        Me.About_Us_Page_Button.UseVisualStyleBackColor = True
        '
        'TITLE_PAGE_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 603)
        Me.Controls.Add(Me.About_Us_Page_Button)
        Me.Controls.Add(Me.Products_Page_Button)
        Me.Controls.Add(Me.About_Us_Page_Picture)
        Me.Controls.Add(Me.Products_Page_Picture)
        Me.Controls.Add(Me.About_Us_Page_Label)
        Me.Controls.Add(Me.Products_Page_Label)
        Me.Controls.Add(Me.Menu_Title_Label)
        Me.Name = "TITLE_PAGE_MENU"
        Me.Text = "Title Page"
        CType(Me.Products_Page_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.About_Us_Page_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_Title_Label As Label
    Friend WithEvents Products_Page_Label As Label
    Friend WithEvents About_Us_Page_Label As Label
    Friend WithEvents Products_Page_Picture As PictureBox
    Friend WithEvents About_Us_Page_Picture As PictureBox
    Friend WithEvents Products_Page_Button As Button
    Friend WithEvents About_Us_Page_Button As Button
End Class
