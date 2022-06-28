using PPAI_DSI_2022.Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PPAI_DSI.Formularios
{
    public partial class FormLogIn : Form
    {
        
        public FormLogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_usuario.ForeColor = Color.Gray;
            txt_contrasena.ForeColor = Color.Gray;
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return;
            }
            if (this.txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_contrasena.Focus();
                return;
            }
            if (txt_usuario.Text == "Juan" && txt_contrasena.Text == "123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Este usuario no esta registrado o ingreso una contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = " Usuario";
                txt_usuario.ForeColor = Color.Gray;
            }
        }

        private void txt_contrasena_Leave(object sender, EventArgs e)
        {
            if (txt_contrasena.Text == "")
            {
                txt_contrasena.PasswordChar = default;
                txt_contrasena.Text = " Contraseña";
                txt_contrasena.ForeColor = Color.Gray;
            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            txt_usuario.Text = null;
            txt_usuario.ForeColor = Color.Black;
        }

        private void txt_contrasena_Enter(object sender, EventArgs e)
        {
            txt_contrasena.Text = null;
            txt_contrasena.ForeColor = Color.Black;
            txt_contrasena.PasswordChar = '*';
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}