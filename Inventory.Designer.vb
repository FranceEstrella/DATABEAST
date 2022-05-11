<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.btnback2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnback2
        '
        Me.btnback2.BackgroundImage = CType(resources.GetObject("btnback2.BackgroundImage"), System.Drawing.Image)
        Me.btnback2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback2.FlatAppearance.BorderSize = 0
        Me.btnback2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback2.Location = New System.Drawing.Point(40, 40)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(39, 37)
        Me.btnback2.TabIndex = 0
        Me.btnback2.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 446)
        Me.Controls.Add(Me.btnback2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBeast"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnback2 As Button
End Class
