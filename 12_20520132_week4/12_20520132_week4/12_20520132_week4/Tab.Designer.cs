namespace _12_20520132_week4
{
    partial class Menu
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
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_Client1 = new System.Windows.Forms.Button();
            this.btn_Client2 = new System.Windows.Forms.Button();
            this.btn_Client3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(12, 46);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(121, 57);
            this.btn_server.TabIndex = 0;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = true;
            // 
            // btn_Client1
            // 
            this.btn_Client1.Location = new System.Drawing.Point(139, 46);
            this.btn_Client1.Name = "btn_Client1";
            this.btn_Client1.Size = new System.Drawing.Size(121, 57);
            this.btn_Client1.TabIndex = 0;
            this.btn_Client1.Text = "Client1";
            this.btn_Client1.UseVisualStyleBackColor = true;
            // 
            // btn_Client2
            // 
            this.btn_Client2.Location = new System.Drawing.Point(12, 109);
            this.btn_Client2.Name = "btn_Client2";
            this.btn_Client2.Size = new System.Drawing.Size(121, 57);
            this.btn_Client2.TabIndex = 2;
            this.btn_Client2.Text = "Client2";
            // 
            // btn_Client3
            // 
            this.btn_Client3.Location = new System.Drawing.Point(139, 109);
            this.btn_Client3.Name = "btn_Client3";
            this.btn_Client3.Size = new System.Drawing.Size(121, 57);
            this.btn_Client3.TabIndex = 0;
            this.btn_Client3.Text = "Client3";
            this.btn_Client3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server và Client";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Client3);
            this.Controls.Add(this.btn_Client2);
            this.Controls.Add(this.btn_Client1);
            this.Controls.Add(this.btn_server);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_Client1;
        private System.Windows.Forms.Button btn_Client2;
        private System.Windows.Forms.Button btn_Client3;
        private System.Windows.Forms.Label label1;
    }
}

