namespace ToDoEF
{
    partial class FormMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstClosed = new System.Windows.Forms.ListBox();
            this.lstResolved = new System.Windows.Forms.ListBox();
            this.lstBackLog = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(469, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstClosed
            // 
            this.lstClosed.AllowDrop = true;
            this.lstClosed.FormattingEnabled = true;
            this.lstClosed.Location = new System.Drawing.Point(596, 46);
            this.lstClosed.Name = "lstClosed";
            this.lstClosed.Size = new System.Drawing.Size(192, 329);
            this.lstClosed.TabIndex = 20;
            this.lstClosed.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstClosed.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstResolved
            // 
            this.lstResolved.AllowDrop = true;
            this.lstResolved.FormattingEnabled = true;
            this.lstResolved.Location = new System.Drawing.Point(303, 46);
            this.lstResolved.Name = "lstResolved";
            this.lstResolved.Size = new System.Drawing.Size(192, 329);
            this.lstResolved.TabIndex = 19;
            this.lstResolved.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstResolved.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstResolved.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstBackLog
            // 
            this.lstBackLog.AllowDrop = true;
            this.lstBackLog.FormattingEnabled = true;
            this.lstBackLog.Location = new System.Drawing.Point(11, 46);
            this.lstBackLog.Name = "lstBackLog";
            this.lstBackLog.Size = new System.Drawing.Size(192, 329);
            this.lstBackLog.TabIndex = 18;
            this.lstBackLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBackLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstBackLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(592, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 20);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Closed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Resolved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "BackLog";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstClosed);
            this.Controls.Add(this.lstResolved);
            this.Controls.Add(this.lstBackLog);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstClosed;
        private System.Windows.Forms.ListBox lstResolved;
        private System.Windows.Forms.ListBox lstBackLog;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

