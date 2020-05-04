Public Class BuildForm3
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all input values
        txtFlower.Clear()
        txtQuantity.Clear()
        radBasket.Checked = False
        radVase.Checked = False
        radMason.Checked = False
        chkBaby.Checked = False
        chkLeaf.Checked = False
        chkRose.Checked = False
        lstOut.Items.Clear()


    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        'apply text box value to variable
        quantity = txtQuantity.Text
        flower = txtFlower.Text

        'display the user's flower choice and quantity while adding the total in listbox 

        lstOut.Items.Add("Flower Chosen")

        If (flower = "Rose") Or (flower = "rose") Or (flower = "Roses") Or (flower = "roses") Then
            lstOut.Items.Add("Rose: $2.80 Each")
            price = quantity * 2.8

        ElseIf (flower = "Daisy") Or (flower = "daisy") Or (flower = "daisies") Or (flower = "Daisies") Then
            lstOut.Items.Add("Daisy: $2.00 Each")
            price = quantity * 2

        ElseIf (flower = "Hydrangea") Or (flower = "hydrangea") Or (flower = "hydrangeas") Or (flower = "Hydrangeas") Then
            lstOut.Items.Add("Hydrangea: $5.00 Each")
            price = quantity * 5

        ElseIf (flower = "Lily") Or (flower = "lily") Or (flower = "Lilies") Or (flower = "lilies") Then
            lstOut.Items.Add("Lily: $3.00 Each")
            price = quantity * 3

        End If

        lstOut.Items.Add("Quantity: " & quantity)


        lstOut.Items.Add(" ")

        'display the users accents chosen while adding the total in listbox

        lstOut.Items.Add("Accents Chosen")

        If (chkRose.Checked = True) Then
            lstOut.Items.Add("Mini Spray Roses: $2.65")
            price = price + 2.65
            rose = "Mini Spray Roses"
        End If


        If (chkBaby.Checked = True) Then
            lstOut.Items.Add("Baby's Breath: $1.50")
            price = price + 1.5
            baby = "Baby's Breath"
        End If


        If (chkLeaf.Checked = True) Then
            lstOut.Items.Add("Leather Leaf Fern: $1.25")
            price = price + 1.25
            leaf = "Leather Leaf Fern"
        End If

        lstOut.Items.Add(" ")

        'display the users chosen container while adding the total in listbox

        lstOut.Items.Add("Container Chosen")

        If (radVase.Checked = True) Then
            lstOut.Items.Add("Vase: $6.00")
            price = price + 6
            containers = "Vase"

        ElseIf (radMason.Checked = True) Then
            lstOut.Items.Add("Mason Jar: $4.00")
            price = price + 4
            containers = "Mason Jar"

        ElseIf (radBasket.Checked = True) Then
            lstOut.Items.Add("Basket: $8.00")
            price = price + 8
            containers = "Basket"

        End If

        lstOut.Items.Add(" ")


        'display the subtotal in listbox
        lstOut.Items.Add("Subtotal: " & FormatCurrency(price, 2))

        'calculate ny sales tax value
        salestax = TAX * price

        'display the tax in the listbox
        lstOut.Items.Add("Tax: " & FormatCurrency(salestax, 2))
        lstOut.Items.Add(" ")

        'calculate the final total with tax
        total = salestax + price

        'display the final total in the listbox 
        lstOut.Items.Add("Total: " & FormatCurrency(total, 2))



    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        'take user to checkout form 4

        'hide the current form
        Me.Hide()

        'show checkout form
        Form.Show()


    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        'take user to main menu (form 1)

        'hide the current form
        Me.Hide()

        'show main menu form 
        MenuForm1.Show()


    End Sub

    Private Sub BuildForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class