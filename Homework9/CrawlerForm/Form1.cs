using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework9;
using System.Threading;
//using System.Threading.Tasks;
namespace CrawlerForm
{
    public partial class CrawlerForm : Form
    {
        SimpleCrawler simpleCrawler = new SimpleCrawler();
        public CrawlerForm()
        {
            InitializeComponent();

            simpleCrawler.PageDownloaded += Crawler_PageDownloaded;
        }

    private void Crawler_PageDownloaded(string url)
    {
        if (this.listBox1.InvokeRequired)
        {
            Action<String> action = this.AddUrl;
            this.Invoke(action, new object[] { url });
        }
        else
        {
            AddUrl(url);
        }
    }
        private void AddUrl(string url)
        {
            listBox1.Items.Add(url);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SimpleCrawler.startUrl = txtUrl.Text;
            listBox1.Items.Clear();

            new Thread(simpleCrawler.Crawl).Start();
        }
    }
}
