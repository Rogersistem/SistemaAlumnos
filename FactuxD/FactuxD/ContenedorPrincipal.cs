using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hacemos el llamado al formulario alumnos
            RegistroAlumnos reg = new RegistroAlumnos();
            reg.MdiParent = this;
            reg.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Desea Salir?", "Aviso", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //hace el llamado al formulario Mantenedor de Alumnos
            MantAlumnos regAl = new MantAlumnos();
            regAl.MdiParent = this;
            regAl.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hacemos el llamado al Formulario Notas
            Notas nota = new Notas();
            nota.MdiParent = this;
            nota.Show();

        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hacemos el llamado al formulario Mantenedor programas
            Mant_Programas mantp = new Mant_Programas();
            mantp.MdiParent = this;
            mantp.Show();

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace llamdo a la calculadora
            Calculadora cal = new Calculadora();
            cal.MdiParent = this;
            cal.Show();

        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se hace el llamdo al formulario Matricula
            Matricula matric = new Matricula();
            matric.MdiParent = this;
            matric.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Matricula matri = new Matricula();
            matri.MdiParent = this;
            matri.Show();
        }

        private void consultarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamado al formulario Pagos
            Pagos not = new Pagos();
            not.MdiParent = this;
            not.Show();
        }

        private void reporte01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamado al formulario Reporte Pagos
            Reporte_Pagos rep = new Reporte_Pagos();
            rep.MdiParent = this;
            rep.Show();
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamado al formulario de reportes de matricula
            ReporteMatricula repMat = new ReporteMatricula();
            repMat.MdiParent = this;
            repMat.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamdo Mantenedor Cursos
            MantCursos mcu = new MantCursos();
            mcu.MdiParent = this;
            mcu.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamdo al formulario mantenedor Docentes
            MantenedorDocentes mantD = new MantenedorDocentes();
            mantD.MdiParent = this;
            mantD.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llama al formulario reportes de notas
            ReporteNotas rep = new ReporteNotas();
            rep.MdiParent = this;
            rep.Show();
        }

        private void backupDBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hace el llamdo a la formulario copia de seguridad
            BackupDba bac = new BackupDba();
            bac.MdiParent = this;
            bac.Show();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            Horarios hor = new Horarios();
            hor.MdiParent = this;
            hor.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReportAsistencia repor = new ReportAsistencia();
            repor.MdiParent = this;
            repor.Show();
            */
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listEvaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEvaluacion lev = new ListEvaluacion();
            lev.MdiParent = this;
            lev.Show();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAsistencia repor = new ReportAsistencia();
            repor.MdiParent = this;
            repor.Show();
        }
    }
}
