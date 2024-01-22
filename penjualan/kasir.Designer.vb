<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kasir
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.namaUser = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.barangI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.money = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.mula = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.iduser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subttl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.change = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.idU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahBar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_ha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.struk = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "kasir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1402, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.namaUser)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1714, 81)
        Me.Panel1.TabIndex = 4
        '
        'namaUser
        '
        Me.namaUser.Enabled = False
        Me.namaUser.Location = New System.Drawing.Point(264, 50)
        Me.namaUser.Name = "namaUser"
        Me.namaUser.Size = New System.Drawing.Size(168, 20)
        Me.namaUser.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(25, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "nama kasir"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.barangI)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.stock)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(99, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 81)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Tag = "barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(206, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "id barang"
        '
        'barangI
        '
        Me.barangI.Enabled = False
        Me.barangI.Location = New System.Drawing.Point(284, 18)
        Me.barangI.Name = "barangI"
        Me.barangI.Size = New System.Drawing.Size(110, 20)
        Me.barangI.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "stock"
        '
        'stock
        '
        Me.stock.Enabled = False
        Me.stock.Location = New System.Drawing.Point(81, 43)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(110, 20)
        Me.stock.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "nama_barang"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "cari"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.total)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.harga)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.jumlah)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.nama)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(521, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 81)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Tag = "barang"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(484, 1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 77)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "submit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(307, 38)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(20, 24)
        Me.total.TabIndex = 9
        Me.total.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "harga"
        '
        'harga
        '
        Me.harga.AutoSize = True
        Me.harga.Location = New System.Drawing.Point(176, 46)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(13, 13)
        Me.harga.TabIndex = 7
        Me.harga.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "total harga"
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(81, 42)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(70, 20)
        Me.jumlah.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "jumlah barang"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Location = New System.Drawing.Point(3, 46)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(13, 13)
        Me.nama.TabIndex = 2
        Me.nama.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "nama barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "detail barang"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(330, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 77)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "submit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.subtotal)
        Me.Panel4.Location = New System.Drawing.Point(1094, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 81)
        Me.Panel4.TabIndex = 7
        Me.Panel4.Tag = "barang"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 55)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "0"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(-1, 1)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(44, 13)
        Me.subtotal.TabIndex = 0
        Me.subtotal.Text = "subtotal"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.money)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(1145, 183)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(399, 81)
        Me.Panel5.TabIndex = 6
        Me.Panel5.Tag = "barang"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 19)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'money
        '
        Me.money.Location = New System.Drawing.Point(-1, 26)
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(399, 20)
        Me.money.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(180, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "jumlah tunai"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.mula)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Location = New System.Drawing.Point(1144, 266)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(399, 60)
        Me.Panel6.TabIndex = 8
        Me.Panel6.Tag = "barang"
        '
        'mula
        '
        Me.mula.AutoSize = True
        Me.mula.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mula.Location = New System.Drawing.Point(192, 0)
        Me.mula.Name = "mula"
        Me.mula.Size = New System.Drawing.Size(51, 55)
        Me.mula.TabIndex = 10
        Me.mula.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 26)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "uang tunai"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Button5)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Location = New System.Drawing.Point(1145, 496)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(399, 82)
        Me.Panel7.TabIndex = 9
        Me.Panel7.Tag = "barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(107, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 55)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 55)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "RP"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 29)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "kembali"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1135, 616)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "submit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1342, 616)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(192, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iduser, Me.idbarang, Me.Nbarang, Me.harga_barang, Me.jumlahB, Me.total_harga, Me.subttl, Me.DS, Me.uang, Me.ttl, Me.change})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1138, 225)
        Me.DataGridView1.TabIndex = 12
        '
        'iduser
        '
        Me.iduser.HeaderText = "id_user"
        Me.iduser.Name = "iduser"
        Me.iduser.ReadOnly = True
        '
        'idbarang
        '
        Me.idbarang.HeaderText = "id_barang"
        Me.idbarang.Name = "idbarang"
        Me.idbarang.ReadOnly = True
        '
        'Nbarang
        '
        Me.Nbarang.HeaderText = "nama_barang"
        Me.Nbarang.Name = "Nbarang"
        Me.Nbarang.ReadOnly = True
        '
        'harga_barang
        '
        Me.harga_barang.HeaderText = "harga_barang"
        Me.harga_barang.Name = "harga_barang"
        Me.harga_barang.ReadOnly = True
        '
        'jumlahB
        '
        Me.jumlahB.HeaderText = "jumlah barang"
        Me.jumlahB.Name = "jumlahB"
        Me.jumlahB.ReadOnly = True
        Me.jumlahB.Width = 200
        '
        'total_harga
        '
        Me.total_harga.HeaderText = "total_harga"
        Me.total_harga.Name = "total_harga"
        Me.total_harga.ReadOnly = True
        '
        'subttl
        '
        Me.subttl.HeaderText = "subtotal"
        Me.subttl.Name = "subttl"
        Me.subttl.ReadOnly = True
        '
        'DS
        '
        Me.DS.HeaderText = "diskon"
        Me.DS.Name = "DS"
        Me.DS.ReadOnly = True
        '
        'uang
        '
        Me.uang.HeaderText = "tunai"
        Me.uang.Name = "uang"
        Me.uang.ReadOnly = True
        '
        'ttl
        '
        Me.ttl.HeaderText = "total"
        Me.ttl.Name = "ttl"
        Me.ttl.ReadOnly = True
        '
        'change
        '
        Me.change.HeaderText = "kembalian"
        Me.change.Name = "change"
        Me.change.ReadOnly = True
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.ComboBox3)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(1145, 328)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(399, 81)
        Me.Panel8.TabIndex = 14
        Me.Panel8.Tag = "barang"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"5", "10", "50"})
        Me.ComboBox3.Location = New System.Drawing.Point(-1, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(395, 21)
        Me.ComboBox3.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "diskon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "total"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Button6)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Location = New System.Drawing.Point(1144, 408)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(399, 92)
        Me.Panel9.TabIndex = 15
        Me.Panel9.Tag = "barang"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(268, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 20)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "hitung kembali"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(83, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 55)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "0"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idU, Me.idb, Me.nama_B, Me.jumlahBar, Me.hrg, Me.total_ha})
        Me.DataGridView2.Location = New System.Drawing.Point(497, 405)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(642, 155)
        Me.DataGridView2.TabIndex = 16
        '
        'idU
        '
        Me.idU.HeaderText = "id_user"
        Me.idU.Name = "idU"
        Me.idU.ReadOnly = True
        '
        'idb
        '
        Me.idb.HeaderText = "id_barang"
        Me.idb.Name = "idb"
        Me.idb.ReadOnly = True
        '
        'nama_B
        '
        Me.nama_B.HeaderText = "nama_barang"
        Me.nama_B.Name = "nama_B"
        Me.nama_B.ReadOnly = True
        '
        'jumlahBar
        '
        Me.jumlahBar.HeaderText = "jumlah_barang"
        Me.jumlahBar.Name = "jumlahBar"
        Me.jumlahBar.ReadOnly = True
        '
        'hrg
        '
        Me.hrg.HeaderText = "harga_barang"
        Me.hrg.Name = "hrg"
        Me.hrg.ReadOnly = True
        '
        'total_ha
        '
        Me.total_ha.HeaderText = "total_harga"
        Me.total_ha.Name = "total_ha"
        Me.total_ha.ReadOnly = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(927, 616)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(192, 32)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "cetak"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1556, 780)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "kasir"
        Me.Text = "kasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents nama As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents harga As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents jumlah As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents subtotal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents money As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents mula As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents namaUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents barangI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stock As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents struk As Printing.PrintDocument
    Friend WithEvents idU As DataGridViewTextBoxColumn
    Friend WithEvents idb As DataGridViewTextBoxColumn
    Friend WithEvents nama_B As DataGridViewTextBoxColumn
    Friend WithEvents jumlahBar As DataGridViewTextBoxColumn
    Friend WithEvents hrg As DataGridViewTextBoxColumn
    Friend WithEvents total_ha As DataGridViewTextBoxColumn
    Friend WithEvents iduser As DataGridViewTextBoxColumn
    Friend WithEvents idbarang As DataGridViewTextBoxColumn
    Friend WithEvents Nbarang As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlahB As DataGridViewTextBoxColumn
    Friend WithEvents total_harga As DataGridViewTextBoxColumn
    Friend WithEvents subttl As DataGridViewTextBoxColumn
    Friend WithEvents DS As DataGridViewTextBoxColumn
    Friend WithEvents uang As DataGridViewTextBoxColumn
    Friend WithEvents ttl As DataGridViewTextBoxColumn
    Friend WithEvents change As DataGridViewTextBoxColumn
End Class
