using System.Drawing;
using System.Windows.Forms;

namespace SpotifyManager
{
    public static class Styling
    {

        public static ColorConverter ColorConverter = new ColorConverter();

        public class Colors
        {
            public static Color Black {
                get
                {
                    return (Color) ColorConverter.ConvertFromString(HexCodes.Black);
                }

            }
            public static Color Background
            {
                get
                {
                    return (Color)ColorConverter.ConvertFromString(HexCodes.Background);
                }

            }
            public static Color Dark
            {
                get
                {
                    return (Color)ColorConverter.ConvertFromString(HexCodes.Dark);
                }

            }
            public static Color Shade
            {
                get
                {
                    return (Color)ColorConverter.ConvertFromString(HexCodes.Shade);
                }

            }
            public static Color Gray
            {
                get
                {
                    return (Color)ColorConverter.ConvertFromString(HexCodes.Gray);
                }

            }

            public struct HexCodes
            {
                public const string Black = "#0D0000";
                public const string Background = "#D8E6F2";
                public const string Dark = "#023859";
                public const string Shade = "#B0C6D9";
                public const string Gray = "#6D7E8C";
            }
        }
        
        public static bool SetScheme(Control control)
        {
            control.BackColor = Colors.Background;
            control.ForeColor = Colors.Black;

            if(control is ContainerControl)
            {
                //each control:
                foreach(Control childControl in control.Controls)
                {
                    
                    control.BackColor = Colors.Background;
                    control.ForeColor = Colors.Black;

                    if (control is ContainerControl)
                    {
                        SetScheme(childControl);
                    }

                    
                    }
                }


            return true;
            }
        }

        /*
        color scheme:

        Black:
        #0D0000

        Background:
        #D8E6F2

        Dark:
        #023859
        
        Shade
        #B0C6D9

        Gray:
        #6D7E8C

         */
    }
