using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DooGame
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CScene theScene1;
        CScene theScene2;
        CScene theScene3;
        CScene theScene4;
        CScene theScene6;
        CScene theScene7;
        CScene theScene8;
        CScene theScene9;
        CScene theScene10;
        CScene theScene11;
        CScene theScene12;



        CScene theCurrentScene;
        SortedList<String, CScene> theScenes;

        int length = 0;
        string testStr = "가나다라마바사아자차카타파하123456789";
        Font theFont = new Font("맑은 고딕", 13);
        Brush theBrush = new SolidBrush(Color.White);

        Image imgMal;
        Image imgBtn1;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("이 게임을 실행하면 돌아올 수 없습니다.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SoundPlayer player = new SoundPlayer("Images/bgm_wav.wav");
            player.Play();

            imgMal = Image.FromFile("Images/mal_fff.png");
            imgBtn1 = Image.FromFile("Images/btn1.png");

            CScene theScene5 = new CScene("시작");
            theScene5.AddImageAndText(Image.FromFile("Images/main_ffff.jpg"));
            theScene5.AddButton("▶", "Scn1");

            theCurrentScene = theScene5;

            theScene1 = new CScene("Scn1");
            theScene1.AddImageAndText(Image.FromFile("Images/domibe.jpg"));
            theScene1.AddButton("▶", "Scn2");

            theScene2 = new CScene("Scn2");
            theScene2.AddImageAndText(Image.FromFile("Images/black.jpg"));
            theScene2.AddButton("▶", "Scn3");
            theScene2.AddText("아~ 심심해 야 우리 무서운 얘기나 할래?");
            theScene2.AddText("응? 갑자기 무서운 얘기?");
            theScene2.AddText("오 좋다 무서운 얘기! 마침 나 할 얘기 있어!");
            theScene2.AddText("그래 그럼 너 부터 시작해봐");

            theScene2.VisibleCheck(true);

            theScene3 = new CScene("Scn3");
            theScene3.AddImageAndText(Image.FromFile("Images/CHAPTER1.jpg"));
            theScene3.AddButton("▶", "Scn4");

            theScene4 = new CScene("Scn4");
            theScene4.AddImageAndText(Image.FromFile("Images/dorm.jpg"));
            theScene4.AddButton("▶", "Scn6");
            theScene4.AddText("그거 알아? 내가 408호에 살았을 때 이야기인데....");
            theScene4.AddText("그 때 친구들하고 침대 쪽에서 이야기를 하고 있었거든? 근데 갑자기 \n나만 들렸는진 모르겠는데 책상 쪽에서 타자 소리가 나는거야");
            theScene4.AddText("난 그때까지만 해도 책상 쪽에 누가 앉아 있는 줄 알았거든? \n근데 침대 쪽에 모여있던 인원은 나까지 포함해서 총 4명이었어");
            theScene4.AddText("그래서 난 이상한 마음에 뒤를 돌아 책상을 바라봤는데 역시 아무도 없는거야");
            theScene4.AddText("나는 처음에 잘못 들은 줄 알고 다시 고개를 돌려서 얘기를 하려는데, \n또 타자 소리가 나는 거야 그때 정말 오싹했지!!");
            theScene4.AddText("나는 일단 책상 쪽으로 가봤어 애들도 들었는지 숨죽이며 있었고....");
            theScene4.AddText("나는 무슨 용기가 들었는지 책상 쪽으로 향했는데 \n책상 네 개 중에서 창문쪽에 내 노트북 하나밖에 없었단 말이야? \n근데 그게 덮여져 있었거든?");
            theScene4.AddText("그래서 나는 노트북을 열었어");

            theScene6 = new CScene("Scn6");
            theScene6.AddImageAndText(Image.FromFile("Images/notebook.jpg"));
            theScene6.AddButton("▶", "Scn7");
            theScene6.AddText("");
            theScene6.AddText("근데 내 바탕화면에 메모장이 떠 있는거야");
            theScene6.AddText("난 메모장을 켠 적이 없는데 말이야... \n심지어 그 메모장에 무언가 적혀있었어!");
            theScenes = new SortedList<string, CScene>();

            theScene7 = new CScene("Scn7");
            theScene7.AddImageAndText(Image.FromFile("Images/memojang.jpg"));
            theScene7.AddButton("▶", "Scn8");
            theScene7.AddText("");
            theScene7.AddText("그것만 보면 내 실수라고 생각할 수 있는데 소름이 돋았던건\n그 메모장에 쳐져있는 영문자가 소문자하고 대문자하고 막 섞여있었어!");
            theScene7.AddText("잘못 쳤다고 생각하기엔 너무 잘 구분되 있었어 \n근데 난 이상한 느낌이 들어서 그 영문자들을 자판으로 쳐봤거든?");
            theScene7.AddText("한글로 말이야.. 그런데 뭔가 문장이 완성되는거야.. \n내가 그 메모장 밑에 따라치고 있었는데\n다 치고 나서 '너 똑똑하구나?'라는 문장이 완성되더라?");
            theScene7.AddText("그리고 그 다음에.... 에러창이 확 뜨는거야! 내가 해석한 영문자가 써 있는 에러창이.. \n");
            theScene7.AddText("난 너무 소름돋아서 '뭐야'하면서 닫으려고 하는데...");

            theScene8 = new CScene("Scn8");
            theScene8.AddImageAndText(Image.FromFile("Images/memojang_jung.jpg"));
            theScene8.AddButton("▶", "Scn9");
            theScene8.AddText("ą̸̡͈͉̣̟̺̝̺̞͊̎͐̏̾̓̈́́͋͝p̷̢͓̦͖̚ä̴̧̙̠̻́͛͌͑́̔͌͆̑̕͠h̸̫̬͕͍͔̫͖̹̓͆͆̄̓͛͆̔̄̚͜͝w̶̡̧̗̯͉̙͗͑͆̈̈́́̏̍̇̿̕͘k̴͓̲̮͖͗̈̈́\nd̵͔͓̩͕̳̰͘̕d̷̠̗̥̳̠̮̭̹̤̣͎̯̥̘͒͜m̸̤̠̲͖̲͛̊̋̅ļ̶̳̻̻̟̗̋͗̈́͛̈́̋͗̾͆̾̃̾͘͠w̶̳͌̆̔͐͌̀̕͘͝k̸̡̦͕̫̈́͋͐̈̂̓̿r̷̨̡̯̭͎̱̬̓̊̀̌̀͗͜e̷̩͑͗́͐͆ẖ̸̡̩̳̖͚̟̬̹̮͋̋̈̉̀͠d̴̢̧̨̡̯̮͎͉̻̲̭̺̆̉̄͜ͅd̸̢͔̼͇͍͎͓̈́̽̂̀̊͑̈͛̄͘͘̚͝l̶̡͚̟͓̾̎̀̈́̃̀͊̈̇͌̑̏̈́̃͠w̶̺̣̞̉̄͋͆́̆n̷̪̯̿̃̅̀͘d̸̜̫̬̐̀̾͒͒̂́͒̒w̷̗̘͈̮͋͛̓̓́́̌̈́͑̌̈̒̓́̕ļ̷̙͔̥̞̈́̇̈͆̎̊̈̑͑̀̓̀̽͝ė̷̢͈͎̫̹̯̤̖̜̦̺̠̉̀͜͠ḫ̸̡̦͕̘̦̩́̈̃̃͐͒̅ḷ̵̢̢͙͔̠̝͇̠̯̭͇̱̞̀̓͌͊͆̎̈́̒̂̈́͝͠d̵̲͈̺̺̪͉͇̻͖͉̻͛͆͒̈̂̈́̒̑̋̀͒̏̚̕͘j̷̝͕̮̪̃̈̚T̴͕̏̇̈̈́̊̃̊͑̓͘͠t̶̙͉͓͈̙̓̉͝m̸̡̺͚̱̞̝͚͚̿q̴̡̛͎̪̹̘́̑̿̓́͒̄̏̂͐̅ͅs̸̛̛̭̤̜̮̰̦̟̞̄͐͑̋̂̀̕l̸̙̯͇͌̆̈́̔́̾͌̇̊̀̈́̑͂ȩ̵̪̣̔̒̀͝ͅk̵̻̞̙̪͛̊̇̃̆̈́ā̸͚̥̹͔͓͚̲͔̬̖̉̈́͑̂̏̏̕͜p̵̢̫̞̤̞̓̾͋̃̽̑̇̈́̽͗̓͒͒͜͝͠ą̴̧̝̣̟̥̘͔̮̘̺̝͚̓̐̋͂̊̅̌͊̅͆̓̔͗̕͘ḩ̸̧̛̗̰͓̮͍͈̙̠̱̫̬̌̀͌̇̌̅͛̎͋ͅw̴̨̛̱͇̘͓̯͍͕̮͚͈͍͈͒͛̔̂̀͑͗̓̚͘͜k̷̙̹͓̥͈͕̰͕̘͔̬̀̄͌̓̚ḑ̵͖̤͚̫̗͕̣̲̹̦̊̉̊̑͋̉̈̒̃͘̕͝͠d̵̡̢̟̪̤̣̹̤̮̪͙̗͐̇̓͒̽̈̓̄́̾̓͒̂̕̕͜m̸̢̰͚̜̜̻̆̑̇̕ļ̶̧̛̫̟̗̘͙̪͓̓̒͗̀̉̇͆̀̚͜͝w̵̞͎͓̣̙͕̹̺̬͋̈́͌̔̂̇͝ḳ̴̢͓͖̥̯̳̆̋͋́̈́̔͠r̷̖̱̻͒͊̚ẽ̵̝̥̱̝̒̽̇͐̄̒̚͝h̵̢̨͚͇͚̺͎̻̘̺͍̱̯̫̞͒̓̓͒͑͂̚͝d̴̛̪̎̐́̉̍̽̉͌͘d̸̺͋̍̇̎͌̿̔̉̾̄̋͜l̷̘͍̟̗̰͉͎̬͊̓̀̾̊̽̾̕w̸̩̔̋̔̃̄̉͘n̷͇̒̀̿d̶̢̺͓̞̭͂͐̎̃w̴̡̦͓̆͗̓͜l̷̡̛̺̱̞̮̠̦̠̩̇́̋̈́̓̒͘̚͘ê̶̢̈́̐͝h̷̦͖̿̓̊̕l̶̤̮̼̖̫̹̥̙̥͐͜͝d̷̻͈͓̙̏͊͒̈̀̓̿̏̈́̕̚͝j̸̢̩̳̺̹̹̞͉̎̎́̂͊̓͗̓̒̐͛̐̀͝͠T̵͈̙̳͕̩̘̪̖̱̪̦͌̂̔ť̶̛̲̞̻̌̈́͝m̷̯̞͕͉̲̯̣̿q̵̛̞̝̣̖̫̜̊ś̴̡̢̛̮̜̟͔̭̮͙͔̦̯̯̗͇́̀́͐̓̈̏̄͌̐͐ḷ̶̹̓̑ẹ̸̢͓̣̘͈͎̜͖̺͓̹͖̓̏̈́̋̓̽̇͐͛̕͠k̶̗̈́͋̊̋͘ͅá̷̳̪͇̝͓̅̊̔̈́̌̈́͂͂̓͑p̵̻̳̽ǎ̷͍̥̼̘͍̭̰̙̞̌͝h̷͔̰̲̠̖͇̘͇̘̫̠̎̔͒̍̃͋̄͜͝w̶̨̢̝̼̹͇̺̤̗̭͋̀̈͆̚͝ķ̷̛̼̻̪͇̽͒̎̏̀̆̄͘̚͝d̴̛̙̄̅̋̿̓̿͌͝͝d̴̘̟̻̳̤̫̖͖̦̭͔͔̫̻̦͑̃̂͛̒̏́̒̎̃͂̈́̚͠m̵̗̤͇̣̜̹̯͚͔̜̥̪̓̋͗̐l̶̟͍̰̙̟̝̯̲͐͋̉̄̈́͊̉̒̍̏̎́́̒̔w̶̯̼̺͑̇̾͆̇̽̏̈́̎̅́͐̚̕͘k̵̢̨̡̘͖̺̯͓̻̫̓́̄̀̈́̄̀̎͘͜r̵̭͒e̷̢̢̡̛͇̙̱͚̲̘̫̻̭̣͊̀̌̄͑̏̑̕͝͝ͅh̷̡͎̻̗͇̟̀̎͆͊̿̈́̎͊͗͒̒d̸̛̻͙́̒̏̎̐̐̂́̚ḏ̵̨̥̥̬̺̪́̅͗̄̏̆̑̿̉̑̐̓̕͘̕ĺ̷͖͔̙̠̜̬͇̘̼̪̾͛̀̎̇̑͝͠ͅw̵̛̥̼̗͐̋͂̑̔̕̚͝͝ń̴̡̥̱̦̹͈͖̼͎͍͓̐͜ͅd̴͙̬͔̥̝̥͓̍̓̋͒̀̂̓̈́͗̓̽̕̕͜ẇ̴͕̣́̉͋̑̎́̏́́̚͝͝͝͝l̶̡̼͇̬͍̦̪̠̋̒̾͗̂͂̉͑̚͝͝͝è̵̢̗̥̞̰̻̹̬͍̩̥̚ḧ̶͍̭̮̥̤̳͉̩̞̲͕͕́̇̾́̇͒͐͐̏̊͜ͅl̷̢̜̱͚̜̳̺̬̝̭̳̫͓̔͑̏̑̏̋͌d̸̳̙̤͈̭͈̪̙̖͒͂͆̄͗͘͝͠j̴̡̧̪̟̹͍̤̮̠̣̰͑͗͋̃̆̕Ţ̵̺̭̹͚̮̘͙̬̜͇̲̣͔̾̀̽̈́͒͝t̶̢̮͖̜͒̿̈́̄̍͝ṃ̸̧̛̬̯̘̗͇̾͑͜͝q̶̤̠̮̩̥͎͖̉̒͋̀̀̔̋̍̚͝s̸̨̨͔͕͉̟͙͐͆̎l̸̫̫̓͑̾͌̿̐̆̽͜͝e̸̩̩̰̫͖̜͓̥̜̦̩͙̮̩̳͝ḵ̶̡̛̘̝̯͕̯̮̤̈́͗͊a̸̢͇̦̣̐̽́̋͐̈̔̈́͐͌͋̓̔͠p̷̢̛͔̙̱̂̿̒̄̂̾͆͐́a̷̢̡̭͈͎͔͙̤͍̲̤̪̖̹̫͐̓̇͛͊͒h̷͔̰͕̤̗̬͕͔͔̭̣͈̑̍̋̉͜͜w̴̢̦͚̗̦̩̔̉̇͛̀̕̚̚̕k̶͖̓̍͌̎̇̎̑̓̿̐͌̚̕͠d̴̖͇̈́̆̿̃d̴̨̢̜̺̜̼̗̈̊̉̊͛̉̑̀̽͛̀̐̾͝ṃ̴̢̦̹̿̈́̂̂͛͜ͅl̵̨̞͇͚̭̻̬̹̥̘̓͂͊̿̈́̃̇́͆ͅͅw̶̢͍͎͉̙̖̹̙͈͌̊k̶̛̠͓̾̅̏̌̽̏̚̚͠r̵̡̨̨̧͕̘͕͉̼̙͎̯͊͊̐̈́͌͘̚e̵̻̩̮̠̠̱̩̝͒̈̍̔̈́͐̐̀̊̅̿͘͜ͅḥ̵̛͍̖̻̪̪̦͈̣̗̭͈̻̉̇͗̈́̂̐͛̍́̌̀͝ͅd̵̙̦̺̻͍̫̼͎̠̼̰̤̈́̓͊͂d̵̬̝̝̪̝̼͚̦̻̳̠̭̅l̸̛̲͉̰̟̦̟̥w̴̨̧͈̲̱̗̗͔͚̮̏̈́̌͋́͠n̷̨̛̘͍̟̳̝͐̎͒̄̾́̈̉̄͠͝ḑ̸̨̡̢̛͕̥̟͍̲͈̮͎͙͎̓̉͋w̶̧̝͇̦̳̭͖̙̮̙̰̫̑̈́͜l̷̡̛̻̖͚͇̻̠͎̣̈́͆̀̏̃͒͊̀̏ẻ̴͙͇̟̲̭̹̱h̶̢̛̭̗̼̻͉͖͚͇̫͉͔͊́̐̊̌̃͋͂̐͗͘͜͝l̸̥̖̪̤̑̿d̵̻̖̣͓̮̫̀̒̔̾̂̾̽͌̍̚͘͘j̶̨̡͚̪̫͓̹̲̳̭̞͓̥͉͈͆̌̈͌̕Ț̶̭̠̞̺͔̩̞̏̀ţ̴͇̙̖̫̳͉́͌̆̄̚̚͠m̵̳̏̋̂̈́̄̀̑̽͝q̷̣̮͕̰̭̞̯͌͠s̴̡̯̯̭̜̭̥̱̼͉̗͔̾͒̂́̓̾̐̈͜ļ̴͖̙͎͍̦̺̺̞͈̘̏e̴̠͇͍͖̤͗͊͛͊͒̕͝k̵̡̧̨͚̖̻̪̹̪͍̣͎͆̆̾" +
                "\ną̸̡͈͉̣̟̺̝̺̞͊̎͐̏̾̓̈́́͋͝p̷̢͓̦͖̚ä̴̧̙̠̻́͛͌͑́̔͌͆̑̕͠h̸̫̬͕͍͔̫͖̹̓͆͆̄̓͛͆̔̄̚͜͝w̶̡̧̗̯͉̙͗͑͆̈̈́́̏̍̇̿̕͘k̴͓̲̮͖͗̈̈́\nd̵͔͓̩͕̳̰͘̕d̷̠̗̥̳̠̮̭̹̤̣͎̯̥̘͒͜m̸̤̠̲͖̲͛̊̋̅ļ̶̳̻̻̟̗̋͗̈́͛̈́̋͗̾͆̾̃̾͘͠w̶̳͌̆̔͐͌̀̕͘͝k̸̡̦͕̫̈́͋͐̈̂̓̿r̷̨̡̯̭͎̱̬̓̊̀̌̀͗͜e̷̩͑͗́͐͆ẖ̸̡̩̳̖͚̟̬̹̮͋̋̈̉̀͠d̴̢̧̨̡̯̮͎͉̻̲̭̺̆̉̄͜ͅd̸̢͔̼͇͍͎͓̈́̽̂̀̊͑̈͛̄͘͘̚͝l̶̡͚̟͓̾̎̀̈́̃̀͊̈̇͌̑̏̈́̃͠w̶̺̣̞̉̄͋͆́̆n̷̪̯̿̃̅̀͘d̸̜̫̬̐̀̾͒͒̂́͒̒w̷̗̘͈̮͋͛̓̓́́̌̈́͑̌̈̒̓́̕ļ̷̙͔̥̞̈́̇̈͆̎̊̈̑͑̀̓̀̽͝ė̷̢͈͎̫̹̯̤̖̜̦̺̠̉̀͜͠ḫ̸̡̦͕̘̦̩́̈̃̃͐͒̅ḷ̵̢̢͙͔̠̝͇̠̯̭͇̱̞̀̓͌͊͆̎̈́̒̂̈́͝͠d̵̲͈̺̺̪͉͇̻͖͉̻͛͆͒̈̂̈́̒̑̋̀͒̏̚̕͘j̷̝͕̮̪̃̈̚T̴͕̏̇̈̈́̊̃̊͑̓͘͠t̶̙͉͓͈̙̓̉͝m̸̡̺͚̱̞̝͚͚̿q̴̡̛͎̪̹̘́̑̿̓́͒̄̏̂͐̅ͅs̸̛̛̭̤̜̮̰̦̟̞̄͐͑̋̂̀̕l̸̙̯͇͌̆̈́̔́̾͌̇̊̀̈́̑͂ȩ̵̪̣̔̒̀͝ͅk̵̻̞̙̪͛̊̇̃̆̈́ā̸͚̥̹͔͓͚̲͔̬̖̉̈́͑̂̏̏̕͜p̵̢̫̞̤̞̓̾͋̃̽̑̇̈́̽͗̓͒͒͜͝͠ą̴̧̝̣̟̥̘͔̮̘̺̝͚̓̐̋͂̊̅̌͊̅͆̓̔͗̕͘ḩ̸̧̛̗̰͓̮͍͈̙̠̱̫̬̌̀͌̇̌̅͛̎͋ͅw̴̨̛̱͇̘͓̯͍͕̮͚͈͍͈͒͛̔̂̀͑͗̓̚͘͜k̷̙̹͓̥͈͕̰͕̘͔̬̀̄͌̓̚ḑ̵͖̤͚̫̗͕̣̲̹̦̊̉̊̑͋̉̈̒̃͘̕͝͠d̵̡̢̟̪̤̣̹̤̮̪͙̗͐̇̓͒̽̈̓̄́̾̓͒̂̕̕͜m̸̢̰͚̜̜̻̆̑̇̕ļ̶̧̛̫̟̗̘͙̪͓̓̒͗̀̉̇͆̀̚͜͝w̵̞͎͓̣̙͕̹̺̬͋̈́͌̔̂̇͝ḳ̴̢͓͖̥̯̳̆̋͋́̈́̔͠r̷̖̱̻͒͊̚ẽ̵̝̥̱̝̒̽̇͐̄̒̚͝h̵̢̨͚͇͚̺͎̻̘̺͍̱̯̫̞͒̓̓͒͑͂̚͝d̴̛̪̎̐́̉̍̽̉͌͘d̸̺͋̍̇̎͌̿̔̉̾̄̋͜l̷̘͍̟̗̰͉͎̬͊̓̀̾̊̽̾̕w̸̩̔̋̔̃̄̉͘n̷͇̒̀̿d̶̢̺͓̞̭͂͐̎̃w̴̡̦͓̆͗̓͜l̷̡̛̺̱̞̮̠̦̠̩̇́̋̈́̓̒͘̚͘ê̶̢̈́̐͝h̷̦͖̿̓̊̕l̶̤̮̼̖̫̹̥̙̥͐͜͝d̷̻͈͓̙̏͊͒̈̀̓̿̏̈́̕̚͝j̸̢̩̳̺̹̹̞͉̎̎́̂͊̓͗̓̒̐͛̐̀͝͠T̵͈̙̳͕̩̘̪̖̱̪̦͌̂̔ť̶̛̲̞̻̌̈́͝m̷̯̞͕͉̲̯̣̿q̵̛̞̝̣̖̫̜̊ś̴̡̢̛̮̜̟͔̭̮͙͔̦̯̯̗͇́̀́͐̓̈̏̄͌̐͐ḷ̶̹̓̑ẹ̸̢͓̣̘͈͎̜͖̺͓̹͖̓̏̈́̋̓̽̇͐͛̕͠k̶̗̈́͋̊̋͘ͅá̷̳̪͇̝͓̅̊̔̈́̌̈́͂͂̓͑p̵̻̳̽ǎ̷͍̥̼̘͍̭̰̙̞̌͝h̷͔̰̲̠̖͇̘͇̘̫̠̎̔͒̍̃͋̄͜͝w̶̨̢̝̼̹͇̺̤̗̭͋̀̈͆̚͝ķ̷̛̼̻̪͇̽͒̎̏̀̆̄͘̚͝d̴̛̙̄̅̋̿̓̿͌͝͝d̴̘̟̻̳̤̫̖͖̦̭͔͔̫̻̦͑̃̂͛̒̏́̒̎̃͂̈́̚͠m̵̗̤͇̣̜̹̯͚͔̜̥̪̓̋͗̐l̶̟͍̰̙̟̝̯̲͐͋̉̄̈́͊̉̒̍̏̎́́̒̔w̶̯̼̺͑̇̾͆̇̽̏̈́̎̅́͐̚̕͘k̵̢̨̡̘͖̺̯͓̻̫̓́̄̀̈́̄̀̎͘͜r̵̭͒e̷̢̢̡̛͇̙̱͚̲̘̫̻̭̣͊̀̌̄͑̏̑̕͝͝ͅh̷̡͎̻̗͇̟̀̎͆͊̿̈́̎͊͗͒̒d̸̛̻͙́̒̏̎̐̐̂́̚ḏ̵̨̥̥̬̺̪́̅͗̄̏̆̑̿̉̑̐̓̕͘̕ĺ̷͖͔̙̠̜̬͇̘̼̪̾͛̀̎̇̑͝͠ͅw̵̛̥̼̗͐̋͂̑̔̕̚͝͝ń̴̡̥̱̦̹͈͖̼͎͍͓̐͜ͅd̴͙̬͔̥̝̥͓̍̓̋͒̀̂̓̈́͗̓̽̕̕͜ẇ̴͕̣́̉͋̑̎́̏́́̚͝͝͝͝l̶̡̼͇̬͍̦̪̠̋̒̾͗̂͂̉͑̚͝͝͝è̵̢̗̥̞̰̻̹̬͍̩̥̚ḧ̶͍̭̮̥̤̳͉̩̞̲͕͕́̇̾́̇͒͐͐̏̊͜ͅl̷̢̜̱͚̜̳̺̬̝̭̳̫͓̔͑̏̑̏̋͌d̸̳̙̤͈̭͈̪̙̖͒͂͆̄͗͘͝͠j̴̡̧̪̟̹͍̤̮̠̣̰͑͗͋̃̆̕Ţ̵̺̭̹͚̮̘͙̬̜͇̲̣͔̾̀̽̈́͒͝t̶̢̮͖̜͒̿̈́̄̍͝ṃ̸̧̛̬̯̘̗͇̾͑͜͝q̶̤̠̮̩̥͎͖̉̒͋̀̀̔̋̍̚͝s̸̨̨͔͕͉̟͙͐͆̎l̸̫̫̓͑̾͌̿̐̆̽͜͝e̸̩̩̰̫͖̜͓̥̜̦̩͙̮̩̳͝ḵ̶̡̛̘̝̯͕̯̮̤̈́͗͊a̸̢͇̦̣̐̽́̋͐̈̔̈́͐͌͋̓̔͠p̷̢̛͔̙̱̂̿̒̄̂̾͆͐́a̷̢̡̭͈͎͔͙̤͍̲̤̪̖̹̫͐̓̇͛͊͒h̷͔̰͕̤̗̬͕͔͔̭̣͈̑̍̋̉͜͜w̴̢̦͚̗̦̩̔̉̇͛̀̕̚̚̕k̶͖̓̍͌̎̇̎̑̓̿̐͌̚̕͠d̴̖͇̈́̆̿̃d̴̨̢̜̺̜̼̗̈̊̉̊͛̉̑̀̽͛̀̐̾͝ṃ̴̢̦̹̿̈́̂̂͛͜ͅl̵̨̞͇͚̭̻̬̹̥̘̓͂͊̿̈́̃̇́͆ͅͅw̶̢͍͎͉̙̖̹̙͈͌̊k̶̛̠͓̾̅̏̌̽̏̚̚͠r̵̡̨̨̧͕̘͕͉̼̙͎̯͊͊̐̈́͌͘̚e̵̻̩̮̠̠̱̩̝͒̈̍̔̈́͐̐̀̊̅̿͘͜ͅḥ̵̛͍̖̻̪̪̦͈̣̗̭͈̻̉̇͗̈́̂̐͛̍́̌̀͝ͅd̵̙̦̺̻͍̫̼͎̠̼̰̤̈́̓͊͂d̵̬̝̝̪̝̼͚̦̻̳̠̭̅l̸̛̲͉̰̟̦̟̥w̴̨̧͈̲̱̗̗͔͚̮̏̈́̌͋́͠n̷̨̛̘͍̟̳̝͐̎͒̄̾́̈̉̄͠͝ḑ̸̨̡̢̛͕̥̟͍̲͈̮͎͙͎̓̉͋w̶̧̝͇̦̳̭͖̙̮̙̰̫̑̈́͜l̷̡̛̻̖͚͇̻̠͎̣̈́͆̀̏̃͒͊̀̏ẻ̴͙͇̟̲̭̹̱h̶̢̛̭̗̼̻͉͖͚͇̫͉͔͊́̐̊̌̃͋͂̐͗͘͜͝l̸̥̖̪̤̑̿d̵̻̖̣͓̮̫̀̒̔̾̂̾̽͌̍̚͘͘j̶̨̡͚̪̫͓̹̲̳̭̞͓̥͉͈͆̌̈͌̕Ț̶̭̠̞̺͔̩̞̏̀ţ̴͇̙̖̫̳͉́͌̆̄̚̚͠m̵̳̏̋̂̈́̄̀̑̽͝q̷̣̮͕̰̭̞̯͌͠s̴̡̯̯̭̜̭̥̱̼͉̗͔̾͒̂́̓̾̐̈͜ļ̴͖̙͎͍̦̺̺̞͈̘̏e̴̠͇͍͖̤͗͊͛͊͒̕͝k̵̡̧̨͚̖̻̪̹̪͍̣͎͆̆̾" +
                "\ną̸̡͈͉̣̟̺̝̺̞͊̎͐̏̾̓̈́́͋͝p̷̢͓̦͖̚ä̴̧̙̠̻́͛͌͑́̔͌͆̑̕͠h̸̫̬͕͍͔̫͖̹̓͆͆̄̓͛͆̔̄̚͜͝w̶̡̧̗̯͉̙͗͑͆̈̈́́̏̍̇̿̕͘k̴͓̲̮͖͗̈̈́\nd̵͔͓̩͕̳̰͘̕d̷̠̗̥̳̠̮̭̹̤̣͎̯̥̘͒͜m̸̤̠̲͖̲͛̊̋̅ļ̶̳̻̻̟̗̋͗̈́͛̈́̋͗̾͆̾̃̾͘͠w̶̳͌̆̔͐͌̀̕͘͝k̸̡̦͕̫̈́͋͐̈̂̓̿r̷̨̡̯̭͎̱̬̓̊̀̌̀͗͜e̷̩͑͗́͐͆ẖ̸̡̩̳̖͚̟̬̹̮͋̋̈̉̀͠d̴̢̧̨̡̯̮͎͉̻̲̭̺̆̉̄͜ͅd̸̢͔̼͇͍͎͓̈́̽̂̀̊͑̈͛̄͘͘̚͝l̶̡͚̟͓̾̎̀̈́̃̀͊̈̇͌̑̏̈́̃͠w̶̺̣̞̉̄͋͆́̆n̷̪̯̿̃̅̀͘d̸̜̫̬̐̀̾͒͒̂́͒̒w̷̗̘͈̮͋͛̓̓́́̌̈́͑̌̈̒̓́̕ļ̷̙͔̥̞̈́̇̈͆̎̊̈̑͑̀̓̀̽͝ė̷̢͈͎̫̹̯̤̖̜̦̺̠̉̀͜͠ḫ̸̡̦͕̘̦̩́̈̃̃͐͒̅ḷ̵̢̢͙͔̠̝͇̠̯̭͇̱̞̀̓͌͊͆̎̈́̒̂̈́͝͠d̵̲͈̺̺̪͉͇̻͖͉̻͛͆͒̈̂̈́̒̑̋̀͒̏̚̕͘j̷̝͕̮̪̃̈̚T̴͕̏̇̈̈́̊̃̊͑̓͘͠t̶̙͉͓͈̙̓̉͝m̸̡̺͚̱̞̝͚͚̿q̴̡̛͎̪̹̘́̑̿̓́͒̄̏̂͐̅ͅs̸̛̛̭̤̜̮̰̦̟̞̄͐͑̋̂̀̕l̸̙̯͇͌̆̈́̔́̾͌̇̊̀̈́̑͂ȩ̵̪̣̔̒̀͝ͅk̵̻̞̙̪͛̊̇̃̆̈́ā̸͚̥̹͔͓͚̲͔̬̖̉̈́͑̂̏̏̕͜p̵̢̫̞̤̞̓̾͋̃̽̑̇̈́̽͗̓͒͒͜͝͠ą̴̧̝̣̟̥̘͔̮̘̺̝͚̓̐̋͂̊̅̌͊̅͆̓̔͗̕͘ḩ̸̧̛̗̰͓̮͍͈̙̠̱̫̬̌̀͌̇̌̅͛̎͋ͅw̴̨̛̱͇̘͓̯͍͕̮͚͈͍͈͒͛̔̂̀͑͗̓̚͘͜k̷̙̹͓̥͈͕̰͕̘͔̬̀̄͌̓̚ḑ̵͖̤͚̫̗͕̣̲̹̦̊̉̊̑͋̉̈̒̃͘̕͝͠d̵̡̢̟̪̤̣̹̤̮̪͙̗͐̇̓͒̽̈̓̄́̾̓͒̂̕̕͜m̸̢̰͚̜̜̻̆̑̇̕ļ̶̧̛̫̟̗̘͙̪͓̓̒͗̀̉̇͆̀̚͜͝w̵̞͎͓̣̙͕̹̺̬͋̈́͌̔̂̇͝ḳ̴̢͓͖̥̯̳̆̋͋́̈́̔͠r̷̖̱̻͒͊̚ẽ̵̝̥̱̝̒̽̇͐̄̒̚͝h̵̢̨͚͇͚̺͎̻̘̺͍̱̯̫̞͒̓̓͒͑͂̚͝d̴̛̪̎̐́̉̍̽̉͌͘d̸̺͋̍̇̎͌̿̔̉̾̄̋͜l̷̘͍̟̗̰͉͎̬͊̓̀̾̊̽̾̕w̸̩̔̋̔̃̄̉͘n̷͇̒̀̿d̶̢̺͓̞̭͂͐̎̃w̴̡̦͓̆͗̓͜l̷̡̛̺̱̞̮̠̦̠̩̇́̋̈́̓̒͘̚͘ê̶̢̈́̐͝h̷̦͖̿̓̊̕l̶̤̮̼̖̫̹̥̙̥͐͜͝d̷̻͈͓̙̏͊͒̈̀̓̿̏̈́̕̚͝j̸̢̩̳̺̹̹̞͉̎̎́̂͊̓͗̓̒̐͛̐̀͝͠T̵͈̙̳͕̩̘̪̖̱̪̦͌̂̔ť̶̛̲̞̻̌̈́͝m̷̯̞͕͉̲̯̣̿q̵̛̞̝̣̖̫̜̊ś̴̡̢̛̮̜̟͔̭̮͙͔̦̯̯̗͇́̀́͐̓̈̏̄͌̐͐ḷ̶̹̓̑ẹ̸̢͓̣̘͈͎̜͖̺͓̹͖̓̏̈́̋̓̽̇͐͛̕͠k̶̗̈́͋̊̋͘ͅá̷̳̪͇̝͓̅̊̔̈́̌̈́͂͂̓͑p̵̻̳̽ǎ̷͍̥̼̘͍̭̰̙̞̌͝h̷͔̰̲̠̖͇̘͇̘̫̠̎̔͒̍̃͋̄͜͝w̶̨̢̝̼̹͇̺̤̗̭͋̀̈͆̚͝ķ̷̛̼̻̪͇̽͒̎̏̀̆̄͘̚͝d̴̛̙̄̅̋̿̓̿͌͝͝d̴̘̟̻̳̤̫̖͖̦̭͔͔̫̻̦͑̃̂͛̒̏́̒̎̃͂̈́̚͠m̵̗̤͇̣̜̹̯͚͔̜̥̪̓̋͗̐l̶̟͍̰̙̟̝̯̲͐͋̉̄̈́͊̉̒̍̏̎́́̒̔w̶̯̼̺͑̇̾͆̇̽̏̈́̎̅́͐̚̕͘k̵̢̨̡̘͖̺̯͓̻̫̓́̄̀̈́̄̀̎͘͜r̵̭͒e̷̢̢̡̛͇̙̱͚̲̘̫̻̭̣͊̀̌̄͑̏̑̕͝͝ͅh̷̡͎̻̗͇̟̀̎͆͊̿̈́̎͊͗͒̒d̸̛̻͙́̒̏̎̐̐̂́̚ḏ̵̨̥̥̬̺̪́̅͗̄̏̆̑̿̉̑̐̓̕͘̕ĺ̷͖͔̙̠̜̬͇̘̼̪̾͛̀̎̇̑͝͠ͅw̵̛̥̼̗͐̋͂̑̔̕̚͝͝ń̴̡̥̱̦̹͈͖̼͎͍͓̐͜ͅd̴͙̬͔̥̝̥͓̍̓̋͒̀̂̓̈́͗̓̽̕̕͜ẇ̴͕̣́̉͋̑̎́̏́́̚͝͝͝͝l̶̡̼͇̬͍̦̪̠̋̒̾͗̂͂̉͑̚͝͝͝è̵̢̗̥̞̰̻̹̬͍̩̥̚ḧ̶͍̭̮̥̤̳͉̩̞̲͕͕́̇̾́̇͒͐͐̏̊͜ͅl̷̢̜̱͚̜̳̺̬̝̭̳̫͓̔͑̏̑̏̋͌d̸̳̙̤͈̭͈̪̙̖͒͂͆̄͗͘͝͠j̴̡̧̪̟̹͍̤̮̠̣̰͑͗͋̃̆̕Ţ̵̺̭̹͚̮̘͙̬̜͇̲̣͔̾̀̽̈́͒͝t̶̢̮͖̜͒̿̈́̄̍͝ṃ̸̧̛̬̯̘̗͇̾͑͜͝q̶̤̠̮̩̥͎͖̉̒͋̀̀̔̋̍̚͝s̸̨̨͔͕͉̟͙͐͆̎l̸̫̫̓͑̾͌̿̐̆̽͜͝e̸̩̩̰̫͖̜͓̥̜̦̩͙̮̩̳͝ḵ̶̡̛̘̝̯͕̯̮̤̈́͗͊a̸̢͇̦̣̐̽́̋͐̈̔̈́͐͌͋̓̔͠p̷̢̛͔̙̱̂̿̒̄̂̾͆͐́a̷̢̡̭͈͎͔͙̤͍̲̤̪̖̹̫͐̓̇͛͊͒h̷͔̰͕̤̗̬͕͔͔̭̣͈̑̍̋̉͜͜w̴̢̦͚̗̦̩̔̉̇͛̀̕̚̚̕k̶͖̓̍͌̎̇̎̑̓̿̐͌̚̕͠d̴̖͇̈́̆̿̃d̴̨̢̜̺̜̼̗̈̊̉̊͛̉̑̀̽͛̀̐̾͝ṃ̴̢̦̹̿̈́̂̂͛͜ͅl̵̨̞͇͚̭̻̬̹̥̘̓͂͊̿̈́̃̇́͆ͅͅw̶̢͍͎͉̙̖̹̙͈͌̊k̶̛̠͓̾̅̏̌̽̏̚̚͠r̵̡̨̨̧͕̘͕͉̼̙͎̯͊͊̐̈́͌͘̚e̵̻̩̮̠̠̱̩̝͒̈̍̔̈́͐̐̀̊̅̿͘͜ͅḥ̵̛͍̖̻̪̪̦͈̣̗̭͈̻̉̇͗̈́̂̐͛̍́̌̀͝ͅd̵̙̦̺̻͍̫̼͎̠̼̰̤̈́̓͊͂d̵̬̝̝̪̝̼͚̦̻̳̠̭̅l̸̛̲͉̰̟̦̟̥w̴̨̧͈̲̱̗̗͔͚̮̏̈́̌͋́͠n̷̨̛̘͍̟̳̝͐̎͒̄̾́̈̉̄͠͝ḑ̸̨̡̢̛͕̥̟͍̲͈̮͎͙͎̓̉͋w̶̧̝͇̦̳̭͖̙̮̙̰̫̑̈́͜l̷̡̛̻̖͚͇̻̠͎̣̈́͆̀̏̃͒͊̀̏ẻ̴͙͇̟̲̭̹̱h̶̢̛̭̗̼̻͉͖͚͇̫͉͔͊́̐̊̌̃͋͂̐͗͘͜͝l̸̥̖̪̤̑̿d̵̻̖̣͓̮̫̀̒̔̾̂̾̽͌̍̚͘͘j̶̨̡͚̪̫͓̹̲̳̭̞͓̥͉͈͆̌̈͌̕Ț̶̭̠̞̺͔̩̞̏̀ţ̴͇̙̖̫̳͉́͌̆̄̚̚͠m̵̳̏̋̂̈́̄̀̑̽͝q̷̣̮͕̰̭̞̯͌͠s̴̡̯̯̭̜̭̥̱̼͉̗͔̾͒̂́̓̾̐̈͜ļ̴͖̙͎͍̦̺̺̞͈̘̏e̴̠͇͍͖̤͗͊͛͊͒̕͝k̵̡̧̨͚̖̻̪̹̪͍̣͎͆̆̾");

            theScene9 = new CScene("Scn9");
            theScene9.AddImageAndText(Image.FromFile("Images/memojang.jpg"));
            theScene9.AddButton("▶", "Scn10");
            theScene9.AddText("그러다가 창문쪽에서 이상한 기척이 느껴지는 거야...");
            theScene9.AddText("난 두려운 마음에 고개를 돌리지 않고 가만히 있다가 기척이 심해지자 \n창문 쪽을 실눈을 뜬 채 조금만 고개를 돌렸어");

            theScene10 = new CScene("Scn10");
            theScene10.AddImageAndText(Image.FromFile("Images/window.jpg"));
            theScene10.AddButton("▶", "Scn11");
            theScene10.AddText("");
            theScene10.AddText("창문을 쳐다봤는데 나만 보이고 아무것도 보이지 않았는데 이상하게 소름이 돋았어..");
            theScene10.AddText("난 그냥 잘못 느낀 거겠지 하면서 다시 돌아가려는데..");
            theScene10.AddText("......");
            theScene10.AddText("그 뒤로 그 방을 쓰지 않았을 때 그 방을 쓰고 있는 친구들에게 물어봤는데");
            theScene10.AddText("아무런 일이 일어나지 않았대");
            theScene10.AddText("어떤 친구가 비어있는 침대에서 소리를 들은 것만 빼고는....");

            theScene11 = new CScene("Scn11");
            theScene11.AddImageAndText(Image.FromFile("Images/window_jump3.jpg"));
            theScene11.AddButton("▶", "Scn12");

            theScene12 = new CScene("Scn12");
            theScene12.AddImageAndText(Image.FromFile("Images/black.jpg"));
            theScene12.AddButton("▶", "Scn1");




            theScenes = new SortedList<string, CScene>();

            theScenes.Add(theScene1.theID, theScene1);
            theScenes.Add(theScene2.theID, theScene2);
            theScenes.Add(theScene3.theID, theScene3);
            theScenes.Add(theScene4.theID, theScene4);
            theScenes.Add(theScene5.theID, theScene5);
            theScenes.Add(theScene6.theID, theScene6);
            theScenes.Add(theScene7.theID, theScene7);
            theScenes.Add(theScene8.theID, theScene8);
            theScenes.Add(theScene9.theID, theScene9);
            theScenes.Add(theScene10.theID, theScene10);
            theScenes.Add(theScene11.theID, theScene11);
            theScenes.Add(theScene12.theID, theScene12);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //            theCurrentScene = theScenes[theCurrentScene.theNextScenes[1]];

            ////            pictureBox1.Image = theCurrentScene.theImages[0];

            //            Text = theCurrentScene.theID;
            //            Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(theCurrentScene.theImages[0], 0, 0, this.Width, this.Height);
            if (theCurrentScene.STexts.Count > 0)
            {
                e.Graphics.DrawImage(imgMal, 15, 320, imgMal.Width, imgMal.Height);
                e.Graphics.DrawString(theCurrentScene.STexts[theTextIndex], theFont, theBrush, 35, 340);
            }
            if (bBtnHighlighted == 1)
            {
                ColorMatrix cm = new ColorMatrix();
                cm.Matrix33 = 1.0f;
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);
                e.Graphics.DrawImage(imgBtn1, new Rectangle(216, 186, imgBtn1.Width, imgBtn1.Height), 0, 0, imgBtn1.Width, imgBtn1.Height, GraphicsUnit.Pixel, ia);

            }
            else
            {
                ColorMatrix cm = new ColorMatrix();
                cm.Matrix33 = 0.5f;
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);
              //e.Graphics.DrawImage(imgBtn1, new Rectangle(216, 186, imgBtn1.Width, imgBtn1.Height), 0, 0, imgBtn1.Width, imgBtn1.Height, GraphicsUnit.Pixel, ia);

            }
        }

        private void Image_Paint(object sender, PaintEventArgs e)
        {
            if (length < testStr.Length)
            {
                e.Graphics.DrawString(testStr.Substring(0, length), theFont, theBrush, 50, 400);
            }
            else
            {
                e.Graphics.DrawString(testStr, theFont, theBrush, 50, 400);

            }
        }

        public int bNextWord = 0;
        public int theTextIndex = 0;

        public int bBtnHighlighted = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (216 < e.X && e.X < 558)
            {
                if (186 < e.Y && e.Y < 233)
                {
                    bBtnHighlighted = 1;
                    return;
                }
            }
            bBtnHighlighted = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Text = String.Format("{0}, {1}", e.X, e.Y);

            if (216 < e.X && e.X < 558)
            {
                if (286 < e.Y && e.Y < 333)
                {
                    theCurrentScene = theScenes[theCurrentScene.theNextScenes[0]];
                    //                    theCurrentScene.CheckNextScene();
                }
            }
            if (721 < e.X && e.X < 746)
            {
                if (508 < e.Y && e.Y < 524)
                {
                    bNextWord = 1;
                }
            }

            if (bNextWord == 1)
            {
                theTextIndex++;
                if (theTextIndex >= theCurrentScene.STexts.Count)
                {
                    theTextIndex = 0;
                    theCurrentScene = theScenes[theCurrentScene.theNextScenes[0]];
                    //                    theCurrentScene.CheckNextWord();
                    // theTextIndex = theCurrentScene.STexts.Count - 1;
                }
            }
            //           Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            length++;
            Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            theCurrentScene = theScenes[theCurrentScene.theNextScenes[0]];
            button1.Text = theCurrentScene.theTexts[0];
            Text = theCurrentScene.theID;

            bNextWord = 0;
            theTextIndex = 0;

            Invalidate();
        }
        /*
                private void Form1_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        theTextIndex++;
                        if (theTextIndex >= theCurrentScene.STexts.Count)
                        {
                            theTextIndex = 0;
                            theCurrentScene = theScenes[theCurrentScene.theNextScenes[0]];
                             theTextIndex = theCurrentScene.STexts.Count - 1;
                        }
                    }
                    if (e.KeyCode == Keys.Enter)
                    {
                        theCurrentScene = theScenes[theCurrentScene.theNextScenes[0]];
                        button1.Text = theCurrentScene.theTexts[0];
                        Text = theCurrentScene.theID;

                        bNextWord = 0;
                        theTextIndex = 0;

                        Invalidate();
                    }
                }
        */
        private void SText_set(object sender, EventArgs e)
        {
            //SText1.Text = "아~ 심심해 야 우리 무서운 얘기나 할래? (클릭해서 다음으로)";
        }

        private void SText1_MouseClick(object sender, MouseEventArgs e)
        {



        }







    }
}
