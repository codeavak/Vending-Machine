namespace drink
{
    partial class VendingMachine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtAmtCola = new System.Windows.Forms.TextBox();
            this.txtAmtCreamSoda = new System.Windows.Forms.TextBox();
            this.txtAmtGrapeSoda = new System.Windows.Forms.TextBox();
            this.txtAmtLemonLime = new System.Windows.Forms.TextBox();
            this.txtAmtRootBeer = new System.Windows.Forms.TextBox();
            this.lblColaPrice = new System.Windows.Forms.Label();
            this.lblCreamSodaPrice = new System.Windows.Forms.Label();
            this.lblGrapeSodaPrice = new System.Windows.Forms.Label();
            this.lblLemonLimePrice = new System.Windows.Forms.Label();
            this.lblRootBeerPrice = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::drink.Properties.Resources.Cola;
            this.pictureBox1.Location = new System.Drawing.Point(95, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::drink.Properties.Resources.CreamSoda;
            this.pictureBox2.Location = new System.Drawing.Point(198, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::drink.Properties.Resources.GrapeSoda;
            this.pictureBox3.Location = new System.Drawing.Point(95, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::drink.Properties.Resources.LemonLime;
            this.pictureBox4.Location = new System.Drawing.Point(198, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::drink.Properties.Resources.RootBeer;
            this.pictureBox5.Location = new System.Drawing.Point(134, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // txtAmtCola
            // 
            this.txtAmtCola.Enabled = false;
            this.txtAmtCola.Location = new System.Drawing.Point(77, 65);
            this.txtAmtCola.Name = "txtAmtCola";
            this.txtAmtCola.Size = new System.Drawing.Size(84, 22);
            this.txtAmtCola.TabIndex = 5;
            this.txtAmtCola.Tag = "1";
            // 
            // txtAmtCreamSoda
            // 
            this.txtAmtCreamSoda.Enabled = false;
            this.txtAmtCreamSoda.Location = new System.Drawing.Point(180, 65);
            this.txtAmtCreamSoda.Name = "txtAmtCreamSoda";
            this.txtAmtCreamSoda.Size = new System.Drawing.Size(84, 22);
            this.txtAmtCreamSoda.TabIndex = 6;
            this.txtAmtCreamSoda.Tag = "1.5";
            // 
            // txtAmtGrapeSoda
            // 
            this.txtAmtGrapeSoda.Enabled = false;
            this.txtAmtGrapeSoda.Location = new System.Drawing.Point(77, 183);
            this.txtAmtGrapeSoda.Name = "txtAmtGrapeSoda";
            this.txtAmtGrapeSoda.Size = new System.Drawing.Size(84, 22);
            this.txtAmtGrapeSoda.TabIndex = 7;
            this.txtAmtGrapeSoda.Tag = "1.5";
            // 
            // txtAmtLemonLime
            // 
            this.txtAmtLemonLime.Enabled = false;
            this.txtAmtLemonLime.Location = new System.Drawing.Point(180, 183);
            this.txtAmtLemonLime.Name = "txtAmtLemonLime";
            this.txtAmtLemonLime.Size = new System.Drawing.Size(84, 22);
            this.txtAmtLemonLime.TabIndex = 8;
            this.txtAmtLemonLime.Tag = "1";
            // 
            // txtAmtRootBeer
            // 
            this.txtAmtRootBeer.Enabled = false;
            this.txtAmtRootBeer.Location = new System.Drawing.Point(116, 312);
            this.txtAmtRootBeer.Name = "txtAmtRootBeer";
            this.txtAmtRootBeer.Size = new System.Drawing.Size(84, 22);
            this.txtAmtRootBeer.TabIndex = 9;
            this.txtAmtRootBeer.Tag = "1";
            // 
            // lblColaPrice
            // 
            this.lblColaPrice.AutoSize = true;
            this.lblColaPrice.Location = new System.Drawing.Point(115, 45);
            this.lblColaPrice.Name = "lblColaPrice";
            this.lblColaPrice.Size = new System.Drawing.Size(44, 17);
            this.lblColaPrice.TabIndex = 10;
            this.lblColaPrice.Text = "$1.00";
            // 
            // lblCreamSodaPrice
            // 
            this.lblCreamSodaPrice.AutoSize = true;
            this.lblCreamSodaPrice.Location = new System.Drawing.Point(220, 45);
            this.lblCreamSodaPrice.Name = "lblCreamSodaPrice";
            this.lblCreamSodaPrice.Size = new System.Drawing.Size(44, 17);
            this.lblCreamSodaPrice.TabIndex = 11;
            this.lblCreamSodaPrice.Text = "$1.50";
            // 
            // lblGrapeSodaPrice
            // 
            this.lblGrapeSodaPrice.AutoSize = true;
            this.lblGrapeSodaPrice.Location = new System.Drawing.Point(117, 163);
            this.lblGrapeSodaPrice.Name = "lblGrapeSodaPrice";
            this.lblGrapeSodaPrice.Size = new System.Drawing.Size(44, 17);
            this.lblGrapeSodaPrice.TabIndex = 12;
            this.lblGrapeSodaPrice.Text = "$1.50";
            // 
            // lblLemonLimePrice
            // 
            this.lblLemonLimePrice.AutoSize = true;
            this.lblLemonLimePrice.Location = new System.Drawing.Point(220, 163);
            this.lblLemonLimePrice.Name = "lblLemonLimePrice";
            this.lblLemonLimePrice.Size = new System.Drawing.Size(44, 17);
            this.lblLemonLimePrice.TabIndex = 13;
            this.lblLemonLimePrice.Text = "$1.00";
            // 
            // lblRootBeerPrice
            // 
            this.lblRootBeerPrice.AutoSize = true;
            this.lblRootBeerPrice.Location = new System.Drawing.Point(156, 292);
            this.lblRootBeerPrice.Name = "lblRootBeerPrice";
            this.lblRootBeerPrice.Size = new System.Drawing.Size(44, 17);
            this.lblRootBeerPrice.TabIndex = 14;
            this.lblRootBeerPrice.Text = "$1.00";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(174, 414);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(115, 419);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(60, 468);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(140, 23);
            this.btnNewUser.TabIndex = 17;
            this.btnNewUser.Text = "New Customer";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "Choose Your Beverage";
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 501);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.lblRootBeerPrice);
            this.Controls.Add(this.lblLemonLimePrice);
            this.Controls.Add(this.lblGrapeSodaPrice);
            this.Controls.Add(this.lblCreamSodaPrice);
            this.Controls.Add(this.lblColaPrice);
            this.Controls.Add(this.txtAmtRootBeer);
            this.Controls.Add(this.txtAmtLemonLime);
            this.Controls.Add(this.txtAmtGrapeSoda);
            this.Controls.Add(this.txtAmtCreamSoda);
            this.Controls.Add(this.txtAmtCola);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VendingMachine";
            this.Text = "Beverage Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtAmtCola;
        private System.Windows.Forms.TextBox txtAmtCreamSoda;
        private System.Windows.Forms.TextBox txtAmtGrapeSoda;
        private System.Windows.Forms.TextBox txtAmtLemonLime;
        private System.Windows.Forms.TextBox txtAmtRootBeer;
        private System.Windows.Forms.Label lblColaPrice;
        private System.Windows.Forms.Label lblCreamSodaPrice;
        private System.Windows.Forms.Label lblGrapeSodaPrice;
        private System.Windows.Forms.Label lblLemonLimePrice;
        private System.Windows.Forms.Label lblRootBeerPrice;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
    }
}

