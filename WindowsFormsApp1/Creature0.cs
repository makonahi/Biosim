using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class Creatures
    { }
    class Cell
    {
        /// <summary>
        /// </summary>
        public int id, lifetime, satiety, maxsatiety, birthdelay, maxlifetime;
        public bool state;
        public Cell(int id, int maxlifetime, int lifetime, int maxsatiety, int satiety, int birthdelay, bool state)
        {
            this.state = state;
            this.id = id;
            this.lifetime = lifetime;
            this.satiety = satiety;
            this.maxsatiety = maxsatiety;
            this.birthdelay = birthdelay;
            this.state = state;
            this.maxlifetime = maxlifetime;
        }
    }
    class Cell2
    {
        public int id, lifetime, satiety, maxsatiety, maxbirthdelay, birthdelay, maxlifetime, red, green, blue;
        //public int[,,,] genome = { {  }, {  }, {  }, {  } };
        public bool state, photosynthesis, carnivorous;
        public Cell2(int id, int maxlifetime, int lifetime, int maxsatiety, int satiety, int maxbirthdelay, int birthdelay, bool state, bool photosynthesis, bool carnivorous, int red, int green, int blue /*int[,,,] genome*/)
        {
            //this.genome = genome;
            this.carnivorous = carnivorous;
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.photosynthesis = photosynthesis;
            this.maxbirthdelay = maxbirthdelay;
            this.state = state;
            this.id = id;
            this.lifetime = lifetime;
            this.satiety = satiety;
            this.maxsatiety = maxsatiety;
            this.birthdelay = birthdelay;
            this.state = state;
            this.maxlifetime = maxlifetime;
        }
    }
    class Mineral
    {
        public int value, id;
        public bool state;
        public Mineral (int id, int value, bool state)
        {
            this.id = id;
            this.value = value;
            this.state = state;
        }
    }
    class Flora
    {
        public int id, value, lifetime, birthdelay;
        public bool alive, blossom;
        public Flora(int id, int value, int lifetime, int birthdelay, bool alive, bool blossom)
        {
            this.id = id;
            this.value = value;
            this.alive = alive;
            this.blossom = blossom;
            this.lifetime = lifetime;
            this.birthdelay = birthdelay;
        }
    }

    class Tile
    {
        public int x, y, id, lightamount;
        public bool filled;
        public Tile(int x, int y, int id, int lightamount, bool filled)
        {
            this.lightamount = lightamount;
            this.id = id;
            this.x = x;
            this.y = y;
            this.filled = filled;
        }
    }
    
}
