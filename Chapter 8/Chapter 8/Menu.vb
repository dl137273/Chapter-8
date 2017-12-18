Public Class Menu

    Private Sub btnLotteryTicket_Click(sender As Object, e As EventArgs) Handles btnLotteryTicket.Click
        Dim Box = New LotteryTicket()
        Box.Show()
    End Sub

    Private Sub btnSeatingChart_Click(sender As Object, e As EventArgs) Handles btnSeatingChart.Click
        Dim Box = New SeatingChart()
        Box.Show()
    End Sub

    Private Sub btnFriendsList_Click(sender As Object, e As EventArgs) Handles btnFriendsList.Click
        Dim Box = New Friend_List()
        Box.Show()
    End Sub

    Private Sub btnFriendList2_Click(sender As Object, e As EventArgs) Handles btnFriendList2.Click
        Dim Box = New Friend_List_2()
        Box.Show()
    End Sub
End Class