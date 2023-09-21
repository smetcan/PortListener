using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortListener
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            ListSerialPorts();
            InitializeSerialPort();
        }

        private void ListSerialPorts()
        {
            string[] portNames = SerialPort.GetPortNames();

            if (portNames.Length > 0)
            {
                // ComboBox'ı temizle
                cmoPorts.Items.Clear();

                // Seri portları ComboBox'a ekle
                cmoPorts.Items.AddRange(portNames);

                // İlk portu seçili yap (isteğe bağlı)
                cmoPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Seri port bulunamadı.");
            }
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();

            // SerialPort ayarlarını burada yapılandırabilir
            // Örnek: serialPort.BaudRate = 9600;

            // DataReceived olayını tanımı
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Encoding = Encoding.GetEncoding("ISO-8859-9"); // Türkçe karakter setini temsil eder.

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Veri alma işlemi 
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadExisting();

            // Veriyi RichTextBox'a ekleme
            AppendTextToLog(data);
        }

        private void AppendTextToLog(string text)
        {
            if (txtLog.InvokeRequired)
            {
                // RichTextBox, farklı bir thread üzerinden erişilecekse Invoke kullanın
                txtLog.Invoke(new Action(() => AppendTextToLog(text)));
            }
            else
            {
                // RichTextBox'a veri ekleme
                txtLog.AppendText(text);
            }
        }


        private void cmoPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPortName = cmoPorts.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedPortName))
            {
                // Seçilen portun detaylarını al
                SerialPort port = new SerialPort(selectedPortName);
                string portDetails = $"Port Adı: {port.PortName}\n"
                                   + $"Bağlantı Hızı: {port.BaudRate} bps\n"
                                   + $"Veri Bitleri: {port.DataBits}\n"
                                   + $"Stop Bitleri: {port.StopBits}\n"
                                   + $"Parity: {port.Parity}";

                // Detayları göstermek için Label'ları güncelle
                lblPortDetails.Text = portDetails;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPortName = cmoPorts.SelectedItem as string;
            

            if (!string.IsNullOrEmpty(selectedPortName) )
            {
               
                    // Porta bağlan
                    serialPort.PortName = selectedPortName;
                    serialPort.Open();
                    MessageBox.Show($"{selectedPortName} porta bağlandı.");
                    panel1.BackColor = Color.LightGreen;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
               
                
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // Portu kapat
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Port bağlantısı kesildi.");
                panel1.BackColor= Color.Red;
                btnConnect.Enabled=true; 
                btnDisconnect.Enabled=false;
                
                
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
