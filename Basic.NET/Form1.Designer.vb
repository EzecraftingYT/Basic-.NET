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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.buttonClos = New System.Windows.Forms.Button()
        Me.buttonMax = New System.Windows.Forms.Button()
        Me.buttonMin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RecentList = New System.Windows.Forms.ListBox()
        Me.CreatePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChooseFolderButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SolutionName = New System.Windows.Forms.RichTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ProjectLocation = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProjectName = New System.Windows.Forms.RichTextBox()
        Me.ChooseFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.CreatePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
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
        'Panel1
        '
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
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Button3)
        Me.MainPanel.Controls.Add(Me.Button2)
        Me.MainPanel.Controls.Add(Me.RecentList)
        Me.MainPanel.Location = New System.Drawing.Point(0, 36)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(730, 524)
        Me.MainPanel.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button3.Location = New System.Drawing.Point(415, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 56)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Create New Project"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button2.Location = New System.Drawing.Point(415, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Open Project"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RecentList
        '
        Me.RecentList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecentList.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RecentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecentList.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.RecentList.ForeColor = System.Drawing.Color.White
        Me.RecentList.FormattingEnabled = True
        Me.RecentList.ItemHeight = 32
        Me.RecentList.Items.AddRange(New Object() {"Project1", "Project2", "Project3", "Project4", "Project5", "Project6", "Project7", "Project8", "Project9", "Project10", "Project11", "Project12"})
        Me.RecentList.Location = New System.Drawing.Point(46, 58)
        Me.RecentList.Name = "RecentList"
        Me.RecentList.Size = New System.Drawing.Size(288, 418)
        Me.RecentList.TabIndex = 5
        '
        'CreatePanel
        '
        Me.CreatePanel.Controls.Add(Me.Panel2)
        Me.CreatePanel.Controls.Add(Me.Label2)
        Me.CreatePanel.Controls.Add(Me.Label1)
        Me.CreatePanel.Controls.Add(Me.ListBox1)
        Me.CreatePanel.Location = New System.Drawing.Point(0, 36)
        Me.CreatePanel.Name = "CreatePanel"
        Me.CreatePanel.Size = New System.Drawing.Size(733, 524)
        Me.CreatePanel.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(46, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 28)
        Me.Panel2.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 5)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(262, 20)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Create Project"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Leelawadee UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 28
        Me.ListBox1.Location = New System.Drawing.Point(406, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(256, 394)
        Me.ListBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.ChooseFolderButton)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 524)
        Me.Panel3.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Leelawadee UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(451, 476)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 37)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(589, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChooseFolderButton
        '
        Me.ChooseFolderButton.FlatAppearance.BorderSize = 0
        Me.ChooseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseFolderButton.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseFolderButton.Location = New System.Drawing.Point(333, 235)
        Me.ChooseFolderButton.Name = "ChooseFolderButton"
        Me.ChooseFolderButton.Size = New System.Drawing.Size(102, 28)
        Me.ChooseFolderButton.TabIndex = 9
        Me.ChooseFolderButton.Text = "Choose..."
        Me.ChooseFolderButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Solution Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Project Location"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.SolutionName)
        Me.Panel6.Location = New System.Drawing.Point(58, 328)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(269, 28)
        Me.Panel6.TabIndex = 7
        '
        'SolutionName
        '
        Me.SolutionName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SolutionName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SolutionName.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolutionName.ForeColor = System.Drawing.Color.White
        Me.SolutionName.Location = New System.Drawing.Point(6, 5)
        Me.SolutionName.Multiline = False
        Me.SolutionName.Name = "SolutionName"
        Me.SolutionName.Size = New System.Drawing.Size(262, 20)
        Me.SolutionName.TabIndex = 1
        Me.SolutionName.Text = ""
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ProjectLocation)
        Me.Panel5.Location = New System.Drawing.Point(58, 235)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(269, 28)
        Me.Panel5.TabIndex = 7
        '
        'ProjectLocation
        '
        Me.ProjectLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProjectLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjectLocation.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectLocation.ForeColor = System.Drawing.Color.White
        Me.ProjectLocation.Location = New System.Drawing.Point(6, 5)
        Me.ProjectLocation.Multiline = False
        Me.ProjectLocation.Name = "ProjectLocation"
        Me.ProjectLocation.Size = New System.Drawing.Size(262, 20)
        Me.ProjectLocation.TabIndex = 1
        Me.ProjectLocation.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Project Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ProjectName)
        Me.Panel4.Location = New System.Drawing.Point(58, 138)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(269, 28)
        Me.Panel4.TabIndex = 5
        '
        'ProjectName
        '
        Me.ProjectName.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjectName.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectName.ForeColor = System.Drawing.Color.White
        Me.ProjectName.Location = New System.Drawing.Point(6, 5)
        Me.ProjectName.Multiline = False
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(262, 20)
        Me.ProjectName.TabIndex = 1
        Me.ProjectName.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CreatePanel)
        Me.Controls.Add(Me.MainPanel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.CreatePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents buttonClos As Button
    Friend WithEvents buttonMax As Button
    Friend WithEvents buttonMin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RecentList As ListBox
    Friend WithEvents CreatePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChooseFolderButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SolutionName As RichTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ProjectLocation As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ProjectName As RichTextBox
    Friend WithEvents ChooseFolderDialog As FolderBrowserDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
