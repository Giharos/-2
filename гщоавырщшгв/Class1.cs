using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_2
{
    public class Class1
    {
        public static int Find(DataGridView table)
        {
            int sum = 0;
            for (int j = 0; j < table.RowCount; j++)
                for (int i = 0; i < table.ColumnCount; i++)
                {
                if (Convert.ToInt32(table[i, j].Value) > 15)
                    sum += Convert.ToInt32(table[i, j].Value);
            }
            return sum;
        }
    }
}
