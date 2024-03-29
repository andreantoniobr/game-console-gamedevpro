using System;

namespace _172_Desafio_OutRefIn
{
    class ConsoleEngine
    {
        private Player player;
        private const int screenWidth = 100;
        private const int screenStartX = 10;
        private const int screenStartY = 2;
        private const int screenHeight = 20;

        public ConsoleEngine(Player player)
        {
            this.player = player;
        }

        public bool GetBounds(out int screenWidthStartX, out int screenWidthEndX, out int screenHeightStartX, out int screenHeightEndX)
        {
            screenWidthStartX = screenStartX;
            screenWidthEndX = screenStartX + screenWidth - player.Size.X;
            screenHeightStartX = screenStartY;
            screenHeightEndX = screenStartY + screenHeight - player.Size.Y;
             return screenWidthStartX > 0 && 
                    screenWidthEndX > 0 && 
                    screenHeightStartX > 0 && 
                    screenHeightEndX > 0;
        }

        public void Draw()
        {
            Console.Clear();
            DrawUtils.Rectangle(screenWidth, screenHeight, screenStartX, screenStartY, ConsoleColor.Red);
            DrawUtils.Rectangle(player.Size.X, player.Size.Y, player.Position.X, player.Position.Y);
        }
    }
}
