<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lvl2Menu
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
        Dim btnreceipt2 As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lvl2Menu))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btninventory2 = New System.Windows.Forms.Button()
        Me.btnlogout2 = New System.Windows.Forms.Button()
        Me.btnemployee = New System.Windows.Forms.Button()
        btnreceipt2 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreceipt2
        '
        btnreceipt2.BackgroundImage = CType(resources.GetObject("btnreceipt2.BackgroundImage"), System.Drawing.Image)
        btnreceipt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnreceipt2.Cursor = System.Windows.Forms.Cursors.Hand
        btnreceipt2.FlatAppearance.BorderSize = 0
        btnreceipt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnreceipt2.ForeColor = System.Drawing.Color.Transparent
        btnreceipt2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        btnreceipt2.Location = New System.Drawing.Point(170, 199)
        btnreceipt2.Name = "btnreceipt2"
        btnreceipt2.Size = New System.Drawing.Size(249, 47)
        btnreceipt2.TabIndex = 1
        btnreceipt2.UseVisualStyleBackColor = True
        AddHandler btnreceipt2.Click, AddressOf Me.btnreceipt_Click
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btninventory2
        '
        Me.btninventory2.BackgroundImage = CType(resources.GetObject("btninventory2.BackgroundImage"), System.Drawing.Image)
        Me.btninventory2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btninventory2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninventory2.FlatAppearance.BorderSize = 0
        Me.btninventory2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninventory2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btninventory2.Location = New System.Drawing.Point(419, 199)
        Me.btninventory2.Name = "btninventory2"
        Me.btninventory2.Size = New System.Drawing.Size(249, 47)
        Me.btninventory2.TabIndex = 2
        Me.btninventory2.UseVisualStyleBackColor = True
        '
        'btnlogout2
        '
        Me.btnlogout2.BackgroundImage = CType(resources.GetObject("btnlogout2.BackgroundImage"), System.Drawing.Image)
        Me.btnlogout2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogout2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout2.FlatAppearance.BorderSize = 0
        Me.btnlogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnlogout2.Location = New System.Drawing.Point(358, 341)
        Me.btnlogout2.Name = "btnlogout2"
        Me.btnlogout2.Size = New System.Drawing.Size(125, 39)
        Me.btnlogout2.TabIndex = 3
        Me.btnlogout2.UseVisualStyleBackColor = True
        '
        'btnemployee
        '
        Me.btnemployee.BackgroundImage = CType(resources.GetObject("btnemployee.BackgroundImage"), System.Drawing.Image)
        Me.btnemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnemployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnemployee.FlatAppearance.BorderSize = 0
        Me.btnemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnemployee.ForeColor = System.Drawing.Color.Transparent
        Me.btnemployee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnemployee.Location = New System.Drawing.Point(170, 252)
        Me.btnemployee.Name = "btnemployee"
        Me.btnemployee.Size = New System.Drawing.Size(498, 55)
        Me.btnemployee.TabIndex = 5
        Me.btnemployee.UseVisualStyleBackColor = True
        '
        'Lvl2Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 441)
        Me.Controls.Add(Me.btnemployee)
        Me.Controls.Add(Me.btnlogout2)
        Me.Controls.Add(Me.btninventory2)
        Me.Controls.Add(btnreceipt2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lvl2Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBeast"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btninventory2 As Button
    Friend WithEvents btnlogout2 As Button
    Friend WithEvents btnemployee As Button
End Class
