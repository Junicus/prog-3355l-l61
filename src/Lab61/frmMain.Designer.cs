namespace Lab61;

partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPueblo = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lvProfesores = new System.Windows.Forms.ListView();
            this.chProfNombre = new System.Windows.Forms.ColumnHeader();
            this.chProfApellido = new System.Windows.Forms.ColumnHeader();
            this.chProfEdad = new System.Windows.Forms.ColumnHeader();
            this.chProfPueblo = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lvEstudiantes = new System.Windows.Forms.ListView();
            this.chEstNombre = new System.Windows.Forms.ColumnHeader();
            this.chEstTelefono = new System.Windows.Forms.ColumnHeader();
            this.chEstPueblo = new System.Windows.Forms.ColumnHeader();
            this.chEstZipCode = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbPueblo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCargar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiar, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pueblo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPueblo
            // 
            this.cbPueblo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPueblo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPueblo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPueblo.FormattingEnabled = true;
            this.cbPueblo.Location = new System.Drawing.Point(59, 11);
            this.cbPueblo.Margin = new System.Windows.Forms.Padding(5);
            this.cbPueblo.Name = "cbPueblo";
            this.cbPueblo.Size = new System.Drawing.Size(231, 23);
            this.cbPueblo.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = true;
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCargar.Location = new System.Drawing.Point(300, 5);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Padding = new System.Windows.Forms.Padding(5);
            this.btnCargar.Size = new System.Drawing.Size(231, 35);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.Location = new System.Drawing.Point(541, 5);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Size = new System.Drawing.Size(232, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lvProfesores, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 136);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Profesores";
            // 
            // lvProfesores
            // 
            this.lvProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProfNombre,
            this.chProfApellido,
            this.chProfEdad,
            this.chProfPueblo});
            this.lvProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProfesores.Location = new System.Drawing.Point(3, 28);
            this.lvProfesores.Name = "lvProfesores";
            this.lvProfesores.Size = new System.Drawing.Size(772, 105);
            this.lvProfesores.TabIndex = 1;
            this.lvProfesores.UseCompatibleStateImageBehavior = false;
            this.lvProfesores.View = System.Windows.Forms.View.Details;
            // 
            // chProfNombre
            // 
            this.chProfNombre.Text = "Nombre";
            this.chProfNombre.Width = 180;
            // 
            // chProfApellido
            // 
            this.chProfApellido.Text = "Apellido";
            this.chProfApellido.Width = 180;
            // 
            // chProfEdad
            // 
            this.chProfEdad.Text = "Edad";
            this.chProfEdad.Width = 120;
            // 
            // chProfPueblo
            // 
            this.chProfPueblo.Text = "Pueblo";
            this.chProfPueblo.Width = 180;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lvEstudiantes, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 137);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estudiantes";
            // 
            // lvEstudiantes
            // 
            this.lvEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEstNombre,
            this.chEstTelefono,
            this.chEstPueblo,
            this.chEstZipCode});
            this.lvEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEstudiantes.Location = new System.Drawing.Point(3, 28);
            this.lvEstudiantes.Name = "lvEstudiantes";
            this.lvEstudiantes.Size = new System.Drawing.Size(772, 106);
            this.lvEstudiantes.TabIndex = 1;
            this.lvEstudiantes.UseCompatibleStateImageBehavior = false;
            this.lvEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // chEstNombre
            // 
            this.chEstNombre.Text = "Nombre";
            this.chEstNombre.Width = 180;
            // 
            // chEstTelefono
            // 
            this.chEstTelefono.Text = "Teléfono";
            this.chEstTelefono.Width = 180;
            // 
            // chEstPueblo
            // 
            this.chEstPueblo.Text = "Pueblo";
            this.chEstPueblo.Width = 120;
            // 
            // chEstZipCode
            // 
            this.chEstZipCode.Text = "Zip Code";
            this.chEstZipCode.Width = 120;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 375);
            this.Name = "frmMain";
            this.Text = "Información de Profesores y Estudiantes";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label1;
    private ComboBox cbPueblo;
    private Button btnCargar;
    private Button btnLimpiar;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private Label label2;
    private ListView lvProfesores;
    private ColumnHeader chProfNombre;
    private ColumnHeader chProfApellido;
    private ColumnHeader chProfEdad;
    private ColumnHeader chProfPueblo;
    private Label label3;
    private ListView lvEstudiantes;
    private ColumnHeader chEstNombre;
    private ColumnHeader chEstTelefono;
    private ColumnHeader chEstPueblo;
    private ColumnHeader chEstZipCode;
}
