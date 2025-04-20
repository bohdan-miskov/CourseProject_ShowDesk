using CourseProject_ShowDesk.Forms;
using CourseProject_ShowDesk.Scripts.Constants;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                AppCostantsManager.LoadAppConstantsFromFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nSo program was loaded default values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (AppConstants.FirstLog == DateTime.MinValue)
            {
                InstructionForm instructionForm = new InstructionForm();
                instructionForm.ShowDialog();
                AppConstants.SetFirstLog();
                AppConstantsData appConstantsData = AppConstants.CloneConstants();
                AppCostantsManager.SaveAppConstantsToFile(appConstantsData);
            }

            Application.Run(new AuthenticateForm());
        }
    }
}
