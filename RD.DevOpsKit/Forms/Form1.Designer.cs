namespace RD.DevOpsKit
{
    partial class FormMaster
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            tabControlMain = new TabControl();
            tpMain = new TabPage();
            tabPage2 = new TabPage();
            lblWatermark = new Label();
            lblVer = new Label();
            pbRedStar = new PictureBox();
            pbKoFi = new PictureBox();
            pbGithub = new PictureBox();
            gbVerData = new GroupBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGithub).BeginInit();
            gbVerData.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tpMain);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(900, 535);
            tabControlMain.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.Location = new Point(4, 24);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(892, 507);
            tpMain.TabIndex = 0;
            tpMain.Text = "Welcome!";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(772, 467);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Text Diff";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblWatermark
            // 
            lblWatermark.AutoSize = true;
            lblWatermark.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWatermark.Location = new Point(6, 84);
            lblWatermark.Name = "lblWatermark";
            lblWatermark.Size = new Size(170, 15);
            lblWatermark.TabIndex = 1;
            lblWatermark.Text = "Coded with ❤️ by Rubber Duck";
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.Location = new Point(6, 17);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(81, 15);
            lblVer.TabIndex = 2;
            lblVer.Text = "Version: v0.0.0";
            // 
            // pbRedStar
            // 
            pbRedStar.BackColor = Color.Transparent;
            pbRedStar.ErrorImage = null;
            pbRedStar.Image = Properties.Resources.red_star;
            pbRedStar.Location = new Point(182, 44);
            pbRedStar.Name = "pbRedStar";
            pbRedStar.Size = new Size(56, 56);
            pbRedStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedStar.TabIndex = 3;
            pbRedStar.TabStop = false;
            // 
            // pbKoFi
            // 
            pbKoFi.BackColor = Color.Transparent;
            pbKoFi.Image = Properties.Resources.rd_kofi_default;
            pbKoFi.Location = new Point(549, 609);
            pbKoFi.Name = "pbKoFi";
            pbKoFi.Size = new Size(200, 50);
            pbKoFi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKoFi.TabIndex = 4;
            pbKoFi.TabStop = false;
            // 
            // pbGithub
            // 
            pbGithub.BackColor = Color.Transparent;
            pbGithub.Image = Properties.Resources.rd_github_default;
            pbGithub.Location = new Point(549, 553);
            pbGithub.Name = "pbGithub";
            pbGithub.Size = new Size(200, 50);
            pbGithub.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGithub.TabIndex = 5;
            pbGithub.TabStop = false;
            // 
            // gbVerData
            // 
            gbVerData.Controls.Add(label1);
            gbVerData.Controls.Add(lblVer);
            gbVerData.Location = new Point(755, 603);
            gbVerData.Name = "gbVerData";
            gbVerData.Size = new Size(157, 56);
            gbVerData.TabIndex = 6;
            gbVerData.TabStop = false;
            gbVerData.Text = "Version info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Build: DD/MM/YYYY";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblWatermark);
            groupBox1.Controls.Add(pbRedStar);
            groupBox1.Location = new Point(12, 553);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 106);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 671);
            Controls.Add(groupBox1);
            Controls.Add(gbVerData);
            Controls.Add(pbGithub);
            Controls.Add(pbKoFi);
            Controls.Add(tabControlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubber Duck's DevOpsKit";
            tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRedStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGithub).EndInit();
            gbVerData.ResumeLayout(false);
            gbVerData.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tpMain;
        private TabPage tabPage2;
        private Label lblWatermark;
        private Label lblVer;
        private PictureBox pbRedStar;
        private PictureBox pbKoFi;
        private PictureBox pbGithub;
        private GroupBox gbVerData;
        private Label label1;
        private GroupBox groupBox1;
    }
}
