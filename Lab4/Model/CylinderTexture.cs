using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL.SceneGraph.Assets;
namespace Lab4.Model
{
    class CylinderTexture
    {
        public Texture topSurfaceTexture { get; set; }
        public Texture bottomSurfaceTexture { get; set; }
        public Texture surroundSurfaceTexture { get; set; }
        public CylinderTexture()
        {
            topSurfaceTexture = new Texture();
            bottomSurfaceTexture = new Texture();
            surroundSurfaceTexture = new Texture();
        }
    }
}
