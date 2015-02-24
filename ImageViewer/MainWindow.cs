using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using openCV;

namespace ImageViewer
{
    public partial class MainWindow : Form
    {
        IplImage normalImage, tempImage, newImage, noChannelNewImage, changeChannelImage;
        string imageName, imagePath;
        int changed = 0;

        public MainWindow()
        {
            InitializeComponent();
            //
            // Disable Close, Save, Edit and Image Menues @ startup.
            //
            SaveMenu.Enabled = false;
            CloseMenu.Enabled = false;
            EditMenu.Enabled = false;
            ImageMenu.Enabled = false;
            ChannelMenu.Enabled = false;
            ResizeMenu.Enabled = false;
            FlipMenu.Enabled = false;
        }

        void changechannel(int channel)
        {
            IplImage nchannelimage;
            nchannelimage = cvlib.CvCreateImage(new CvSize(newImage.width, newImage.height), newImage.depth, normalImage.nChannels);

            if (changed == 1)
                changeChannelImage = noChannelNewImage;
            else
                changeChannelImage = newImage;

            int srcadress = changeChannelImage.imageData.ToInt32();
            int dstadress = nchannelimage.imageData.ToInt32();
            if (channel != 012)
            {
                unsafe
                {
                    for (int r = 0; r < nchannelimage.height; r++)
                    {
                        for (int c = 0; c < nchannelimage.width; c++)
                        {
                            int srcindex, dstindex;
                            srcindex = dstindex = (nchannelimage.width * r * nchannelimage.nChannels) + c * nchannelimage.nChannels;
                            byte* color = (byte*)(srcadress + srcindex + channel);
                            *((byte*)(dstadress + dstindex + channel)) = *color;
                        }
                    }
                }
            }
            else
            {
                unsafe
                {
                    for (int r = 0; r < nchannelimage.height; r++)
                    {
                        for (int c = 0; c < nchannelimage.width; c++)
                        {
                            int srcindex, dstindex;
                            srcindex = dstindex = (nchannelimage.width * r * nchannelimage.nChannels) + c * nchannelimage.nChannels;
                            byte color = (byte)((*(byte*)(srcadress + srcindex + 0) + *(byte*)(srcadress + srcindex + 1) + *(byte*)(srcadress + srcindex + 2)) / 3);
                            *((byte*)(dstadress + dstindex + 0)) = color;
                            *((byte*)(dstadress + dstindex + 1)) = color;
                            *((byte*)(dstadress + dstindex + 2)) = color;
                        }
                    }
                }
            }

            tempImage = newImage;
            newImage = nchannelimage;
            changed = 1;

            UndoMenu.Enabled = true;
            ResetMenu.Enabled = true;

            previewbox.BackgroundImage = (Image)newImage;
        }

        void ResizeImage(Int32 w, Int32 h)
        {
            try
            {
                IplImage resizedimage;
                Int32 width = w, height = h;
                CvSize size = new CvSize(width, height);
                resizedimage = cvlib.CvCreateImage(size, newImage.depth, newImage.nChannels);

                //src image control which image to resize the normal "normalimage" or edited "newimage" 
                cvlib.CvResize(ref normalImage, ref resizedimage, cvlib.CV_INTER_LINEAR);

                cvlib.CvNamedWindow("ImageViewer", 1);
                cvlib.CvShowImage("ImageViewer", ref resizedimage);
                cvlib.CvWaitKey(1000000000);

                DialogResult resizesave = MessageBox.Show("Done, Do you want to save the new image now?", "", MessageBoxButtons.YesNo);
                if (resizesave == System.Windows.Forms.DialogResult.Yes)
                {
                    newImage = resizedimage;
                    noChannelNewImage = resizedimage;

                    ResetMenu.Enabled = true;
                    UndoMenu.Enabled = true;
                    SaveMenu.PerformClick();

                    DialogResult workwith = MessageBox.Show("Do you want to work on the resized image?", "ImageViewer", MessageBoxButtons.YesNo);
                    if (workwith == System.Windows.Forms.DialogResult.Yes)
                    {
                        ResetMenu.Enabled = true;
                        UndoMenu.Enabled = true;

                        previewbox.BackgroundImage = (Image)newImage;
                    }
                    else
                        if (workwith == System.Windows.Forms.DialogResult.No)
                        {
                            UndoMenu.Enabled = false;
                            ResetMenu.Enabled = false;
                        }
                }
                else
                    if (resizesave == System.Windows.Forms.DialogResult.No)
                    {
                        DialogResult result2 = MessageBox.Show("Do you want to work on the resized image?", "ImageViewer", MessageBoxButtons.YesNo);
                        if (result2 == System.Windows.Forms.DialogResult.Yes)
                        {
                            UndoMenu.Enabled = true;
                            ResetMenu.Enabled = true;

                            previewbox.BackgroundImage = (Image)newImage;
                        }
                        else
                            if (result2 == System.Windows.Forms.DialogResult.No)
                            {
                                UndoMenu.Enabled = false;
                                ResetMenu.Enabled = false;
                            }
                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FlipImage(int direction)
        {
            IplImage flippedimage;
            flippedimage = cvlib.CvCreateImage(new CvSize(newImage.width, newImage.height), newImage.depth, newImage.nChannels);
            cvlib.CvFlip(ref newImage, ref flippedimage, direction);

            tempImage = newImage;
            newImage = flippedimage;
            noChannelNewImage = flippedimage;

            UndoMenu.Enabled = true;
            ResetMenu.Enabled = true;

            previewbox.BackgroundImage = (Image)newImage;
        }

        void TestMode()
        {
            if (changed == 1)
                changed = 0;

            SaveMenu.Enabled = true;
            IplImage testimage = cvlib.ToIplImage(ImageViewer.Properties.Resources.TestModeImage, false);
            newImage = normalImage = changeChannelImage = testimage;
            previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;

            DialogResult result2 = MessageBox.Show("Test Red Channel, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (result2 != System.Windows.Forms.DialogResult.No)
            {
                changechannel(2);
                changed = 0;

                DialogResult result3 = MessageBox.Show("Test Green Channel, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (result3 != System.Windows.Forms.DialogResult.No)
                {
                    IplImage testimage3 = cvlib.ToIplImage(ImageViewer.Properties.Resources.TestModeImage, false);
                    newImage = testimage3;
                    changechannel(1);
                    changed = 0;

                    DialogResult result4 = MessageBox.Show("Test Blue Channel, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (result4 != System.Windows.Forms.DialogResult.No)
                    {
                        IplImage testimage4 = cvlib.ToIplImage(ImageViewer.Properties.Resources.TestModeImage, false);
                        newImage = testimage4;
                        changechannel(0);
                        changed = 0;

                        DialogResult result7 = MessageBox.Show("Test Grayscale Channel, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        if (result7 != System.Windows.Forms.DialogResult.No)
                        {
                            GrayscaleChannelMenu.PerformClick();

                            DialogResult result5 = MessageBox.Show("Test Horizontal Flip, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                            if (result5 != System.Windows.Forms.DialogResult.No)
                            {
                                //To Flip a new version of the test image
                                /*
                                IplImage testimage5 = cvlib.ToIplImage(ImageViewer.Properties.Resources.TestModeImage, false);
                                newimage = testimage5;
                                */

                                FlipImage(1);
                                DialogResult result6 = MessageBox.Show("Test Vertical Flip, Continue ?", "ImageViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                                if (result6 != System.Windows.Forms.DialogResult.No)
                                {
                                    FlipImage(0);

                                    DialogResult result8 = MessageBox.Show("At last Test Image Copy to the Clipboard, Continue ?", "ImageViewer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    if (result8 == System.Windows.Forms.DialogResult.OK)
                                        CopyImageMenu.PerformClick();
                                    else
                                        previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
                                }
                                else
                                    previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
                            }
                            else
                                previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
                        }
                        else
                            previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
                    }
                    else
                        previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
                }
                else
                    previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
            }
            else
                previewbox.BackgroundImage = ImageViewer.Properties.Resources.TestModeImage;
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;
            if (x >= previewbox.Location.X && x <= previewbox.Location.X + previewbox.Width && y >= previewbox.Location.Y && y <= previewbox.Location.Y + previewbox.Height)
            {
                string[] dropedfile = (string[])e.Data.GetData(DataFormats.FileDrop);

                newImage = noChannelNewImage = normalImage = cvlib.CvLoadImage(dropedfile[0], cvlib.CV_LOAD_IMAGE_COLOR);

                imageName = dropedfile[0];

                SaveMenu.Enabled = true;
                EditMenu.Enabled = true;
                ImageMenu.Enabled = true;
                ChannelMenu.Enabled = true;
                ResizeMenu.Enabled = true;
                FlipMenu.Enabled = true;
                CloseMenu.Enabled = true;
                UndoMenu.Enabled = false;
                ResetMenu.Enabled = false;

                previewbox.BackgroundImage = (Image)newImage;
            }
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            opendialog.FileName = "";
            opendialog.Filter = "Image Files(*.PNG:*.JPEG)|*.PNG;*.JPG|JPEG(*.JPEG)|*.JPG|PNG(*.PNG)|*.BNG|All Files(*.*)|*.*";
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    normalImage = cvlib.CvLoadImage(opendialog.FileName, cvlib.CV_LOAD_IMAGE_COLOR);

                    imageName = opendialog.SafeFileName;
                    imagePath = opendialog.FileName;

                    newImage = noChannelNewImage = normalImage;

                    SaveMenu.Enabled = true;
                    EditMenu.Enabled = true;
                    ImageMenu.Enabled = true;
                    ChannelMenu.Enabled = true;
                    ResizeMenu.Enabled = true;
                    FlipMenu.Enabled = true;
                    CloseMenu.Enabled = true;
                    UndoMenu.Enabled = false;
                    ResetMenu.Enabled = false;

                    previewbox.BackgroundImage = (Image)newImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    OpenMenu.PerformClick();
                }
            }
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            savedialog.FileName = imageName;
            savedialog.Filter = "Image Files(*.PNG:*.JPEG)|*.PNG;*.JPG|JPEG(*.JPEG)|*.JPG|PNG(*.PNG)|*.BNG|All Files(*.*)|*.*";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ResetMenu.Enabled == true)
                        cvlib.CvSaveImage(savedialog.FileName, ref newImage);
                    else
                        cvlib.CvSaveImage(savedialog.FileName, ref normalImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void _800x600SizeMenu_Click(object sender, EventArgs e)
        {
            ResizeImage(800, 600);
        }

        private void _1024x768SizeMenu_Click(object sender, EventArgs e)
        {
            ResizeImage(1024, 768);
        }

        private void _1280x720SizeMenu_Click(object sender, EventArgs e)
        {
            ResizeImage(1280, 720);
        }

        private void _1900x1080SizeMenu_Click(object sender, EventArgs e)
        {
            ResizeImage(1920, 1080);
        }

        private void CopyPathMenu_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(imagePath);
        }

        private void GrayChannelMenu_Click(object sender, EventArgs e)
        {
            changechannel(012);
        }

        private void RedChannelMenu_Click(object sender, EventArgs e)
        {
            changechannel(2);
        }

        private void GreenChannelMenu_Click(object sender, EventArgs e)
        {
            changechannel(1);
        }

        private void BlueChannelMenu_Click(object sender, EventArgs e)
        {
            changechannel(0);
        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The image has been modified,\nDo you want to save your changes?", "ImageViewer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                SaveMenu.Enabled = false;
                EditMenu.Enabled = false;
                ImageMenu.Enabled = false;
                ChannelMenu.Enabled = false;
                ResizeMenu.Enabled = false;
                FlipMenu.Enabled = false;
                CloseMenu.Enabled = false;

                previewbox.BackgroundImage = previewbox.InitialImage;
            }
            else
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveMenu.PerformClick();
                }
        }

        private void CustomSizeMenu_Click(object sender, EventArgs e)
        {
            CustomSizeWindow customsize = new CustomSizeWindow();
            customsize.ShowDialog();
            ResizeImage(customsize.width, customsize.height);
        }

        private void CopyImageMenu_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage((Image)newImage);
        }

        private void RestartMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HorizontallyFlipMenu_Click(object sender, EventArgs e)
        {
            FlipImage(1);
        }

        private void VerticallyFlipMenu_Click(object sender, EventArgs e)
        {
            FlipImage(0);
        }

        private void UndoMenu_Click(object sender, EventArgs e)
        {
            previewbox.BackgroundImage = (Image)tempImage;
            UndoMenu.Enabled = false;
        }

        private void ResetMenu_Click(object sender, EventArgs e)
        {
            previewbox.BackgroundImage = (Image)normalImage;
            ResetMenu.Enabled = false;
        }

        private void AdditionMenu_Click(object sender, EventArgs e)
        {
            string srcimg2imagepath;
            IplImage srcimg2, dst;

            opendialog.FileName = "";
            opendialog.Filter = "Image Files(*.PNG:*.JPEG)|*.PNG;*.JPG|JPEG(*.JPEG)|*.JPG|PNG(*.PNG)|*.BNG|All Files(*.*)|*.*";
            opendialog.ShowDialog();
            srcimg2imagepath = opendialog.FileName;
            srcimg2 = cvlib.CvLoadImage(srcimg2imagepath, cvlib.CV_LOAD_IMAGE_COLOR);

            dst = cvlib.CvCreateImage(new CvSize(srcimg2.width, srcimg2.height), srcimg2.depth, srcimg2.nChannels);

            cvlib.CvAdd(ref newImage, ref srcimg2, ref dst);
            previewbox.BackgroundImage = (Image)dst;
        }

        private void SubtractionMenu_Click(object sender, EventArgs e)
        {
            IplImage srcimg, dst, mask;

            opendialog.FileName = "";
            opendialog.Filter = "Image Files(*.PNG:*.JPEG)|*.PNG;*.JPG|JPEG(*.JPEG)|*.JPG|PNG(*.PNG)|*.BNG|All Files(*.*)|*.*";
            opendialog.ShowDialog();
            srcimg = cvlib.CvLoadImage(opendialog.FileName, cvlib.CV_LOAD_IMAGE_COLOR);

            dst = cvlib.CvCreateImage(new CvSize(srcimg.width, srcimg.height), srcimg.depth, srcimg.nChannels);

            opendialog.FileName = "";
            opendialog.Filter = "Image Files(*.PNG:*.JPEG)|*.PNG;*.JPG|JPEG(*.JPEG)|*.JPG|PNG(*.PNG)|*.BNG|All Files(*.*)|*.*";
            opendialog.ShowDialog();

            mask = cvlib.CvLoadImage(opendialog.FileName, cvlib.CV_LOAD_IMAGE_GRAYSCALE);

            cvlib.CvSub(ref newImage, ref srcimg, ref dst, ref mask);
            previewbox.BackgroundImage = (Image)dst;
        }

        private void EdgeDetectionMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented");
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            if (CloseMenu.Enabled == true)
            {
                CloseMenu.PerformClick();
                Application.Exit(); //No use after refining CloseMenu
            }
            else
                Application.Exit(); //MayBe No use after refining CloseMenu
        }

        private void TestModeMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("\nIntroducing ImageViewer Test Mode.\n\nWith the help of the Test Mode you can test many of the programs features with just a few clicks.\n\nInstructions:\n1.An image will open automatically to test the editing tools.\n2.Every operation will wait after excution for your OK to procced to the next one.\n\nWarning\nCancelation at any point will discard Test changes.\n\nStart ImageViewer Test Mode?", "ImageViewer", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                TestMode();
            }
        }
    }
}