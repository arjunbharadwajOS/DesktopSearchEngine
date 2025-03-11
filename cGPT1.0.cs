using System.ComponentModel;
using System.Diagnostics;

namespace cGPT
{
    public partial class Form1 : Form
    {
        BackgroundWorker m_oWorker;
        public string result = "";

        public Form1()
        {
            InitializeComponent();

            m_oWorker = new BackgroundWorker();

            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler
                    (m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchResults.Clear();
            result = "";
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 10;
            m_oWorker.RunWorkerAsync();


        }

        public void customFunction()
        {
            if (result != "")
            {
                progressBar1.Value += 5;
                progressBar1.Visible = false;
                txtSearchResults.Text = result;

            }
        }

        private void m_oWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            m_oWorker.ReportProgress(10);

            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "ollama run llama3.2 \"" + txtChatSearchBox.Text + "\"");

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;

            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;


            proc.Start();

            result = proc.StandardOutput.ReadToEnd();

            if (result != "")
            {
                m_oWorker.ReportProgress(100);
            }

        }

        private void m_oWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (result == "")
            {
                progressBar1.Value += 5;
            }

        }

        private void m_oWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            customFunction();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("                        Pre-Requisite " + Environment.NewLine +
                Environment.NewLine +
                "Download and Install Ollama " + Environment.NewLine +
                "Run the command : ollama pull llama3.2 " + Environment.NewLine +
                "Reference link: " + "https://github.com/ollama/ollama", "Ollama Help");
        }
    }
}