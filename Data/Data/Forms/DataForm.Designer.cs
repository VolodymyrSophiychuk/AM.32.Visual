using System.Runtime.InteropServices;

namespace Data.Forms
{
    partial class DataForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializePanelsField()
        {
            panels = new List<Panel>();

            panels.Add(SidebarJsonSubmenu);
            panels.Add(SidebarXmlSubmenu);
            panels.Add(SidebarDatabaseSubmenu);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sidebar = new System.Windows.Forms.Panel();
            this.SidebarDatabaseSubmenu = new System.Windows.Forms.Panel();
            this.SidebarDatabaseSave = new System.Windows.Forms.Button();
            this.SidebarDatabaseLoad = new System.Windows.Forms.Button();
            this.SidebarDatabaseMenu = new System.Windows.Forms.Button();
            this.SidebarXmlSubmenu = new System.Windows.Forms.Panel();
            this.SidebarXmlSampleTwo = new System.Windows.Forms.Button();
            this.SidebarXmlSampleOne = new System.Windows.Forms.Button();
            this.SidebarXmlSave = new System.Windows.Forms.Button();
            this.SidebarXmlLoad = new System.Windows.Forms.Button();
            this.SidebarXmlMenu = new System.Windows.Forms.Button();
            this.SidebarJsonSubmenu = new System.Windows.Forms.Panel();
            this.SidebarJsonSample = new System.Windows.Forms.Button();
            this.SidebarJsonSave = new System.Windows.Forms.Button();
            this.SidebarJsonLoad = new System.Windows.Forms.Button();
            this.SidebarJsonMenu = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Sidebar.SuspendLayout();
            this.SidebarDatabaseSubmenu.SuspendLayout();
            this.SidebarXmlSubmenu.SuspendLayout();
            this.SidebarJsonSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Sidebar.Controls.Add(this.SidebarDatabaseSubmenu);
            this.Sidebar.Controls.Add(this.SidebarDatabaseMenu);
            this.Sidebar.Controls.Add(this.SidebarXmlSubmenu);
            this.Sidebar.Controls.Add(this.SidebarXmlMenu);
            this.Sidebar.Controls.Add(this.SidebarJsonSubmenu);
            this.Sidebar.Controls.Add(this.SidebarJsonMenu);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(400, 1016);
            this.Sidebar.TabIndex = 0;
            // 
            // SidebarDatabaseSubmenu
            // 
            this.SidebarDatabaseSubmenu.Controls.Add(this.SidebarDatabaseSave);
            this.SidebarDatabaseSubmenu.Controls.Add(this.SidebarDatabaseLoad);
            this.SidebarDatabaseSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarDatabaseSubmenu.Location = new System.Drawing.Point(0, 1000);
            this.SidebarDatabaseSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarDatabaseSubmenu.Name = "SidebarDatabaseSubmenu";
            this.SidebarDatabaseSubmenu.Size = new System.Drawing.Size(370, 200);
            this.SidebarDatabaseSubmenu.TabIndex = 5;
            this.SidebarDatabaseSubmenu.Visible = false;
            // 
            // SidebarDatabaseSave
            // 
            this.SidebarDatabaseSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarDatabaseSave.FlatAppearance.BorderSize = 0;
            this.SidebarDatabaseSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarDatabaseSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarDatabaseSave.Location = new System.Drawing.Point(0, 100);
            this.SidebarDatabaseSave.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarDatabaseSave.Name = "SidebarDatabaseSave";
            this.SidebarDatabaseSave.Size = new System.Drawing.Size(370, 100);
            this.SidebarDatabaseSave.TabIndex = 3;
            this.SidebarDatabaseSave.Text = "Save";
            this.SidebarDatabaseSave.UseVisualStyleBackColor = true;
            this.SidebarDatabaseSave.Click += new System.EventHandler(this.SidebarSubmenuSaveDBSelected);
            // 
            // SidebarDatabaseLoad
            // 
            this.SidebarDatabaseLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarDatabaseLoad.FlatAppearance.BorderSize = 0;
            this.SidebarDatabaseLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarDatabaseLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarDatabaseLoad.Location = new System.Drawing.Point(0, 0);
            this.SidebarDatabaseLoad.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarDatabaseLoad.Name = "SidebarDatabaseLoad";
            this.SidebarDatabaseLoad.Size = new System.Drawing.Size(370, 100);
            this.SidebarDatabaseLoad.TabIndex = 2;
            this.SidebarDatabaseLoad.Text = "Load";
            this.SidebarDatabaseLoad.UseVisualStyleBackColor = true;
            this.SidebarDatabaseLoad.Click += new System.EventHandler(this.SidebarSubmenuLoadDBSelected);
            // 
            // SidebarDatabaseMenu
            // 
            this.SidebarDatabaseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SidebarDatabaseMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarDatabaseMenu.FlatAppearance.BorderSize = 0;
            this.SidebarDatabaseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarDatabaseMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarDatabaseMenu.ForeColor = System.Drawing.Color.White;
            this.SidebarDatabaseMenu.Location = new System.Drawing.Point(0, 900);
            this.SidebarDatabaseMenu.Name = "SidebarDatabaseMenu";
            this.SidebarDatabaseMenu.Size = new System.Drawing.Size(370, 100);
            this.SidebarDatabaseMenu.TabIndex = 4;
            this.SidebarDatabaseMenu.Text = "Database";
            this.SidebarDatabaseMenu.UseVisualStyleBackColor = false;
            this.SidebarDatabaseMenu.Click += new System.EventHandler(this.SidebarMenuDatabaseItemSelected);
            // 
            // SidebarXmlSubmenu
            // 
            this.SidebarXmlSubmenu.Controls.Add(this.SidebarXmlSampleTwo);
            this.SidebarXmlSubmenu.Controls.Add(this.SidebarXmlSampleOne);
            this.SidebarXmlSubmenu.Controls.Add(this.SidebarXmlSave);
            this.SidebarXmlSubmenu.Controls.Add(this.SidebarXmlLoad);
            this.SidebarXmlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlSubmenu.Location = new System.Drawing.Point(0, 500);
            this.SidebarXmlSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarXmlSubmenu.Name = "SidebarXmlSubmenu";
            this.SidebarXmlSubmenu.Size = new System.Drawing.Size(370, 400);
            this.SidebarXmlSubmenu.TabIndex = 3;
            this.SidebarXmlSubmenu.Visible = false;
            // 
            // SidebarXmlSampleTwo
            // 
            this.SidebarXmlSampleTwo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlSampleTwo.FlatAppearance.BorderSize = 0;
            this.SidebarXmlSampleTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarXmlSampleTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarXmlSampleTwo.Location = new System.Drawing.Point(0, 300);
            this.SidebarXmlSampleTwo.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarXmlSampleTwo.Name = "SidebarXmlSampleTwo";
            this.SidebarXmlSampleTwo.Size = new System.Drawing.Size(370, 100);
            this.SidebarXmlSampleTwo.TabIndex = 3;
            this.SidebarXmlSampleTwo.Text = "Sample Two";
            this.SidebarXmlSampleTwo.UseVisualStyleBackColor = true;
            this.SidebarXmlSampleTwo.Click += new System.EventHandler(this.SidebarXlSampleTwoClick);
            // 
            // SidebarXmlSampleOne
            // 
            this.SidebarXmlSampleOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlSampleOne.FlatAppearance.BorderSize = 0;
            this.SidebarXmlSampleOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarXmlSampleOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarXmlSampleOne.Location = new System.Drawing.Point(0, 200);
            this.SidebarXmlSampleOne.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarXmlSampleOne.Name = "SidebarXmlSampleOne";
            this.SidebarXmlSampleOne.Size = new System.Drawing.Size(370, 100);
            this.SidebarXmlSampleOne.TabIndex = 2;
            this.SidebarXmlSampleOne.Text = "Sample One";
            this.SidebarXmlSampleOne.UseVisualStyleBackColor = true;
            this.SidebarXmlSampleOne.Click += new System.EventHandler(this.SidebarXmlSampleOneClick);
            // 
            // SidebarXmlSave
            // 
            this.SidebarXmlSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlSave.FlatAppearance.BorderSize = 0;
            this.SidebarXmlSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarXmlSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarXmlSave.Location = new System.Drawing.Point(0, 100);
            this.SidebarXmlSave.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarXmlSave.Name = "SidebarXmlSave";
            this.SidebarXmlSave.Size = new System.Drawing.Size(370, 100);
            this.SidebarXmlSave.TabIndex = 1;
            this.SidebarXmlSave.Text = "Save";
            this.SidebarXmlSave.UseVisualStyleBackColor = true;
            this.SidebarXmlSave.Click += new System.EventHandler(this.SidebarSubmenuSaveItemSelected);
            // 
            // SidebarXmlLoad
            // 
            this.SidebarXmlLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlLoad.FlatAppearance.BorderSize = 0;
            this.SidebarXmlLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarXmlLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarXmlLoad.Location = new System.Drawing.Point(0, 0);
            this.SidebarXmlLoad.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarXmlLoad.Name = "SidebarXmlLoad";
            this.SidebarXmlLoad.Size = new System.Drawing.Size(370, 100);
            this.SidebarXmlLoad.TabIndex = 0;
            this.SidebarXmlLoad.Text = "Load";
            this.SidebarXmlLoad.UseVisualStyleBackColor = true;
            this.SidebarXmlLoad.Click += new System.EventHandler(this.SidebarSubmenuLoadItemSelected);
            // 
            // SidebarXmlMenu
            // 
            this.SidebarXmlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SidebarXmlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarXmlMenu.FlatAppearance.BorderSize = 0;
            this.SidebarXmlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarXmlMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarXmlMenu.ForeColor = System.Drawing.Color.White;
            this.SidebarXmlMenu.Location = new System.Drawing.Point(0, 400);
            this.SidebarXmlMenu.Name = "SidebarXmlMenu";
            this.SidebarXmlMenu.Size = new System.Drawing.Size(370, 100);
            this.SidebarXmlMenu.TabIndex = 2;
            this.SidebarXmlMenu.Text = "Xml";
            this.SidebarXmlMenu.UseVisualStyleBackColor = false;
            this.SidebarXmlMenu.Click += new System.EventHandler(this.SidebarMenuXmlItemSelected);
            // 
            // SidebarJsonSubmenu
            // 
            this.SidebarJsonSubmenu.Controls.Add(this.SidebarJsonSample);
            this.SidebarJsonSubmenu.Controls.Add(this.SidebarJsonSave);
            this.SidebarJsonSubmenu.Controls.Add(this.SidebarJsonLoad);
            this.SidebarJsonSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarJsonSubmenu.Location = new System.Drawing.Point(0, 100);
            this.SidebarJsonSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarJsonSubmenu.Name = "SidebarJsonSubmenu";
            this.SidebarJsonSubmenu.Size = new System.Drawing.Size(370, 300);
            this.SidebarJsonSubmenu.TabIndex = 1;
            this.SidebarJsonSubmenu.Visible = false;
            // 
            // SidebarJsonSample
            // 
            this.SidebarJsonSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarJsonSample.FlatAppearance.BorderSize = 0;
            this.SidebarJsonSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarJsonSample.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarJsonSample.Location = new System.Drawing.Point(0, 200);
            this.SidebarJsonSample.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarJsonSample.Name = "SidebarJsonSample";
            this.SidebarJsonSample.Size = new System.Drawing.Size(370, 100);
            this.SidebarJsonSample.TabIndex = 2;
            this.SidebarJsonSample.Text = "Sample";
            this.SidebarJsonSample.UseVisualStyleBackColor = true;
            this.SidebarJsonSample.Click += new System.EventHandler(this.SidebarJsonSampleClick);
            // 
            // SidebarJsonSave
            // 
            this.SidebarJsonSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarJsonSave.FlatAppearance.BorderSize = 0;
            this.SidebarJsonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarJsonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarJsonSave.Location = new System.Drawing.Point(0, 100);
            this.SidebarJsonSave.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarJsonSave.Name = "SidebarJsonSave";
            this.SidebarJsonSave.Size = new System.Drawing.Size(370, 100);
            this.SidebarJsonSave.TabIndex = 1;
            this.SidebarJsonSave.Text = "Save";
            this.SidebarJsonSave.UseVisualStyleBackColor = true;
            this.SidebarJsonSave.Click += new System.EventHandler(this.SidebarSubmenuSaveItemSelected);
            // 
            // SidebarJsonLoad
            // 
            this.SidebarJsonLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarJsonLoad.FlatAppearance.BorderSize = 0;
            this.SidebarJsonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarJsonLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarJsonLoad.Location = new System.Drawing.Point(0, 0);
            this.SidebarJsonLoad.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarJsonLoad.Name = "SidebarJsonLoad";
            this.SidebarJsonLoad.Size = new System.Drawing.Size(370, 100);
            this.SidebarJsonLoad.TabIndex = 0;
            this.SidebarJsonLoad.Text = "Load";
            this.SidebarJsonLoad.UseVisualStyleBackColor = true;
            this.SidebarJsonLoad.Click += new System.EventHandler(this.SidebarSubmenuLoadItemSelected);
            // 
            // SidebarJsonMenu
            // 
            this.SidebarJsonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SidebarJsonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarJsonMenu.FlatAppearance.BorderSize = 0;
            this.SidebarJsonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarJsonMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SidebarJsonMenu.ForeColor = System.Drawing.Color.White;
            this.SidebarJsonMenu.Location = new System.Drawing.Point(0, 0);
            this.SidebarJsonMenu.Name = "SidebarJsonMenu";
            this.SidebarJsonMenu.Size = new System.Drawing.Size(370, 100);
            this.SidebarJsonMenu.TabIndex = 0;
            this.SidebarJsonMenu.Text = "Json";
            this.SidebarJsonMenu.UseVisualStyleBackColor = false;
            this.SidebarJsonMenu.Click += new System.EventHandler(this.SidebarMenuJsonItemSelected);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(400, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1496, 1016);
            this.Main.TabIndex = 1;
            // 
            // LoadFileDialog
            // 
            this.LoadFileDialog.FileName = "data";
            this.LoadFileDialog.InitialDirectory = "D:\\WorkFolder\\VS\\VP\\Data\\Data\\bin\\Debug\\net6.0-windows";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "data";
            this.SaveFileDialog.InitialDirectory = "D:\\WorkFolder\\VS\\VP\\Data\\Data\\bin\\Debug\\net6.0-windows";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Sidebar);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "DataForm";
            this.Text = "Data";
            this.Sidebar.ResumeLayout(false);
            this.SidebarDatabaseSubmenu.ResumeLayout(false);
            this.SidebarXmlSubmenu.ResumeLayout(false);
            this.SidebarJsonSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region GridForm

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public void InitializeForm(bool preDelete = false)
        {
            CurrentForm?.Close();
            CurrentForm = new GridForm(preDelete)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            CurrentForm.Show();

            SetParent(CurrentForm.Handle, Main.Handle);

            Main.Controls.Add(CurrentForm);
        }

        #endregion

        #region Sidebar

        private void SidebarSubmenuChangeVisibility(object sender)
        {
            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }
            (sender as Panel).Visible = true;
        }

        #endregion

        private GridForm CurrentForm;
        private List<Panel> panels;

        private Panel Sidebar;
        private Button SidebarJsonMenu;
        private Panel Main;
        private Button SidebarDatabaseMenu;
        private Panel SidebarXmlSubmenu;
        private Button SidebarXmlSave;
        private Button SidebarXmlLoad;
        private Button SidebarXmlMenu;
        private Panel SidebarJsonSubmenu;
        private Button SidebarJsonSave;
        private Button SidebarJsonLoad;
        private OpenFileDialog LoadFileDialog;
        private SaveFileDialog SaveFileDialog;
        private Panel SidebarDatabaseSubmenu;
        private Button SidebarDatabaseSave;
        private Button SidebarDatabaseLoad;
        private Button SidebarJsonSample;
        private Button SidebarXmlSampleTwo;
        private Button SidebarXmlSampleOne;
    }
}