namespace AsyncSample1
{
    partial class Form1
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
            this.ButtonAsyncInvoke = new System.Windows.Forms.Button();
            this.ButtonNonAsyncInvoke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxHash = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAsyncInvoke
            // 
            this.ButtonAsyncInvoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAsyncInvoke.Location = new System.Drawing.Point(25, 133);
            this.ButtonAsyncInvoke.Name = "ButtonAsyncInvoke";
            this.ButtonAsyncInvoke.Size = new System.Drawing.Size(117, 44);
            this.ButtonAsyncInvoke.TabIndex = 0;
            this.ButtonAsyncInvoke.Text = "Async Invoke";
            this.ButtonAsyncInvoke.UseVisualStyleBackColor = true;
            this.ButtonAsyncInvoke.Click += new System.EventHandler(this.ButtonAsyncInvoke_Click);
            // 
            // ButtonNonAsyncInvoke
            // 
            this.ButtonNonAsyncInvoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNonAsyncInvoke.Location = new System.Drawing.Point(258, 133);
            this.ButtonNonAsyncInvoke.Name = "ButtonNonAsyncInvoke";
            this.ButtonNonAsyncInvoke.Size = new System.Drawing.Size(117, 44);
            this.ButtonNonAsyncInvoke.TabIndex = 1;
            this.ButtonNonAsyncInvoke.Text = "No Async Invoke";
            this.ButtonNonAsyncInvoke.UseVisualStyleBackColor = true;
            this.ButtonNonAsyncInvoke.Click += new System.EventHandler(this.ButtonNonAsyncInvoke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter text to hash:";
            // 
            // TextBoxHash
            // 
            this.TextBoxHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHash.Location = new System.Drawing.Point(25, 44);
            this.TextBoxHash.Name = "TextBoxHash";
            this.TextBoxHash.Size = new System.Drawing.Size(350, 21);
            this.TextBoxHash.TabIndex = 3;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResult.Location = new System.Drawing.Point(25, 98);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(350, 21);
            this.TextBoxResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.TextBoxHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonNonAsyncInvoke);
            this.Controls.Add(this.ButtonAsyncInvoke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAsyncInvoke;
        private System.Windows.Forms.Button ButtonNonAsyncInvoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxHash;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label2;
    }
}

