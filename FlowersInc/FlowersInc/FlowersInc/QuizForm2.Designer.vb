<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizForm2))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpFlower = New System.Windows.Forms.GroupBox()
        Me.radLily = New System.Windows.Forms.RadioButton()
        Me.radSunflower = New System.Windows.Forms.RadioButton()
        Me.radDaffodil = New System.Windows.Forms.RadioButton()
        Me.radDaisy = New System.Windows.Forms.RadioButton()
        Me.radTulip = New System.Windows.Forms.RadioButton()
        Me.radRose = New System.Windows.Forms.RadioButton()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.picRose = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picTulip = New System.Windows.Forms.PictureBox()
        Me.picDaisy = New System.Windows.Forms.PictureBox()
        Me.picDaffodil = New System.Windows.Forms.PictureBox()
        Me.picSunflower = New System.Windows.Forms.PictureBox()
        Me.picLily = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpFlower.SuspendLayout()
        CType(Me.picRose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTulip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaisy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaffodil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(10, 35)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 27)
        Me.txtName.TabIndex = 0
        '
        'grpFlower
        '
        Me.grpFlower.Controls.Add(Me.radLily)
        Me.grpFlower.Controls.Add(Me.radSunflower)
        Me.grpFlower.Controls.Add(Me.radDaffodil)
        Me.grpFlower.Controls.Add(Me.radDaisy)
        Me.grpFlower.Controls.Add(Me.radTulip)
        Me.grpFlower.Controls.Add(Me.radRose)
        Me.grpFlower.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFlower.Location = New System.Drawing.Point(10, 68)
        Me.grpFlower.Name = "grpFlower"
        Me.grpFlower.Size = New System.Drawing.Size(248, 168)
        Me.grpFlower.TabIndex = 1
        Me.grpFlower.TabStop = False
        Me.grpFlower.Text = "What's Your Favorite Flower?"
        '
        'radLily
        '
        Me.radLily.AutoSize = True
        Me.radLily.Location = New System.Drawing.Point(7, 139)
        Me.radLily.Name = "radLily"
        Me.radLily.Size = New System.Drawing.Size(65, 23)
        Me.radLily.TabIndex = 5
        Me.radLily.TabStop = True
        Me.radLily.Text = "Lilies"
        Me.radLily.UseVisualStyleBackColor = True
        '
        'radSunflower
        '
        Me.radSunflower.AutoSize = True
        Me.radSunflower.Location = New System.Drawing.Point(7, 115)
        Me.radSunflower.Name = "radSunflower"
        Me.radSunflower.Size = New System.Drawing.Size(105, 23)
        Me.radSunflower.TabIndex = 4
        Me.radSunflower.TabStop = True
        Me.radSunflower.Text = "Sunflowers"
        Me.radSunflower.UseVisualStyleBackColor = True
        '
        'radDaffodil
        '
        Me.radDaffodil.AutoSize = True
        Me.radDaffodil.Location = New System.Drawing.Point(7, 91)
        Me.radDaffodil.Name = "radDaffodil"
        Me.radDaffodil.Size = New System.Drawing.Size(92, 23)
        Me.radDaffodil.TabIndex = 3
        Me.radDaffodil.TabStop = True
        Me.radDaffodil.Text = "Daffodils"
        Me.radDaffodil.UseVisualStyleBackColor = True
        '
        'radDaisy
        '
        Me.radDaisy.AutoSize = True
        Me.radDaisy.Location = New System.Drawing.Point(7, 67)
        Me.radDaisy.Name = "radDaisy"
        Me.radDaisy.Size = New System.Drawing.Size(79, 23)
        Me.radDaisy.TabIndex = 2
        Me.radDaisy.TabStop = True
        Me.radDaisy.Text = "Daisies"
        Me.radDaisy.UseVisualStyleBackColor = True
        '
        'radTulip
        '
        Me.radTulip.AutoSize = True
        Me.radTulip.Location = New System.Drawing.Point(7, 44)
        Me.radTulip.Name = "radTulip"
        Me.radTulip.Size = New System.Drawing.Size(72, 23)
        Me.radTulip.TabIndex = 1
        Me.radTulip.TabStop = True
        Me.radTulip.Text = "Tulips"
        Me.radTulip.UseVisualStyleBackColor = True
        '
        'radRose
        '
        Me.radRose.AutoSize = True
        Me.radRose.Location = New System.Drawing.Point(7, 20)
        Me.radRose.Name = "radRose"
        Me.radRose.Size = New System.Drawing.Size(68, 23)
        Me.radRose.TabIndex = 0
        Me.radRose.TabStop = True
        Me.radRose.Text = "Roses"
        Me.radRose.UseVisualStyleBackColor = True
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lstOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstOut.Font = New System.Drawing.Font("Ink Free", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 21
        Me.lstOut.Location = New System.Drawing.Point(264, 167)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(570, 105)
        Me.lstOut.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(9, 487)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(128, 487)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 30)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'picRose
        '
        Me.picRose.Image = CType(resources.GetObject("picRose.Image"), System.Drawing.Image)
        Me.picRose.Location = New System.Drawing.Point(-2, 278)
        Me.picRose.Name = "picRose"
        Me.picRose.Size = New System.Drawing.Size(140, 203)
        Me.picRose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRose.TabIndex = 5
        Me.picRose.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(9, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 30)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Results"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(212, 23)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Enter Your First Name"
        '
        'picTulip
        '
        Me.picTulip.Image = CType(resources.GetObject("picTulip.Image"), System.Drawing.Image)
        Me.picTulip.Location = New System.Drawing.Point(144, 278)
        Me.picTulip.Name = "picTulip"
        Me.picTulip.Size = New System.Drawing.Size(140, 203)
        Me.picTulip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTulip.TabIndex = 8
        Me.picTulip.TabStop = False
        '
        'picDaisy
        '
        Me.picDaisy.Image = CType(resources.GetObject("picDaisy.Image"), System.Drawing.Image)
        Me.picDaisy.Location = New System.Drawing.Point(292, 278)
        Me.picDaisy.Name = "picDaisy"
        Me.picDaisy.Size = New System.Drawing.Size(140, 203)
        Me.picDaisy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDaisy.TabIndex = 9
        Me.picDaisy.TabStop = False
        '
        'picDaffodil
        '
        Me.picDaffodil.Image = CType(resources.GetObject("picDaffodil.Image"), System.Drawing.Image)
        Me.picDaffodil.Location = New System.Drawing.Point(438, 278)
        Me.picDaffodil.Name = "picDaffodil"
        Me.picDaffodil.Size = New System.Drawing.Size(140, 203)
        Me.picDaffodil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDaffodil.TabIndex = 10
        Me.picDaffodil.TabStop = False
        '
        'picSunflower
        '
        Me.picSunflower.Image = CType(resources.GetObject("picSunflower.Image"), System.Drawing.Image)
        Me.picSunflower.Location = New System.Drawing.Point(569, 278)
        Me.picSunflower.Name = "picSunflower"
        Me.picSunflower.Size = New System.Drawing.Size(140, 203)
        Me.picSunflower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSunflower.TabIndex = 11
        Me.picSunflower.TabStop = False
        '
        'picLily
        '
        Me.picLily.Image = CType(resources.GetObject("picLily.Image"), System.Drawing.Image)
        Me.picLily.Location = New System.Drawing.Point(715, 278)
        Me.picLily.Name = "picLily"
        Me.picLily.Size = New System.Drawing.Size(140, 203)
        Me.picLily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLily.TabIndex = 12
        Me.picLily.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(397, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(289, 60)
        Me.lblHeading.TabIndex = 13
        Me.lblHeading.Text = "Flowers Inc."
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(317, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(477, 60)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Favorite Flower Quiz"
        '
        'QuizForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(846, 529)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picLily)
        Me.Controls.Add(Me.picSunflower)
        Me.Controls.Add(Me.picDaffodil)
        Me.Controls.Add(Me.picDaisy)
        Me.Controls.Add(Me.picTulip)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picRose)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpFlower)
        Me.Controls.Add(Me.txtName)
        Me.Name = "QuizForm2"
        Me.Text = "Take The Quiz!"
        Me.grpFlower.ResumeLayout(False)
        Me.grpFlower.PerformLayout()
        CType(Me.picRose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTulip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaisy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaffodil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents grpFlower As GroupBox
    Friend WithEvents radRose As RadioButton
    Friend WithEvents radLily As RadioButton
    Friend WithEvents radSunflower As RadioButton
    Friend WithEvents radDaffodil As RadioButton
    Friend WithEvents radDaisy As RadioButton
    Friend WithEvents radTulip As RadioButton
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents picRose As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblName As Label
    Friend WithEvents picTulip As PictureBox
    Friend WithEvents picDaisy As PictureBox
    Friend WithEvents picDaffodil As PictureBox
    Friend WithEvents picSunflower As PictureBox
    Friend WithEvents picLily As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTitle As Label
End Class
