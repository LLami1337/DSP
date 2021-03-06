﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP
{
    public partial class DSP : Form
    {
        public DSP()
        {
            InitializeComponent();
        }

        private void aboutMenuTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программу DSP разработали:\n" +
                "Сибен Андрей, Сосновская Ксения\n" +
                "Разработанные функции:\n" +
                "...",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void openFileTool_Click(object sender, EventArgs e)
        {
            string fileName = "", fileText = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовый файл(*.txt)|*.txt|" +
                "DAT-файл(*.dat)|*.dat|" +
                "Файл аудиопотока(*.wav)|*.wav|" +
                "Звуковой файл(*.mp3)|*.mp3|" +
                "Видео файл(*.avi)|*.avi|";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = dialog.FileName;
                fileText = System.IO.File.ReadAllText(fileName);
            }
        }
    }
}
