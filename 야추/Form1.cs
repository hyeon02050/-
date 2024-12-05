using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 야추
{
    public partial class YachtKing : Form
    {
        int diceA = 0, diceB = 0, diceC = 0, diceD = 0, diceE = 0; //1번째 주사위부터 5번째 주사위까지의 값
        private int sum1 = 0; //1끼리의 합의 정수
        private int sum2 = 0; //2끼리의 합의 정수
        private int sum3 = 0; //3끼리의 합의 정수
        private int sum4 = 0; //4끼리의 합의 정수
        private int sum5 = 0; //5끼리의 합의 정수
        private int sum6 = 0; //6끼리의 합의 정수
        private int choice_sum = 0; //눈 전체의 합의 정수
        private int fourOfAKind_sum = 0; // 동일한 눈 4개의 정수
        private int fullHouse_sum = 0; // 같은 3개, 2개의 정수
        private int littleStraight_sum = 0; // 눈이 각각 1,2,3,4,5일 때의 정수
        private int bigStraight_sum = 0; // 각각 2,3,4,5,6일 때의 정수
        private int yacht_sum = 0; //동일한 주사위 눈이 5개일 때의 정수
        private int ReRollValue = 0; //주사위 리롤 횟수
        private int timeElapsed = 0; // 주사위 리롤 경과 시간
        private Random random = new Random(); //랜덤 함수
        private bool Dice1Lock = false; //1번째 주사위 잠금
        private bool Dice2Lock = false; //2번째 주사위 잠금
        private bool Dice3Lock = false; //3번째 주사위 잠금
        private bool Dice4Lock = false; //4번째 주사위 잠금
        private bool Dice5Lock = false; //5번째 주사위 잠금
        private bool isOnesFixed = false;  // Ones 점수 고정 
        private bool isTwosFixed = false;  // Twos 점수 고정 
        private bool isThreesFixed = false;  // Threes 점수 고정 
        private bool isFoursFixed = false;  // Fours 점수 고정 
        private bool isFivesFixed = false;  // Fives 점수 고정 
        private bool isSixesFixed = false;  // Sixes 점수 고정 
        private bool isChoiceFixed = false;  // Choice 점수 고정 
        private bool isFourOfAKindFixed = false;  // FourOfAKind 점수 고정 
        private bool isFullHouseFixed = false;  // FullHouse 점수 고정 
        private bool isLittleStraightFixed = false;  // LittleStraight 점수 고정 
        private bool isBigStraightFixed = false;  // BigStraight 점수 고정 
        private bool isYachtFixed = false;  // Yacht 점수 고정 
        private int selectedCategory = -1; //선택 완료 값
        private int User_HP = 100;
        private int User_Attack = 0;
        private int User_Defense = 0;
        private int User_DefenseStack = 0;
        private int Defense = 0; //임시로 디펜스를 저장하는 수
        private int Monster_Attack; //몬스터 공격력 저장하는 함수
        private int Monster_Defense; //몬스터 방어력 저장하는 함수
        private int Monster_HP; //몬스터 HP 저장하는 함수
        private int Monster; //몬스터 랜덤 지정 함수
        private string Monster_Name; //몬스터 이름를 저장하는 함수
        private int Monster_DefenseStack;//몬스터 누적 방어력
        private int Score = 0; //점수 
        private int count = 1;
        private int Delay_Delete =0;

        private void AddNarration(String text) //Narration을 출력하기위한 함수
        {
            Narration.AppendText(text + Environment.NewLine);
            Narration.ScrollToCaret(); //텍스트 박스가 스크롤 될 수 있게 함
        }
        private void User_Information(int? attack = null, int? defense = null, int? hpchange = null) //유저 정보를 관리(int?로 int에 null값을 가질 수 있게 만듬)
        {
            if (attack.HasValue) // null값 예외를 방지하기 위해 HaValue를 씀
            {
                User_Attack = attack.Value;  //유저의 공격력
            }

            if (defense.HasValue)
            {
                User_Defense += defense.Value; //유저의 방어력, 누적되게 설정하였음
            }

            if (hpchange.HasValue)
            {
                User_HP += hpchange.Value; //유저의 HP
                if (User_HP < 0) User_HP = 0; //유저의 HP가 0이하로 안떨어지게 함
            }
        }

        public YachtKing()
        {
            InitializeComponent();
            ReRollCount.Text = "0/3";
            ShowScore();
        }
        private void DiceRoll_Tick(object sender, EventArgs e) //주사위 타이머로 돌렸을 때
        {
            ResetScoreLock(); //모든 값이 다 잠겼을 경우, 모든 잠금 비활성화
            timeElapsed += 100; //0.1초에 한 번 출력
            ResetScore();
            if (!Dice1Lock)
            {
                int RandomIndex1 = random.Next(imageList1.Images.Count);
                diceA = RandomIndex1 + 1;
                Dice1.BackgroundImage = imageList1.Images[RandomIndex1];
            } //1번째 주사위가 잠기지 않은 경우
            if (!Dice2Lock)
            {
                int RandomIndex2 = random.Next(imageList1.Images.Count);
                diceB = RandomIndex2 + 1;
                Dice2.BackgroundImage = imageList1.Images[RandomIndex2];
            } //2번째 주사위가 잠기지 않은 경우
            if (!Dice3Lock)
            {
                int RandomIndex3 = random.Next(imageList1.Images.Count);
                diceC = RandomIndex3 + 1;
                Dice3.BackgroundImage = imageList1.Images[RandomIndex3];
            } //3번째 주사위가 잠기지 않은 경우
            if (!Dice4Lock)
            {
                int RandomIndex4 = random.Next(imageList1.Images.Count);
                diceD = RandomIndex4 + 1;
                Dice4.BackgroundImage = imageList1.Images[RandomIndex4];
            } //4번째 주사위가 잠기지 않은 경우
            if (!Dice5Lock)
            {
                int RandomIndex5 = random.Next(imageList1.Images.Count); //이미지를 랜덤 설정하는 함수
                diceE = RandomIndex5 + 1;
                Dice5.BackgroundImage = imageList1.Images[RandomIndex5];
            } //5번째 주사위가 잠기지 않은 경우
            //위의 랜덤 함수로 주사위의 이미지를 출력
            int[] diceValues = { diceA, diceB, diceC, diceD, diceE }; //1번째 주사위부터 5번째 주사위까지 값으로 배열
            if (!isOnesFixed) sum1 += diceValues.Count(dice => dice == 1); //1의 합
            if (!isTwosFixed) sum2 += diceValues.Count(dice => dice == 2) * 2; //2의 합
            if (!isThreesFixed) sum3 += diceValues.Count(dice => dice == 3) * 3; //3의 합
            if (!isFoursFixed) sum4 += diceValues.Count(dice => dice == 4) * 4; //4의 합
            if (!isFivesFixed) sum5 += diceValues.Count(dice => dice == 5) * 5; //5의 합
            if (!isSixesFixed) sum6 += diceValues.Count(dice => dice == 6) * 6; //6의 합
            if (!isChoiceFixed) choice_sum = diceValues.Sum(); //모든 값의 합
            var fourOfAKind_grouped = diceValues.GroupBy(d => d)   // 값별로 그룹화
                            .Where(g => g.Count() == 4)  // 4개 동일한 값 찾기
                            .Select(g => g.Key)
                            .FirstOrDefault();// 동일한 값만 추출
            if (fourOfAKind_grouped != 0)  // 4개 동일한 값이 있으면
            {
                // 4개 동일한 값이 있으면 그 값을 4배 곱해 출력
                if (!isChoiceFixed) fourOfAKind_sum = fourOfAKind_grouped * 4;
            }

            var fullHouse_grouped = diceValues.GroupBy(d => d)
                                     .Where(g => g.Count() == 3 || g.Count() == 2)
                                     .ToList(); // 3개와 2개 그룹화
                                                // 풀 하우스는 정확히 3개 동일 + 2개 동일해야 함
            if (fullHouse_grouped.Count == 2 &&
                fullHouse_grouped.Any(g => g.Count() == 3) && // 3개 동일한 값이 있어야 함
                fullHouse_grouped.Any(g => g.Count() == 2)) // 2개 동일한 값이 있어야 함
            {
                var threeOfAKind = fullHouse_grouped.First(g => g.Count() == 3).Key; // 3개 동일한 값
                var pair = fullHouse_grouped.First(g => g.Count() == 2).Key; // 2개 동일한 값
                if (!isFullHouseFixed) fullHouse_sum = (threeOfAKind * 3) + (pair * 2); // 3개와 2개를 합산하여 점수 계산
            }

            bool littleStraight = new[] { 1, 2, 3, 4, 5 }.All(value => diceValues.Contains(value));
            if (!isLittleStraightFixed) littleStraight_sum = littleStraight ? 30 : 0;

            bool bigStraight = new[] { 2, 3, 4, 5, 6 }.All(value => diceValues.Contains(value));
            if (!isBigStraightFixed) bigStraight_sum = bigStraight ? 30 : 0;

            var yacht_grouped = diceValues.GroupBy(d => d)   // 값별로 그룹화
                            .Where(g => g.Count() == 5)  // 5개 동일한 값 찾기
                            .Select(g => g.Key)
                            .FirstOrDefault();// 동일한 값만 추출
            if (yacht_grouped != 0)  // 5개 동일한 값이 있으면
            {
                // 5개 동일한 값이 있으면 50점 고정
                if (!isYachtFixed) yacht_sum = 50;
            }
            DiceRoll.Start();
            if (timeElapsed >= 1500) //1.5초 후
            {
                DiceRoll.Stop();  // 타이머 멈추기
                ReRoll.Enabled = true;
                ShowScore();
            }
        }

        private void ReRoll_Click(object sender, EventArgs e)
        {
            if (ReRollValue < 3)
            {
                ReRollValue++; // 리롤 횟수 추가
                timeElapsed = 0; //타이머 시간 초기화
                ReRoll.Enabled = false; //리롤 버튼 비활성화
                DiceRoll.Stop();
                DiceRoll.Start(); // 정지 후 다시 시작
            }
            ReRollCount.Text = (ReRollValue) + "/3";
        } //리롤 버튼 클릭

        private void Dice1_Click(object sender, EventArgs e) //첫번째 주사위 잠금 함수
        {
            if (ReRollValue != 0) //리롤 횟수가 1번 이상일 때
            {
                if (Dice1Lock == false) //주사위가 잠겨있지 않으면
                {
                    Dice1Lock = true; //주사위를 잠구고
                    Lock1.Visible = true; //"잠금" 이라는 표시를 띄운다
                }
                else
                {
                    Dice1Lock = false;
                    Lock1.Visible = false;
                }
            }
        }

        private void Dice2_Click(object sender, EventArgs e) //두번째 주사위 잠금 함수
        {
            if (ReRollValue != 0)
            {
                if (Dice2Lock == false)
                {
                    Dice2Lock = true;
                    Lock2.Visible = true;
                }
                else
                {
                    Dice2Lock = false;
                    Lock2.Visible = false;
                }
            }
        }

        private void Dice3_Click(object sender, EventArgs e) //세번째 주사위 잠금 함수
        {
            if (ReRollValue != 0)
            {
                if (Dice3Lock == false)
                {
                    Dice3Lock = true;
                    Lock3.Visible = true;
                }
                else
                {
                    Dice3Lock = false;
                    Lock3.Visible = false;
                }
            }
        }

        private void Dice4_Click(object sender, EventArgs e) //네번째 주사위 잠금 함수
        {
            if (ReRollValue != 0)
            {
                if (Dice4Lock == false)
                {
                    Dice4Lock = true;
                    Lock4.Visible = true;
                }
                else
                {
                    Dice4Lock = false;
                    Lock4.Visible = false;
                }
            }
        }

        private void Dice5_Click(object sender, EventArgs e) //다섯번째 주사위 잠금 함수
        {
            if (ReRollValue != 0)
            {
                if (Dice5Lock == false)
                {
                    Dice5Lock = true;
                    Lock5.Visible = true;
                }
                else
                {
                    Dice5Lock = false;
                    Lock5.Visible = false;
                }
            }
        }

        private void Ones_Click(object sender, EventArgs e)
        {
            selectedCategory = 1;  // Ones 선택
        } //Ones ~ Yacht Click은 눌렀을 때

        private void Twos_Click(object sender, EventArgs e)
        {
            selectedCategory = 2;  // Twos 선택
        } //selectCategory 값 반환

        private void Threes_Click(object sender, EventArgs e)
        {
            selectedCategory = 3;  // Threes 선택
        }

        private void Fours_Click(object sender, EventArgs e)
        {
            selectedCategory = 4;  // Fours 선택
        }

        private void Fives_Click(object sender, EventArgs e)
        {
            selectedCategory = 5;  // Fives 선택
        }

        private void SIxes_Click(object sender, EventArgs e)
        {
            selectedCategory = 6;  // Ones 선택
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            selectedCategory = 7;  // Choice 선택
        }

        private void FourOfAKind_Click(object sender, EventArgs e)
        {
            selectedCategory = 8;  // FourOfAKind 선택
        }

        private void FullHouse_Click(object sender, EventArgs e)
        {
            selectedCategory = 9;  // FullHouse 선택
        }

        private void LittleStraight_Click(object sender, EventArgs e)
        {
            selectedCategory = 10;  // LittleStraight 선택
        }

        private void BigStraight_Click(object sender, EventArgs e)
        {
            selectedCategory = 11;  // BigStraight 선택
        }

        private void Yacht_Click(object sender, EventArgs e)
        {
            selectedCategory = 12;  // Yacht 선택
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            if (ReRollValue != 0)
            { // 선택된 카테고리별로 점수 고정
                if (selectedCategory == 1 && !isOnesFixed) // Ones 점수 고정
                {
                    Ones.Enabled = false;
                    isOnesFixed = true;
                }
                else if (selectedCategory == 2 && !isTwosFixed) // Twos 점수 고정
                {
                    Twos.Enabled = false;
                    isTwosFixed = true;
                }
                else if (selectedCategory == 3 && !isThreesFixed) // Threes 점수 고정
                {
                    Threes.Enabled = false;
                    isThreesFixed = true;
                }
                else if (selectedCategory == 4 && !isFoursFixed) // Fours 점수 고정
                {
                    Fours.Enabled = false;
                    isFoursFixed = true;
                }
                else if (selectedCategory == 5 && !isFivesFixed) // Fives 점수 고정
                {
                    Fives.Enabled = false;
                    isFivesFixed = true;
                }
                else if (selectedCategory == 6 && !isSixesFixed) // Sixes 점수 고정
                {
                    Sixes.Enabled = false;
                    isSixesFixed = true;
                }
                else if (selectedCategory == 7 && !isChoiceFixed) // Choice 점수 고정
                {
                    Choice.Enabled = false;
                    isChoiceFixed = true;
                }
                else if (selectedCategory == 8 && !isFourOfAKindFixed) // FourOfAKind 점수 고정
                {
                    FourOfAKind.Enabled = false;
                    isFourOfAKindFixed = true;
                }
                else if (selectedCategory == 9 && !isFullHouseFixed) // FullHouse 점수 고정
                {
                    FullHouse.Enabled = false;
                    isFullHouseFixed = true;
                }
                else if (selectedCategory == 10 && !isLittleStraightFixed) // LittleStraight 점수 고정
                {
                    LittleStraight.Enabled = false;
                    isLittleStraightFixed = true;
                }
                else if (selectedCategory == 11 && !isBigStraightFixed) // BigStraight 점수 고정
                {
                    BigStraight.Enabled = false;
                    isBigStraightFixed = true;
                }

                else if (selectedCategory == 12 && !isYachtFixed) // Yacht 점수 고정
                {
                    Yacht.Enabled = false;
                    isYachtFixed = true;  // Yacht 점수 고정
                }

                if (selectedCategory != -1) //주사위가 한번이라도 돌아간 상황에서 선택 완료를 누르면
                {
                    Choose.Enabled = false; //선택 완료 버튼이 잠기고 1번째 주사위부터 5번째 주사위까지의 잠금 해제
                    Dice1Lock = false;
                    Lock1.Visible = false;
                    Dice2Lock = false;
                    Lock2.Visible = false;
                    Dice3Lock = false;
                    Lock3.Visible = false;
                    Dice4Lock = false;
                    Lock4.Visible = false;
                    Dice5Lock = false;
                    Lock5.Visible = false;
                    ReRollValue = 0; //리롤 횟수 초기화
                }
            }
        } //Fixed 관련 함수

        private void ResetScore()
        {
            selectedCategory = -1;
            Choose.Enabled = true;
            if (!isOnesFixed) sum1 = 0;
            if (!isTwosFixed) sum2 = 0;
            if (!isThreesFixed) sum3 = 0;
            if (!isFoursFixed) sum4 = 0;
            if (!isFivesFixed) sum5 = 0;
            if (!isSixesFixed) sum6 = 0;
            if (!isChoiceFixed) choice_sum = 0;
            if (!isFourOfAKindFixed) fourOfAKind_sum = 0;
            if (!isFullHouseFixed) fullHouse_sum = 0;
            if (!isLittleStraightFixed) littleStraight_sum = 0;
            if (!isBigStraightFixed) bigStraight_sum = 0;
            if (!isYachtFixed) yacht_sum = 0;
        } //선택 완료 버튼 및 결과값 초기화
        private void ShowScore()
        {
            OnesResult.Text = sum1.ToString(); // 모든 정수의 합 다시 출력
            TwosResult.Text = sum2.ToString();
            ThreesResult.Text = sum3.ToString();
            FoursResult.Text = sum4.ToString();
            FivesResult.Text = sum5.ToString();
            SixesResult.Text = sum6.ToString();
            ChoiceResult.Text = choice_sum.ToString();
            FourOfAKindResult.Text = fourOfAKind_sum.ToString();
            FullHouseResult.Text = fullHouse_sum.ToString();
            LittleStraightResult.Text = littleStraight_sum.ToString();
            BigStraightResult.Text = bigStraight_sum.ToString();
            YachtResult.Text = yacht_sum.ToString();
        } //int를 string으로 바꾸어 출력

        private void ResetScoreLock()
        {
            if (isOnesFixed && isTwosFixed && isThreesFixed && isFoursFixed &&
        isFivesFixed && isSixesFixed && isChoiceFixed && isFourOfAKindFixed &&
        isLittleStraightFixed && isBigStraightFixed && isYachtFixed && isFullHouseFixed)
            {
                isOnesFixed = false;
                isTwosFixed = false;
                isThreesFixed = false;
                isFoursFixed = false;
                isFivesFixed = false;
                isSixesFixed = false;
                isChoiceFixed = false;
                isFourOfAKindFixed = false;
                isLittleStraightFixed = false;
                isBigStraightFixed = false;
                isYachtFixed = false;
                isFullHouseFixed = false;
                Ones.Enabled = true;
                Twos.Enabled = true;
                Threes.Enabled = true;
                Fours.Enabled = true;
                Fives.Enabled = true;
                Sixes.Enabled = true;
                Choice.Enabled = true;
                FullHouse.Enabled = true;
                LittleStraight.Enabled = true;
                BigStraight.Enabled = true;
                Yacht.Enabled = true;
            }
        }  //점수 잠금 비활성화 함수
        private void Monster1() //몬스터 1 함수
        {
            Monster_HP = random.Next(5, 50); //몬스터 HP를 랜덤으로 지정
            Monster_Attack = random.Next(1, 30);
            Monster_Defense = 0;
            Monster_Name = "스켈레톤";
            monsterLabel.Image = imageList2.Images[0];
        }

        private void Monster2() //몬스터 2 함수
        {
            Monster_HP = random.Next(1, 10); //몬스터 HP를 랜덤으로 지정
            Monster_Attack = 0;
            Monster_Defense = random.Next(1, 15);
            Monster_Name = "슬라임";
            monsterLabel.Image = imageList2.Images[2];
        }

        private void Monster3() // 몬스터 3 함수
        {
            Monster_HP = random.Next(10, 40); //몬스터 HP를 랜덤으로 지정
            Monster_Attack = random.Next(1, 10);
            Monster_Defense = random.Next(1, 10);
            Monster_Name = "고블린";
            monsterLabel.Image = imageList2.Images[4];
        }
    }


}

    
