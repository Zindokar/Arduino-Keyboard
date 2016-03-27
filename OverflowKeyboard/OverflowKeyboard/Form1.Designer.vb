<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textoCom = New System.Windows.Forms.Label()
        Me.comPortList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.profileList = New System.Windows.Forms.ComboBox()
        Me.addProfile = New System.Windows.Forms.Button()
        Me.c01 = New System.Windows.Forms.TextBox()
        Me.c02 = New System.Windows.Forms.TextBox()
        Me.c03 = New System.Windows.Forms.TextBox()
        Me.c04 = New System.Windows.Forms.TextBox()
        Me.b01 = New System.Windows.Forms.TextBox()
        Me.b02 = New System.Windows.Forms.TextBox()
        Me.b03 = New System.Windows.Forms.TextBox()
        Me.b04 = New System.Windows.Forms.TextBox()
        Me.msg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OverflowKeyboard.My.Resources.Resources.teclado
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'textoCom
        '
        Me.textoCom.AutoSize = True
        Me.textoCom.Location = New System.Drawing.Point(9, 10)
        Me.textoCom.Name = "textoCom"
        Me.textoCom.Size = New System.Drawing.Size(196, 13)
        Me.textoCom.TabIndex = 2
        Me.textoCom.Text = "Elige el puerto COM asociado al teclado"
        '
        'comPortList
        '
        Me.comPortList.FormattingEnabled = True
        Me.comPortList.Location = New System.Drawing.Point(12, 26)
        Me.comPortList.Name = "comPortList"
        Me.comPortList.Size = New System.Drawing.Size(193, 21)
        Me.comPortList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Perfil"
        '
        'profileList
        '
        Me.profileList.FormattingEnabled = True
        Me.profileList.Location = New System.Drawing.Point(309, 25)
        Me.profileList.Name = "profileList"
        Me.profileList.Size = New System.Drawing.Size(121, 21)
        Me.profileList.TabIndex = 5
        '
        'addProfile
        '
        Me.addProfile.Location = New System.Drawing.Point(437, 25)
        Me.addProfile.Name = "addProfile"
        Me.addProfile.Size = New System.Drawing.Size(25, 21)
        Me.addProfile.TabIndex = 6
        Me.addProfile.Text = "+"
        Me.addProfile.UseVisualStyleBackColor = True
        '
        'c01
        '
        Me.c01.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.c01.Location = New System.Drawing.Point(15, 95)
        Me.c01.Name = "c01"
        Me.c01.Size = New System.Drawing.Size(100, 20)
        Me.c01.TabIndex = 7
        Me.c01.Text = "q"
        Me.c01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c02
        '
        Me.c02.Location = New System.Drawing.Point(125, 95)
        Me.c02.Name = "c02"
        Me.c02.Size = New System.Drawing.Size(100, 20)
        Me.c02.TabIndex = 8
        Me.c02.Text = "w"
        Me.c02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c03
        '
        Me.c03.Location = New System.Drawing.Point(235, 95)
        Me.c03.Name = "c03"
        Me.c03.Size = New System.Drawing.Size(100, 20)
        Me.c03.TabIndex = 9
        Me.c03.Text = "e"
        Me.c03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c04
        '
        Me.c04.Location = New System.Drawing.Point(348, 95)
        Me.c04.Name = "c04"
        Me.c04.Size = New System.Drawing.Size(100, 20)
        Me.c04.TabIndex = 10
        Me.c04.Text = "r"
        Me.c04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b01
        '
        Me.b01.Location = New System.Drawing.Point(15, 180)
        Me.b01.Name = "b01"
        Me.b01.Size = New System.Drawing.Size(100, 20)
        Me.b01.TabIndex = 11
        Me.b01.Text = "d"
        Me.b01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b02
        '
        Me.b02.Location = New System.Drawing.Point(125, 180)
        Me.b02.Name = "b02"
        Me.b02.Size = New System.Drawing.Size(100, 20)
        Me.b02.TabIndex = 12
        Me.b02.Text = "f"
        Me.b02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b03
        '
        Me.b03.Location = New System.Drawing.Point(235, 180)
        Me.b03.Name = "b03"
        Me.b03.Size = New System.Drawing.Size(100, 20)
        Me.b03.TabIndex = 13
        Me.b03.Text = "3"
        Me.b03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b04
        '
        Me.b04.Location = New System.Drawing.Point(348, 180)
        Me.b04.Name = "b04"
        Me.b04.Size = New System.Drawing.Size(100, 20)
        Me.b04.TabIndex = 14
        Me.b04.Text = "4"
        Me.b04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Location = New System.Drawing.Point(211, 29)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(69, 13)
        Me.msg.TabIndex = 15
        Me.msg.Text = "A la espera..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 255)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.b04)
        Me.Controls.Add(Me.b03)
        Me.Controls.Add(Me.b02)
        Me.Controls.Add(Me.b01)
        Me.Controls.Add(Me.c04)
        Me.Controls.Add(Me.c03)
        Me.Controls.Add(Me.c02)
        Me.Controls.Add(Me.c01)
        Me.Controls.Add(Me.addProfile)
        Me.Controls.Add(Me.profileList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comPortList)
        Me.Controls.Add(Me.textoCom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "OverflowKeyboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textoCom As Label
    Friend WithEvents comPortList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents profileList As ComboBox
    Friend WithEvents addProfile As Button
    Friend WithEvents c01 As TextBox
    Friend WithEvents c02 As TextBox
    Friend WithEvents c03 As TextBox
    Friend WithEvents c04 As TextBox
    Friend WithEvents b01 As TextBox
    Friend WithEvents b02 As TextBox
    Friend WithEvents b03 As TextBox
    Friend WithEvents b04 As TextBox
    Friend WithEvents msg As Label
End Class
