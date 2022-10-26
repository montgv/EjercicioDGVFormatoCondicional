namespace EjercicioDGVFormatoCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void definirDatosIniciales(int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = 553;
                fila.Cells[1].Value = "Montse";
                fila.Cells[2].Value = "Garrido";
                fila.Cells[3].Value = "Valero";
                fila.Cells[4].Value = "Baeza";
                fila.Cells[5].Value = "15/08/2000";
                fila.Cells[6].Value = "A";
                fila.Cells[7].Value = "1550,50";

                dgv.Rows.Add(fila);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}