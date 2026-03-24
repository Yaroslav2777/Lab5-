namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbFlavor = new System.Windows.Forms.GroupBox();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.rbPlombir = new System.Windows.Forms.RadioButton();
            this.rbFruit = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFlavor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFlavor
            // 
            this.gbFlavor.Controls.Add(this.rbVanilla);
            this.gbFlavor.Controls.Add(this.rbPlombir);
            this.gbFlavor.Controls.Add(this.rbFruit);
            this.gbFlavor.Controls.Add(this.rbChocolate);
            this.gbFlavor.Location = new System.Drawing.Point(79, 54);
            this.gbFlavor.Name = "gbFlavor";
            this.gbFlavor.Size = new System.Drawing.Size(152, 109);
            this.gbFlavor.TabIndex = 0;
            this.gbFlavor.TabStop = false;
            this.gbFlavor.Text = "Оберіть сорт морозива";
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Location = new System.Drawing.Point(6, 86);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(70, 17);
            this.rbVanilla.TabIndex = 4;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Ванільне";
            this.rbVanilla.UseVisualStyleBackColor = true;
            // 
            // rbPlombir
            // 
            this.rbPlombir.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.rbPlombir.AutoSize = true;
            this.rbPlombir.Location = new System.Drawing.Point(6, 19);
            this.rbPlombir.Name = "rbPlombir";
            this.rbPlombir.Size = new System.Drawing.Size(67, 17);
            this.rbPlombir.TabIndex = 1;
            this.rbPlombir.TabStop = true;
            this.rbPlombir.Text = "Пломбір";
            this.rbPlombir.UseVisualStyleBackColor = true;
            // 
            // rbFruit
            // 
            this.rbFruit.AutoSize = true;
            this.rbFruit.Location = new System.Drawing.Point(6, 65);
            this.rbFruit.Name = "rbFruit";
            this.rbFruit.Size = new System.Drawing.Size(76, 17);
            this.rbFruit.TabIndex = 3;
            this.rbFruit.TabStop = true;
            this.rbFruit.Text = "Фруктове";
            this.rbFruit.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(6, 42);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(82, 17);
            this.rbChocolate.TabIndex = 2;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Шоколадне";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(76, 189);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Кількість порцій";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(186, 187);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(62, 20);
            this.numQuantity.TabIndex = 2;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(286, 54);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(249, 13);
            this.lblPriceInfo.TabIndex = 3;
            this.lblPriceInfo.Text = "* При замовленні більше 20 порцій — знижка 5%";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(79, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(303, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(107, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "До сплати: 0.00 грн";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPriceInfo);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.gbFlavor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFlavor.ResumeLayout(false);
            this.gbFlavor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFlavor;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.RadioButton rbPlombir;
        private System.Windows.Forms.RadioButton rbFruit;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPriceInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

