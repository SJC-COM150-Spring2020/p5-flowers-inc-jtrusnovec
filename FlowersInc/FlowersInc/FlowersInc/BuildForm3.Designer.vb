<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuildForm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuildForm3))
        Me.grpAccent = New System.Windows.Forms.GroupBox()
        Me.chkLeaf = New System.Windows.Forms.CheckBox()
        Me.chkBaby = New System.Windows.Forms.CheckBox()
        Me.chkRose = New System.Windows.Forms.CheckBox()
        Me.grpContainer = New System.Windows.Forms.GroupBox()
        Me.radBasket = New System.Windows.Forms.RadioButton()
        Me.radMason = New System.Windows.Forms.RadioButton()
        Me.radVase = New System.Windows.Forms.RadioButton()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtFlower = New System.Windows.Forms.TextBox()
        Me.lblRose = New System.Windows.Forms.Label()
        Me.lblHydrangea = New System.Windows.Forms.Label()
        Me.lblDaisy = New System.Windows.Forms.Label()
        Me.lblLily = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picFlower = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picFlower1 = New System.Windows.Forms.PictureBox()
        Me.picThanks = New System.Windows.Forms.PictureBox()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.grpAccent.SuspendLayout()
        Me.grpContainer.SuspendLayout()
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlower1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAccent
        '
        Me.grpAccent.Controls.Add(Me.chkLeaf)
        Me.grpAccent.Controls.Add(Me.chkBaby)
        Me.grpAccent.Controls.Add(Me.chkRose)
        Me.grpAccent.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccent.Location = New System.Drawing.Point(273, 206)
        Me.grpAccent.Name = "grpAccent"
        Me.grpAccent.Size = New System.Drawing.Size(253, 107)
        Me.grpAccent.TabIndex = 2
        Me.grpAccent.TabStop = False
        Me.grpAccent.Text = "Accents"
        '
        'chkLeaf
        '
        Me.chkLeaf.AutoSize = True
        Me.chkLeaf.Location = New System.Drawing.Point(6, 74)
        Me.chkLeaf.Name = "chkLeaf"
        Me.chkLeaf.Size = New System.Drawing.Size(235, 24)
        Me.chkLeaf.TabIndex = 2
        Me.chkLeaf.Text = "Leather Leaf Fern ($1.25)"
        Me.chkLeaf.UseVisualStyleBackColor = True
        '
        'chkBaby
        '
        Me.chkBaby.AutoSize = True
        Me.chkBaby.Location = New System.Drawing.Point(6, 47)
        Me.chkBaby.Name = "chkBaby"
        Me.chkBaby.Size = New System.Drawing.Size(202, 24)
        Me.chkBaby.TabIndex = 1
        Me.chkBaby.Text = "Baby's Breath ($1.50)"
        Me.chkBaby.UseVisualStyleBackColor = True
        '
        'chkRose
        '
        Me.chkRose.AutoSize = True
        Me.chkRose.Location = New System.Drawing.Point(6, 21)
        Me.chkRose.Name = "chkRose"
        Me.chkRose.Size = New System.Drawing.Size(229, 24)
        Me.chkRose.TabIndex = 0
        Me.chkRose.Text = "Mini Spray Roses  ($2.65)"
        Me.chkRose.UseVisualStyleBackColor = True
        '
        'grpContainer
        '
        Me.grpContainer.Controls.Add(Me.radBasket)
        Me.grpContainer.Controls.Add(Me.radMason)
        Me.grpContainer.Controls.Add(Me.radVase)
        Me.grpContainer.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpContainer.Location = New System.Drawing.Point(544, 206)
        Me.grpContainer.Name = "grpContainer"
        Me.grpContainer.Size = New System.Drawing.Size(283, 107)
        Me.grpContainer.TabIndex = 3
        Me.grpContainer.TabStop = False
        Me.grpContainer.Text = "Containers"
        '
        'radBasket
        '
        Me.radBasket.AutoSize = True
        Me.radBasket.Location = New System.Drawing.Point(6, 73)
        Me.radBasket.Name = "radBasket"
        Me.radBasket.Size = New System.Drawing.Size(148, 24)
        Me.radBasket.TabIndex = 2
        Me.radBasket.TabStop = True
        Me.radBasket.Text = "Basket ($8.00)"
        Me.radBasket.UseVisualStyleBackColor = True
        '
        'radMason
        '
        Me.radMason.AutoSize = True
        Me.radMason.Location = New System.Drawing.Point(6, 48)
        Me.radMason.Name = "radMason"
        Me.radMason.Size = New System.Drawing.Size(173, 24)
        Me.radMason.TabIndex = 1
        Me.radMason.TabStop = True
        Me.radMason.Text = "Mason Jar ($4.00)"
        Me.radMason.UseVisualStyleBackColor = True
        '
        'radVase
        '
        Me.radVase.AutoSize = True
        Me.radVase.Location = New System.Drawing.Point(6, 20)
        Me.radVase.Name = "radVase"
        Me.radVase.Size = New System.Drawing.Size(126, 24)
        Me.radVase.TabIndex = 0
        Me.radVase.TabStop = True
        Me.radVase.Text = "Vase ($6.00)"
        Me.radVase.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(327, 64)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(179, 34)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Flower Prices"
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lstOut.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 20
        Me.lstOut.Location = New System.Drawing.Point(5, 374)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(393, 124)
        Me.lstOut.TabIndex = 5
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.White
        Me.btnTotal.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(4, 312)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(129, 32)
        Me.btnTotal.TabIndex = 6
        Me.btnTotal.Text = "Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.White
        Me.btnCheckout.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(279, 504)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(103, 32)
        Me.btnCheckout.TabIndex = 7
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(139, 504)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(128, 32)
        Me.btnMenu.TabIndex = 8
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(5, 504)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 32)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(139, 251)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(124, 27)
        Me.txtQuantity.TabIndex = 11
        '
        'txtFlower
        '
        Me.txtFlower.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlower.Location = New System.Drawing.Point(139, 218)
        Me.txtFlower.Name = "txtFlower"
        Me.txtFlower.Size = New System.Drawing.Size(124, 27)
        Me.txtFlower.TabIndex = 12
        '
        'lblRose
        '
        Me.lblRose.AutoSize = True
        Me.lblRose.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRose.Location = New System.Drawing.Point(340, 98)
        Me.lblRose.Name = "lblRose"
        Me.lblRose.Size = New System.Drawing.Size(144, 20)
        Me.lblRose.TabIndex = 13
        Me.lblRose.Text = "Rose: $2.80 Each"
        '
        'lblHydrangea
        '
        Me.lblHydrangea.AutoSize = True
        Me.lblHydrangea.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHydrangea.Location = New System.Drawing.Point(320, 138)
        Me.lblHydrangea.Name = "lblHydrangea"
        Me.lblHydrangea.Size = New System.Drawing.Size(186, 20)
        Me.lblHydrangea.TabIndex = 14
        Me.lblHydrangea.Text = "Hydrangea: $5.00 Each"
        '
        'lblDaisy
        '
        Me.lblDaisy.AutoSize = True
        Me.lblDaisy.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaisy.Location = New System.Drawing.Point(337, 118)
        Me.lblDaisy.Name = "lblDaisy"
        Me.lblDaisy.Size = New System.Drawing.Size(147, 20)
        Me.lblDaisy.TabIndex = 15
        Me.lblDaisy.Text = "Daisy: $2.00 Each"
        '
        'lblLily
        '
        Me.lblLily.AutoSize = True
        Me.lblLily.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLily.Location = New System.Drawing.Point(351, 160)
        Me.lblLily.Name = "lblLily"
        Me.lblLily.Size = New System.Drawing.Size(133, 20)
        Me.lblLily.TabIndex = 16
        Me.lblLily.Text = "Lily: $3.00 Each"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ink Free", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(228, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(366, 39)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Build Your Own Bouquet"
        '
        'picFlower
        '
        Me.picFlower.Image = CType(resources.GetObject("picFlower.Image"), System.Drawing.Image)
        Me.picFlower.Location = New System.Drawing.Point(5, 64)
        Me.picFlower.Name = "picFlower"
        Me.picFlower.Size = New System.Drawing.Size(291, 116)
        Me.picFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlower.TabIndex = 19
        Me.picFlower.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Flower Choice:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Quantity:"
        '
        'picFlower1
        '
        Me.picFlower1.Image = CType(resources.GetObject("picFlower1.Image"), System.Drawing.Image)
        Me.picFlower1.Location = New System.Drawing.Point(536, 64)
        Me.picFlower1.Name = "picFlower1"
        Me.picFlower1.Size = New System.Drawing.Size(291, 116)
        Me.picFlower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlower1.TabIndex = 22
        Me.picFlower1.TabStop = False
        '
        'picThanks
        '
        Me.picThanks.Image = CType(resources.GetObject("picThanks.Image"), System.Drawing.Image)
        Me.picThanks.Location = New System.Drawing.Point(404, 350)
        Me.picThanks.Name = "picThanks"
        Me.picThanks.Size = New System.Drawing.Size(423, 165)
        Me.picThanks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThanks.TabIndex = 23
        Me.picThanks.TabStop = False
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(2, 354)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(98, 19)
        Me.lblReceipt.TabIndex = 24
        Me.lblReceipt.Text = "Your Receipt"
        '
        'BuildForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(839, 536)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.picThanks)
        Me.Controls.Add(Me.picFlower1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picFlower)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblLily)
        Me.Controls.Add(Me.lblDaisy)
        Me.Controls.Add(Me.lblHydrangea)
        Me.Controls.Add(Me.lblRose)
        Me.Controls.Add(Me.txtFlower)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.grpContainer)
        Me.Controls.Add(Me.grpAccent)
        Me.Name = "BuildForm3"
        Me.Text = "Build Your Bouquet!"
        Me.grpAccent.ResumeLayout(False)
        Me.grpAccent.PerformLayout()
        Me.grpContainer.ResumeLayout(False)
        Me.grpContainer.PerformLayout()
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlower1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAccent As GroupBox
    Friend WithEvents chkRose As CheckBox
    Friend WithEvents chkLeaf As CheckBox
    Friend WithEvents chkBaby As CheckBox
    Friend WithEvents grpContainer As GroupBox
    Friend WithEvents radBasket As RadioButton
    Friend WithEvents radMason As RadioButton
    Friend WithEvents radVase As RadioButton
    Friend WithEvents lblPrice As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtFlower As TextBox
    Friend WithEvents lblRose As Label
    Friend WithEvents lblHydrangea As Label
    Friend WithEvents lblDaisy As Label
    Friend WithEvents lblLily As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picFlower As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picFlower1 As PictureBox
    Friend WithEvents picThanks As PictureBox
    Friend WithEvents lblReceipt As Label
End Class
