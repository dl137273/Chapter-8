﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Friend_List
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
        Me.btnEnterNames = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnEnterNames
        '
        Me.btnEnterNames.Location = New System.Drawing.Point(47, 269)
        Me.btnEnterNames.Name = "btnEnterNames"
        Me.btnEnterNames.Size = New System.Drawing.Size(78, 41)
        Me.btnEnterNames.TabIndex = 0
        Me.btnEnterNames.Text = "Enter Names"
        Me.btnEnterNames.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(255, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 41)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(115, 70)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(165, 134)
        Me.lstFriends.TabIndex = 2
        '
        'Friend_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 336)
        Me.Controls.Add(Me.lstFriends)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNames)
        Me.Name = "Friend_List"
        Me.Text = "Friend List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterNames As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstFriends As System.Windows.Forms.ListBox
End Class
