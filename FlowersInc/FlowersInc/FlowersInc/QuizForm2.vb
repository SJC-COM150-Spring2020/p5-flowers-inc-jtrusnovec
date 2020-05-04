Public Class QuizForm2
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all radio buttons, text box, list box, and make pictures reappear

        lstOut.Items.Clear()
        radDaffodil.Checked = False
        radDaisy.Checked = False
        radLily.Checked = False
        radRose.Checked = False
        radSunflower.Checked = False
        radTulip.Checked = False
        txtName.Clear()
        picDaffodil.Visible = True
        picDaisy.Visible = True
        picLily.Visible = True
        picRose.Visible = True
        picSunflower.Visible = True
        picTulip.Visible = True

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        'take user back to main menu

        'hide current form using me
        Me.Hide()

        'show main menu (form 1)
        MenuForm1.Show()


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'output the users favorite flower choice and name to listbox, display favorite flower in picbox

        If (radDaffodil.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Daffodil!")
            lstOut.Items.Add("You are fun and laid-back and always put friends and family first.")
            picDaffodil.Visible = True
            picDaisy.Visible = False
            picLily.Visible = False
            picRose.Visible = False
            picSunflower.Visible = False
            picTulip.Visible = False

        ElseIf (radDaisy.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Daisy!")
            lstOut.Items.Add("You are an optimist who can find the good in any bad situation.")
            picDaisy.Visible = True
            picDaffodil.Visible = False
            picLily.Visible = False
            picRose.Visible = False
            picSunflower.Visible = False
            picTulip.Visible = False

        ElseIf (radLily.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Lily!")
            lstOut.Items.Add("You are a hard worker and are proud of all you accomplish.")
            picLily.Visible = True
            picDaffodil.Visible = False
            picDaisy.Visible = False
            picRose.Visible = False
            picSunflower.Visible = False
            picTulip.Visible = False

        ElseIf (radRose.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Rose!")
            lstOut.Items.Add("You think with your heart and know how to make a statement.")
            picRose.Visible = True
            picDaffodil.Visible = False
            picDaisy.Visible = False
            picLily.Visible = False
            picSunflower.Visible = False
            picTulip.Visible = False

        ElseIf (radSunflower.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Sunflower!")
            lstOut.Items.Add("You love to be around people and make new friends.")
            picSunflower.Visible = True
            picDaffodil.Visible = False
            picDaisy.Visible = False
            picLily.Visible = False
            picRose.Visible = False
            picTulip.Visible = False

        ElseIf (radTulip.Checked = True) Then
            lstOut.Items.Add(txtName.Text & ", your favorite flower is a Tulip!")
            lstOut.Items.Add("You are thoughtful and confident and are always coordinated.")
            picTulip.Visible = True
            picDaffodil.Visible = False
            picDaisy.Visible = False
            picLily.Visible = False
            picRose.Visible = False
            picSunflower.Visible = False

        End If

    End Sub
End Class