
namespace EventApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.TestThread = new System.Windows.Forms.Button();
            this.Distance = new System.Windows.Forms.NumericUpDown();
            this.Trajectory = new System.Windows.Forms.NumericUpDown();
            this.bclTread = new System.Windows.Forms.Button();
            this.freez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trajectory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(223, 243);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(166, 23);
            this.Play.TabIndex = 4;
            this.Play.Text = "Play Ball !!";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // TestThread
            // 
            this.TestThread.Location = new System.Drawing.Point(564, 302);
            this.TestThread.Name = "TestThread";
            this.TestThread.Size = new System.Drawing.Size(110, 23);
            this.TestThread.TabIndex = 5;
            this.TestThread.Text = "Test Threading";
            this.TestThread.UseVisualStyleBackColor = true;
            this.TestThread.Click += new System.EventHandler(this.TestThread_Click);
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(297, 203);
            this.Distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(120, 20);
            this.Distance.TabIndex = 6;
            // 
            // Trajectory
            // 
            this.Trajectory.Location = new System.Drawing.Point(297, 156);
            this.Trajectory.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Trajectory.Name = "Trajectory";
            this.Trajectory.Size = new System.Drawing.Size(120, 20);
            this.Trajectory.TabIndex = 7;
            // 
            // bclTread
            // 
            this.bclTread.Location = new System.Drawing.Point(146, 302);
            this.bclTread.Name = "bclTread";
            this.bclTread.Size = new System.Drawing.Size(119, 23);
            this.bclTread.TabIndex = 8;
            this.bclTread.Text = "boucle Thread";
            this.bclTread.UseVisualStyleBackColor = true;
            this.bclTread.Click += new System.EventHandler(this.bclTread_Click);
            // 
            // freez
            // 
            this.freez.Location = new System.Drawing.Point(376, 339);
            this.freez.Name = "freez";
            this.freez.Size = new System.Drawing.Size(75, 23);
            this.freez.TabIndex = 9;
            this.freez.Text = "freez test";
            this.freez.UseVisualStyleBackColor = true;
            this.freez.Click += new System.EventHandler(this.freez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.freez);
            this.Controls.Add(this.bclTread);
            this.Controls.Add(this.Trajectory);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.TestThread);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trajectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button TestThread;
        private System.Windows.Forms.NumericUpDown Distance;
        private System.Windows.Forms.NumericUpDown Trajectory;
        private System.Windows.Forms.Button bclTread;
        private System.Windows.Forms.Button freez;
    }
}

