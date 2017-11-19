using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;
using SharpGL.SceneGraph.Assets;
namespace Lab4.Model
{
    class Cube
    {
        public Texture surfaceNumberOneTexture { get; set; }
        public Texture surfaceNumberTwoTexture { get; set; }
        public Texture surfaceNumberThreeTexture { get; set; }
        public Texture surfaceNumberFourTexture { get; set; }
        public Texture surfaceNumberFiveTexture { get; set; }
        public Texture surfaceNumberSixTexture { get; set; }
        public void Cube()
        {
            surfaceNumberOneTexture  = new Texture();
            surfaceNumberTwoTexture = new Texture();
            surfaceNumberThreeTexture = new Texture();
            surfaceNumberFourTexture = new Texture();
            surfaceNumberFiveTexture = new Texture();
            surfaceNumberSixTexture = new Texture();
        }
        void LoadTextureAndDrawCube()
        {
            OpenGL gl =  openGLControl.OpenGL;

            texture.Create(gl, "texture01.bmp");
            gl.Enable(SharpGL.OpenGL.GL_BLEND);
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);
            //gl.BlendFunc(SharpGL.Enumerations.BlendingSourceFactor.SourceAlpha, SharpGL.Enumerations.BlendingDestinationFactor.OneMinusSourceAlpha);
            //gl.ClearColor(0, 0, 0, 1);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            texture.Bind(gl);

            //gl.GenTextures(1, texNames);
            //gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, texture.);

            //gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_WRAP_S, SharpGL.OpenGL.GL_REPEAT);
            //gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_WRAP_T, SharpGL.OpenGL.GL_REPEAT);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);
            gl.Begin(OpenGL.GL_QUADS);
            if (textureFlag == CUBE_SURFACE_NUMBER_ONE)
            {
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
            }
            else
            {
                gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
                gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
            }

            // Back Face
            if (textureFlag == CUBE_SURFACE_NUMBER_TWO)
            {
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad
            }
            else
            {
                gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad
            }
            // Top Face
            if (textureFlag == CUBE_SURFACE_NUMBER_THREE)
            {
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
            }
            else
            {
                gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.Vertex(-1.0f, 1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
            }
            // Bottom Face
            if (textureFlag == CUBE_SURFACE_NUMBER_FOUR)
            {
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
            }
            else
            {
                gl.Vertex(-1.0f, -1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.Vertex(1.0f, -1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
            }
            // Right face
            if (textureFlag == CUBE_SURFACE_NUMBER_FIVE)
            {
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
            }
            else
            {
                gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad
                gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
            }
            // Left Face
            if (textureFlag == CUBE_SURFACE_NUMBER_FIVE)
            {
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
            }
            else
            {
                gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad
                gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
                gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
            }
            gl.End();
            gl.PopMatrix();

            gl.Disable(OpenGL.GL_TEXTURE_2D);


        }
    }
}
