
namespace WTF_is_My_Password
{
    partial class FindPass
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgListOfPass = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfPass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 26);
            this.textBox1.TabIndex = 1;
            // 
            // dgListOfPass
            // 
            this.dgListOfPass.AllowUserToAddRows = false;
            this.dgListOfPass.AllowUserToDeleteRows = false;
            this.dgListOfPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListOfPass.Location = new System.Drawing.Point(12, 75);
            this.dgListOfPass.Name = "dgListOfPass";
            this.dgListOfPass.ReadOnly = true;
            this.dgListOfPass.RowHeadersWidth = 62;
            this.dgListOfPass.RowTemplate.Height = 28;
            this.dgListOfPass.Size = new System.Drawing.Size(1026, 198);
            this.dgListOfPass.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FindPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgListOfPass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FindPass";
            this.Text = "FindPass";
            this.Load += new System.EventHandler(this.FindPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgListOfPass;
        private System.Windows.Forms.Button button1;
    }
}