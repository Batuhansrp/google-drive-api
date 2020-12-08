using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace googleformdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "googledeneme";
        private void baglanbtn_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            credential = GetCredentials();

            // Yeni drive api servisi yaratma
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string pageToken = null;

            //Dosyaları Listeleme
                ListFiles(service, ref pageToken);

           

            

        }

        //credentials dosyasını okuma
        private  UserCredential GetCredentials()
        {
            UserCredential credential;

            using (FileStream stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
               
            }

            return credential;
        }
        private static void UploadBasicImage(string path, DriveService service)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);
            fileMetadata.MimeType = "image/jpeg";
            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "image/jpeg");
                request.Fields = "id";
                request.Upload();
            }

            var file = request.ResponseBody;

            

        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            credential = GetCredentials();

            
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            UploadBasicImage(txtbox1.Text, service);

        }

        private void btnklasor_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            credential = GetCredentials();

           
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string DirectoryName = txtbox2.Text;
            var body = new Google.Apis.Drive.v3.Data.File();
            body.Name = DirectoryName;
            body.MimeType = "application/vnd.google-apps.folder";
            
            
                var request = service.Files.Create(body);
                request.Fields = "id";
                var _FF = request.Execute();
            
        }

        private void ListFiles(DriveService service, ref string pageToken)
        {  
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 30;
           
            listRequest.Fields = "nextPageToken, files(name)";
            listRequest.PageToken = pageToken;
            listRequest.Q = "mimeType='image/jpeg'";

            
            var request = listRequest.Execute();


            if (request.Files != null && request.Files.Count > 0)
            {


                foreach (var file in request.Files)
                {
                   listBox1.Items.Add( file.Name);
                }

                pageToken = request.NextPageToken;

                if (request.NextPageToken != null)
                {
                    Console.WriteLine("Press any key to conti...");
                    Console.ReadLine();



                }


            }
            else
            {
                Console.WriteLine("No files found.");

            }

        }
    }
}
