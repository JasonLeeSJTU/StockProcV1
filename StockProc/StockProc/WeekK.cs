using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockProc
{
    public partial class WeekK : Form
    {
        public WeekK()
        {
            InitializeComponent();
        }


        private void rowMergeView_weekK_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (!isColor)
            {
                for (int ii = 1; ii < rowMergeView_weekK.Rows.Count; ii += 2)
                {
                    for (int jj = 4; jj < 10; jj++)
                    {
                        if (rowMergeView_weekK.Rows[ii].Cells[jj].Value.ToString() != "" && Convert.ToDouble(rowMergeView_weekK.Rows[ii].Cells[jj].Value) > 0)
                        {
                            rowMergeView_weekK.Rows[ii].Cells[jj].Style.BackColor = Color.Red;
                        }
                        else if (rowMergeView_weekK.Rows[ii].Cells[jj].Value.ToString() != "" && Convert.ToDouble(rowMergeView_weekK.Rows[ii].Cells[jj].Value) < 0)
                        {
                            rowMergeView_weekK.Rows[ii].Cells[jj].Style.BackColor = Color.Green;
                        }
                    }
                }
                isColor = true;
            }
        }

        private void rowMergeView_weekK_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isColor = false;
        }
    }
}
