<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.YourScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PlayAgain = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.payerHighscore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YourScore
        '
        Me.YourScore.AutoSize = True
        Me.YourScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.YourScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourScore.ForeColor = System.Drawing.Color.Gainsboro
        Me.YourScore.Location = New System.Drawing.Point(485, 220)
        Me.YourScore.Name = "YourScore"
        Me.YourScore.Size = New System.Drawing.Size(84, 26)
        Me.YourScore.TabIndex = 5
        Me.YourScore.Text = "000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(355, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Your score:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(-15, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(839, 518)
        Me.DataGridView1.TabIndex = 6
        '
        'PlayAgain
        '
        Me.PlayAgain.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PlayAgain.Depth = 0
        Me.PlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.PlayAgain.FlatAppearance.BorderSize = 2
        Me.PlayAgain.Location = New System.Drawing.Point(658, 399)
        Me.PlayAgain.MouseState = MaterialSkin.MouseState.HOVER
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Primary = True
        Me.PlayAgain.Size = New System.Drawing.Size(143, 52)
        Me.PlayAgain.TabIndex = 0
        Me.PlayAgain.Text = "Play again?"
        Me.PlayAgain.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(647, 390)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(154, 10)
        Me.DataGridView2.TabIndex = 7
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.DataGridView3.Location = New System.Drawing.Point(649, 391)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(10, 60)
        Me.DataGridView3.TabIndex = 8
        '
        'payerHighscore
        '
        Me.payerHighscore.AutoSize = True
        Me.payerHighscore.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.payerHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payerHighscore.ForeColor = System.Drawing.Color.Gainsboro
        Me.payerHighscore.Location = New System.Drawing.Point(485, 194)
        Me.payerHighscore.Name = "payerHighscore"
        Me.payerHighscore.Size = New System.Drawing.Size(84, 26)
        Me.payerHighscore.TabIndex = 10
        Me.payerHighscore.Text = "000000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(308, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Your high score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(673, 52)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "After some hard math questions, I am sorry to say that you lose." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you would li" &
    "ke to play again, then click on the ""Play again?"" button."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tetris_Math.My.Resources.Resources.Blue_Screen_of_Death
        Me.PictureBox1.Location = New System.Drawing.Point(0, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 387)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.payerHighscore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.YourScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "GameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameOver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YourScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PlayAgain As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents payerHighscore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
