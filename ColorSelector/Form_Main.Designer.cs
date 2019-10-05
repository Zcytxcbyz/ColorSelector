namespace ColorSelector
{
    partial class Form_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_color = new System.Windows.Forms.Button();
            this.panel_color = new System.Windows.Forms.Panel();
            this.textBox_red = new System.Windows.Forms.TextBox();
            this.textBox_green = new System.Windows.Forms.TextBox();
            this.textBox_blue = new System.Windows.Forms.TextBox();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.textBox_rgb = new System.Windows.Forms.TextBox();
            this.label_rgb = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(12, 88);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(70, 41);
            this.button_color.TabIndex = 0;
            this.button_color.Text = "Select Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // panel_color
            // 
            this.panel_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_color.Location = new System.Drawing.Point(12, 12);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(70, 70);
            this.panel_color.TabIndex = 2;
            // 
            // textBox_red
            // 
            this.textBox_red.Location = new System.Drawing.Point(131, 24);
            this.textBox_red.Name = "textBox_red";
            this.textBox_red.Size = new System.Drawing.Size(48, 21);
            this.textBox_red.TabIndex = 3;
            this.textBox_red.TextChanged += new System.EventHandler(this.textBox_red_TextChanged);
            // 
            // textBox_green
            // 
            this.textBox_green.Location = new System.Drawing.Point(131, 51);
            this.textBox_green.Name = "textBox_green";
            this.textBox_green.Size = new System.Drawing.Size(48, 21);
            this.textBox_green.TabIndex = 4;
            this.textBox_green.TextChanged += new System.EventHandler(this.textBox_green_TextChanged);
            // 
            // textBox_blue
            // 
            this.textBox_blue.Location = new System.Drawing.Point(131, 78);
            this.textBox_blue.Name = "textBox_blue";
            this.textBox_blue.Size = new System.Drawing.Size(48, 21);
            this.textBox_blue.TabIndex = 5;
            this.textBox_blue.TextChanged += new System.EventHandler(this.textBox_blue_TextChanged);
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(102, 27);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(23, 12);
            this.label_red.TabIndex = 7;
            this.label_red.Text = "Red";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(90, 54);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(35, 12);
            this.label_green.TabIndex = 8;
            this.label_green.Text = "Green";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(96, 81);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(29, 12);
            this.label_blue.TabIndex = 9;
            this.label_blue.Text = "Blue";
            // 
            // textBox_rgb
            // 
            this.textBox_rgb.Location = new System.Drawing.Point(41, 138);
            this.textBox_rgb.Name = "textBox_rgb";
            this.textBox_rgb.Size = new System.Drawing.Size(138, 21);
            this.textBox_rgb.TabIndex = 11;
            this.textBox_rgb.TextChanged += new System.EventHandler(this.textBox_rgb_TextChanged);
            // 
            // label_rgb
            // 
            this.label_rgb.AutoSize = true;
            this.label_rgb.Location = new System.Drawing.Point(12, 141);
            this.label_rgb.Name = "label_rgb";
            this.label_rgb.Size = new System.Drawing.Size(23, 12);
            this.label_rgb.TabIndex = 12;
            this.label_rgb.Text = "RGB";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.ForeColor = System.Drawing.Color.Red;
            this.label_info.Location = new System.Drawing.Point(90, 102);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(77, 12);
            this.label_info.TabIndex = 13;
            this.label_info.Text = "[label_info]";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 171);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_rgb);
            this.Controls.Add(this.textBox_rgb);
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.textBox_blue);
            this.Controls.Add(this.textBox_green);
            this.Controls.Add(this.textBox_red);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.button_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.Text = "Color Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.TextBox textBox_red;
        private System.Windows.Forms.TextBox textBox_green;
        private System.Windows.Forms.TextBox textBox_blue;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.TextBox textBox_rgb;
        private System.Windows.Forms.Label label_rgb;
        private System.Windows.Forms.Label label_info;
    }
}

