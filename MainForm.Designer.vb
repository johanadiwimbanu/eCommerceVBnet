<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Label1 = New Label()
        ComboBoxProduk = New ComboBox()
        Label2 = New Label()
        TextBoxJumlah = New TextBox()
        Label3 = New Label()
        DataGridViewKeranjang = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        ButtonTambah = New Button()
        ButtonCheckout = New Button()
        CType(DataGridViewKeranjang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ecommerce"
        ' 
        ' ComboBoxProduk
        ' 
        ComboBoxProduk.FormattingEnabled = True
        ComboBoxProduk.Location = New Point(0, 70)
        ComboBoxProduk.Name = "ComboBoxProduk"
        ComboBoxProduk.Size = New Size(182, 33)
        ComboBoxProduk.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 2
        Label2.Text = "Pilih Produk"
        ' 
        ' TextBoxJumlah
        ' 
        TextBoxJumlah.Location = New Point(0, 149)
        TextBoxJumlah.Name = "TextBoxJumlah"
        TextBoxJumlah.Size = New Size(150, 31)
        TextBoxJumlah.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 25)
        Label3.TabIndex = 4
        Label3.Text = "Jumlah Barang"
        ' 
        ' DataGridViewKeranjang
        ' 
        DataGridViewKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewKeranjang.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridViewKeranjang.Location = New Point(0, 308)
        DataGridViewKeranjang.Name = "DataGridViewKeranjang"
        DataGridViewKeranjang.RowHeadersWidth = 62
        DataGridViewKeranjang.Size = New Size(658, 225)
        DataGridViewKeranjang.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama Produk"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Jumlah"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Harga"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sub Total"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 25)
        Label4.TabIndex = 6
        Label4.Text = "Keranjang"
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.Location = New Point(0, 204)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(219, 34)
        ButtonTambah.TabIndex = 7
        ButtonTambah.Text = "Tambahkan ke keranjang"
        ButtonTambah.UseVisualStyleBackColor = True
        ' 
        ' ButtonCheckout
        ' 
        ButtonCheckout.Location = New Point(0, 539)
        ButtonCheckout.Name = "ButtonCheckout"
        ButtonCheckout.Size = New Size(112, 34)
        ButtonCheckout.TabIndex = 8
        ButtonCheckout.Text = "Checkout"
        ButtonCheckout.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 725)
        Controls.Add(ButtonCheckout)
        Controls.Add(ButtonTambah)
        Controls.Add(Label4)
        Controls.Add(DataGridViewKeranjang)
        Controls.Add(Label3)
        Controls.Add(TextBoxJumlah)
        Controls.Add(Label2)
        Controls.Add(ComboBoxProduk)
        Controls.Add(Label1)
        Name = "MainForm"
        Text = "MainForm"
        CType(DataGridViewKeranjang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxProduk As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewKeranjang As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonCheckout As Button
End Class
