﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt2))
        Me.btnback1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnback1
        '
        Me.btnback1.BackgroundImage = CType(resources.GetObject("btnback1.BackgroundImage"), System.Drawing.Image)
        Me.btnback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback1.FlatAppearance.BorderSize = 0
        Me.btnback1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback1.Location = New System.Drawing.Point(36, 28)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(39, 37)
        Me.btnback1.TabIndex = 2
        Me.btnback1.UseVisualStyleBackColor = True
        '
        'Receipt2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnback1)
        Me.DoubleBuffered = True
        Me.Name = "Receipt2"
        Me.Text = "DataBeast"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnback1 As Button
End Class