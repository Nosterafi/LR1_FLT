namespace UI
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxInput = new RichTextBox();
            buttonAnalyze = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridViewRecognizedTokens = new DataGridView();
            Токен = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            richTextBoxMessages = new RichTextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecognizedTokens).BeginInit();
            SuspendLayout();
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Location = new Point(29, 168);
            richTextBoxInput.Margin = new Padding(4, 5, 4, 5);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(485, 392);
            richTextBoxInput.TabIndex = 1;
            richTextBoxInput.Text = "";
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Location = new Point(189, 591);
            buttonAnalyze.Margin = new Padding(4, 5, 4, 5);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new Size(183, 52);
            buttonAnalyze.TabIndex = 2;
            buttonAnalyze.Text = "Анализировать текст";
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += buttonAnalyze_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Входной текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(419, 20);
            label2.TabIndex = 4;
            label2.Text = "Регулярное выражение слов первого типа: (011)*001(010)*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(510, 20);
            label3.TabIndex = 5;
            label3.Text = "Регулярное выражение слов второго типа: (a|b|c|d)+ (без \"aa\" в конце) ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 86);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(284, 20);
            label4.TabIndex = 6;
            label4.Text = "Комментарий: многострочный  {  ........  }";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(540, 143);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 8;
            label5.Text = "Распознанные токены:";
            // 
            // dataGridViewRecognizedTokens
            // 
            dataGridViewRecognizedTokens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecognizedTokens.Columns.AddRange(new DataGridViewColumn[] { Токен, Column1, Column2, Column3, Column4 });
            dataGridViewRecognizedTokens.Location = new Point(544, 168);
            dataGridViewRecognizedTokens.Margin = new Padding(4, 5, 4, 5);
            dataGridViewRecognizedTokens.Name = "dataGridViewRecognizedTokens";
            dataGridViewRecognizedTokens.ReadOnly = true;
            dataGridViewRecognizedTokens.RowHeadersWidth = 51;
            dataGridViewRecognizedTokens.Size = new Size(524, 394);
            dataGridViewRecognizedTokens.TabIndex = 9;
            // 
            // Токен
            // 
            Токен.HeaderText = "№";
            Токен.MinimumWidth = 6;
            Токен.Name = "Токен";
            Токен.ReadOnly = true;
            Токен.Width = 30;
            // 
            // Column1
            // 
            Column1.HeaderText = "Токен";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Тип токена";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Индекс строки";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.HeaderText = "Индекс символа";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 60;
            // 
            // richTextBoxMessages
            // 
            richTextBoxMessages.Location = new Point(29, 685);
            richTextBoxMessages.Margin = new Padding(4, 5, 4, 5);
            richTextBoxMessages.Name = "richTextBoxMessages";
            richTextBoxMessages.Size = new Size(1037, 126);
            richTextBoxMessages.TabIndex = 10;
            richTextBoxMessages.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 660);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Сообщения:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 832);
            Controls.Add(label6);
            Controls.Add(richTextBoxMessages);
            Controls.Add(dataGridViewRecognizedTokens);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAnalyze);
            Controls.Add(richTextBoxInput);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Лабораторная работа № 1 - Разработка лексического анализатора";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecognizedTokens).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewRecognizedTokens;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Токен;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}