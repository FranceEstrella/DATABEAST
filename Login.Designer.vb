<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(248, 202)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(342, 35)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(248, 259)
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt2.Size = New System.Drawing.Size(342, 35)
        Me.txt2.TabIndex = 1
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.Location = New System.Drawing.Point(346, 332)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(148, 50)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = " "
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 441)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Text = "DataBeast"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btnlogin As Button
End Class
