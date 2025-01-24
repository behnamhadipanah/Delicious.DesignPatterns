namespace Ex.Command.RedoUndo
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
            textBox1 = new TextBox();
            setText_btn = new Button();
            undo_btn = new Button();
            redo_btn = new Button();
            result_lbl = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 0;
            // 
            // setText_btn
            // 
            setText_btn.Location = new Point(15, 36);
            setText_btn.Name = "setText_btn";
            setText_btn.Size = new Size(106, 35);
            setText_btn.TabIndex = 1;
            setText_btn.Text = "Set text";
            setText_btn.UseVisualStyleBackColor = true;
            setText_btn.Click += setText_btn_Click;
            // 
            // undo_btn
            // 
            undo_btn.Location = new Point(221, 42);
            undo_btn.Name = "undo_btn";
            undo_btn.Size = new Size(75, 23);
            undo_btn.TabIndex = 2;
            undo_btn.Text = "Undo";
            undo_btn.UseVisualStyleBackColor = true;
            undo_btn.Click += undo_btn_Click;
            // 
            // redo_btn
            // 
            redo_btn.Location = new Point(302, 42);
            redo_btn.Name = "redo_btn";
            redo_btn.Size = new Size(75, 23);
            redo_btn.TabIndex = 3;
            redo_btn.Text = "Redo";
            redo_btn.UseVisualStyleBackColor = true;
            redo_btn.Click += redo_btn_Click;
            // 
            // result_lbl
            // 
            result_lbl.AutoSize = true;
            result_lbl.Location = new Point(40, 89);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(0, 15);
            result_lbl.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_lbl);
            Controls.Add(redo_btn);
            Controls.Add(undo_btn);
            Controls.Add(setText_btn);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button setText_btn;
        private Button undo_btn;
        private Button redo_btn;
        private Label result_lbl;
    }
}
