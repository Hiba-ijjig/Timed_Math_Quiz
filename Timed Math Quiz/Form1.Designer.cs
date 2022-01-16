
namespace Timed_Math_Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.addright = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addLeft = new System.Windows.Forms.Label();
            this.sumRess = new System.Windows.Forms.NumericUpDown();
            this.minusRes = new System.Windows.Forms.NumericUpDown();
            this.minusLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.divRes = new System.Windows.Forms.NumericUpDown();
            this.divLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mulRes = new System.Windows.Forms.NumericUpDown();
            this.mulLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mulRight = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sumRess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(184, 23);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(69, 20);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time left";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLeftLabel.Location = new System.Drawing.Point(78, 65);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 1;
            this.PlusLeftLabel.Text = "+";
            this.PlusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(276, 16);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(120, 30);
            this.timer.TabIndex = 6;
            this.timer.Click += new System.EventHandler(this.label1_Click);
            // 
            // addright
            // 
            this.addright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addright.Location = new System.Drawing.Point(144, 65);
            this.addright.Name = "addright";
            this.addright.Size = new System.Drawing.Size(60, 50);
            this.addright.TabIndex = 7;
            this.addright.Text = "?";
            this.addright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addright.Click += new System.EventHandler(this.plusRightLabel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addLeft
            // 
            this.addLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLeft.Location = new System.Drawing.Point(12, 65);
            this.addLeft.Name = "addLeft";
            this.addLeft.Size = new System.Drawing.Size(60, 50);
            this.addLeft.TabIndex = 9;
            this.addLeft.Text = "?";
            this.addLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumRess
            // 
            this.sumRess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumRess.Location = new System.Drawing.Point(276, 80);
            this.sumRess.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumRess.Name = "sumRess";
            this.sumRess.Size = new System.Drawing.Size(120, 23);
            this.sumRess.TabIndex = 10;
            this.sumRess.ValueChanged += new System.EventHandler(this.Answer);
            this.sumRess.Enter += new System.EventHandler(this.sumRess_Enter);
            // 
            // minusRes
            // 
            this.minusRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRes.Location = new System.Drawing.Point(276, 140);
            this.minusRes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minusRes.Name = "minusRes";
            this.minusRes.Size = new System.Drawing.Size(120, 23);
            this.minusRes.TabIndex = 15;
            this.minusRes.ValueChanged += new System.EventHandler(this.Answer);
            this.minusRes.Enter += new System.EventHandler(this.sumRess_Enter);
            // 
            // minusLeft
            // 
            this.minusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeft.Location = new System.Drawing.Point(12, 125);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(60, 50);
            this.minusLeft.TabIndex = 14;
            this.minusLeft.Text = "?";
            this.minusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 13;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRight
            // 
            this.minusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRight.Location = new System.Drawing.Point(144, 125);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(60, 50);
            this.minusRight.TabIndex = 12;
            this.minusRight.Text = "?";
            this.minusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRes
            // 
            this.divRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRes.Location = new System.Drawing.Point(276, 199);
            this.divRes.Name = "divRes";
            this.divRes.Size = new System.Drawing.Size(120, 23);
            this.divRes.TabIndex = 20;
            this.divRes.ValueChanged += new System.EventHandler(this.Answer);
            this.divRes.Enter += new System.EventHandler(this.sumRess_Enter);
            // 
            // divLeft
            // 
            this.divLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeft.Location = new System.Drawing.Point(12, 184);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(60, 50);
            this.divLeft.TabIndex = 19;
            this.divLeft.Text = "?";
            this.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 18;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRight
            // 
            this.divRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRight.Location = new System.Drawing.Point(144, 184);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(60, 50);
            this.divRight.TabIndex = 17;
            this.divRight.Text = "?";
            this.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 16;
            this.label11.Text = "/";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulRes
            // 
            this.mulRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulRes.Location = new System.Drawing.Point(276, 266);
            this.mulRes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mulRes.Name = "mulRes";
            this.mulRes.Size = new System.Drawing.Size(120, 23);
            this.mulRes.TabIndex = 25;
            this.mulRes.ValueChanged += new System.EventHandler(this.Answer);
            this.mulRes.Enter += new System.EventHandler(this.sumRess_Enter);
            // 
            // mulLeft
            // 
            this.mulLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulLeft.Location = new System.Drawing.Point(12, 251);
            this.mulLeft.Name = "mulLeft";
            this.mulLeft.Size = new System.Drawing.Size(60, 50);
            this.mulLeft.TabIndex = 24;
            this.mulLeft.Text = "?";
            this.mulLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 23;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulRight
            // 
            this.mulRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulRight.Location = new System.Drawing.Point(144, 251);
            this.mulRight.Name = "mulRight";
            this.mulRight.Size = new System.Drawing.Size(60, 50);
            this.mulRight.TabIndex = 22;
            this.mulRight.Text = "?";
            this.mulRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 21;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(364, 317);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(94, 32);
            this.start.TabIndex = 26;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(481, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(480, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.mulRes);
            this.Controls.Add(this.mulLeft);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mulRight);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.divRes);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.minusRes);
            this.Controls.Add(this.minusLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sumRess);
            this.Controls.Add(this.addLeft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addright);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sumRess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label addright;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addLeft;
        private System.Windows.Forms.NumericUpDown sumRess;
        private System.Windows.Forms.NumericUpDown minusRes;
        private System.Windows.Forms.Label minusLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown divRes;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label divRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown mulRes;
        private System.Windows.Forms.Label mulLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label mulRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
    }
}

