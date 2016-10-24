using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int[] list = Enumerable.Range(0, 49).OrderBy(o => rand.Next()).ToArray();

            //서버에서 어떻게 받아오는지 알아야 할 수 있음
            

            int receive_from_server = 15;//(블럭생성개수)
            PictureBox[] PictureBox_Num = new PictureBox[255];
            for (int i = 0; i < receive_from_server; ++i)
            {
                for (int j = 0; j < receive_from_server; ++j)
                {
                    int seed = Environment.TickCount;
                    Random r = new Random(seed++);
                    int rand_num = r.Next(0, 49);
                    PictureBox_Num[i] = new PictureBox();
                    PictureBox_Num[i].Size = new Size(50, 50);
                    PictureBox_Num[i].Location = new Point(0, 0);

                    Controls.Add(PictureBox_Num[i]);
                    if (list[rand_num] >= 0 && list[rand_num] <= 8)
                    {
                        //아이템:물풍선 개수 증가 할당.
                    }
                    else if (list[rand_num] >= 9 && list[rand_num] <= 17)
                    {
                        //아이템:이동 속도 증가 할당.
                    }
                    else if (list[rand_num] >= 18 && list[rand_num] <= 26)
                    {
                        //아이템:풍선의 화력 증가 할당.
                    }
                    else if (list[rand_num] >= 27 && list[rand_num] <= 27)
                    {
                        //아이템:탈것_부엉이 할당.
                    }
                    else if (list[rand_num] >= 28 && list[rand_num] <= 30)
                    {
                        //아이템:탈것_거북이_느린거북이 할당.
                    }
                    else if (list[rand_num] >= 31 && list[rand_num] <= 31)
                    {
                        //아이템:탈것_거북이_빠른거북이 할당.
                    }
                    else if (list[rand_num] >= 32 && list[rand_num] <= 35)
                    {
                        //아이템:바늘 할당.
                    }
                    else if (list[rand_num] >= 36 && list[rand_num] <= 39)
                    {
                        //아이템:무적 할당.
                    }
                    else if (list[rand_num] >= 40 && list[rand_num] <= 49)
                    {
                        //아이템 없음:빈 블럭.
                    }
                }
            }

            InitializeComponent();

        }

        
        public class receive
        {
            public int block_x=0;
            public int block_y=0;
            int block_type=0;
            /*
             * 0:부술 수 있는 블럭
             * 1:부술 수 없는 블럭
            */


        }
        

        
        public class Blocks
        {
            public int x=0;
            public int y=0;
            public int item_info=0;
            /*
             * 0 : no item
             * 1 : 물풍선 개수 증가
             * 2 : 이동 속도 증가
             * 3 : 물풍선 화력 증가
             * 4 : 탈것:부엉이
             * 5 : 탈것:느린거북이
             * 6 : 탈것:빠른거북이
             * 7 : 물풍선에 갇혔을때 탈출가능한 바늘
             * 8 : 2초동안 무적 
            */
            public int block_type=0;
            /*
             * 0 : 부술 수 있는 블럭
             * 1 : 부술 수 없는 블럭
             * 2 : 옮길 수 있는 블럭
            */
            public int block_image=0;
            /*
             * 이건 이미지 받으면 나중에 추가하는걸로
            */

        }

        

    }

}
