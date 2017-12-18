<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnLotteryTicket = New System.Windows.Forms.Button()
        Me.btnSeatingChart = New System.Windows.Forms.Button()
        Me.btnFriendsList = New System.Windows.Forms.Button()
        Me.btnFriendList2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLotteryTicket
        '
        Me.btnLotteryTicket.Location = New System.Drawing.Point(157, 133)
        Me.btnLotteryTicket.Name = "btnLotteryTicket"
        Me.btnLotteryTicket.Size = New System.Drawing.Size(97, 34)
        Me.btnLotteryTicket.TabIndex = 0
        Me.btnLotteryTicket.Text = "Lottery Ticket"
        Me.btnLotteryTicket.UseVisualStyleBackColor = True
        '
        'btnSeatingChart
        '
        Me.btnSeatingChart.Location = New System.Drawing.Point(157, 194)
        Me.btnSeatingChart.Name = "btnSeatingChart"
        Me.btnSeatingChart.Size = New System.Drawing.Size(97, 34)
        Me.btnSeatingChart.TabIndex = 1
        Me.btnSeatingChart.Text = "Seating Chart"
        Me.btnSeatingChart.UseVisualStyleBackColor = True
        '
        'btnFriendsList
        '
        Me.btnFriendsList.Location = New System.Drawing.Point(157, 246)
        Me.btnFriendsList.Name = "btnFriendsList"
        Me.btnFriendsList.Size = New System.Drawing.Size(97, 34)
        Me.btnFriendsList.TabIndex = 2
        Me.btnFriendsList.Text = "Friend List"
        Me.btnFriendsList.UseVisualStyleBackColor = True
        '
        'btnFriendList2
        '
        Me.btnFriendList2.Location = New System.Drawing.Point(157, 299)
        Me.btnFriendList2.Name = "btnFriendList2"
        Me.btnFriendList2.Size = New System.Drawing.Size(97, 34)
        Me.btnFriendList2.TabIndex = 3
        Me.btnFriendList2.Text = "Friend List 2"
        Me.btnFriendList2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Menu"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 398)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFriendList2)
        Me.Controls.Add(Me.btnFriendsList)
        Me.Controls.Add(Me.btnSeatingChart)
        Me.Controls.Add(Me.btnLotteryTicket)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLotteryTicket As System.Windows.Forms.Button
    Friend WithEvents btnSeatingChart As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList As System.Windows.Forms.Button
    Friend WithEvents btnFriendList2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
