using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitmapAddition.Extensions;

namespace BitmapAddition
{
    unsafe public partial class MainForm : Form
    {
        private Bitmap sourceImage1;
        private Bitmap sourceImage2;

        private Bitmap result;


        public MainForm()
        {
            InitializeComponent();
        }

        private void openSourceImage1Button_Click(object sender, EventArgs e)
        {
            if (openSourceDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = (Bitmap) Bitmap.FromFile(openSourceDialog.FileName);

                if (sourceImage2 != null && bitmap.Height == sourceImage2.Height && bitmap.Width == sourceImage2.Width)
                {
                    sourceImage1 = bitmap;
                    pictureBoxSource1.Image = sourceImage1;
                }
                else if (sourceImage2 != null && (bitmap.Height != sourceImage2.Height || bitmap.Width != sourceImage2.Width))
                {
                    MessageBox.Show("Obrazki muszą mieć jednakowe wymiary!");
                }
                else if (sourceImage2 == null)
                {
                    sourceImage1 = bitmap;
                    pictureBoxSource1.Image = sourceImage1;
                } 
            }
        }

        private void openSourceImage2Button_Click(object sender, EventArgs e)
        {
            if (openSourceDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromFile(openSourceDialog.FileName);

                if (sourceImage1 != null && bitmap.Height == sourceImage1.Height && bitmap.Width == sourceImage1.Width)
                {
                    sourceImage2 = bitmap;
                    pictureBoxSource2.Image = sourceImage2;
                }
                else if (sourceImage1 != null && (bitmap.Height != sourceImage1.Height || bitmap.Width != sourceImage1.Width))
                {
                    MessageBox.Show("Obrazki muszą mieć jednakowe wymiary!");
                }
                else if (sourceImage1 == null)
                {
                    sourceImage2 = bitmap;
                    pictureBoxSource2.Image = sourceImage2;
                }
            }
        }

        private void addImagesButton_Click(object sender, EventArgs e)
        {
            if (sourceImage1 != null && sourceImage2 != null)
            {
                int weight = trackBarWeightSource1.Value;
                bool revertNormalizationByFirstImage = radioButtonReverNormalizationByImage1.Checked;

                result = BitmapAdditionDllManager.AddImages(sourceImage1, sourceImage2, weight, revertNormalizationByFirstImage);

                pictureBoxResult.Image = result;
            }
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            if (result != null && saveResultDialog.ShowDialog() == DialogResult.OK)
            {
                result.Save(saveResultDialog.FileName);
            }
        }

        private void clearImage1_Click(object sender, EventArgs e)
        {
            sourceImage1 = null;
            pictureBoxSource1.Image = null;
        }

        private void clearImage2_Click(object sender, EventArgs e)
        {
            sourceImage2 = null;
            pictureBoxSource2.Image = null;
        }

        private void trackBarWeightSource2_Scroll(object sender, EventArgs e)
        {
            trackBarWeightSource1.Value = trackBarWeightSource1.Maximum - trackBarWeightSource2.Value;
            source2WeightLabel.Text = $"Waga: {trackBarWeightSource2.Value}";
            source1WeightLabel.Text = $"Waga: {trackBarWeightSource1.Value}";
        }

        private void trackBarWeightSource1_Scroll(object sender, EventArgs e)
        {
            trackBarWeightSource2.Value = trackBarWeightSource2.Maximum - trackBarWeightSource1.Value;
            source1WeightLabel.Text = $"Waga: {trackBarWeightSource1.Value}";
            source2WeightLabel.Text = $"Waga: {trackBarWeightSource2.Value}";
        }
    }
}
