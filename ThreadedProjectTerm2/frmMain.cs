using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectTerm2
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Main form that is the parent MDI form to manage the application:
        ///             
        ///     - stores application level variables to manage user credentials
        ///       and child form tranisitions
        ///     - provides code for menu buttons 
        ///     - loads the home page (frmHome) 
        ///     - supports logic to ensure that only one instance of each type of form 
        ///       is loaded at a given time (i.e. to avoid multiple versions of the same 
        ///       form)
        ///     
        /// Author: Stuart Peters (parent/child form management)
        ///         
        /// </summary>
        
        //form level variables that are set when a child form of a given type opens  
        //these objects are used to test if a child form is already open when a menu item is clicked
        //if child form is open (i.e. activeFrm[Name] != null), then application shows that form
        //if child form is not already open, a new instance of the form is created and the activeFrm[type]
        //is set to that form instance
        //this avoids opening duplicate versions of each form when menu buttons are clicked 
        
        public frmHome activeFrmHome = null;             //active instance of frmHome
        public frmPackages activeFrmPackages = null;    //active instance of frmPackages
        public frmProducts activeFrmProducts = null;    //active instance of frmProducts
        public frmSuppliers activeFrmSuppliers = null;  //active instance of frmSuppliers
        public frmAgents activeFrmAgents= null;         //active instance of frmAgents


        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            int x = Screen.PrimaryScreen.WorkingArea.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height;

            this.MinimumSize = new System.Drawing.Size(x, y);
        }

        //test if an instance of frmHome is open.  
        //  - If false, creates new instance of frmHome
        //  - if true, brings frmHome to front
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeFrmHome == null)
            {
                activeFrmHome = new frmHome();
                activeFrmHome.MdiParent = this;
                activeFrmHome.WindowState = FormWindowState.Maximized;
                activeFrmHome.Show();
                activeFrmHome.ControlBox = false;
                activeFrmHome.activeFrmMain = this;
            }
            else
            {
                activeFrmHome.BringToFront();
                activeFrmHome.WindowState = FormWindowState.Maximized;
            }
        }

        //test if an instance of frmPackages is open.  
        //  - If false, creates new instance of frmHome
        //  - if true, brings frmPackages to front
        private void btnPackages_Click(object sender, EventArgs e)
        {
            if (activeFrmPackages == null)
            {
                activeFrmPackages = new frmPackages();
                activeFrmPackages.MdiParent = this;
                activeFrmPackages.WindowState = FormWindowState.Maximized;
                activeFrmPackages.Show();
                activeFrmPackages.ControlBox = false;
                activeFrmPackages.activeFrmMain = this;
            }
            else
            {
                activeFrmPackages.BringToFront();
                activeFrmPackages.WindowState = FormWindowState.Maximized;
            }

        }


        //test if an instance of frmProducts is open.  
        //  - If false, creates new instance of frmHome
        //  - if true, brings frmProducts to front
        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (activeFrmProducts == null)
            {
                activeFrmProducts = new frmProducts();
                activeFrmProducts.MdiParent = this;
                activeFrmProducts.WindowState = FormWindowState.Maximized;
                activeFrmProducts.Show();
                activeFrmProducts.ControlBox = false;
                activeFrmProducts.activeFrmMain = this;
            }
            else
            {
                activeFrmProducts.BringToFront();
                activeFrmProducts.WindowState = FormWindowState.Maximized;
            }
        }


        //test if an instance of frmSuppliers is open.  
        //  - If false, creates new instance of frmHome
        //  - if true, brings frmSuppliers to front
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (activeFrmSuppliers == null)
            {
                activeFrmSuppliers = new frmSuppliers();
                activeFrmSuppliers.MdiParent = this;
                activeFrmSuppliers.WindowState = FormWindowState.Maximized;
                activeFrmSuppliers.Show();
                activeFrmSuppliers.ControlBox = false;
                activeFrmSuppliers.activeFrmMain = this;
            }
            else
            {
                activeFrmSuppliers.BringToFront();
                activeFrmSuppliers.WindowState = FormWindowState.Maximized;
            }
        }


        //test if an instance of frmAgents is open.  
        //  - If false, creates new instance of frmHome
        //  - if true, brings frmAgents to front
        private void btnAgents_Click(object sender, EventArgs e)
        {
            if (activeFrmAgents == null)
            {
                activeFrmAgents = new frmAgents();
                activeFrmAgents.MdiParent = this;
                activeFrmAgents.WindowState = FormWindowState.Maximized;
                activeFrmAgents.Show();
                activeFrmAgents.ControlBox = false;
                activeFrmAgents.activeFrmMain = this;
            }
            else
            {
                activeFrmAgents.BringToFront();
                activeFrmAgents.WindowState = FormWindowState.Maximized;
            }
        }


        //exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //loads the main form at start up, 
        //loads frmHome as the first form, and sets activeFrmHome to this instance
        //sets properties of frmHome instance

        private void frmMain_Load(object sender, EventArgs e)
        {
            activeFrmHome = new frmHome();
            activeFrmHome.MdiParent = this;
            activeFrmHome.WindowState = FormWindowState.Maximized;
            activeFrmHome.Show();
            activeFrmHome.ControlBox = false;
            activeFrmHome.activeFrmMain = this;
        }
    }
}
