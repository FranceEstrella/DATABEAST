<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lvl1Menu
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
        Dim btnreceipt As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lvl1Menu))
        Me.btninventory = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        btnreceipt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnreceipt
        '
        resources.ApplyResources(btnreceipt, "btnreceipt")
        btnreceipt.Cursor = System.Windows.Forms.Cursors.Hand
        btnreceipt.FlatAppearance.BorderSize = 0
        btnreceipt.ForeColor = System.Drawing.Color.Transparent
        btnreceipt.Name = "btnreceipt"
        btnreceipt.UseVisualStyleBackColor = True
        AddHandler btnreceipt.Click, AddressOf Me.Button1_Click
        '
        'btninventory
        '
        resources.ApplyResources(Me.btninventory, "btninventory")
        Me.btninventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninventory.FlatAppearance.BorderSize = 0
        Me.btninventory.Name = "btninventory"
        Me.btninventory.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        resources.ApplyResources(Me.btnlogout, "btnlogout")
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Lvl1Menu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btninventory)
        Me.Controls.Add(btnreceipt)
        Me.Name = "Lvl1Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btninventory As Button
    Friend WithEvents btnlogout As Button
End Class
