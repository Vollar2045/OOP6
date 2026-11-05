namespace OOP6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAdapterLog;
        private System.Windows.Forms.Button btnAdapterTest;
        private System.Windows.Forms.Label lblAdapterInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.NumericUpDown numArea;
        private System.Windows.Forms.NumericUpDown numResidents;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numWear;
        private System.Windows.Forms.NumericUpDown numTerm;
        private System.Windows.Forms.Button btnCalculateInsurance;
        private System.Windows.Forms.Label lblInsuranceResult;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblAdapterInfo = new Label();
            btnAdapterTest = new Button();
            txtAdapterLog = new TextBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            cmbPropertyType = new ComboBox();
            label2 = new Label();
            numArea = new NumericUpDown();
            label3 = new Label();
            numResidents = new NumericUpDown();
            label4 = new Label();
            numYear = new NumericUpDown();
            label5 = new Label();
            numWear = new NumericUpDown();
            label6 = new Label();
            numTerm = new NumericUpDown();
            btnCalculateInsurance = new Button();
            lblInsuranceResult = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResidents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTerm).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblAdapterInfo);
            tabPage1.Controls.Add(btnAdapterTest);
            tabPage1.Controls.Add(txtAdapterLog);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(592, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Адаптер (Газ)";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAdapterInfo
            // 
            lblAdapterInfo.AutoSize = true;
            lblAdapterInfo.Font = new Font("Segoe UI", 18F);
            lblAdapterInfo.Location = new Point(20, 20);
            lblAdapterInfo.Name = "lblAdapterInfo";
            lblAdapterInfo.Size = new Size(182, 32);
            lblAdapterInfo.TabIndex = 0;
            lblAdapterInfo.Text = "Баллон с газом";
            // 
            // btnAdapterTest
            // 
            btnAdapterTest.Location = new Point(208, 20);
            btnAdapterTest.Name = "btnAdapterTest";
            btnAdapterTest.Size = new Size(250, 40);
            btnAdapterTest.TabIndex = 1;
            btnAdapterTest.Text = "Запустить тест адаптера";
            btnAdapterTest.Click += btnAdapterTest_Click;
            // 
            // txtAdapterLog
            // 
            txtAdapterLog.Font = new Font("Consolas", 10F);
            txtAdapterLog.Location = new Point(20, 66);
            txtAdapterLog.Multiline = true;
            txtAdapterLog.Name = "txtAdapterLog";
            txtAdapterLog.ReadOnly = true;
            txtAdapterLog.ScrollBars = ScrollBars.Vertical;
            txtAdapterLog.Size = new Size(549, 374);
            txtAdapterLog.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cmbPropertyType);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(numArea);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(numResidents);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(numYear);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(numWear);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(numTerm);
            tabPage2.Controls.Add(btnCalculateInsurance);
            tabPage2.Controls.Add(lblInsuranceResult);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(192, 70);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Фасад (Страховка)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 0;
            label1.Text = "Тип недвижимости:";
            // 
            // cmbPropertyType
            // 
            cmbPropertyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropertyType.Items.AddRange(new object[] { "квартира", "таун-хаус", "коттедж" });
            cmbPropertyType.Location = new Point(220, 18);
            cmbPropertyType.Name = "cmbPropertyType";
            cmbPropertyType.Size = new Size(200, 25);
            cmbPropertyType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 2;
            label2.Text = "Площадь (м2):";
            // 
            // numArea
            // 
            numArea.Location = new Point(220, 58);
            numArea.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numArea.Name = "numArea";
            numArea.Size = new Size(120, 25);
            numArea.TabIndex = 3;
            numArea.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 4;
            label3.Text = "Проживающих:";
            // 
            // numResidents
            // 
            numResidents.Location = new Point(220, 98);
            numResidents.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numResidents.Name = "numResidents";
            numResidents.Size = new Size(120, 25);
            numResidents.TabIndex = 5;
            numResidents.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 6;
            label4.Text = "Год постройки:";
            // 
            // numYear
            // 
            numYear.Location = new Point(220, 138);
            numYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 25);
            numYear.TabIndex = 7;
            numYear.Value = new decimal(new int[] { 2010, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 8;
            label5.Text = "Износ (%):";
            // 
            // numWear
            // 
            numWear.Location = new Point(220, 178);
            numWear.Name = "numWear";
            numWear.Size = new Size(120, 25);
            numWear.TabIndex = 9;
            numWear.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 10;
            label6.Text = "Срок (лет):";
            // 
            // numTerm
            // 
            numTerm.Location = new Point(220, 218);
            numTerm.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numTerm.Name = "numTerm";
            numTerm.Size = new Size(120, 25);
            numTerm.TabIndex = 11;
            numTerm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalculateInsurance
            // 
            btnCalculateInsurance.Location = new Point(20, 270);
            btnCalculateInsurance.Name = "btnCalculateInsurance";
            btnCalculateInsurance.Size = new Size(250, 40);
            btnCalculateInsurance.TabIndex = 12;
            btnCalculateInsurance.Text = "Рассчитать страховку";
            btnCalculateInsurance.Click += btnCalculateInsurance_Click;
            // 
            // lblInsuranceResult
            // 
            lblInsuranceResult.AutoSize = true;
            lblInsuranceResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInsuranceResult.ForeColor = Color.DarkGreen;
            lblInsuranceResult.Location = new Point(20, 330);
            lblInsuranceResult.Name = "lblInsuranceResult";
            lblInsuranceResult.Size = new Size(221, 25);
            lblInsuranceResult.TabIndex = 13;
            lblInsuranceResult.Text = "Результат: ожидание...";
            // 
            // Form1
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Адаптер и Фасад";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResidents).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTerm).EndInit();
            ResumeLayout(false);
        }
    }
}