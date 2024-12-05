namespace 야추
{
    partial class YachtKing
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YachtKing));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DiceRoll = new System.Windows.Forms.Timer(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ReRollCount = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.ReRoll = new System.Windows.Forms.Button();
            this.Yacht = new System.Windows.Forms.Button();
            this.BigStraight = new System.Windows.Forms.Button();
            this.LittleStraight = new System.Windows.Forms.Button();
            this.FullHouse = new System.Windows.Forms.Button();
            this.FourOfAKind = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.Button();
            this.Sixes = new System.Windows.Forms.Button();
            this.Fives = new System.Windows.Forms.Button();
            this.Fours = new System.Windows.Forms.Button();
            this.Threes = new System.Windows.Forms.Button();
            this.Twos = new System.Windows.Forms.Button();
            this.Ones = new System.Windows.Forms.Button();
            this.YachtResult = new System.Windows.Forms.TextBox();
            this.BigStraightResult = new System.Windows.Forms.TextBox();
            this.LittleStraightResult = new System.Windows.Forms.TextBox();
            this.FullHouseResult = new System.Windows.Forms.TextBox();
            this.FourOfAKindResult = new System.Windows.Forms.TextBox();
            this.ChoiceResult = new System.Windows.Forms.TextBox();
            this.SixesResult = new System.Windows.Forms.TextBox();
            this.FivesResult = new System.Windows.Forms.TextBox();
            this.FoursResult = new System.Windows.Forms.TextBox();
            this.ThreesResult = new System.Windows.Forms.TextBox();
            this.TwosResult = new System.Windows.Forms.TextBox();
            this.OnesResult = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Lock5 = new System.Windows.Forms.Label();
            this.Lock4 = new System.Windows.Forms.Label();
            this.Lock3 = new System.Windows.Forms.Label();
            this.Lock2 = new System.Windows.Forms.Label();
            this.Lock1 = new System.Windows.Forms.Label();
            this.Dice5 = new System.Windows.Forms.Label();
            this.Dice4 = new System.Windows.Forms.Label();
            this.Dice3 = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.Label();
            this.Dice1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dice1.png");
            this.imageList1.Images.SetKeyName(1, "Dice2.png");
            this.imageList1.Images.SetKeyName(2, "Dice3.png");
            this.imageList1.Images.SetKeyName(3, "Dice4.png");
            this.imageList1.Images.SetKeyName(4, "Dice5.png");
            this.imageList1.Images.SetKeyName(5, "Dice6.png");
            // 
            // DiceRoll
            // 
            this.DiceRoll.Tick += new System.EventHandler(this.DiceRoll_Tick);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ReRollCount);
            this.splitContainer3.Panel1.Controls.Add(this.Choose);
            this.splitContainer3.Panel1.Controls.Add(this.ReRoll);
            this.splitContainer3.Panel1.Controls.Add(this.Yacht);
            this.splitContainer3.Panel1.Controls.Add(this.BigStraight);
            this.splitContainer3.Panel1.Controls.Add(this.LittleStraight);
            this.splitContainer3.Panel1.Controls.Add(this.FullHouse);
            this.splitContainer3.Panel1.Controls.Add(this.FourOfAKind);
            this.splitContainer3.Panel1.Controls.Add(this.Choice);
            this.splitContainer3.Panel1.Controls.Add(this.Sixes);
            this.splitContainer3.Panel1.Controls.Add(this.Fives);
            this.splitContainer3.Panel1.Controls.Add(this.Fours);
            this.splitContainer3.Panel1.Controls.Add(this.Threes);
            this.splitContainer3.Panel1.Controls.Add(this.Twos);
            this.splitContainer3.Panel1.Controls.Add(this.Ones);
            this.splitContainer3.Panel1.Controls.Add(this.YachtResult);
            this.splitContainer3.Panel1.Controls.Add(this.BigStraightResult);
            this.splitContainer3.Panel1.Controls.Add(this.LittleStraightResult);
            this.splitContainer3.Panel1.Controls.Add(this.FullHouseResult);
            this.splitContainer3.Panel1.Controls.Add(this.FourOfAKindResult);
            this.splitContainer3.Panel1.Controls.Add(this.ChoiceResult);
            this.splitContainer3.Panel1.Controls.Add(this.SixesResult);
            this.splitContainer3.Panel1.Controls.Add(this.FivesResult);
            this.splitContainer3.Panel1.Controls.Add(this.FoursResult);
            this.splitContainer3.Panel1.Controls.Add(this.ThreesResult);
            this.splitContainer3.Panel1.Controls.Add(this.TwosResult);
            this.splitContainer3.Panel1.Controls.Add(this.OnesResult);
            this.splitContainer3.Size = new System.Drawing.Size(247, 433);
            this.splitContainer3.SplitterDistance = 250;
            this.splitContainer3.TabIndex = 0;
            // 
            // ReRollCount
            // 
            this.ReRollCount.AutoSize = true;
            this.ReRollCount.Location = new System.Drawing.Point(52, 229);
            this.ReRollCount.Name = "ReRollCount";
            this.ReRollCount.Size = new System.Drawing.Size(29, 15);
            this.ReRollCount.TabIndex = 40;
            this.ReRollCount.Text = "0/3";
            // 
            // Choose
            // 
            this.Choose.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Choose.Location = new System.Drawing.Point(125, 198);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(116, 28);
            this.Choose.TabIndex = 39;
            this.Choose.Text = "선택 완료";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // ReRoll
            // 
            this.ReRoll.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReRoll.Location = new System.Drawing.Point(8, 198);
            this.ReRoll.Name = "ReRoll";
            this.ReRoll.Size = new System.Drawing.Size(115, 28);
            this.ReRoll.TabIndex = 38;
            this.ReRoll.Text = "다시 던지기";
            this.ReRoll.UseVisualStyleBackColor = true;
            this.ReRoll.Click += new System.EventHandler(this.ReRoll_Click);
            // 
            // Yacht
            // 
            this.Yacht.Location = new System.Drawing.Point(125, 167);
            this.Yacht.Name = "Yacht";
            this.Yacht.Size = new System.Drawing.Size(59, 25);
            this.Yacht.TabIndex = 37;
            this.Yacht.Text = "Yacht";
            this.Yacht.UseVisualStyleBackColor = true;
            this.Yacht.Click += new System.EventHandler(this.Yacht_Click);
            // 
            // BigStraight
            // 
            this.BigStraight.Location = new System.Drawing.Point(125, 135);
            this.BigStraight.Name = "BigStraight";
            this.BigStraight.Size = new System.Drawing.Size(59, 25);
            this.BigStraight.TabIndex = 36;
            this.BigStraight.Text = "BH";
            this.BigStraight.UseVisualStyleBackColor = true;
            this.BigStraight.Click += new System.EventHandler(this.BigStraight_Click);
            // 
            // LittleStraight
            // 
            this.LittleStraight.Location = new System.Drawing.Point(125, 105);
            this.LittleStraight.Name = "LittleStraight";
            this.LittleStraight.Size = new System.Drawing.Size(59, 25);
            this.LittleStraight.TabIndex = 35;
            this.LittleStraight.Text = "LH";
            this.LittleStraight.UseVisualStyleBackColor = true;
            this.LittleStraight.Click += new System.EventHandler(this.LittleStraight_Click);
            // 
            // FullHouse
            // 
            this.FullHouse.Location = new System.Drawing.Point(125, 74);
            this.FullHouse.Name = "FullHouse";
            this.FullHouse.Size = new System.Drawing.Size(59, 25);
            this.FullHouse.TabIndex = 34;
            this.FullHouse.Text = "FH";
            this.FullHouse.UseVisualStyleBackColor = true;
            this.FullHouse.Click += new System.EventHandler(this.FullHouse_Click);
            // 
            // FourOfAKind
            // 
            this.FourOfAKind.Location = new System.Drawing.Point(125, 43);
            this.FourOfAKind.Name = "FourOfAKind";
            this.FourOfAKind.Size = new System.Drawing.Size(59, 25);
            this.FourOfAKind.TabIndex = 33;
            this.FourOfAKind.Text = "FK";
            this.FourOfAKind.UseVisualStyleBackColor = true;
            this.FourOfAKind.Click += new System.EventHandler(this.FourOfAKind_Click);
            // 
            // Choice
            // 
            this.Choice.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Choice.Location = new System.Drawing.Point(125, 12);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(59, 25);
            this.Choice.TabIndex = 32;
            this.Choice.Text = "Choice";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // Sixes
            // 
            this.Sixes.Location = new System.Drawing.Point(8, 167);
            this.Sixes.Name = "Sixes";
            this.Sixes.Size = new System.Drawing.Size(59, 25);
            this.Sixes.TabIndex = 31;
            this.Sixes.Text = "Sixes";
            this.Sixes.UseVisualStyleBackColor = true;
            this.Sixes.Click += new System.EventHandler(this.SIxes_Click);
            // 
            // Fives
            // 
            this.Fives.Location = new System.Drawing.Point(8, 135);
            this.Fives.Name = "Fives";
            this.Fives.Size = new System.Drawing.Size(59, 25);
            this.Fives.TabIndex = 30;
            this.Fives.Text = "Fives";
            this.Fives.UseVisualStyleBackColor = true;
            this.Fives.Click += new System.EventHandler(this.Fives_Click);
            // 
            // Fours
            // 
            this.Fours.Location = new System.Drawing.Point(8, 105);
            this.Fours.Name = "Fours";
            this.Fours.Size = new System.Drawing.Size(59, 25);
            this.Fours.TabIndex = 29;
            this.Fours.Text = "Fours";
            this.Fours.UseVisualStyleBackColor = true;
            this.Fours.Click += new System.EventHandler(this.Fours_Click);
            // 
            // Threes
            // 
            this.Threes.Location = new System.Drawing.Point(8, 74);
            this.Threes.Name = "Threes";
            this.Threes.Size = new System.Drawing.Size(59, 25);
            this.Threes.TabIndex = 28;
            this.Threes.Text = "Threes";
            this.Threes.UseVisualStyleBackColor = true;
            this.Threes.Click += new System.EventHandler(this.Threes_Click);
            // 
            // Twos
            // 
            this.Twos.Location = new System.Drawing.Point(8, 43);
            this.Twos.Name = "Twos";
            this.Twos.Size = new System.Drawing.Size(59, 25);
            this.Twos.TabIndex = 27;
            this.Twos.Text = "Twos";
            this.Twos.UseVisualStyleBackColor = true;
            this.Twos.Click += new System.EventHandler(this.Twos_Click);
            // 
            // Ones
            // 
            this.Ones.Location = new System.Drawing.Point(8, 12);
            this.Ones.Name = "Ones";
            this.Ones.Size = new System.Drawing.Size(59, 25);
            this.Ones.TabIndex = 26;
            this.Ones.Text = "Ones";
            this.Ones.UseVisualStyleBackColor = true;
            this.Ones.Click += new System.EventHandler(this.Ones_Click);
            // 
            // YachtResult
            // 
            this.YachtResult.Enabled = false;
            this.YachtResult.Location = new System.Drawing.Point(186, 167);
            this.YachtResult.Name = "YachtResult";
            this.YachtResult.Size = new System.Drawing.Size(55, 25);
            this.YachtResult.TabIndex = 23;
            // 
            // BigStraightResult
            // 
            this.BigStraightResult.Enabled = false;
            this.BigStraightResult.Location = new System.Drawing.Point(186, 136);
            this.BigStraightResult.Name = "BigStraightResult";
            this.BigStraightResult.Size = new System.Drawing.Size(55, 25);
            this.BigStraightResult.TabIndex = 22;
            // 
            // LittleStraightResult
            // 
            this.LittleStraightResult.Enabled = false;
            this.LittleStraightResult.Location = new System.Drawing.Point(186, 105);
            this.LittleStraightResult.Name = "LittleStraightResult";
            this.LittleStraightResult.Size = new System.Drawing.Size(55, 25);
            this.LittleStraightResult.TabIndex = 21;
            // 
            // FullHouseResult
            // 
            this.FullHouseResult.Enabled = false;
            this.FullHouseResult.Location = new System.Drawing.Point(186, 74);
            this.FullHouseResult.Name = "FullHouseResult";
            this.FullHouseResult.Size = new System.Drawing.Size(55, 25);
            this.FullHouseResult.TabIndex = 20;
            // 
            // FourOfAKindResult
            // 
            this.FourOfAKindResult.Enabled = false;
            this.FourOfAKindResult.Location = new System.Drawing.Point(186, 43);
            this.FourOfAKindResult.Name = "FourOfAKindResult";
            this.FourOfAKindResult.Size = new System.Drawing.Size(55, 25);
            this.FourOfAKindResult.TabIndex = 19;
            // 
            // ChoiceResult
            // 
            this.ChoiceResult.Enabled = false;
            this.ChoiceResult.Location = new System.Drawing.Point(186, 12);
            this.ChoiceResult.Name = "ChoiceResult";
            this.ChoiceResult.Size = new System.Drawing.Size(55, 25);
            this.ChoiceResult.TabIndex = 18;
            // 
            // SixesResult
            // 
            this.SixesResult.Enabled = false;
            this.SixesResult.Location = new System.Drawing.Point(69, 167);
            this.SixesResult.Name = "SixesResult";
            this.SixesResult.Size = new System.Drawing.Size(54, 25);
            this.SixesResult.TabIndex = 11;
            // 
            // FivesResult
            // 
            this.FivesResult.Enabled = false;
            this.FivesResult.Location = new System.Drawing.Point(68, 136);
            this.FivesResult.Name = "FivesResult";
            this.FivesResult.Size = new System.Drawing.Size(55, 25);
            this.FivesResult.TabIndex = 10;
            // 
            // FoursResult
            // 
            this.FoursResult.Enabled = false;
            this.FoursResult.Location = new System.Drawing.Point(69, 105);
            this.FoursResult.Name = "FoursResult";
            this.FoursResult.Size = new System.Drawing.Size(54, 25);
            this.FoursResult.TabIndex = 9;
            // 
            // ThreesResult
            // 
            this.ThreesResult.Enabled = false;
            this.ThreesResult.Location = new System.Drawing.Point(68, 74);
            this.ThreesResult.Name = "ThreesResult";
            this.ThreesResult.Size = new System.Drawing.Size(55, 25);
            this.ThreesResult.TabIndex = 8;
            // 
            // TwosResult
            // 
            this.TwosResult.Enabled = false;
            this.TwosResult.Location = new System.Drawing.Point(68, 43);
            this.TwosResult.Name = "TwosResult";
            this.TwosResult.Size = new System.Drawing.Size(55, 25);
            this.TwosResult.TabIndex = 7;
            // 
            // OnesResult
            // 
            this.OnesResult.Enabled = false;
            this.OnesResult.Location = new System.Drawing.Point(68, 12);
            this.OnesResult.Name = "OnesResult";
            this.OnesResult.Size = new System.Drawing.Size(55, 25);
            this.OnesResult.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Lock5);
            this.splitContainer2.Panel2.Controls.Add(this.Lock4);
            this.splitContainer2.Panel2.Controls.Add(this.Lock3);
            this.splitContainer2.Panel2.Controls.Add(this.Lock2);
            this.splitContainer2.Panel2.Controls.Add(this.Lock1);
            this.splitContainer2.Panel2.Controls.Add(this.Dice5);
            this.splitContainer2.Panel2.Controls.Add(this.Dice4);
            this.splitContainer2.Panel2.Controls.Add(this.Dice3);
            this.splitContainer2.Panel2.Controls.Add(this.Dice2);
            this.splitContainer2.Panel2.Controls.Add(this.Dice1);
            this.splitContainer2.Size = new System.Drawing.Size(450, 433);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;
            // 
            // Lock5
            // 
            this.Lock5.AutoSize = true;
            this.Lock5.Location = new System.Drawing.Point(377, 137);
            this.Lock5.Name = "Lock5";
            this.Lock5.Size = new System.Drawing.Size(37, 15);
            this.Lock5.TabIndex = 9;
            this.Lock5.Text = "잠금";
            this.Lock5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock5.Visible = false;
            // 
            // Lock4
            // 
            this.Lock4.AutoSize = true;
            this.Lock4.Location = new System.Drawing.Point(293, 137);
            this.Lock4.Name = "Lock4";
            this.Lock4.Size = new System.Drawing.Size(37, 15);
            this.Lock4.TabIndex = 8;
            this.Lock4.Text = "잠금";
            this.Lock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock4.Visible = false;
            // 
            // Lock3
            // 
            this.Lock3.AutoSize = true;
            this.Lock3.Location = new System.Drawing.Point(205, 136);
            this.Lock3.Name = "Lock3";
            this.Lock3.Size = new System.Drawing.Size(37, 15);
            this.Lock3.TabIndex = 7;
            this.Lock3.Text = "잠금";
            this.Lock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock3.Visible = false;
            // 
            // Lock2
            // 
            this.Lock2.AutoSize = true;
            this.Lock2.Location = new System.Drawing.Point(122, 137);
            this.Lock2.Name = "Lock2";
            this.Lock2.Size = new System.Drawing.Size(37, 15);
            this.Lock2.TabIndex = 6;
            this.Lock2.Text = "잠금";
            this.Lock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock2.Visible = false;
            // 
            // Lock1
            // 
            this.Lock1.AutoSize = true;
            this.Lock1.Location = new System.Drawing.Point(35, 137);
            this.Lock1.Name = "Lock1";
            this.Lock1.Size = new System.Drawing.Size(37, 15);
            this.Lock1.TabIndex = 5;
            this.Lock1.Text = "잠금";
            this.Lock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lock1.Visible = false;
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dice5.ImageList = this.imageList1;
            this.Dice5.Location = new System.Drawing.Point(356, 44);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(79, 79);
            this.Dice5.TabIndex = 4;
            this.Dice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dice5.Click += new System.EventHandler(this.Dice5_Click);
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dice4.ImageList = this.imageList1;
            this.Dice4.Location = new System.Drawing.Point(271, 44);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(79, 79);
            this.Dice4.TabIndex = 3;
            this.Dice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dice4.Click += new System.EventHandler(this.Dice4_Click);
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dice3.ImageList = this.imageList1;
            this.Dice3.Location = new System.Drawing.Point(186, 44);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(79, 79);
            this.Dice3.TabIndex = 2;
            this.Dice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dice3.Click += new System.EventHandler(this.Dice3_Click);
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dice2.ImageList = this.imageList1;
            this.Dice2.Location = new System.Drawing.Point(101, 44);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(79, 79);
            this.Dice2.TabIndex = 1;
            this.Dice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dice2.Click += new System.EventHandler(this.Dice2_Click);
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dice1.ImageList = this.imageList1;
            this.Dice1.Location = new System.Drawing.Point(13, 44);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(79, 79);
            this.Dice1.TabIndex = 0;
            this.Dice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(702, 433);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // YachtKing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YachtKing";
            this.Text = "Yacht King";
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer DiceRoll;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button Ones;
        private System.Windows.Forms.TextBox YachtResult;
        private System.Windows.Forms.TextBox BigStraightResult;
        private System.Windows.Forms.TextBox LittleStraightResult;
        private System.Windows.Forms.TextBox FullHouseResult;
        private System.Windows.Forms.TextBox FourOfAKindResult;
        private System.Windows.Forms.TextBox ChoiceResult;
        private System.Windows.Forms.TextBox SixesResult;
        private System.Windows.Forms.TextBox FivesResult;
        private System.Windows.Forms.TextBox FoursResult;
        private System.Windows.Forms.TextBox ThreesResult;
        private System.Windows.Forms.TextBox TwosResult;
        private System.Windows.Forms.TextBox OnesResult;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Dice5;
        private System.Windows.Forms.Label Dice4;
        private System.Windows.Forms.Label Dice3;
        private System.Windows.Forms.Label Dice2;
        private System.Windows.Forms.Label Dice1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Yacht;
        private System.Windows.Forms.Button BigStraight;
        private System.Windows.Forms.Button LittleStraight;
        private System.Windows.Forms.Button FullHouse;
        private System.Windows.Forms.Button FourOfAKind;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.Button Sixes;
        private System.Windows.Forms.Button Fives;
        private System.Windows.Forms.Button Fours;
        private System.Windows.Forms.Button Threes;
        private System.Windows.Forms.Button Twos;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button ReRoll;
        private System.Windows.Forms.Label ReRollCount;
        private System.Windows.Forms.Label Lock5;
        private System.Windows.Forms.Label Lock4;
        private System.Windows.Forms.Label Lock3;
        private System.Windows.Forms.Label Lock2;
        private System.Windows.Forms.Label Lock1;
    }
}

