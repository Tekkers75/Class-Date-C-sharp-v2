/// @author Саранчин К.А.
namespace AppDate
{
    partial class FormDate
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAllDay = new System.Windows.Forms.Label();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDay2 = new System.Windows.Forms.TextBox();
            this.textBoxMonth2 = new System.Windows.Forms.TextBox();
            this.textBoxYear2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.textBoxResultAll = new System.Windows.Forms.TextBox();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Дату в дни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConvertDate_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(7, 28);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "День";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 44);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(73, 20);
            this.textBoxDay.TabIndex = 2;
            this.textBoxDay.Text = "0";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(89, 44);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(73, 20);
            this.textBoxMonth.TabIndex = 4;
            this.textBoxMonth.Text = "0";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(86, 28);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "Месяц";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(168, 44);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(73, 20);
            this.textBoxYear.TabIndex = 6;
            this.textBoxYear.Text = "0";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(165, 28);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(25, 13);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Год";
            // 
            // labelAllDay
            // 
            this.labelAllDay.AutoSize = true;
            this.labelAllDay.Location = new System.Drawing.Point(247, 28);
            this.labelAllDay.Name = "labelAllDay";
            this.labelAllDay.Size = new System.Drawing.Size(105, 13);
            this.labelAllDay.TabIndex = 7;
            this.labelAllDay.Text = "Общее кол-во дней";
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.Location = new System.Drawing.Point(247, 44);
            this.textBoxResult1.Multiline = true;
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.Size = new System.Drawing.Size(105, 20);
            this.textBoxResult1.TabIndex = 12;
            this.textBoxResult1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Дни в дату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSetDateInDay_Click);
            // 
            // textBoxDay2
            // 
            this.textBoxDay2.Location = new System.Drawing.Point(12, 73);
            this.textBoxDay2.Name = "textBoxDay2";
            this.textBoxDay2.Size = new System.Drawing.Size(73, 20);
            this.textBoxDay2.TabIndex = 14;
            this.textBoxDay2.Text = "0";
            // 
            // textBoxMonth2
            // 
            this.textBoxMonth2.Location = new System.Drawing.Point(89, 73);
            this.textBoxMonth2.Name = "textBoxMonth2";
            this.textBoxMonth2.Size = new System.Drawing.Size(73, 20);
            this.textBoxMonth2.TabIndex = 15;
            this.textBoxMonth2.Text = "0";
            // 
            // textBoxYear2
            // 
            this.textBoxYear2.Location = new System.Drawing.Point(167, 73);
            this.textBoxYear2.Name = "textBoxYear2";
            this.textBoxYear2.Size = new System.Drawing.Size(74, 20);
            this.textBoxYear2.TabIndex = 16;
            this.textBoxYear2.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 20);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Сложить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(127, 99);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(114, 20);
            this.buttonSub.TabIndex = 18;
            this.buttonSub.Text = "Вычесть";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // textBoxResultAll
            // 
            this.textBoxResultAll.Location = new System.Drawing.Point(12, 125);
            this.textBoxResultAll.Multiline = true;
            this.textBoxResultAll.Name = "textBoxResultAll";
            this.textBoxResultAll.ReadOnly = true;
            this.textBoxResultAll.Size = new System.Drawing.Size(229, 21);
            this.textBoxResultAll.TabIndex = 20;
            this.textBoxResultAll.Text = "0";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(12, 152);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.Size = new System.Drawing.Size(340, 20);
            this.textBoxError.TabIndex = 21;
            this.textBoxError.Text = "Информация";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.инструкцияToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // FormDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 182);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.textBoxResultAll);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxYear2);
            this.Controls.Add(this.textBoxMonth2);
            this.Controls.Add(this.textBoxDay2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.labelAllDay);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDate";
            this.Text = "Калькулятор даты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAllDay;
        private System.Windows.Forms.TextBox textBoxResult1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDay2;
        private System.Windows.Forms.TextBox textBoxMonth2;
        private System.Windows.Forms.TextBox textBoxYear2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.TextBox textBoxResultAll;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
    }
}

