﻿namespace HotelApp_v1
{
    partial class ViewLocations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.locations1 = new HotelApp_v1.Locations();
            this.textBox_zip_code = new System.Windows.Forms.TextBox();
            this.button_manage_locations = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.locations1);
            this.panel2.Controls.Add(this.textBox_zip_code);
            this.panel2.Controls.Add(this.button_manage_locations);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 25;
            // 
            // locations1
            // 
            this.locations1.Location = new System.Drawing.Point(0, 0);
            this.locations1.Name = "locations1";
            this.locations1.Size = new System.Drawing.Size(692, 545);
            this.locations1.TabIndex = 28;
            this.locations1.Visible = false;
            // 
            // textBox_zip_code
            // 
            this.textBox_zip_code.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_zip_code.Location = new System.Drawing.Point(322, 124);
            this.textBox_zip_code.Name = "textBox_zip_code";
            this.textBox_zip_code.Size = new System.Drawing.Size(227, 27);
            this.textBox_zip_code.TabIndex = 27;
            // 
            // button_manage_locations
            // 
            this.button_manage_locations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_manage_locations.FlatAppearance.BorderSize = 0;
            this.button_manage_locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_locations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_locations.ForeColor = System.Drawing.Color.White;
            this.button_manage_locations.Location = new System.Drawing.Point(346, 501);
            this.button_manage_locations.Name = "button_manage_locations";
            this.button_manage_locations.Size = new System.Drawing.Size(346, 44);
            this.button_manage_locations.TabIndex = 26;
            this.button_manage_locations.Text = "Manage Locations";
            this.button_manage_locations.UseVisualStyleBackColor = false;
            this.button_manage_locations.Click += new System.EventHandler(this.button_manage_locations_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 501);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(346, 44);
            this.button_home.TabIndex = 24;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 325);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zip Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(494, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose desired location to view rooms and room types";
            // 
            // ViewLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ViewLocations";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_manage_locations;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_zip_code;
        private Locations locations1;
    }
}
