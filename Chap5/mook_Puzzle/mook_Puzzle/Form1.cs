using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int level = 3; //이미지 조각 수
        private Rectangle[,] DrawPoint;  //폼에 그릴 좌표
        private Rectangle[,] ImagePoint; //이미지 각 조각의 좌표
        private int emptyX, emptyY; //빈 공간 좌표
        private int[,] MixNum; //섞인 이미지 번호
        private Bitmap bitImage; //비트맵 클래스
        private bool game = false; //이미지 로드
        private bool GameStart = false; //게임 시작
        private int count, counter; // 카운터 수,조각 이동 수

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!game) //이미지가 bitImage 객체에 저장되었을 때
            {
                return;
            }
            if (!GameStart) //시작 버튼을 누르기 전
            {

                //원본 이미지 출력
                for (int i = 0; i < this.level; i++)
                {
                    for (int j = 0; j < this.level; j++)
                    {
                        int a = this.MixNum[i, j] / this.level;
                        int b = this.MixNum[i, j] % this.level;
                        e.Graphics.DrawImage(bitImage, this.DrawPoint[a, b], 
                            this.ImagePoint[a, b], GraphicsUnit.Pixel);
                    }
                }
            }
            else
            {
                ControlEnabledF(); //ControlEnabledF()메서드 호출
                this.timer.Start(); //timer 컨트롤의 Start()메서드 실행

                //조각난 이미지 출력
                for (int i = 0; i < this.level; i++)
                {
                    for (int j = 0; j < this.level; j++)
                    {
                        int a = this.MixNum[i, j] / this.level;
                        int b = this.MixNum[i, j] % this.level;
                        e.Graphics.DrawImage(bitImage, this.DrawPoint[i, j], 
                            this.ImagePoint[a, b], GraphicsUnit.Pixel);
                    }
                }
                ImageEmpty(this.emptyX, this.emptyY);
            }
        }

        private void ControlEnabledT()
        {
            //toolBar1 컨트롤의 버튼 비활성화
            this.tsbtnBeginner.Enabled = true;
            this.tsbtnIntermediate.Enabled = true;
            this.tsbtnExpert.Enabled = true;
            //button 컨트롤의 비활성화
            this.btnStart.Enabled = true;
            this.btnReStart.Enabled = true;
            //mainMenu1 컨트롤의 일부 메뉴 비활성화
            this.새게임NToolStripMenuItem.Enabled = true;
            this.열기OToolStripMenuItem.Enabled = true;
            this.초급ToolStripMenuItem.Enabled = true;
            this.중급ToolStripMenuItem.Enabled = true;
            this.고급ToolStripMenuItem.Enabled = true;
        }

        private void ControlEnabledF()
        {
            //toolBar1 컨트롤의 버튼 활성화
            this.tsbtnOpen.Enabled = false;
            this.tsbtnBeginner.Enabled = false;
            this.tsbtnIntermediate.Enabled = false;
            this.tsbtnExpert.Enabled = false;
            //button 컨트롤의 활성화
            this.btnStart.Enabled = false;
            //mainMenu1 컨트롤의 일부 메뉴 활성화
            this.열기OToolStripMenuItem.Enabled = false;
            this.초급ToolStripMenuItem.Enabled = false;
            this.중급ToolStripMenuItem.Enabled = false;
            this.고급ToolStripMenuItem.Enabled = false;
        }

        private void ImageRandom()
        {
            this.DrawPoint = new Rectangle[this.level, this.level]; //2차원 배열 DrawPoint를 인스턴스화
            this.ImagePoint = new Rectangle[this.level, this.level];  //2차원 배열 ImagePoint를 인스턴스화

            this.MixNum = new int[this.level, this.level]; //2차원 배열 MixNum를 인스턴스화

            int X = (400) / this.level;
            int Y = (400) / this.level;

            for (int i = 0; i < this.level; i++)
            {
                for (int j = 0; j < this.level; j++)
                {
                    this.DrawPoint[i, j] = new Rectangle(j * X + 20, i * Y + 50, X, Y); //2차원 배열에 그려질 이미지 사각형의 크기와 위치 저장
                    this.ImagePoint[i, j] = new Rectangle(j * X, i * Y, X, Y); //2차원 배열에 실제 이미지 사각형의 크기와 위치 저장
                }
            }

            Random ra = new Random(); //난수 생성기
            int[] arrayMax = new int[25]; //최대 5*5
            int su = 0;
            int imgMax = this.level * this.level - 1;

            bool bRand;

            for (int i = 0; i <= imgMax; i++) //조각난 이미지 수만큼 루프를 실행
            {
                bRand = true;
                while (bRand)
                {
                    bRand = false;
                    su = ra.Next(imgMax + 1); //0 <= su < imgMax+1 

                    for (int j = 0; j < i; j++) //arrayMax 배열을 처음부터 j<i 까지 검색
                    {
                        if (arrayMax[j] == su) //배열에 같은 난수가 저장되지 않게하는 조건문
                        {
                            bRand = true;
                            break; //이미 저장된 배열값과 난수 값이 같으면 while 루프 실행
                        }
                    }
                }

                arrayMax[i] = su; //난수 저장
                this.MixNum[i / this.level, i % this.level] = su; //2차원에 난수 저장

                if (imgMax == su) //조각난 수-1 과 난수가 같을 때
                {
                    this.emptyX = i / this.level;
                    this.emptyY = i % this.level;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!game)
            {
                return;
            }
            if (GameStart)
            {
                int mX = -1, mY = 0;

                for (int i = 0; i < this.level; i++)
                {
                    for (int j = 0; j < this.level; j++)
                    {
                        if (this.DrawPoint[i, j].Contains(e.X, e.Y)) //클릭된 영역이 화면의 어느곳에 속하는지
                        {
                            mX = i;
                            mY = j;
                        }
                    }
                }

                if (mX == -1) //조각 이미지에 커서가 없을 때
                {
                    return;
                }
                else if (mX == this.emptyX && mY == this.emptyY) //빈 공간 클릭
                {
                    return;
                }
                else if (!(((mX == this.emptyX) && Math.Abs(mY - this.emptyY) == 1) ||
                    ((mY == this.emptyY) && Math.Abs(mX - this.emptyX) == 1))) //빈 공간의 대각선 방향의 이미지를 클릭했을 때
                {
                    return;
                }

                Graphics g = this.CreateGraphics(); //Graphics 객체의 인스턴스 생성

                int gx = this.MixNum[mX, mY] / this.level;
                int gy = this.MixNum[mX, mY] % this.level;
                g.DrawImage(this.bitImage, this.DrawPoint[this.emptyX, this.emptyY], this.ImagePoint[gx, gy], GraphicsUnit.Pixel);

                this.MixNum[this.emptyX, this.emptyY] = this.MixNum[mX, mY];
                this.MixNum[mX, mY] = this.level * this.level - 1;

                this.emptyX = mX;
                this.emptyY = mY;
                ImageEmpty(this.emptyX, this.emptyY);
                OkCheck();
            }
        }

        private void ImageEmpty(int x, int y)
        {
            Graphics g = this.CreateGraphics(); //Graphics 클래스의 g 인스턴스 생성
            g.FillRectangle(new SolidBrush(Color.White), DrawPoint[x, y]); //지정된 사각형 내부를 지정된 형식에 의해 채움
        }

        private void OkCheck()
        {
            counter++; //이동수 증가 증가
            this.txtAction.Text = "이동수 " + counter.ToString() + "번";
            int n = 0;
            for (int a = 0; a < this.level; a++)
            {
                for (int b = 0; b < this.level; b++)
                {
                    if (this.MixNum[a, b] != n) return;
                    n++;
                }
            }
            timer.Stop();
            if (MessageBox.Show("성공하셨습니다.!! 한번 더 하겠습니까??", "성공추카", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GameStart = true;
                ImageRandom();
                Invalidate(); //Form1_Paint 호출
            }
            else
            {
                this.Close();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 60; //1분
            counter = 0; //이동수 초기화
            count = count * (this.level - 1);
            GameStart = true;
            this.ControlEnabledT(); //ControlEnabledT() 메서드 호출
            Invalidate(); //Form1_Paint 호출
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            count = 60; //1분
            counter = 0; //이동수 초기화
            this.timer.Stop(); //Stop() 메서드를 통하여 타이머 중지
            count = count * (this.level - 1);
            GameStart = true;
            ImageRandom(); //ImageRnadom() 메서드 호출
            Invalidate(); //Form1_Paint 호출
        }

        private void 새게임NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.txtTime.Text = "";
            this.txtAction.Text = "";
            GameStart = false;
            btnReStart.Enabled = false;
            tsbtnOpen.Enabled = true;
            새게임NToolStripMenuItem.Enabled = false;
            열기OToolStripMenuItem.Enabled = true;
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 닫기
        }

        private void tsbtnBeginner_Click(object sender, EventArgs e)
        {
            this.level = 3; //3*3
            GameStart = false; //게임 시작 전
            //이루 메뉴 체크 박스 체크 및 해제
            this.초급ToolStripMenuItem.Checked = true;
            this.중급ToolStripMenuItem.Checked = false;
            this.고급ToolStripMenuItem.Checked = false;
            ImageRandom(); //ImageRandom() 메서드 호출
        }

        private void tsbtnIntermediate_Click(object sender, EventArgs e)
        {
            this.level = 4; //4*4
            GameStart = false; //게임 시작 전
            //이루 메뉴 체크 박스 체크 및 해제
            this.초급ToolStripMenuItem.Checked = false;
            this.중급ToolStripMenuItem.Checked = true;
            this.고급ToolStripMenuItem.Checked = false;
            ImageRandom(); //ImageRandom() 메서드 호출
        }

        private void tsbtnExpert_Click(object sender, EventArgs e)
        {
            this.level = 5; //5*5
            GameStart = false;//게임 시작 전
            //이루 메뉴 체크 박스 체크 및 해제
            this.초급ToolStripMenuItem.Checked = false;
            this.중급ToolStripMenuItem.Checked = false;
            this.고급ToolStripMenuItem.Checked = true;
            ImageRandom(); //ImageRandom() 메서드 호출
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            if (this.ofdIamgeopen.ShowDialog() == DialogResult.OK)
            {
                bitImage = new Bitmap(Image.FromFile(this.ofdIamgeopen.FileName), 400, 400); //bitImage 객체에 이미지 저장
                this.pictureBox.Image = bitImage; //pictureBox 컨트롤에 이미지 로드
                game = true;
                GameStart = false;
                ImageRandom(); //ImageRandom() 메서드 호출
                this.btnStart.Enabled = true;
                this.tsbtnBeginner.Enabled = true;
                this.tsbtnIntermediate.Enabled = true;
                this.tsbtnExpert.Enabled = true;
                this.초급ToolStripMenuItem.Enabled = true;
                this.초급ToolStripMenuItem.Checked = true;
                this.중급ToolStripMenuItem.Enabled = true;
                this.고급ToolStripMenuItem.Enabled = true;
                Invalidate(); //Form1_Paint 호출
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count--; //카운트 감소
            this.txtTime.Text = "남은시간 " + count.ToString() + "초";

            if (count == 0)
            {
                timer.Stop();
                if (MessageBox.Show("시간이 만료되었네요! 다시 시작하겠습니까?", "실패하였습니다.", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    count = 60; //1분
                    counter = 0; //이동수 초기화
                    count = count * (this.level - 1);
                    GameStart = true;
                    ImageRandom();
                    Invalidate();
                }
                else
                {
                    this.Close();
                }
            }
        }

    }
}
