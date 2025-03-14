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
        Me.txtNPM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNPM
        '
        Me.txtNPM.Location = New System.Drawing.Point(254, 12)
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.Size = New System.Drawing.Size(202, 26)
        Me.txtNPM.TabIndex = 0
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(254, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(202, 26)
        Me.txtNama.TabIndex = 1
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Location = New System.Drawing.Point(254, 165)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(255, 28)
        Me.cmbFakultas.TabIndex = 2
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(254, 207)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(255, 28)
        Me.cmbJurusan.TabIndex = 3
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(51, 360)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(95, 37)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jurusan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama"
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(192, 113)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(85, 24)
        Me.rblaki.TabIndex = 9
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "laki-laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(341, 113)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(115, 24)
        Me.rbperempuan.TabIndex = 10
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "jenis kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nilai"
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(314, 274)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(80, 26)
        Me.txtTugas.TabIndex = 13
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(486, 274)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(80, 26)
        Me.txtUTS.TabIndex = 14
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(665, 274)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(80, 26)
        Me.txtUAS.TabIndex = 15
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(791, 274)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(86, 26)
        Me.txtGrade.TabIndex = 16
        Me.txtGrade.Text = "-GRADE-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tugas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(421, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "UTS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(603, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "UAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 444)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNPM)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNPM As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
