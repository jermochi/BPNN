namespace BPNN
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(110, 76);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(368, 38);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(110, 145);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(368, 38);
            this.input2.TabIndex = 1;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(527, 179);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(368, 38);
            this.output.TabIndex = 2;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(110, 360);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(160, 70);
            this.create.TabIndex = 3;
            this.create.Text = "create BPNN";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(318, 360);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(160, 70);
            this.train.TabIndex = 4;
            this.train.Text = "Train the Neural Net";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(633, 252);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(160, 70);
            this.test.TabIndex = 5;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // input3
            // 
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input3.Location = new System.Drawing.Point(110, 215);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(368, 38);
            this.input3.TabIndex = 6;
            // 
            // input4
            // 
            this.input4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input4.Location = new System.Drawing.Point(110, 284);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(368, 38);
            this.input4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 479);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train);
            this.Controls.Add(this.create);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "BPNN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input4;
    }
}

