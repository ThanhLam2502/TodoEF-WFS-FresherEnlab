﻿namespace ToDoEF
{
    partial class FormAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtDescripton = new System.Windows.Forms.TextBox();
            this.txtTile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(151, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dateFinish
            // 
            this.dateFinish.Location = new System.Drawing.Point(132, 187);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(342, 20);
            this.dateFinish.TabIndex = 23;
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(132, 154);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(342, 20);
            this.dateCreate.TabIndex = 22;
            // 
            // txtDescripton
            // 
            this.txtDescripton.Location = new System.Drawing.Point(132, 54);
            this.txtDescripton.Multiline = true;
            this.txtDescripton.Name = "txtDescripton";
            this.txtDescripton.Size = new System.Drawing.Size(342, 94);
            this.txtDescripton.TabIndex = 21;
            // 
            // txtTile
            // 
            this.txtTile.Location = new System.Drawing.Point(132, 28);
            this.txtTile.Name = "txtTile";
            this.txtTile.Size = new System.Drawing.Size(342, 20);
            this.txtTile.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Finish Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Create Date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title :";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dateFinish);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.txtDescripton);
            this.Controls.Add(this.txtTile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd";
            this.Text = "Add To-Do";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.TextBox txtDescripton;
        private System.Windows.Forms.TextBox txtTile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}