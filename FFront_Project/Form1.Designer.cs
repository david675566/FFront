namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.SourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputVideo = new System.Windows.Forms.CheckBox();
            this.TargetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputAudio = new System.Windows.Forms.CheckBox();
            this.SourceFileText = new System.Windows.Forms.TextBox();
            this.TargetFileText = new System.Windows.Forms.TextBox();
            this.SourceLable = new System.Windows.Forms.Label();
            this.TargetLable = new System.Windows.Forms.Label();
            this.SourceFileButton = new System.Windows.Forms.Button();
            this.TargetFileButton = new System.Windows.Forms.Button();
            this.videoCodec = new System.Windows.Forms.ComboBox();
            this.lablevc = new System.Windows.Forms.Label();
            this.lablevb = new System.Windows.Forms.Label();
            this.lableab = new System.Windows.Forms.Label();
            this.lableac = new System.Windows.Forms.Label();
            this.audioBitrate = new System.Windows.Forms.ComboBox();
            this.audioCodec = new System.Windows.Forms.ComboBox();
            this.lablear = new System.Windows.Forms.Label();
            this.audioSampleRate = new System.Windows.Forms.ComboBox();
            this.lablevf = new System.Windows.Forms.Label();
            this.videoFPS = new System.Windows.Forms.ComboBox();
            this.lablevwh = new System.Windows.Forms.Label();
            this.lableVWHX = new System.Windows.Forms.Label();
            this.videoBitrate = new System.Windows.Forms.TextBox();
            this.lableKb_v = new System.Windows.Forms.Label();
            this.videoWidth = new System.Windows.Forms.TextBox();
            this.videoHeight = new System.Windows.Forms.TextBox();
            this.labelKb_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(130, 399);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(85, 39);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "轉檔";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SourceFileDialog
            // 
            this.SourceFileDialog.FileName = "openFileDialog1";
            this.SourceFileDialog.Title = "選擇來源";
            // 
            // outputVideo
            // 
            this.outputVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outputVideo.AutoSize = true;
            this.outputVideo.Enabled = false;
            this.outputVideo.Location = new System.Drawing.Point(23, 127);
            this.outputVideo.Name = "outputVideo";
            this.outputVideo.Size = new System.Drawing.Size(72, 16);
            this.outputVideo.TabIndex = 7;
            this.outputVideo.Text = "輸出影片";
            this.outputVideo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.outputVideo.UseVisualStyleBackColor = true;
            this.outputVideo.CheckStateChanged += new System.EventHandler(this.outputVideo_CheckStateChanged);
            this.outputVideo.EnabledChanged += new System.EventHandler(this.outputVideo_EnabledChanged);
            // 
            // TargetFileDialog
            // 
            this.TargetFileDialog.Filter = "Mpeg4 Video|*.mp4|WebM Video|*.webm|所有檔案|*.*";
            this.TargetFileDialog.Title = "選擇目的";
            // 
            // outputAudio
            // 
            this.outputAudio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outputAudio.AutoSize = true;
            this.outputAudio.Enabled = false;
            this.outputAudio.Location = new System.Drawing.Point(23, 260);
            this.outputAudio.Name = "outputAudio";
            this.outputAudio.Size = new System.Drawing.Size(72, 16);
            this.outputAudio.TabIndex = 7;
            this.outputAudio.Text = "輸出聲音";
            this.outputAudio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.outputAudio.UseVisualStyleBackColor = true;
            this.outputAudio.CheckedChanged += new System.EventHandler(this.outputAudio_CheckedChanged);
            this.outputAudio.EnabledChanged += new System.EventHandler(this.outputAudio_EnabledChanged);
            // 
            // SourceFileText
            // 
            this.SourceFileText.Location = new System.Drawing.Point(25, 33);
            this.SourceFileText.Name = "SourceFileText";
            this.SourceFileText.Size = new System.Drawing.Size(263, 22);
            this.SourceFileText.TabIndex = 1;
            // 
            // TargetFileText
            // 
            this.TargetFileText.Location = new System.Drawing.Point(25, 83);
            this.TargetFileText.Name = "TargetFileText";
            this.TargetFileText.Size = new System.Drawing.Size(265, 22);
            this.TargetFileText.TabIndex = 2;
            // 
            // SourceLable
            // 
            this.SourceLable.AutoSize = true;
            this.SourceLable.Location = new System.Drawing.Point(25, 18);
            this.SourceLable.Name = "SourceLable";
            this.SourceLable.Size = new System.Drawing.Size(32, 12);
            this.SourceLable.TabIndex = 3;
            this.SourceLable.Text = "來源:";
            // 
            // TargetLable
            // 
            this.TargetLable.AutoSize = true;
            this.TargetLable.Location = new System.Drawing.Point(25, 68);
            this.TargetLable.Name = "TargetLable";
            this.TargetLable.Size = new System.Drawing.Size(32, 12);
            this.TargetLable.TabIndex = 4;
            this.TargetLable.Text = "目的:";
            // 
            // SourceFileButton
            // 
            this.SourceFileButton.Location = new System.Drawing.Point(296, 34);
            this.SourceFileButton.Name = "SourceFileButton";
            this.SourceFileButton.Size = new System.Drawing.Size(23, 21);
            this.SourceFileButton.TabIndex = 5;
            this.SourceFileButton.Text = "...";
            this.SourceFileButton.UseVisualStyleBackColor = true;
            this.SourceFileButton.Click += new System.EventHandler(this.SourceFileButton_Click);
            // 
            // TargetFileButton
            // 
            this.TargetFileButton.Location = new System.Drawing.Point(296, 84);
            this.TargetFileButton.Name = "TargetFileButton";
            this.TargetFileButton.Size = new System.Drawing.Size(23, 21);
            this.TargetFileButton.TabIndex = 6;
            this.TargetFileButton.Text = "...";
            this.TargetFileButton.UseVisualStyleBackColor = true;
            this.TargetFileButton.Click += new System.EventHandler(this.TargetFileButton_Click);
            // 
            // videoCodec
            // 
            this.videoCodec.BackColor = System.Drawing.SystemColors.Window;
            this.videoCodec.Enabled = false;
            this.videoCodec.Font = new System.Drawing.Font("新細明體", 9F);
            this.videoCodec.FormattingEnabled = true;
            this.videoCodec.Location = new System.Drawing.Point(36, 168);
            this.videoCodec.Name = "videoCodec";
            this.videoCodec.Size = new System.Drawing.Size(136, 20);
            this.videoCodec.TabIndex = 8;
            // 
            // lablevc
            // 
            this.lablevc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lablevc.AutoSize = true;
            this.lablevc.Enabled = false;
            this.lablevc.Location = new System.Drawing.Point(34, 153);
            this.lablevc.Name = "lablevc";
            this.lablevc.Size = new System.Drawing.Size(41, 12);
            this.lablevc.TabIndex = 12;
            this.lablevc.Text = "編碼器";
            // 
            // lablevb
            // 
            this.lablevb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lablevb.AutoSize = true;
            this.lablevb.Enabled = false;
            this.lablevb.Location = new System.Drawing.Point(34, 195);
            this.lablevb.Name = "lablevb";
            this.lablevb.Size = new System.Drawing.Size(41, 12);
            this.lablevb.TabIndex = 15;
            this.lablevb.Text = "位元率";
            // 
            // lableab
            // 
            this.lableab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lableab.AutoSize = true;
            this.lableab.Enabled = false;
            this.lableab.Location = new System.Drawing.Point(34, 327);
            this.lableab.Name = "lableab";
            this.lableab.Size = new System.Drawing.Size(41, 12);
            this.lableab.TabIndex = 19;
            this.lableab.Text = "位元率";
            // 
            // lableac
            // 
            this.lableac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lableac.AutoSize = true;
            this.lableac.Enabled = false;
            this.lableac.Location = new System.Drawing.Point(34, 285);
            this.lableac.Name = "lableac";
            this.lableac.Size = new System.Drawing.Size(41, 12);
            this.lableac.TabIndex = 18;
            this.lableac.Text = "編碼器";
            // 
            // audioBitrate
            // 
            this.audioBitrate.Enabled = false;
            this.audioBitrate.FormattingEnabled = true;
            this.audioBitrate.Items.AddRange(new object[] {
            "96",
            "128",
            "192",
            "256",
            "320"});
            this.audioBitrate.Location = new System.Drawing.Point(36, 342);
            this.audioBitrate.Name = "audioBitrate";
            this.audioBitrate.Size = new System.Drawing.Size(84, 20);
            this.audioBitrate.TabIndex = 17;
            // 
            // audioCodec
            // 
            this.audioCodec.Enabled = false;
            this.audioCodec.FormattingEnabled = true;
            this.audioCodec.Location = new System.Drawing.Point(36, 300);
            this.audioCodec.Name = "audioCodec";
            this.audioCodec.Size = new System.Drawing.Size(136, 20);
            this.audioCodec.TabIndex = 16;
            // 
            // lablear
            // 
            this.lablear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lablear.AutoSize = true;
            this.lablear.Enabled = false;
            this.lablear.Location = new System.Drawing.Point(191, 285);
            this.lablear.Name = "lablear";
            this.lablear.Size = new System.Drawing.Size(41, 12);
            this.lablear.TabIndex = 21;
            this.lablear.Text = "取樣率";
            // 
            // audioSampleRate
            // 
            this.audioSampleRate.Enabled = false;
            this.audioSampleRate.FormattingEnabled = true;
            this.audioSampleRate.Items.AddRange(new object[] {
            "44100",
            "48000",
            "96000",
            "192000"});
            this.audioSampleRate.Location = new System.Drawing.Point(193, 300);
            this.audioSampleRate.Name = "audioSampleRate";
            this.audioSampleRate.Size = new System.Drawing.Size(84, 20);
            this.audioSampleRate.TabIndex = 20;
            // 
            // lablevf
            // 
            this.lablevf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lablevf.AutoSize = true;
            this.lablevf.Enabled = false;
            this.lablevf.Location = new System.Drawing.Point(191, 153);
            this.lablevf.Name = "lablevf";
            this.lablevf.Size = new System.Drawing.Size(23, 12);
            this.lablevf.TabIndex = 23;
            this.lablevf.Text = "FPS";
            // 
            // videoFPS
            // 
            this.videoFPS.Enabled = false;
            this.videoFPS.FormattingEnabled = true;
            this.videoFPS.Items.AddRange(new object[] {
            "(與來源相同)",
            "24",
            "25 (PAL)",
            "29.97 (NTSC)",
            "30",
            "60"});
            this.videoFPS.Location = new System.Drawing.Point(193, 168);
            this.videoFPS.Name = "videoFPS";
            this.videoFPS.Size = new System.Drawing.Size(97, 20);
            this.videoFPS.TabIndex = 22;
            // 
            // lablevwh
            // 
            this.lablevwh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lablevwh.AutoSize = true;
            this.lablevwh.Enabled = false;
            this.lablevwh.Location = new System.Drawing.Point(191, 195);
            this.lablevwh.Name = "lablevwh";
            this.lablevwh.Size = new System.Drawing.Size(29, 12);
            this.lablevwh.TabIndex = 25;
            this.lablevwh.Text = "長寬";
            // 
            // lableVWHX
            // 
            this.lableVWHX.AutoSize = true;
            this.lableVWHX.Enabled = false;
            this.lableVWHX.Location = new System.Drawing.Point(252, 218);
            this.lableVWHX.Name = "lableVWHX";
            this.lableVWHX.Size = new System.Drawing.Size(11, 12);
            this.lableVWHX.TabIndex = 27;
            this.lableVWHX.Text = "x";
            // 
            // videoBitrate
            // 
            this.videoBitrate.Enabled = false;
            this.videoBitrate.Location = new System.Drawing.Point(36, 210);
            this.videoBitrate.Name = "videoBitrate";
            this.videoBitrate.Size = new System.Drawing.Size(84, 22);
            this.videoBitrate.TabIndex = 28;
            // 
            // lableKb_v
            // 
            this.lableKb_v.AutoSize = true;
            this.lableKb_v.Enabled = false;
            this.lableKb_v.Location = new System.Drawing.Point(127, 216);
            this.lableKb_v.Name = "lableKb_v";
            this.lableKb_v.Size = new System.Drawing.Size(24, 12);
            this.lableKb_v.TabIndex = 29;
            this.lableKb_v.Text = "kb/s";
            // 
            // videoWidth
            // 
            this.videoWidth.Enabled = false;
            this.videoWidth.Location = new System.Drawing.Point(193, 210);
            this.videoWidth.Name = "videoWidth";
            this.videoWidth.Size = new System.Drawing.Size(52, 22);
            this.videoWidth.TabIndex = 30;
            // 
            // videoHeight
            // 
            this.videoHeight.Enabled = false;
            this.videoHeight.Location = new System.Drawing.Point(269, 210);
            this.videoHeight.Name = "videoHeight";
            this.videoHeight.Size = new System.Drawing.Size(52, 22);
            this.videoHeight.TabIndex = 31;
            // 
            // labelKb_a
            // 
            this.labelKb_a.AutoSize = true;
            this.labelKb_a.Enabled = false;
            this.labelKb_a.Location = new System.Drawing.Point(126, 350);
            this.labelKb_a.Name = "labelKb_a";
            this.labelKb_a.Size = new System.Drawing.Size(24, 12);
            this.labelKb_a.TabIndex = 32;
            this.labelKb_a.Text = "kb/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKb_a);
            this.Controls.Add(this.videoHeight);
            this.Controls.Add(this.videoWidth);
            this.Controls.Add(this.lableKb_v);
            this.Controls.Add(this.videoBitrate);
            this.Controls.Add(this.lableVWHX);
            this.Controls.Add(this.lablevwh);
            this.Controls.Add(this.lablevf);
            this.Controls.Add(this.videoFPS);
            this.Controls.Add(this.lablear);
            this.Controls.Add(this.audioSampleRate);
            this.Controls.Add(this.lableab);
            this.Controls.Add(this.lableac);
            this.Controls.Add(this.audioBitrate);
            this.Controls.Add(this.audioCodec);
            this.Controls.Add(this.lablevb);
            this.Controls.Add(this.lablevc);
            this.Controls.Add(this.videoCodec);
            this.Controls.Add(this.outputAudio);
            this.Controls.Add(this.outputVideo);
            this.Controls.Add(this.TargetFileButton);
            this.Controls.Add(this.SourceFileButton);
            this.Controls.Add(this.TargetLable);
            this.Controls.Add(this.SourceLable);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TargetFileText);
            this.Controls.Add(this.SourceFileText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FFront Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.OpenFileDialog SourceFileDialog;
        private System.Windows.Forms.CheckBox outputVideo;
        private System.Windows.Forms.SaveFileDialog TargetFileDialog;
        private System.Windows.Forms.CheckBox outputAudio;
        private System.Windows.Forms.TextBox SourceFileText;
        private System.Windows.Forms.TextBox TargetFileText;
        private System.Windows.Forms.Label SourceLable;
        private System.Windows.Forms.Label TargetLable;
        private System.Windows.Forms.Button SourceFileButton;
        private System.Windows.Forms.Button TargetFileButton;
        private System.Windows.Forms.ComboBox videoCodec;
        private System.Windows.Forms.Label lablevc;
        private System.Windows.Forms.Label lablevb;
        private System.Windows.Forms.Label lableab;
        private System.Windows.Forms.Label lableac;
        private System.Windows.Forms.ComboBox audioBitrate;
        private System.Windows.Forms.ComboBox audioCodec;
        private System.Windows.Forms.Label lablear;
        private System.Windows.Forms.ComboBox audioSampleRate;
        private System.Windows.Forms.Label lablevf;
        private System.Windows.Forms.ComboBox videoFPS;
        private System.Windows.Forms.Label lablevwh;
        private System.Windows.Forms.Label lableVWHX;
        private System.Windows.Forms.TextBox videoBitrate;
        private System.Windows.Forms.Label lableKb_v;
        private System.Windows.Forms.TextBox videoWidth;
        private System.Windows.Forms.TextBox videoHeight;
        private System.Windows.Forms.Label labelKb_a;
        private System.Windows.Forms.Label label1;
    }
}

