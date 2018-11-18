using manageTask.Logic;
using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace manageTask
{
    public partial class AddWorkerToProject : Telerik.WinControls.UI.RadForm
    {
        public AddWorkerToProject()
        {
            InitializeComponent();
        }

        private void AddWorkerToProject_Load(object sender, EventArgs e)
        {


            List<Project> projects = TaskRequests.getAllProjects();
            if (projects != null)
            {

                cmbx_projects.DisplayMember = "ProjectName";
                foreach (var item in projects)
                {
                    cmbx_projects.Items.Add(getItemProject(item));
                }
            }
        }


        public RadListDataItem getItemProject(Project project)
        {
            RadListDataItem item = new RadListDataItem();
            item.Tag = project;
            item.Text = project.ProjectName;
            return item;
        }

        public ListViewDataItem getItemWorker(User worker)
        {
            ListViewDataItem item = new ListViewDataItem();
            item.Text = worker.UserName;
            item.Tag = worker;
            return item;
        }



        private void checkedListBoxWorkers_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            if (checkedListBoxWorkers.Items.Where(p => p.CheckState == ToggleState.On).Count() > 0)
            {
                btn_addProjectToWorker.Visible = true;
            }
            else btn_addProjectToWorker.Visible = false;
        }



        private void btn_checkAll_Click(object sender, EventArgs e)
        {
            if (this.btn_checkAll.Text == "Check all")
            {
                this.checkedListBoxWorkers.CheckAllItems();
                this.btn_checkAll.Text = "Uncheck all";
            }
            else
            {
                this.checkedListBoxWorkers.UncheckAllItems();
                this.btn_checkAll.Text = "Check all";
            }
        }

        private void cmbx_projects_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            checkedListBoxWorkers.Items.Clear();
            int idPprojectSelect = (cmbx_projects.SelectedItem.Tag as Project).ProjectId;
            List<User> workers = UserRequests.getWorkerNotInProject(idPprojectSelect);
            if (workers != null)
            {
                checkedListBoxWorkers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    checkedListBoxWorkers.Items.Add(getItemWorker(worker));
                }

            }
        }

        private void btn_addProjectToWorker_Click(object sender, EventArgs e)
        {

            List<User> users = new List<User>();
            var workerAdd = checkedListBoxWorkers.Items.Where(p => p.CheckState == ToggleState.On).Select(p=>p.Tag).ToList();
            foreach (var item in workerAdd)
            {
                users.Add(item as User);
            }
            bool isSuccess = UserRequests.addWorkerToProject((cmbx_projects.SelectedItem.Tag as Project).ProjectId, users);
            if (isSuccess)
                MessageBox.Show("Success");
            else MessageBox.Show("ERROR!");
        }




    }
}
