using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorFrame
{
    class ActorFrame
    {
        private string spriteName;
        private string spriteIndex;
        private int frameDuration;
        private DecorateFunction.DecorateFunction dfunction;
        
        public ActorFrame(string sprite, char index, int dur, DecorateFunction.DecorateFunction func)
        {
            if(sprite.Length == 4)
            {
                spriteName = sprite.ToUpper();
            }
            else
            {
                Console.WriteLine("Sprite name for actor frame is not 4 characters!");
                spriteName = "TNT1";
            }
            if(isCharValid(index))
            {
                spriteIndex = index.ToString().ToUpper();
            }
            else
            {
                Console.WriteLine("Sprite index for actor is not valid!");
                spriteIndex = "A";
            }
            if(dur < 0)
            {
                frameDuration = 0;
            }
            else
            {
                frameDuration = dur;
            }
            this.dfunction = func;
        }

        private bool isCharValid(char c)
        {
            if(c >= 0x0041 &&  c <= 0x005A)
            {
                return true;
            }
            if(c >= 0x0061 && c <= 0x007A)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            if (dfunction == null)
            {
                return spriteName + " " + spriteIndex + " " + frameDuration;
            }
            return spriteName + " " + spriteIndex + " " + frameDuration + " " + dfunction.ToString();
        }
    }
}
