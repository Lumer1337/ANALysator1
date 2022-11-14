namespace _3sem_analisator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInput = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.RichTextBox();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.примерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пример3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_tool_strip_but = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.errorLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.пример4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.textInput.Location = new System.Drawing.Point(285, 97);
            this.textInput.Margin = new System.Windows.Forms.Padding(2);
            this.textInput.MaximumSize = new System.Drawing.Size(3751, 150);
            this.textInput.MinimumSize = new System.Drawing.Size(338, 4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(590, 37);
            this.textInput.TabIndex = 4;
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(432, 249);
            this.error.Margin = new System.Windows.Forms.Padding(2);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(538, 187);
            this.error.TabIndex = 5;
            this.error.Text = "";
            // 
            // errorBox
            // 
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorBox.Location = new System.Drawing.Point(18, 249);
            this.errorBox.Margin = new System.Windows.Forms.Padding(2);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(385, 187);
            this.errorBox.TabIndex = 7;
            this.errorBox.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.MaximumSize = new System.Drawing.Size(500, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Входная строка:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.примерToolStripMenuItem,
            this.примерToolStripMenuItem1,
            this.пример3ToolStripMenuItem,
            this.пример4ToolStripMenuItem,
            this.пример5ToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(125, 33);
            this.toolStripDropDownButton1.Text = "Пример";
            // 
            // примерToolStripMenuItem
            // 
            this.примерToolStripMenuItem.Name = "примерToolStripMenuItem";
            this.примерToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.примерToolStripMenuItem.Text = "Пример1";
            this.примерToolStripMenuItem.Click += new System.EventHandler(this.примерToolStripMenuItem_Click);
            // 
            // примерToolStripMenuItem1
            // 
            this.примерToolStripMenuItem1.Name = "примерToolStripMenuItem1";
            this.примерToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.примерToolStripMenuItem1.Text = "Пример2";
            this.примерToolStripMenuItem1.Click += new System.EventHandler(this.примерToolStripMenuItem1_Click);
            // 
            // пример3ToolStripMenuItem
            // 
            this.пример3ToolStripMenuItem.Name = "пример3ToolStripMenuItem";
            this.пример3ToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.пример3ToolStripMenuItem.Text = "Пример3";
            this.пример3ToolStripMenuItem.Click += new System.EventHandler(this.пример3ToolStripMenuItem_Click);
            // 
            // insert_tool_strip_but
            // 
            this.insert_tool_strip_but.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.insert_tool_strip_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.insert_tool_strip_but.Image = ((System.Drawing.Image)(resources.GetObject("insert_tool_strip_but.Image")));
            this.insert_tool_strip_but.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insert_tool_strip_but.Name = "insert_tool_strip_but";
            this.insert_tool_strip_but.Size = new System.Drawing.Size(210, 33);
            this.insert_tool_strip_but.Text = "Анализировать";
            this.insert_tool_strip_but.Click += new System.EventHandler(this.insert_tool_strip_but_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.insert_tool_strip_but});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 36);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // errorLab
            // 
            this.errorLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLab.Location = new System.Drawing.Point(12, 206);
            this.errorLab.MaximumSize = new System.Drawing.Size(500, 90);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(472, 41);
            this.errorLab.TabIndex = 11;
            this.errorLab.Text = "Ошибки:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 206);
            this.label2.MaximumSize = new System.Drawing.Size(700, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 90);
            this.label2.TabIndex = 12;
            this.label2.Text = "Список констант и идентификаторов:";
            // 
            // пример4ToolStripMenuItem
            // 
            this.пример4ToolStripMenuItem.Name = "пример4ToolStripMenuItem";
            this.пример4ToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.пример4ToolStripMenuItem.Text = "Пример4";
            this.пример4ToolStripMenuItem.Click += new System.EventHandler(this.пример4ToolStripMenuItem_Click);
            // 
            // пример5ToolStripMenuItem
            // 
            this.пример5ToolStripMenuItem.Name = "пример5ToolStripMenuItem";
            this.пример5ToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.пример5ToolStripMenuItem.Text = "Пример5";
            this.пример5ToolStripMenuItem.Click += new System.EventHandler(this.пример5ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 472);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLab);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.errorBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.RichTextBox error;
        private System.Windows.Forms.RichTextBox errorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem примерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem примерToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пример3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton insert_tool_strip_but;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label errorLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem пример4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример5ToolStripMenuItem;
    }
}

