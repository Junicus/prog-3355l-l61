using Lab61.Data;

namespace Lab61;

public partial class frmMain : Form
{
    private readonly PuntajesDbContext _context;

    public frmMain()
    {
        _context = new PuntajesDbContext();

        InitializeComponent();
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
        var profesores = _context.Profesores.Where(p => p.Pueblo == cbPueblo.SelectedValue).ToList();
        lvProfesores.Items.Clear();
        lvProfesores.Items.AddRange(profesores.Select(p => new ListViewItem(new[] { p.Nombre, p.Apellido, p.Edad.ToString(), p.Pueblo })).ToArray());

        var estudiantes = _context.Estudiantes.Where(p => p.Pueblo == cbPueblo.SelectedValue).ToList();
        lvEstudiantes.Items.Clear();
        lvEstudiantes.Items.AddRange(estudiantes.Select(p => new ListViewItem(new[] { p.Nombre, p.Telefono, p.Pueblo, p.ZipCode })).ToArray());
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        lvProfesores.Items.Clear();
        lvEstudiantes.Items.Clear();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        var pueblos = _context.Pueblos.Select(p => p.Name).ToList();

        cbPueblo.DataSource = pueblos;
    }
}
