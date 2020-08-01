using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISCIO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

       
        serverCreate alim;

        private void buildBtn_Click(object sender, EventArgs e)
        {
            if (alim == null)
            {
                alim = new serverCreate();
                alim.Dock = DockStyle.Fill;
                masterPage.Controls.Add(alim);
            }
            alim.BringToFront();

        }
       
        private void settingsButton_Click(object sender, EventArgs e)
        {
            
        }

        testMail mailTest;
        private void _testMail_Click(object sender, EventArgs e)
        {
            if (mailTest == null)
            {
                mailTest = new testMail();
                mailTest.Dock = DockStyle.Fill;
                masterPage.Controls.Add(mailTest);
            }
            mailTest.BringToFront();
        }

        private void gitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this._gitLink.LinkVisited = true;

           
            System.Diagnostics.Process.Start("https://github.com/ysfcndgr");
        }

        private void passwordsBtn_Click(object sender, EventArgs e)
        {

        }
        dashboard Dashboard;
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (Dashboard == null)
            {
                Dashboard = new dashboard();
                Dashboard.Dock = DockStyle.Fill;
                masterPage.Controls.Add(Dashboard);
            }
            Dashboard.BringToFront();

        }

        private void masterPage_Paint(object sender, PaintEventArgs e)
        {

        }

        settings _settings;
        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            if (_settings == null)
            {
                _settings = new settings();
                _settings.Dock = DockStyle.Fill;
                masterPage.Controls.Add(_settings);
            }
            _settings.BringToFront();
        }
        visualTracking _visualTracking;
        private void visualtrackingBtn_Click(object sender, EventArgs e)
        {
            if (_visualTracking == null)
            {
                _visualTracking = new visualTracking();
                _visualTracking.Dock = DockStyle.Fill;
                masterPage.Controls.Add(_visualTracking);
            }
            _visualTracking.BringToFront();
        }

        passwords _passwords;
        private void passwordsBtn_Click_1(object sender, EventArgs e)
        {
            if (_passwords == null)
            {
                _passwords = new passwords();
                _passwords.Dock = DockStyle.Fill;
                masterPage.Controls.Add(_passwords);
            }
            _passwords.BringToFront();
        }

        spread _spread;
        private void spreadBtn_Click(object sender, EventArgs e)
        {
            if (_spread == null)
            {
                _spread = new spread();
                _spread.Dock = DockStyle.Fill;
                masterPage.Controls.Add(_spread);
            }
            _spread.BringToFront();
        }
    }
    }
