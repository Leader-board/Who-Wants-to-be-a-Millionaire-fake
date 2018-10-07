<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumberOfQuestionsAnsweredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageTimeTakenForEachQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LifelinesUsedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeUsedUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoOfGamesPlayedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageNumberOfQuestionsAnsweredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageNumberOfPointsObtainedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageNumberOfLifelinesUsedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeUsedUpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options and Statistics"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 227)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Player"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name of player"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(232, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(38, 18)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(232, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 18)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enable experimental banked mode on Q15"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(343, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 227)
        Me.Panel2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = ":statistical option choosen:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Choose a statistical option from the menu above:-"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(378, 227)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 381
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatisticsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem, Me.SystemToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumberOfQuestionsAnsweredToolStripMenuItem, Me.AverageTimeTakenForEachQuestionToolStripMenuItem, Me.LifelinesUsedToolStripMenuItem, Me.TimeUsedUpToolStripMenuItem})
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlayerToolStripMenuItem.Text = "Player"
        '
        'NumberOfQuestionsAnsweredToolStripMenuItem
        '
        Me.NumberOfQuestionsAnsweredToolStripMenuItem.Name = "NumberOfQuestionsAnsweredToolStripMenuItem"
        Me.NumberOfQuestionsAnsweredToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.NumberOfQuestionsAnsweredToolStripMenuItem.Text = "Number of questions answered"
        '
        'AverageTimeTakenForEachQuestionToolStripMenuItem
        '
        Me.AverageTimeTakenForEachQuestionToolStripMenuItem.Name = "AverageTimeTakenForEachQuestionToolStripMenuItem"
        Me.AverageTimeTakenForEachQuestionToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.AverageTimeTakenForEachQuestionToolStripMenuItem.Text = "Average time taken for each question"
        '
        'LifelinesUsedToolStripMenuItem
        '
        Me.LifelinesUsedToolStripMenuItem.Name = "LifelinesUsedToolStripMenuItem"
        Me.LifelinesUsedToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.LifelinesUsedToolStripMenuItem.Text = "Lifelines used"
        '
        'TimeUsedUpToolStripMenuItem
        '
        Me.TimeUsedUpToolStripMenuItem.Name = "TimeUsedUpToolStripMenuItem"
        Me.TimeUsedUpToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.TimeUsedUpToolStripMenuItem.Text = "% time used up"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoOfGamesPlayedToolStripMenuItem, Me.AverageNumberOfQuestionsAnsweredToolStripMenuItem, Me.AverageNumberOfPointsObtainedToolStripMenuItem, Me.AverageNumberOfLifelinesUsedToolStripMenuItem, Me.TimeUsedUpToolStripMenuItem1})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'NoOfGamesPlayedToolStripMenuItem
        '
        Me.NoOfGamesPlayedToolStripMenuItem.Name = "NoOfGamesPlayedToolStripMenuItem"
        Me.NoOfGamesPlayedToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.NoOfGamesPlayedToolStripMenuItem.Text = "No of games played"
        '
        'AverageNumberOfQuestionsAnsweredToolStripMenuItem
        '
        Me.AverageNumberOfQuestionsAnsweredToolStripMenuItem.Name = "AverageNumberOfQuestionsAnsweredToolStripMenuItem"
        Me.AverageNumberOfQuestionsAnsweredToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.AverageNumberOfQuestionsAnsweredToolStripMenuItem.Text = "Average number of questions answered"
        '
        'AverageNumberOfPointsObtainedToolStripMenuItem
        '
        Me.AverageNumberOfPointsObtainedToolStripMenuItem.Name = "AverageNumberOfPointsObtainedToolStripMenuItem"
        Me.AverageNumberOfPointsObtainedToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.AverageNumberOfPointsObtainedToolStripMenuItem.Text = "Average number of points obtained"
        '
        'AverageNumberOfLifelinesUsedToolStripMenuItem
        '
        Me.AverageNumberOfLifelinesUsedToolStripMenuItem.Name = "AverageNumberOfLifelinesUsedToolStripMenuItem"
        Me.AverageNumberOfLifelinesUsedToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.AverageNumberOfLifelinesUsedToolStripMenuItem.Text = "Average number of lifelines used"
        '
        'TimeUsedUpToolStripMenuItem1
        '
        Me.TimeUsedUpToolStripMenuItem1.Name = "TimeUsedUpToolStripMenuItem1"
        Me.TimeUsedUpToolStripMenuItem1.Size = New System.Drawing.Size(283, 22)
        Me.TimeUsedUpToolStripMenuItem1.Text = "% time used up"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.Text = "frmOptions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumberOfQuestionsAnsweredToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageTimeTakenForEachQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LifelinesUsedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeUsedUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoOfGamesPlayedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageNumberOfQuestionsAnsweredToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageNumberOfPointsObtainedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageNumberOfLifelinesUsedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeUsedUpToolStripMenuItem1 As ToolStripMenuItem
End Class
