
namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.freePalnt = new System.Windows.Forms.Button();
            this.Kill = new System.Windows.Forms.Button();
            this.plantnocd = new System.Windows.Forms.Button();
            this.shorttime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.getmoney = new System.Windows.Forms.Button();
            this.recover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "无限阳光";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SUN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "自动拾取阳光";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Autosunn_Click);
            // 
            // freePalnt
            // 
            this.freePalnt.Location = new System.Drawing.Point(27, 149);
            this.freePalnt.Name = "freePalnt";
            this.freePalnt.Size = new System.Drawing.Size(116, 32);
            this.freePalnt.TabIndex = 6;
            this.freePalnt.Text = "免费种植物";
            this.freePalnt.UseVisualStyleBackColor = true;
            this.freePalnt.Click += new System.EventHandler(this.freePalnt_Click);
            // 
            // Kill
            // 
            this.Kill.Location = new System.Drawing.Point(169, 199);
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(116, 35);
            this.Kill.TabIndex = 8;
            this.Kill.Text = "秒杀僵尸";
            this.Kill.UseVisualStyleBackColor = true;
            this.Kill.Click += new System.EventHandler(this.Kill_Click);
            // 
            // plantnocd
            // 
            this.plantnocd.Location = new System.Drawing.Point(169, 149);
            this.plantnocd.Name = "plantnocd";
            this.plantnocd.Size = new System.Drawing.Size(116, 32);
            this.plantnocd.TabIndex = 9;
            this.plantnocd.Text = "植物无冷却";
            this.plantnocd.UseVisualStyleBackColor = true;
            this.plantnocd.Click += new System.EventHandler(this.plantnocd_Click);
            // 
            // shorttime
            // 
            this.shorttime.Location = new System.Drawing.Point(27, 202);
            this.shorttime.Name = "shorttime";
            this.shorttime.Size = new System.Drawing.Size(116, 32);
            this.shorttime.TabIndex = 10;
            this.shorttime.Text = "缩短冷却时间";
            this.shorttime.UseVisualStyleBackColor = true;
            this.shorttime.Click += new System.EventHandler(this.shorttime_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(302, 37);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(114, 38);
            this.select.TabIndex = 12;
            this.select.Text = "选择关卡";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // getmoney
            // 
            this.getmoney.Location = new System.Drawing.Point(27, 254);
            this.getmoney.Name = "getmoney";
            this.getmoney.Size = new System.Drawing.Size(116, 36);
            this.getmoney.TabIndex = 13;
            this.getmoney.Text = "无限金币";
            this.getmoney.UseVisualStyleBackColor = true;
            this.getmoney.Click += new System.EventHandler(this.getmoney_Click);
            // 
            // recover
            // 
            this.recover.Location = new System.Drawing.Point(169, 254);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(116, 36);
            this.recover.TabIndex = 14;
            this.recover.Text = "恢复所有修改";
            this.recover.UseVisualStyleBackColor = true;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 313);
            this.Controls.Add(this.recover);
            this.Controls.Add(this.getmoney);
            this.Controls.Add(this.select);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shorttime);
            this.Controls.Add(this.plantnocd);
            this.Controls.Add(this.Kill);
            this.Controls.Add(this.freePalnt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.SUN_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button freePalnt;
        private System.Windows.Forms.Button Kill;
        private System.Windows.Forms.Button plantnocd;
        private System.Windows.Forms.Button shorttime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button getmoney;
        private System.Windows.Forms.Button recover;
    }
}

