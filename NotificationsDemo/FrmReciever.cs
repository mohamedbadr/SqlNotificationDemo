using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotificationsDemo.Data;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace NotificationsDemo
{
    public partial class FrmReciever : Form
    {
        private SqlTableDependency<Item> _dependency;

        public FrmReciever()
        {
            InitializeComponent();
          
        }

        private void FrmReciever_Load(object sender, EventArgs e)
        {
            _dependency = new SqlTableDependency<Item>(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, "Items");
            _dependency.OnChanged += OnChanged;
            _dependency.Start();
        }

        private void FrmReciever_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dependency.Stop();
        }

        public void OnChanged(object sender, RecordChangedEventArgs<Item> e)
        {
            if (e.ChangeType == ChangeType.Insert)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            using (var db = new NotificationsDemoEntities())
            {
                var items = db.Items.Count();

                TxtCount.Invoke(new Action(() => TxtCount.Text = items.ToString()));

              //  TxtCount.Text = items.ToString();
            }
        }
    }
}
