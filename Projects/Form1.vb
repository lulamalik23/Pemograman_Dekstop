Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan item ke dalam ComboBox Fakultas
        cmbFakultas.Items.Add("FMIPA")
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FEB")

        ' Menambahkan item ke dalam ComboBox Jurusan
        cmbJurusan.Items.Add("Matematika")
        cmbJurusan.Items.Add("Kimia")
        cmbJurusan.Items.Add("Biologi")
        cmbJurusan.Items.Add("Fisika")
        cmbJurusan.Items.Add("Ilmu Komputer")
    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNPM.KeyPress
        ' Hanya memperbolehkan angka di NIP
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi input tidak boleh kosong
        If txtNPM.Text = "" OrElse txtNama.Text = "" OrElse cmbFakultas.SelectedIndex = -1 OrElse cmbJurusan.SelectedIndex = -1 Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pilih jenis kelamin dari RadioButton
        Dim jenisKelamin As String = ""
        If rblaki.Checked Then
            jenisKelamin = "Laki-laki"
        ElseIf rbperempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi input nilai tidak boleh kosong
        If txtTugas.Text = "" Or txtUTS.Text = "" Or txtUAS.Text = "" Then
            MessageBox.Show("Harap isi semua nilai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengubah input nilai dari TextBox ke tipe angka
        Dim tugas, uts, uas, nilaiAkhir As Double
        If Not Double.TryParse(txtTugas.Text, tugas) OrElse Not Double.TryParse(txtUTS.Text, uts) OrElse Not Double.TryParse(txtUAS.Text, uas) Then
            MessageBox.Show("Masukkan nilai yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Menghitung nilai akhir berdasarkan bobot
        nilaiAkhir = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        ' Menentukan GRADE
        Dim grade As String
        Select Case nilaiAkhir
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

        ' TAMPILAN MessageBox
        Dim message As String = "Hai : " & txtNPM.Text & vbCrLf &
                                "Nip : " & txtNama.Text & vbCrLf &
                                "Fakultas : " & cmbFakultas.SelectedItem.ToString() & vbCrLf &
                                "Jurusan : " & cmbJurusan.SelectedItem.ToString() & vbCrLf &
                                "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                                "Nilai Akhir : " & nilaiAkhir.ToString("0.00") & vbCrLf &
                                "GRADE : " & grade

        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class