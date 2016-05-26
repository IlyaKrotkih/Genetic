namespace Genetic
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIteration = new System.Windows.Forms.Label();
            this.lblMaxIteration = new System.Windows.Forms.Label();
            this.numMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPopulationCount = new System.Windows.Forms.Label();
            this.numPopulationCount = new System.Windows.Forms.NumericUpDown();
            this.lstIteration = new System.Windows.Forms.ListBox();
            this.btnParrents = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnMutation = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIteration
            // 
            this.txtIteration.AutoSize = true;
            this.txtIteration.Location = new System.Drawing.Point(12, 61);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(56, 13);
            this.txtIteration.TabIndex = 1;
            this.txtIteration.Text = "Итерация";
            // 
            // lblMaxIteration
            // 
            this.lblMaxIteration.AutoSize = true;
            this.lblMaxIteration.Location = new System.Drawing.Point(12, 9);
            this.lblMaxIteration.Name = "lblMaxIteration";
            this.lblMaxIteration.Size = new System.Drawing.Size(166, 13);
            this.lblMaxIteration.TabIndex = 2;
            this.lblMaxIteration.Text = "Максимальное число итераций";
            // 
            // numMaxIteration
            // 
            this.numMaxIteration.Location = new System.Drawing.Point(184, 7);
            this.numMaxIteration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxIteration.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numMaxIteration.Name = "numMaxIteration";
            this.numMaxIteration.Size = new System.Drawing.Size(94, 20);
            this.numMaxIteration.TabIndex = 3;
            this.numMaxIteration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(284, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 49);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPopulationCount
            // 
            this.lblPopulationCount.AutoSize = true;
            this.lblPopulationCount.Location = new System.Drawing.Point(12, 35);
            this.lblPopulationCount.Name = "lblPopulationCount";
            this.lblPopulationCount.Size = new System.Drawing.Size(130, 13);
            this.lblPopulationCount.TabIndex = 2;
            this.lblPopulationCount.Text = "Численность популяции";
            // 
            // numPopulationCount
            // 
            this.numPopulationCount.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationCount.Location = new System.Drawing.Point(184, 33);
            this.numPopulationCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numPopulationCount.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numPopulationCount.Name = "numPopulationCount";
            this.numPopulationCount.Size = new System.Drawing.Size(94, 20);
            this.numPopulationCount.TabIndex = 3;
            this.numPopulationCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numPopulationCount.ValueChanged += new System.EventHandler(this.numPopulationCount_ValueChanged);
            // 
            // lstIteration
            // 
            this.lstIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIteration.FormattingEnabled = true;
            this.lstIteration.Location = new System.Drawing.Point(74, 61);
            this.lstIteration.Name = "lstIteration";
            this.lstIteration.Size = new System.Drawing.Size(285, 199);
            this.lstIteration.TabIndex = 5;
            this.lstIteration.SelectedIndexChanged += new System.EventHandler(this.lstIteration_SelectedIndexChanged);
            // 
            // btnParrents
            // 
            this.btnParrents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParrents.Location = new System.Drawing.Point(15, 271);
            this.btnParrents.Name = "btnParrents";
            this.btnParrents.Size = new System.Drawing.Size(75, 23);
            this.btnParrents.TabIndex = 6;
            this.btnParrents.Text = "Родители";
            this.btnParrents.UseVisualStyleBackColor = true;
            this.btnParrents.Click += new System.EventHandler(this.btnParrents_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelection.Location = new System.Drawing.Point(96, 271);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(95, 23);
            this.btnSelection.TabIndex = 7;
            this.btnSelection.Text = "Скрещивание";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnMutation
            // 
            this.btnMutation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMutation.Location = new System.Drawing.Point(197, 271);
            this.btnMutation.Name = "btnMutation";
            this.btnMutation.Size = new System.Drawing.Size(81, 23);
            this.btnMutation.TabIndex = 8;
            this.btnMutation.Text = "Мутация";
            this.btnMutation.UseVisualStyleBackColor = true;
            this.btnMutation.Click += new System.EventHandler(this.btnMutation_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer.Location = new System.Drawing.Point(284, 271);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 9;
            this.btnAnswer.Text = "Итог";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 311);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnMutation);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnParrents);
            this.Controls.Add(this.lstIteration);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numPopulationCount);
            this.Controls.Add(this.lblPopulationCount);
            this.Controls.Add(this.numMaxIteration);
            this.Controls.Add(this.lblMaxIteration);
            this.Controls.Add(this.txtIteration);
            this.Name = "FormMain";
            this.Text = "Генетические алгоритмы";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtIteration;
        private System.Windows.Forms.Label lblMaxIteration;
        private System.Windows.Forms.NumericUpDown numMaxIteration;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPopulationCount;
        private System.Windows.Forms.NumericUpDown numPopulationCount;
        private System.Windows.Forms.ListBox lstIteration;
        private System.Windows.Forms.Button btnParrents;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnMutation;
        private System.Windows.Forms.Button btnAnswer;
    }
}

