Public Class Form3


    Private Const BokchoyPrice As Integer = 20
    Private Const OnionPrice As Integer = 50
    Private Const TomatoPrice As Integer = 35
    Private Const MustasaPrice As Integer = 50
    Private Const SunflowerPrice As Integer = 45
    Private Const EggplantPrice As Integer = 40
    Private Const CabbagePrice As Integer = 30
    Private Const LettucePrice As Integer = 55

    Private bokchoyQty As Integer = 0
    Private onionQty As Integer = 0
    Private tomatoQty As Integer = 0
    Private mustasaQty As Integer = 0
    Private sunflowerQty As Integer = 0
    Private eggplantQty As Integer = 0
    Private cabbageQty As Integer = 0
    Private lettuceQty As Integer = 0
    Public Property MessageBoxButton As Object

    Public Function CalculateTotal() As Integer
        Dim total As Integer = 0
        total += bokchoyQty * BokchoyPrice
        total += onionQty * OnionPrice
        total += tomatoQty * TomatoPrice
        total += mustasaQty * MustasaPrice
        total += sunflowerQty * SunflowerPrice
        total += eggplantQty * EggplantPrice
        total += cabbageQty * CabbagePrice
        total += lettuceQty * LettucePrice
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, PictureBox9.DoubleClick
        Dim quantity = Integer.Parse(Qty1.Text)
        quantity += 1
        Qty1.Text = quantity.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim quantity As Integer = Integer.Parse(Qty1.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty1.Text = quantity.ToString()
        End If
    End Sub

    Private Sub OnionPlus_Click(sender As Object, e As EventArgs) Handles OnionPlus.Click
        Dim quantity = Integer.Parse(Qty2.Text)
        quantity += 1
        Qty2.Text = quantity.ToString
    End Sub

    Private Sub OnionMinus_Click(sender As Object, e As EventArgs) Handles OnionMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty2.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty2.Text = quantity.ToString()
        End If
    End Sub

    Private Sub TomatoPlus_Click(sender As Object, e As EventArgs) Handles TomatoPlus.Click
        Dim quantity As Integer = Integer.Parse(Qty3.Text)
        quantity += 1
        Qty3.Text = quantity.ToString()
    End Sub

    Private Sub TomatoMinus_Click(sender As Object, e As EventArgs) Handles TomatoMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty3.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty3.Text = quantity.ToString()
        End If
    End Sub

    Private Sub MustasaPlus_Click(sender As Object, e As EventArgs) Handles MustasaPlus.Click
        Dim quantity As Integer = Integer.Parse(Qty4.Text)
        quantity += 1
        Qty4.Text = quantity.ToString()
    End Sub

    Private Sub MustasaMinus_Click(sender As Object, e As EventArgs) Handles MustasaMinus.Click
        Dim quantity = Integer.Parse(Qty4.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty4.Text = quantity.ToString
        End If
    End Sub

    Private Sub SunflowerPlus_Click(sender As Object, e As EventArgs) Handles SunflowerPlus.Click
        Dim quantity As Integer = Integer.Parse(Qty5.Text)
        quantity += 1
        Qty5.Text = quantity.ToString()
    End Sub

    Private Sub SunflowerMinus_Click(sender As Object, e As EventArgs) Handles SunflowerMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty5.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty5.Text = quantity.ToString()
        End If
    End Sub

    Private Sub EggplantPlus_Click(sender As Object, e As EventArgs) Handles EggplantPlus.Click
        Dim quantity As Integer = Integer.Parse(Qty6.Text)
        quantity += 1
        Qty6.Text = quantity.ToString()
    End Sub

    Private Sub EggplantMinus_Click(sender As Object, e As EventArgs) Handles EggplantMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty6.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty6.Text = quantity.ToString()
        End If
    End Sub

    Private Sub CabbagePlus_Click(sender As Object, e As EventArgs) Handles CabbagePlus.Click
        Dim quantity As Integer = Integer.Parse(Qty7.Text)
        quantity += 1
        Qty7.Text = quantity.ToString()
    End Sub

    Private Sub CabbageMinus_Click(sender As Object, e As EventArgs) Handles CabbageMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty7.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty7.Text = quantity.ToString()
        End If
    End Sub

    Private Sub LettucePlus_Click(sender As Object, e As EventArgs) Handles LettucePlus.Click
        Dim quantity As Integer = Integer.Parse(Qty8.Text)
        quantity += 1
        Qty8.Text = quantity.ToString()
    End Sub

    Private Sub LettuceMinus_Click(sender As Object, e As EventArgs) Handles LettuceMinus.Click
        Dim quantity As Integer = Integer.Parse(Qty8.Text)
        If quantity > 0 Then
            quantity -= 1
            Qty8.Text = quantity.ToString()
        End If
    End Sub
    Private Sub UpdateGrandTotal()
        lblTotal.Text = CalculateTotal().ToString()
    End Sub

    Private Sub UpdateBoughtList()
        Items.Items.Clear()

        If bokchoyQty > 0 Then Items.Items.Add($"Bokchoy: {bokchoyQty}")
        If onionQty > 0 Then Items.Items.Add($"Onion: {onionQty}")
        If tomatoQty > 0 Then Items.Items.Add($"Tomato: {tomatoQty}")
        If mustasaQty > 0 Then Items.Items.Add($"Mustasa: {mustasaQty}")
        If sunflowerQty > 0 Then Items.Items.Add($"Sunflower: {sunflowerQty}")
        If eggplantQty > 0 Then Items.Items.Add($"Eggplant: {eggplantQty}")
        If cabbageQty > 0 Then Items.Items.Add($"Cabbage: {cabbageQty}")
        If lettuceQty > 0 Then Items.Items.Add($"Lettuce: {lettuceQty}")
    End Sub

    Private Sub bokchoyBuy_Click(sender As Object, e As EventArgs) Handles bokchoyBuy.Click
        bokchoyQty = Integer.Parse(Qty1.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub OnionBuy_Click(sender As Object, e As EventArgs) Handles OnionBuy.Click
        onionQty = Integer.Parse(Qty2.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub TomatoBuy_Click(sender As Object, e As EventArgs) Handles TomatoBuy.Click
        tomatoQty = Integer.Parse(Qty3.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub MustasaBuy_Click(sender As Object, e As EventArgs) Handles MustasaBuy.Click
        mustasaQty = Integer.Parse(Qty4.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub SunflowerBuy_Click(sender As Object, e As EventArgs) Handles SunflowerBuy.Click
        sunflowerQty = Integer.Parse(Qty5.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub EggplantBuy_Click(sender As Object, e As EventArgs) Handles EggplantBuy.Click
        eggplantQty = Integer.Parse(Qty6.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub CabbageBuy_Click(sender As Object, e As EventArgs) Handles CabbageBuy.Click
        cabbageQty = Integer.Parse(Qty7.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub LettuceBuy_Click(sender As Object, e As EventArgs) Handles LettuceBuy.Click
        lettuceQty = Integer.Parse(Qty8.Text)
        UpdateBoughtList()
        UpdateGrandTotal()
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        MessageBox.Show("Order Successfully Placed!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim receiptText As New System.Text.StringBuilder()
        receiptText.AppendLine("-------------- FINAL RECEIPT -------------")
        receiptText.AppendLine("Item         | Quantity | Price | Total")
        receiptText.AppendLine(New String("-"c, 38))

        receiptText.AppendLine(AddItemToReceipt("Bokchoy", bokchoyQty, BokchoyPrice))
        receiptText.AppendLine(AddItemToReceipt("Onion", onionQty, OnionPrice))
        receiptText.AppendLine(AddItemToReceipt("Tomato", tomatoQty, TomatoPrice))
        receiptText.AppendLine(AddItemToReceipt("Mustasa", mustasaQty, MustasaPrice))
        receiptText.AppendLine(AddItemToReceipt("Sunflower", sunflowerQty, SunflowerPrice))
        receiptText.AppendLine(AddItemToReceipt("Eggplant", eggplantQty, EggplantPrice))
        receiptText.AppendLine(AddItemToReceipt("Cabbage", cabbageQty, CabbagePrice))
        receiptText.AppendLine(AddItemToReceipt("Lettuce", lettuceQty, LettucePrice))

        receiptText.AppendLine(New String("-"c, 38))
        receiptText.AppendLine($"Grand Total: ₱{CalculateTotal(),-27}")


        MessageBox.Show(receiptText.ToString(), "Receipt", MessageBoxButtons.OK)
    End Sub



    Private Function AddItemToReceipt(itemName As String, quantity As Integer, price As Integer) As String
        If quantity > 0 Then
            Dim totalPrice As Integer = quantity * price
            Return $"{itemName,-12} | {quantity,7} | ₱{price,5} | ₱{totalPrice,5}"
        Else
            Return String.Empty
        End If
    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Hide()
    End Sub

    Private Sub lstBought_SelectedIndexChanged(sender As Object, e As EventArgs)
        Show()


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form1.Show()
        Me.Hide()



    End Sub

    Private Sub Items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Items.SelectedIndexChanged

    End Sub

    Private Sub Receipt_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class