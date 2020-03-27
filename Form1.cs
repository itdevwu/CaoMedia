using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaoMedia
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            string _filePathName;
            OpenFileDialog _fileDialog = new OpenFileDialog();
            _fileDialog.Multiselect = false;
            _fileDialog.Title = "请选择想要处理的音频或视频文件";
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePathName = _fileDialog.FileName;
            }
            else
            {
                _filePathName = "";
            }
            inputPathBox.Text = _filePathName;
        }

        private void inputPathBox_TextChanged(object sender, EventArgs e)
        {
            string _tmp = inputPathBox.Text;
            // TODO: set output path as input file automatically
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog _fileDialog = new FolderBrowserDialog();
            _fileDialog.Description = "请选择输出文件保存的位置";
            if (_fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(_fileDialog.SelectedPath))
                {
                    MessageBox.Show("选择路径不能为空", "提示");
                    return;
                }
            }
            outputPathTextBox.Text = _fileDialog.SelectedPath;
        }

        private void exitTopStripe_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("确定要关闭程序吗？（未完成的任务可能出现问题）", "退出程序", MessageBoxButtons.YesNo);
            if (_result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void ultrafastModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void versionTopStripe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CaoMedia：一个简单好用的音视频处理工具\nDeveloped by Zhenglong WU\n版本 0.1.0", "版本信息");
        }

        private bool readyForConvert()
        {
            bool _status;
            if (inputPathBox.TextLength > 0 && outputPathTextBox.TextLength > 0 && formatComboBox.SelectedIndex > -1)
                _status = true;
            else
                _status = false;
            return _status;
        }

        private void ffConvert()
        {
            convertProgressBar.Value = 10;
            ConvertMissionClass convertMission = new ConvertMissionClass();
            convertMission.inputFilePathName = inputPathBox.Text;
            convertMission.outputFormat = formatComboBox.SelectedIndex + 1;
            convertMission.outputFilePath = outputPathTextBox.Text;
            if (ultrafastModeCheckBox.Checked)
            {
                convertMission.ultraFastMode = true;
            }
            convertMission.ffmpegConvert();
            convertProgressBar.Value = 100;
            MessageBox.Show("处理完成！", "完成提示");
        }

        private void startConvertButton_Click(object sender, EventArgs e)
        {
            if (readyForConvert() == true)
            {
                ffConvert();
            }
            else
            {
                MessageBox.Show("不能进行转换！\n尚未完成设置！", "错误");
            }
        }
    }
}
