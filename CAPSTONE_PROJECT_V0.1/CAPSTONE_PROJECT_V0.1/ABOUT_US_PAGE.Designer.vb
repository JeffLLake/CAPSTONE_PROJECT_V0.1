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
        Me.Return_Menu_Button = New System.Windows.Forms.Button()
        Me.Return_Menu_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Return_Menu_Button
        '
        Me.Return_Menu_Button.Location = New System.Drawing.Point(12, 32)
        Me.Return_Menu_Button.Name = "Return_Menu_Button"
        Me.Return_Menu_Button.Size = New System.Drawing.Size(111, 29)
        Me.Return_Menu_Button.TabIndex = 0
        Me.Return_Menu_Button.Text = "Enter"
        Me.Return_Menu_Button.UseVisualStyleBackColor = True
        '
        'Return_Menu_Label
        '
        Me.Return_Menu_Label.AutoSize = True
        Me.Return_Menu_Label.Location = New System.Drawing.Point(12, 9)
        Me.Return_Menu_Label.Name = "Return_Menu_Label"
        Me.Return_Menu_Label.Size = New System.Drawing.Size(111, 20)
        Me.Return_Menu_Label.TabIndex = 1
        Me.Return_Menu_Label.Text = "Return to Menu"
        '
        'ABOUT_US_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Return_Menu_Label)
        Me.Controls.Add(Me.Return_Menu_Button)
        Me.Name = "ABOUT_US_PAGE"
        Me.Text = "About Us Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Return_Menu_Button As Button
    Friend WithEvents Return_Menu_Label As Label
End Class
