﻿using Avalonia.Media;
using Avalonia.Utilities;

namespace Avalonia.Controls
{
    /// <summary>
    /// Implements the standard sixteen color palette from the HTML 4.01 specification.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Web_colors#HTML_color_names.
    /// </remarks>
    public class SixteenColorPalette : IColorPalette
    {
        // The 16 standard colors from HTML and early Windows computers
        // https://en.wikipedia.org/wiki/List_of_software_palettes
        // https://en.wikipedia.org/wiki/Web_colors#HTML_color_names
        private static Color[,] colorChart = new Color[,]
        {
            {
                Colors.White,
                Colors.Silver
            },
            {
                Colors.Gray,
                Colors.Black
            },
            {
                Colors.Red,
                Colors.Maroon
            },
            {
                Colors.Yellow,
                Colors.Olive
            },
            {
                Colors.Lime,
                Colors.Green
            },
            {
                Colors.Aqua,
                Colors.Teal
            },
            {
                Colors.Blue,
                Colors.Navy
            },
            {
                Colors.Fuchsia,
                Colors.Purple
            }
        };

        /// <summary>
        /// Gets the index of the default shade of colors in this palette.
        /// </summary>
        public const int DefaultShadeIndex = 0;

        private const int WhiteIndex = 0;
        private const int SilverIndex = 1;
        private const int GrayIndex = 2;
        private const int BlackIndex = 3;
        private const int RedIndex = 4;
        private const int MaroonIndex = 5;
        private const int YellowIndex = 6;
        private const int OliveIndex = 7;
        private const int LimeIndex = 8;
        private const int GreenIndex = 9;
        private const int AquaIndex = 10;
        private const int TealIndex = 11;
        private const int BlueIndex = 12;
        private const int NavyIndex = 13;
        private const int FuchsiaIndex = 14;
        private const int PurpleIndex = 15;

        /// <inheritdoc/>
        public int ColorCount
        {
            get => colorChart.GetLength(0);
        }

        /// <inheritdoc/>
        public int ShadeCount
        {
            get => colorChart.GetLength(1);
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FFFFFFFF.
        /// </summary>
        public static Color White
        {
            get => colorChart[WhiteIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FFC0C0C0.
        /// </summary>
        public static Color Silver
        {
            get => colorChart[SilverIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF808080.
        /// </summary>
        public static Color Gray
        {
            get => colorChart[GrayIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF000000.
        /// </summary>
        public static Color Black
        {
            get => colorChart[BlackIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FFFF0000.
        /// </summary>
        public static Color Red
        {
            get => colorChart[RedIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF800000.
        /// </summary>
        public static Color Maroon
        {
            get => colorChart[MaroonIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FFFFFF00.
        /// </summary>
        public static Color Yellow
        {
            get => colorChart[YellowIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF808000.
        /// </summary>
        public static Color Olive
        {
            get => colorChart[OliveIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF00FF00.
        /// </summary>
        public static Color Lime
        {
            get => colorChart[LimeIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF008000.
        /// </summary>
        public static Color Green
        {
            get => colorChart[GreenIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF00FFFF.
        /// </summary>
        public static Color Aqua
        {
            get => colorChart[AquaIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF008080.
        /// </summary>
        public static Color Teal
        {
            get => colorChart[TealIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF0000FF.
        /// </summary>
        public static Color Blue
        {
            get => colorChart[BlueIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF000080.
        /// </summary>
        public static Color Navy
        {
            get => colorChart[NavyIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FFFF00FF.
        /// </summary>
        public static Color Fuchsia
        {
            get => colorChart[FuchsiaIndex, DefaultShadeIndex];
        }

        /// <summary>
        /// Gets the palette defined color that has an ARGB value of #FF800080.
        /// </summary>
        public static Color Purple
        {
            get => colorChart[PurpleIndex, DefaultShadeIndex];
        }

        /// <inheritdoc/>
        public Color GetColor(int colorIndex, int shadeIndex)
        {
            return colorChart[
                MathUtilities.Clamp(colorIndex, 0, colorChart.GetLength(0) - 1),
                MathUtilities.Clamp(shadeIndex, 0, colorChart.GetLength(1) - 1)];
        }
    }
}
