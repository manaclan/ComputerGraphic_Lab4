using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL.SceneGraph.Assets;
namespace Lab4.Model
{
    class ConeTexture
    {
        public Texture surroundSurfaceTexture { get; set; }
        public Texture bottomSurfaceTexture { get; set; }
        public ConeTexture()
        {
            surroundSurfaceTexture = new Texture();
            bottomSurfaceTexture = new Texture();
        }
    }
}
