// Form1.cs
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace o_Mini_Cofre_de_Palavras_Passe
{
    public partial class Form1 : Form
    {
        private string chaveCorreta = "";

        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mensagem de boas-vindas e verificação da existência da chave mestra
            try
            {
                if (File.Exists("key.txt"))
                {
                    chaveCorreta = File.ReadAllText("key.txt").Trim();

                    if (string.IsNullOrWhiteSpace(chaveCorreta))
                    {
                        MessageBox.Show("The file 'key.txt' is empty. Please enter a new key.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PromptForNewKey();
                    }
                }
                else
                {
                    MessageBox.Show("The file 'key.txt' was not found! A new key will be created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PromptForNewKey();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file 'key.txt': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Carregar dados anteriores do ficheiro contas.txt
            if (File.Exists("contas.txt"))
            {
                string[] linhas = File.ReadAllLines("contas.txt");

                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3)
                    {
                        lstContas.Rows.Add(partes[0], partes[1], partes[2]);
                    }
                }
            }
        }

        // Criação e guarda da nova chave mestra
        private void PromptForNewKey()
        {
            string newKey = Microsoft.VisualBasic.Interaction.InputBox("Enter a new key:", "New Key");

            if (!string.IsNullOrWhiteSpace(newKey))
            {
                chaveCorreta = newKey.Trim();
                File.WriteAllText("key.txt", chaveCorreta);
                MessageBox.Show("Key saved successfully.");
            }
            else
            {
                MessageBox.Show("No key was entered. Some features may not work.");
            }
        }

        // Ação do botão Guardar
        private void btnSave_Click(object sender, EventArgs e)
        {
            string site = Sitetxt.Text;
            string username = txtUsername.Text;
            string password = EncryptBase64(txtPass.Text);

            if (!string.IsNullOrEmpty(site) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                lstContas.Rows.Add(site, username, password);

                // Guardar os dados da conta num ficheiro .txt
                string fileName = $"{site}.txt";
                string content = $"Site: {site}\nUsername: {username}\nPassword (Encrypted): {password}\nPassword (Decrypted): {txtPass.Text}";

                try
                {
                    File.WriteAllText(fileName, content);
                    MessageBox.Show($"Saved to file: {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Acrescentar linha ao ficheiro geral contas.txt
                    File.AppendAllText("contas.txt", $"{site};{username};{password}{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Sitetxt.Clear();
                txtUsername.Clear();
                txtPass.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Ação do botão Copiar
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstContas.CurrentRow != null)
            {
                string copiedPassword = lstContas.CurrentRow.Cells[2].Value.ToString();
                Clipboard.SetText(copiedPassword);
            }
        }

        // Filtro de pesquisa em tempo real
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtpesquisar.Text.ToLower();
            foreach (DataGridViewRow row in lstContas.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool visible = row.Cells[0].Value.ToString().ToLower().Contains(search) ||
                                   row.Cells[1].Value.ToString().ToLower().Contains(search);
                    row.Visible = visible;
                }
            }
        }

        // Mostrar password desencriptada ao clicar numa célula
        private void dgvPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string encryptedPassword = lstContas.Rows[e.RowIndex].Cells[2].Value.ToString();
                string decryptedPassword = DecryptBase64(encryptedPassword);
                MessageBox.Show($"Password: {decryptedPassword}", "Decrypted Password");
            }
        }

        // Encriptação de texto em Base64
        private string EncryptBase64(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }

        // Desencriptação de Base64 para texto normal
        private string DecryptBase64(string base64Text)
        {
            byte[] bytes = Convert.FromBase64String(base64Text);
            return Encoding.UTF8.GetString(bytes);
        }

        // Estilo visual escuro da aplicação
        private void CustomizeDesign()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(45, 45, 45);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = Color.FromArgb(50, 50, 50);
                    txt.ForeColor = Color.White;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.FromArgb(40, 40, 40);
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                }
            }
        }

        private void lstContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
