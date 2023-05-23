namespace SorM4.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbLook = new System.Windows.Forms.Label();
            this.lb_Mesagge = new System.Windows.Forms.Label();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLogin = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LoginMessage = new System.Windows.Forms.Timer(this.components);
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnSigin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLook
            // 
            this.lbLook.AutoSize = true;
            this.lbLook.BackColor = System.Drawing.Color.Transparent;
            this.lbLook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLook.Location = new System.Drawing.Point(864, 412);
            this.lbLook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLook.Name = "lbLook";
            this.lbLook.Size = new System.Drawing.Size(172, 25);
            this.lbLook.TabIndex = 37;
            this.lbLook.Text = "Echa un vistazo!";
            this.lbLook.Click += new System.EventHandler(this.lbLook_Click);
            // 
            // lb_Mesagge
            // 
            this.lb_Mesagge.BackColor = System.Drawing.Color.Transparent;
            this.lb_Mesagge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mesagge.Location = new System.Drawing.Point(23, 379);
            this.lb_Mesagge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Mesagge.Name = "lb_Mesagge";
            this.lb_Mesagge.Size = new System.Drawing.Size(505, 58);
            this.lb_Mesagge.TabIndex = 34;
            this.lb_Mesagge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(65, 464);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.OverrideDefault.Back.ColorAngle = 70F;
            this.btnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.OverrideDefault.Border.Rounding = 15;
            this.btnLogin.OverrideDefault.Border.Width = 1;
            this.btnLogin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Size = new System.Drawing.Size(160, 45);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Back.ColorAngle = 70F;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Border.ColorAngle = 70F;
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateCommon.Border.Rounding = 15;
            this.btnLogin.StateCommon.Border.Width = 1;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StatePressed.Back.ColorAngle = 200F;
            this.btnLogin.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnLogin.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Border.ColorAngle = 135F;
            this.btnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Border.Rounding = 15;
            this.btnLogin.StatePressed.Border.Width = 1;
            this.btnLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StateTracking.Back.ColorAngle = 200F;
            this.btnLogin.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateTracking.Border.Rounding = 15;
            this.btnLogin.StateTracking.Border.Width = 1;
            this.btnLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.TabIndex = 35;
            this.btnLogin.Values.Text = "Iniciar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbWelcome.Location = new System.Drawing.Point(16, 110);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(115, 25);
            this.lbWelcome.TabIndex = 30;
            this.lbWelcome.Text = "Bienvenido!";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(-1, 11);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(287, 69);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "Mentores";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(556, 47);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(508, 442);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 32;
            this.pictureBox.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 231);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(505, 36);
            this.txtUser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUser.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUser.StateCommon.Border.Rounding = 20;
            this.txtUser.StateCommon.Border.Width = 1;
            this.txtUser.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUser.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUser.TabIndex = 31;
            this.txtUser.Text = "Nombre de usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 314);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(505, 36);
            this.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPassword.StateCommon.Border.Rounding = 20;
            this.txtPassword.StateCommon.Border.Width = 1;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // kryptonLogin
            // 
            this.kryptonLogin.Common.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonLogin.Common.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonLogin.Common.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonLogin.Common.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonLogin.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonLogin.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonLogin.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // 
            // LoginMessage
            // 
            this.LoginMessage.Tick += new System.EventHandler(this.LoginMessage_Tick);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUser.Location = new System.Drawing.Point(31, 190);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(79, 25);
            this.lbUser.TabIndex = 38;
            this.lbUser.Text = "Usuario";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPass.Location = new System.Drawing.Point(31, 283);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(114, 25);
            this.lbPass.TabIndex = 39;
            this.lbPass.Text = "Contraseña";
            // 
            // btnSigin
            // 
            this.btnSigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigin.Location = new System.Drawing.Point(256, 464);
            this.btnSigin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSigin.Name = "btnSigin";
            this.btnSigin.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSigin.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSigin.OverrideDefault.Back.ColorAngle = 70F;
            this.btnSigin.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnSigin.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnSigin.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSigin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSigin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSigin.OverrideDefault.Border.Rounding = 15;
            this.btnSigin.OverrideDefault.Border.Width = 1;
            this.btnSigin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigin.Size = new System.Drawing.Size(160, 45);
            this.btnSigin.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSigin.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSigin.StateCommon.Back.ColorAngle = 70F;
            this.btnSigin.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StateCommon.Border.ColorAngle = 70F;
            this.btnSigin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSigin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSigin.StateCommon.Border.Rounding = 15;
            this.btnSigin.StateCommon.Border.Width = 1;
            this.btnSigin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigin.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSigin.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSigin.StatePressed.Back.ColorAngle = 200F;
            this.btnSigin.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSigin.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StatePressed.Border.ColorAngle = 135F;
            this.btnSigin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSigin.StatePressed.Border.Rounding = 15;
            this.btnSigin.StatePressed.Border.Width = 1;
            this.btnSigin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigin.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSigin.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSigin.StateTracking.Back.ColorAngle = 200F;
            this.btnSigin.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSigin.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSigin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSigin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSigin.StateTracking.Border.Rounding = 15;
            this.btnSigin.StateTracking.Border.Width = 1;
            this.btnSigin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSigin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSigin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigin.TabIndex = 41;
            this.btnSigin.Values.Text = "Registrarse";
            this.btnSigin.Click += new System.EventHandler(this.btnSigin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(944, 493);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnExit.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnExit.OverrideDefault.Back.ColorAngle = 70F;
            this.btnExit.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnExit.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnExit.OverrideDefault.Border.ColorAngle = 45F;
            this.btnExit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExit.OverrideDefault.Border.Rounding = 15;
            this.btnExit.OverrideDefault.Border.Width = 1;
            this.btnExit.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Size = new System.Drawing.Size(116, 45);
            this.btnExit.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnExit.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnExit.StateCommon.Back.ColorAngle = 70F;
            this.btnExit.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnExit.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnExit.StateCommon.Border.ColorAngle = 70F;
            this.btnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExit.StateCommon.Border.Rounding = 15;
            this.btnExit.StateCommon.Border.Width = 1;
            this.btnExit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnExit.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnExit.StatePressed.Back.ColorAngle = 200F;
            this.btnExit.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnExit.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnExit.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnExit.StatePressed.Border.ColorAngle = 135F;
            this.btnExit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StatePressed.Border.Rounding = 15;
            this.btnExit.StatePressed.Border.Width = 1;
            this.btnExit.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExit.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExit.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnExit.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnExit.StateTracking.Back.ColorAngle = 200F;
            this.btnExit.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnExit.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnExit.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnExit.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExit.StateTracking.Border.Rounding = 15;
            this.btnExit.StateTracking.Border.Width = 1;
            this.btnExit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnExit.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnExit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TabIndex = 42;
            this.btnExit.Values.Text = "Salir";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSigin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbLook);
            this.Controls.Add(this.lb_Mesagge);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Palette = this.kryptonLogin;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLook;
        private System.Windows.Forms.Label lb_Mesagge;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonLogin;
        private System.Windows.Forms.Timer LoginMessage;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSigin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
    }
}