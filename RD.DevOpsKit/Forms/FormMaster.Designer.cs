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
            lblLinkChangelogGitHub = new LinkLabel();
            lblChangelog = new Label();
            lblLinkFAQs = new LinkLabel();
            lblLinkDocs = new LinkLabel();
            lblLinkGPL = new LinkLabel();
            lblLinkBug = new LinkLabel();
            lblLinkFeature = new LinkLabel();
            lblOr = new Label();
            lblLicense = new Label();
            lblHelpImproveText = new Label();
            lblExperiencingIssuesQ = new Label();
            lblLinkKubernetes = new LinkLabel();
            lblLinkJson = new LinkLabel();
            lblLinkB64 = new LinkLabel();
            lblLinkDiff = new LinkLabel();
            lblStartMsg = new Label();
            lblGreeting = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tpDiff = new TabPage();
            rtbRightLines = new RichTextBox();
            rtbRight = new RichTextBox();
            rtbLeftLines = new RichTextBox();
            btnClearAll = new Button();
            btnCompare = new Button();
            btnClearRight = new Button();
            btnClearLeft = new Button();
            btnAppend = new Button();
            btnRevert = new Button();
            lblTxt2 = new Label();
            lblTxt1 = new Label();
            lblHeadTextDiff = new Label();
            rtbLeft = new RichTextBox();
            tpJsonPrettyPrint = new TabPage();
            tpBase64Coder = new TabPage();
            tpKubernetes = new TabPage();
            lblWatermark = new Label();
            lblVer = new Label();
            pbRedStar = new PictureBox();
            pbKoFi = new PictureBox();
            pbGithub = new PictureBox();
            gbVerData = new GroupBox();
            lblLinkCheckUpdates = new LinkLabel();
            label1 = new Label();
            msMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
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
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            reportABugToolStripMenuItem1 = new ToolStripMenuItem();
            requestAFeatureToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            rDDevOpsKitToolStripMenuItem = new ToolStripMenuItem();
            buildInfoToolStripMenuItem = new ToolStripMenuItem();
            gNUGPLv3ToolStripMenuItem = new ToolStripMenuItem();
            changelogToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpDiff.SuspendLayout();
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
            tabControlMain.Controls.Add(tpJsonPrettyPrint);
            tabControlMain.Controls.Add(tpBase64Coder);
            tabControlMain.Controls.Add(tpKubernetes);
            tabControlMain.Location = new Point(12, 27);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(900, 570);
            tabControlMain.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(lblLinkChangelogGitHub);
            tpMain.Controls.Add(lblChangelog);
            tpMain.Controls.Add(lblLinkFAQs);
            tpMain.Controls.Add(lblLinkDocs);
            tpMain.Controls.Add(lblLinkGPL);
            tpMain.Controls.Add(lblLinkBug);
            tpMain.Controls.Add(lblLinkFeature);
            tpMain.Controls.Add(lblOr);
            tpMain.Controls.Add(lblLicense);
            tpMain.Controls.Add(lblHelpImproveText);
            tpMain.Controls.Add(lblExperiencingIssuesQ);
            tpMain.Controls.Add(lblLinkKubernetes);
            tpMain.Controls.Add(lblLinkJson);
            tpMain.Controls.Add(lblLinkB64);
            tpMain.Controls.Add(lblLinkDiff);
            tpMain.Controls.Add(lblStartMsg);
            tpMain.Controls.Add(lblGreeting);
            tpMain.Controls.Add(pictureBox2);
            tpMain.Controls.Add(pictureBox1);
            tpMain.Location = new Point(4, 24);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(892, 542);
            tpMain.TabIndex = 0;
            tpMain.Text = "Welcome!";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // lblLinkChangelogGitHub
            // 
            lblLinkChangelogGitHub.AutoSize = true;
            lblLinkChangelogGitHub.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkChangelogGitHub.Location = new Point(111, 509);
            lblLinkChangelogGitHub.Name = "lblLinkChangelogGitHub";
            lblLinkChangelogGitHub.Size = new Size(192, 17);
            lblLinkChangelogGitHub.TabIndex = 17;
            lblLinkChangelogGitHub.TabStop = true;
            lblLinkChangelogGitHub.Text = "Available here (GitHub)";
            // 
            // lblChangelog
            // 
            lblChangelog.AutoSize = true;
            lblChangelog.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChangelog.Location = new Point(6, 506);
            lblChangelog.Name = "lblChangelog";
            lblChangelog.Size = new Size(99, 20);
            lblChangelog.TabIndex = 16;
            lblChangelog.Text = "Changelog:";
            // 
            // lblLinkFAQs
            // 
            lblLinkFAQs.AutoSize = true;
            lblLinkFAQs.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkFAQs.Location = new Point(202, 372);
            lblLinkFAQs.Name = "lblLinkFAQs";
            lblLinkFAQs.Size = new Size(160, 17);
            lblLinkFAQs.TabIndex = 15;
            lblLinkFAQs.TabStop = true;
            lblLinkFAQs.Text = "Check FAQs (GitHub)";
            // 
            // lblLinkDocs
            // 
            lblLinkDocs.AutoSize = true;
            lblLinkDocs.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkDocs.Location = new Point(202, 354);
            lblLinkDocs.Name = "lblLinkDocs";
            lblLinkDocs.Size = new Size(264, 17);
            lblLinkDocs.TabIndex = 13;
            lblLinkDocs.TabStop = true;
            lblLinkDocs.Text = "Read official docs (GitHub Wiki)";
            // 
            // lblLinkGPL
            // 
            lblLinkGPL.AutoSize = true;
            lblLinkGPL.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkGPL.Location = new Point(364, 469);
            lblLinkGPL.Name = "lblLinkGPL";
            lblLinkGPL.Size = new Size(176, 17);
            lblLinkGPL.TabIndex = 14;
            lblLinkGPL.TabStop = true;
            lblLinkGPL.Text = "Read it here (GitHub)";
            // 
            // lblLinkBug
            // 
            lblLinkBug.AutoSize = true;
            lblLinkBug.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkBug.Location = new Point(648, 418);
            lblLinkBug.Name = "lblLinkBug";
            lblLinkBug.Size = new Size(176, 17);
            lblLinkBug.TabIndex = 13;
            lblLinkBug.TabStop = true;
            lblLinkBug.Text = "Report a bug (GitHub)";
            // 
            // lblLinkFeature
            // 
            lblLinkFeature.AutoSize = true;
            lblLinkFeature.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkFeature.Location = new Point(337, 418);
            lblLinkFeature.Name = "lblLinkFeature";
            lblLinkFeature.Size = new Size(272, 17);
            lblLinkFeature.TabIndex = 12;
            lblLinkFeature.TabStop = true;
            lblLinkFeature.Text = "Submit a feature request (GitHub)";
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOr.Location = new Point(614, 414);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(28, 21);
            lblOr.TabIndex = 11;
            lblOr.Text = "or";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicense.Location = new Point(6, 466);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(352, 21);
            lblLicense.TabIndex = 10;
            lblLicense.Text = "This tool is licensed under GNU GPLv3.";
            // 
            // lblHelpImproveText
            // 
            lblHelpImproveText.AutoSize = true;
            lblHelpImproveText.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelpImproveText.Location = new Point(6, 415);
            lblHelpImproveText.Name = "lblHelpImproveText";
            lblHelpImproveText.Size = new Size(325, 21);
            lblHelpImproveText.TabIndex = 9;
            lblHelpImproveText.Text = "Help me further improve this tool: ";
            // 
            // lblExperiencingIssuesQ
            // 
            lblExperiencingIssuesQ.AutoSize = true;
            lblExperiencingIssuesQ.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExperiencingIssuesQ.Location = new Point(6, 351);
            lblExperiencingIssuesQ.Name = "lblExperiencingIssuesQ";
            lblExperiencingIssuesQ.Size = new Size(190, 21);
            lblExperiencingIssuesQ.TabIndex = 8;
            lblExperiencingIssuesQ.Text = "Experiencing issues?";
            // 
            // lblLinkKubernetes
            // 
            lblLinkKubernetes.AutoSize = true;
            lblLinkKubernetes.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkKubernetes.Location = new Point(604, 297);
            lblLinkKubernetes.Name = "lblLinkKubernetes";
            lblLinkKubernetes.Size = new Size(136, 17);
            lblLinkKubernetes.TabIndex = 7;
            lblLinkKubernetes.TabStop = true;
            lblLinkKubernetes.Text = "Kubernetes (K8s)";
            // 
            // lblLinkJson
            // 
            lblLinkJson.AutoSize = true;
            lblLinkJson.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkJson.Location = new Point(392, 297);
            lblLinkJson.Name = "lblLinkJson";
            lblLinkJson.Size = new Size(144, 17);
            lblLinkJson.TabIndex = 6;
            lblLinkJson.TabStop = true;
            lblLinkJson.Text = "JSON Pretty Print";
            // 
            // lblLinkB64
            // 
            lblLinkB64.AutoSize = true;
            lblLinkB64.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkB64.Location = new Point(542, 297);
            lblLinkB64.Name = "lblLinkB64";
            lblLinkB64.Size = new Size(56, 17);
            lblLinkB64.TabIndex = 5;
            lblLinkB64.TabStop = true;
            lblLinkB64.Text = "Base64";
            // 
            // lblLinkDiff
            // 
            lblLinkDiff.AutoSize = true;
            lblLinkDiff.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinkDiff.Location = new Point(306, 297);
            lblLinkDiff.Name = "lblLinkDiff";
            lblLinkDiff.Size = new Size(80, 17);
            lblLinkDiff.TabIndex = 4;
            lblLinkDiff.TabStop = true;
            lblLinkDiff.Text = "Text Diff";
            // 
            // lblStartMsg
            // 
            lblStartMsg.AutoSize = true;
            lblStartMsg.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartMsg.Location = new Point(6, 272);
            lblStartMsg.Name = "lblStartMsg";
            lblStartMsg.Size = new Size(388, 42);
            lblStartMsg.TabIndex = 3;
            lblStartMsg.Text = "To start, simply select the tool you need.\r\nHere are some recommendations:";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(194, 201);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(518, 32);
            lblGreeting.TabIndex = 2;
            lblGreeting.Text = "Welcome to Rubber Duck's DevOps Kit!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.devopskit;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(96, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(707, 125);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.rubberducks;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tpDiff
            // 
            tpDiff.Controls.Add(rtbRightLines);
            tpDiff.Controls.Add(rtbRight);
            tpDiff.Controls.Add(rtbLeftLines);
            tpDiff.Controls.Add(btnClearAll);
            tpDiff.Controls.Add(btnCompare);
            tpDiff.Controls.Add(btnClearRight);
            tpDiff.Controls.Add(btnClearLeft);
            tpDiff.Controls.Add(btnAppend);
            tpDiff.Controls.Add(btnRevert);
            tpDiff.Controls.Add(lblTxt2);
            tpDiff.Controls.Add(lblTxt1);
            tpDiff.Controls.Add(lblHeadTextDiff);
            tpDiff.Controls.Add(rtbLeft);
            tpDiff.Location = new Point(4, 24);
            tpDiff.Name = "tpDiff";
            tpDiff.Padding = new Padding(3);
            tpDiff.Size = new Size(892, 542);
            tpDiff.TabIndex = 1;
            tpDiff.Text = "Text Diff";
            tpDiff.UseVisualStyleBackColor = true;
            // 
            // rtbRightLines
            // 
            rtbRightLines.Location = new Point(481, 63);
            rtbRightLines.Name = "rtbRightLines";
            rtbRightLines.ReadOnly = true;
            rtbRightLines.Size = new Size(30, 368);
            rtbRightLines.TabIndex = 13;
            rtbRightLines.Text = "";
            // 
            // rtbRight
            // 
            rtbRight.Location = new Point(509, 63);
            rtbRight.Name = "rtbRight";
            rtbRight.Size = new Size(377, 368);
            rtbRight.TabIndex = 12;
            rtbRight.Text = "";
            // 
            // rtbLeftLines
            // 
            rtbLeftLines.Location = new Point(6, 63);
            rtbLeftLines.Name = "rtbLeftLines";
            rtbLeftLines.ReadOnly = true;
            rtbLeftLines.Size = new Size(30, 368);
            rtbLeftLines.TabIndex = 11;
            rtbLeftLines.Text = "";
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(359, 489);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(171, 26);
            btnClearAll.TabIndex = 10;
            btnClearAll.Text = "Clear both inputs";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompare.Location = new Point(359, 437);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(171, 46);
            btnCompare.TabIndex = 9;
            btnCompare.Text = "< Check diff >";
            btnCompare.UseVisualStyleBackColor = true;
            // 
            // btnClearRight
            // 
            btnClearRight.Location = new Point(786, 31);
            btnClearRight.Name = "btnClearRight";
            btnClearRight.Size = new Size(100, 26);
            btnClearRight.TabIndex = 8;
            btnClearRight.Text = "Clear";
            btnClearRight.UseVisualStyleBackColor = true;
            // 
            // btnClearLeft
            // 
            btnClearLeft.Location = new Point(311, 31);
            btnClearLeft.Name = "btnClearLeft";
            btnClearLeft.Size = new Size(100, 26);
            btnClearLeft.TabIndex = 7;
            btnClearLeft.Text = "Clear";
            btnClearLeft.UseVisualStyleBackColor = true;
            // 
            // btnAppend
            // 
            btnAppend.Location = new Point(417, 258);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(58, 26);
            btnAppend.TabIndex = 6;
            btnAppend.Text = ">>>";
            btnAppend.UseVisualStyleBackColor = true;
            // 
            // btnRevert
            // 
            btnRevert.Location = new Point(417, 159);
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new Size(58, 26);
            btnRevert.TabIndex = 5;
            btnRevert.Text = "<<<";
            btnRevert.UseVisualStyleBackColor = true;
            // 
            // lblTxt2
            // 
            lblTxt2.AutoSize = true;
            lblTxt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxt2.Location = new Point(478, 39);
            lblTxt2.Name = "lblTxt2";
            lblTxt2.Size = new Size(61, 21);
            lblTxt2.TabIndex = 4;
            lblTxt2.Text = "Text #2:";
            // 
            // lblTxt1
            // 
            lblTxt1.AutoSize = true;
            lblTxt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxt1.Location = new Point(3, 39);
            lblTxt1.Name = "lblTxt1";
            lblTxt1.Size = new Size(61, 21);
            lblTxt1.TabIndex = 3;
            lblTxt1.Text = "Text #1:";
            // 
            // lblHeadTextDiff
            // 
            lblHeadTextDiff.AutoSize = true;
            lblHeadTextDiff.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeadTextDiff.Location = new Point(6, 3);
            lblHeadTextDiff.Name = "lblHeadTextDiff";
            lblHeadTextDiff.Size = new Size(285, 25);
            lblHeadTextDiff.TabIndex = 2;
            lblHeadTextDiff.Text = "Text Diff: Check text differences";
            // 
            // rtbLeft
            // 
            rtbLeft.Location = new Point(34, 63);
            rtbLeft.Name = "rtbLeft";
            rtbLeft.Size = new Size(377, 368);
            rtbLeft.TabIndex = 0;
            rtbLeft.Text = "";
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
            // tpBase64Coder
            // 
            tpBase64Coder.Location = new Point(4, 24);
            tpBase64Coder.Name = "tpBase64Coder";
            tpBase64Coder.Size = new Size(892, 542);
            tpBase64Coder.TabIndex = 2;
            tpBase64Coder.Text = "Base64";
            tpBase64Coder.UseVisualStyleBackColor = true;
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
            pbKoFi.Location = new Point(475, 609);
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
            gbVerData.Controls.Add(lblLinkCheckUpdates);
            gbVerData.Controls.Add(label1);
            gbVerData.Controls.Add(lblVer);
            gbVerData.Location = new Point(681, 603);
            gbVerData.Name = "gbVerData";
            gbVerData.Size = new Size(227, 56);
            gbVerData.TabIndex = 6;
            gbVerData.TabStop = false;
            gbVerData.Text = "Version info:";
            // 
            // lblLinkCheckUpdates
            // 
            lblLinkCheckUpdates.AutoSize = true;
            lblLinkCheckUpdates.Location = new Point(104, 17);
            lblLinkCheckUpdates.Name = "lblLinkCheckUpdates";
            lblLinkCheckUpdates.Size = new Size(112, 15);
            lblLinkCheckUpdates.TabIndex = 18;
            lblLinkCheckUpdates.TabStop = true;
            lblLinkCheckUpdates.Text = "Check for updates...";
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkForUpdatesToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new Size(179, 22);
            checkForUpdatesToolStripMenuItem.Text = "Check for updates...";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(179, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiTextDiff, tsmiJson, tsmiB64, tsmiKubernetes, tsmiSystem, tsmiNetwork });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(99, 20);
            toolsToolStripMenuItem.Text = "DevOps Tools...";
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
            redClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gETToolStripMenuItem, pUTToolStripMenuItem, pOSTToolStripMenuItem, toolStripMenuItem1 });
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(102, 22);
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
            donateToolStripMenuItem.Size = new Size(121, 22);
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
            whatsThisToolStripMenuItem.Size = new Size(137, 22);
            whatsThisToolStripMenuItem.Text = "What's this?";
            // 
            // docsToolStripMenuItem
            // 
            docsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewGitHubWikiToolStripMenuItem });
            docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            docsToolStripMenuItem.Size = new Size(137, 22);
            docsToolStripMenuItem.Text = "Docs";
            // 
            // viewGitHubWikiToolStripMenuItem
            // 
            viewGitHubWikiToolStripMenuItem.Name = "viewGitHubWikiToolStripMenuItem";
            viewGitHubWikiToolStripMenuItem.Size = new Size(166, 22);
            viewGitHubWikiToolStripMenuItem.Text = "View GitHub Wiki";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportABugToolStripMenuItem1, requestAFeatureToolStripMenuItem1 });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(137, 22);
            cToolStripMenuItem.Text = "Contribute";
            // 
            // reportABugToolStripMenuItem1
            // 
            reportABugToolStripMenuItem1.Name = "reportABugToolStripMenuItem1";
            reportABugToolStripMenuItem1.Size = new Size(174, 22);
            reportABugToolStripMenuItem1.Text = "Report a bug...";
            // 
            // requestAFeatureToolStripMenuItem1
            // 
            requestAFeatureToolStripMenuItem1.Name = "requestAFeatureToolStripMenuItem1";
            requestAFeatureToolStripMenuItem1.Size = new Size(174, 22);
            requestAFeatureToolStripMenuItem1.Text = "Request a feature...";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rDDevOpsKitToolStripMenuItem, buildInfoToolStripMenuItem, gNUGPLv3ToolStripMenuItem, changelogToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(61, 20);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // rDDevOpsKitToolStripMenuItem
            // 
            rDDevOpsKitToolStripMenuItem.Name = "rDDevOpsKitToolStripMenuItem";
            rDDevOpsKitToolStripMenuItem.Size = new Size(147, 22);
            rDDevOpsKitToolStripMenuItem.Text = "RD DevOpsKit";
            // 
            // buildInfoToolStripMenuItem
            // 
            buildInfoToolStripMenuItem.Name = "buildInfoToolStripMenuItem";
            buildInfoToolStripMenuItem.Size = new Size(147, 22);
            buildInfoToolStripMenuItem.Text = "Build info";
            // 
            // gNUGPLv3ToolStripMenuItem
            // 
            gNUGPLv3ToolStripMenuItem.Name = "gNUGPLv3ToolStripMenuItem";
            gNUGPLv3ToolStripMenuItem.Size = new Size(147, 22);
            gNUGPLv3ToolStripMenuItem.Text = "GNU GPLv3";
            // 
            // changelogToolStripMenuItem
            // 
            changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            changelogToolStripMenuItem.Size = new Size(147, 22);
            changelogToolStripMenuItem.Text = "Changelog";
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
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpDiff.ResumeLayout(false);
            tpDiff.PerformLayout();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblGreeting;
        private Label lblExperiencingIssuesQ;
        private LinkLabel lblLinkKubernetes;
        private LinkLabel lblLinkJson;
        private LinkLabel lblLinkB64;
        private LinkLabel lblLinkDiff;
        private Label lblStartMsg;
        private LinkLabel lblLinkGPL;
        private LinkLabel lblLinkBug;
        private LinkLabel lblLinkFeature;
        private Label lblOr;
        private Label lblLicense;
        private Label lblHelpImproveText;
        private LinkLabel lblLinkChangelogGitHub;
        private Label lblChangelog;
        private LinkLabel lblLinkFAQs;
        private LinkLabel lblLinkDocs;
        private LinkLabel lblLinkCheckUpdates;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem changelogToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private RichTextBox rtbLeft;
        private Button btnRevert;
        private Label lblTxt2;
        private Label lblTxt1;
        private Label lblHeadTextDiff;
        private Button btnClearAll;
        private Button btnCompare;
        private Button btnClearRight;
        private Button btnClearLeft;
        private Button btnAppend;
        private RichTextBox rtbLeftLines;
        private RichTextBox rtbRightLines;
        private RichTextBox rtbRight;
    }
}
