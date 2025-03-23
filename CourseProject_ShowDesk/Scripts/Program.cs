using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Forms;
using System;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;

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
            AppCostantsManager.LoadAppConstantsFromFile();
            Application.Run(new AuthenticateForm());
        }
    }
}
