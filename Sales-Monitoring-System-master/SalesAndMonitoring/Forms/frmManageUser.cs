using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesAndMonitoring.Database;
using SalesAndMonitoring.Helpers;

namespace SalesAndMonitoring
{
    public partial class frmManageUser : frmDataEntry
    {
        public frmManageUser()
        {
            InitializeComponent();

            var userCount = BusinessAccessLayer.GetEntity().User_tbl.Count();

            if(userCount <=0)
            {
                var user = new User_tbl();
                user.UserID = "Admin";
                user.Password = "Admin123";
                BusinessAccessLayer.GetEntity().User_tbl.AddObject(user);
                BusinessAccessLayer.GetEntity().SaveChanges();
            }

            RefreshData();
            comboBox1.SelectedValueChanged +=comboBox1_SelectedValueChanged;
        }

        void RefreshData()
        {
            UserSource.DataSource = BusinessAccessLayer.GetEntity().User_tbl;
            DBSource.DataSource = BusinessAccessLayer.GetEntity().DB_tbl;
            SubPrivSource.DataSource = BusinessAccessLayer.GetEntity().Sub_Priv_tbl;
            PrivelegeSource.DataSource = BusinessAccessLayer.GetEntity().Privilege_tbl;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var checkAdd = checkBox1.Checked;
            var checkedit = checkBox2.Checked;
            var checkDelete = checkBox3.Checked;
            var checkView = checkBox4.Checked;
            var selectDB = int.Parse(comboBox1.SelectedValue.ToString());

            AsyncHelper.TaskAwaiter(() =>
            {
                var user = (User_tbl)UserSource.Current;

                var priv = user.Privilege_tbl.Where(x => x.DbID == selectDB);
                if (priv.Count() <= 0)
                {
                    var subpriv = new Sub_Priv_tbl
                    {
                        Add = checkAdd,
                        Edit = checkedit,
                        Delete = checkDelete,
                        View = checkView
                    };

                    var privNew = new Privilege_tbl();
                    privNew.DbID = selectDB;
                    privNew.Sub_Priv_tbl = subpriv;

                    user.Privilege_tbl.Add(privNew);
                }

                BusinessAccessLayer.GetEntity().SaveChanges();
                return true;
            });
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            OnChangeDataSelect();
        }

        private void OnChangeDataSelect()
        {
            var user = (User_tbl) UserSource.Current;
            var Dbtbl = (DB_tbl) DBSource.Current;

            var checkAdd = checkBox1.Checked;
            var checkedit = checkBox2.Checked;
            var checkDelete = checkBox3.Checked;
            var checkView = checkBox4.Checked;
            var selectDB = int.Parse(comboBox1.SelectedValue.ToString());

            var dataAwaiter = AsyncHelper.TaskAwaiter(() =>
            {
                var privList =
                    BusinessAccessLayer.GetEntity().Privilege_tbl.Where(x => x.UserID == user.ID && x.DbID == Dbtbl.ID);


                if (privList.Count() <= 0)
                {
                    var subpriv = new Sub_Priv_tbl
                                      {
                                          Add = checkAdd,
                                          Edit = checkedit,
                                          Delete = checkDelete,
                                          View = checkView
                                      };

                    var privNew = new Privilege_tbl();
                    privNew.DbID = selectDB;
                    privNew.Sub_Priv_tbl = subpriv;

                    user.Privilege_tbl.Add(privNew);
                    BusinessAccessLayer.GetEntity().SaveChanges();

                    privList =
                        BusinessAccessLayer.GetEntity().Privilege_tbl.Where(x => x.UserID == user.ID && x.DbID == Dbtbl.ID);
                }
                return privList;
            });

            dataAwaiter.OnCompleted(() =>
            {
                var privList = dataAwaiter.GetResult();
                if (privList.Count() > 0)
                {
                    SubPrivSource.DataSource = privList.First().Sub_Priv_tbl;
                }
            });
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            UserSource.MoveFirst();
            OnChangeDataSelect();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            UserSource.MovePrevious();
            OnChangeDataSelect();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UserSource.MoveNext();
            OnChangeDataSelect();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            UserSource.MoveLast();
            OnChangeDataSelect();
        }
    }
}