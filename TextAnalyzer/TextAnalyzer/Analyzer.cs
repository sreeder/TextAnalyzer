using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAnalyzer;

namespace TextAnalyzer
{
    public partial class Analyzer : Form
    {
        public Analyzer()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            var result = WorkerBee.AnalyzeText(txtInput.Text);
            lbResults.Items.Clear();
            foreach (var r in result)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(r.Key.ToString());
                lvi.SubItems.Add(r.Value.ToString());
                //lbResults.Items.Add(r.Key.ToString(), r.Value.ToString()); 
                lbResults.Items.Add(lvi);
            }

        }
    }
}
