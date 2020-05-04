'declare the module to hold our global varibales so they can be used across forms
Module Globals
    Public price As Double
    Public Const TAX As Double = 0.08645
    Public total As Double
    Public salestax As Double
    Public quantity As Integer
    Public flower As String
    Public rose As String
    Public baby As String
    Public leaf As String
    Public containers As String
End Module


Public Class MenuForm1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exit the program
        Application.Exit()

    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click

        'take user to form 2 to take the quiz

        'hide main menu (form 1) using me because it is the current form
        Me.Hide()

        'show form 2
        QuizForm2.Show()

    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click

        'take user to form 3 to build their bouquet

        'hide main menu (form 1) using me because it is the current form
        Me.Hide()

        'show form 3
        BuildForm3.Show()


    End Sub

End Class
