using Firebase.Storage;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel.PHONG
{
    public partial class FormChiTietPhong : Form
    {
        public FormChiTietPhong()
        {
            InitializeComponent();
        }
        PhongModel phong;
        Firebase_API firebase = new Firebase_API();
        string filePath, videoFileName;
        string id;
        public FormChiTietPhong(string maphong) : this()
        {
            phong = new PhongModel();
            id = maphong.ToString();
        }

        private void button_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //mp4
            openFileDialog.Filter = "Video files (*.mp4)|*.mp4";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = filePath;
                //var storage = new FirebaseStorage("winformtt.appspot.com");
                videoFileName = Path.GetFileName(filePath);
            }
        }


        private void FormChiTietPhong_Load_1(object sender, EventArgs e)
        {
            _ = getVideoRoomAsync(id);
        }
        private async Task getVideoRoomAsync(string v)
        {
            PhongModel myPhongModel = await firebase.getVideoRoomAsync(v);
            if (myPhongModel == null)
            {
                axWindowsMediaPlayer1.URL = "";
            }
            else
            {
                axWindowsMediaPlayer1.URL = myPhongModel.url;
                //max volume
                axWindowsMediaPlayer1.settings.volume = 100;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void button_upload_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Visible=true;
                Task t = firebase.createVideoRoomAsync(id, filePath, videoFileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormChiTietPhong_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteVideoRoom(id);
        }
        private async void deleteVideoRoom(string id)
        {
            try
            {
                firebase.deleteVideoRoomAsync(id);
                axWindowsMediaPlayer1.URL = "";
                MessageBox.Show("Xóa video thành công", "Xóa video", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadingfirebase(string lb)
        {
            label1.Text = lb;
        }
    }

}
