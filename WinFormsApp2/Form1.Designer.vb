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
        Me.Lweli = New System.Windows.Forms.Label()
        Me.Lsab = New System.Windows.Forms.Label()
        Me.Llik = New System.Windows.Forms.Label()
        Me.Lvada = New System.Windows.Forms.Label()
        Me.Vlik = New System.Windows.Forms.TextBox()
        Me.Vweli = New System.Windows.Forms.TextBox()
        Me.Vvada = New System.Windows.Forms.TextBox()
        Me.Vsab = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGsia = New System.Windows.Forms.DataGridView()
        CType(Me.DGsia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lweli
        '
        Me.Lweli.AutoSize = True
        Me.Lweli.Location = New System.Drawing.Point(48, 40)
        Me.Lweli.Name = "Lweli"
        Me.Lweli.Size = New System.Drawing.Size(41, 15)
        Me.Lweli.TabIndex = 0
        Me.Lweli.Text = "წელი"
        '
        'Lsab
        '
        Me.Lsab.AutoSize = True
        Me.Lsab.Location = New System.Drawing.Point(105, 40)
        Me.Lsab.Name = "Lsab"
        Me.Lsab.Size = New System.Drawing.Size(158, 15)
        Me.Lsab.TabIndex = 0
        Me.Lsab.Text = "საბალანსო ღირებულება"
        '
        'Llik
        '
        Me.Llik.AutoSize = True
        Me.Llik.Location = New System.Drawing.Point(260, 40)
        Me.Llik.Name = "Llik"
        Me.Llik.Size = New System.Drawing.Size(182, 15)
        Me.Llik.TabIndex = 0
        Me.Llik.Text = "სალიკვიდაციო ღირებულება"
        '
        'Lvada
        '
        Me.Lvada.AutoSize = True
        Me.Lvada.Location = New System.Drawing.Point(448, 40)
        Me.Lvada.Name = "Lvada"
        Me.Lvada.Size = New System.Drawing.Size(136, 15)
        Me.Lvada.TabIndex = 0
        Me.Lvada.Text = "ექსპლუატაციის ვადა"
        '
        'Vlik
        '
        Me.Vlik.Location = New System.Drawing.Point(299, 121)
        Me.Vlik.Name = "Vlik"
        Me.Vlik.Size = New System.Drawing.Size(100, 23)
        Me.Vlik.TabIndex = 1
        '
        'Vweli
        '
        Me.Vweli.Location = New System.Drawing.Point(42, 121)
        Me.Vweli.Name = "Vweli"
        Me.Vweli.Size = New System.Drawing.Size(100, 23)
        Me.Vweli.TabIndex = 1
        '
        'Vvada
        '
        Me.Vvada.Location = New System.Drawing.Point(434, 121)
        Me.Vvada.Name = "Vvada"
        Me.Vvada.Size = New System.Drawing.Size(100, 23)
        Me.Vvada.TabIndex = 1
        '
        'Vsab
        '
        Me.Vsab.Location = New System.Drawing.Point(177, 121)
        Me.Vsab.Name = "Vsab"
        Me.Vsab.Size = New System.Drawing.Size(100, 23)
        Me.Vsab.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(635, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 104)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "გაანგარიშება"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGsia
        '
        Me.DGsia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGsia.Location = New System.Drawing.Point(42, 273)
        Me.DGsia.Name = "DGsia"
        Me.DGsia.RowTemplate.Height = 25
        Me.DGsia.Size = New System.Drawing.Size(746, 150)
        Me.DGsia.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGsia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Vsab)
        Me.Controls.Add(Me.Vvada)
        Me.Controls.Add(Me.Vweli)
        Me.Controls.Add(Me.Vlik)
        Me.Controls.Add(Me.Lvada)
        Me.Controls.Add(Me.Llik)
        Me.Controls.Add(Me.Lsab)
        Me.Controls.Add(Me.Lweli)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGsia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lweli As Label
    Friend WithEvents Lsab As Label
    Friend WithEvents Llik As Label
    Friend WithEvents Lvada As Label
    Friend WithEvents Vlik As TextBox
    Friend WithEvents Vweli As TextBox
    Friend WithEvents Vvada As TextBox
    Friend WithEvents Vsab As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DGsia As DataGridView
End Class
