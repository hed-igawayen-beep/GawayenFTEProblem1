<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtArtistName = New System.Windows.Forms.TextBox()
        Me.txtArtworkTitle = New System.Windows.Forms.TextBox()
        Me.txtArtworkPrice = New System.Windows.Forms.TextBox()
        Me.cmbArtworkCategory = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtArtistName
        '
        Me.txtArtistName.Location = New System.Drawing.Point(406, 63)
        Me.txtArtistName.Name = "txtArtistName"
        Me.txtArtistName.Size = New System.Drawing.Size(100, 20)
        Me.txtArtistName.TabIndex = 0
        '
        'txtArtworkTitle
        '
        Me.txtArtworkTitle.Location = New System.Drawing.Point(252, 63)
        Me.txtArtworkTitle.Name = "txtArtworkTitle"
        Me.txtArtworkTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtArtworkTitle.TabIndex = 1
        '
        'txtArtworkPrice
        '
        Me.txtArtworkPrice.Location = New System.Drawing.Point(329, 142)
        Me.txtArtworkPrice.Name = "txtArtworkPrice"
        Me.txtArtworkPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtArtworkPrice.TabIndex = 2
        '
        'cmbArtworkCategory
        '
        Me.cmbArtworkCategory.FormattingEnabled = True
        Me.cmbArtworkCategory.Location = New System.Drawing.Point(320, 216)
        Me.cmbArtworkCategory.Name = "cmbArtworkCategory"
        Me.cmbArtworkCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbArtworkCategory.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(252, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Artwork"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Artwork Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Artist Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Category"
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(342, 273)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(87, 25)
        Me.btnAnalyze.TabIndex = 9
        Me.btnAnalyze.Text = "Analyze Exhibit"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(450, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 25)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.FormattingEnabled = True
        Me.Output.Location = New System.Drawing.Point(242, 325)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(305, 95)
        Me.Output.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbArtworkCategory)
        Me.Controls.Add(Me.txtArtworkPrice)
        Me.Controls.Add(Me.txtArtworkTitle)
        Me.Controls.Add(Me.txtArtistName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtistName As TextBox
    Friend WithEvents txtArtworkTitle As TextBox
    Friend WithEvents txtArtworkPrice As TextBox
    Friend WithEvents cmbArtworkCategory As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Output As ListBox
End Class
