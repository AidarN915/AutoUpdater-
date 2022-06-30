namespace AutoUpdaterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkToNull(pathToAutoUpdaterTextBox)
                && checkToNull(clientIDTextBox)
                && checkToNull(clientKeyTextBox)
                && checkToNull(projectIDTextBox)
                && checkToNull(pathToDownloadTextBox)
                && checkToNull(pathToBackupsTextBox)
                && checkApi(apiAdressTextBox))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string path = saveFileDialog.FileName;
                string text = "\"" + pathToAutoUpdaterTextBox.Text + "\" "
                    + "\"" + clientIDTextBox.Text + "\" "
                    + "\"" + clientKeyTextBox.Text + "\" "
                    + "\"" + projectIDTextBox.Text + "\" "
                    + "\"" + pathToDownloadTextBox.Text + "\" \"1\" "
                    + "\"" + filesToIgnoreTextBox.Text + "\" "
                    + "\"" + pathToBackupsTextBox.Text + "\" "
                    + "\"" + apiAdressTextBox.Text + "\" \"1\" "
                    + "\"" + fileAfterUpdateTextBox.Text + "\" ";
                System.IO.File.WriteAllText(path + ".bat", text);
                MessageBox.Show("Файл сохранён");
            }
            else
            {
                MessageBox.Show("Заполните поля со звёздочкой");
            }
        }
        bool checkToNull(TextBox box){
            if (box.Text.Length > 0 && box.Text != null)
            {
                return true;
            }
            else{
                return false;
            }
        }
        bool checkApi(TextBox box)
        {
            bool flag = true;
            string http = "http";
            if(box.Text.Contains(http)){
                flag = true;
            }else{
            flag = false;
            }
            return flag && checkToNull(box);
        }

    }
}