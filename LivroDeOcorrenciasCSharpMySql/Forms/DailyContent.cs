using LivroDeOcorrenciasCSharpMySql.Connections;
using LivroDeOcorrenciasCSharpMySql.Infos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    public partial class DailyContent : Form
    {
        ConnectionInfo connectionInfo = new ConnectionInfo();
        Essential essential = new Essential();

        string shift = string.Empty;
        public DailyContent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pictureBox1;
            OpenNewImage(pictureBox);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pictureBox2;
            OpenNewImage(pictureBox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pictureBox3;
            OpenNewImage(pictureBox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pictureBox4;
            OpenNewImage(pictureBox);
        }
        private void endButton_Click(object sender, EventArgs e)
        {
            if(SaveAndEnd())
            {
                SaveDailyContent();
            }
        }
        private void clearImagesButton_Click(object sender, EventArgs e)
        {
            ClearImages();
        }

        public void HeaderText()
        {
            headerLabel.Text = $"{essential.LoadInfoToUse()}, {essential.GetDateToUse()}, turno {essential.GetShiftToUse()}.";

            shift = essential.GetShiftToUse();
        }

        void OpenNewImage(PictureBox pictureBox)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = openFileDialog1.FileName;
                    string extension = Path.GetExtension(sourceFilePath);

                    string targetFolderPath = Path.GetFullPath(
                        @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\temp\");
                    //Path.Combine(Application.StartupPath, "Imgs"); usar esse no código final :D

                    if (!Directory.Exists(targetFolderPath))
                    {
                        Directory.CreateDirectory(targetFolderPath);
                    }

                    string dateTimeNow = DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss");
                    string fileName = $"Img_{dateTimeNow}{extension}";

                    string targetFilePath = Path.Combine(targetFolderPath, fileName);

                    if (!Directory.Exists(targetFilePath))
                    {
                        File.Copy(sourceFilePath, targetFilePath, true);
                    }

                    pictureBox.Image = Image.FromFile(targetFilePath);
                    pictureBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                }
            }
        }

        void ClearImages()
        {
            string defaultImage = Path.GetFullPath(
                @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\GreenEye.png");

            PictureBox[] pictureBoxes = [pictureBox1, pictureBox2, pictureBox3, pictureBox4];

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            DeleteTempImages();

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Image = Image.FromFile(defaultImage);
                pictureBox.Enabled = true;
            }
        }

        void DeleteTempImages()
        {
            try
            {
                string targetFolderPath = Path.GetFullPath(
                    @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\temp\");
                if (Directory.Exists(targetFolderPath))
                {
                    string[] files = Directory.GetFiles(targetFolderPath);

                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }
                }
                else
                {
                    MessageBox.Show("A pasta não existe!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar os arquivos: {ex.Message}");
            }
        }

        void SaveDailyContent()
        {
            //movendo as imagens para a pasta principal e salvando o caminho delas no banco de dados
            try
            {
                //move as imagens para a pasta correta
                string sourceFolderPath = Path.GetFullPath(
                    @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\temp\");

                string dateNow = DateTime.Now.ToString("dd-MM-yyyy");

                string destinationFolderPath = Path.GetFullPath(
                    @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\" + dateNow + "_" + shift);

                string[] pathToSave = new string[4];
                PictureBox[] pictureBoxes = [pictureBox1, pictureBox2, pictureBox3, pictureBox4];
                string defaultImage = Path.GetFullPath(
                @"D:\Gabriel Leite\Green Eye Dev\Livro de Ocorrências\livrodeocorrencias\LivroDeOcorrencias\LivroDeOcorrenciasCSharpMySql\Imgs\GreenEye.png");

                for(int i = 0; i < pathToSave.Length; i++)
                {
                    if (string.IsNullOrEmpty(pathToSave[i]))
                    {
                        pathToSave[i] = defaultImage;
                    }
                }

                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                if(Directory.Exists(sourceFolderPath))
                {
                    string[] files = Directory.GetFiles(sourceFolderPath);
                    

                    for (int i = 0; i < files.Length; i++)
                    {
                        string fileName = Path.GetFileName(files[i]);
                        string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
                        
                        pathToSave[i] = destinationFilePath;

                        pictureBoxes[i].Image.Dispose();
                        pictureBoxes[i].Image = null;

                        File.Move(files[i], destinationFilePath);

                        pictureBoxes[i].Image = Image.FromFile(defaultImage);
                        pictureBoxes[i].Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("A pasta de origem não existe.");
                }

                //cargo, primeiro nome, data, turno, conteúdo
                string position = essential.LoadInfoToUse().Split(' ')[0];
                string firstName = essential.LoadInfoToUse().Split(' ')[1];
                string date = essential.GetDateToUse();
                string actualShift = shift;
                string contentText = contentTextBox.Text;

                //banco de dados
                using (MySqlConnection connection = new MySqlConnection(connectionInfo.MySqlConnectionString()))
                {
                    try
                    {
                        connection.Open();

                        string query = $"INSERT INTO daily (position, firstName, date, shift, content, image1path, image2path, image3path, image4path) " +
                        $"VALUES (@Position, @FirstName, @Date, @Shift, @Content, @Img1, @Img2, @Img3, @Img4)";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Shift", actualShift);
                        command.Parameters.AddWithValue("@Content", contentText);
                        command.Parameters.AddWithValue("@Img1", pathToSave[0]);
                        command.Parameters.AddWithValue("@Img2", pathToSave[1]);
                        command.Parameters.AddWithValue("@Img3", pathToSave[2]);
                        command.Parameters.AddWithValue("@Img4", pathToSave[3]);

                        command.ExecuteNonQuery();

                        MessageBox.Show($"{position} {firstName}, {date}, turno {actualShift}.\n\nConteúdo: {contentText}.\n" +
                            $"\nPrimeira Imagem: {pathToSave[0]}\n\nSegunda Imagem: {pathToSave[1]}\n\nTerceira Imagem: {pathToSave[2]}\n\nQuarta Imagem: {pathToSave[3]}");
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show($"DataBase Error: {sqlEx.Message}");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return;
                    }
                }
                    //depois de tudo, fecha a página do livro
                    Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }
        bool SaveAndEnd()
        {
            DialogResult result = MessageBox.Show("Deseja finalizar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
    }
}