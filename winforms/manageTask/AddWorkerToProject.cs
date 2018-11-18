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
            btn_addProjectToWorker.Visible = false;
        }

        private void AddWorkerToProject_Load(object sender, EventArgs e)
        {
            List<Project> projects = TaskRequests.getAllProjects();
            if (projects != null)
            {
                DropDownListProject.DisplayMember = "ProjectName";
                foreach (var item in projects)
                {
                    DropDownListProject.Items.Add(CreateItemProject(item));
                }
            }
        }

        private ListViewDataItem CreateItemWorker(User worker)
        {
            ListViewDataItem item = new ListViewDataItem();
            item.Text = worker.UserName;
            item.Tag = worker;
            return item;
        }

        private RadListDataItem CreateItemProject(Project project)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = project.ProjectName;
            item.Tag = project;
            return item;
        }

        private void btn_addProjectToWorker_Click(object sender, EventArgs e)
        {

            List<User> users = new List<User>();
            var workersAdd = checkedListBoxWorkers.CheckedItems.Select(p => p.Tag).ToList() ;
            foreach (var item in workersAdd)
            {
                users.Add(item as User);
            }
            bool isSuccess = UserRequests.addWorkerToProject((DropDownListProject.SelectedItem.Tag as Project).ProjectId, users);
            if (isSuccess)
            {
                checkedListBoxWorkers.Items.Clear();
                RadMessageBox.SetThemeName("MaterialTeal");
                RadMessageBox.Show("error add project", "sucsses", MessageBoxButtons.OK, RadMessageIcon.None, MessageBoxDefaultButton.Button1);
            }
            else {
                RadMessageBox.SetThemeName("MaterialTeal");
                RadMessageBox.Show("error add workers to project", "error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
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


        private void checkedListBoxWorkers_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            if (checkedListBoxWorkers.CheckedItems.Where(s => s.CheckState == ToggleState.On).ToList().Count > 0)
                btn_addProjectToWorker.Visible = true;
            else btn_addProjectToWorker.Visible = false;
        }

        private void DropDownListProject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            checkedListBoxWorkers.Items.Clear();
            int idProjectSelect = (DropDownListProject.SelectedItem.Tag as Project).ProjectId;
            List<User> workers = UserRequests.getWorkerNotInProject(idProjectSelect);
            if (workers != null)
            {
                checkedListBoxWorkers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    checkedListBoxWorkers.Items.Add(CreateItemWorker(worker));
                }
            }
        }
    }
}



