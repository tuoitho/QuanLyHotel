using AxWMPLib;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Svg;

namespace QuanLyHotel.PHONG
{
    internal class Firebase_API
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "DWzwpu2txuwqp0YAyAqAHzW4YljVvnH5HWU6yyXj",
            BasePath = "https://winformtt-default-rtdb.firebaseio.com/"
        };
        //contructer
        public Firebase_API()
        {
            GetFirebaseClient();
        }
        //FirebaseClient client;
        IFirebaseClient client;

        public IFirebaseClient GetFirebaseClient()
        {
            if (client == null)
            {
                client = new FireSharp.FirebaseClient(config);
            }
            return client;
        }
        public async Task<PhongModel> updateVideoRoomAsync(string maphong, string videourl)
        {

            PhongModel data = new PhongModel
            {
                id = maphong,
                url = videourl
            };
            SetResponse response = await client.SetTaskAsync("VideoRooms/"+maphong, data);
            PhongModel result = response.ResultAs<PhongModel>();
            return result;
        }

        public async Task createVideoRoomAsync(String maphong, String filepath, String videoFileName)
        {
            string _url="";
            FirebaseStorageOptions options = new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult("DWzwpu2txuwqp0YAyAqAHzW4YljVvnH5HWU6yyXj"),
            };

            var storage = new FirebaseStorage("winformtt.appspot.com");
            var stream = File.OpenRead(filepath);
            var uploadTask = storage
                .Child("Videos") // Optional: Folder structure within storage
                .Child(videoFileName)
                .PutAsync(stream);
            //lay form dang run
            FormChiTietPhong f = (FormChiTietPhong)Application.OpenForms["FormChiTietPhong"];
            uploadTask.Progress.ProgressChanged += (s, e) => f.loadingfirebase(e.Percentage.ToString()+"%");
            try
            {
                // error during upload will be thrown when you await the task
                _url=(String) await uploadTask;
                MessageBox.Show("Data has been uploaded");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateVideoRoomAsync(maphong, _url);

        }
        public async Task<PhongModel> getVideoRoomAsync(string maphong)
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync("VideoRooms/");
                //MessageBox.Show(response.Body);
                Dictionary<string, PhongModel> data = response.ResultAs<Dictionary<string, PhongModel>>();
                PhongModel result = data.Where(i => i.Value.id == maphong).Select(i => i.Value).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public async void deleteVideoRoomAsync(string maphong)
        {
            try
            {
                FirebaseResponse response = await client.DeleteTaskAsync("VideoRooms/" + maphong);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
