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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonMin = New System.Windows.Forms.Button()
        Me.buttonMax = New System.Windows.Forms.Button()
        Me.buttonClos = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.buttonMin)
        Me.Panel1.Controls.Add(Me.buttonMax)
        Me.Panel1.Controls.Add(Me.buttonClos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 36)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Basic.NET.My.Resources.Resources.Basic_NET_Logo_Small
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'buttonMin
        '
        Me.buttonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonMin.FlatAppearance.BorderSize = 0
        Me.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMin.ForeColor = System.Drawing.Color.Transparent
        Me.buttonMin.Location = New System.Drawing.Point(521, 1)
        Me.buttonMin.Name = "buttonMin"
        Me.buttonMin.Size = New System.Drawing.Size(69, 35)
        Me.buttonMin.TabIndex = 3
        Me.buttonMin.Text = "▁"
        Me.buttonMin.UseVisualStyleBackColor = True
        '
        'buttonMax
        '
        Me.buttonMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonMax.FlatAppearance.BorderSize = 0
        Me.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMax.ForeColor = System.Drawing.Color.Transparent
        Me.buttonMax.Location = New System.Drawing.Point(589, 1)
        Me.buttonMax.Name = "buttonMax"
        Me.buttonMax.Size = New System.Drawing.Size(73, 35)
        Me.buttonMax.TabIndex = 2
        Me.buttonMax.Text = "▭"
        Me.buttonMax.UseVisualStyleBackColor = True
        '
        'buttonClos
        '
        Me.buttonClos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClos.FlatAppearance.BorderSize = 0
        Me.buttonClos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClos.ForeColor = System.Drawing.Color.Transparent
        Me.buttonClos.Location = New System.Drawing.Point(661, 1)
        Me.buttonClos.Name = "buttonClos"
        Me.buttonClos.Size = New System.Drawing.Size(69, 35)
        Me.buttonClos.TabIndex = 1
        Me.buttonClos.Text = "❌"
        Me.buttonClos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 543)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents buttonClos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonMin As Button
    Friend WithEvents buttonMax As Button
    Friend WithEvents Timer1 As Timer
End Class
