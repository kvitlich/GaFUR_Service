namespace Sys_Watcher_GaFUR
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.dataVolume = new System.Windows.Forms.TextBox();
            this.meteringInterval = new System.Windows.Forms.TextBox();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.ProccessVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(330, 485);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(184, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "НАЧАТЬ ИЗМЕРЕНИЯ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start);
            // 
            // dataVolume
            // 
            this.dataVolume.Location = new System.Drawing.Point(12, 12);
            this.dataVolume.Name = "dataVolume";
            this.dataVolume.Size = new System.Drawing.Size(502, 22);
            this.dataVolume.TabIndex = 1;
            this.dataVolume.Text = "Введите объем данных (количество измерений)";
            this.dataVolume.TextChanged += new System.EventHandler(this.dataVolume_TextChanged);
            // 
            // meteringInterval
            // 
            this.meteringInterval.Location = new System.Drawing.Point(13, 41);
            this.meteringInterval.Name = "meteringInterval";
            this.meteringInterval.Size = new System.Drawing.Size(501, 22);
            this.meteringInterval.TabIndex = 2;
            this.meteringInterval.Text = "Введите интервал между каждым измерением (в милесекундах)";
            this.meteringInterval.TextChanged += new System.EventHandler(this.meteringInterval_TextChanged);
            // 
            // mainGrid
            // 
            this.mainGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProccessVolume});
            this.mainGrid.Location = new System.Drawing.Point(12, 69);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersWidth = 51;
            this.mainGrid.RowTemplate.Height = 24;
            this.mainGrid.Size = new System.Drawing.Size(502, 395);
            this.mainGrid.TabIndex = 3;
            this.mainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProccessVolume
            // 
            this.ProccessVolume.HeaderText = "Нагруженность процессора (%)";
            this.ProccessVolume.MinimumWidth = 6;
            this.ProccessVolume.Name = "ProccessVolume";
            this.ProccessVolume.Width = 320;
            // 
            // middleValue
            // 
            this.middleValue.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.middleValue.Location = new System.Drawing.Point(13, 491);
            this.middleValue.Name = "middleValue";
            this.middleValue.Size = new System.Drawing.Size(311, 22);
            this.middleValue.TabIndex = 4;
            this.middleValue.Text = "Среднее значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 532);
            this.Controls.Add(this.middleValue);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.meteringInterval);
            this.Controls.Add(this.dataVolume);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "ГаФУР";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox dataVolume;
        private System.Windows.Forms.TextBox meteringInterval;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProccessVolume;
        private System.Windows.Forms.TextBox middleValue;
    }
}