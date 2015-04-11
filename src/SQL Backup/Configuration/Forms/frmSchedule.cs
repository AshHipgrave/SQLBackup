using System;
using System.Windows.Forms;

using Microsoft.Win32.TaskScheduler;

namespace Configuration
{
    public partial class frmSchedule : Form
    {
        private bool ExitOnClose;

        public frmSchedule()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (TaskService taskService = new TaskService())
            {
                TaskDefinition taskDefinition = taskService.NewTask();
                taskDefinition.Principal.RunLevel = TaskRunLevel.Highest;

                taskDefinition.RegistrationInfo.Author = "Ashley Hipgrave";
                taskDefinition.RegistrationInfo.Description = "Performs a Backup of a SQL Database";

                taskDefinition.Settings.MultipleInstances = TaskInstancesPolicy.StopExisting;

                taskDefinition.Settings.DisallowStartIfOnBatteries = false;
                taskDefinition.Settings.IdleSettings.StopOnIdleEnd = false;
                taskDefinition.Settings.IdleSettings.RestartOnIdle = false;
                taskDefinition.Settings.StopIfGoingOnBatteries = false;

                switch ((string)cmbSchedule.SelectedItem)
                {
                    case "Daily":
                        DailyTrigger dailyTrigger = (DailyTrigger)taskDefinition.Triggers.Add(new DailyTrigger { DaysInterval = Int16.Parse(txtFreq.Text) });
                        dailyTrigger.StartBoundary = Convert.ToDateTime(dtBackupTime.Text);
                        break;

                    case "Weekly":
                        WeeklyTrigger weeklyTrigger = (WeeklyTrigger)taskDefinition.Triggers.Add(new WeeklyTrigger { WeeksInterval = Int16.Parse(txtFreq.Text) });
                        weeklyTrigger.StartBoundary = Convert.ToDateTime(dtBackupTime.Text);

                        switch((string)cmbRunDay.SelectedItem)
                        {
                            case "Sunday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Sunday;
                            break;

                            case "Monday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Monday;
                                break;

                            case "Tuesday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Tuesday;
                                break;

                            case "Wednesday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Wednesday;
                                break;

                            case "Thursday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Thursday;
                                break;

                            case "Friday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Friday;
                                break;

                            case "Saturday":
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Saturday;
                                break;

                            default:
                                weeklyTrigger.DaysOfWeek = DaysOfTheWeek.Sunday;
                                break;
                        }
                        break;

                    default:
                        DailyTrigger defaultTrigger = (DailyTrigger)taskDefinition.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                        defaultTrigger.StartBoundary = Convert.ToDateTime(dtBackupTime);
                        break;
                }

                taskDefinition.Actions.Add(new ExecAction(Environment.CurrentDirectory + "\\Backup.exe"));

                try
                {
                    taskService.RootFolder.RegisterTaskDefinition("SQL Backup", taskDefinition, TaskCreation.CreateOrUpdate, "SYSTEM", null, TaskLogonType.ServiceAccount);
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Failed to Create the Scheduled Task:\r\n\r\n" + Ex, "Error Creating Scheduled Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ExitOnClose = false;
                Close();
            }
        }

        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)cmbSchedule.SelectedItem)
            {
                case "Daily":
                    lblOnDay.Enabled = false;
                    cmbRunDay.Enabled = false;
                    lblDaysWeeks.Text = "Days";
                    break;

                case "Weekly":
                    lblOnDay.Enabled = true;
                    cmbRunDay.Enabled = true;
                    lblDaysWeeks.Text = "Weeks";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitOnClose)
                Application.Exit();

            frmReview reviewForm = new frmReview();
            reviewForm.Show();
        }
    }
}
