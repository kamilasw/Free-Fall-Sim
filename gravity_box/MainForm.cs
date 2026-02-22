using System.Diagnostics;

namespace gravity_box
{
    public partial class MainForm : Form
    {

        int object_height = 0; // 0: object doesn't exist yet, >0: object exists with weight 
        double current_velocity = 0;
        double acceleration = -9.8;
        public MainForm()
        {
            InitializeComponent();
        }



        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateObject createobjectwindow = new();
            createobjectwindow.StartPosition = FormStartPosition.CenterParent;


            createobjectwindow.ShowDialog();


            // set the height of the object
            if (createobjectwindow.DialogResult == DialogResult.OK)
            {
                object_height = createobjectwindow.getHeightValue();
            }


            if (object_height > 0)
            {
                // show the object 

                Point location = new Point(250, 635 - object_height);

                ObjectPictureBox.Location = location;
                ObjectPictureBox.Visible = true;



                // adjust menu buttons
                startSimulationToolStripMenuItem.Enabled = true;
                clearToolStripMenuItem.Enabled = true;
                createToolStripMenuItem.Enabled = false;
            }
            else
            {
                clearToolStripMenuItem_Click(sender, e);
            }


        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (object_height > 0)
            {
                // clear the object visually
                ObjectPictureBox.Visible = false;

                object_height = 0;
                current_velocity = 0;


                // adjuct menu selection
                clearToolStripMenuItem.Enabled = false;
                startSimulationToolStripMenuItem.Enabled = false;
                createToolStripMenuItem.Enabled = true;

            }

        }

        private void startSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startSimulationToolStripMenuItem.Enabled = false;
            createToolStripMenuItem.Enabled = false;

            // perform the fall simulation 

            double seconds = 0;

            while(ObjectPictureBox.Location.Y<635)
            {
               
                // 1 pixel is 1 meter
                // time step is 0.1 sec

                current_velocity = seconds * acceleration;

                int next_y = ObjectPictureBox.Location.Y - (int)(current_velocity / 10);

                Point location = new Point(250, next_y);

                ObjectPictureBox.Location = location;

                seconds += 0.1; 

                Thread.Sleep(100);
            }
        }
    }
}
