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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABOUT_US_PAGE))
        Me.Return_Main_Menu_AboutUs_Button = New System.Windows.Forms.Button()
        Me.About_Us_return_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Return_Main_Menu_AboutUs_Button
        '
        Me.Return_Main_Menu_AboutUs_Button.Font = New System.Drawing.Font("Impact", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Return_Main_Menu_AboutUs_Button.Location = New System.Drawing.Point(58, 40)
        Me.Return_Main_Menu_AboutUs_Button.Name = "Return_Main_Menu_AboutUs_Button"
        Me.Return_Main_Menu_AboutUs_Button.Size = New System.Drawing.Size(94, 29)
        Me.Return_Main_Menu_AboutUs_Button.TabIndex = 0
        Me.Return_Main_Menu_AboutUs_Button.Text = "Enter"
        Me.Return_Main_Menu_AboutUs_Button.UseVisualStyleBackColor = True
        '
        'About_Us_return_Label
        '
        Me.About_Us_return_Label.AutoSize = True
        Me.About_Us_return_Label.Font = New System.Drawing.Font("Impact", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.About_Us_return_Label.Location = New System.Drawing.Point(12, 9)
        Me.About_Us_return_Label.Name = "About_Us_return_Label"
        Me.About_Us_return_Label.Size = New System.Drawing.Size(239, 28)
        Me.About_Us_return_Label.TabIndex = 1
        Me.About_Us_return_Label.Text = "Return to the Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(176, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "We are a local computer parts supplier that offers " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     competitive prices agai" &
    "nst our competitors."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(109, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ABOUT_US_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.About_Us_return_Label)
        Me.Controls.Add(Me.Return_Main_Menu_AboutUs_Button)
        Me.Name = "ABOUT_US_PAGE"
        Me.Text = "About Us Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Return_Main_Menu_AboutUs_Button As Button
    Friend WithEvents About_Us_return_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
