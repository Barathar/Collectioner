using HomeCollection.UI;
using System.Drawing;

namespace HomeCollection.Utility
{
    public static class StyleManager
    {
        public static Color DEFAULT_MAIN_BACK = Color.DimGray;
        public static Color DEFAULT_MAIN_FORE = Color.White;
        public static Color DEFAULT_ALTERNATING_BACK = Color.Gray;
        public static Color DEFAULT_ALTERNATING_FORE = Color.White;
        public static Color DEFAULT_HIGHLIGHTING_BACK = Color.Orange;
        public static Color DEFAULT_HIGHLIGHTING_FORE = Color.Black;
        public static Color BOARDGAME_MAIN_BACK = Color.CornflowerBlue;
        public static Color BOARDGAME_MAIN_FORE = Color.White;
        public static Color BOARDGAME_ALTERNATING_BACK = Color.RoyalBlue;
        public static Color BOARDGAME_ALTERNATING_FORE = Color.White;
        public static Color BOARDGAME_HIGHLIGHTING_BACK = Color.OrangeRed;
        public static Color BOARDGAME_HIGHLIGHTING_FORE = Color.Black;
        public static Color VIDEOGAME_MAIN_BACK = Color.GreenYellow;
        public static Color VIDEOGAME_MAIN_FORE = Color.White;
        public static Color VIDEOGAME_ALTERNATING_BACK = Color.DarkSeaGreen;
        public static Color VIDEOGAME_ALTERNATING_FORE = Color.White;
        public static Color VIDEOGAME_HIGHLIGHTING_BACK = Color.DeepPink;
        public static Color VIDEOGAME_HIGHLIGHTING_FORE = Color.Black;

        public static Color MainBack { get; private set; }
        public static Color MainFore { get; private set; }
        public static Color AlternatingBack { get; private set; }
        public static Color AlternatingFore { get; private set; }
        public static Color HighlightBack { get; private set; }
        public static Color HighlightFore { get; private set; }
        public static Font Font { get; private set; }

        static StyleManager()
        {
            ChangeColorTheme(CollectionMode.Boardgame);
            ChangeFont();
        }

        public static void ChangeColorTheme(CollectionMode mode)
        {
            switch (mode)
            {
                case CollectionMode.Boardgame:
                    SetTheme(BOARDGAME_MAIN_BACK, BOARDGAME_MAIN_FORE, BOARDGAME_ALTERNATING_BACK, BOARDGAME_ALTERNATING_FORE, BOARDGAME_HIGHLIGHTING_BACK, BOARDGAME_HIGHLIGHTING_FORE);
                    break;
                case CollectionMode.Videogame:
                    SetTheme(VIDEOGAME_MAIN_BACK, VIDEOGAME_MAIN_FORE, VIDEOGAME_ALTERNATING_BACK, VIDEOGAME_ALTERNATING_FORE, VIDEOGAME_HIGHLIGHTING_BACK, VIDEOGAME_HIGHLIGHTING_FORE);
                    break;
                case CollectionMode.CD:
                    break;
                case CollectionMode.DVD:
                    break;
                case CollectionMode.Book:
                    break;
                default:
                    SetTheme(DEFAULT_MAIN_BACK, DEFAULT_MAIN_FORE, DEFAULT_ALTERNATING_BACK, DEFAULT_ALTERNATING_FORE, DEFAULT_HIGHLIGHTING_BACK, DEFAULT_HIGHLIGHTING_FORE);
                    break;
            }
        }
        public static void ChangeFont()
        {
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        private static void SetTheme(Color mainBack, Color mainFore, Color altBack, Color altFore, Color highlightBack, Color highlightFore)
        {
            MainBack = mainBack;
            MainFore = mainFore;
            AlternatingBack = altBack;
            AlternatingFore = altFore;
            HighlightBack = highlightBack;
            HighlightFore = HighlightFore;
        }
    }
}
