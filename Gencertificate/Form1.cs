using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Gencertificate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Gencer_Click(object sender, EventArgs e)
        {
            txct_Ountput.Clear();
            string path = txt_Path.Text;
            string Filename = txt_filename.Text;
            string setPath_private = $"\"{path}\\private.key\"";

            if (ck_NewKey.Checked)
            {
                //Run the following command to generate a private key: 
                string excmd = $"openssl genrsa -out {setPath_private} 2048";
                RunCommand(excmd);
                txct_Ountput.AppendText(excmd);
                txct_Ountput.AppendText("\n---------------------\n");
            }
            

            string setPath_certificate = "\"" + path + "\\certificate.csr\"";
            //Run the following command to generate a private key: 

            string c_ = txt_Country.Text; 
            string ST_ = txt_State.Text; 
            string L_  = txt_City.Text; 
            string o_ = txt_Organization.Text; 
            string ou_ = txt_OU.Text; 
            string CN_ = txt_CommonName.Text;
            string em_ = txt_Email.Text;
            string sp_ = txt_ServiceProvider.Text;
            

            string textContent = txct_Ountput.Text;
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy-MM-dd HH-mm-ss");

            string pathText = $"{ path }\\openssl.cnf";
            string mess = $"[req]\r\ndistinguished_name = req_distinguished_name\r\nreq_extensions = SAN\r\n\r\n[req_distinguished_name]\r\n\r\n[SAN]\r\nsubjectAltName=DNS:{CN_}";
            // Write the content to the file
            File.WriteAllText(pathText, mess);

            string enterValue = "/C="+ c_ + "/ST="+ ST_ + "/L="+ L_ + "/O="+o_+"/OU="+ ou_ + "/CN="+ CN_ + "/emailAddress="+ em_ + "/SP="+ sp_ + "";
            // openssl req -new -key "G:\test\New folder\test1\private.key" -out "G:\test\New folder\test1\certificate.csr" -subj "/C=US/ST=State/L=City/O=Organization/OU=OrganizationalUnit/CN=CommonName"
            string exitValue = $"openssl req -new -key {setPath_private} -out {setPath_certificate} -subj \"{enterValue}\" -reqexts SAN -config \"{pathText}\"";
            //string exitValue = $"openssl req -new -key {setPath_private} -out {setPath_certificate} -subj \"{enterValue}\"";
            //openssl req -new -key "G:\certi\testApp\private.key" -out "G:\certi\testApp\certificate.csr" -subj           -reqexts SAN -config "G:\certi\testApp\openssl.cnf"
            RunCommand(exitValue);
            txct_Ountput.AppendText(exitValue);
            txct_Ountput.AppendText("\n---------------------\n");
            string day = txt_ExpiryDate.Text;
            // openssl x509 -req -days 365 -in "G:\certi\testApp\certificate.csr" -signkey "G:\certi\testApp\private.key" -out "G:\certi\testApp\Private.crt"
            exitValue = $"openssl x509 -req -days {day} -in {setPath_certificate} -signkey {setPath_private} -out \"{path}\\Private.crt\"";
            RunCommand(exitValue);
            txct_Ountput.AppendText(exitValue);
            txct_Ountput.AppendText("\n---------------------\n");

            // openssl x509 -req -days 365 -in ""G:\certi\testApp\certificate.csr"" -signkey ""G:\certi\testApp\private.key"" -out "G:\certi\testApp\Private.crt"
            string pass = txt_Password.Text;
            // openssl pkcs12 -export -out "G:\certi\testApp\certificate.pfx" -inkey "G:\certi\testApp\private.key" -in "G:\certi\testApp\Private.crt"
            exitValue = $"openssl pkcs12 -export -out \"{path}\\{Filename}.pfx\" -inkey {setPath_private} -in \"{path}\\Private.crt\" -passout pass:{pass} -name \"{CN_}\"";
            RunCommand(exitValue);
            txct_Ountput.AppendText(exitValue);
            txct_Ountput.AppendText("\n\n----------------------------------------------------------\n");



//            openssl req -new - key "G:\certi\testApp\Gen3\New folder\private.key" -out "G:\certi\testApp\Gen3\New folder\certificate.csr" - subj "/C=asdasd/ST=sada/L=asdasd/O=asdasd/OU=asdasd/CN=verifycerv2/emailAddress=asdasda/SP=asdasd" - reqexts SAN - config "G:\certi\testApp\Gen3\New folder\openssl.cnf"
//-------------------- -
//openssl x509 - req - days 852 -in "G:\certi\testApp\Gen3\New folder\certificate.csr" - signkey "G:\certi\testApp\Gen3\New folder\private.key" -out "G:\certi\testApp\Gen3\New folder\Private.crt"
//            -------------------- -
//            openssl pkcs12 - export -out "G:\certi\testApp\Gen3\New folder\verifycerv2.pfx" - inkey "G:\certi\testApp\Gen3\New folder\private.key" -in "G:\certi\testApp\Gen3\New folder\Private.crt" - passout pass: C4544142z - *x - name "verifycerv2"

            try
            {
                string textContent_ = txct_Ountput.Text;
           
                string formattedDate_ = date.ToString("yyyy-MM-dd HH-mm-ss");

                string pathText_ = path + "\\"+ Filename +" "+ formattedDate_ + ".txt";
                // Write the content to the file
                File.WriteAllText(pathText_, "Password : "+ pass+"\n\n");
                using (StreamWriter writer = File.AppendText(pathText_))
                {
                    writer.WriteLine(textContent_);
                }

            }
            catch (Exception ex)
            {
               
            }

        }

        static string RunCommand(string command)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

               return output;
            }
        }

        static string RunOpenSSLCommand(string arguments)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "openssl";
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;

                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output;
            }
        }


        private void BT_SetPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txt_Path.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    Console.WriteLine("No folder selected.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txct_Ountput.Clear();
        }

        private void BT_OpenPath_Click(object sender, EventArgs e)
        {
            string folderPath = txt_Path.Text;
            if (!string.IsNullOrEmpty(folderPath))
            {
                // Start the default file manager with the specified folder path
                Process.Start(new ProcessStartInfo
                {
                    FileName = folderPath,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p = "C:\\Windows\\System32\\drivers\\etc";
            try
            {
                if (!string.IsNullOrEmpty(p))
                {
                    // Start the default file manager with the specified folder path
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = p,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("file not found : "+p);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://server.cryptomix.com/secure/?_gl=1*1gqirjo*_gcl_au*NjU1Nzc0OTQxLjE3MDU2Mzg0OTA.";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
