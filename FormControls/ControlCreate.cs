﻿using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Controls;

namespace FormControls
{
    class ControlCreate
    {
        public static DarkLabel NewLabel(DarkLabel label, int x, int y, string name)
        {
            label.Text = $"{name}";
            label.Location = new Point(x, y);
            label.AutoSize = true;
            return label;
        }

        public static DarkNumericUpDown NewNumeric(DarkNumericUpDown numeric, int x, int y, int value, int min, int max)
        {
            numeric.Location = new Point(x, y);
            numeric.Value = value;
            numeric.Minimum = min;
            numeric.Maximum = max;
            return numeric;
        }

        public static DataGridView NewDataGrid(DataGridView datagridview, int x, int y, int width, int height, string name)
        {
            datagridview.BackgroundColor = Color.FromArgb(60, 63, 65);
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.DefaultCellStyle.BackColor = Color.FromArgb(60, 63, 65);
            datagridview.DefaultCellStyle.ForeColor = Color.White;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            datagridview.GridColor = Color.DimGray;

            datagridview.AllowDrop = false;
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToResizeRows = false;
            datagridview.AllowUserToDeleteRows = false;
            datagridview.AllowUserToOrderColumns = false;
            datagridview.AllowUserToResizeColumns = false;
            datagridview.ReadOnly = true;
            datagridview.Name = name;
            datagridview.Location = new Point(x, y);
            datagridview.Size = new Size(width, height);
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            datagridview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            if (datagridview.RowCount == 0 && name == "PlayerGrid")
            {
                datagridview.Columns.Add("Level", "Level");
                datagridview.Columns.Add("Exp", "Exp");
                datagridview.Columns.Add("Attack", "Attack");
                datagridview.Columns.Add("Defense", "Defense");
                datagridview.Columns.Add("MagicAttack", "Magic Attack");
                datagridview.Columns.Add("MagicDefense", "Magic Defense");
                datagridview.Columns.Add("Speed", "Speed");
                datagridview.Columns.Add("HitPoints", "Hit Points");
            }
            return datagridview;
        }

        public static DarkButton NewButton(DarkButton button, int x, int y, int width, int height, string text)
        {
            button.Text = "Update!";
            button.Location = new Point(x, y);
            button.Size = new Size(width, height);
            return button;
        }

        public static DarkCheckBox NewCheckBox(DarkCheckBox checkBox, int x, int y, string text)
        {
            checkBox.Text = text;
            checkBox.Location = new Point(x, y);
            checkBox.AutoSize = true;
            return checkBox;
        }
    }
}