using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabFilters
{
    public partial class Form1 : Form
    {

        Bitmap image;
        Stack<Bitmap> imageHistory = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаём диалог для открытия файла
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void ApplyFilter(Filters filter)
        {
            if (image != null)
            {
                imageHistory.Push((Bitmap)image.Clone());
            }

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new InvertFilter());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new BlurFilter());

        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GaussianFilter());
        }

        private void чёрнобелоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GrayScaleFilter());
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sepia());
        }

        private void яркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Brightness());
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SobelFilter());
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpness());
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Embossing());
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new MedianFilter());
        }

        private void влевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Left());
        }

        private void направоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Right());
        }

        private void противЧасовойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateLeft());
        }

        private void поЧасовойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateRight());
        }

        private void поГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new WavesG());
        }

        private void поВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new WavesV());
        }

        private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Glass());
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new MotionBlur());
        }

        private void сФРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SFSharpness());
        }

        private void выдГраницЩарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new OperatorSharra());
        }

        private void выдГраницПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new OperatorPruitta());
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.png)|*.png";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет изображения", "Ошибка",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void отменаДействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageHistory.Count > 0)
            {
                image = imageHistory.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Нет действий для отмены.");
            }
        }
    }
}
