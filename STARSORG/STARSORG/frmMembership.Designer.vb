<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembership
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
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.lvwMembers = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpMemInfo = New System.Windows.Forms.GroupBox()
        Me.btnNewMem = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.grpMembers.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.btnModify)
        Me.grpMembers.Controls.Add(Me.btnNewMem)
        Me.grpMembers.Controls.Add(Me.lvwMembers)
        Me.grpMembers.Location = New System.Drawing.Point(24, 12)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(290, 556)
        Me.grpMembers.TabIndex = 0
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Members"
        '
        'lvwMembers
        '
        Me.lvwMembers.HideSelection = False
        Me.lvwMembers.Location = New System.Drawing.Point(0, 25)
        Me.lvwMembers.Name = "lvwMembers"
        Me.lvwMembers.Size = New System.Drawing.Size(288, 473)
        Me.lvwMembers.TabIndex = 0
        Me.lvwMembers.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(337, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 188)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpMemInfo
        '
        Me.grpMemInfo.BackColor = System.Drawing.SystemColors.Control
        Me.grpMemInfo.Location = New System.Drawing.Point(335, 220)
        Me.grpMemInfo.Name = "grpMemInfo"
        Me.grpMemInfo.Size = New System.Drawing.Size(668, 344)
        Me.grpMemInfo.TabIndex = 2
        Me.grpMemInfo.TabStop = False
        Me.grpMemInfo.Text = "Member Information "
        '
        'btnNewMem
        '
        Me.btnNewMem.Location = New System.Drawing.Point(6, 504)
        Me.btnNewMem.Name = "btnNewMem"
        Me.btnNewMem.Size = New System.Drawing.Size(109, 46)
        Me.btnNewMem.TabIndex = 1
        Me.btnNewMem.Text = "New"
        Me.btnNewMem.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(175, 504)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(109, 46)
        Me.btnModify.TabIndex = 2
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.txtSearchBox)
        Me.grpSearch.Controls.Add(Me.ComboBox1)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Location = New System.Drawing.Point(585, 17)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(417, 182)
        Me.grpSearch.TabIndex = 3
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(141, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(232, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Location = New System.Drawing.Point(140, 100)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(233, 26)
        Me.txtSearchBox.TabIndex = 3
        '
        'frmMembership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 576)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpMemInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpMembers)
        Me.Name = "frmMembership"
        Me.Text = "Membership"
        Me.grpMembers.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents lvwMembers As ListView
    Friend WithEvents btnModify As Button
    Friend WithEvents btnNewMem As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpMemInfo As GroupBox
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
