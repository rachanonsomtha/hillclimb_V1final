using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Hill_climb.Class
{
    class hud : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        int distanceFromTop = 50;
        int fuelDistanceFromTop = 80;
        int moneyDistanseFromTop = 120;
        Texture2D fuelTankHud;
        Texture2D distanceHud;
        Texture2D moneyHud;
      
        public void loadContent()
        {
            fuelTankHud = Content.Load<Texture2D>("fuel_can");
            distanceHud = Content.Load<Texture2D>("distance");
            moneyHud = Content.Load<Texture2D>("coin");
        } 

       public void Draw()
        {
            spriteBatch.Begin();

            spriteBatch.Draw(fuelTankHud,new Rectangle(10,fuelDistanceFromTop, fuelTankHud.Width, fuelTankHud.Height), Color.White);
            spriteBatch.Draw(distanceHud, new Rectangle(10, distanceFromTop,distanceHud.Width, distanceHud.Height),Color.White);
            spriteBatch.Draw(moneyHud, new Rectangle(10, moneyDistanseFromTop, moneyHud.Width, moneyHud.Height), Color.White);


            spriteBatch.End();
        }

     







    }
}
