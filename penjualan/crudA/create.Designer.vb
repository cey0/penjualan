<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UN = New System.Windows.Forms.TextBox()
        Me.PW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RL = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(542, 99)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "username"
        '
        'UN
        '
        Me.UN.Location = New System.Drawing.Point(83, 142)
        Me.UN.Name = "UN"
        Me.UN.Size = New System.Drawing.Size(110, 20)
        Me.UN.TabIndex = 2
        '
        'PW
        '
        Me.PW.Location = New System.Drawing.Point(83, 181)
        Me.PW.Name = "PW"
        Me.PW.Size = New System.Drawing.Size(110, 20)
        Me.PW.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "password"
        '
        'NM
        '
        Me.NM.Location = New System.Drawing.Point(281, 142)
        Me.NM.Name = "NM"
        Me.NM.Size = New System.Drawing.Size(110, 20)
        Me.NM.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "role"
        '
        'RL
        '
        Me.RL.FormattingEnabled = True
        Me.RL.Items.AddRange(New Object() {"admin", "kasir"})
        Me.RL.Location = New System.Drawing.Point(280, 180)
        Me.RL.Name = "RL"
        Me.RL.Size = New System.Drawing.Size(111, 21)
        Me.RL.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 98)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(583, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 228)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "create"
        Me.Text = "create"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents UN As TextBox
    Friend WithEvents PW As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RL As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
