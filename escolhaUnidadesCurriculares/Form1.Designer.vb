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
        Me.lblEscolhaUCs = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.listBoxUCs = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'lblEscolhaUCs
        '
        Me.lblEscolhaUCs.AutoSize = True
        Me.lblEscolhaUCs.Location = New System.Drawing.Point(46, 27)
        Me.lblEscolhaUCs.Name = "lblEscolhaUCs"
        Me.lblEscolhaUCs.Size = New System.Drawing.Size(168, 13)
        Me.lblEscolhaUCs.TabIndex = 0
        Me.lblEscolhaUCs.Text = "Escolha as Unidades Curriculares:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(49, 156)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(165, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'listBoxUCs
        '
        Me.listBoxUCs.BackColor = System.Drawing.SystemColors.MenuBar
        Me.listBoxUCs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBoxUCs.CheckOnClick = True
        Me.listBoxUCs.FormattingEnabled = True
        Me.listBoxUCs.Items.AddRange(New Object() {"Programação Desktop", "Lógica de Programação", "Banco de Dados", "Informática Básica", "Programação Web"})
        Me.listBoxUCs.Location = New System.Drawing.Point(49, 60)
        Me.listBoxUCs.Name = "listBoxUCs"
        Me.listBoxUCs.Size = New System.Drawing.Size(164, 90)
        Me.listBoxUCs.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 214)
        Me.Controls.Add(Me.listBoxUCs)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblEscolhaUCs)
        Me.Name = "Form1"
        Me.Text = "Seleção de UC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEscolhaUCs As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents listBoxUCs As System.Windows.Forms.CheckedListBox

End Class
