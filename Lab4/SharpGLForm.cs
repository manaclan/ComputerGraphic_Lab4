﻿using System;
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
        Lab4.Model.CubeTexture cubeTexture;
        Lab4.Model.SphereTexture sphereTexture;
        Lab4.Model.CylinderTexture cylinderTexture;
        Lab4.Model.ConeTexture coneTexture;
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
            gl.Translate(-4.0f, 2.0f, -7.0f);
            gl.Rotate(angleCube, 1.0f, 1.0f, 1.0f);
            //  Rotate around the Y axis.
            DrawCube();

            gl.LoadIdentity();
            gl.Translate(0.0f, 2.0f, -7.0f);
            gl.Rotate(angleSphere, 1.0f, 1.0f, 1.0f);
            DrawSphere();

            // Draw cylinder
            gl.LoadIdentity();
            gl.Translate(6.0f, 1.0f, -7.0f);
            gl.Rotate(angleCylinder, 1.0f, 0.0f, 0.0f);
            DrawCylinder();

            // Draw cone
            gl.LoadIdentity();
            gl.Translate(10.0f, 1.0f, -7.0f);
            gl.Rotate(angleCone, 1.0f, 0.0f, 0.0f);
            DrawCone();
            //  Nudge the rotation.
            angleCube -= 3.0f;
            angleSphere -= 3.0f;
            angleCylinder -= 3.0f;
            angleCone -= 3.0f;
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
            cubeTexture = new Lab4.Model.CubeTexture();
            sphereTexture = new Lab4.Model.SphereTexture();
            cylinderTexture = new Lab4.Model.CylinderTexture();
            coneTexture = new Lab4.Model.ConeTexture();
            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            gl.ClearDepth(1.0f);
            gl.Enable(OpenGL.GL_DEPTH_TEST);
            gl.DepthFunc(OpenGL.GL_LEQUAL);
            gl.ShadeModel(OpenGL.GL_SMOOTH);
            gl.Hint(OpenGL.GL_PERSPECTIVE_CORRECTION_HINT, OpenGL.GL_NICEST);
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

        void DrawCube()
        {
            OpenGL gl =  openGLControl.OpenGL ;
            gl.BlendFunc(SharpGL.Enumerations.BlendingSourceFactor.SourceAlpha, SharpGL.Enumerations.BlendingDestinationFactor.OneMinusSourceAlpha);
            //gl.ClearColor(0, 0, 0, 1);
            

            //gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_WRAP_S, SharpGL.OpenGL.GL_REPEAT);
            //gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_WRAP_T, SharpGL.OpenGL.GL_REPEAT);

            // Front Face
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            
            cubeTexture.surfaceNumberOneTexture.Bind(gl);
            gl.Begin(OpenGL.GL_QUADS);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

                
            // Back Face
                gl.Enable(SharpGL.OpenGL.GL_BLEND);
                gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
                cubeTexture.surfaceNumberTwoTexture.Bind(gl);
                gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad
                gl.End();
                gl.Disable(OpenGL.GL_TEXTURE_2D);

                
            // Top Face
                gl.Enable(SharpGL.OpenGL.GL_BLEND);
                gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
                cubeTexture.surfaceNumberThreeTexture.Bind(gl);
                gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.End();
                gl.Disable(OpenGL.GL_TEXTURE_2D);

                
            // Bottom Face
                gl.Enable(SharpGL.OpenGL.GL_BLEND);
                gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
                cubeTexture.surfaceNumberFourTexture.Bind(gl);
                gl.Begin(OpenGL.GL_QUADS);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.End();
                gl.Disable(OpenGL.GL_TEXTURE_2D);
                
                
            // Right face
                gl.Enable(SharpGL.OpenGL.GL_BLEND);
                gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
                gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            cubeTexture.surfaceNumberFiveTexture.Bind(gl);
            gl.Begin(OpenGL.GL_QUADS);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

            // Left Face
            
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            cubeTexture.surfaceNumberSixTexture.Bind(gl);
            gl.Begin(OpenGL.GL_QUADS);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);// Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad

            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

        }
        void DrawSphere()
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.BlendFunc(SharpGL.Enumerations.BlendingSourceFactor.SourceAlpha, SharpGL.Enumerations.BlendingDestinationFactor.OneMinusSourceAlpha);
            
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            
            sphereTexture.texture.Bind(gl);
            
            IntPtr quadric = gl.NewQuadric();
            gl.QuadricDrawStyle(quadric, OpenGL.GLU_FILL);
            
            gl.QuadricNormals(quadric, OpenGL.GL_SMOOTH);
            gl.QuadricTexture(quadric, 1);
            gl.Sphere(quadric,1.5f,36,18);
            
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

        void DrawCylinder()
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.BlendFunc(SharpGL.Enumerations.BlendingSourceFactor.SourceAlpha, SharpGL.Enumerations.BlendingDestinationFactor.OneMinusSourceAlpha);

            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            cylinderTexture.topSurfaceTexture.Bind(gl);
            double i, resolution = 0.1;
            double height = 3;
            double radius = 1.3;

            //top
            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.TexCoord(0.5, 0.5);
            gl.Vertex(0.0f, height, 0.0f);
            for (i = 2 * Math.PI; i >= 0; i -= resolution)
            {
                gl.TexCoord(0.5f * Math.Cos(i) + 0.5f, 0.5f * Math.Sin(i) + 0.5f);
                gl.Vertex(radius * Math.Cos(i), height, radius * Math.Sin(i));
            }
            gl.TexCoord(0.5, 0.5);
            gl.Vertex(radius, height, 0);
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

            //bottom
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            cylinderTexture.bottomSurfaceTexture.Bind(gl);
            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.TexCoord(0.5f, 0.5f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            for (i = 0; i <= 2 * Math.PI; i += resolution)
            {
                gl.TexCoord(0.5f * Math.Cos(i) + 0.5f, 0.5f * Math.Sin(i) + 0.5f);
                gl.Vertex(radius * Math.Cos(i), 0, radius * Math.Sin(i));
            }
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

            //surrond
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            cylinderTexture.surroundSurfaceTexture.Bind(gl);
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            for (i = 0; i <= 2 * Math.PI; i += resolution)
            {
                float tc = ((float)i / (float)(2 * Math.PI));
                gl.TexCoord(tc, 0.0);
                gl.Vertex(radius * Math.Cos(i), 0, radius * Math.Sin(i));
                gl.TexCoord(tc, 1.0f);
                gl.Vertex(radius * Math.Cos(i), height, radius * Math.Sin(i));
            }
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(radius, 0, 0);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(radius, height, 0);
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }
        void DrawCone()
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.BlendFunc(SharpGL.Enumerations.BlendingSourceFactor.SourceAlpha, SharpGL.Enumerations.BlendingDestinationFactor.OneMinusSourceAlpha);

            
            double i, resolution = 0.1;
            double height = 3;
            double radius = 1.3;

            //bottom
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            coneTexture.bottomSurfaceTexture.Bind(gl);
            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.TexCoord(0.5f, 0.5f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            for (i = 0; i <= 2 * Math.PI; i += resolution)
            {
                gl.TexCoord(0.5f * Math.Cos(i) + 0.5f, 0.5f * Math.Sin(i) + 0.5f);
                gl.Vertex(radius * Math.Cos(i), 0, radius * Math.Sin(i));
            }
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);

            //surrond
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            coneTexture.surroundSurfaceTexture.Bind(gl);
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            for (i = 0; i <= 2 * Math.PI; i += resolution)
            {
                float tc = ((float)i / (float)(2 * Math.PI));
                gl.TexCoord(tc, 0.0);
                gl.Vertex(radius * Math.Cos(i), 0, radius * Math.Sin(i));
                gl.TexCoord(tc, 1.0f);
                gl.Vertex(0, height, 0);
            }
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(radius, 0, 0);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0, height, 0);
            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }
        /// <summary>
        /// The current rotation.
        /// </summary>
        private float angleCube = 0.0f;
        private float angleSphere = 0.0f;
        private float angleCylinder = 0.0f;
        private float angleCone = 0.0f;
        private void mat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberOneTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberOneTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberTwoTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberTwoTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberThreeTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberThreeTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberFourTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberFourTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberFiveTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberFiveTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void mat6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cubeTexture.surfaceNumberSixTexture.Destroy(openGLControl.OpenGL);
                cubeTexture.surfaceNumberSixTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void hinhCauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sphereTexture.texture.Destroy(openGLControl.OpenGL);
                sphereTexture.texture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void matTrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cylinderTexture.topSurfaceTexture.Destroy(openGLControl.OpenGL);
                cylinderTexture.topSurfaceTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void matDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cylinderTexture.bottomSurfaceTexture.Destroy(openGLControl.OpenGL);
                cylinderTexture.bottomSurfaceTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void xungQuanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cylinderTexture.surroundSurfaceTexture.Destroy(openGLControl.OpenGL);
                cylinderTexture.surroundSurfaceTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void xungQuanhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                coneTexture.surroundSurfaceTexture.Destroy(openGLControl.OpenGL);
                coneTexture.surroundSurfaceTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                coneTexture.bottomSurfaceTexture.Destroy(openGLControl.OpenGL);
                coneTexture.bottomSurfaceTexture.Create(openGLControl.OpenGL, openFileDialog.FileName);
                openGLControl.Invalidate();
            }
        }
    }
}
