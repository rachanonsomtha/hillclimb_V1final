using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Hill_climb
{
    class Car
    {
        Texture2D texture;

        Vector2 position;
        Vector2 velocity;

        bool hasJumped;

        public Car(Texture2D newTexture,Vector2 newPosition)
        {
            texture = newTexture;
            position = newPosition;
            hasJumped = true;
        }

        public void Update(GameTime gameTime)
        {
            position += velocity;

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                velocity.X += 0.2f;
            }else

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                velocity.X -= 0.2f;
            }
            
            

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false)
       
            {
                position.Y -=10;
                velocity.Y = -5f;
                hasJumped = true;


            }
            if(hasJumped == true)
            {

                float i = 1;
                velocity.Y += 0.5f * i;
            }
           
            if(position.Y + texture.Height >= 450)
            {
                hasJumped = false;
            }
             if (hasJumped == false)
            {
                velocity.Y = 0f;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
       

    }
}
