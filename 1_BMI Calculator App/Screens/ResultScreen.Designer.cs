namespace BMICalculator.Screens
{
    partial class ResultScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cirProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.picBoxClassImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblBMIClass = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblMoreInfoBMIClass = new System.Windows.Forms.Label();
            this.lblCatogryBMIClass = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShareBMI = new Guna.UI2.WinForms.Guna2Button();
            this.btnReCalcutror = new Guna.UI2.WinForms.Guna2Button();
            this.imageListClass = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.cirProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClassImage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.51439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.18899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29662F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel5, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.283156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.42342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.40128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.978768F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.855626F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.cirProgressBar);
            this.guna2Panel1.Controls.Add(this.lblBMIClass);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(508, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.SetRowSpan(this.guna2Panel1, 2);
            this.guna2Panel1.Size = new System.Drawing.Size(293, 327);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cirProgressBar
            // 
            this.cirProgressBar.Controls.Add(this.picBoxClassImage);
            this.cirProgressBar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cirProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cirProgressBar.ForeColor = System.Drawing.Color.White;
            this.cirProgressBar.Location = new System.Drawing.Point(26, 13);
            this.cirProgressBar.Minimum = 1;
            this.cirProgressBar.Name = "cirProgressBar";
            this.cirProgressBar.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.cirProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(136)))));
            this.cirProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cirProgressBar.Size = new System.Drawing.Size(248, 248);
            this.cirProgressBar.TabIndex = 0;
            this.cirProgressBar.Text = "guna2CircleProgressBar1";
            this.cirProgressBar.Value = 1;
            // 
            // picBoxClassImage
            // 
            this.picBoxClassImage.BackColor = System.Drawing.Color.Transparent;
            this.picBoxClassImage.FillColor = System.Drawing.Color.Transparent;
            this.picBoxClassImage.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClassImage.Image")));
            this.picBoxClassImage.ImageRotate = 0F;
            this.picBoxClassImage.Location = new System.Drawing.Point(92, 63);
            this.picBoxClassImage.Name = "picBoxClassImage";
            this.picBoxClassImage.Size = new System.Drawing.Size(64, 127);
            this.picBoxClassImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxClassImage.TabIndex = 3;
            this.picBoxClassImage.TabStop = false;
            // 
            // lblBMIClass
            // 
            this.lblBMIClass.BackColor = System.Drawing.Color.Transparent;
            this.lblBMIClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBMIClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBMIClass.Location = new System.Drawing.Point(10, 269);
            this.lblBMIClass.Name = "lblBMIClass";
            this.lblBMIClass.Size = new System.Drawing.Size(273, 48);
            this.lblBMIClass.TabIndex = 2;
            this.lblBMIClass.Text = "BMi Class";
            this.lblBMIClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.guna2Panel2, 2);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(8, 28);
            this.guna2Panel2.Name = "guna2Panel2";
            this.tableLayoutPanel1.SetRowSpan(this.guna2Panel2, 2);
            this.guna2Panel2.Size = new System.Drawing.Size(494, 327);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 12;
            this.guna2GradientPanel2.Controls.Add(this.lblMoreInfoBMIClass);
            this.guna2GradientPanel2.Controls.Add(this.lblCatogryBMIClass);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Orange;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.Orange;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 166);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(494, 161);
            this.guna2GradientPanel2.TabIndex = 3;
            // 
            // lblMoreInfoBMIClass
            // 
            this.lblMoreInfoBMIClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMoreInfoBMIClass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoreInfoBMIClass.ForeColor = System.Drawing.Color.White;
            this.lblMoreInfoBMIClass.Location = new System.Drawing.Point(0, 47);
            this.lblMoreInfoBMIClass.Name = "lblMoreInfoBMIClass";
            this.lblMoreInfoBMIClass.Padding = new System.Windows.Forms.Padding(10);
            this.lblMoreInfoBMIClass.Size = new System.Drawing.Size(494, 114);
            this.lblMoreInfoBMIClass.TabIndex = 8;
            this.lblMoreInfoBMIClass.Text = "MoreInfo About Catogry";
            // 
            // lblCatogryBMIClass
            // 
            this.lblCatogryBMIClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatogryBMIClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogryBMIClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCatogryBMIClass.Location = new System.Drawing.Point(0, 0);
            this.lblCatogryBMIClass.Name = "lblCatogryBMIClass";
            this.lblCatogryBMIClass.Padding = new System.Windows.Forms.Padding(10);
            this.lblCatogryBMIClass.Size = new System.Drawing.Size(494, 47);
            this.lblCatogryBMIClass.TabIndex = 7;
            this.lblCatogryBMIClass.Text = "Catogry";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 12;
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.lblBMIResult);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(494, 160);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(314, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Kg/M²)";
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIResult.ForeColor = System.Drawing.Color.White;
            this.lblBMIResult.Location = new System.Drawing.Point(224, 42);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(156, 81);
            this.lblBMIResult.TabIndex = 6;
            this.lblBMIResult.Text = "24.1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 92);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your BMI \r\nResult (Score):";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnShareBMI);
            this.guna2Panel5.Controls.Add(this.btnReCalcutror);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(99, 394);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(403, 41);
            this.guna2Panel5.TabIndex = 2;
            // 
            // btnShareBMI
            // 
            this.btnShareBMI.Animated = true;
            this.btnShareBMI.AnimatedGIF = true;
            this.btnShareBMI.BorderColor = System.Drawing.Color.Empty;
            this.btnShareBMI.BorderRadius = 6;
            this.btnShareBMI.BorderThickness = 1;
            this.btnShareBMI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShareBMI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShareBMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShareBMI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShareBMI.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShareBMI.FillColor = System.Drawing.Color.Orange;
            this.btnShareBMI.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShareBMI.ForeColor = System.Drawing.Color.White;
            this.btnShareBMI.Location = new System.Drawing.Point(283, 0);
            this.btnShareBMI.Name = "btnShareBMI";
            this.btnShareBMI.Size = new System.Drawing.Size(120, 41);
            this.btnShareBMI.TabIndex = 1;
            this.btnShareBMI.Text = "Share";
            this.btnShareBMI.Click += new System.EventHandler(this.btnShareBMI_Click);
            // 
            // btnReCalcutror
            // 
            this.btnReCalcutror.Animated = true;
            this.btnReCalcutror.AnimatedGIF = true;
            this.btnReCalcutror.BorderColor = System.Drawing.Color.Empty;
            this.btnReCalcutror.BorderRadius = 6;
            this.btnReCalcutror.BorderThickness = 1;
            this.btnReCalcutror.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReCalcutror.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReCalcutror.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReCalcutror.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReCalcutror.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReCalcutror.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReCalcutror.ForeColor = System.Drawing.Color.White;
            this.btnReCalcutror.Location = new System.Drawing.Point(0, 0);
            this.btnReCalcutror.Name = "btnReCalcutror";
            this.btnReCalcutror.Size = new System.Drawing.Size(218, 41);
            this.btnReCalcutror.TabIndex = 0;
            this.btnReCalcutror.Text = "ReCalculator";
            this.btnReCalcutror.Click += new System.EventHandler(this.btnReCalcutror_Click);
            // 
            // imageListClass
            // 
            this.imageListClass.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListClass.ImageStream")));
            this.imageListClass.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListClass.Images.SetKeyName(0, "Man1.png");
            this.imageListClass.Images.SetKeyName(1, "Man2.png");
            this.imageListClass.Images.SetKeyName(2, "Man3.png");
            this.imageListClass.Images.SetKeyName(3, "Man4.png");
            this.imageListClass.Images.SetKeyName(4, "Man5.png");
            this.imageListClass.Images.SetKeyName(5, "Man6.png");
            this.imageListClass.Images.SetKeyName(6, "Man7.png");
            this.imageListClass.Images.SetKeyName(7, "Man8.png");
            // 
            // ResultScreen
            // 
            this.AcceptButton = this.btnReCalcutror;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(827, 528);
            this.MinimumSize = new System.Drawing.Size(827, 528);
            this.Name = "ResultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultScreen";
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.cirProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClassImage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageListClass;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cirProgressBar;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxClassImage;
        private System.Windows.Forms.Label lblBMIClass;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button btnReCalcutror;
        private Guna.UI2.WinForms.Guna2Button btnShareBMI;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblMoreInfoBMIClass;
        private System.Windows.Forms.Label lblCatogryBMIClass;
    }
}