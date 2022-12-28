namespace OverviewTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Somente letras maiúsculas
            txtNome.Text = txtNome.Text.ToUpper();

            // Não permite campo vazio
            if (txtNome.Text == "")
            {
                MessageBox.Show("Não é permitido adicionar campo vazio!");
                return;
            }
            // Add nome e data de nascimento
            ListViewItem item = new ListViewItem(txtNome.Text);
            MessageBox.Show("Usuário cadastrado com sucesso!");

            item.SubItems.Add(dtpNascimento.Text);
            listView1.Items.Add(item);
            // limpar campo após adicionar nome na lista
            txtNome.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Teste push
   

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            {
                MessageBox.Show("O REGISTRO FOI EXCLUÍDO COM SUCESSO!");
                return;
            }
        }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)

        { if (listView1.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];

                if (txtNome.Text != "")
                {
                    listView1.Items[selectedIndex].SubItems[0].Text = txtNome.Text.ToUpper();
                    listView1.Items[selectedIndex].SubItems[1].Text = dtpNascimento.Text;

                    txtNome.Clear();
                }
                else
                {
                    MessageBox.Show("Não é permitido alterar um campo vazio!");
                    return;
                }                  
            }
             
        }
    }
}