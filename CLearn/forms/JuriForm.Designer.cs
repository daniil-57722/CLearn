namespace CLearn.forms
{
    partial class JuriForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuriForm));
            this.amountLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.eventBox2 = new System.Windows.Forms.ComboBox();
            this.personBox = new System.Windows.Forms.ComboBox();
            this.personList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personList)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLbl.Location = new System.Drawing.Point(180, 417);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(51, 20);
            this.amountLbl.TabIndex = 17;
            this.amountLbl.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.findButton.Location = new System.Drawing.Point(599, 103);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(94, 29);
            this.findButton.TabIndex = 15;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // eventBox2
            // 
            this.eventBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventBox2.FormattingEnabled = true;
            this.eventBox2.Location = new System.Drawing.Point(178, 100);
            this.eventBox2.Name = "eventBox2";
            this.eventBox2.Size = new System.Drawing.Size(362, 28);
            this.eventBox2.TabIndex = 14;
            // 
            // personBox
            // 
            this.personBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personBox.FormattingEnabled = true;
            this.personBox.Location = new System.Drawing.Point(178, 68);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(362, 28);
            this.personBox.TabIndex = 13;
            // 
            // personList
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personList.Location = new System.Drawing.Point(3, 145);
            this.personList.Name = "personList";
            this.personList.RowHeadersWidth = 51;
            this.personList.RowTemplate.Height = 29;
            this.personList.Size = new System.Drawing.Size(795, 266);
            this.personList.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Мероприятие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(349, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ЖЮРИ/МОДЕРАТОРЫ";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(587, 415);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(94, 29);
            this.regButton.TabIndex = 18;
            this.regButton.Text = "Зарегистрировать";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // JuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.eventBox2);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JuriForm";
            this.Load += new System.EventHandler(this.JuriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label amountLbl;
        private Label label4;
        private Button findButton;
        private ComboBox eventBox2;
        private ComboBox personBox;
        private DataGridView personList;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button regButton;
    }
}