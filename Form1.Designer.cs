namespace DSED_01
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnImune = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.devToolkit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBomb = new System.Windows.Forms.Label();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.gbxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.devToolkit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 44);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Start";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTry
            // 
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTry.Location = new System.Drawing.Point(12, 81);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(163, 47);
            this.btnTry.TabIndex = 1;
            this.btnTry.Text = "Atempt disarm";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 47);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Restart Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnImune);
            this.gbxTools.Location = new System.Drawing.Point(12, 224);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(249, 168);
            this.gbxTools.TabIndex = 3;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Options";
            // 
            // btnImune
            // 
            this.btnImune.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImune.Location = new System.Drawing.Point(17, 31);
            this.btnImune.Name = "btnImune";
            this.btnImune.Size = new System.Drawing.Size(226, 51);
            this.btnImune.TabIndex = 0;
            this.btnImune.Text = "Use Shield";
            this.btnImune.UseVisualStyleBackColor = true;
            this.btnImune.Click += new System.EventHandler(this.btnImune_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 191);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Silver;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(463, 72);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(396, 56);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Outcome";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebug
            // 
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.Location = new System.Drawing.Point(6, 31);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(145, 26);
            this.lblDebug.TabIndex = 6;
            this.lblDebug.Text = "Dupe Status";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Silver;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(462, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(397, 53);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devToolkit
            // 
            this.devToolkit.Controls.Add(this.label2);
            this.devToolkit.Controls.Add(this.label1);
            this.devToolkit.Controls.Add(this.lblBomb);
            this.devToolkit.Controls.Add(this.lblTrigger);
            this.devToolkit.Controls.Add(this.lblDebug);
            this.devToolkit.Location = new System.Drawing.Point(554, 294);
            this.devToolkit.Name = "devToolkit";
            this.devToolkit.Size = new System.Drawing.Size(305, 187);
            this.devToolkit.TabIndex = 8;
            this.devToolkit.TabStop = false;
            this.devToolkit.Text = "Dev Tool Boox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "bomb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "trigger:";
            // 
            // lblBomb
            // 
            this.lblBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomb.Location = new System.Drawing.Point(48, 83);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(145, 26);
            this.lblBomb.TabIndex = 8;
            this.lblBomb.Text = "Bomb";
            // 
            // lblTrigger
            // 
            this.lblTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.Location = new System.Drawing.Point(48, 57);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(145, 26);
            this.lblTrigger.TabIndex = 7;
            this.lblTrigger.Text = "Trigger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 502);
            this.Controls.Add(this.devToolkit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bomb Blaster";
            this.gbxTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.devToolkit.ResumeLayout(false);
            this.devToolkit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnImune;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox devToolkit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBomb;
        private System.Windows.Forms.Label lblTrigger;
    }
}

