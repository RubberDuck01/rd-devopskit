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
            tpDiff = new TabPage();
            tpBase64Coder = new TabPage();
            tpJsonPrettyPrint = new TabPage();
            tpKubernetes = new TabPage();
            lblWatermark = new Label();
            lblVer = new Label();
            pbRedStar = new PictureBox();
            pbKoFi = new PictureBox();
            pbGithub = new PictureBox();
            gbVerData = new GroupBox();
            label1 = new Label();
            msMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            tsmiTextDiff = new ToolStripMenuItem();
            tsmiJson = new ToolStripMenuItem();
            tsmiB64 = new ToolStripMenuItem();
            encodeTextToB64ToolStripMenuItem = new ToolStripMenuItem();
            decodeB64ToTextToolStripMenuItem = new ToolStripMenuItem();
            tsmiKubernetes = new ToolStripMenuItem();
            generateSimpleYAMLManifestToolStripMenuItem = new ToolStripMenuItem();
            yAMLManifestVerifierToolStripMenuItem = new ToolStripMenuItem();
            validateSecretsToolStripMenuItem = new ToolStripMenuItem();
            tsmiSystem = new ToolStripMenuItem();
            statsToolStripMenuItem1 = new ToolStripMenuItem();
            checkResourcesToolStripMenuItem = new ToolStripMenuItem();
            lockingPCManipulatorToolStripMenuItem = new ToolStripMenuItem();
            tsmiNetwork = new ToolStripMenuItem();
            statsToolStripMenuItem = new ToolStripMenuItem();
            checkConnectionToolStripMenuItem = new ToolStripMenuItem();
            redClientToolStripMenuItem = new ToolStripMenuItem();
            gETToolStripMenuItem = new ToolStripMenuItem();
            pUTToolStripMenuItem = new ToolStripMenuItem();
            pOSTToolStripMenuItem = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            sourceCodeToolStripMenuItem = new ToolStripMenuItem();
            wikiToolStripMenuItem = new ToolStripMenuItem();
            rubberDucksGitHubProfileToolStripMenuItem = new ToolStripMenuItem();
            koFiToolStripMenuItem = new ToolStripMenuItem();
            donateToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            whatsThisToolStripMenuItem = new ToolStripMenuItem();
            docsToolStripMenuItem = new ToolStripMenuItem();
            viewGitHubWikiToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            rDDevOpsKitToolStripMenuItem = new ToolStripMenuItem();
            buildInfoToolStripMenuItem = new ToolStripMenuItem();
            reportABugToolStripMenuItem1 = new ToolStripMenuItem();
            requestAFeatureToolStripMenuItem1 = new ToolStripMenuItem();
            gNUGPLv3ToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGithub).BeginInit();
            gbVerData.SuspendLayout();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tpMain);
            tabControlMain.Controls.Add(tpDiff);
            tabControlMain.Controls.Add(tpBase64Coder);
            tabControlMain.Controls.Add(tpJsonPrettyPrint);
            tabControlMain.Controls.Add(tpKubernetes);
            tabControlMain.Location = new Point(12, 27);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(900, 570);
            tabControlMain.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.Location = new Point(4, 24);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(892, 542);
            tpMain.TabIndex = 0;
            tpMain.Text = "Welcome!";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // tpDiff
            // 
            tpDiff.Location = new Point(4, 24);
            tpDiff.Name = "tpDiff";
            tpDiff.Padding = new Padding(3);
            tpDiff.Size = new Size(892, 542);
            tpDiff.TabIndex = 1;
            tpDiff.Text = "Text Diff";
            tpDiff.UseVisualStyleBackColor = true;
            // 
            // tpBase64Coder
            // 
            tpBase64Coder.Location = new Point(4, 24);
            tpBase64Coder.Name = "tpBase64Coder";
            tpBase64Coder.Size = new Size(892, 542);
            tpBase64Coder.TabIndex = 2;
            tpBase64Coder.Text = "Base64";
            tpBase64Coder.UseVisualStyleBackColor = true;
            // 
            // tpJsonPrettyPrint
            // 
            tpJsonPrettyPrint.Location = new Point(4, 24);
            tpJsonPrettyPrint.Name = "tpJsonPrettyPrint";
            tpJsonPrettyPrint.Size = new Size(892, 542);
            tpJsonPrettyPrint.TabIndex = 3;
            tpJsonPrettyPrint.Text = "JSON Pretty Print";
            tpJsonPrettyPrint.UseVisualStyleBackColor = true;
            // 
            // tpKubernetes
            // 
            tpKubernetes.Location = new Point(4, 24);
            tpKubernetes.Name = "tpKubernetes";
            tpKubernetes.Size = new Size(892, 542);
            tpKubernetes.TabIndex = 4;
            tpKubernetes.Text = "Kubernetes (K8s)";
            tpKubernetes.UseVisualStyleBackColor = true;
            // 
            // lblWatermark
            // 
            lblWatermark.AutoSize = true;
            lblWatermark.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWatermark.Location = new Point(12, 637);
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
            pbRedStar.Location = new Point(188, 627);
            pbRedStar.Name = "pbRedStar";
            pbRedStar.Size = new Size(32, 32);
            pbRedStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedStar.TabIndex = 3;
            pbRedStar.TabStop = false;
            // 
            // pbKoFi
            // 
            pbKoFi.BackColor = Color.Transparent;
            pbKoFi.Image = Properties.Resources.rd_kofi_default;
            pbKoFi.Location = new Point(506, 609);
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
            pbGithub.Location = new Point(269, 609);
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
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, gitHubToolStripMenuItem, koFiToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(924, 24);
            msMain.TabIndex = 7;
            msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(97, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiTextDiff, tsmiJson, tsmiB64, tsmiKubernetes, tsmiSystem, tsmiNetwork });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // tsmiTextDiff
            // 
            tsmiTextDiff.Name = "tsmiTextDiff";
            tsmiTextDiff.Size = new Size(164, 22);
            tsmiTextDiff.Text = "Text Diff";
            // 
            // tsmiJson
            // 
            tsmiJson.Name = "tsmiJson";
            tsmiJson.Size = new Size(164, 22);
            tsmiJson.Text = "JSON Pretty Print";
            // 
            // tsmiB64
            // 
            tsmiB64.DropDownItems.AddRange(new ToolStripItem[] { encodeTextToB64ToolStripMenuItem, decodeB64ToTextToolStripMenuItem });
            tsmiB64.Name = "tsmiB64";
            tsmiB64.Size = new Size(164, 22);
            tsmiB64.Text = "Base64...";
            // 
            // encodeTextToB64ToolStripMenuItem
            // 
            encodeTextToB64ToolStripMenuItem.Name = "encodeTextToB64ToolStripMenuItem";
            encodeTextToB64ToolStripMenuItem.Size = new Size(173, 22);
            encodeTextToB64ToolStripMenuItem.Text = "Encode text to B64";
            // 
            // decodeB64ToTextToolStripMenuItem
            // 
            decodeB64ToTextToolStripMenuItem.Name = "decodeB64ToTextToolStripMenuItem";
            decodeB64ToTextToolStripMenuItem.Size = new Size(173, 22);
            decodeB64ToTextToolStripMenuItem.Text = "Decode B64 to text";
            // 
            // tsmiKubernetes
            // 
            tsmiKubernetes.DropDownItems.AddRange(new ToolStripItem[] { generateSimpleYAMLManifestToolStripMenuItem, yAMLManifestVerifierToolStripMenuItem, validateSecretsToolStripMenuItem });
            tsmiKubernetes.Name = "tsmiKubernetes";
            tsmiKubernetes.Size = new Size(164, 22);
            tsmiKubernetes.Text = "Kubernetes (K8s)";
            // 
            // generateSimpleYAMLManifestToolStripMenuItem
            // 
            generateSimpleYAMLManifestToolStripMenuItem.Name = "generateSimpleYAMLManifestToolStripMenuItem";
            generateSimpleYAMLManifestToolStripMenuItem.Size = new Size(242, 22);
            generateSimpleYAMLManifestToolStripMenuItem.Text = "Generate simple YAML manifest";
            // 
            // yAMLManifestVerifierToolStripMenuItem
            // 
            yAMLManifestVerifierToolStripMenuItem.Name = "yAMLManifestVerifierToolStripMenuItem";
            yAMLManifestVerifierToolStripMenuItem.Size = new Size(242, 22);
            yAMLManifestVerifierToolStripMenuItem.Text = "YAML Manifest verifier";
            // 
            // validateSecretsToolStripMenuItem
            // 
            validateSecretsToolStripMenuItem.Name = "validateSecretsToolStripMenuItem";
            validateSecretsToolStripMenuItem.Size = new Size(242, 22);
            validateSecretsToolStripMenuItem.Text = "Validate Secrets";
            // 
            // tsmiSystem
            // 
            tsmiSystem.DropDownItems.AddRange(new ToolStripItem[] { statsToolStripMenuItem1, checkResourcesToolStripMenuItem, lockingPCManipulatorToolStripMenuItem });
            tsmiSystem.Name = "tsmiSystem";
            tsmiSystem.Size = new Size(164, 22);
            tsmiSystem.Text = "System";
            // 
            // statsToolStripMenuItem1
            // 
            statsToolStripMenuItem1.Name = "statsToolStripMenuItem1";
            statsToolStripMenuItem1.Size = new Size(202, 22);
            statsToolStripMenuItem1.Text = "Stats";
            // 
            // checkResourcesToolStripMenuItem
            // 
            checkResourcesToolStripMenuItem.Name = "checkResourcesToolStripMenuItem";
            checkResourcesToolStripMenuItem.Size = new Size(202, 22);
            checkResourcesToolStripMenuItem.Text = "Check resources";
            // 
            // lockingPCManipulatorToolStripMenuItem
            // 
            lockingPCManipulatorToolStripMenuItem.Name = "lockingPCManipulatorToolStripMenuItem";
            lockingPCManipulatorToolStripMenuItem.Size = new Size(202, 22);
            lockingPCManipulatorToolStripMenuItem.Text = "Locking PC manipulator";
            // 
            // tsmiNetwork
            // 
            tsmiNetwork.DropDownItems.AddRange(new ToolStripItem[] { statsToolStripMenuItem, checkConnectionToolStripMenuItem, redClientToolStripMenuItem });
            tsmiNetwork.Name = "tsmiNetwork";
            tsmiNetwork.Size = new Size(164, 22);
            tsmiNetwork.Text = "Network";
            // 
            // statsToolStripMenuItem
            // 
            statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            statsToolStripMenuItem.Size = new Size(170, 22);
            statsToolStripMenuItem.Text = "Stats";
            // 
            // checkConnectionToolStripMenuItem
            // 
            checkConnectionToolStripMenuItem.Name = "checkConnectionToolStripMenuItem";
            checkConnectionToolStripMenuItem.Size = new Size(170, 22);
            checkConnectionToolStripMenuItem.Text = "Check connection";
            // 
            // redClientToolStripMenuItem
            // 
            redClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gETToolStripMenuItem, pUTToolStripMenuItem, pOSTToolStripMenuItem });
            redClientToolStripMenuItem.Name = "redClientToolStripMenuItem";
            redClientToolStripMenuItem.Size = new Size(170, 22);
            redClientToolStripMenuItem.Text = "RedClient";
            // 
            // gETToolStripMenuItem
            // 
            gETToolStripMenuItem.Name = "gETToolStripMenuItem";
            gETToolStripMenuItem.Size = new Size(102, 22);
            gETToolStripMenuItem.Text = "GET";
            // 
            // pUTToolStripMenuItem
            // 
            pUTToolStripMenuItem.Name = "pUTToolStripMenuItem";
            pUTToolStripMenuItem.Size = new Size(102, 22);
            pUTToolStripMenuItem.Text = "PUT";
            // 
            // pOSTToolStripMenuItem
            // 
            pOSTToolStripMenuItem.Name = "pOSTToolStripMenuItem";
            pOSTToolStripMenuItem.Size = new Size(102, 22);
            pOSTToolStripMenuItem.Text = "POST";
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sourceCodeToolStripMenuItem, wikiToolStripMenuItem, rubberDucksGitHubProfileToolStripMenuItem });
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(57, 20);
            gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // sourceCodeToolStripMenuItem
            // 
            sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            sourceCodeToolStripMenuItem.Size = new Size(228, 22);
            sourceCodeToolStripMenuItem.Text = "Source code";
            // 
            // wikiToolStripMenuItem
            // 
            wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            wikiToolStripMenuItem.Size = new Size(228, 22);
            wikiToolStripMenuItem.Text = "Wiki";
            // 
            // rubberDucksGitHubProfileToolStripMenuItem
            // 
            rubberDucksGitHubProfileToolStripMenuItem.Name = "rubberDucksGitHubProfileToolStripMenuItem";
            rubberDucksGitHubProfileToolStripMenuItem.Size = new Size(228, 22);
            rubberDucksGitHubProfileToolStripMenuItem.Text = "Rubber Duck's GitHub profile";
            // 
            // koFiToolStripMenuItem
            // 
            koFiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { donateToolStripMenuItem });
            koFiToolStripMenuItem.Name = "koFiToolStripMenuItem";
            koFiToolStripMenuItem.Size = new Size(47, 20);
            koFiToolStripMenuItem.Text = "Ko-Fi";
            // 
            // donateToolStripMenuItem
            // 
            donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            donateToolStripMenuItem.Size = new Size(180, 22);
            donateToolStripMenuItem.Text = "Donate...";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatsThisToolStripMenuItem, docsToolStripMenuItem, cToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // whatsThisToolStripMenuItem
            // 
            whatsThisToolStripMenuItem.Name = "whatsThisToolStripMenuItem";
            whatsThisToolStripMenuItem.Size = new Size(180, 22);
            whatsThisToolStripMenuItem.Text = "What's this?";
            // 
            // docsToolStripMenuItem
            // 
            docsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewGitHubWikiToolStripMenuItem });
            docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            docsToolStripMenuItem.Size = new Size(180, 22);
            docsToolStripMenuItem.Text = "Docs";
            // 
            // viewGitHubWikiToolStripMenuItem
            // 
            viewGitHubWikiToolStripMenuItem.Name = "viewGitHubWikiToolStripMenuItem";
            viewGitHubWikiToolStripMenuItem.Size = new Size(180, 22);
            viewGitHubWikiToolStripMenuItem.Text = "View GitHub Wiki";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportABugToolStripMenuItem1, requestAFeatureToolStripMenuItem1 });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(180, 22);
            cToolStripMenuItem.Text = "Contribute";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rDDevOpsKitToolStripMenuItem, buildInfoToolStripMenuItem, gNUGPLv3ToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(61, 20);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // rDDevOpsKitToolStripMenuItem
            // 
            rDDevOpsKitToolStripMenuItem.Name = "rDDevOpsKitToolStripMenuItem";
            rDDevOpsKitToolStripMenuItem.Size = new Size(180, 22);
            rDDevOpsKitToolStripMenuItem.Text = "RD DevOpsKit";
            // 
            // buildInfoToolStripMenuItem
            // 
            buildInfoToolStripMenuItem.Name = "buildInfoToolStripMenuItem";
            buildInfoToolStripMenuItem.Size = new Size(180, 22);
            buildInfoToolStripMenuItem.Text = "Build info";
            // 
            // reportABugToolStripMenuItem1
            // 
            reportABugToolStripMenuItem1.Name = "reportABugToolStripMenuItem1";
            reportABugToolStripMenuItem1.Size = new Size(180, 22);
            reportABugToolStripMenuItem1.Text = "Report a bug...";
            // 
            // requestAFeatureToolStripMenuItem1
            // 
            requestAFeatureToolStripMenuItem1.Name = "requestAFeatureToolStripMenuItem1";
            requestAFeatureToolStripMenuItem1.Size = new Size(180, 22);
            requestAFeatureToolStripMenuItem1.Text = "Request a feature...";
            // 
            // gNUGPLv3ToolStripMenuItem
            // 
            gNUGPLv3ToolStripMenuItem.Name = "gNUGPLv3ToolStripMenuItem";
            gNUGPLv3ToolStripMenuItem.Size = new Size(180, 22);
            gNUGPLv3ToolStripMenuItem.Text = "GNU GPLv3";
            // 
            // FormMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 671);
            Controls.Add(lblWatermark);
            Controls.Add(pbRedStar);
            Controls.Add(gbVerData);
            Controls.Add(pbGithub);
            Controls.Add(pbKoFi);
            Controls.Add(tabControlMain);
            Controls.Add(msMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMain;
            Name = "FormMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubber Duck's DevOpsKit";
            tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRedStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKoFi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGithub).EndInit();
            gbVerData.ResumeLayout(false);
            gbVerData.PerformLayout();
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tpMain;
        private TabPage tpDiff;
        private Label lblWatermark;
        private Label lblVer;
        private PictureBox pbRedStar;
        private PictureBox pbKoFi;
        private PictureBox pbGithub;
        private GroupBox gbVerData;
        private Label label1;
        private TabPage tpBase64Coder;
        private MenuStrip msMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem tsmiTextDiff;
        private ToolStripMenuItem tsmiB64;
        private ToolStripMenuItem encodeTextToB64ToolStripMenuItem;
        private ToolStripMenuItem decodeB64ToTextToolStripMenuItem;
        private ToolStripMenuItem tsmiJson;
        private ToolStripMenuItem tsmiKubernetes;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem koFiToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem generateSimpleYAMLManifestToolStripMenuItem;
        private ToolStripMenuItem yAMLManifestVerifierToolStripMenuItem;
        private ToolStripMenuItem validateSecretsToolStripMenuItem;
        private ToolStripMenuItem sourceCodeToolStripMenuItem;
        private ToolStripMenuItem wikiToolStripMenuItem;
        private ToolStripMenuItem rubberDucksGitHubProfileToolStripMenuItem;
        private ToolStripMenuItem donateToolStripMenuItem;
        private ToolStripMenuItem whatsThisToolStripMenuItem;
        private ToolStripMenuItem docsToolStripMenuItem;
        private ToolStripMenuItem viewGitHubWikiToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem rDDevOpsKitToolStripMenuItem;
        private ToolStripMenuItem buildInfoToolStripMenuItem;
        private TabPage tpJsonPrettyPrint;
        private TabPage tpKubernetes;
        private ToolStripMenuItem tsmiNetwork;
        private ToolStripMenuItem statsToolStripMenuItem;
        private ToolStripMenuItem checkConnectionToolStripMenuItem;
        private ToolStripMenuItem tsmiSystem;
        private ToolStripMenuItem statsToolStripMenuItem1;
        private ToolStripMenuItem checkResourcesToolStripMenuItem;
        private ToolStripMenuItem lockingPCManipulatorToolStripMenuItem;
        private ToolStripMenuItem redClientToolStripMenuItem;
        private ToolStripMenuItem gETToolStripMenuItem;
        private ToolStripMenuItem pUTToolStripMenuItem;
        private ToolStripMenuItem pOSTToolStripMenuItem;
        private ToolStripMenuItem reportABugToolStripMenuItem1;
        private ToolStripMenuItem requestAFeatureToolStripMenuItem1;
        private ToolStripMenuItem gNUGPLv3ToolStripMenuItem;
    }
}
