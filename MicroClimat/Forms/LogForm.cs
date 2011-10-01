using System.Windows.Forms;
using MicroClimat.Classes;

namespace MicroClimat.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            CLogger log = new CLogger();
            log.LogEvent += InsertMessage;
        }

        static void InsertMessage()
        {
            MessageBox.Show(@"Message");
        }
    }
}
