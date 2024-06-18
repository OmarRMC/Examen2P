using ClassLibrary1; 
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ConexionDB conexion_bd;
        public Form1()
        {
            InitializeComponent();
            conexion_bd = new ConexionDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<List<string>> estudiantes = conexion_bd.getEstudiantes();
            foreach (List<string> estudiante in estudiantes)
            {

                int rowIndex = dataGridView1.Rows.Add(
                       estudiante[0].ToString(),
                       estudiante[1].ToString(),
                       estudiante[2].ToString(),
                       estudiante[3].ToString(),
                       estudiante[4].ToString(),
                       estudiante[5].ToString()
                   );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
