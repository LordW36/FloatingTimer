namespace FloatingStopWatch
{
    partial class StopWatchFace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_PP = new System.Windows.Forms.Button();
            this.TxBx_StartTime = new System.Windows.Forms.TextBox();
            this.TxBx_Label = new System.Windows.Forms.TextBox();
            this.TLP_TimeContainer = new System.Windows.Forms.TableLayoutPanel();
            this.Lab_Time = new System.Windows.Forms.Label();
            this.TLP_SWFace = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_TimeContainer.SuspendLayout();
            this.TLP_SWFace.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.AutoSize = true;
            this.Btn_Reset.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(155, 127);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(34, 33);
            this.Btn_Reset.TabIndex = 4;
            this.Btn_Reset.Text = "↺";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_PP
            // 
            this.Btn_PP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_PP.AutoSize = true;
            this.Btn_PP.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PP.Location = new System.Drawing.Point(116, 127);
            this.Btn_PP.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_PP.Name = "Btn_PP";
            this.Btn_PP.Size = new System.Drawing.Size(39, 33);
            this.Btn_PP.TabIndex = 3;
            this.Btn_PP.Text = "►";
            this.Btn_PP.UseVisualStyleBackColor = true;
            this.Btn_PP.Click += new System.EventHandler(this.Btn_PP_Click);
            // 
            // TxBx_StartTime
            // 
            this.TxBx_StartTime.Location = new System.Drawing.Point(158, 3);
            this.TxBx_StartTime.Name = "TxBx_StartTime";
            this.TxBx_StartTime.Size = new System.Drawing.Size(69, 20);
            this.TxBx_StartTime.TabIndex = 2;
            this.TxBx_StartTime.Text = "00:02:00";
            // 
            // TxBx_Label
            // 
            this.TxBx_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxBx_Label.Location = new System.Drawing.Point(3, 3);
            this.TxBx_Label.Name = "TxBx_Label";
            this.TxBx_Label.Size = new System.Drawing.Size(149, 20);
            this.TxBx_Label.TabIndex = 1;
            this.TxBx_Label.Text = "Timer";
            // 
            // TLP_TimeContainer
            // 
            this.TLP_TimeContainer.ColumnCount = 3;
            this.TLP_SWFace.SetColumnSpan(this.TLP_TimeContainer, 2);
            this.TLP_TimeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TimeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_TimeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TimeContainer.Controls.Add(this.Lab_Time, 1, 1);
            this.TLP_TimeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_TimeContainer.Location = new System.Drawing.Point(0, 26);
            this.TLP_TimeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_TimeContainer.Name = "TLP_TimeContainer";
            this.TLP_TimeContainer.RowCount = 3;
            this.TLP_TimeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TimeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TimeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TimeContainer.Size = new System.Drawing.Size(230, 101);
            this.TLP_TimeContainer.TabIndex = 0;
            // 
            // Lab_Time
            // 
            this.Lab_Time.AutoSize = true;
            this.Lab_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Time.Location = new System.Drawing.Point(43, 32);
            this.Lab_Time.Margin = new System.Windows.Forms.Padding(3);
            this.Lab_Time.Name = "Lab_Time";
            this.Lab_Time.Size = new System.Drawing.Size(143, 37);
            this.Lab_Time.TabIndex = 0;
            this.Lab_Time.Text = "00:00:00";
            // 
            // TLP_SWFace
            // 
            this.TLP_SWFace.ColumnCount = 2;
            this.TLP_SWFace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_SWFace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_SWFace.Controls.Add(this.TLP_TimeContainer, 0, 1);
            this.TLP_SWFace.Controls.Add(this.TxBx_Label, 0, 0);
            this.TLP_SWFace.Controls.Add(this.TxBx_StartTime, 1, 0);
            this.TLP_SWFace.Controls.Add(this.Btn_PP, 0, 2);
            this.TLP_SWFace.Controls.Add(this.Btn_Reset, 1, 2);
            this.TLP_SWFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_SWFace.Location = new System.Drawing.Point(0, 0);
            this.TLP_SWFace.Name = "TLP_SWFace";
            this.TLP_SWFace.RowCount = 3;
            this.TLP_SWFace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_SWFace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_SWFace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_SWFace.Size = new System.Drawing.Size(230, 160);
            this.TLP_SWFace.TabIndex = 0;
            // 
            // StopWatchFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP_SWFace);
            this.Name = "StopWatchFace";
            this.Size = new System.Drawing.Size(230, 160);
            this.TLP_TimeContainer.ResumeLayout(false);
            this.TLP_TimeContainer.PerformLayout();
            this.TLP_SWFace.ResumeLayout(false);
            this.TLP_SWFace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_PP;
        private System.Windows.Forms.TextBox TxBx_StartTime;
        private System.Windows.Forms.TextBox TxBx_Label;
        private System.Windows.Forms.TableLayoutPanel TLP_TimeContainer;
        private System.Windows.Forms.TableLayoutPanel TLP_SWFace;
        private System.Windows.Forms.Label Lab_Time;
    }
}
