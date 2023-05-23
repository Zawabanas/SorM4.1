using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
=======
using System.Drawing.Drawing2D;
>>>>>>> Agregar archivos de proyecto.
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Npgsql;
using SorM4.Class;

namespace SorM4.Forms
{
    public partial class Principal : KryptonForm
    {
        public Principal()
        {
            InitializeComponent();

            lb_Usuario.Text = CurrentUser.Name;
            lb_rol.Text = CurrentUser.Role;
            tbNamePrincipal.Text = CurrentUser.Name;
            tbLastNamePrincipal.Text = CurrentUser.LastName;
            tbUserNamePrincipal.Text = CurrentUser.UserName;
            tbEmailPrincipal.Text = CurrentUser.Email;
            tbPasswordPrincipal.Text = CurrentUser.Password;
            RedondearBordesFlowLayoutPanel(dayContainer, 10);
<<<<<<< HEAD
            CargarMentoriasEnDataGridView();
        }

        private void CargarMentoriasEnDataGridView()
        {
            connectionBD conexion = new connectionBD();
            if (conexion.Conect())
            {
                string pgSql = "SELECT m.id_mentoria, ma.nombre AS nombre_materia, u.nombre AS nombre_mentor " +
                    "FROM mentorias m INNER JOIN materias ma ON m.id_materia = ma.id_materia " +
                    "INNER JOIN usuarios u ON m.id_mentor = u.id_user";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataMentorias.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
=======

        }



        private void MostrarMateriasEnDataGridView()
        {
            connectionBD conexion = new connectionBD();

            if (conexion.Conect())
            {
                try
                {
                    string query = "SELECT m.nombre AS Materia, u.nombre AS Mentor " +
                                   "FROM Materias m " +
                                   "INNER JOIN Usuarios u ON m.id_mentor = u.id_user";

                    using (var cmd = new NpgsqlCommand(query, conexion.conn))
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        MateriasDisponibles.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al mostrar las materias: " + ex.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }


        private void MostrarInscripcionesUsuario()
        {
            connectionBD conexion = new connectionBD();

            if (conexion.Conect())
            {
                try
                {
                    int idUsuario = CurrentUser.Id; // Obtener el ID del usuario actualmente logueado

                    string query = "SELECT i.id_inscripcion, u.nombre AS nombre_usuario, i.id_mentoria " +
                                   "FROM inscripciones i " +
                                   "INNER JOIN usuarios u ON i.id_usuario = u.id_user " +
                                   "WHERE i.id_usuario = @idUsuario";

                    using (var cmd = new NpgsqlCommand(query, conexion.conn))
                    {
                        cmd.Parameters.AddWithValue("idUsuario", idUsuario);

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        materiasInscrito.DataSource = dataTable; // Asignar los datos al DataGridView
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al mostrar las inscripciones: " + ex.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
>>>>>>> Agregar archivos de proyecto.
            }
        }


<<<<<<< HEAD
=======






>>>>>>> Agregar archivos de proyecto.
        //configuracion de perfil
        private void btnSave_Click(object sender, EventArgs e)
        {
            
                // Obtener los nuevos valores de los campos de texto
                string newName = tbNamePrincipal.Text;
                string newLastName = tbLastNamePrincipal.Text;
                string newUserName = tbUserNamePrincipal.Text;
                string newEmail = tbEmailPrincipal.Text;
                string newPassword = tbPasswordPrincipal.Text;

                // Actualizar los valores en la base de datos
                connectionBD conexion = new connectionBD();

                if (conexion.Conect())
                {
                    var PgSQL = "UPDATE usuarios SET nombre = @nombre, apellido = @apellido, nombre_usuario = @nombre_usuario, email = @email, contraseña = @contraseña WHERE id_user = @id_user";

                    using (var cmd = new NpgsqlCommand(PgSQL, conexion.conn))
                    {
                        cmd.Parameters.AddWithValue("nombre", newName);
                        cmd.Parameters.AddWithValue("apellido", newLastName);
                        cmd.Parameters.AddWithValue("nombre_usuario", newUserName);
                        cmd.Parameters.AddWithValue("email", newEmail);
                        cmd.Parameters.AddWithValue("contraseña", newPassword);
                        cmd.Parameters.AddWithValue("id_user", CurrentUser.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Actualización exitosa
                            MessageBox.Show("Los datos del usuario han sido actualizados correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar los valores en el objeto CurrentUser
                            CurrentUser.Name = newName;
                            CurrentUser.LastName = newLastName;
                            CurrentUser.UserName = newUserName;
                            CurrentUser.Email = newEmail;
                            CurrentUser.Password = newPassword;
                        }
                        else
                        {
                            // No se pudo actualizar el usuario
                            MessageBox.Show("No se pudo actualizar los datos del usuario.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conexion.Desconectar();
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿Estás seguro/a de que deseas eliminar tu cuenta de usuario? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connectionBD conexion = new connectionBD();

                    if (conexion.Conect())
                    {
                        var PgSQL = "DELETE FROM usuarios WHERE id_user = @id_user";

                        using (var cmd = new NpgsqlCommand(PgSQL, conexion.conn))
                        {
                            cmd.Parameters.AddWithValue("id_user", CurrentUser.Id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Eliminación exitosa
                                MessageBox.Show("Tu cuenta de usuario ha sido eliminada correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Cerrar la aplicación o redirigir a la pantalla de inicio de sesión
                                Application.Exit();
                            }
                            else
                            {
                                // No se pudo eliminar el usuario
                                MessageBox.Show("No se pudo eliminar tu cuenta de usuario.", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        conexion.Desconectar();
                    }
                }
            }

        //vista hacia mensajes
        private void btnMessages_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.Show();
        }


        //Botones de pestaña
        private void CambiarPestaña(int indicePestaña)
        {
            tabControlPrincipal.SelectedIndex = indicePestaña;

            // Habilitar todos los botones de navegación
            btn_inicio.Enabled = true;
            btn_seleccionM.Enabled = true;
            btn_Actividades.Enabled = true;
            btn_ayuda.Enabled = true;
            btn_configuracion.Enabled = true;

            // Deshabilitar el botón correspondiente a la pestaña actual
            switch (indicePestaña)
            {
                case 0:
                    btn_inicio.Enabled = false;
                    break;
                case 1:
                    btn_seleccionM.Enabled = false;
                    break;
                case 2:
                    btn_Actividades.Enabled = false;
                    break;
                case 3:
                    btn_ayuda.Enabled = false;
                    break;
                case 4:
                    btn_configuracion.Enabled = false;
                    break;
            }
        }


        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_seleccionM_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_Actividades_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Inicializar month y year con el primer día del mes anterior
            DateTime now = DateTime.Now;
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1);

            // Avanzar un día para llegar al primer día del mes actual
            DateTime firstDayOfMonth = firstDayOfPreviousMonth.AddDays(1);
            month = firstDayOfMonth.Month;
            year = firstDayOfMonth.Year;

            displayDays();
<<<<<<< HEAD
=======
            MostrarMateriasEnDataGridView();
            MostrarInscripcionesUsuario();


>>>>>>> Agregar archivos de proyecto.
        }


        //Calendario
        int month, year;
        private void displayDays()
        {
            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            // Ajustar el valor de daysoftheweek para que sea cero en lugar de uno cuando el día de la semana sea domingo
            int daysoftheweek = (int)startofthemonth.DayOfWeek + 1;
            if (daysoftheweek == 0) daysoftheweek = 7;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }

            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysoftheweek = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }

            string monthdname = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lbDate.Text = monthdname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysoftheweek = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

<<<<<<< HEAD
        private void btnInscription_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la mentoria seleccionada en el DataGridView
            if (dataMentorias.SelectedCells.Count > 0)
            {
                int rowIndex = dataMentorias.SelectedCells[0].RowIndex;
                int idMentoria = Convert.ToInt32(dataMentorias.Rows[rowIndex].Cells[0].Value);

                // Realizar la inscripción en la tabla "inscripciones"
                connectionBD conexion = new connectionBD();
                if (conexion.Conect())
                {
                    string consultaSql = "INSERT INTO inscripciones (id_usuario, id_mentoria) VALUES (@idUsuario, @idMentoria)";

                    using (NpgsqlCommand command = new NpgsqlCommand(consultaSql, conexion.conn))
                    {
                        // Obtener el ID del usuario que desea inscribirse (puedes reemplazar esto con tu lógica de obtención de ID de usuario)
                        int idUsuario = ObtenerIdUsuario();

                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        command.Parameters.AddWithValue("@idMentoria", idMentoria);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inscripción exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar la inscripción");
                        }
                    }

                    conexion.Desconectar();
                }
                else
                {
                    Console.WriteLine("Error al conectar a la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una mentoria en el DataGridView");
            }
        }

        private void btnDeleteInscription_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la mentoria seleccionada en el DataGridView
            if (dataMentorias.SelectedCells.Count > 0)
            {
                int rowIndex = dataMentorias.SelectedCells[0].RowIndex;
                int idMentoria = Convert.ToInt32(dataMentorias.Rows[rowIndex].Cells[0].Value);

                // Obtener el ID del usuario actualmente logueado
                int idUsuarioActual = CurrentUser.Id;

                // Verificar si el usuario tiene permiso para eliminar la inscripción
                if (VerificarPermisoEliminarInscripcion(idMentoria, idUsuarioActual))
                {
                    // Realizar la eliminación de la inscripción en la tabla "inscripciones"
                    connectionBD conexion = new connectionBD();
                    if (conexion.Conect())
                    {
                        string consultaSql = "DELETE FROM inscripciones WHERE id_mentoria = @idMentoria AND id_usuario = @idUsuario";

                        using (NpgsqlCommand command = new NpgsqlCommand(consultaSql, conexion.conn))
                        {
                            command.Parameters.AddWithValue("@idMentoria", idMentoria);
                            command.Parameters.AddWithValue("@idUsuario", idUsuarioActual);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Inscripción eliminada correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la inscripción");
                            }
                        }

                        conexion.Desconectar();
                    }
                    else
                    {
                        Console.WriteLine("Error al conectar a la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("No tienes permiso para eliminar esta inscripción");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una mentoria en el DataGridView");
            }
        }

        private bool VerificarPermisoEliminarInscripcion(int idMentoria, int idUsuario)
        {
            // Realiza la lógica necesaria para verificar si el usuario tiene permiso para eliminar la inscripción
            // Puedes realizar consultas a la base de datos, comparar IDs, etc.
            // En este ejemplo, se asume que el usuario solo puede eliminar sus propias inscripciones
            // Puedes adaptar esta lógica según tus requerimientos y estructura de la base de datos

            // Obtener la conexión a la base de datos
            connectionBD conexion = new connectionBD();
            if (conexion.Conect())
            {
                string consultaSql = "SELECT COUNT(*) FROM inscripciones WHERE id_mentoria = @idMentoria AND id_usuario = @idUsuario";

                using (NpgsqlCommand command = new NpgsqlCommand(consultaSql, conexion.conn))
                {
                    command.Parameters.AddWithValue("@idMentoria", idMentoria);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }

            return false;
        }
        private int ObtenerIdUsuario()
        {
            return CurrentUser.Id;
        }



=======
        private void btnIncription_Click(object sender, EventArgs e)
        {
            connectionBD conexion = new connectionBD();

            if (conexion.Conect())
            {
                try
                {
                    int idUsuario = CurrentUser.Id; // Obtener el ID del usuario actualmente logueado
                    int idMentoria = 1; // Obtener el ID de la mentoría deseada, puedes reemplazarlo por el valor correspondiente

                    string query = "INSERT INTO inscripciones (id_usuario, id_mentoria) VALUES (@idUsuario, @idMentoria)";

                    using (var cmd = new NpgsqlCommand(query, conexion.conn))
                    {
                        cmd.Parameters.AddWithValue("idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("idMentoria", idMentoria);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Inscripción realizada con éxito.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al realizar la inscripción: " + ex.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            connectionBD conexion = new connectionBD();

            if (conexion.Conect())
            {
                try
                {
                    int idUsuario = CurrentUser.Id; // Obtener el ID del usuario actualmente logueado
                    int idInscripcion = 1; // Obtener el ID de la inscripción que se desea eliminar, puedes reemplazarlo por el valor correspondiente

                    string query = "DELETE FROM inscripciones WHERE id_usuario = @idUsuario AND id_inscripcion = @idInscripcion";

                    using (var cmd = new NpgsqlCommand(query, conexion.conn))
                    {
                        cmd.Parameters.AddWithValue("idUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("idInscripcion", idInscripcion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inscripción eliminada con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la inscripción para eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar la inscripción: " + ex.Message);
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
        }

>>>>>>> Agregar archivos de proyecto.
        private void RedondearBordesFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, int radio)
        {
            flowLayoutPanel.Paint += (sender, e) =>
            {
                System.Drawing.Drawing2D.GraphicsPath forma = new System.Drawing.Drawing2D.GraphicsPath();
                forma.AddArc(0, 0, radio, radio, 180, 90);
                forma.AddLine(radio, 0, flowLayoutPanel.Width - radio, 0);
                forma.AddArc(flowLayoutPanel.Width - radio, 0, radio, radio, -90, 90);
                forma.AddLine(flowLayoutPanel.Width, radio, flowLayoutPanel.Width, flowLayoutPanel.Height - radio);
                forma.AddArc(flowLayoutPanel.Width - radio, flowLayoutPanel.Height - radio, radio, radio, 0, 90);
                forma.AddLine(flowLayoutPanel.Width - radio, flowLayoutPanel.Height, radio, flowLayoutPanel.Height);
                forma.AddArc(0, flowLayoutPanel.Height - radio, radio, radio, 90, 90);

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                flowLayoutPanel.Region = new System.Drawing.Region(forma);
            };
        }

    }
<<<<<<< HEAD
=======

>>>>>>> Agregar archivos de proyecto.
}
