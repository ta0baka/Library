using QRCoder;

namespace Library
{
    public partial class RateForm : Form
    {
        public RateForm()
        {
            InitializeComponent();
            pbQR.Visible = false;
            btnGenerateQRCode.Click += btnGenerateQRCode_Click;
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/ta0baka/Task1";
            GenerateQRCode(githubUrl);
            btnGenerateQRCode.Visible = false;
            pbQR.Visible = true;

        }

        private void GenerateQRCode(string url)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(6);
                        pbQR.Image = qrCodeImage;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
