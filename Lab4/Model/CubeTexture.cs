using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;
using SharpGL.SceneGraph.Assets;
namespace Lab4.Model
{
    class CubeTexture 
    {
        public Texture surfaceNumberOneTexture { get; set; }
        public Texture surfaceNumberTwoTexture { get; set; }
        public Texture surfaceNumberThreeTexture { get; set; }
        public Texture surfaceNumberFourTexture { get; set; }
        public Texture surfaceNumberFiveTexture { get; set; }
        public Texture surfaceNumberSixTexture { get; set; }
        public  CubeTexture()
        {
            surfaceNumberOneTexture  = new Texture();
            surfaceNumberTwoTexture = new Texture();
            surfaceNumberThreeTexture = new Texture();
            surfaceNumberFourTexture = new Texture();
            surfaceNumberFiveTexture = new Texture();
            surfaceNumberSixTexture = new Texture();
        }
       
    }
}
