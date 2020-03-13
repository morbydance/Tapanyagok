using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.Presenters;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TablazatForm : Form, ITablazatView
    {
        private TablazatPresenter tablazatPresenter;
        private int pageCount;

        public TablazatForm()
        {
            InitializeComponent();
            tablazatPresenter = new TablazatPresenter(this);

            Init();

            tablazatPresenter.LoadData();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortBy = "Id";
            ascending = true;
        }

        public BindingList<tapanyag> bindingList {
            get => (BindingList<tapanyag>)tablazatDGV.DataSource;
            set => tablazatDGV.DataSource = value;
        } 
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }

        public string search => keresesTB.Text;

        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                oldalLbl.Text = pageNumber.ToString() + "/" + pageCount.ToString();
            }
        }

        private void mentesBtn_Click(object sender, EventArgs e)
        {

        }

        private void ujBtn_Click(object sender, EventArgs e)
        {

        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            int index = tablazatDGV.CurrentCell.RowIndex;
            tapanyag etel = bindingList.ElementAt(index);
            bindingList.RemoveAt(index);
            tablazatPresenter.Remove(etel.id);
        }

        private void keresesBtn_Click(object sender, EventArgs e)
        {

        }

        private void szerkesztesTSMI_Click(object sender, EventArgs e)
        {

        }

        private void torlesTSMI_Click(object sender, EventArgs e)
        {
            int index = tablazatDGV.CurrentCell.RowIndex;
            tapanyag etel = bindingList.ElementAt(index);
            bindingList.RemoveAt(index);
            tablazatPresenter.Remove(etel.id);
        }

        private void tablazatDGV_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tablazatDGV.CurrentCell = tablazatDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                tablazatDGV.Rows[e.RowIndex].Selected = true;
                tablazatDGV.Focus();
            }
        }

        private void elozoBtn_Click(object sender, EventArgs e)
        {
            pageNumber = Math.Max(1, --pageNumber);
            tablazatPresenter.LoadData();
        }

        private void elsoBtn_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            tablazatPresenter.LoadData();
        }

        private void kovetkezoBtn_Click(object sender, EventArgs e)
        {
            pageNumber = Math.Min(pageCount, ++pageNumber);
            tablazatPresenter.LoadData();
        }

        private void utolsoBtn_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            tablazatPresenter.LoadData();
        }
    }
}
