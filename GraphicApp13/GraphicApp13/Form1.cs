using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;


namespace GraphicApp13
{
    public partial class MainForm : Form
    {
        int vertex = 0;    // идентификатор вершинного шейдера
        int fragment = 0;  // идентификатор фрагментного шейдера
        int program = 0;
        
        
        public MainForm()
        {
            InitializeComponent();
            openGlControl.InitializeContexts();
            timer1.Start();
            Init();

            Resize(openGlControl.Width, openGlControl.Height);

        }
        public static bool Init()
        {
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT,
                      Gl.GL_NICEST);

            return true;
        }

        private static void Resize(int width, int height)
        {
            if (height == 0)
            {
                height = 1;
            }

            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, width / (double)height, 0.1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }
        double angle=0;
        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glTranslated(0.0, -0.5, -4.0);
            Gl.glRotated(angle, 0.0, 1.0, 0.0);

            Gl.glColor3d(0.6, 0.4, 0.2);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex3d(-1, -0.5, -1);
            Gl.glVertex3d(1, -0.5, -1);
            Gl.glVertex3d(1, -0.5, 1);
            Gl.glVertex3d(-1, -0.5, -1);
            Gl.glEnd();
            Gl.glTranslated(0.0, 1.0, 0.0);

            Gl.glColor3d(1.0, 0.2, 0.5);
            Glu.GLUquadric q = Glu.gluNewQuadric();
            Glu.gluSphere(q, 0.5, 50, 50);
            Glu.gluDeleteQuadric(q);

            Gl.glFlush();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 1.0;

            openGlControl.Invalidate();

        }

        private void openGlControl_Paint(object sender, PaintEventArgs e)
        {
            Draw();

        }
    }
}
