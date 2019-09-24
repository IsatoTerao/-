using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WorkReport1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public class RepoFilePath
        {
            public string WorkRepoPath { get; set; }
            public string WorkerName { get; set; }
            public string CSVFileName { get; set; }
        }


        
        private void GetPathsAndNamesInit()
        {
            string rootWorkRepoPath = Directory.GetCurrentDirectory() + "\\WorkRepos";
            var repoFilePaths = new RepoFilePath[]
            {
                new RepoFilePath
                {
                    WorkRepoPath = rootWorkRepoPath,
                    WorkerName = Path.GetFileNameWithoutExtension(rootWorkRepoPath),
                    CSVFileName = ""
                }
            };

            
            comboBoxWorkerName.DataSource = repoFilePaths;
            comboBoxWorkerName.DisplayMember = "WorkerName";
        }
        
        private void GetPathsAndNames()
        {

        }


    /*
        private void GetWorkerNamePath()
        {
            //作業者ごとの報告書ディレクトリを取得し、出退勤タブの作業者コンボボックスのDataSourceに入れる
            //作業報告書ディレクトリの取得(Debugのexeからの相対パス)
            string repoDirPath = Directory.GetCurrentDirectory() + "\\WorkRepos";

            //作業者ごとのディレクトリ一覧を取得
            string[] workerName = Directory.GetDirectories(repoDirPath);
            comboBoxWorkerName.DataSource = workerName;

            //string repoCSVPath = comboBoxWorkerName.SelectedItem.ToString();
            //repoCSVPath = repoCSVPath + Path.GetFileName(repoCSVPath);

            string[] repoCSVPath = Directory.GetFiles(comboBoxWorkerName.SelectedItem.ToString());



        }
    */

        /*private void getReportCSVPath()
        {
            getWorkerNamePath();
            string reportCSVPath = comboBoxWorkerName.SelectedItem.ToString();
            reportCSVPath = reportCSVPath + Path.GetFileName(reportCSVPath);
            textBox1.Text = reportCSVPath;

        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {            
            //DataGridViewの行を交互に色変更
            //全ての行の背景色を水色にする
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                //奇数行を黄色にする
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            ////選択中の行はデザインプロパティでピンクに変更

            //ロード時に作業者名、作業報告書ファイル名の取得
            //getWorkerNamePath();
            GetPathsAndNamesInit();
            

            //getReportCSVPath();

            //DataGridViewの設定
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //listBoxYM.DataSource = Directory.GetFiles(comboBoxWorkerName.SelectedItem.ToString());

            //string fileName = listBoxYM.SelectedItem.ToString(getReportCSVPath);
            //fileName = Path.GetFileNameWithoutExtension(fileName);
            //textBoxDbgCsvPath.Text = fileName;



        }

        private void LoadData()
        {
            // 重複防止のため一旦テーブルをクリア
            workReportDataSet.workReportDataTable.Clear();

            //getReportCSVPath();

            string csvPath = listBoxYM.SelectedItem.ToString();
            string delimStr = ","; //区切り文字の指定
            char[] delimiter = delimStr.ToCharArray(); //区切り文字をまとめる
            string[] strData; //分解後の文字を入れる配列
            string strLine; //１行分のデータ
            bool fileExists = System.IO.File.Exists(csvPath);

            string fileName = listBoxYM.SelectedItem.ToString();
            fileName = Path.GetFileNameWithoutExtension(fileName);
            textBoxDbgCsvPath.Text = fileName;



            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                                                csvPath,
                                                System.Text.Encoding.Default);


                while (sr.Peek() >= 0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);
                    workReportDataSet.workReportDataTable.AddworkReportDataTableRow(
                                                DateTime.Parse(strData[0]),
                                                strData[1],
                                                strData[2],
                                                strData[3],
                                                strData[4],
                                                strData[5]
                        );
                }
                sr.Close();
            }
        }
        private void ListBoxYM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowDialog
            //string csvPath = listBoxYM.SelectedItem.ToString();

            LoadData();
        }

        private void DgvKintai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveData()
        {
            // パス取得
            //getWorkerNamePath();
            //getReportCSVPath();
            string csvPath = listBoxYM.SelectedItem.ToString();
            string[] repoCSVPath = Directory.GetFiles(comboBoxWorkerName.SelectedItem.ToString());
            //string dtToFilename = DateTime.Now("YYYY-MM");


            string strData = ""; //１行分のデータ
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                csvPath,
                false,
                System.Text.Encoding.Default);
            foreach (WorkReportDataSet.workReportDataTableRow drMoney
                    in workReportDataSet.workReportDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                        + drMoney.開始 + ","
                        + drMoney.終了 + ","
                        + drMoney.勤務時間 + ","
                        + drMoney.作業内容 + ","
                        + drMoney.備考 + ",";

                sw.WriteLine(strData);
            }
            sw.Close();
        }

        private void SaveDataReg()
        {
            string csvPath = listBoxYM.SelectedItem.ToString();
            string strData = ""; //１行分のデータ
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                csvPath,
                false,
                System.Text.Encoding.Default);
            foreach (WorkReportDataSet.workReportDataTableRow drMoney
                    in workReportDataSet.workReportDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                        + drMoney.開始 + ","
                        + drMoney.終了 + ","
                        + drMoney.勤務時間 + ","
                        + drMoney.作業内容 + ","
                        + drMoney.備考 + ",";

                sw.WriteLine(strData);
            }
            sw.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？", "保存", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SaveData();
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？", "保存", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SaveData();
            }
        }

        private void CalcWorkTime()
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            DateTime start = Convert.ToDateTime(dataGridView1.Rows[r].Cells[1].Value);
            DateTime end = Convert.ToDateTime(dataGridView1.Rows[r].Cells[2].Value);
            //TimeSpan ts = end - start;
            dataGridView1.Rows[r].Cells[3].Value = end - start;
            

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //ゆくゆくは入力済みの場合は確認画面を出した上でOKを押せば上書き可能とする
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = DateTime.Now.ToString("HH:mm");

            //上の代入を終えた上で、終了時刻－開始時刻を計算し勤務時間に代入
            //ゆくゆくは形式チェックや終了時刻の有無を確認した上で実行
            CalcWorkTime();

        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[2].Value = DateTime.Now.ToString("HH:mm");

            //上の代入を終えた上で、終了時刻－開始時刻を計算し勤務時間に代入
            //ゆくゆくは形式チェックや終了時刻の有無を確認した上で実行
            CalcWorkTime();
        }

        private void DataGridView1_CellValidating(object sender, DataGridViewCellEventArgs e)
        {
            //CalcWorkTime();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalcWorkTime();
        }

        private void 終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("終了しますか？", "終了", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void 出勤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ゆくゆく前2行もまとめてStartWork();とかにする
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = DateTime.Now.ToString("HH:mm");
            CalcWorkTime();
        }

        private void 退勤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ゆくゆく前2行もまとめてEndWork();とかにする
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[2].Value = DateTime.Now.ToString("HH:mm");
            CalcWorkTime();
        }

        private void ButtonRecordStartTime_Click(object sender, EventArgs e)
        {

            //出退勤登録タブからの出勤登録・ファイル保存
            //LoadData();
            //現在日時の日付のみ取得
            DateTime dt = DateTime.Now;

            //配列のindexを呼ぶためマイナス1
            int r = dt.Day -1;

            //ボタン押下時の日付に日時を保存
            dataGridView1.Rows[r].Cells[1].Value = DateTime.Now.ToString("HH:mm");
            CalcWorkTime();
            SaveData();

        }

        private void ButtonRecordEndTime_Click(object sender, EventArgs e)
        {
            //出退勤登録タブからの退勤登録・ファイル保存

            //現在日時の日付のみ取得
            DateTime dt = DateTime.Now;

            //配列のindexを呼ぶためマイナス1
            int r = dt.Day - 1;
            DateTime start = Convert.ToDateTime(dataGridView1.Rows[r].Cells[1].Value);
            DateTime end = Convert.ToDateTime(dataGridView1.Rows[r].Cells[2].Value);
            dataGridView1.Rows[r].Cells[3].Value = end - start;

            //ボタン押下時の日付に日時を保存
            dataGridView1.Rows[r].Cells[2].Value = DateTime.Now.ToString("HH:mm");
            CalcWorkTime();
            SaveData();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択したタブによりメニューの有効化無効化を切り替える
            if (tabControl1.SelectedIndex == 0)
            {
                保存SToolStripMenuItem.Enabled = false;
                出勤ToolStripMenuItem.Enabled = true;
                退勤ToolStripMenuItem.Enabled = true;
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                保存SToolStripMenuItem.Enabled = false;
                出勤ToolStripMenuItem.Enabled = false;
                退勤ToolStripMenuItem.Enabled = false;
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                保存SToolStripMenuItem.Enabled = true;
                出勤ToolStripMenuItem.Enabled = false;
                退勤ToolStripMenuItem.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBoxDateTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");

        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void ListBoxYM_Format(object sender, ListControlConvertEventArgs e)
        {
        }

        private void ヘルプHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxWorkerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getWorkerNamePath();
            //textBoxdbg1.Text = comboBoxWorkerName.SelectedItem.ToString();

            //string[] repoCSVPath = Directory.GetFiles(comboBoxWorkerName.SelectedItem.ToString());
            //repoCSVPath = Directory.GetFiles(repoCSVPath.ToString,"*",SearchOption.AllDirectories);
            //textBoxdbg2.Text = repoCSVPath[0];
            //getReportCSVPath();

        }
    }
}
