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
<<<<<<< HEAD
               DropDownListProject.DisplayMember = "ProjectName";
                foreach (var item in projects)
                {
                    DropDownListProject.Items.Add(getItemProject(item));
                }
            }
        }

        private void btn_addProjectToWorker_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            var workersAdd = checkedListBoxWorkers.SelectedItems.Select(p=>p.Tag).ToList();
            foreach (var item in workersAdd)
            {
                users.Add(item as User);
            }
            bool isSuccess = UserRequests.addWorkerToProject((DropDownListProject.SelectedItem.Tag as Project).ProjectId, users);
            if (isSuccess)
            {
                RadMessageBox.SetThemeName("MaterialTeal");
                RadMessageBox.Show("sucsses add project", "ok", MessageBoxButtons.OK, RadMessageIcon.None, MessageBoxDefaultButton.Button1);
            }

            else {
                RadMessageBox.SetThemeName("MaterialTeal");
                RadMessageBox.Show("error add workers to project", "error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            } 
        }

        private void checkedListBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        { 
             btn_addProjectToWorker.Visible = true;
        }

        void radButtonRemoveFromWorker_Click(object sender, EventArgs e)
        {
            while (this.checkedListBoxWorkers.CheckedItems.Count > 0)
            {
                this.checkedListBoxWorkers.Items.Remove(this.checkedListBoxWorkers.CheckedItems[0]);
=======
                cmbx_projects.DisplayMember = "ProjectName";
                cmbx_projects.Items.AddRange(projects.ToArray());
            }
        }


        private void cmbx_projects_SelectedIndexChanged(object sender, EventArgs e)
        {
           int idPprojectSelect= (cmbx_projects.SelectedItem as Project).ProjectId;
            List<User> workers = UserRequests.getWorkerNotInProject(idPprojectSelect);
            if (workers != null)
            {
                checkedListBoxWorkers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    checkedListBoxWorkers.Items.Add(worker);
                }

            }
        }

        private void btn_addProjectToWorker_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < checkedListBoxWorkers.Items.Count; i++)
            {   
                if (checkedListBoxWorkers.GetItemChecked(i))
                {
                    users.Add((checkedListBoxWorkers.Items[i] as User));

                }
>>>>>>> ae5ed1a4e5bfa890fc342e9e4214f82fce371fec
            }
            bool isSuccess = UserRequests.addWorkerToProject((cmbx_projects.SelectedItem as Project).ProjectId, users);
            if (isSuccess)
                MessageBox.Show("Success");
            else MessageBox.Show("ERROR!");
        }

<<<<<<< HEAD
      public  RadListDataItem getItemProject(Project project)
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
=======
        private void checkedListBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
             btn_addProjectToWorker.Visible = true;
>>>>>>> ae5ed1a4e5bfa890fc342e9e4214f82fce371fec
        }

        void radButtonRemoveFromWorker_Click(object sender, EventArgs e)
        {
            while (this.checkedListBoxWorkers.CheckedItems.Count > 0)
            {
<<<<<<< HEAD
                checkedListBoxWorkers.DisplayMember = "UserName";
                foreach (User worker in workers)
                {
                    checkedListBoxWorkers.Items.Add(getItemWorker(worker));
                }
=======
                this.checkedListBoxWorkers.Items.Remove(this.checkedListBoxWorkers.CheckedItems[0]);
>>>>>>> ae5ed1a4e5bfa890fc342e9e4214f82fce371fec
            }
        }

        private void checkedListBoxWorkers_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            if(checkedListBoxWorkers.Items.Where(p=>p.CheckState==ToggleState.On).Count()>0)
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
    }
}
