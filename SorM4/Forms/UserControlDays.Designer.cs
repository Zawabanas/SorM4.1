namespace SorM4.Forms
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonLogin = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lbDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // lbDays
            // 
            this.lbDays.BackColor = System.Drawing.Color.Transparent;
            this.lbDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(0, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(36, 36);
            this.lbDays.TabIndex = 1;
            this.lbDays.Text = "00";
            this.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDays.MouseEnter += new System.EventHandler(this.lbDays_MouseEnter);
            this.lbDays.MouseLeave += new System.EventHandler(this.lbDays_MouseLeave);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(36, 36);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonLogin;
        private System.Windows.Forms.Label lbDays;
    }
}
