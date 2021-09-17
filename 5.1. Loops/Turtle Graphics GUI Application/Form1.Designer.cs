
namespace Turtle_Graphics_GUI_Application
{
    partial class FormTurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHexagono = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonSpiral = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(38, 25);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(94, 40);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(38, 150);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(94, 40);
            this.buttonShowHideTurtle.TabIndex = 1;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(38, 88);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 41);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHexagono
            // 
            this.buttonHexagono.Location = new System.Drawing.Point(38, 215);
            this.buttonHexagono.Name = "buttonHexagono";
            this.buttonHexagono.Size = new System.Drawing.Size(94, 37);
            this.buttonHexagono.TabIndex = 3;
            this.buttonHexagono.Text = "Hexagono";
            this.buttonHexagono.UseVisualStyleBackColor = true;
            this.buttonHexagono.Click += new System.EventHandler(this.buttonHexagono_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(38, 280);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(94, 37);
            this.buttonStar.TabIndex = 4;
            this.buttonStar.Text = "Star";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // buttonSpiral
            // 
            this.buttonSpiral.Location = new System.Drawing.Point(38, 344);
            this.buttonSpiral.Name = "buttonSpiral";
            this.buttonSpiral.Size = new System.Drawing.Size(94, 36);
            this.buttonSpiral.TabIndex = 5;
            this.buttonSpiral.Text = "Spiral";
            this.buttonSpiral.UseVisualStyleBackColor = true;
            this.buttonSpiral.Click += new System.EventHandler(this.buttonSpiral_Click);
            // 
            // buttonSun
            // 
            this.buttonSun.Location = new System.Drawing.Point(38, 407);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(94, 36);
            this.buttonSun.TabIndex = 6;
            this.buttonSun.Text = "Sun";
            this.buttonSun.UseVisualStyleBackColor = true;
            this.buttonSun.Click += new System.EventHandler(this.buttonSun_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(38, 469);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(94, 36);
            this.buttonTriangle.TabIndex = 7;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // FormTurtleGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 547);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonSun);
            this.Controls.Add(this.buttonSpiral);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonHexagono);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormTurtleGraphics";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turtle Graphics ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHexagono;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonSpiral;
        private System.Windows.Forms.Button buttonSun;
        private System.Windows.Forms.Button buttonTriangle;
    }
}

