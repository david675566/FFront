using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FileExtension = "";
        private bool firstTime = true;
        
        private int wtemp;
        private int htemp;

        private StringBuilder ControlARG = new StringBuilder();

        private string[] mp4_video_codecs = new string[]
        {
            "mpeg4",
            "H.264 (建議)",
            "H.264 RGB",
            "H.264 AMD AMF",
            "H.264 Nvidia NVENC",
            "H.264 QSV",
            "HEVC (H.265)",
            "HEVC AMD AMF",
            "HEVC Nvidia NVENC",
            "HEVC QSV"
        };
        private string[] mp4_audio_codecs = new string[] {
            "AAC",
            "Vorbis"
        };
        private string[] webm_video_codecs = new string[]
        {
            "VP8",
            "VP9 (推薦)"
        };
        private string[] webm_audio_codecs = new string[] {
            "Opus",
            "Vorbis"
        };

        //Really?
        private string ffmpegDir = Directory.GetCurrentDirectory() +  "\\ffmpeg\\bin\\ffmpeg.exe";

        private int findFilterIndex(string[] splited)
        {
            Console.WriteLine(TargetFileDialog.Filter);
            Console.WriteLine("Target: " + FileExtension);

            //Get index number
            int index = Array.IndexOf(splited, "*." + FileExtension);
            int actualIndex = (index + 1) >> 1;
            
            Console.WriteLine("In string: " + index);
            Console.WriteLine("FilterIndex: " + actualIndex);

            //Return
            return actualIndex;
        }

        private string changeExtension(string source) {
            //Split file name into "name", "extentsion"
            string[] splited = source.Split('.');
            Console.WriteLine("before: " + splited[1]);

            /* Currently I only have two formats available,
             * since it's FFmpeg, I'll add more in future (not too hard)
             */
            if (splited[1].Equals("webm"))
                splited[1] = "mp4";
            else
                splited[1] = "webm";

            Console.WriteLine("after: " + splited[1]);

            //Save extension for later use
            FileExtension = splited[1];

            //Join modifilded strings and return
            return string.Join(".", splited);
        }

        private void Video_AdditionalOptions(bool state) {
            //All options
            videoBitrate.Enabled = state;
            videoCodec.Enabled = state;
            videoFPS.Enabled = state;
            videoHeight.Enabled = state;
            videoWidth.Enabled = state;

            //Text
            lablevb.Enabled = state;
            lablevc.Enabled = state;
            lablevf.Enabled = state;
            lablevwh.Enabled = state;
            lableKb_v.Enabled = state;
            lableVWHX.Enabled = state;
        }

        private void Audio_AdditionalOptions(bool state) {
            //All options
            audioBitrate.Enabled = state;
            audioCodec.Enabled = state;
            audioSampleRate.Enabled = state;

            //Text
            lableab.Enabled = state;
            lableac.Enabled = state;
            lablear.Enabled = state;
            labelKb_a.Enabled = state;
        }

        private void Video_DefaultOptions() {
            //Determine the format
            if (string.Equals(FileExtension, "mp4"))
            {
                videoCodec.Items.Clear();
                videoCodec.Items.AddRange(mp4_video_codecs);
            }
            else
            {
                videoCodec.Items.Clear();
                videoCodec.Items.AddRange(webm_video_codecs);
            }
            

            //Default items
            videoCodec.SelectedIndex = 1;
            videoFPS.SelectedIndex = 0;
            videoBitrate.Text = "3500";
            videoHeight.Text = "(來源)";
            videoWidth.Text = "(來源)";
        }

        private void Audio_DefaultOptions() {
            //Determine the format
            if (string.Equals(FileExtension, "mp4"))
            {
                audioCodec.Items.Clear();
                audioCodec.Items.AddRange(mp4_audio_codecs);
            }
            else
            {
                audioCodec.Items.Clear();
                audioCodec.Items.AddRange(webm_audio_codecs);
            }


            //Default items
            audioCodec.SelectedIndex = 0;
            audioSampleRate.SelectedIndex = 1;
            audioBitrate.SelectedIndex = 1;
        }

        /*private void DEBUG_print_result() {
            Console.WriteLine(
               "OutputVideo\nCodec: {0}\nFPS: {1}\nBitrate: {2}\nResolution: {3}*{4}\n",
                videoCodec.SelectedItem.ToString(),
                videoFPS.SelectedItem.ToString(),
                videoBitrate.Text,
                videoWidth.Text,
                videoHeight.Text
            );
            Console.WriteLine(
                "Argument:\nffmpeg{0}",
                ControlARG.ToString()
            );
        }*/

        private void outputVideo_CheckStateChanged(object sender, EventArgs e)
        {
            Console.WriteLine(outputVideo.Checked);
            Video_AdditionalOptions(outputVideo.Checked);
        }

        private void outputAudio_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(outputAudio.Checked);
            Audio_AdditionalOptions(outputAudio.Checked);
        }

        private void outputVideo_EnabledChanged(object sender, EventArgs e)
        {
            outputVideo.CheckState = CheckState.Checked;
        }

        private void outputAudio_EnabledChanged(object sender, EventArgs e)
        {
            outputAudio.CheckState = CheckState.Checked;
        }

        private void SourceFileButton_Click(object sender, EventArgs e)
        {
            //Show Dialog
            DialogResult result = SourceFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                //Set file name
                SourceFileText.Text = SourceFileDialog.FileName;
                TargetFileDialog.FileName = changeExtension(SourceFileDialog.SafeFileName);
                TargetFileText.Text = changeExtension(SourceFileText.Text);

                Video_DefaultOptions();
                Audio_DefaultOptions();

                //Check if it's the first time since program started
                if (firstTime) {

                    //Enable all options
                    outputVideo.Enabled = true;
                    outputAudio.Enabled = true;

                    firstTime = false;
                }
            }

            //Debugger
            Console.WriteLine(result);
        }
        
        private void TargetFileButton_Click(object sender, EventArgs e)
        {
            string[] splited = TargetFileDialog.Filter.Split('|');
            
            int afterIndex = findFilterIndex(splited);

            TargetFileDialog.FilterIndex = afterIndex;

            DialogResult result = TargetFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TargetFileText.Text = TargetFileDialog.FileName;
            }

            //Debugger
            Console.WriteLine(result);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!(outputAudio.Checked || outputVideo.Checked))
            {
                Console.WriteLine("At least one output!");
            }
            else {
                ControlARG.AppendFormat(" -i \"{0}\"", SourceFileText.Text);
                if (outputVideo.Checked)
                {

                    int.TryParse(videoWidth.Text, out wtemp);
                    int.TryParse(videoHeight.Text, out htemp);

                    ControlARG.Append(" -c:v ");

                    //Codec
                    if (string.Equals(FileExtension, "mp4"))
                    {
                        switch (videoCodec.SelectedIndex)
                        {
                            case 0: ControlARG.Append("mpeg4"); break;
                            case 1: ControlARG.Append("libx264"); break;
                            case 2: ControlARG.Append("libx264rgb"); break;
                            case 3: ControlARG.Append("libx264_amf"); break;
                            case 4: ControlARG.Append("libx264_nvenc"); break;
                            case 5: ControlARG.Append("libx264_qsv"); break;
                            case 6: ControlARG.Append("libx265"); break;
                            case 7: ControlARG.Append("hevc_amf"); break;
                            case 8: ControlARG.Append("hevc_nvenc"); break;
                            case 9: ControlARG.Append("hevc_qsv"); break;
                        }
                    }
                    else
                    {
                        switch (videoCodec.SelectedIndex)
                        {
                            case 0: ControlARG.Append("libvpx"); break;
                            case 1: ControlARG.Append("libvpx-vp9"); break;
                        }
                    }

                    //Bitrate
                    ControlARG.AppendFormat(" -b:v {0}000", videoBitrate.Text);

                    //Framerate
                    if (videoFPS.SelectedIndex != 0) {

                        //God dammit NTSC
                        ControlARG.AppendFormat(" -r {0}", 
                            videoFPS.SelectedIndex==3?"30000/1001":videoFPS.SelectedItem.ToString()
                        );
                    }

                    //Resolution Scale
                    if (wtemp > 0 || htemp > 0)
                    {
                        ControlARG.Append(" -vf scale=");
                        if (wtemp > 0 && htemp > 0)
                            ControlARG.AppendFormat("{0}:{1}", videoWidth.Text, videoHeight.Text);
                        else if (wtemp < 1)
                            ControlARG.AppendFormat("-1:{0}", videoHeight.Text);
                        else
                            ControlARG.AppendFormat("{0}:-1", videoWidth.Text);
                    }


                }
                else {
                    ControlARG.Append(" -vn");
                }
                if (outputAudio.Checked) {
                    ControlARG.Append(" -c:a ");

                    //Codec
                    if (string.Equals(FileExtension, "mp4"))
                    {
                        switch (audioCodec.SelectedIndex)
                        {
                            case 0: ControlARG.Append("aac"); break;
                            case 1: ControlARG.Append("libvorbis"); break;
                        }
                    }
                    else
                    {
                        switch (audioCodec.SelectedIndex)
                        {
                            case 0: ControlARG.Append("libopus"); break;
                            case 1: ControlARG.Append("libvorbis"); break;
                        }
                    }

                    //Bitrate
                    ControlARG.AppendFormat(" -b:a {0}000", audioBitrate.Text);

                    //Sample Rate
                    ControlARG.AppendFormat(" -ar {0}", audioSampleRate.SelectedItem.ToString());
                }
                else
                {
                    ControlARG.Append(" -an");
                }

                ControlARG.AppendFormat(" \"{0}\"", TargetFileText.Text);

                //DEBUG_print_result();
                System.Diagnostics.Process.Start(ffmpegDir, ControlARG.ToString());

                ControlARG.Clear();
            }
        }
    }
}
