namespace CFinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            showSandwichCategories = new Label();
            pictureOfSandwichs = new PictureBox();
            pictureOfADrink = new PictureBox();
            showDessertsCategories = new Label();
            showSidesCategories = new Label();
            showDrinksCategories = new Label();
            pictureOfSides = new PictureBox();
            pictureOfDeserts = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureOfSandwichs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfADrink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfSides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfDeserts).BeginInit();
            SuspendLayout();
            // 
            // showSandwichCategories
            // 
            showSandwichCategories.AutoSize = true;
            showSandwichCategories.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            showSandwichCategories.Location = new Point(857, 324);
            showSandwichCategories.Margin = new Padding(5, 0, 5, 0);
            showSandwichCategories.Name = "showSandwichCategories";
            showSandwichCategories.Size = new Size(138, 31);
            showSandwichCategories.TabIndex = 17;
            showSandwichCategories.Text = "Sandwichs";
            showSandwichCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureOfSandwichs
            // 
            pictureOfSandwichs.Image = Properties.Resources.R__1_;
            pictureOfSandwichs.Location = new Point(742, 27);
            pictureOfSandwichs.Margin = new Padding(5, 4, 5, 4);
            pictureOfSandwichs.Name = "pictureOfSandwichs";
            pictureOfSandwichs.Size = new Size(356, 293);
            pictureOfSandwichs.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfSandwichs.TabIndex = 16;
            pictureOfSandwichs.TabStop = false;
            // 
            // pictureOfADrink
            // 
            pictureOfADrink.Image = (Image)resources.GetObject("pictureOfADrink.Image");
            pictureOfADrink.Location = new Point(71, 430);
            pictureOfADrink.Margin = new Padding(5, 4, 5, 4);
            pictureOfADrink.Name = "pictureOfADrink";
            pictureOfADrink.Size = new Size(356, 293);
            pictureOfADrink.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfADrink.TabIndex = 10;
            pictureOfADrink.TabStop = false;
            // 
            // showDessertsCategories
            // 
            showDessertsCategories.AutoSize = true;
            showDessertsCategories.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            showDessertsCategories.Location = new Point(1562, 727);
            showDessertsCategories.Margin = new Padding(5, 0, 5, 0);
            showDessertsCategories.Name = "showDessertsCategories";
            showDessertsCategories.Size = new Size(112, 31);
            showDessertsCategories.TabIndex = 15;
            showDessertsCategories.Text = "Desserts";
            showDessertsCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showSidesCategories
            // 
            showSidesCategories.AutoSize = true;
            showSidesCategories.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            showSidesCategories.Location = new Point(880, 727);
            showSidesCategories.Margin = new Padding(5, 0, 5, 0);
            showSidesCategories.Name = "showSidesCategories";
            showSidesCategories.Size = new Size(75, 31);
            showSidesCategories.TabIndex = 14;
            showSidesCategories.Text = "Sides";
            showSidesCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showDrinksCategories
            // 
            showDrinksCategories.Anchor = AnchorStyles.None;
            showDrinksCategories.AutoSize = true;
            showDrinksCategories.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            showDrinksCategories.Location = new Point(197, 727);
            showDrinksCategories.Margin = new Padding(5, 0, 5, 0);
            showDrinksCategories.Name = "showDrinksCategories";
            showDrinksCategories.Size = new Size(95, 31);
            showDrinksCategories.TabIndex = 13;
            showDrinksCategories.Text = "Drinks";
            showDrinksCategories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureOfSides
            // 
            pictureOfSides.Image = Properties.Resources.e70ae65e5d0287429522e1fd57177309;
            pictureOfSides.Location = new Point(742, 430);
            pictureOfSides.Margin = new Padding(5, 4, 5, 4);
            pictureOfSides.Name = "pictureOfSides";
            pictureOfSides.Size = new Size(356, 293);
            pictureOfSides.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfSides.TabIndex = 12;
            pictureOfSides.TabStop = false;
            pictureOfSides.Click += pictureOfSides_Click;
            // 
            // pictureOfDeserts
            // 
            pictureOfDeserts.Image = Properties.Resources.Healthy_Chocolate_Peanut_Butter_Raw_Cheesecake8_3;
            pictureOfDeserts.Location = new Point(1432, 430);
            pictureOfDeserts.Margin = new Padding(5, 4, 5, 4);
            pictureOfDeserts.Name = "pictureOfDeserts";
            pictureOfDeserts.Size = new Size(356, 293);
            pictureOfDeserts.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfDeserts.TabIndex = 11;
            pictureOfDeserts.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1858, 785);
            Controls.Add(showSandwichCategories);
            Controls.Add(pictureOfSandwichs);
            Controls.Add(pictureOfADrink);
            Controls.Add(showDessertsCategories);
            Controls.Add(showSidesCategories);
            Controls.Add(showDrinksCategories);
            Controls.Add(pictureOfSides);
            Controls.Add(pictureOfDeserts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureOfSandwichs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfADrink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfSides).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOfDeserts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showSandwichCategories;
        private PictureBox pictureOfSandwichs;
        private PictureBox pictureOfADrink;
        private Label showDessertsCategories;
        private Label showSidesCategories;
        private Label showDrinksCategories;
        private PictureBox pictureOfSides;
        private PictureBox pictureOfDeserts;
    }
}