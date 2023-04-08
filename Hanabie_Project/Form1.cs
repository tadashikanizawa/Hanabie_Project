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
            tools.tools.AddRange(Nishin.CarregarEndmill());
            // Use um SortableBindingList em vez de uma lista simples
            SortableBindingList<Tools> sortableList = new SortableBindingList<Tools>(tools.tools);
            dataGridView1.DataSource = sortableList;
            dataGridView1.Refresh();

            LoadMarkComboBox();
            LoadTypeComboBox();
        }
        public List<Tools> FilterTools(string mark, string type, string id, int? laminas, float? kei, float? kubushita, float? hachou, float? kado, float? zenchou)
        {
            var filteredTools = tools.tools.Where(tool =>
                (string.IsNullOrEmpty(mark) || mark == "ALL" || tool.Mark == mark) &&
                 (string.IsNullOrEmpty(type) || type == "ALL" || tool.Type == type) &&
                (string.IsNullOrEmpty(id) || tool.ID.Contains(id)) &&
                (!laminas.HasValue || tool.Laminas >= laminas.Value) &&
                (!kei.HasValue || tool.Kei <= kei.Value) &&
                (!kubushita.HasValue || tool.Kubushita >= kubushita.Value) &&
                (!hachou.HasValue || tool.Hachou >= hachou.Value) &&
                (!kado.HasValue || tool.Kado == kado.Value) &&
                (!zenchou.HasValue || tool.Zenchou >= zenchou.Value)
            );

            return filteredTools.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        private void UpdateDataGridView()

        {
            string mark = Mark_ComboBox.SelectedIndex != -1 ? Mark_ComboBox.SelectedItem.ToString() : null;
            string type = Type_ComboBox.SelectedIndex != -1 ? Type_ComboBox.SelectedItem.ToString() : null;

            string id = ID_TextBox.Text;

            int? laminas = null;
            if (int.TryParse(Laminas_TextBox.Text, out int laminasValue))
            {
                laminas = laminasValue;
            }

            float? kei = null;
            if (float.TryParse(Kei_TextBox.Text, out float keiValue))
            {
                kei = keiValue;
            }

            float? zenchouMin = null;
            if (float.TryParse(Zenchou_Textbox.Text, out float zenchou))
            {
                zenchouMin = zenchou;
            }

            float? kado = null;
            if (float.TryParse(Kado_Textbox.Text, out float kadoValue))
            {
                kado = kadoValue;
            }

            float? hachou = null;
            if (float.TryParse(Hachou_Textbox.Text, out float hachouValue))
            {
                hachou = hachouValue;
            }

            float? kubushitaMax = null;
            if (float.TryParse(Kubushita_Textbox.Text, out float kubushita))
            {
                kubushitaMax = kubushita;
            }

            var filteredTools = FilterTools(mark, type, id, laminas, kei, kubushita, hachou, kado, zenchou);
            dataGridView1.DataSource = new SortableBindingList<Tools>(filteredTools);
        }

        private void Textboxs_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void LoadMarkComboBox()
        {
            Mark_ComboBox.DataSource = Enum.GetValues(typeof(Marks));
            Mark_ComboBox.SelectedIndex = -1;
        }

        private void LoadTypeComboBox()
        {
            Type_ComboBox.DataSource = Enum.GetValues(typeof(Types));
            Type_ComboBox.SelectedIndex = -1;
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                Clipboard.SetText(id);

                label8.Text = "ID copiado para a área de transferência!";
                label8.Visible = true;

                await Task.Delay(2000); // Aguarde 2 segundos (2000 milissegundos)

                label8.Visible = false;
            }
        }
    }
}