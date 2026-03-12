using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 게임 점수 저장용 필드(기본값 0)
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void CatchmeButton_Click(object sender, EventArgs e)
        {
            // 메시지박스가 표시될 때 소리 재생
            System.Media.SystemSounds.Asterisk.Play();


            score += 100; //score를 100 증가

            // 버튼 클릭 시 메시지 박스 표시
            MessageBox.Show(" 축하합니다 ~ ! ");

            int minSize = 20; //최소 버튼 크기 설정
            int newWidth = Math.Max(minSize, (int)(CatchmeButton.Width * 0.9));
            int newHeight = Math.Max(minSize, (int)(CatchmeButton.Height * 0.9)); //높이와 너비를 10%씩 줄이지만 최소 크기보다 작아지지 않도록 설정
            CatchmeButton.Size = new Size(newWidth, newHeight); //높이와 너비를 버튼크기에 적용




        }

        private void CatchmeButton_MouseEnter(object sender, EventArgs e)
        {

            // 점수가 -200 이하로 내려가면 게임오버 처리: 메시지 출력 후 모든 버튼 비활성화
            if (score <= -200)
            {
                MessageBox.Show("GameOver");
                CatchmeButton.Enabled = false;
                // RestartButton이 있으면 활성화
                try
                {
                    RestartButton.Enabled = true;
                }
                catch
                {
                    // 무시
                }
                return; // 더 이상 버튼을 이동시키지 않음
            }

            //1. 난수 생성기 준비
            Random rd = new Random();

            //2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            //3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX - CatchmeButton.Width);
            int nextY = rd.Next(0, maxY - CatchmeButton.Height);//버튼의 크기만큼 빼줘야 버튼이 폼 밖으로 나가지 않음

            //4. 위치 할당(새로운 Point 객체 생성)
            CatchmeButton.Location = new Point(nextX, nextY);

            score -= 10; //마우스가 버튼을 놓치고 지나갈 때마다 점수를 10점씩 감소

            System.Media.SystemSounds.Exclamation.Play(); //버튼을 놓칠 때마다 소리 재생

            //5. 시각적 피드백 (폼 제목 표시줄에 좌표 및 점수출력)
            this.Text = $"버튼위치 : ({nextX}, {nextY}), 점수 : [{score.ToString()}]";//점수는 문자열로 변환해서 출력





        }

        private void Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            // 점수 초기화
            score = 0;
            this.Text = $" 점수 : [{score.ToString()}]";


            // CatchmeButton 재활성화 및 크기/폰트 초기화
            CatchmeButton.Enabled = true;
            CatchmeButton.Size = new Size(234, 155);


            // Restart 버튼 비활성화
            try
            {
                RestartButton.Enabled = false;
            }
            catch
            {
                // 무시
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
