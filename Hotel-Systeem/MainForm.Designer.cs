namespace Hotel_Systeem
{
    partial class MainForm
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
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnViewRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(101, 218);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(118, 62);
            this.btnReservations.TabIndex = 0;
            this.btnReservations.Text = "View reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnViewRooms
            // 
            this.btnViewRooms.Location = new System.Drawing.Point(451, 218);
            this.btnViewRooms.Name = "btnViewRooms";
            this.btnViewRooms.Size = new System.Drawing.Size(118, 62);
            this.btnViewRooms.TabIndex = 1;
            this.btnViewRooms.Text = "View rooms";
            this.btnViewRooms.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 521);
            this.Controls.Add(this.btnViewRooms);
            this.Controls.Add(this.btnReservations);
            this.Name = "MainForm";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnViewRooms;
    }
}

