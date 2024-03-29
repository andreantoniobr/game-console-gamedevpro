namespace _172_Desafio_OutRefIn
{
    class Player
    {
        private Vector2 position;
        private Vector2 size;

        public Vector2 Position => position;
        public Vector2 Size => size;

        public Player(Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;
        }

        public void SetPlayerPosition(Vector2 position)
        {
            this.position = position;
        }

        public void SetPlayerPositionX(int positionX)
        {
            this.position.X = positionX;
        }

        public void SetPlayerPositionY(int positionY)
        {
            this.position.Y = positionY;
        }
    }
}
