using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using stdole;
namespace QuanLyHotel.EMPLOYEE
{
    public partial class FormDiemDanhKhuonMat : Form
    {
        public int ketquanhandangkhachhang = 0;
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        //MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        //chu dam va to hon
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.1, 2);

        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        Dictionary<string, int> dic = new Dictionary<string, int>();
        private bool isDangky = false;
        private int makh;
        public FormDiemDanhKhuonMat()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public FormDiemDanhKhuonMat(bool v, int makh) : this()
        {
            this.isDangky = v;
            this.makh = makh;
            
        }

        private void FormDiemDanhKhuonMat_Load(object sender, EventArgs e)
        {
            panel_tacvu.Enabled = isDangky;
            if (isDangky)
            {
                textBox_makh.Text = makh.ToString();
                textBox_makh.ReadOnly = true;
            }
            if (!isDangky)
            {
                label_solan.Text = "Tần suất max (tối thiểu 3)";
                textBox_solan.Text = "0";
                label_title.Text= "Vui lòng đưa mặt bạn vào khung hình, hệ thống sẽ nhận diện khuôn mặt của bạn!";
            }
        }

        private void button_kichhoat_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }


        private void button_add_khuonmat_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox_makh.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                //MessageBox.Show(textBox_makh.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int cnt = 0;
        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            NamePersons.Add("");
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();
            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);
                    name = recognizer.Recognize(result);
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Yellow));
                    if (isDangky)
                    {
                        if(cnt<10)
                        button_add_khuonmat_Click(sender, e );
                        cnt++;
                        textBox_solan.Text = cnt.ToString()+ "/10";
                        if (cnt == 10)
                        {
                            MessageBox.Show("Đã đăng ký khuôn mặt cho khách hàng có mã số: " + makh);
                            this.DialogResult = DialogResult.OK;
                            Close();

                        }
                    }
                }
                NamePersons[t - 1] = name;
                NamePersons.Add("");
                ////
                ///
                if (name != null)
                    if (name.Length > 0)
                    {
                        if (!dic.ContainsKey(name))
                        {
                            //tao
                            dic.Add(name, 1);
                        }
                        else
                        {
                            //tang 1
                            dic[name] = dic[name] + 1;
                        }
                    }
                label3.Text = facesDetected[0].Length.ToString();
            }
            t = 0;
            names = NamePersons[0];
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;
            //tim tan suat max của ket trong dictionary
            int max = 0;
            string maxid = "";
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                if (kvp.Value > max)
                {
                    max = kvp.Value;
                    maxid = kvp.Key;
                }
            }
            if (!isDangky)
            {
                //chon so max cang lon thi xac suat dung cang cao, vd o day chon max=4
                textBox_solan.Text = max.ToString();
                if (max >= 3 && maxid == names)
                {
                    this.ketquanhandangkhachhang = Convert.ToInt32(maxid);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Bạn là Khách hàng có mã số:" + maxid + "\nSố lần kiểm tra " + max);
                    Close();
                }
                else
                {
                    if (maxid != names)
                    {
                        dic.Clear();
                    }
                }
            }

            names = "";
            NamePersons.Clear();

        }
    }
}
