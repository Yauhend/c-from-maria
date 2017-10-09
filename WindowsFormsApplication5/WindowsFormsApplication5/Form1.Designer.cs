namespace WindowsFormsApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTown = new System.Windows.Forms.TextBox();
            this.TBStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NMHouse = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NMFlat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MTBPhone = new System.Windows.Forms.MaskedTextBox();
            this.Btransform = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.Bforward = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PBNumber = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NMHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMFlat)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(148, 23);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(254, 20);
            this.TBSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(148, 59);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(254, 20);
            this.TBName.TabIndex = 4;
            // 
            // TBSname
            // 
            this.TBSname.Location = new System.Drawing.Point(148, 89);
            this.TBSname.Name = "TBSname";
            this.TBSname.Size = new System.Drawing.Size(254, 20);
            this.TBSname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Город";
            // 
            // TBTown
            // 
            this.TBTown.Location = new System.Drawing.Point(148, 126);
            this.TBTown.Name = "TBTown";
            this.TBTown.Size = new System.Drawing.Size(254, 20);
            this.TBTown.TabIndex = 7;
            // 
            // TBStreet
            // 
            this.TBStreet.Location = new System.Drawing.Point(148, 166);
            this.TBStreet.Name = "TBStreet";
            this.TBStreet.Size = new System.Drawing.Size(254, 20);
            this.TBStreet.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Улица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дом";
            // 
            // NMHouse
            // 
            this.NMHouse.Location = new System.Drawing.Point(148, 200);
            this.NMHouse.Name = "NMHouse";
            this.NMHouse.Size = new System.Drawing.Size(254, 20);
            this.NMHouse.TabIndex = 11;
            this.NMHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Квартира";
            // 
            // NMFlat
            // 
            this.NMFlat.Location = new System.Drawing.Point(148, 237);
            this.NMFlat.Name = "NMFlat";
            this.NMFlat.Size = new System.Drawing.Size(254, 20);
            this.NMFlat.TabIndex = 13;
            this.NMFlat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Телефон";
            // 
            // MTBPhone
            // 
            this.MTBPhone.Location = new System.Drawing.Point(148, 275);
            this.MTBPhone.Mask = "(999) 000-0000";
            this.MTBPhone.Name = "MTBPhone";
            this.MTBPhone.Size = new System.Drawing.Size(250, 20);
            this.MTBPhone.TabIndex = 15;
            this.MTBPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btransform
            // 
            this.Btransform.Location = new System.Drawing.Point(148, 320);
            this.Btransform.Name = "Btransform";
            this.Btransform.Size = new System.Drawing.Size(127, 30);
            this.Btransform.TabIndex = 16;
            this.Btransform.Text = "Изменить";
            this.Btransform.UseVisualStyleBackColor = true;
            this.Btransform.Click += new System.EventHandler(this.Btransform_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(148, 356);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(127, 30);
            this.BAdd.TabIndex = 17;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(15, 320);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(114, 30);
            this.BBack.TabIndex = 18;
            this.BBack.Text = "<- Назад ";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // Bforward
            // 
            this.Bforward.Location = new System.Drawing.Point(287, 320);
            this.Bforward.Name = "Bforward";
            this.Bforward.Size = new System.Drawing.Size(115, 30);
            this.Bforward.TabIndex = 19;
            this.Bforward.Text = "Вперед ->";
            this.Bforward.UseVisualStyleBackColor = true;
            this.Bforward.Click += new System.EventHandler(this.Bforward_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(15, 356);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(114, 30);
            this.BDelete.TabIndex = 20;
            this.BDelete.Text = "Удалить";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tsRCount,
            this.toolStripStatusLabel1,
            this.PBNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel2.Text = "Количество";
            // 
            // tsRCount
            // 
            this.tsRCount.AutoSize = false;
            this.tsRCount.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tsRCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRCount.Name = "tsRCount";
            this.tsRCount.Size = new System.Drawing.Size(40, 17);
            this.tsRCount.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Номер";
            // 
            // PBNumber
            // 
            this.PBNumber.AutoSize = false;
            this.PBNumber.Name = "PBNumber";
            this.PBNumber.Size = new System.Drawing.Size(118, 17);
            this.PBNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 456);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.Bforward);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.Btransform);
            this.Controls.Add(this.MTBPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NMFlat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NMHouse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBStreet);
            this.Controls.Add(this.TBTown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBSname);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            ((System.ComponentModel.ISupportInitialize)(this.NMHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMFlat)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTown;
        private System.Windows.Forms.TextBox TBStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NMHouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NMFlat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MTBPhone;
        private System.Windows.Forms.Button Btransform;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button Bforward;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsRCount;
        private System.Windows.Forms.ToolStripStatusLabel PBNumber;
    }
}

