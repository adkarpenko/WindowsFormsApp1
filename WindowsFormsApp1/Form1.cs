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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string[]> data = new List<string[]>();
        List<string[]> dataNow = new List<string[]>();
        List<Company> companies = new List<Company>();
        public List<Company2> companies2 = new List<Company2>();
        private int downval;
        private int upval;
        private string[] str;
        public Form1()
        {
            downval = 10;
            upval = -1;
            InitializeComponent();
            str = File.ReadAllLines("../../TCCU.csv");
            for (int i = 0; i < str.Length; i++)
            {
                string[] strNow = str[i].Split(';');
                try
                {
                    DateTime a = DateTime.Parse(strNow[3]);
                    int b = int.Parse(strNow[4]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                data.Add(new string[6]);
                for (int j = 0; j < 6; j++)
                {
                    if (j != 3)
                        data[data.Count - 1][j] = strNow[j];
                    else
                        data[data.Count - 1][j] = DateTime.Parse(strNow[j]).ToString();
                }

                if (i < 10)
                {
                    dataNow.Add(new string[6]);
                    for (int j = 0; j < 6; j++)
                    {
                        if (j != 3)
                            dataNow[dataNow.Count - 1][j] = strNow[j];
                        else
                            dataNow[dataNow.Count - 1][j] = DateTime.Parse(strNow[j]).ToString();
                    }
                }
            }

            foreach (var s in dataNow)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (upval == -1)
                MessageBox.Show("Выше некуда");
            else
            {
                downval--;
                int k = upval;
                dataNow.Clear();
                for (int i = 0; i < 10; i++)
                {
                    dataNow.Add(new string[6]);
                    for (int j = 0; j < 6; j++)
                    {
                        dataNow[dataNow.Count - 1][j] = data[k][j];
                    }

                    k++;
                }
                upval--;
                dataGridView1.Rows.Clear();
                foreach (var s in dataNow)
                {
                    dataGridView1.Rows.Add(s);
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (downval == 1460)
                MessageBox.Show("Ниже некуда");
            else
            {
                upval++;
                int k = downval - 9;
                dataNow.Clear();
                for (int i = 0; i < 10; i++)
                {
                    dataNow.Add(new string[6]);
                    for (int j = 0; j < 6; j++)
                    {
                        dataNow[dataNow.Count - 1][j] = data[k][j];
                    }

                    k++;
                }
                downval++;
                dataGridView1.Rows.Clear();
                foreach (var s in dataNow)
                {
                    dataGridView1.Rows.Add(s);
                }
            }
        }

        private void buttonVisibleJSON_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer formater = new DataContractJsonSerializer(typeof(List<Company>),
                new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                });
            try
            {
                for (int i = 0; i < dataNow.Count; i++)
                {
                    companies.Add(new Company(dataNow[i][0], dataNow[i][1],
                        dataNow[i][2], DateTime.Parse(dataNow[i][3]), int.Parse(dataNow[i][4]), dataNow[i][5]));
                }
                using (FileStream fs = new FileStream("../../VisibleJSON.json", FileMode.Create))
                {
                    formater.WriteObject(fs, companies);
                }
                companies.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAllJSON_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer formater = new DataContractJsonSerializer(typeof(List<Company>),
                new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                });
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    companies.Add(new Company(data[i][0], data[i][1],
                        data[i][2], DateTime.Parse(data[i][3]), int.Parse(data[i][4]), data[i][5]));
                }
                using (FileStream fs = new FileStream("../../AllJSON.json", FileMode.Create))
                {
                    formater.WriteObject(fs, companies);
                }
                companies.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVisibleXml_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Company2>));
            try
            {
                for (int i = 0; i < dataNow.Count; i++)
                {
                    companies2.Add(new Company2(dataNow[i][0], dataNow[i][1],
                        dataNow[i][2], DateTime.Parse(dataNow[i][3]), int.Parse(dataNow[i][4]), dataNow[i][5]));
                }
                using (FileStream fs = new FileStream("../../VisibleXml.xml", FileMode.Create))
                {
                    ser.Serialize(fs, companies2);
                }
                companies2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAllXml_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Company2>));
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    companies2.Add(new Company2(data[i][0], data[i][1],
                        data[i][2], DateTime.Parse(data[i][3]), int.Parse(data[i][4]), data[i][5]));
                }
                using (FileStream fs = new FileStream("../../AllXml.xml", FileMode.Create))
                {
                    ser.Serialize(fs, companies2);
                }
                companies2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [DataContract]
        public class Company
        {
            public Company(string name, string foundDate, string city, DateTime dateTime, int amt, string round)
            {
                Name = name;
                this.foundDate = foundDate;
                City = city;
                this.dateTime = dateTime;
                this.amt = amt;
                Round = round;
            }
            [DataMember]
            public string Name { get; private set; }
            [DataMember]
            public string foundDate { get; private set; }
            [DataMember]
            public string City { get; private set; }
            [DataMember]
            public DateTime dateTime { get; private set; }
            [DataMember]
            public int amt { get; private set; }
            [DataMember]
            public string Round { get; private set; }
        }

        [Serializable]
        public class Company2
        {
            public Company2()
            { }
            public Company2(string name, string foundDate, string city, DateTime dateTime, int amt, string round)
            {
                Name = name;
                this.foundDate = foundDate;
                City = city;
                this.dateTime = dateTime;
                this.amt = amt;
                Round = round;
            }
            public string Name { get; set; }
            public string foundDate { get; set; }
            public string City { get; set; }
            public DateTime dateTime { get; set; }
            public int amt { get; set; }
            public string Round { get; set; }
        }
    }
}
