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
            }
            bool isSuccess = UserRequests.addWorkerToProject((cmbx_projects.SelectedItem as Project).ProjectId, users);
            if (isSuccess)
                MessageBox.Show("Success");
            else MessageBox.Show("ERROR!");
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
            }
        }
    }
}



