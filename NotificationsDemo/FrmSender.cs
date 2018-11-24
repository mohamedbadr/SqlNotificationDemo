using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotificationsDemo.Data;
using TableDependency.SqlClient;
using System.Configuration;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace NotificationsDemo
{
    public partial class Form1 : Form
    {
        private readonly SqlTableDependency<Item> _dependency;

        public Form1()
        {
            InitializeComponent();

            _dependency = new SqlTableDependency<Item>(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, "Items");

            _dependency.OnChanged += OnChanged;
            _dependency.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new NotificationsDemoEntities())
            {
                var items = db.Items.Count();
                TxtCount.Text = items.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new NotificationsDemoEntities())
            {
                var item = new Item();
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

        public  void OnChanged(object sender, RecordChangedEventArgs<Item> e)
        {
            if (e.ChangeType == ChangeType.Insert)
            {
                LoadData();
            }
        }
    }
}
