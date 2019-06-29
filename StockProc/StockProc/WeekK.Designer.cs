namespace StockProc
{
    partial class WeekK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekK));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rowMergeView_weekK = new StockProc.RowMergeView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView_weekK)).BeginInit();
            this.SuspendLayout();
            // 
            // rowMergeView_weekK
            // 
            this.rowMergeView_weekK.AllowUserToAddRows = false;
            this.rowMergeView_weekK.AllowUserToDeleteRows = false;
            this.rowMergeView_weekK.AllowUserToResizeColumns = false;
            this.rowMergeView_weekK.AllowUserToResizeRows = false;
            this.rowMergeView_weekK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rowMergeView_weekK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rowMergeView_weekK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowMergeView_weekK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.month,
            this.week,
            this.date,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Total});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rowMergeView_weekK.DefaultCellStyle = dataGridViewCellStyle12;
            this.rowMergeView_weekK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowMergeView_weekK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rowMergeView_weekK.Location = new System.Drawing.Point(0, 0);
            this.rowMergeView_weekK.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.rowMergeView_weekK.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rowMergeView_weekK.MergeColumnNames")));
            this.rowMergeView_weekK.Name = "rowMergeView_weekK";
            this.rowMergeView_weekK.RowTemplate.Height = 23;
            this.rowMergeView_weekK.Size = new System.Drawing.Size(1101, 733);
            this.rowMergeView_weekK.TabIndex = 0;
            this.rowMergeView_weekK.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.rowMergeView_weekK_CellPainting);
            this.rowMergeView_weekK.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rowMergeView_weekK_ColumnHeaderMouseClick);
            // 
            // year
            // 
            this.year.DataPropertyName = "col0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.year.DefaultCellStyle = dataGridViewCellStyle2;
            this.year.HeaderText = "年份";
            this.year.Name = "year";
            // 
            // month
            // 
            this.month.DataPropertyName = "col01";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.month.DefaultCellStyle = dataGridViewCellStyle3;
            this.month.HeaderText = "月份";
            this.month.Name = "month";
            // 
            // week
            // 
            this.week.DataPropertyName = "col1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.week.DefaultCellStyle = dataGridViewCellStyle4;
            this.week.HeaderText = "周数";
            this.week.Name = "week";
            // 
            // date
            // 
            this.date.DataPropertyName = "col2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.HeaderText = "项目";
            this.date.Name = "date";
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "col3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Monday.DefaultCellStyle = dataGridViewCellStyle6;
            this.Monday.HeaderText = "周一（亿）";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "col4";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tuesday.DefaultCellStyle = dataGridViewCellStyle7;
            this.Tuesday.HeaderText = "周二（亿）";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "col5";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Wednesday.DefaultCellStyle = dataGridViewCellStyle8;
            this.Wednesday.HeaderText = "周三（亿）";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "col6";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thursday.DefaultCellStyle = dataGridViewCellStyle9;
            this.Thursday.HeaderText = "周四（亿）";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "col7";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Friday.DefaultCellStyle = dataGridViewCellStyle10;
            this.Friday.HeaderText = "周五（亿）";
            this.Friday.Name = "Friday";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "col8";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Total.DefaultCellStyle = dataGridViewCellStyle11;
            this.Total.HeaderText = "累计（亿）";
            this.Total.Name = "Total";
            // 
            // WeekK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 733);
            this.Controls.Add(this.rowMergeView_weekK);
            this.Name = "WeekK";
            this.Text = "周K基准量";
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView_weekK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public RowMergeView rowMergeView_weekK;
        private bool isColor = false;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}