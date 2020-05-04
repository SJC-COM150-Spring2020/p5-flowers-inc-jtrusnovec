<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm1))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnBuild = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picFlower = New System.Windows.Forms.PictureBox()
        Me.lblQuiz = New System.Windows.Forms.Label()
        Me.lblQuiz2 = New System.Windows.Forms.Label()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblBuild2 = New System.Windows.Forms.Label()
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(181, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 38)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnQuiz
        '
        Me.btnQuiz.BackColor = System.Drawing.Color.White
        Me.btnQuiz.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQuiz.Location = New System.Drawing.Point(52, 279)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(134, 38)
        Me.btnQuiz.TabIndex = 1
        Me.btnQuiz.Text = "Take Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = False
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.White
        Me.btnBuild.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuild.Location = New System.Drawing.Point(351, 279)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(134, 38)
        Me.btnBuild.TabIndex = 2
        Me.btnBuild.Text = "Build Bouquet"
        Me.btnBuild.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeading.Location = New System.Drawing.Point(66, 171)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(381, 79)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Flowers Inc."
        '
        'picFlower
        '
        Me.picFlower.Image = CType(resources.GetObject("picFlower.Image"), System.Drawing.Image)
        Me.picFlower.Location = New System.Drawing.Point(-1, 1)
        Me.picFlower.Name = "picFlower"
        Me.picFlower.Size = New System.Drawing.Size(528, 167)
        Me.picFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFlower.TabIndex = 4
        Me.picFlower.TabStop = False
        '
        'lblQuiz
        '
        Me.lblQuiz.AutoSize = True
        Me.lblQuiz.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuiz.ForeColor = System.Drawing.Color.Black
        Me.lblQuiz.Location = New System.Drawing.Point(12, 320)
        Me.lblQuiz.Name = "lblQuiz"
        Me.lblQuiz.Size = New System.Drawing.Size(218, 16)
        Me.lblQuiz.TabIndex = 5
        Me.lblQuiz.Text = "What Does Your Favorite Flower"
        '
        'lblQuiz2
        '
        Me.lblQuiz2.AutoSize = True
        Me.lblQuiz2.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuiz2.ForeColor = System.Drawing.Color.Black
        Me.lblQuiz2.Location = New System.Drawing.Point(62, 336)
        Me.lblQuiz2.Name = "lblQuiz2"
        Me.lblQuiz2.Size = New System.Drawing.Size(107, 16)
        Me.lblQuiz2.TabIndex = 6
        Me.lblQuiz2.Text = "Say About You?"
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuild.ForeColor = System.Drawing.Color.Black
        Me.lblBuild.Location = New System.Drawing.Point(336, 320)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(161, 16)
        Me.lblBuild.TabIndex = 7
        Me.lblBuild.Text = "Build And Buy Your Own"
        '
        'lblBuild2
        '
        Me.lblBuild2.AutoSize = True
        Me.lblBuild2.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuild2.ForeColor = System.Drawing.Color.Black
        Me.lblBuild2.Location = New System.Drawing.Point(364, 336)
        Me.lblBuild2.Name = "lblBuild2"
        Me.lblBuild2.Size = New System.Drawing.Size(112, 16)
        Me.lblBuild2.TabIndex = 8
        Me.lblBuild2.Text = "Flower Bouquet!"
        '
        'MenuForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(524, 439)
        Me.Controls.Add(Me.lblBuild2)
        Me.Controls.Add(Me.lblBuild)
        Me.Controls.Add(Me.lblQuiz2)
        Me.Controls.Add(Me.lblQuiz)
        Me.Controls.Add(Me.picFlower)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnBuild)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnExit)
        Me.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Name = "MenuForm1"
        Me.Text = "Main Menu"
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnBuild As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents picFlower As PictureBox
    Friend WithEvents lblQuiz As Label
    Friend WithEvents lblQuiz2 As Label
    Friend WithEvents lblBuild As Label
    Friend WithEvents lblBuild2 As Label
End Class
