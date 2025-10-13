namespace CsvReadWrite
{
    partial class Form1
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
        private void InitializeComponent()
        {
            textBoxInputCSVFileName = new TextBox();
            buttonCsvRead = new Button();
            dataGridViewCsv = new DataGridView();
            textBoxOutputCSVFileName = new TextBox();
            buttonCsvWrite = new Button();
            openFileDialogCsv = new OpenFileDialog();
            saveFileDialogCsv = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).BeginInit();
            SuspendLayout();
            // 
            // textBoxInputCSVFileName
            // 
            textBoxInputCSVFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInputCSVFileName.Location = new Point(0, 0);
            textBoxInputCSVFileName.Name = "textBoxInputCSVFileName";
            textBoxInputCSVFileName.Size = new Size(414, 23);
            textBoxInputCSVFileName.TabIndex = 0;
            // 
            // buttonCsvRead
            // 
            buttonCsvRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCsvRead.Location = new Point(430, 0);
            buttonCsvRead.Name = "buttonCsvRead";
            buttonCsvRead.Size = new Size(75, 23);
            buttonCsvRead.TabIndex = 1;
            buttonCsvRead.Text = "CSV取得";
            buttonCsvRead.UseVisualStyleBackColor = true;
            buttonCsvRead.Click += buttonCsvRead_Click_1;
            // 
            // dataGridViewCsv
            // 
            dataGridViewCsv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCsv.Location = new Point(12, 29);
            dataGridViewCsv.Name = "dataGridViewCsv";
            dataGridViewCsv.Size = new Size(402, 207);
            dataGridViewCsv.TabIndex = 2;
            // 
            // textBoxOutputCSVFileName
            // 
            textBoxOutputCSVFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutputCSVFileName.Location = new Point(12, 242);
            textBoxOutputCSVFileName.Name = "textBoxOutputCSVFileName";
            textBoxOutputCSVFileName.Size = new Size(402, 23);
            textBoxOutputCSVFileName.TabIndex = 3;
            // 
            // buttonCsvWrite
            // 
            buttonCsvWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCsvWrite.Location = new Point(420, 242);
            buttonCsvWrite.Name = "buttonCsvWrite";
            buttonCsvWrite.Size = new Size(75, 23);
            buttonCsvWrite.TabIndex = 4;
            buttonCsvWrite.Text = "CSV出力";
            buttonCsvWrite.UseVisualStyleBackColor = true;
            buttonCsvWrite.Click += buttonCsvWrite_Click;
            // 
            // openFileDialogCsv
            // 
            openFileDialogCsv.FileName = "*.csv";
            openFileDialogCsv.InitialDirectory = ".\\";
            // 
            // saveFileDialogCsv
            // 
            saveFileDialogCsv.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCsvWrite);
            Controls.Add(textBoxOutputCSVFileName);
            Controls.Add(dataGridViewCsv);
            Controls.Add(buttonCsvRead);
            Controls.Add(textBoxInputCSVFileName);
            Name = "Form1";
            Text = "CSVの読み書き";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCsv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputCSVFileName;
        private Button buttonCsvRead;
        private DataGridView dataGridViewCsv;
        private TextBox textBoxOutputCSVFileName;
        private Button buttonCsvWrite;
        private OpenFileDialog openFileDialogCsv;
        private SaveFileDialog saveFileDialogCsv;
    }
}
