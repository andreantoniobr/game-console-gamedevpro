using System;

namespace _172_Desafio_OutRefIn
{
    class Game
    {
        private Player player;
        private Vector2 playerInitialPosition = new Vector2 (20, 10);
        private Vector2 playeSize = new Vector2(2, 1);
        private int playerSpeed = 5;

        private ConsoleEngine engine;        

        public Game()
        {
            player = new Player(playerInitialPosition, playeSize);            
            engine = new ConsoleEngine(player);
        }

        public void Play()
        {
            while (true)
            {
                engine.Draw();  
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) break;          
                Move(key);
            }
        }

        private void Move(ConsoleKeyInfo key)
        {
            Vector2 playerPosition = player.Position;

            if (key.Key == ConsoleKey.D)
                {
                    playerPosition.X = player.Position.X + playerSpeed;
                }

                if (key.Key == ConsoleKey.A)
                {
                    playerPosition.X = player.Position.X - playerSpeed;
                }

                if (key.Key == ConsoleKey.W)
                {
                    playerPosition.Y = player.Position.Y - playerSpeed;
                }

                if (key.Key == ConsoleKey.S)
                {
                    playerPosition.Y = player.Position.Y + playerSpeed;
                }

                int startX;
                int endX;

                int startY;                
                int endY;
                
                if (engine.GetBounds(out startX, out endX, out startY, out endY))
                {
                    playerPosition.X = Math.Clamp(playerPosition.X, startX, endX);
                    playerPosition.Y = Math.Clamp(playerPosition.Y, startY, endY);
                    player.SetPlayerPosition(playerPosition);
                }                
        }
    }
}
