namespace CLearn.forms
{
    partial class OrganizatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizatorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.participantsBtn = new System.Windows.Forms.Button();
            this.juriBtn = new System.Windows.Forms.Button();
            this.introLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Окно организатора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(47, 128);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(176, 175);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.profileBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.Location = new System.Drawing.Point(47, 344);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(176, 29);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Мой профиль";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // eventsBtn
            // 
            this.eventsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.eventsBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventsBtn.Location = new System.Drawing.Point(480, 183);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Size = new System.Drawing.Size(121, 48);
            this.eventsBtn.TabIndex = 3;
            this.eventsBtn.Text = "Мероприятия";
            this.eventsBtn.UseVisualStyleBackColor = false;
            this.eventsBtn.Click += new System.EventHandler(this.eventsBtn_Click);
            this.eventsBtn.MouseCaptureChanged += new System.EventHandler(this.button1_MouseCaptureChanged);
            // 
            // participantsBtn
            // 
            this.participantsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.participantsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.participantsBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.participantsBtn.Location = new System.Drawing.Point(479, 232);
            this.participantsBtn.Name = "participantsBtn";
            this.participantsBtn.Size = new System.Drawing.Size(121, 45);
            this.participantsBtn.TabIndex = 4;
            this.participantsBtn.Text = "Участники";
            this.participantsBtn.UseVisualStyleBackColor = false;
            this.participantsBtn.MouseCaptureChanged += new System.EventHandler(this.button1_MouseCaptureChanged);
            // 
            // juriBtn
            // 
            this.juriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.juriBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.juriBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.juriBtn.Location = new System.Drawing.Point(479, 280);
            this.juriBtn.Name = "juriBtn";
            this.juriBtn.Size = new System.Drawing.Size(121, 42);
            this.juriBtn.TabIndex = 5;
            this.juriBtn.Text = "Жюри";
            this.juriBtn.UseVisualStyleBackColor = false;
            this.juriBtn.Click += new System.EventHandler(this.juriBtn_Click);
            this.juriBtn.MouseCaptureChanged += new System.EventHandler(this.button1_MouseCaptureChanged);
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introLabel.Location = new System.Drawing.Point(272, 111);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(528, 24);
            this.introLabel.TabIndex = 6;
            this.introLabel.Text = "Доброе";
            this.introLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrganizatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.juriBtn);
            this.Controls.Add(this.participantsBtn);
            this.Controls.Add(this.eventsBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrganizatorForm_FormClosing);
            this.Load += new System.EventHandler(this.OrganizatorForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox avatar;
        private Button profileBtn;
        private Button eventsBtn;
        private Button participantsBtn;
        private Button juriBtn;
        private Label introLabel;
    }
}