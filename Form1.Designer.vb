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
        Me.BTN_GRABAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BTN_LEER_FICHERO = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BTN_ORDEN_POR_APELLIDO = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_BORRAR = New System.Windows.Forms.Button()
        Me.BTN_GUARDAR_EDICION = New System.Windows.Forms.Button()
        Me.BTN_EDITAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_GRABAR
        '
        Me.BTN_GRABAR.Location = New System.Drawing.Point(662, 12)
        Me.BTN_GRABAR.Name = "BTN_GRABAR"
        Me.BTN_GRABAR.Size = New System.Drawing.Size(126, 23)
        Me.BTN_GRABAR.TabIndex = 0
        Me.BTN_GRABAR.Text = "GRABA FICHERO"
        Me.BTN_GRABAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APELLIDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FECHA NACIMIENTO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(152, 227)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(152, 292)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 20)
        Me.TextBox4.TabIndex = 8
        '
        'BTN_LEER_FICHERO
        '
        Me.BTN_LEER_FICHERO.Location = New System.Drawing.Point(662, 41)
        Me.BTN_LEER_FICHERO.Name = "BTN_LEER_FICHERO"
        Me.BTN_LEER_FICHERO.Size = New System.Drawing.Size(126, 23)
        Me.BTN_LEER_FICHERO.TabIndex = 9
        Me.BTN_LEER_FICHERO.Text = "LEER FICHERO"
        Me.BTN_LEER_FICHERO.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(350, 87)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(287, 225)
        Me.ListBox1.TabIndex = 10
        '
        'BTN_ORDEN_POR_APELLIDO
        '
        Me.BTN_ORDEN_POR_APELLIDO.Location = New System.Drawing.Point(662, 70)
        Me.BTN_ORDEN_POR_APELLIDO.Name = "BTN_ORDEN_POR_APELLIDO"
        Me.BTN_ORDEN_POR_APELLIDO.Size = New System.Drawing.Size(126, 23)
        Me.BTN_ORDEN_POR_APELLIDO.TabIndex = 11
        Me.BTN_ORDEN_POR_APELLIDO.Text = "POR APELLIDO"
        Me.BTN_ORDEN_POR_APELLIDO.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(662, 99)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(126, 23)
        Me.BTN_BUSCAR.TabIndex = 13
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(662, 128)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(126, 23)
        Me.BTN_LIMPIAR.TabIndex = 14
        Me.BTN_LIMPIAR.Text = "LIMPIAR"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = True
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.Location = New System.Drawing.Point(662, 159)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(126, 23)
        Me.BTN_BORRAR.TabIndex = 15
        Me.BTN_BORRAR.Text = "BORRAR"
        Me.BTN_BORRAR.UseVisualStyleBackColor = True
        '
        'BTN_GUARDAR_EDICION
        '
        Me.BTN_GUARDAR_EDICION.Location = New System.Drawing.Point(350, 356)
        Me.BTN_GUARDAR_EDICION.Name = "BTN_GUARDAR_EDICION"
        Me.BTN_GUARDAR_EDICION.Size = New System.Drawing.Size(126, 23)
        Me.BTN_GUARDAR_EDICION.TabIndex = 16
        Me.BTN_GUARDAR_EDICION.Text = "GUARDAR EDICIÓN"
        Me.BTN_GUARDAR_EDICION.UseVisualStyleBackColor = True
        '
        'BTN_EDITAR
        '
        Me.BTN_EDITAR.Location = New System.Drawing.Point(511, 356)
        Me.BTN_EDITAR.Name = "BTN_EDITAR"
        Me.BTN_EDITAR.Size = New System.Drawing.Size(126, 23)
        Me.BTN_EDITAR.TabIndex = 17
        Me.BTN_EDITAR.Text = "EDITAR"
        Me.BTN_EDITAR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_EDITAR)
        Me.Controls.Add(Me.BTN_GUARDAR_EDICION)
        Me.Controls.Add(Me.BTN_BORRAR)
        Me.Controls.Add(Me.BTN_LIMPIAR)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.BTN_ORDEN_POR_APELLIDO)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BTN_LEER_FICHERO)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_GRABAR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_GRABAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BTN_LEER_FICHERO As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BTN_ORDEN_POR_APELLIDO As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents BTN_LIMPIAR As Button
    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents BTN_GUARDAR_EDICION As Button
    Friend WithEvents BTN_EDITAR As Button
End Class
