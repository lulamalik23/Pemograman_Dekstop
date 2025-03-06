Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan pilihan Fakultas
        cmbFakultas.Items.AddRange(New String() {"FMIPA", "FKIP", "FEB"})

        ' Menambahkan pilihan Jurusan
        cmbJurusan.Items.AddRange(New String() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})

        ' Mengisi data langsung ke dalam form
        txtNIP.Text = "2307051011"
        txtNama.Text = "Lula Malikatul Fajri"
        cmbFakultas.SelectedItem = "FMIPA"
        cmbJurusan.SelectedItem = "Ilmu Komputer"
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi NIP (harus angka)
        If Not IsNumeric(txtNIP.Text) Then
            MessageBox.Show("NIP hanya boleh berisi angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNIP.Focus()
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

        ' Menampilkan MessageBox dengan data yang telah diinput
        Dim message As String = "Hai : " & txtNIP.Text & vbNewLine &
                                "NIP : " & txtNIP.Text & vbNewLine &
                                "Nama : " & txtNama.Text & vbNewLine &
                                "Fakultas : " & cmbFakultas.SelectedItem.ToString() & vbNewLine &
                                "Jurusan : " & cmbJurusan.SelectedItem.ToString()

        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
