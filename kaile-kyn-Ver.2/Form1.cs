using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Security.Cryptography;
using System.Diagnostics;


namespace kaile_kyn_Ver._2
{
    public partial class Form1 : Form
    {
        bool ispattern1End = false;
        bool ispattern2End = false;
        bool ispattern3End = false;
        bool ispattern4End = false;
        bool ispattern5End = false;
        bool ispattern6End = false;

        

        String[] netsuword = new string[] { "やぁ　僕の名前はカイル", "\r\n" + "こんなご時世だから、もちろん熱を計った上で" + "\r\n" + "パソコンを触ってるんだよね？", "\r\n" + "何度だったか教えてくれない？" };

        String[] washword = new string[] { "手洗いの正しいやり方って結構普及してないんだよね", "\r\n" + "時には初心に帰って勉強することも大事だよ" };

        String[] ugaiword = new string[] { "この部屋.......", "\r\n" + "空気が淀んでいるんだけど...", "\r\n" + "そろそろ換気しな？" };

        String[] shoudokuword = new string[] { "パソコン触る前にしっかり消毒した？", "\r\n" + "ちゃんと使っているならそろそろなくなるよね？", "\r\n" + "しっかり買っとこう" };

        String[] koikeword = new string[] { "最近コロナ減ったよね～", "\r\n" + "だから最近コロナ対策怠ってるんじゃない？", "\r\n" + "こんな時はあの方のメッセージをもう一度見てみよう！！" };

        String[] gokigenword = new string[] { "ふぅ～...", "\r\n" + "これで一応コロナ対策は出来たかな！", "\r\n" + "僕がいなくてもしっかりと対策するんだよ？", "\r\n" + "じゃあね♪　バイバイ！" };

        public Form1()
        {
            InitializeComponent();
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@".\serif3.wav");
            simpleSound.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            // ウィンドウを画面右下に表示させる
            int left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            DesktopBounds = new Rectangle(left, top, this.Width, this.Height);

            label2.Visible = false;
            if (label1.Visible == false)
            {
                label1.Visible = true;

            }

            pictureBox1.ImageLocation = @".\kaile_move.gif";
            printstring1(netsuword);
            //ispattern1End = true;



            //pictureBox1.ImageLocation = @".\kaile_stop.gif";


        }
        //熱の発言だけ違う関数を用いる。
        private async void printstring1(string[] delayword)
        {

            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);

            }
            async Task OutputMessage(string s)
            {
                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            textBox1.Visible = true;
            button1.Visible = true;
            button3.Enabled = true;
        }
        private async void printstring2(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);
            }
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Jmk4mrR3RVA");
            async Task OutputMessage(string s)
            {

                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }
        private async void printstring3(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);
            }
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=wh8WGnejYJY");
            async Task OutputMessage(string s)
            {
                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }
        private async void printstring4(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);
            }
            System.Diagnostics.Process.Start("https://www.amazon.co.jp/%E6%B6%88%E6%AF%92%E7%94%A8%E3%82%A2%E3%83%AB%E3%82%B3%E3%83%BC%E3%83%AB/s?k=%E6%B6%88%E6%AF%92%E7%94%A8%E3%82%A2%E3%83%AB%E3%82%B3%E3%83%BC%E3%83%AB");
            async Task OutputMessage(string s)
            {

                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }
        //熱の関数以外はここで関数を用いる。
        private async void printstring5(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);
            }
            async Task OutputMessage(string s)
            {
                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }
        private async void printstring6(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                await Task.Delay(waitTimeLine);
            }
            async Task OutputMessage(string s)
            {
                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }







        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //バックスペースと小数点使用可能とする
                if (e.KeyChar == 0x08 || e.KeyChar == '.')
                {
                    return;
                }

                //数字キー以外の入力をキャンセルする
                if (e.KeyChar < 0x30 || e.KeyChar > 0x39)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }

        bool isDelete = false;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            isDelete = (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back);
        }

        //整数部桁数
        private readonly int LENGTH_INT_PART = 2;
        //小数部桁数
        private readonly int LENGTH_DECIMAL_PLACES = 1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;

            txtBox.TextChanged -= textBox1_TextChanged;

            try
            {
                if (!string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    var value = txtBox.Text;
                    //整数と小数を分割する
                    string[] values = value.Split('.');

                    int currentPoint = 0;
                    switch (values.Length)
                    {
                        case 1:
                            //------------------------------
                            //整数部のみで構成されている場合
                            //------------------------------
                            //整数部の最大桁数を超えた場合、今回の入力値を無効にする
                            if (value.Length > LENGTH_INT_PART)
                            {
                                //DELETEやBackSpaceによる削除で桁あふれが発生しているなら
                                //小数点の削除によるものなので、先頭桁から削除する
                                if (isDelete)
                                {
                                    txtBox.Text = value.Substring(value.Length - LENGTH_INT_PART);

                                    //カーソル位置を移動
                                    if (currentPoint - (values.Length - LENGTH_INT_PART) >= 0)
                                    {
                                        txtBox.SelectionStart = currentPoint -
                                            (values.Length - LENGTH_INT_PART);
                                    }
                                    else
                                    {
                                        txtBox.SelectionStart = 0;
                                    }
                                }
                                else
                                {
                                    //入力後の現カーソル位置を取得
                                    currentPoint = txtBox.SelectionStart;

                                    //カーソル位置の前の１文字が今回入力された文字、
                                    //よって、それを省いた文字列に編集する
                                    var left = value.Substring(0
                                        , currentPoint > LENGTH_INT_PART
                                            ? LENGTH_INT_PART : currentPoint - 1);
                                    var right = left.Length >= LENGTH_INT_PART
                                        ? "" : value.Substring(currentPoint);
                                    txtBox.Text = left + right;

                                    //カーソル位置を入力前の位置に戻す
                                    txtBox.SelectionStart = currentPoint - 1;
                                }
                            }
                            break;

                        case 2:
                            //----------------------------------
                            //整数部＋小数部で構成されている場合
                            //----------------------------------
                            //入力後の現カーソル位置を取得
                            currentPoint = txtBox.SelectionStart;

                            //今回の入力値が"."の場合、小数点を基準点として桁あふれ分を除外する
                            if (value.Substring(currentPoint - 1, 1) == ".")
                            {
                                //=== 整数部の処理 ===
                                var intPart = values[0];
                                if (values[0].Length > LENGTH_INT_PART)
                                {
                                    intPart = values[0].Substring(LENGTH_INT_PART - values[0].Length);
                                }

                                //=== 小数部の処理 ===
                                var decimalPart = values[1];
                                if (values[1].Length > LENGTH_DECIMAL_PLACES)
                                {
                                    decimalPart = values[1].Substring(0, LENGTH_DECIMAL_PLACES);
                                }

                                //整数と小数を結合
                                if (values[0].Length > LENGTH_INT_PART || values[1].Length > LENGTH_DECIMAL_PLACES)
                                {
                                    txtBox.Text = string.Format("{0}.{1}", intPart, decimalPart);

                                    //小数点入力時なら小数点の後ろにカーソルをセット
                                    txtBox.SelectionStart = value.IndexOf(".") + 1;
                                }
                            }
                            else
                            {
                                //=== 整数部の処理 ===
                                var intPart = values[0];
                                if (values[0].Length > LENGTH_INT_PART)
                                {
                                    //カーソル位置の前の１文字が今回入力された文字、
                                    //よって、それを省いた文字列に編集する
                                    var left = values[0].Substring(0
                                        , currentPoint > LENGTH_INT_PART
                                            ? LENGTH_INT_PART : currentPoint - 1);
                                    var right = left.Length >= LENGTH_INT_PART
                                        ? "" : values[0].Substring(currentPoint);

                                    //桁数調整後の整数部文字列
                                    intPart = left + right;
                                }

                                //=== 小数部の処理 ===
                                var decimalPart = values[1];
                                if (values[1].Length > LENGTH_DECIMAL_PLACES)
                                {
                                    //整数部と小数点を除いたときのカーソル位置を算出
                                    var tempPoint = currentPoint - values[0].Length - 1;
                                    //カーソル位置の前の１文字を除外する
                                    var left = values[1].Substring(0
                                        , tempPoint > LENGTH_DECIMAL_PLACES
                                            ? LENGTH_DECIMAL_PLACES : tempPoint - 1);
                                    var right = left.Length >= LENGTH_DECIMAL_PLACES
                                            ? "" : values[1].Substring(tempPoint);

                                    //桁数調整後の小数部文字列
                                    decimalPart = left + right;
                                }

                                //整数と小数を結合
                                if (values[0].Length > LENGTH_INT_PART || values[1].Length > LENGTH_DECIMAL_PLACES)
                                {
                                    txtBox.Text = string.Format("{0}.{1}", intPart, decimalPart);

                                    //カーソル位置を入力前の位置に戻す
                                    txtBox.SelectionStart = currentPoint - 1;
                                }
                            }

                            break;

                        default:
                            //"."で文字列を分割したときに３以上になるのなら、
                            //既に"."が存在しているのに今回"."が入力されたことを示す
                            //よって、今回の入力を無効にしてしまう。
                            {
                                currentPoint = txtBox.SelectionStart;
                                var left = value.Substring(0, currentPoint - 1);
                                var right = value.Substring(currentPoint);
                                txtBox.Text = left + right;
                                txtBox.SelectionStart = currentPoint - 1;
                            }
                            break;
                    }

                    //先頭が小数点なら先頭に 0 を入れる
                    if (txtBox.Text.StartsWith("."))
                    {
                        currentPoint = txtBox.SelectionStart;
                        txtBox.Text = "0" + txtBox.Text;
                        txtBox.SelectionStart = currentPoint + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            finally
            {
                txtBox.TextChanged += textBox1_TextChanged;
            }
            this.label3.Text = txtBox.Text;

        }
        int cnt = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("今朝計った温度は" + label3.Text + "℃でよろしいですか？",
             "確認だよ",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);
            double Btemp = double.Parse(label3.Text);

            String[] konetsuword = new string[] { "今すぐにパソコンをやめろ" };

            String[] binetsuword = new string[] { "......え？", "\r\n" + "聞き間違いだと思うからもう一回聞くね？", "\r\n" + "今朝何度だった？" };

            String[] heinetuword = new string[] { "ふ～ん、まぁ熱がない事は当然だけどね" };

            String[] angryword = new string[] { "熱があるくせにパソコン触ってんじゃねぇよ", "\r\n" + "熱を直してから出直してね♪" };



            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                textBox1.Visible = false;
                button1.Visible = false;
                ispattern1End = true;
                button3.Enabled = false;

                if (Btemp > 37.3)
                {

                    printWord(konetsuword);
                    pictureBox1.ImageLocation = @".\kaile_move.gif";
                    await Task.Delay(3000);
                    this.Close();
                }
                else if ((Btemp > 36.9) && (Btemp < 37.4))
                {

                    cnt += 1;
                    if (cnt > 2)
                    {
                        printWord(angryword);
                        pictureBox1.ImageLocation = @".\kaile_move.gif";
                        await Task.Delay(3000);
                        this.Close();
                    }
                    else
                    {
                        printWord(binetsuword);
                        pictureBox1.ImageLocation = @".\kaile_move.gif";
                        textBox1.ResetText();
                        textBox1.Visible = true;
                        button1.Visible = true;
                    }





                }
                else if ((Btemp > 35.9) && (Btemp < 37.0))
                {
                    
                    printWord(heinetuword);
                    pictureBox1.ImageLocation = @".\kaile_move.gif";
                    
                }
            }
        }
        private async void printWord(string[] delayword)
        {
            string output = "";
            int waitTimeChar = 100; // 一文字の待機時間
            int waitTimeLine = 400; // 行間の待機時間
            int dwNum = delayword.Length; //dwNum = delaywordNum
            for (int i = 0; i < dwNum; i++)
            {
                await OutputMessage(delayword[i]);
                await Task.Delay(waitTimeLine);
            }
            async Task OutputMessage(string s)
            {
                // foreachで1文字ずつ処理（後半）
                foreach (char c in s)
                {
                    // 1文字追加
                    output += c.ToString();

                    // ラベルに表示
                    this.label1.Text = output;
                    playSimpleSound();

                    // 空白文字以外にディレイさせる
                    if ("" != c.ToString())
                    {
                        // ディレイ
                        await Task.Delay(waitTimeChar);
                    }
                }
            }
            button3.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            // フォームのウィンドウを最小化する
            this.WindowState = FormWindowState.Minimized;
            await Task.Delay(1000);
            this.WindowState = FormWindowState.Normal;

        }
        private async void button3_Click(object sender, EventArgs e)
        {

            //Form1_Load(sender, e);
            textBox1.Visible = false;
            button1.Visible = false;
            
            if (!ispattern1End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring1(netsuword);

                ispattern1End = true;

            }
            else if (!ispattern2End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring5(ugaiword);

                ispattern2End = true;
            }
            else if (!ispattern3End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring2(washword);

                ispattern3End = true;
            }
            else if (!ispattern4End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring4(shoudokuword);

                ispattern4End = true;
            }
            else if (!ispattern5End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring3(koikeword);

                ispattern5End = true;
            }
            else if (!ispattern6End)
            {
                pictureBox1.ImageLocation = @".\kaile_move.gif";
                printstring6(gokigenword);

                ispattern6End = true;

                await Task.Delay(9500);
                this.Close();
            }

        }
    }
}
