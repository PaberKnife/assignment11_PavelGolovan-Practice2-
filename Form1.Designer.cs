namespace assignment11_PavelGolovan_Practice2_
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
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.driveGroupBox = new System.Windows.Forms.GroupBox();
            this.carLabel = new System.Windows.Forms.Label();
            this.kmhLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedPictureBox = new System.Windows.Forms.PictureBox();
            this.brakePictureBox = new System.Windows.Forms.PictureBox();
            this.gasPictureBox = new System.Windows.Forms.PictureBox();
            this.carGroupBox.SuspendLayout();
            this.driveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeTextBox.Location = new System.Drawing.Point(88, 36);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(191, 34);
            this.makeTextBox.TabIndex = 0;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(88, 85);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(191, 34);
            this.yearTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(12, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(15, 39);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(67, 28);
            this.makeLabel.TabIndex = 7;
            this.makeLabel.Text = "Make:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(15, 88);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(56, 28);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(this.createButton);
            this.carGroupBox.Controls.Add(this.makeTextBox);
            this.carGroupBox.Controls.Add(this.yearTextBox);
            this.carGroupBox.Controls.Add(this.yearLabel);
            this.carGroupBox.Controls.Add(this.makeLabel);
            this.carGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carGroupBox.Location = new System.Drawing.Point(12, 12);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(294, 187);
            this.carGroupBox.TabIndex = 10;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Your Car";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(20, 134);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(259, 38);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // driveGroupBox
            // 
            this.driveGroupBox.Controls.Add(this.carLabel);
            this.driveGroupBox.Controls.Add(this.kmhLabel);
            this.driveGroupBox.Controls.Add(this.speedLabel);
            this.driveGroupBox.Controls.Add(this.speedPictureBox);
            this.driveGroupBox.Controls.Add(this.brakePictureBox);
            this.driveGroupBox.Controls.Add(this.gasPictureBox);
            this.driveGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.driveGroupBox.Location = new System.Drawing.Point(312, 18);
            this.driveGroupBox.Name = "driveGroupBox";
            this.driveGroupBox.Size = new System.Drawing.Size(300, 411);
            this.driveGroupBox.TabIndex = 11;
            this.driveGroupBox.TabStop = false;
            // 
            // carLabel
            // 
            this.carLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carLabel.Location = new System.Drawing.Point(22, 161);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(256, 34);
            this.carLabel.TabIndex = 9;
            this.carLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kmhLabel
            // 
            this.kmhLabel.BackColor = System.Drawing.Color.Silver;
            this.kmhLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.kmhLabel.ForeColor = System.Drawing.Color.Purple;
            this.kmhLabel.Location = new System.Drawing.Point(163, 43);
            this.kmhLabel.Name = "kmhLabel";
            this.kmhLabel.Size = new System.Drawing.Size(102, 82);
            this.kmhLabel.TabIndex = 8;
            this.kmhLabel.Text = "km/h";
            this.kmhLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.Silver;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 45F, System.Drawing.FontStyle.Bold);
            this.speedLabel.ForeColor = System.Drawing.Color.Purple;
            this.speedLabel.Location = new System.Drawing.Point(35, 43);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(136, 82);
            this.speedLabel.TabIndex = 7;
            this.speedLabel.Text = "0";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // speedPictureBox
            // 
            this.speedPictureBox.Image = global::assignment11_PavelGolovan_Practice2_.Properties.Resources.speedometer;
            this.speedPictureBox.Location = new System.Drawing.Point(22, 21);
            this.speedPictureBox.Name = "speedPictureBox";
            this.speedPictureBox.Size = new System.Drawing.Size(256, 128);
            this.speedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speedPictureBox.TabIndex = 6;
            this.speedPictureBox.TabStop = false;
            // 
            // brakePictureBox
            // 
            this.brakePictureBox.Image = global::assignment11_PavelGolovan_Practice2_.Properties.Resources.brake;
            this.brakePictureBox.Location = new System.Drawing.Point(83, 268);
            this.brakePictureBox.Name = "brakePictureBox";
            this.brakePictureBox.Size = new System.Drawing.Size(64, 128);
            this.brakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brakePictureBox.TabIndex = 5;
            this.brakePictureBox.TabStop = false;
            this.brakePictureBox.Click += new System.EventHandler(this.brakePictureBox_Click);
            // 
            // gasPictureBox
            // 
            this.gasPictureBox.Image = global::assignment11_PavelGolovan_Practice2_.Properties.Resources.gas;
            this.gasPictureBox.Location = new System.Drawing.Point(153, 268);
            this.gasPictureBox.Name = "gasPictureBox";
            this.gasPictureBox.Size = new System.Drawing.Size(64, 128);
            this.gasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gasPictureBox.TabIndex = 4;
            this.gasPictureBox.TabStop = false;
            this.gasPictureBox.Click += new System.EventHandler(this.gasPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.driveGroupBox);
            this.Controls.Add(this.carGroupBox);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Car Class";
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            this.driveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brakePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox gasPictureBox;
        private System.Windows.Forms.PictureBox brakePictureBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.GroupBox carGroupBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox driveGroupBox;
        private System.Windows.Forms.PictureBox speedPictureBox;
        private System.Windows.Forms.Label kmhLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label carLabel;
    }
}

