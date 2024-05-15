namespace TrainingCoop
{
    partial class MainMenus
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
            menuStrip1 = new MenuStrip();
            เพมขอมลToolStripMenuItem = new ToolStripMenuItem();
            MenuItem = new ToolStripMenuItem();
            MenuEmployee = new ToolStripMenuItem();
            MenuCustomer = new ToolStripMenuItem();
            Menudepartment = new ToolStripMenuItem();
            MenuItemType = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { เพมขอมลToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // เพมขอมลToolStripMenuItem
            // 
            เพมขอมลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItem, MenuEmployee, MenuCustomer, Menudepartment, MenuItemType });
            เพมขอมลToolStripMenuItem.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            เพมขอมลToolStripMenuItem.Name = "เพมขอมลToolStripMenuItem";
            เพมขอมลToolStripMenuItem.Size = new Size(82, 26);
            เพมขอมลToolStripMenuItem.Text = "เพิ่มข้อมูล";
            // 
            // MenuItem
            // 
            MenuItem.Name = "MenuItem";
            MenuItem.Size = new Size(195, 26);
            MenuItem.Text = "ข้อมูลสินค้า";
            MenuItem.Click += MenuItem_Click;
            // 
            // MenuEmployee
            // 
            MenuEmployee.Name = "MenuEmployee";
            MenuEmployee.Size = new Size(195, 26);
            MenuEmployee.Text = "ข้อมูลพนักงาน";
            MenuEmployee.Click += MenuEmployee_Click;
            // 
            // MenuCustomer
            // 
            MenuCustomer.Name = "MenuCustomer";
            MenuCustomer.Size = new Size(195, 26);
            MenuCustomer.Text = "ข้อมูลลูกค้า";
            MenuCustomer.Click += MenuCustomer_Click;
            // 
            // Menudepartment
            // 
            Menudepartment.Name = "Menudepartment";
            Menudepartment.Size = new Size(195, 26);
            Menudepartment.Text = "ข้อมูลแผนก";
            Menudepartment.Click += Menudepartment_Click;
            // 
            // MenuItemType
            // 
            MenuItemType.Name = "MenuItemType";
            MenuItemType.Size = new Size(195, 26);
            MenuItemType.Text = "ข้อมูลประเภทสินค้า";
            MenuItemType.Click += MenuItemType_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(50, 26);
            aboutToolStripMenuItem.Text = "about";
            // 
            // MainMenus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenus";
            Text = "MainMenus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem เพมขอมลToolStripMenuItem;
        private ToolStripMenuItem MenuItem;
        private ToolStripMenuItem MenuEmployee;
        private ToolStripMenuItem MenuCustomer;
        private ToolStripMenuItem Menudepartment;
        private ToolStripMenuItem MenuItemType;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}