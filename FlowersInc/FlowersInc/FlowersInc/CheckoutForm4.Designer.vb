<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picFlower = New System.Windows.Forms.PictureBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(6, 224)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(132, 27)
        Me.txtFirst.TabIndex = 0
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(144, 224)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(132, 27)
        Me.txtLast.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(282, 224)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(132, 27)
        Me.txtAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(420, 224)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 27)
        Me.txtCity.TabIndex = 3
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(694, 224)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(132, 27)
        Me.txtZip.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(558, 224)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(132, 27)
        Me.txtState.TabIndex = 5
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lstOut.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 20
        Me.lstOut.Location = New System.Drawing.Point(12, 364)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(796, 124)
        Me.lstOut.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(-1, 494)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 32)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.White
        Me.btnOrder.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(12, 297)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(116, 32)
        Me.btnOrder.TabIndex = 8
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(243, 494)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(116, 32)
        Me.btnMenu.TabIndex = 9
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ink Free", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(309, 152)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 39)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Order Checkout"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Ink Free", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(328, 113)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(197, 39)
        Me.lblHeading.TabIndex = 20
        Me.lblHeading.Text = "Flowers Inc."
        '
        'picFlower
        '
        Me.picFlower.Image = CType(resources.GetObject("picFlower.Image"), System.Drawing.Image)
        Me.picFlower.Location = New System.Drawing.Point(228, -5)
        Me.picFlower.Name = "picFlower"
        Me.picFlower.Size = New System.Drawing.Size(385, 116)
        Me.picFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlower.TabIndex = 21
        Me.picFlower.TabStop = False
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(26, 254)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(96, 20)
        Me.lblFirst.TabIndex = 22
        Me.lblFirst.Text = "First Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(160, 254)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(93, 20)
        Me.lblLast.TabIndex = 23
        Me.lblLast.Text = "Last Name"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(286, 254)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(128, 20)
        Me.lblStreet.TabIndex = 24
        Me.lblStreet.Text = "Street Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(459, 254)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(40, 20)
        Me.lblCity.TabIndex = 25
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(589, 254)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(54, 20)
        Me.lblState.TabIndex = 26
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(724, 254)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(74, 20)
        Me.lblZip.TabIndex = 27
        Me.lblZip.Text = "Zip Code"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(12, 341)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(130, 20)
        Me.lblSummary.TabIndex = 28
        Me.lblSummary.Text = "Order Summary"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(121, 494)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 32)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(834, 548)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.picFlower)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "Form"
        Me.Text = "Checkout"
        CType(Me.picFlower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents picFlower As PictureBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents btnClear As Button
End Class
