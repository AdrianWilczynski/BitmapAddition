namespace BitmapAddition
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSource1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSource2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.openSourceImage1Button = new System.Windows.Forms.Button();
            this.openSourceImage2Button = new System.Windows.Forms.Button();
            this.addImagesButton = new System.Windows.Forms.Button();
            this.openSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveResultDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.clearImage1 = new System.Windows.Forms.Button();
            this.clearImage2 = new System.Windows.Forms.Button();
            this.trackBarWeightSource1 = new System.Windows.Forms.TrackBar();
            this.trackBarWeightSource2 = new System.Windows.Forms.TrackBar();
            this.source1WeightLabel = new System.Windows.Forms.Label();
            this.source2WeightLabel = new System.Windows.Forms.Label();
            this.radioButtonReverNormalizationByImage1 = new System.Windows.Forms.RadioButton();
            this.radioButtonReverNormalizationByImage2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWeightSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWeightSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSource1
            // 
            this.pictureBoxSource1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSource1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSource1.Name = "pictureBoxSource1";
            this.pictureBoxSource1.Size = new System.Drawing.Size(300, 292);
            this.pictureBoxSource1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource1.TabIndex = 0;
            this.pictureBoxSource1.TabStop = false;
            // 
            // pictureBoxSource2
            // 
            this.pictureBoxSource2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSource2.Location = new System.Drawing.Point(318, 12);
            this.pictureBoxSource2.Name = "pictureBoxSource2";
            this.pictureBoxSource2.Size = new System.Drawing.Size(300, 292);
            this.pictureBoxSource2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource2.TabIndex = 1;
            this.pictureBoxSource2.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(624, 12);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(300, 292);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            // 
            // openSourceImage1Button
            // 
            this.openSourceImage1Button.Location = new System.Drawing.Point(12, 310);
            this.openSourceImage1Button.Name = "openSourceImage1Button";
            this.openSourceImage1Button.Size = new System.Drawing.Size(300, 23);
            this.openSourceImage1Button.TabIndex = 4;
            this.openSourceImage1Button.Text = "Otwórz pierwszy obrazek";
            this.openSourceImage1Button.UseVisualStyleBackColor = true;
            this.openSourceImage1Button.Click += new System.EventHandler(this.openSourceImage1Button_Click);
            // 
            // openSourceImage2Button
            // 
            this.openSourceImage2Button.Location = new System.Drawing.Point(318, 310);
            this.openSourceImage2Button.Name = "openSourceImage2Button";
            this.openSourceImage2Button.Size = new System.Drawing.Size(300, 23);
            this.openSourceImage2Button.TabIndex = 5;
            this.openSourceImage2Button.Text = "Otwórz drugi obrazek";
            this.openSourceImage2Button.UseVisualStyleBackColor = true;
            this.openSourceImage2Button.Click += new System.EventHandler(this.openSourceImage2Button_Click);
            // 
            // addImagesButton
            // 
            this.addImagesButton.Location = new System.Drawing.Point(624, 310);
            this.addImagesButton.Name = "addImagesButton";
            this.addImagesButton.Size = new System.Drawing.Size(300, 23);
            this.addImagesButton.TabIndex = 6;
            this.addImagesButton.Text = "Dodaj obrazki";
            this.addImagesButton.UseVisualStyleBackColor = true;
            this.addImagesButton.Click += new System.EventHandler(this.addImagesButton_Click);
            // 
            // openSourceDialog
            // 
            this.openSourceDialog.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
            // 
            // saveResultDialog
            // 
            this.saveResultDialog.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(624, 334);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(300, 23);
            this.saveResultButton.TabIndex = 7;
            this.saveResultButton.Text = "Zapisz wynik dodawania";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // clearImage1
            // 
            this.clearImage1.Location = new System.Drawing.Point(12, 334);
            this.clearImage1.Name = "clearImage1";
            this.clearImage1.Size = new System.Drawing.Size(300, 23);
            this.clearImage1.TabIndex = 8;
            this.clearImage1.Text = "Wyczyść";
            this.clearImage1.UseVisualStyleBackColor = true;
            this.clearImage1.Click += new System.EventHandler(this.clearImage1_Click);
            // 
            // clearImage2
            // 
            this.clearImage2.Location = new System.Drawing.Point(318, 334);
            this.clearImage2.Name = "clearImage2";
            this.clearImage2.Size = new System.Drawing.Size(300, 23);
            this.clearImage2.TabIndex = 9;
            this.clearImage2.Text = "Wyczyść";
            this.clearImage2.UseVisualStyleBackColor = true;
            this.clearImage2.Click += new System.EventHandler(this.clearImage2_Click);
            // 
            // trackBarWeightSource1
            // 
            this.trackBarWeightSource1.Location = new System.Drawing.Point(12, 363);
            this.trackBarWeightSource1.Maximum = 100;
            this.trackBarWeightSource1.Name = "trackBarWeightSource1";
            this.trackBarWeightSource1.Size = new System.Drawing.Size(300, 45);
            this.trackBarWeightSource1.TabIndex = 25;
            this.trackBarWeightSource1.TickFrequency = 10;
            this.trackBarWeightSource1.Value = 50;
            this.trackBarWeightSource1.Scroll += new System.EventHandler(this.trackBarWeightSource1_Scroll);
            // 
            // trackBarWeightSource2
            // 
            this.trackBarWeightSource2.Location = new System.Drawing.Point(318, 363);
            this.trackBarWeightSource2.Maximum = 100;
            this.trackBarWeightSource2.Name = "trackBarWeightSource2";
            this.trackBarWeightSource2.Size = new System.Drawing.Size(300, 45);
            this.trackBarWeightSource2.TabIndex = 11;
            this.trackBarWeightSource2.TickFrequency = 10;
            this.trackBarWeightSource2.Value = 50;
            this.trackBarWeightSource2.Scroll += new System.EventHandler(this.trackBarWeightSource2_Scroll);
            // 
            // source1WeightLabel
            // 
            this.source1WeightLabel.AutoSize = true;
            this.source1WeightLabel.Location = new System.Drawing.Point(138, 395);
            this.source1WeightLabel.Name = "source1WeightLabel";
            this.source1WeightLabel.Size = new System.Drawing.Size(54, 13);
            this.source1WeightLabel.TabIndex = 26;
            this.source1WeightLabel.Text = "Waga: 50";
            // 
            // source2WeightLabel
            // 
            this.source2WeightLabel.AutoSize = true;
            this.source2WeightLabel.Location = new System.Drawing.Point(444, 395);
            this.source2WeightLabel.Name = "source2WeightLabel";
            this.source2WeightLabel.Size = new System.Drawing.Size(54, 13);
            this.source2WeightLabel.TabIndex = 27;
            this.source2WeightLabel.Text = "Waga: 50";
            // 
            // radioButtonReverNormalizationByImage1
            // 
            this.radioButtonReverNormalizationByImage1.AutoSize = true;
            this.radioButtonReverNormalizationByImage1.Checked = true;
            this.radioButtonReverNormalizationByImage1.Location = new System.Drawing.Point(624, 368);
            this.radioButtonReverNormalizationByImage1.Name = "radioButtonReverNormalizationByImage1";
            this.radioButtonReverNormalizationByImage1.Size = new System.Drawing.Size(270, 17);
            this.radioButtonReverNormalizationByImage1.TabIndex = 28;
            this.radioButtonReverNormalizationByImage1.TabStop = true;
            this.radioButtonReverNormalizationByImage1.Text = "Odwróć normalizację względem pierwszego obrazka";
            this.radioButtonReverNormalizationByImage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonReverNormalizationByImage2
            // 
            this.radioButtonReverNormalizationByImage2.AutoSize = true;
            this.radioButtonReverNormalizationByImage2.Location = new System.Drawing.Point(624, 391);
            this.radioButtonReverNormalizationByImage2.Name = "radioButtonReverNormalizationByImage2";
            this.radioButtonReverNormalizationByImage2.Size = new System.Drawing.Size(258, 17);
            this.radioButtonReverNormalizationByImage2.TabIndex = 29;
            this.radioButtonReverNormalizationByImage2.Text = "Odwróć normalizację względem drugiego obrazka";
            this.radioButtonReverNormalizationByImage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 420);
            this.Controls.Add(this.radioButtonReverNormalizationByImage2);
            this.Controls.Add(this.radioButtonReverNormalizationByImage1);
            this.Controls.Add(this.source2WeightLabel);
            this.Controls.Add(this.source1WeightLabel);
            this.Controls.Add(this.trackBarWeightSource2);
            this.Controls.Add(this.trackBarWeightSource1);
            this.Controls.Add(this.clearImage2);
            this.Controls.Add(this.clearImage1);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.addImagesButton);
            this.Controls.Add(this.openSourceImage2Button);
            this.Controls.Add(this.openSourceImage1Button);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxSource2);
            this.Controls.Add(this.pictureBoxSource1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dodaj obrazki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWeightSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWeightSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSource1;
        private System.Windows.Forms.PictureBox pictureBoxSource2;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button openSourceImage1Button;
        private System.Windows.Forms.Button openSourceImage2Button;
        private System.Windows.Forms.Button addImagesButton;
        private System.Windows.Forms.OpenFileDialog openSourceDialog;
        private System.Windows.Forms.SaveFileDialog saveResultDialog;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button clearImage1;
        private System.Windows.Forms.Button clearImage2;
        private System.Windows.Forms.TrackBar trackBarWeightSource1;
        private System.Windows.Forms.TrackBar trackBarWeightSource2;
        private System.Windows.Forms.Label source1WeightLabel;
        private System.Windows.Forms.Label source2WeightLabel;
        private System.Windows.Forms.RadioButton radioButtonReverNormalizationByImage1;
        private System.Windows.Forms.RadioButton radioButtonReverNormalizationByImage2;
    }
}

