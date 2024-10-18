using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MapConverter
{
    internal struct OKLab
    {
        // fields
        private float l;
        private float a;
        private float b;

        // properties

        /// <summary>
        /// gets the colors lightness
        /// </summary>
        public float L { get { return l; } }

        /// <summary>
        /// gets the colors red/green value
        /// </summary>
        public float A { get { return a; } }

        /// <summary>
        /// gets the colors blue/yellow value
        /// </summary>
        public float B { get { return b; } }

        // constructor

        /// <summary>
        /// creates a new OKLab color
        /// </summary>
        /// <param name="l">lightness</param>
        /// <param name="a">red/green</param>
        /// <param name="b">blue/yellow</param>
        private OKLab(float l, float a, float b)
        {
            this.l = l;
            this.a = a;
            this.b = b;
        }

        // methods

        // below method adapted from Björn Ottosson
        // https://bottosson.github.io/posts/oklab/
        /// <summary>
        /// converts between rgb and oklab
        /// </summary>
        /// <param name="c">color in rgb</param>
        /// <returns>color in oklab space</returns>
        public static OKLab FromRGB(Color c)
        {
            // convert to linear rgb
            float r = MathF.Pow(c.R / 255f, 2.2f);
            float g = MathF.Pow(c.G / 255f, 2.2f);
            float b = MathF.Pow(c.B / 255f, 2.2f);

            // convert to oklab
            float l = 0.4122214708f * r + 0.5363325363f * g + 0.0514459929f * b;
            float m = 0.2119034982f * r + 0.6806995451f * g + 0.1073969566f * b;
            float s = 0.0883024619f * r + 0.2817188376f * g + 0.6299787005f * b;

            float l_ = MathF.Cbrt(l);
            float m_ = MathF.Cbrt(m);
            float s_ = MathF.Cbrt(s);

            return new OKLab(
                +4.0767416621f * l - 3.3077115913f * m + 0.2309699292f * s,
                -1.2684380046f * l + 2.6097574011f * m - 0.3413193965f * s,
                -0.0041960863f * l - 0.7034186147f * m + 1.7076147010f * s);
        }

        /// <summary>
        /// finds the squared distance to another color in OKLab space
        /// </summary>
        /// <param name="c">color to find distance to</param>
        /// <returns>squared distance</returns>
        public float SquaredDistanceTo(Color c)
        {
            OKLab lab = FromRGB(c);

            return MathF.Pow(lab.L - l, 2) 
                + MathF.Pow(lab.A - a, 2) 
                + MathF.Pow(lab.B - b, 2); 
        }
    }
}
