Public Class Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exit the program for the user
        Application.Exit()


    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        'take user back to main menu (form 1)

        'hide current form
        Me.Hide()

        'show main menu form
        MenuForm1.Show()



    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click


        'display a message box thanking user
        MessageBox.Show("Thank You For Your Order, " & txtFirst.Text & "!")

        'output the users name, address, order summary, and total into the listbox
        lstOut.Items.Add(txtFirst.Text & " " & txtLast.Text & ", your order will be delivered to " & txtAddress.Text & ", " & txtCity.Text & ", " & txtState.Text & " " & txtZip.Text & ".")
        lstOut.Items.Add(" ")
        lstOut.Items.Add("Flower:")
        lstOut.Items.Add(flower)
        lstOut.Items.Add(" ")
        lstOut.Items.Add("Quantity:")
        lstOut.Items.Add(quantity)
        lstOut.Items.Add(" ")
        lstOut.Items.Add("Accents:")

        'if statement for only checked accents to show up in order summary 
        If (BuildForm3.chkRose.Checked = True) Then
            lstOut.Items.Add(rose)
        End If

        If (BuildForm3.chkBaby.Checked = True) Then
            lstOut.Items.Add(baby)
        End If

        If (BuildForm3.chkLeaf.Checked = True) Then
            lstOut.Items.Add(leaf)
        End If

        lstOut.Items.Add(" ")
        lstOut.Items.Add("Container:")
        lstOut.Items.Add(containers)
        lstOut.Items.Add(" ")
        lstOut.Items.Add("Total: " & FormatCurrency(total, 2))

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all values on form 4

        txtAddress.Clear()
        txtCity.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtState.Clear()
        txtZip.Clear()
        lstOut.Items.Clear()

    End Sub
End Class