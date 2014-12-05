namespace BridgeControlSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bridgeStatus = new System.Windows.Forms.Label();
            this.trafficStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bridge_button = new System.Windows.Forms.Button();
            this.traffic_button = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bridgeStatus);
            this.panel1.Controls.Add(this.trafficStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bridge_button);
            this.panel1.Controls.Add(this.traffic_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 183);
            this.panel1.TabIndex = 0;
            // 
            // bridgeStatus
            // 
            this.bridgeStatus.AutoSize = true;
            this.bridgeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bridgeStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.bridgeStatus.Location = new System.Drawing.Point(336, 120);
            this.bridgeStatus.Name = "bridgeStatus";
            this.bridgeStatus.Size = new System.Drawing.Size(101, 25);
            this.bridgeStatus.TabIndex = 6;
            this.bridgeStatus.Text = "Lowered";
            // 
            // trafficStatus
            // 
            this.trafficStatus.AutoSize = true;
            this.trafficStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trafficStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.trafficStatus.Location = new System.Drawing.Point(251, 120);
            this.trafficStatus.Name = "trafficStatus";
            this.trafficStatus.Size = new System.Drawing.Size(68, 25);
            this.trafficStatus.TabIndex = 5;
            this.trafficStatus.Text = "Open";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Status:";
            // 
            // bridge_button
            // 
            this.bridge_button.Enabled = false;
            this.bridge_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bridge_button.Location = new System.Drawing.Point(327, 30);
            this.bridge_button.Name = "bridge_button";
            this.bridge_button.Size = new System.Drawing.Size(144, 60);
            this.bridge_button.TabIndex = 1;
            this.bridge_button.Text = "Raise";
            this.bridge_button.UseVisualStyleBackColor = true;
            this.bridge_button.Click += new System.EventHandler(this.bridgebutton_Click);
            // 
            // traffic_button
            // 
            this.traffic_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traffic_button.Location = new System.Drawing.Point(100, 30);
            this.traffic_button.Name = "traffic_button";
            this.traffic_button.Size = new System.Drawing.Size(142, 60);
            this.traffic_button.TabIndex = 0;
            this.traffic_button.Text = "Close";
            this.traffic_button.UseVisualStyleBackColor = true;
            this.traffic_button.Click += new System.EventHandler(this.trafficbutton_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canvas.Location = new System.Drawing.Point(0, 183);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 395);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 578);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bridge User Interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button bridge_button;
        private System.Windows.Forms.Button traffic_button;
        private System.Windows.Forms.Label trafficStatus;
        private System.Windows.Forms.Label label1;

        private void renderForm()
        {
            if (isClosed)
            {
                this.traffic_button.Text = "Open";
                this.trafficStatus.Text = "Closed";
            }
            else
            {
                this.traffic_button.Text = "Close";
                this.trafficStatus.Text = "Open";
            }

            if (isRaised)
            {
                this.bridge_button.Text = "Lower";
                this.bridgeStatus.Text = "Raised";
            }
            else
            {
                this.bridge_button.Text = "Raise";
                this.bridgeStatus.Text = "Lowered";
            }

            if (isRaised || isMoving || isTrafficChanging)
                this.traffic_button.Enabled = false;
            else
                this.traffic_button.Enabled = true;

            if (!isClosed || isMoving)
                this.bridge_button.Enabled = false;
            else
                this.bridge_button.Enabled = true;
        }

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label bridgeStatus;
    }
}

