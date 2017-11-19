using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace Lab4
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class SharpGLForm : Form
    {

        Texture texture = new Texture();
        int textureFlag = -1;
        const int CUBE_SURFACE_NUMBER_ONE = 01;
        const int CUBE_SURFACE_NUMBER_TWO = 02;
        const int CUBE_SURFACE_NUMBER_THREE = 03;
        const int CUBE_SURFACE_NUMBER_FOUR = 04;
        const int CUBE_SURFACE_NUMBER_FIVE = 05;
        const int CUBE_SURFACE_NUMBER_SIX = 06;
        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGLForm"/> class.
        /// </summary>
        public SharpGLForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //gl.MatrixMode(OpenGL.GL_MODELVIEW);
            //  Load the identity matrix.
            gl.LoadIdentity();

            // Translate the cube
            gl.Translate(-3.0f, 2.0f, -7.0f);
            gl.Rotate(angleCube, 1.0f, 1.0f, 1.0f);
            //  Rotate around the Y axis.
            //gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            LoadTextureAndDrawCube();

            //  Nudge the rotation.
            rotation += 3.0f;
            angleCube -= 3.0f;
        }



        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.1f, 100.0f);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(-5, 5, 10, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

      
         
        /// <summary>
        /// The current rotation.
        /// </summary>
        private float rotation = 0.0f;
        private float angleCube = 0.0f;

        private void mat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_ONE;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_TWO;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_THREE;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_FOUR;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_FIVE;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textureFlag = CUBE_SURFACE_NUMBER_SIX;
                texture.Destroy(openGLControl.OpenGL);
                texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }
    }
}
