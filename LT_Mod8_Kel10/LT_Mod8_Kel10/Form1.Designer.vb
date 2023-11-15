<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnConvert = New Button()
        txtInput = New TextBox()
        cmbFrom = New ComboBox()
        cmbTo = New ComboBox()
        txtOutput = New TextBox()
        btnClear = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(407, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 2
        Label1.Text = "Konversi Suhu"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(613, 305)
        btnConvert.Margin = New Padding(3, 4, 3, 4)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(99, 31)
        btnConvert.TabIndex = 3
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(354, 143)
        txtInput.Margin = New Padding(3, 4, 3, 4)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(215, 27)
        txtInput.TabIndex = 4
        ' 
        ' cmbFrom
        ' 
        cmbFrom.FormattingEnabled = True
        cmbFrom.Location = New Point(222, 205)
        cmbFrom.Margin = New Padding(3, 4, 3, 4)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(215, 28)
        cmbFrom.TabIndex = 5
        ' 
        ' cmbTo
        ' 
        cmbTo.FormattingEnabled = True
        cmbTo.Location = New Point(497, 205)
        cmbTo.Margin = New Padding(3, 4, 3, 4)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(215, 28)
        cmbTo.TabIndex = 8
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(354, 277)
        txtOutput.Margin = New Padding(3, 4, 3, 4)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(215, 27)
        txtOutput.TabIndex = 7
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(613, 344)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(99, 31)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(166, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 9
        Label2.Text = "From"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(452, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 20)
        Label3.TabIndex = 10
        Label3.Text = "To"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(184, 451)
        Label4.Name = "Label4"
        Label4.Size = New Size(239, 20)
        Label4.TabIndex = 11
        Label4.Text = "Kel10 : Dapa, Iqbal, Dimas, Foresto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(434, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 20)
        Label5.TabIndex = 12
        Label5.Text = "Input"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(434, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 13
        Label6.Text = "Output"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmbTo)
        Controls.Add(txtOutput)
        Controls.Add(btnClear)
        Controls.Add(cmbFrom)
        Controls.Add(txtInput)
        Controls.Add(btnConvert)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Tugas_Mod8_Kel10"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
