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
    public partial class Form1 : Form
    {
        Bitmap cellm;
        Bitmap graphicsmap;
        Graphics g, graphics;
        Pen greenpen, graphpenc, graphpenf, mappen, eraserpen, redpen, orangepen, graypen;

        SolidBrush cellbrush;
        Pen cellpen;

        SolidBrush cell2brush;
        Pen cell2pen;

        SolidBrush tilebrush;

        Brush greenbrush, eraserbrush, yellowbrush, graybrush;
        Random rnd;
        int a, b = 0, time1 = 0, pretime = 0, precount = 0, precountF = 0, seconds = 0, milliseconds = 0;
        int random1 = 0, random2 = 0, random3 = 0, random4 = 0;

        const byte TILESIZE = 20;
        const byte REPRODUCTION_ENERGY_FACTOR = 2;
        const byte BLOSSOM_ENERGY_FACTOR = 2;
        const byte MOVING_ENERGY_CONSUMPTION = 8;
        const byte STAGNATION_ENERGY_CONSUMPTION = 3;

        const short BIRTH_DELAY_F = 40;
        const short BIRTH_DELAY_C = 80;
        const short BLOSSOM_PERIOD = 500;
        const byte PHOTOSYNTHESIS_PENALTY = 0;
        const byte CARNIVOROUS_PENALTY = 0;
        const byte OMNIVOROUS = 0;


        int mapsize;
        int width;

        public int lightamount = 3;
        public int tilelightamount = 56;
        public float radiationfactor = 0.1f;
        public int pressid = 0;
        byte simulationtype = 0;
        byte maptype = 0;
        short temporary = -1;

        Cell[] cell;
        Tile[] tile;
        Flora[] flora;
        Cell2[] cell2;
        Mineral[] mineral;


        public int cellcount, scavcount, floracount, alivefloracount, alivecellcount, mineralcount, maxmineral = 200, speciescount = 0;
        public Form1()
        {
            //this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            InitializeComponent();
            ColorsInit();
            StandartFormLoad();
            this.pictureBox1.Image = cellm;
        }
        private void ColorsInit()
        {
            greenpen = new Pen(Color.Green);
            mappen = new Pen(Color.Black);
            eraserpen = new Pen(Color.White);
            redpen = new Pen(Color.Red);
            orangepen = new Pen(Color.Orange);
            graypen = new Pen(Color.Gray);

            graphpenc = new Pen(Color.FromArgb(0, 128, 128));
            graphpenf = new Pen(Color.Lime);

            graphpenf.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            redpen.Width = 3.0F;
            mappen.Width = 2.0F;
            graphpenc.Width = 3.0F;
            graphpenf.Width = 3.0F;

            greenbrush = Brushes.Lime;
            graybrush = Brushes.DarkGray;
            eraserbrush = Brushes.White;
            yellowbrush = Brushes.Yellow;

            cellbrush = new SolidBrush(Color.FromArgb(0, 250, 154));
            cellpen = new Pen(Color.FromArgb(0, 128, 128));

            cell2brush = new SolidBrush(Color.FromArgb(64, 64, 64));
            cell2pen = new Pen(Color.FromArgb(128, 128, 128));
        }
        private void Init()
        {
            mineralcount = -1;
            cellcount = -1;
            scavcount = -1;
            floracount = -1;
            alivefloracount = -1;
            alivecellcount = -1;
            if (simulationtype == 0)
            {
                for (int i = 0; i < mapsize; i++)
                {
                    a = rnd.Next(0, 80);
                    if (a == 0 && !tile[i].filled)
                    {
                        alivecellcount++;
                        cellcount++;
                        cell[cellcount] = new Cell(tile[i].id, 150, 400000, 90, 5000, 0, true);
                        tile[i].filled = true;
                    }
                }

                for (int i = 0; i < mapsize; i++)
                {
                    a = rnd.Next(0, 30);
                    if (a == 0 && !tile[i].filled)
                    {
                        floracount++;
                        alivefloracount++;
                        flora[floracount] = new Flora(tile[i].id, 26, 0, 0, true, false);
                        tile[i].filled = true;
                    }
                }
            }
            if (simulationtype == 1)
            {
                for (int i = 0; i < mapsize; i++)
                {
                    a = rnd.Next(0, 30);
                    if (a == 0 && !tile[i].filled)
                    {
                        alivecellcount++;
                        cellcount++;
                        cell2[cellcount] = new Cell2(tile[i].id, 500, 30000, 500, 5000, 50, 0, true, false, true, 128, 128, 128);
                        tile[i].filled = true;
                    }
                }
                for (int i = 0; i < maxmineral; i++)
                    while (mineral[i] == null)
                    {
                        a = rnd.Next(mapsize / 2, mapsize);
                        if (!tile[a].filled)
                        {
                            mineral[i] = new Mineral(tile[a].id, 64, true);
                            DrawMineral(i, orangepen, yellowbrush, g);
                            tile[a].filled = true;
                        }
                    }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void DrawLine(Pen pen, int x, int y, int fx, int fy, Graphics g)
        {
            g.DrawLine(pen, x, y, fx, fy);
        }
        public void DrawGLine(Pen pen, int x, int y, int fx, int fy, Graphics g)
        {
            graphics.DrawLine(pen, x, y, fx, fy);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void lightAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            Move.Enabled = false;
            pressid = 0;
        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (textBox8.Visible == true)
                {
                    if (pressid == 0)
                    {
                        lightamount = Convert.ToInt32(textBox8.Text);
                    }
                    if (pressid == 1)
                    {
                        radiationfactor = float.Parse(textBox8.Text);
                    }
                    textBox8.Visible = false;
                    Move.Enabled = true;
                }
        }
        private void radiationAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            Move.Enabled = false;
            pressid = 1;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        void StandartFormLoad()
        {
            width = this.Width / TILESIZE;
            //tilelightamount = width;
            cellm = new Bitmap(this.Width, this.Height);
            graphicsmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            g = Graphics.FromImage(cellm);
            graphics = Graphics.FromImage(graphicsmap);
            mapsize = (this.Width / TILESIZE) * (this.Height / TILESIZE);
            cell = new Cell[mapsize * 2];
            flora = new Flora[mapsize * 2];
            tile = new Tile[mapsize];
            cell2 = new Cell2[mapsize * 2];
            mineral = new Mineral[maxmineral];
            rnd = new Random();
            for (int x = 0; x <= this.Width / TILESIZE; x++)
                DrawLine(mappen, x * TILESIZE, 0, x * TILESIZE, this.Height, g);
            for (int y = 0; y <= this.Height / TILESIZE; y++)
                DrawLine(mappen, 0, y * TILESIZE, this.Width, y * TILESIZE, g);
            for (int i = 0; i < mapsize; i++)
            {
                if ((i / width) < 14)
                    temporary = 0;
                if ((i / width) > 14 && (i / width) < 28)
                    temporary = 1;
                if ((i / width) > 28 && (i / width) < 42)
                    temporary = 2;
                if ((i / width) > 42 && (i / width) < 56)
                    temporary = 3;
                if ((i / width) > 56)
                    temporary = 4;
                tile[i] = new Tile(2 + (i % width) * 20, 2 + (i / width) * 20, i, Math.Max(0, tilelightamount - 14 * temporary), false);
            }
        }
        private void simulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StandartFormLoad();
            Move.Enabled = true;
            Init();
        }
        private void defaultSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public void DrawCell(int i, Pen pen, Brush brush, Graphics graphics)
        {
            graphics.DrawRectangle(pen, tile[cell[i].id].x - 1, tile[cell[i].id].y - 1, 17, 17);
            graphics.FillRectangle(brush, tile[cell[i].id].x, tile[cell[i].id].y, 16, 16);
            this.pictureBox1.Image = cellm;
        }
        public void DrawCell2(int i, Pen pen, Brush brush, Graphics graphics)
        {
            graphics.DrawRectangle(pen, tile[cell2[i].id].x - 1, tile[cell2[i].id].y - 1, 17, 17);
            graphics.FillRectangle(brush, tile[cell2[i].id].x, tile[cell2[i].id].y, 16, 16);
            this.pictureBox1.Image = cellm;
        }
        public void DrawMineral(int i, Pen pen, Brush brush, Graphics graphics)
        {
            graphics.DrawRectangle(pen, tile[mineral[i].id].x - 1, tile[mineral[i].id].y - 1, 17, 17);
            graphics.FillRectangle(brush, tile[mineral[i].id].x, tile[mineral[i].id].y, 16, 16);
            this.pictureBox1.Image = cellm;
        }
        public void DrawFlora(Pen pen, Brush brush, Graphics graphics, int i)
        {
            if (flora[i].alive)
            {
                if (!flora[i].blossom)
                {
                    graphics.DrawRectangle(pen, tile[flora[i].id].x - 1, tile[flora[i].id].y - 1, 17, 17);
                    graphics.FillRectangle(brush, tile[flora[i].id].x, tile[flora[i].id].y, 16, 16);
                    return;
                }
                else
                {
                    graphics.DrawRectangle(orangepen, tile[flora[i].id].x - 1, tile[flora[i].id].y - 1, 17, 17);
                    graphics.FillRectangle(yellowbrush, tile[flora[i].id].x, tile[flora[i].id].y, 16, 16);
                }
            }
            this.pictureBox1.Image = cellm;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void эволюционнаяМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simulationtype = 1;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //5000 tick speed
            Move.Enabled = true;
            Move.Interval = 500;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //10000 tick speed
            Move.Enabled = true;
            Move.Interval = 1000;
        }
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //1000 tick speed
            Move.Enabled = true;
            Move.Interval = 100;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void освещенностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maptype = 2;
            for (int i = 0; i < mapsize; i++)
            {
                tilebrush = new SolidBrush(Color.FromArgb(Math.Min(tile[i].lightamount * 4, 255), Math.Min(tile[i].lightamount * 4, 255), 0));
                g.FillRectangle(tilebrush, tile[i].x - 1, tile[i].y - 1, 17, 17);
            }
            Move.Enabled = false;
        }
        private void видоваяКартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mapsize; i++)
            {
                tilebrush = new SolidBrush(Color.FromArgb(255, 255, 255));
                g.FillRectangle(tilebrush, tile[i].x - 1, tile[i].y - 1, 17, 17);
            }
            maptype = 0;
            Move.Enabled = true;
        }
        private void фотосинтезирующиеКлеткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mapsize; i++)
            {
                tilebrush = new SolidBrush(Color.FromArgb(255, 255, 255));
                g.FillRectangle(tilebrush, tile[i].x - 1, tile[i].y - 1, 17, 17);
            }
            maptype = 1;
            Move.Enabled = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                if (menuStrip1.Visible == true)
                    menuStrip1.Visible = false;
                else
                    menuStrip1.Visible = true;
            if (e.KeyValue == 32)
                Application.Exit();
        }
        
        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Move.Enabled = true;
            Move.Interval = 10;
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Move.Enabled = false;
        }
        private void x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Move.Enabled = true;
            Move.Interval = 1;
        }
        private void graphicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                textBox1.Visible = true;
                textBox1.BringToFront();
                textBox2.Visible = true;
                textBox2.BringToFront();
                textBox4.Visible = true;
                textBox4.BringToFront();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// стандартный субстрат
        /// </summary>
        void FReprodalgRED(int i, int direction, bool blossom)
        {
            for (int u = 0; u < floracount; u++)
                if (!flora[u].alive)
                {
                    flora[u] = new Flora(flora[i].id + direction, flora[i].value, 0, 0, true, blossom);
                    flora[i].birthdelay = 0;
                    tile[flora[u].id].filled = true;
                    alivefloracount++;
                    return;
                }
            flora[floracount + 1] = new Flora(flora[i].id + direction, flora[i].value, 0, 0, true, blossom);
            flora[i].birthdelay = 0;
            tile[flora[floracount + 1].id].filled = true;
            alivefloracount++;
            floracount++;
        }
        void FReprodalg(int i, int id)
        {
            if (tile[flora[i].id + id].filled)
                return;
            if (flora[i].birthdelay >= BIRTH_DELAY_F)
                FReprodalgRED(i, id, false);
        }
        void FloraMainAlgorithm()
        {
            if (alivefloracount + alivecellcount < mapsize * 2)
            {
                for (int i = 0; i < floracount; i++)
                {
                    if (flora[i].alive)
                    {
                        if (flora[i].birthdelay >= BIRTH_DELAY_F)
                        {
                            b = rnd.Next(0, 4);
                            switch (b)
                            {
                                case 0:
                                    if (tile[flora[i].id].x >= 1902)
                                    {
                                        FReprodalg(i, -95);
                                        goto case 4;
                                    }
                                    FReprodalg(i, 1);
                                    break;
                                case 1:
                                    if (tile[flora[i].id].x == 2)
                                    {
                                        FReprodalg(i, 95);
                                        goto case 4;
                                    }
                                    FReprodalg(i, -1);
                                    break;
                                case 2:
                                    if (tile[flora[i].id].y >= 1062)
                                    {
                                        FReprodalg(i, -5088);
                                        goto case 4;
                                    }
                                    FReprodalg(i, 96);
                                    break;
                                case 3:
                                    if (tile[flora[i].id].y == 2)
                                    {
                                        FReprodalg(i, 5088);
                                        goto case 4;
                                    }
                                    FReprodalg(i, -96);
                                    break;
                                case 4:
                                    break;
                            }
                        }
                        if (!flora[i].blossom)
                            flora[i].lifetime += lightamount / 2;
                        if (flora[i].lifetime > BLOSSOM_PERIOD && !flora[i].blossom)
                        {
                            flora[i].blossom = true;
                            flora[i].value *= BLOSSOM_ENERGY_FACTOR;
                        }
                        flora[i].birthdelay += lightamount;
                    }
                    DrawFlora(greenpen, greenbrush, g, i);
                }
            }
        }
        void HReprodalgRED(int i, int direction)
        {
            for (int u = 0; u < cellcount; u++)
            {
                if (!cell[u].state)
                {
                    cell[u] = new Cell(cell[i].id + direction, cell[i].maxlifetime, cell[i].maxlifetime, cell[i].maxsatiety, cell[i].maxsatiety / 2, 0, true);
                    cell[i].satiety /= REPRODUCTION_ENERGY_FACTOR;
                    cell[i].birthdelay = 0;
                    tile[cell[u].id].filled = true;
                    return;
                }
            }
            cell[cellcount + 1] = new Cell(cell[i].id + direction, cell[i].maxlifetime, cell[i].maxlifetime, cell[i].maxsatiety, cell[i].maxsatiety / 2, 0, true);
            tile[cell[cellcount + 1].id].filled = true;
            cell[i].satiety /= REPRODUCTION_ENERGY_FACTOR;
            cell[i].birthdelay = 0;
            cellcount++;
        }
        void HReprodalg(int i, int id)
        {
            if (tile[cell[i].id + id].filled)
                return;
            else if (cell[i].birthdelay >= BIRTH_DELAY_C)
                HReprodalgRED(i, id);
        }
        void HMovealg(int i, int id)
        {
            if (tile[cell[i].id + id].filled)
            {
                for (int u = 0; u < floracount; u++)
                {
                    if (flora[u].id == tile[cell[i].id + id].id && flora[u].alive)
                    {
                        tile[cell[i].id + id].filled = true;
                        tile[cell[i].id].filled = false;
                        cell[i].id += id;
                        cell[i].satiety += flora[u].value;
                        if (cell[i].satiety > cell[i].maxsatiety)
                        {
                            cell[i].birthdelay += cell[i].satiety - cell[i].maxsatiety;
                            cell[i].satiety = cell[i].maxsatiety;
                        }
                        cell[i].satiety -= MOVING_ENERGY_CONSUMPTION;
                        flora[u].alive = false;
                        flora[u].lifetime = 0;
                        flora[u].blossom = false;
                        return;
                    }
                    if (flora[u].id == tile[cell[i].id + id].id && !flora[u].alive)
                    {
                        tile[cell[i].id + id].filled = true;
                        tile[cell[i].id].filled = false;
                        cell[i].id += id;
                        cell[i].satiety -= MOVING_ENERGY_CONSUMPTION;
                        return;
                    }
                }
                return;
            }
            tile[cell[i].id + id].filled = true;
            tile[cell[i].id].filled = false;
            cell[i].id += id;
            cell[i].satiety -= MOVING_ENERGY_CONSUMPTION;

        }
        void CellMainAlgorithm()
        {
            for (int i = 0; i < cellcount; i++)
            {
                if (cell[i].lifetime < 0 && cell[i].state)
                {
                    cell[i].state = false;
                    tile[cell[i].id].filled = false;
                }
                DrawCell(i, eraserpen, eraserbrush, g);
                if (cell[i].state)
                {
                    a = rnd.Next(0, 4);
                    switch (a)
                    {
                        case 0:
                            if (tile[cell[i].id].x >= 1902)
                            {
                                HMovealg(i, -95);
                                goto case 4;
                            }
                            HMovealg(i, 1);
                            break;
                        case 1:
                            if (tile[cell[i].id].x == 2)
                            {
                                HMovealg(i, 95);
                                goto case 4;
                            }
                            HMovealg(i, -1);
                            break;
                        case 2:
                            if (tile[cell[i].id].y >= 1062)
                            {
                                HMovealg(i, -5088);
                                goto case 4;
                            }
                            HMovealg(i, 96);
                            break;
                        case 3:
                            if (tile[cell[i].id].y == 2)
                            {
                                HMovealg(i, 5088);
                                goto case 4;
                            }
                            HMovealg(i, -96);
                            break;
                        case 4:
                            break;
                    }
                    if (alivecellcount + alivefloracount < mapsize * 2 && cell[i].satiety > cell[i].maxsatiety / REPRODUCTION_ENERGY_FACTOR)
                    {
                        b = rnd.Next(0, 4);
                        switch (b)
                        {
                            case 0:
                                if (tile[cell[i].id].x >= 1902)
                                {
                                    HReprodalg(i, -95);
                                    goto case 4;
                                }
                                HReprodalg(i, 1);
                                break;
                            case 1:
                                if (tile[cell[i].id].x == 2)
                                {
                                    HReprodalg(i, 95);
                                    goto case 4;
                                }
                                HReprodalg(i, -1);
                                break;
                            case 2:
                                if (tile[cell[i].id].y >= 1062)
                                {
                                    HReprodalg(i, -5088);
                                    goto case 4;
                                }
                                HReprodalg(i, 96);
                                break;
                            case 3:
                                if (tile[cell[i].id].y == 2)
                                {
                                    HReprodalg(i, 5088);
                                    goto case 4;
                                }
                                HReprodalg(i, -96);
                                break;
                            case 4:
                                break;
                        }

                    }
                    if (cell[i].satiety <= 0 && cell[i].satiety >= -10)
                        cell[i].lifetime -= 3;
                    if (cell[i].satiety <= -10)
                        cell[i].lifetime -= 1000;
                    cell[i].lifetime--;
                    if (cell[i].birthdelay < BIRTH_DELAY_C)
                        cell[i].birthdelay++;
                    DrawCell(i, cellpen, cellbrush, g);
                }

            }
        }
        /// <summary>
        /// эволюционный субстрат
        /// </summary>
        void Cell2Reprodalg21(int i, int u, int id)
        {
            a = rnd.Next(0, Convert.ToInt32(100 / radiationfactor));
            if (a == 0)
            {
                random1 = rnd.Next(cell2[i].maxlifetime - 20, cell2[i].maxlifetime + 21);
                random2 = rnd.Next(cell2[i].maxsatiety - 20, cell2[i].maxsatiety + 21);
                random3 = rnd.Next(cell2[i].maxbirthdelay - 5, cell2[i].maxbirthdelay + 5);
                random4 = rnd.Next(0, Convert.ToInt32(100 / radiationfactor));
                if (random4 == 0)
                {
                    cell2[u] = new Cell2(cell2[i].id + id, random1, random1, random2, 128, random3, 0, true, !cell2[i].photosynthesis, cell2[i].carnivorous, cell2[i].red + random1*rnd.Next(0,3), cell2[i].green + random2*rnd.Next(0, 3), cell2[i].blue + random3*rnd.Next(0, 3));
                    cell2[i].satiety -= 200;
                    cell2[i].birthdelay = 0;
                    tile[cell2[u].id].filled = true;
                    speciescount++;
                    return;
                }
                if (random4 == 1)
                {
                    cell2[u] = new Cell2(cell2[i].id + id, random1, random1, random2, 128, random3, 0, true, cell2[i].photosynthesis, !cell2[i].carnivorous, cell2[i].red + random1, cell2[i].green + random2, cell2[i].blue + random3);
                    cell2[i].satiety -= 200;
                    cell2[i].birthdelay = 0;
                    tile[cell2[u].id].filled = true;
                    speciescount++;
                    return;
                }
                cell2[u] = new Cell2(cell2[i].id + id, random1, random1, random2, 128, random3, 0, true, cell2[i].photosynthesis, cell2[i].carnivorous, cell2[i].red + random1, cell2[i].green + random2, cell2[i].blue + random3);
                cell2[i].satiety -= 200;
                cell2[i].birthdelay = 0;
                tile[cell2[u].id].filled = true;
                speciescount++;
                return;
            }
            else
            {
                cell2[u] = new Cell2(cell2[i].id + id, cell2[i].maxlifetime, cell2[i].maxlifetime, cell2[i].maxsatiety, 128, cell2[i].maxbirthdelay, 0, true, cell2[i].photosynthesis, cell2[i].carnivorous, cell2[i].red, cell2[i].green, cell2[i].blue);
                cell2[i].satiety -= 200;
                cell2[i].birthdelay = 0;
                tile[cell2[u].id].filled = true;
                return;
            }
        }
        void Cell2Reprodalg2(int i, int id)
        {
            for (int u = 0; u < cellcount; u++)
            {
                if (!cell2[u].state)
                {
                    Cell2Reprodalg21(i, u, id);
                    return;
                }
            }
            Cell2Reprodalg21(i, cellcount + 1, id);
            cellcount++;
        }
        void Cell2Reprodalg(int i, int id)
        {
            if (tile[cell2[i].id + id].filled)
                return;
            else if (cell2[i].birthdelay >= cell2[i].maxbirthdelay && cell2[i].satiety >= 240)
                Cell2Reprodalg2(i, id);
        }
        void Cell2Movealg2(int i, int id)
        {
            tile[cell2[i].id + id].filled = true;
            tile[cell2[i].id].filled = false;
            cell2[i].id += id;
            cell2[i].satiety -= MOVING_ENERGY_CONSUMPTION;
        }
        bool RedGenomeCheck(int i, int u)
        {
            for (int z = cell2[u].red - 20; z < cell2[u].red + 20; z++)
                if (cell2[i].red == z)
                    return true;
            return false;
        }
        bool GreenGenomeCheck(int i, int u)
        {
            for (int z = cell2[u].green - 20; z < cell2[u].green + 20; z++)
                if (cell2[i].green == z)
                    return true;
            return false;
        }
        bool BlueGenomeCheck(int i, int u)
        {
            for (int z = cell2[u].blue - 20; z < cell2[u].blue + 20; z++)
                if (cell2[i].blue == z)
                    return true;
            return false;
        }
        void Cell2Movealg(int i, int id)
        {
            if (tile[cell2[i].id + id].filled)
            {
                for (int u = 0; u < cellcount; u++)
                {
                    if (cell2[u].id == tile[cell2[i].id + id].id)
                    {
                        if (cell2[u].state)
                        {
                            if (cell2[i].carnivorous)
                            {
                                if (!RedGenomeCheck(i, u) || !GreenGenomeCheck(i, u) || !BlueGenomeCheck(i, u) || cell2[u].photosynthesis != cell2[i].photosynthesis || cell2[u].carnivorous != cell2[i].carnivorous)
                                {
                                    Cell2Movealg2(i, id);
                                    cell2[i].satiety += cell2[u].satiety;
                                    if (cell2[i].satiety > cell2[i].maxsatiety)
                                    {
                                        cell2[i].birthdelay += cell2[i].satiety - cell2[i].maxsatiety;
                                        cell2[i].satiety = cell2[i].maxsatiety;
                                    }
                                    cell2[u].state = false;
                                    return;
                                }
                                else
                                    return;
                            }
                            else
                                return;
                        }
                        else
                            Cell2Movealg2(i, id);
                        return;
                    }
                }
                for (int u = 0; u < maxmineral; u++)
                {
                    if (mineral[u].id == tile[cell2[i].id + id].id)
                    {
                        Cell2Movealg2(i, id);
                        if (cell2[i].photosynthesis)
                        {
                            cell2[i].satiety += mineral[u].value/4;
                            mineral[u].state = false;
                            return;
                        }
                        cell2[i].satiety = cell2[i].maxsatiety;
                        mineral[u].state = false;
                        return;
                    }
                }
                return;
            }
            Cell2Movealg2(i, id);
        }
        void MineralSpawning()
        {
            for (int i = 0; i < maxmineral; i++)
            {
                while (!mineral[i].state)
                {
                    a = rnd.Next(mapsize / 2, mapsize);
                    if (!tile[a].filled)
                    {
                        DrawMineral(i, eraserpen, eraserbrush, g);
                        mineral[i] = new Mineral(tile[a].id, 64, true);
                        DrawMineral(i, orangepen, yellowbrush, g);
                        tile[a].filled = true;
                    }
                }
            }

        }
        void Cell2MainAlgorithm()
        {
            for (int i = 0; i < cellcount; i++)
            {
                if (cell2[i].lifetime < 0 && cell2[i].state)
                {
                    cell2[i].state = false;
                    tile[cell2[i].id].filled = false;
                }
                DrawCell2(i, eraserpen, eraserbrush, g);
                if (cell2[i].state)
                {
                    a = rnd.Next(0, 4);
                    switch (a)
                    {
                        case 0:
                            if (tile[cell2[i].id].x >= 1902)
                            {
                                Cell2Movealg(i, -95);
                                goto case 4;
                            }
                            Cell2Movealg(i, 1);
                            break;
                        case 1:
                            if (tile[cell2[i].id].x == 2)
                            {
                                Cell2Movealg(i, 95);
                                goto case 4;
                            }
                            Cell2Movealg(i, -1);
                            break;
                        case 2:
                            if (tile[cell2[i].id].y >= 1062)
                            {
                                goto case 4;
                            }
                            Cell2Movealg(i, 96);
                            break;
                        case 3:
                            if (tile[cell2[i].id].y == 2)
                            {
                                goto case 4;
                            }
                            Cell2Movealg(i, -96);
                            break;
                        case 4:
                            break;
                    }
                    if (alivecellcount < mapsize * 2)
                    {
                        b = rnd.Next(0, 4);
                        switch (b)
                        {
                            case 0:
                                if (tile[cell2[i].id].x >= 1902)
                                {
                                    Cell2Reprodalg(i, -95);
                                    goto case 4;
                                }
                                Cell2Reprodalg(i, 1);
                                break;
                            case 1:
                                if (tile[cell2[i].id].x == 2)
                                {
                                    Cell2Reprodalg(i, 95);
                                    goto case 4;
                                }
                                Cell2Reprodalg(i, -1);
                                break;
                            case 2:
                                if (tile[cell2[i].id].y >= 1062)
                                {
                                    goto case 4;
                                }
                                Cell2Reprodalg(i, 96);
                                break;
                            case 3:
                                if (tile[cell2[i].id].y == 2)
                                {
                                    goto case 4;
                                }
                                Cell2Reprodalg(i, -96);
                                break;
                            case 4:
                                break;
                        }
                    }
                    if (cell2[i].satiety <= 0 && cell2[i].satiety >= -10)
                        cell2[i].lifetime -= 3;
                    if (cell2[i].satiety <= -10)
                        cell2[i].lifetime -= 1000;
                    cell2[i].lifetime--;
                    if (cell2[i].birthdelay < cell2[i].maxbirthdelay)
                        cell2[i].birthdelay++;
                    if (cell2[i].photosynthesis)
                        cell2[i].satiety += tile[cell2[i].id].lightamount - PHOTOSYNTHESIS_PENALTY;
                    if (cell2[i].carnivorous)
                        cell2[i].satiety -= CARNIVOROUS_PENALTY;
                    if (cell2[i].carnivorous && cell2[i].photosynthesis)
                        cell2[i].satiety -= OMNIVOROUS;
                    ColorCheck(i);
                    cell2brush = new SolidBrush(Color.FromArgb(cell2[i].red, cell2[i].green, cell2[i].blue));
                    cell2pen = new Pen(Color.FromArgb(Math.Min(cell2[i].red + 20, 255), Math.Min(cell2[i].green + 20, 255), Math.Min(cell2[i].blue + 20, 255)));
                    if (maptype == 0)
                        DrawCell2(i, cell2pen, cell2brush, g);
                    if (maptype == 1)
                    {
                        if (cell2[i].photosynthesis && cell2[i].carnivorous)
                        {
                            cell2brush = new SolidBrush(Color.FromArgb(255, 255, 0));
                            cell2pen = new Pen(Color.FromArgb(255, 255, 0));
                            DrawCell2(i, cell2pen, cell2brush, g);
                        }
                        if (cell2[i].photosynthesis && !cell2[i].carnivorous)
                        {
                            cell2brush = new SolidBrush(Color.FromArgb(0, 255, 0));
                            cell2pen = new Pen(Color.FromArgb(0, 255, 0));
                            DrawCell2(i, cell2pen, cell2brush, g);
                        }
                        if (!cell2[i].photosynthesis && cell2[i].carnivorous)
                        {
                            cell2brush = new SolidBrush(Color.FromArgb(255, 0, 0));
                            cell2pen = new Pen(Color.FromArgb(255, 0, 0));
                            DrawCell2(i, cell2pen, cell2brush, g);
                        }
                        if (!cell2[i].photosynthesis && !cell2[i].carnivorous)
                        {
                            DrawCell2(i, graypen, graybrush, g);
                        }
                    }

                }

            }
        }
        void ColorCheck(int i)
        {
            if (cell2[i].red > 255)
                cell2[i].red = rnd.Next(0, 255);
            if (cell2[i].red < 0)
                cell2[i].red = rnd.Next(0, 255);
            if (cell2[i].green > 255)
                cell2[i].green = rnd.Next(0, 255);
            if (cell2[i].green < 0)
                cell2[i].green = rnd.Next(0, 255);
            if (cell2[i].blue > 255)
                cell2[i].blue = rnd.Next(0, 255);
            if (cell2[i].blue < 0)
                cell2[i].blue = rnd.Next(0,255);
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            milliseconds++;
            if (milliseconds % 100 == 0)
            {
                seconds++;
                milliseconds = 0;
            }
            if (milliseconds / 10 == 10 && seconds / 10 == 0)
                textBox1.Text = "Времени прошло: 0" + seconds + ":" + "0" + milliseconds;
            else if (milliseconds / 10 == 10)
                textBox1.Text = "Времени прошло: " + seconds + ":" + "0" + milliseconds;
            else if (seconds / 10 == 10)
                textBox1.Text = "Времени прошло: 0" + seconds + ":" + milliseconds;
            else
                textBox1.Text = "Времени прошло: " + seconds + ":" + milliseconds;
        }
        public void ClearImage()
        {
            Graphics g = Graphics.FromImage(graphicsmap);
            g.Clear(Color.FromArgb(240, 240, 240));
        }
        private void Move_Tick(object sender, EventArgs e)
        {
            if (simulationtype == 0)
            {
                Clock.Interval = Move.Interval;
                if (!Move.Enabled)
                    Clock.Enabled = false;
                precountF = alivefloracount;
                precount = alivecellcount;
                alivecellcount = 0;
                alivefloracount = 0;
                for (int i = 0; i < cellcount; i++)
                    if (cell[i].state)
                        alivecellcount++;
                for (int i = 0; i < floracount; i++)
                    if (flora[i].alive)
                        alivefloracount++;
                CellMainAlgorithm();
                if (time1 > pictureBox2.Width * 2)
                {
                    time1 = 0;
                    ClearImage();
                }
                pretime = time1;
                time1++;
                FloraMainAlgorithm();
                DrawGLine(graphpenc, pretime / 2, (pictureBox2.Height - precount / 4), time1 / 2, (pictureBox2.Height - alivecellcount / 4), graphics);
                DrawGLine(graphpenf, pretime / 2, (pictureBox2.Height - precountF / 8), time1 / 2, (pictureBox2.Height - alivefloracount / 8), graphics);
                DrawGLine(redpen, pretime / 2, (pictureBox2.Height - precountF / 8 - precount / 4), time1 / 2, (pictureBox2.Height - alivefloracount / 8 - alivecellcount / 4), graphics);
                this.pictureBox2.Image = graphicsmap;
                textBox2.Text = "Хищник: " + alivecellcount.ToString();
                textBox4.Text = "Жертва: " + alivefloracount.ToString();
            }
            if (simulationtype == 1)
            {
                Cell2MainAlgorithm();
                MineralSpawning();
                if (time1 > pictureBox2.Width * 2)
                {
                    time1 = 0;
                    ClearImage();
                }
                pretime = time1;
                time1++;
                precount = alivecellcount;
                precountF = speciescount;
                alivecellcount = 0;
                mineralcount = 0;
                for (int i = 0; i < cellcount; i++)
                {
                    if (cell2[i].state)
                        alivecellcount++;
                }
                for (int i = 0; i < maxmineral; i++)
                    if (mineral[i].state)
                        mineralcount++;
                DrawGLine(graphpenc, pretime / 2, (pictureBox2.Height - precount / 4), time1 / 2, (pictureBox2.Height - alivecellcount / 4), graphics);
                DrawGLine(graphpenf, pretime / 2, (pictureBox2.Height - precountF / 8), time1 / 2, (pictureBox2.Height - alivefloracount / 8), graphics);
                this.pictureBox2.Image = graphicsmap;
                textBox2.Text = "Популяция: " + alivecellcount.ToString();
                textBox4.Text = "Видовое разнообразие: " + speciescount.ToString();
            }
        }

    }





}
