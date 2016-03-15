using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

namespace github
{
    public partial class Form1 : Form
    {
        private Capture _captura;
        private bool captura_progresso;
        private CascadeClassifier classificador;
        Image<Bgr, Byte> ImageFrame;

        public Form1()
        {
            InitializeComponent();
        }
        private void ReleaseData()
        {
            if (_captura != null)
                _captura.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_captura == null)
            {
                try
                {
                    _captura = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            //#endregion

            if (_captura != null)
            {
                if (captura_progresso)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    //button2.Text = "Start!"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    //button2.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }

                captura_progresso = !captura_progresso;
            }
            classificador = new CascadeClassifier(Application.StartupPath + "/haarcascade/haarcascade_frontalface_alt_tree.xml");

           /* Image imagem = Image.FromFile(@"imagens\foto.jpg");
            Image<Bgr, byte> ImageFrame = new Image<Bgr, byte>(new Bitmap(imagem));

            Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();

            int TotalFaces = faces.Length;

            MessageBox.Show("Total faces detected: " + TotalFaces.ToString());

            //show the image in the EmguCV ImageBox
            imgCamUser_2.Image = ImageFrame;*/

        }
        //Treina o programa a reconhecer as caras
        /*public bool TrainRecognizer()
        {
            var allFaces = _dataStoreAccess.CallFaces("ALL_USERS");
            if (allFaces != null)
            {
                var faceImages = new Image<Gray, byte>[allFaces.Count];
                var faceLabels = new int[allFaces.Count];
                for (int i = 0; i < allFaces.Count; i++)
                {
                    Stream stream = new MemoryStream();
                    stream.Write(allFaces[i].Image, 0, allFaces[i].Image.Length);
                    var faceImage = new Image<Gray, byte>(new Bitmap(stream));
                    faceImages[i] = faceImage.Resize(100, 100, Inter.Cubic);
                    faceLabels[i] = allFaces[i].UserId;
                }
                _faceRecognizer.Train(faceImages, faceLabels);
                _faceRecognizer.Save(_recognizerFilePath);
            }
            return true;

        }*/
        private void ProcessFrame(object sender, EventArgs arg)
        {
           
            ImageFrame = _captura.QueryFrame().ToImage<Bgr, Byte>();

            if (ImageFrame != null)
            {
                Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();
                var faces = classificador.DetectMultiScale(grayframe, 1.1, 3, new Size(20, 20));

                foreach (var face in faces)
                {
                    ImageFrame.Draw(face, new Bgr(Color.White), 3);
                }
            }
                imgCamUser_2.Image = ImageFrame;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tirar Foto
            /*_captura = null; 
            _captura = new Capture(0);
            imgCamUser.Image = _captura.QueryFrame();*/



            /*using (var imageFrame = )
                {
                    if (imageFrame != null)
                    {
                        var grayframe = imageFrame.Convert<Gray, byte>();
                        var caras = classificador.DetectMultiScale(grayframe, 1.1, 10, Size.Empty); //Deteção da cara 

                        foreach (var cara in caras)
                        {
                          imageFrame.Draw(cara, new Bgr(Color.BurlyWood), 3); 
                        }
                    }
                imgCamUser_2.Image = imageFrame;
            }*/

//---------------------//-------------------------------//---------------------------------------//------------------------------
           //Reconhecimento na foto
           

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmm");
        }



        private void button2_Click(object sender, EventArgs e)
        {

            String timeStamp = GetTimestamp(DateTime.Now);
            button2.Text = "Foto Tirada!";
            ImageFrame.Save(@"imagens/foto" + timeStamp + ".jpg");
        }



        private void buttonLer_fotos_Click(object sender, EventArgs e)
        {
            //escolher a foto para fazer reconhecimento
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> foto = new Image<Bgr, byte>(file.FileName);
                Image<Bgr, Byte> imageFrame = new Image<Bgr, byte>(new Bitmap(foto.ToString()));
                Image<Gray, Byte> grayFrame = imageFrame.Convert<Gray, Byte>();
                //aumenta o contraste
                grayFrame._EqualizeHist();

                //Reconhece a cara e guarda o retangulo da mesma
                var faces = classificador.DetectMultiScale(grayFrame, 1.1, 3, new Size(20, 20));

                foreach (var face in faces)
                {
                    imageFrame.Draw(face, new Bgr(System.Drawing.Color.White), 3);
                }

                imageBox1.Image = imageFrame;

            }

            

        }
    }
  }

