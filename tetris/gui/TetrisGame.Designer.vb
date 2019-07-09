<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TetrisGame
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PlayMusic = New System.Windows.Forms.CheckBox()
        Me.ShapePreview1 = New Tetris_Math.ShapePreview()
        Me.game = New Tetris_Math.GameGrid()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShapePreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.game, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(383, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Silver
        Me.lblScore.Location = New System.Drawing.Point(464, 488)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(84, 26)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "000000"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(-9, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 518)
        Me.DataGridView1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Depth = 0
        Me.Button1.Location = New System.Drawing.Point(457, 526)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = True
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "New Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(321, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current Block:"
        '
        'PlayMusic
        '
        Me.PlayMusic.AutoSize = True
        Me.PlayMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayMusic.ForeColor = System.Drawing.SystemColors.Control
        Me.PlayMusic.Location = New System.Drawing.Point(470, 447)
        Me.PlayMusic.Name = "PlayMusic"
        Me.PlayMusic.Size = New System.Drawing.Size(78, 24)
        Me.PlayMusic.TabIndex = 9
        Me.PlayMusic.Text = "Music?"
        Me.PlayMusic.UseVisualStyleBackColor = True
        '
        'ShapePreview1
        '
        Me.ShapePreview1.AllowUserToAddRows = False
        Me.ShapePreview1.AllowUserToDeleteRows = False
        Me.ShapePreview1.AllowUserToResizeColumns = False
        Me.ShapePreview1.AllowUserToResizeRows = False
        Me.ShapePreview1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ShapePreview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShapePreview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShapePreview1.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ShapePreview1.DefaultCellStyle = DataGridViewCellStyle1
        Me.ShapePreview1.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ShapePreview1.Location = New System.Drawing.Point(469, 91)
        Me.ShapePreview1.Name = "ShapePreview1"
        Me.ShapePreview1.RowHeadersVisible = False
        Me.ShapePreview1.Size = New System.Drawing.Size(91, 91)
        Me.ShapePreview1.TabIndex = 1
        '
        'game
        '
        Me.game.AllowUserToAddRows = False
        Me.game.AllowUserToDeleteRows = False
        Me.game.AllowUserToResizeColumns = False
        Me.game.AllowUserToResizeRows = False
        Me.game.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.game.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.game.DefaultCellStyle = DataGridViewCellStyle2
        Me.game.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.game.Location = New System.Drawing.Point(12, 93)
        Me.game.Name = "game"
        Me.game.RowHeadersVisible = False
        Me.game.Size = New System.Drawing.Size(303, 453)
        Me.game.TabIndex = 0
        '
        'TetrisGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 561)
        Me.Controls.Add(Me.PlayMusic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapePreview1)
        Me.Controls.Add(Me.game)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "TetrisGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetris+"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShapePreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.game, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapePreview1 As ShapePreview
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PlayMusic As CheckBox
    Public WithEvents lblScore As Label
    Public WithEvents game As GameGrid
End Class
