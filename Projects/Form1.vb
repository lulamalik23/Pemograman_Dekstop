Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan pilihan Fakultas
        cmbFakultas.Items.AddRange(New String() {"FMIPA", "FKIP", "FEB"})

        ' Menambahkan pilihan Jurusan
        cmbJurusan.Items.AddRange(New String() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})

        ' Set default jenis kelamin (tidak ada yang terpilih)
        rbLaki.Checked = False
        rbPerempuan.Checked = False
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi NPM (harus angka)
        If Not IsNumeric(txtNPM.Text) Then
            MessageBox.Show("NPM hanya boleh berisi angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNPM.Focus()
            Exit Sub
        End If

        ' Validasi Nama (tidak boleh kosong)
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNama.Focus()
            Exit Sub
        End If

        ' Validasi Fakultas
        If cmbFakultas.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Fakultas terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbFakultas.Focus()
            Exit Sub
        End If

        ' Validasi Jurusan
        If cmbJurusan.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Jurusan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbJurusan.Focus()
            Exit Sub
        End If

        ' Validasi Jenis Kelamin (harus dipilih)
        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki - Laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Pilih jenis kelamin terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Menampilkan MessageBox dengan format yang sesuai
        Dim message As String = "Hai : " & txtNPM.Text & vbNewLine &
                                "NPM : " & txtNama.Text & vbNewLine &
                                "Fakultas : " & cmbFakultas.SelectedItem.ToString() & vbNewLine &
                                "Jurusan : " & cmbJurusan.SelectedItem.ToString() & vbNewLine &
                                "Jenis Kelamin : " & jenisKelamin

        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
