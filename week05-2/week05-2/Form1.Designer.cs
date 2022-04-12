
namespace week05_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRollDice = new System.Windows.Forms.Button();
            this.labelFirstNum = new System.Windows.Forms.Label();
            this.labelSecNum = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(17, 13);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(133, 35);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // labelFirstNum
            // 
            this.labelFirstNum.BackColor = System.Drawing.Color.Maroon;
            this.labelFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFirstNum.ForeColor = System.Drawing.Color.White;
            this.labelFirstNum.Location = new System.Drawing.Point(13, 53);
            this.labelFirstNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstNum.Name = "labelFirstNum";
            this.labelFirstNum.Size = new System.Drawing.Size(51, 52);
            this.labelFirstNum.TabIndex = 1;
            this.labelFirstNum.Text = "1";
            this.labelFirstNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecNum
            // 
            this.labelSecNum.BackColor = System.Drawing.Color.Maroon;
            this.labelSecNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSecNum.ForeColor = System.Drawing.Color.White;
            this.labelSecNum.Location = new System.Drawing.Point(99, 53);
            this.labelSecNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecNum.Name = "labelSecNum";
            this.labelSecNum.Size = new System.Drawing.Size(51, 52);
            this.labelSecNum.TabIndex = 2;
            this.labelSecNum.Text = "1";
            this.labelSecNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(168, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(261, 467);
            this.labelResult.TabIndex = 3;
            this.labelResult.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 485);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSecNum);
            this.Controls.Add(this.labelFirstNum);
            this.Controls.Add(this.btnRollDice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label labelFirstNum;
        private System.Windows.Forms.Label labelSecNum;
        private System.Windows.Forms.Label labelResult;
    }
}

