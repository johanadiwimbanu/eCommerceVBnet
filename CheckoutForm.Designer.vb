<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
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
        LabelTotalBiaya = New Label()
        LabelTotal = New Label()
        ButtonKonfirmasi = New Button()
        SuspendLayout()
        ' 
        ' LabelTotalBiaya
        ' 
        LabelTotalBiaya.AutoSize = True
        LabelTotalBiaya.Location = New Point(0, 0)
        LabelTotalBiaya.Name = "LabelTotalBiaya"
        LabelTotalBiaya.Size = New Size(95, 25)
        LabelTotalBiaya.TabIndex = 0
        LabelTotalBiaya.Text = "Total Biaya"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(0, 25)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(0, 25)
        LabelTotal.TabIndex = 1
        ' 
        ' ButtonKonfirmasi
        ' 
        ButtonKonfirmasi.Location = New Point(0, 100)
        ButtonKonfirmasi.Name = "ButtonKonfirmasi"
        ButtonKonfirmasi.Size = New Size(349, 34)
        ButtonKonfirmasi.TabIndex = 2
        ButtonKonfirmasi.Text = "Konfirmasi Pembayaran"
        ButtonKonfirmasi.UseVisualStyleBackColor = True
        ' 
        ' CheckoutForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonKonfirmasi)
        Controls.Add(LabelTotal)
        Controls.Add(LabelTotalBiaya)
        Name = "CheckoutForm"
        Text = "CheckoutForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTotalBiaya As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonKonfirmasi As Button
End Class
