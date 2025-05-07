namespace SysFix_Tool
{
    partial class SysFixTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysFixTool));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelHerramienta = new System.Windows.Forms.Panel();
            this.TerminalSys = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Maximizar = new System.Windows.Forms.Button();
            this.Restaurar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.Organizador = new System.Windows.Forms.TabControl();
            this.Reparacion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ReparacionCompleta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReparacionIMG = new System.Windows.Forms.Button();
            this.Diagnosticar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SFC = new System.Windows.Forms.Button();
            this.Diagnostico = new System.Windows.Forms.Label();
            this.ControlProcesos = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DetenerProcesos = new System.Windows.Forms.Button();
            this.VerProcesos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SeleccionarArchivo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.RepararRed = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.HistorialNav = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ConexActivas = new System.Windows.Forms.Button();
            this.InfoRed = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LimpiarDNS = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Limpieza = new System.Windows.Forms.TabPage();
            this.EleminarArchivosDeInstalacion = new System.Windows.Forms.Button();
            this.ArchivosInecesarios = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Procesosospechosos = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ActualizarAll = new System.Windows.Forms.Button();
            this.ActualizacionDisponible = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DesactivarProcesos = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.VerficarDisco = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.EstadoRAM = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.PanelHerramienta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalSys)).BeginInit();
            this.Organizador.SuspendLayout();
            this.Reparacion.SuspendLayout();
            this.ControlProcesos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Limpieza.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SysFix Tool";
            // 
            // PanelHerramienta
            // 
            this.PanelHerramienta.Controls.Add(this.TerminalSys);
            this.PanelHerramienta.Controls.Add(this.Cerrar);
            this.PanelHerramienta.Controls.Add(this.lblTitulo);
            this.PanelHerramienta.Controls.Add(this.Maximizar);
            this.PanelHerramienta.Controls.Add(this.Restaurar);
            this.PanelHerramienta.Controls.Add(this.Minimizar);
            this.PanelHerramienta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHerramienta.Location = new System.Drawing.Point(0, 0);
            this.PanelHerramienta.Name = "PanelHerramienta";
            this.PanelHerramienta.Size = new System.Drawing.Size(810, 30);
            this.PanelHerramienta.TabIndex = 5;
            // 
            // TerminalSys
            // 
            this.TerminalSys.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TerminalSys.Image = global::SysFix_Tool.Properties.Resources.TerminalSys;
            this.TerminalSys.Location = new System.Drawing.Point(3, 0);
            this.TerminalSys.Name = "TerminalSys";
            this.TerminalSys.Size = new System.Drawing.Size(40, 30);
            this.TerminalSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TerminalSys.TabIndex = 6;
            this.TerminalSys.TabStop = false;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Image = global::SysFix_Tool.Properties.Resources.Cerrar;
            this.Cerrar.Location = new System.Drawing.Point(770, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(40, 30);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.FlatAppearance.BorderSize = 0;
            this.Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximizar.Image = global::SysFix_Tool.Properties.Resources.Maximizar;
            this.Maximizar.Location = new System.Drawing.Point(724, 0);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(40, 30);
            this.Maximizar.TabIndex = 2;
            this.Maximizar.UseVisualStyleBackColor = true;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.FlatAppearance.BorderSize = 0;
            this.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurar.Image = global::SysFix_Tool.Properties.Resources.Restaurar;
            this.Restaurar.Location = new System.Drawing.Point(722, 0);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(40, 30);
            this.Restaurar.TabIndex = 4;
            this.Restaurar.UseVisualStyleBackColor = true;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Image = global::SysFix_Tool.Properties.Resources.Minimizar;
            this.Minimizar.Location = new System.Drawing.Point(672, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 30);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.UseVisualStyleBackColor = true;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Organizador
            // 
            this.Organizador.Controls.Add(this.Reparacion);
            this.Organizador.Controls.Add(this.ControlProcesos);
            this.Organizador.Controls.Add(this.tabPage1);
            this.Organizador.Controls.Add(this.Limpieza);
            this.Organizador.Controls.Add(this.tabPage2);
            this.Organizador.Controls.Add(this.tabPage3);
            this.Organizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Organizador.HotTrack = true;
            this.Organizador.Location = new System.Drawing.Point(0, 30);
            this.Organizador.Margin = new System.Windows.Forms.Padding(0);
            this.Organizador.Name = "Organizador";
            this.Organizador.Padding = new System.Drawing.Point(0, 0);
            this.Organizador.SelectedIndex = 0;
            this.Organizador.Size = new System.Drawing.Size(810, 417);
            this.Organizador.TabIndex = 0;
            // 
            // Reparacion
            // 
            this.Reparacion.AutoScroll = true;
            this.Reparacion.BackColor = System.Drawing.Color.Black;
            this.Reparacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reparacion.Controls.Add(this.label4);
            this.Reparacion.Controls.Add(this.ReparacionCompleta);
            this.Reparacion.Controls.Add(this.label3);
            this.Reparacion.Controls.Add(this.ReparacionIMG);
            this.Reparacion.Controls.Add(this.Diagnosticar);
            this.Reparacion.Controls.Add(this.label2);
            this.Reparacion.Controls.Add(this.label1);
            this.Reparacion.Controls.Add(this.SFC);
            this.Reparacion.Controls.Add(this.Diagnostico);
            this.Reparacion.ForeColor = System.Drawing.Color.White;
            this.Reparacion.ImageKey = "(ninguno)";
            this.Reparacion.Location = new System.Drawing.Point(4, 26);
            this.Reparacion.Margin = new System.Windows.Forms.Padding(0);
            this.Reparacion.Name = "Reparacion";
            this.Reparacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Reparacion.Size = new System.Drawing.Size(802, 387);
            this.Reparacion.TabIndex = 0;
            this.Reparacion.Text = "Reparacion";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(246, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Haz Click Aqui Para hacer todos lo anteror ";
            // 
            // ReparacionCompleta
            // 
            this.ReparacionCompleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReparacionCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ReparacionCompleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReparacionCompleta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReparacionCompleta.FlatAppearance.BorderSize = 0;
            this.ReparacionCompleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReparacionCompleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ReparacionCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReparacionCompleta.ForeColor = System.Drawing.Color.White;
            this.ReparacionCompleta.Location = new System.Drawing.Point(270, 289);
            this.ReparacionCompleta.Name = "ReparacionCompleta";
            this.ReparacionCompleta.Size = new System.Drawing.Size(214, 30);
            this.ReparacionCompleta.TabIndex = 10;
            this.ReparacionCompleta.Text = "Reparacion Completa";
            this.ReparacionCompleta.UseVisualStyleBackColor = false;
            this.ReparacionCompleta.Click += new System.EventHandler(this.ReparacionCompleta_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(74, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "sfc /scannow\r\n";
            // 
            // ReparacionIMG
            // 
            this.ReparacionIMG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReparacionIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ReparacionIMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReparacionIMG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReparacionIMG.FlatAppearance.BorderSize = 0;
            this.ReparacionIMG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReparacionIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ReparacionIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReparacionIMG.ForeColor = System.Drawing.Color.White;
            this.ReparacionIMG.Location = new System.Drawing.Point(559, 129);
            this.ReparacionIMG.Name = "ReparacionIMG";
            this.ReparacionIMG.Size = new System.Drawing.Size(214, 30);
            this.ReparacionIMG.TabIndex = 8;
            this.ReparacionIMG.Text = "Reparacion De Imagen";
            this.ReparacionIMG.UseVisualStyleBackColor = false;
            this.ReparacionIMG.Click += new System.EventHandler(this.ReparacionIMG_Click);
            // 
            // Diagnosticar
            // 
            this.Diagnosticar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Diagnosticar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.Diagnosticar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diagnosticar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Diagnosticar.FlatAppearance.BorderSize = 0;
            this.Diagnosticar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Diagnosticar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.Diagnosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diagnosticar.ForeColor = System.Drawing.Color.White;
            this.Diagnosticar.Location = new System.Drawing.Point(559, 77);
            this.Diagnosticar.Name = "Diagnosticar";
            this.Diagnosticar.Size = new System.Drawing.Size(214, 30);
            this.Diagnosticar.TabIndex = 7;
            this.Diagnosticar.Text = "Diagnostico";
            this.Diagnosticar.UseVisualStyleBackColor = false;
            this.Diagnosticar.Click += new System.EventHandler(this.Diagnosticar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(74, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "DISM /Online /Cleanup-Image /RestoreHealth";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(74, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DISM /Online /Cleanup-Image /CheckHealth";
            // 
            // SFC
            // 
            this.SFC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.SFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SFC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SFC.FlatAppearance.BorderSize = 0;
            this.SFC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SFC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.SFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFC.ForeColor = System.Drawing.Color.White;
            this.SFC.Location = new System.Drawing.Point(559, 178);
            this.SFC.Name = "SFC";
            this.SFC.Size = new System.Drawing.Size(214, 30);
            this.SFC.TabIndex = 4;
            this.SFC.Text = "Reparacion De Archivos";
            this.SFC.UseVisualStyleBackColor = false;
            this.SFC.Click += new System.EventHandler(this.SFC_Click);
            // 
            // Diagnostico
            // 
            this.Diagnostico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Diagnostico.AutoSize = true;
            this.Diagnostico.BackColor = System.Drawing.Color.Transparent;
            this.Diagnostico.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnostico.ForeColor = System.Drawing.Color.Lime;
            this.Diagnostico.Location = new System.Drawing.Point(113, 31);
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Size = new System.Drawing.Size(579, 18);
            this.Diagnostico.TabIndex = 3;
            this.Diagnostico.Text = "1.Diagnóstico → 2. Reparación de imagen → 3. Reparación de archivos.";
            // 
            // ControlProcesos
            // 
            this.ControlProcesos.BackColor = System.Drawing.Color.Black;
            this.ControlProcesos.Controls.Add(this.label10);
            this.ControlProcesos.Controls.Add(this.txtPID);
            this.ControlProcesos.Controls.Add(this.label6);
            this.ControlProcesos.Controls.Add(this.DetenerProcesos);
            this.ControlProcesos.Controls.Add(this.VerProcesos);
            this.ControlProcesos.Controls.Add(this.label7);
            this.ControlProcesos.Controls.Add(this.label8);
            this.ControlProcesos.Controls.Add(this.SeleccionarArchivo);
            this.ControlProcesos.Controls.Add(this.label9);
            this.ControlProcesos.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlProcesos.Location = new System.Drawing.Point(4, 26);
            this.ControlProcesos.Name = "ControlProcesos";
            this.ControlProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.ControlProcesos.Size = new System.Drawing.Size(802, 387);
            this.ControlProcesos.TabIndex = 1;
            this.ControlProcesos.Text = "Control de Procesos";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(301, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "PID de Proceso";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(419, 140);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 25);
            this.txtPID.TabIndex = 21;
            this.txtPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPID_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(85, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Eleminar Archivos Con Procesos";
            // 
            // DetenerProcesos
            // 
            this.DetenerProcesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetenerProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.DetenerProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetenerProcesos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DetenerProcesos.FlatAppearance.BorderSize = 0;
            this.DetenerProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DetenerProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.DetenerProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetenerProcesos.ForeColor = System.Drawing.Color.White;
            this.DetenerProcesos.Location = new System.Drawing.Point(546, 136);
            this.DetenerProcesos.Name = "DetenerProcesos";
            this.DetenerProcesos.Size = new System.Drawing.Size(214, 30);
            this.DetenerProcesos.TabIndex = 17;
            this.DetenerProcesos.Text = "Detener Proceso";
            this.DetenerProcesos.UseVisualStyleBackColor = false;
            this.DetenerProcesos.Click += new System.EventHandler(this.DetenerProcesos_Click);
            // 
            // VerProcesos
            // 
            this.VerProcesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.VerProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerProcesos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VerProcesos.FlatAppearance.BorderSize = 0;
            this.VerProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VerProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.VerProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerProcesos.ForeColor = System.Drawing.Color.White;
            this.VerProcesos.Location = new System.Drawing.Point(548, 84);
            this.VerProcesos.Name = "VerProcesos";
            this.VerProcesos.Size = new System.Drawing.Size(214, 30);
            this.VerProcesos.TabIndex = 16;
            this.VerProcesos.Text = "Ver Procesos";
            this.VerProcesos.UseVisualStyleBackColor = false;
            this.VerProcesos.Click += new System.EventHandler(this.VerProcesos_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(85, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Detener Proceso\r\n";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(85, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lista De Procesos";
            // 
            // SeleccionarArchivo
            // 
            this.SeleccionarArchivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SeleccionarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.SeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeleccionarArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SeleccionarArchivo.FlatAppearance.BorderSize = 0;
            this.SeleccionarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SeleccionarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.SeleccionarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.SeleccionarArchivo.Location = new System.Drawing.Point(544, 204);
            this.SeleccionarArchivo.Name = "SeleccionarArchivo";
            this.SeleccionarArchivo.Size = new System.Drawing.Size(214, 30);
            this.SeleccionarArchivo.TabIndex = 13;
            this.SeleccionarArchivo.Text = "Seleccionar Archivo";
            this.SeleccionarArchivo.UseVisualStyleBackColor = false;
            this.SeleccionarArchivo.Click += new System.EventHandler(this.SeleccionarArchivo_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(316, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado de Procesos\r\n\r\n";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.RepararRed);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.HistorialNav);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ConexActivas);
            this.tabPage1.Controls.Add(this.InfoRed);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.LimpiarDNS);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 387);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Estado de Red";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(52, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "netsh int ip reset";
            // 
            // RepararRed
            // 
            this.RepararRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RepararRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.RepararRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepararRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RepararRed.FlatAppearance.BorderSize = 0;
            this.RepararRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RepararRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.RepararRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepararRed.ForeColor = System.Drawing.Color.White;
            this.RepararRed.Location = new System.Drawing.Point(537, 287);
            this.RepararRed.Name = "RepararRed";
            this.RepararRed.Size = new System.Drawing.Size(214, 30);
            this.RepararRed.TabIndex = 21;
            this.RepararRed.Text = "Reparar Red";
            this.RepararRed.UseVisualStyleBackColor = false;
            this.RepararRed.Click += new System.EventHandler(this.RepararRed_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(52, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "ipconfig /displaydns";
            // 
            // HistorialNav
            // 
            this.HistorialNav.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistorialNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.HistorialNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistorialNav.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HistorialNav.FlatAppearance.BorderSize = 0;
            this.HistorialNav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HistorialNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.HistorialNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistorialNav.ForeColor = System.Drawing.Color.White;
            this.HistorialNav.Location = new System.Drawing.Point(537, 232);
            this.HistorialNav.Name = "HistorialNav";
            this.HistorialNav.Size = new System.Drawing.Size(214, 30);
            this.HistorialNav.TabIndex = 19;
            this.HistorialNav.Text = "Ver historial de Navegacion";
            this.HistorialNav.UseVisualStyleBackColor = false;
            this.HistorialNav.Click += new System.EventHandler(this.HistorialNav_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(52, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "ipconfig /flushdns";
            // 
            // ConexActivas
            // 
            this.ConexActivas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConexActivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ConexActivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConexActivas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConexActivas.FlatAppearance.BorderSize = 0;
            this.ConexActivas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConexActivas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ConexActivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConexActivas.ForeColor = System.Drawing.Color.White;
            this.ConexActivas.Location = new System.Drawing.Point(537, 120);
            this.ConexActivas.Name = "ConexActivas";
            this.ConexActivas.Size = new System.Drawing.Size(214, 30);
            this.ConexActivas.TabIndex = 17;
            this.ConexActivas.Text = "Conexiones Activas";
            this.ConexActivas.UseVisualStyleBackColor = false;
            this.ConexActivas.Click += new System.EventHandler(this.ConexActivas_Click);
            // 
            // InfoRed
            // 
            this.InfoRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.InfoRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InfoRed.FlatAppearance.BorderSize = 0;
            this.InfoRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InfoRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.InfoRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoRed.ForeColor = System.Drawing.Color.White;
            this.InfoRed.Location = new System.Drawing.Point(537, 76);
            this.InfoRed.Name = "InfoRed";
            this.InfoRed.Size = new System.Drawing.Size(214, 30);
            this.InfoRed.TabIndex = 16;
            this.InfoRed.Text = "Informacion De Red";
            this.InfoRed.UseVisualStyleBackColor = false;
            this.InfoRed.Click += new System.EventHandler(this.InfoRed_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(52, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "netstat -ano\r\n";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(52, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "ipconfig /all\r\n";
            // 
            // LimpiarDNS
            // 
            this.LimpiarDNS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LimpiarDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.LimpiarDNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarDNS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LimpiarDNS.FlatAppearance.BorderSize = 0;
            this.LimpiarDNS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LimpiarDNS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.LimpiarDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarDNS.ForeColor = System.Drawing.Color.White;
            this.LimpiarDNS.Location = new System.Drawing.Point(537, 173);
            this.LimpiarDNS.Name = "LimpiarDNS";
            this.LimpiarDNS.Size = new System.Drawing.Size(214, 30);
            this.LimpiarDNS.TabIndex = 13;
            this.LimpiarDNS.Text = "Limpiar DNS";
            this.LimpiarDNS.UseVisualStyleBackColor = false;
            this.LimpiarDNS.Click += new System.EventHandler(this.LimpiarDNS_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(304, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Estado de Red\r\n";
            // 
            // Limpieza
            // 
            this.Limpieza.BackColor = System.Drawing.Color.Black;
            this.Limpieza.Controls.Add(this.EleminarArchivosDeInstalacion);
            this.Limpieza.Controls.Add(this.ArchivosInecesarios);
            this.Limpieza.Controls.Add(this.label17);
            this.Limpieza.Controls.Add(this.label18);
            this.Limpieza.Controls.Add(this.label19);
            this.Limpieza.Location = new System.Drawing.Point(4, 26);
            this.Limpieza.Name = "Limpieza";
            this.Limpieza.Padding = new System.Windows.Forms.Padding(3);
            this.Limpieza.Size = new System.Drawing.Size(802, 387);
            this.Limpieza.TabIndex = 3;
            this.Limpieza.Text = "Limpieza De Archivos";
            // 
            // EleminarArchivosDeInstalacion
            // 
            this.EleminarArchivosDeInstalacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EleminarArchivosDeInstalacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.EleminarArchivosDeInstalacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EleminarArchivosDeInstalacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EleminarArchivosDeInstalacion.FlatAppearance.BorderSize = 0;
            this.EleminarArchivosDeInstalacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EleminarArchivosDeInstalacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.EleminarArchivosDeInstalacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EleminarArchivosDeInstalacion.ForeColor = System.Drawing.Color.White;
            this.EleminarArchivosDeInstalacion.Location = new System.Drawing.Point(549, 130);
            this.EleminarArchivosDeInstalacion.Name = "EleminarArchivosDeInstalacion";
            this.EleminarArchivosDeInstalacion.Size = new System.Drawing.Size(214, 30);
            this.EleminarArchivosDeInstalacion.TabIndex = 15;
            this.EleminarArchivosDeInstalacion.Text = "Eliminar archivos de instalación";
            this.EleminarArchivosDeInstalacion.UseVisualStyleBackColor = false;
            this.EleminarArchivosDeInstalacion.Click += new System.EventHandler(this.EleminarArchivosDeInstalacion_Click);
            // 
            // ArchivosInecesarios
            // 
            this.ArchivosInecesarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArchivosInecesarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ArchivosInecesarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArchivosInecesarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArchivosInecesarios.FlatAppearance.BorderSize = 0;
            this.ArchivosInecesarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ArchivosInecesarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ArchivosInecesarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchivosInecesarios.ForeColor = System.Drawing.Color.White;
            this.ArchivosInecesarios.Location = new System.Drawing.Point(549, 78);
            this.ArchivosInecesarios.Name = "ArchivosInecesarios";
            this.ArchivosInecesarios.Size = new System.Drawing.Size(214, 30);
            this.ArchivosInecesarios.TabIndex = 14;
            this.ArchivosInecesarios.Text = "Borrar Datos Inecesarios";
            this.ArchivosInecesarios.UseVisualStyleBackColor = false;
            this.ArchivosInecesarios.Click += new System.EventHandler(this.ArchivosInecesarios_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(64, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(328, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "dism /online /Cleanup-Image /StartComponentCleanup\r\n";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkGray;
            this.label18.Location = new System.Drawing.Point(64, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "cleanmgr\r\n";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(305, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 18);
            this.label19.TabIndex = 10;
            this.label19.Text = "Limpieza de archivos\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.EstadoRAM);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.VerficarDisco);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.DesactivarProcesos);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.Procesosospechosos);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 387);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Seguridad y Privacidad";
            // 
            // Procesosospechosos
            // 
            this.Procesosospechosos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Procesosospechosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.Procesosospechosos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Procesosospechosos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Procesosospechosos.FlatAppearance.BorderSize = 0;
            this.Procesosospechosos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Procesosospechosos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.Procesosospechosos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Procesosospechosos.ForeColor = System.Drawing.Color.White;
            this.Procesosospechosos.Location = new System.Drawing.Point(555, 73);
            this.Procesosospechosos.Name = "Procesosospechosos";
            this.Procesosospechosos.Size = new System.Drawing.Size(214, 30);
            this.Procesosospechosos.TabIndex = 14;
            this.Procesosospechosos.Text = "Ver procesos sospechosos";
            this.Procesosospechosos.UseVisualStyleBackColor = false;
            this.Procesosospechosos.Click += new System.EventHandler(this.Procesosospechosos_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DarkGray;
            this.label22.Location = new System.Drawing.Point(70, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 17);
            this.label22.TabIndex = 12;
            this.label22.Text = "tasklist /v | findstr /i \"unknown\"\r\n";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(303, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(194, 18);
            this.label23.TabIndex = 10;
            this.label23.Text = "Seguridad y Privacidad\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.ActualizarAll);
            this.tabPage3.Controls.Add(this.ActualizacionDisponible);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 387);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Actualizacion y detalles";
            // 
            // ActualizarAll
            // 
            this.ActualizarAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActualizarAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ActualizarAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ActualizarAll.FlatAppearance.BorderSize = 0;
            this.ActualizarAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ActualizarAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ActualizarAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarAll.ForeColor = System.Drawing.Color.White;
            this.ActualizarAll.Location = new System.Drawing.Point(542, 147);
            this.ActualizarAll.Name = "ActualizarAll";
            this.ActualizarAll.Size = new System.Drawing.Size(214, 30);
            this.ActualizarAll.TabIndex = 20;
            this.ActualizarAll.Text = "Actualizar todas las Aplicaciones \r\n";
            this.ActualizarAll.UseVisualStyleBackColor = false;
            this.ActualizarAll.Click += new System.EventHandler(this.ActualizarAll_Click);
            // 
            // ActualizacionDisponible
            // 
            this.ActualizacionDisponible.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActualizacionDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.ActualizacionDisponible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizacionDisponible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ActualizacionDisponible.FlatAppearance.BorderSize = 0;
            this.ActualizacionDisponible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ActualizacionDisponible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.ActualizacionDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizacionDisponible.ForeColor = System.Drawing.Color.White;
            this.ActualizacionDisponible.Location = new System.Drawing.Point(542, 95);
            this.ActualizacionDisponible.Name = "ActualizacionDisponible";
            this.ActualizacionDisponible.Size = new System.Drawing.Size(214, 30);
            this.ActualizacionDisponible.TabIndex = 19;
            this.ActualizacionDisponible.Text = "Actualizaciones Disponibles";
            this.ActualizacionDisponible.UseVisualStyleBackColor = false;
            this.ActualizacionDisponible.Click += new System.EventHandler(this.ActualizacionDisponible_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(57, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 34);
            this.label16.TabIndex = 18;
            this.label16.Text = "winget upgrade --all\r\n\r\n";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DarkGray;
            this.label20.Location = new System.Drawing.Point(57, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "winget upgrade";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(318, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 36);
            this.label21.TabIndex = 16;
            this.label21.Text = "Actualizacion y detalles\r\n\r\n";
            // 
            // DesactivarProcesos
            // 
            this.DesactivarProcesos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DesactivarProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.DesactivarProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesactivarProcesos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DesactivarProcesos.FlatAppearance.BorderSize = 0;
            this.DesactivarProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DesactivarProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.DesactivarProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesactivarProcesos.ForeColor = System.Drawing.Color.White;
            this.DesactivarProcesos.Location = new System.Drawing.Point(555, 136);
            this.DesactivarProcesos.Name = "DesactivarProcesos";
            this.DesactivarProcesos.Size = new System.Drawing.Size(214, 30);
            this.DesactivarProcesos.TabIndex = 16;
            this.DesactivarProcesos.Text = "Desactivar";
            this.DesactivarProcesos.UseVisualStyleBackColor = false;
            this.DesactivarProcesos.Click += new System.EventHandler(this.DesactivarProcesos_Click);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.DarkGray;
            this.label24.Location = new System.Drawing.Point(70, 143);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(287, 34);
            this.label24.TabIndex = 15;
            this.label24.Text = " Desactivar servicios innecesarios en PowerShell\r\n\r\n";
            // 
            // VerficarDisco
            // 
            this.VerficarDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerficarDisco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.VerficarDisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerficarDisco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VerficarDisco.FlatAppearance.BorderSize = 0;
            this.VerficarDisco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VerficarDisco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.VerficarDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerficarDisco.ForeColor = System.Drawing.Color.White;
            this.VerficarDisco.Location = new System.Drawing.Point(555, 194);
            this.VerficarDisco.Name = "VerficarDisco";
            this.VerficarDisco.Size = new System.Drawing.Size(214, 30);
            this.VerficarDisco.TabIndex = 18;
            this.VerficarDisco.Text = "Ver Estado de Disco";
            this.VerficarDisco.UseVisualStyleBackColor = false;
            this.VerficarDisco.Click += new System.EventHandler(this.VerficarDisco_Click);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.DarkGray;
            this.label25.Location = new System.Drawing.Point(70, 201);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(169, 34);
            this.label25.TabIndex = 17;
            this.label25.Text = "Verifica el estado del disco \r\n\r\n";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(609, 227);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 34);
            this.label26.TabIndex = 19;
            this.label26.Text = "Requiere Reinicio\r\n\r\n";
            // 
            // EstadoRAM
            // 
            this.EstadoRAM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EstadoRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.EstadoRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EstadoRAM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EstadoRAM.FlatAppearance.BorderSize = 0;
            this.EstadoRAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EstadoRAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.EstadoRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstadoRAM.ForeColor = System.Drawing.Color.White;
            this.EstadoRAM.Location = new System.Drawing.Point(544, 264);
            this.EstadoRAM.Name = "EstadoRAM";
            this.EstadoRAM.Size = new System.Drawing.Size(214, 30);
            this.EstadoRAM.TabIndex = 21;
            this.EstadoRAM.Text = "Estado De La Memoria";
            this.EstadoRAM.UseVisualStyleBackColor = false;
            this.EstadoRAM.Click += new System.EventHandler(this.EstadoRAM_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.DarkGray;
            this.label27.Location = new System.Drawing.Point(59, 271);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 17);
            this.label27.TabIndex = 20;
            this.label27.Text = "Ver Estado De la Memoria Ram\r\n";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(609, 297);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 34);
            this.label28.TabIndex = 22;
            this.label28.Text = "Requiere Reinicio\r\n\r\n";
            // 
            // SysFixTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(810, 447);
            this.Controls.Add(this.Organizador);
            this.Controls.Add(this.PanelHerramienta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SysFixTool";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysFixTool";
            this.Load += new System.EventHandler(this.SysFixTool_Load);
            this.PanelHerramienta.ResumeLayout(false);
            this.PanelHerramienta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalSys)).EndInit();
            this.Organizador.ResumeLayout(false);
            this.Reparacion.ResumeLayout(false);
            this.Reparacion.PerformLayout();
            this.ControlProcesos.ResumeLayout(false);
            this.ControlProcesos.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Limpieza.ResumeLayout(false);
            this.Limpieza.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Maximizar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Button Restaurar;
        private System.Windows.Forms.Panel PanelHerramienta;
        private System.Windows.Forms.PictureBox TerminalSys;
        private System.Windows.Forms.TabControl Organizador;
        private System.Windows.Forms.TabPage Reparacion;
        private System.Windows.Forms.TabPage ControlProcesos;
        private System.Windows.Forms.Label Diagnostico;
        private System.Windows.Forms.Button SFC;
        private System.Windows.Forms.Button Diagnosticar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReparacionIMG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReparacionCompleta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DetenerProcesos;
        private System.Windows.Forms.Button VerProcesos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SeleccionarArchivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button HistorialNav;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ConexActivas;
        private System.Windows.Forms.Button InfoRed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button LimpiarDNS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RepararRed;
        private System.Windows.Forms.TabPage Limpieza;
        private System.Windows.Forms.Button EleminarArchivosDeInstalacion;
        private System.Windows.Forms.Button ArchivosInecesarios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Procesosospechosos;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ActualizarAll;
        private System.Windows.Forms.Button ActualizacionDisponible;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button DesactivarProcesos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button VerficarDisco;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button EstadoRAM;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
    }
}