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
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.BTNExtractHTML = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TBSearchKeyword = New System.Windows.Forms.TextBox()
        Me.TBNumValue = New System.Windows.Forms.TextBox()
        Me.TBStartValue = New System.Windows.Forms.TextBox()
        Me.EmailDomain = New System.Windows.Forms.TextBox()
        Me.TBHtmlSourceCode = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBEmails = New System.Windows.Forms.Label()
        Me.RBGmail = New System.Windows.Forms.RadioButton()
        Me.RBYahoo = New System.Windows.Forms.RadioButton()
        Me.RBHotmail = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSearch
        '
        Me.BTNSearch.Location = New System.Drawing.Point(156, 138)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.Size = New System.Drawing.Size(75, 23)
        Me.BTNSearch.TabIndex = 0
        Me.BTNSearch.Text = "Search"
        Me.BTNSearch.UseVisualStyleBackColor = True
        '
        'BTNExtractHTML
        '
        Me.BTNExtractHTML.Location = New System.Drawing.Point(379, 247)
        Me.BTNExtractHTML.Name = "BTNExtractHTML"
        Me.BTNExtractHTML.Size = New System.Drawing.Size(128, 87)
        Me.BTNExtractHTML.TabIndex = 1
        Me.BTNExtractHTML.Text = "Extract HTML code from site"
        Me.BTNExtractHTML.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(379, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TBSearchKeyword
        '
        Me.TBSearchKeyword.Location = New System.Drawing.Point(71, 31)
        Me.TBSearchKeyword.Name = "TBSearchKeyword"
        Me.TBSearchKeyword.Size = New System.Drawing.Size(308, 20)
        Me.TBSearchKeyword.TabIndex = 3
        '
        'TBNumValue
        '
        Me.TBNumValue.Location = New System.Drawing.Point(408, 131)
        Me.TBNumValue.Name = "TBNumValue"
        Me.TBNumValue.Size = New System.Drawing.Size(46, 20)
        Me.TBNumValue.TabIndex = 4
        '
        'TBStartValue
        '
        Me.TBStartValue.Location = New System.Drawing.Point(408, 69)
        Me.TBStartValue.Name = "TBStartValue"
        Me.TBStartValue.Size = New System.Drawing.Size(46, 20)
        Me.TBStartValue.TabIndex = 5
        '
        'EmailDomain
        '
        Me.EmailDomain.Location = New System.Drawing.Point(71, 69)
        Me.EmailDomain.Name = "EmailDomain"
        Me.EmailDomain.Size = New System.Drawing.Size(194, 20)
        Me.EmailDomain.TabIndex = 7
        '
        'TBHtmlSourceCode
        '
        Me.TBHtmlSourceCode.Location = New System.Drawing.Point(71, 203)
        Me.TBHtmlSourceCode.Multiline = True
        Me.TBHtmlSourceCode.Name = "TBHtmlSourceCode"
        Me.TBHtmlSourceCode.Size = New System.Drawing.Size(281, 131)
        Me.TBHtmlSourceCode.TabIndex = 8
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(71, 366)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(281, 238)
        Me.ListBox1.TabIndex = 9
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(534, 20)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(605, 613)
        Me.WebBrowser1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Index"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Results"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Page"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 491)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Emails"
        '
        'LBEmails
        '
        Me.LBEmails.AutoSize = True
        Me.LBEmails.Location = New System.Drawing.Point(436, 491)
        Me.LBEmails.Name = "LBEmails"
        Me.LBEmails.Size = New System.Drawing.Size(13, 13)
        Me.LBEmails.TabIndex = 16
        Me.LBEmails.Text = "0"
        '
        'RBGmail
        '
        Me.RBGmail.AutoSize = True
        Me.RBGmail.Location = New System.Drawing.Point(71, 95)
        Me.RBGmail.Name = "RBGmail"
        Me.RBGmail.Size = New System.Drawing.Size(51, 17)
        Me.RBGmail.TabIndex = 17
        Me.RBGmail.TabStop = True
        Me.RBGmail.Text = "Gmail"
        Me.RBGmail.UseVisualStyleBackColor = True
        '
        'RBYahoo
        '
        Me.RBYahoo.AutoSize = True
        Me.RBYahoo.Location = New System.Drawing.Point(273, 72)
        Me.RBYahoo.Name = "RBYahoo"
        Me.RBYahoo.Size = New System.Drawing.Size(88, 17)
        Me.RBYahoo.TabIndex = 18
        Me.RBYahoo.TabStop = True
        Me.RBYahoo.Text = "other Domain"
        Me.RBYahoo.UseVisualStyleBackColor = True
        '
        'RBHotmail
        '
        Me.RBHotmail.AutoSize = True
        Me.RBHotmail.Location = New System.Drawing.Point(139, 95)
        Me.RBHotmail.Name = "RBHotmail"
        Me.RBHotmail.Size = New System.Drawing.Size(60, 17)
        Me.RBHotmail.TabIndex = 19
        Me.RBHotmail.TabStop = True
        Me.RBHotmail.Text = "Hotmail"
        Me.RBHotmail.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(71, 138)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown1.TabIndex = 20
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(221, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Match Domain"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 645)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.RBHotmail)
        Me.Controls.Add(Me.RBYahoo)
        Me.Controls.Add(Me.RBGmail)
        Me.Controls.Add(Me.LBEmails)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TBHtmlSourceCode)
        Me.Controls.Add(Me.EmailDomain)
        Me.Controls.Add(Me.TBStartValue)
        Me.Controls.Add(Me.TBNumValue)
        Me.Controls.Add(Me.TBSearchKeyword)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BTNExtractHTML)
        Me.Controls.Add(Me.BTNSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSearch As Button
    Friend WithEvents BTNExtractHTML As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TBSearchKeyword As TextBox
    Friend WithEvents TBNumValue As TextBox
    Friend WithEvents TBStartValue As TextBox
    Friend WithEvents EmailDomain As TextBox
    Friend WithEvents TBHtmlSourceCode As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBEmails As Label
    Friend WithEvents RBGmail As RadioButton
    Friend WithEvents RBYahoo As RadioButton
    Friend WithEvents RBHotmail As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CheckBox1 As CheckBox
End Class
