using Hanabie_Project.Marcas;
using System.Windows.Forms;

namespace Hanabie_Project
{
    public partial class Form1 : Form
    {
        public Tools tools;
        public Form1()
        {
            InitializeComponent();
            this.tools = new Tools();
            tools.tools.AddRange(Nishin.CarregarCSV("Nishin - Table 1.csv"));
            // Use um SortableBindingList em vez de uma lista simples
            SortableBindingList<Tools> sortableList = new SortableBindingList<Tools>(tools.tools);
            dataGridView1.DataSource = sortableList;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}