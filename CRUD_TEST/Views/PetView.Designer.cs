namespace CRUD_TEST.Views
{
    partial class PetView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X_btn = new System.Windows.Forms.Button();
            this.Tap_table = new System.Windows.Forms.TabControl();
            this.tap_curd1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tap_curd2 = new System.Windows.Forms.TabPage();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.pet_color_tb = new System.Windows.Forms.TextBox();
            this.pet_tpe_tb = new System.Windows.Forms.TextBox();
            this.pet_name_tb = new System.Windows.Forms.TextBox();
            this.pet_id_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Tap_table.SuspendLayout();
            this.tap_curd1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tap_curd2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.X_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 42);
            this.panel1.TabIndex = 1;
            // 
            // X_btn
            // 
            this.X_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.X_btn.Location = new System.Drawing.Point(753, 9);
            this.X_btn.Name = "X_btn";
            this.X_btn.Size = new System.Drawing.Size(27, 23);
            this.X_btn.TabIndex = 8;
            this.X_btn.Text = "X";
            this.X_btn.UseVisualStyleBackColor = true;
            // 
            // Tap_table
            // 
            this.Tap_table.Controls.Add(this.tap_curd1);
            this.Tap_table.Controls.Add(this.tap_curd2);
            this.Tap_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tap_table.Location = new System.Drawing.Point(0, 42);
            this.Tap_table.Name = "Tap_table";
            this.Tap_table.SelectedIndex = 0;
            this.Tap_table.Size = new System.Drawing.Size(792, 417);
            this.Tap_table.TabIndex = 2;
            // 
            // tap_curd1
            // 
            this.tap_curd1.Controls.Add(this.dataGridView1);
            this.tap_curd1.Controls.Add(this.delete_btn);
            this.tap_curd1.Controls.Add(this.edit_btn);
            this.tap_curd1.Controls.Add(this.Add_btn);
            this.tap_curd1.Controls.Add(this.search_btn);
            this.tap_curd1.Controls.Add(this.search_txt);
            this.tap_curd1.Controls.Add(this.label2);
            this.tap_curd1.Location = new System.Drawing.Point(4, 22);
            this.tap_curd1.Name = "tap_curd1";
            this.tap_curd1.Padding = new System.Windows.Forms.Padding(3);
            this.tap_curd1.Size = new System.Drawing.Size(784, 391);
            this.tap_curd1.TabIndex = 0;
            this.tap_curd1.Text = "CURD";
            this.tap_curd1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 336);
            this.dataGridView1.TabIndex = 7;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Location = new System.Drawing.Point(688, 113);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Location = new System.Drawing.Point(688, 84);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.Location = new System.Drawing.Point(688, 55);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Location = new System.Drawing.Point(446, 3);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Location = new System.Drawing.Point(67, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(373, 20);
            this.search_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // tap_curd2
            // 
            this.tap_curd2.Controls.Add(this.cancel_btn);
            this.tap_curd2.Controls.Add(this.save_btn);
            this.tap_curd2.Controls.Add(this.pet_color_tb);
            this.tap_curd2.Controls.Add(this.pet_tpe_tb);
            this.tap_curd2.Controls.Add(this.pet_name_tb);
            this.tap_curd2.Controls.Add(this.pet_id_tb);
            this.tap_curd2.Controls.Add(this.label6);
            this.tap_curd2.Controls.Add(this.label5);
            this.tap_curd2.Controls.Add(this.label4);
            this.tap_curd2.Controls.Add(this.label3);
            this.tap_curd2.Location = new System.Drawing.Point(4, 22);
            this.tap_curd2.Name = "tap_curd2";
            this.tap_curd2.Padding = new System.Windows.Forms.Padding(3);
            this.tap_curd2.Size = new System.Drawing.Size(784, 391);
            this.tap_curd2.TabIndex = 1;
            this.tap_curd2.Text = "Details";
            this.tap_curd2.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(231, 237);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 32);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(103, 237);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(100, 32);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // pet_color_tb
            // 
            this.pet_color_tb.Location = new System.Drawing.Point(103, 189);
            this.pet_color_tb.Name = "pet_color_tb";
            this.pet_color_tb.Size = new System.Drawing.Size(228, 20);
            this.pet_color_tb.TabIndex = 7;
            // 
            // pet_tpe_tb
            // 
            this.pet_tpe_tb.Location = new System.Drawing.Point(231, 133);
            this.pet_tpe_tb.Name = "pet_tpe_tb";
            this.pet_tpe_tb.Size = new System.Drawing.Size(100, 20);
            this.pet_tpe_tb.TabIndex = 6;
            // 
            // pet_name_tb
            // 
            this.pet_name_tb.Location = new System.Drawing.Point(103, 133);
            this.pet_name_tb.Name = "pet_name_tb";
            this.pet_name_tb.Size = new System.Drawing.Size(100, 20);
            this.pet_name_tb.TabIndex = 5;
            // 
            // pet_id_tb
            // 
            this.pet_id_tb.Location = new System.Drawing.Point(103, 81);
            this.pet_id_tb.Name = "pet_id_tb";
            this.pet_id_tb.Size = new System.Drawing.Size(100, 20);
            this.pet_id_tb.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "PetColor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PetType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "PetName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PetID";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 459);
            this.Controls.Add(this.Tap_table);
            this.Controls.Add(this.panel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tap_table.ResumeLayout(false);
            this.tap_curd1.ResumeLayout(false);
            this.tap_curd1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tap_curd2.ResumeLayout(false);
            this.tap_curd2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Tap_table;
        private System.Windows.Forms.TabPage tap_curd1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tap_curd2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox pet_color_tb;
        private System.Windows.Forms.TextBox pet_tpe_tb;
        private System.Windows.Forms.TextBox pet_name_tb;
        private System.Windows.Forms.TextBox pet_id_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button X_btn;
    }
}