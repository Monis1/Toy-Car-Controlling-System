using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net;
using System.Windows.Forms;

namespace bms
{
    class weather
    {

        public string tempC;



        public void request()
        {
            string requesturl;
            try
            {
                requesturl = "http://api.worldweatheronline.com/free/v2/weather.ashx?q=Karachi&format=XML&num_of_days=5&key=d845e2ccaa954539f223a878e330f";
                WebClient webClient = new WebClient();
                Stream xmlData = webClient.OpenRead(requesturl);
                StreamReader streamReader = new StreamReader(xmlData);
                processXmlData(streamReader);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message + "\nCheck your Internet Connection", "Error"); }

        }

        private void processXmlData(StreamReader xmlData)
        {
            try
            {
                string xmlText = xmlData.ReadToEnd();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlText);
                XmlNodeList xmlNodeList = xmlDocument.SelectNodes("data/request");
                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    string type = xmlNode["type"].InnerText;
                    string query = xmlNode["query"].InnerText;

                }

                XmlNodeList currentConditionsNodeList = xmlDocument.SelectNodes("data/current_condition");
                foreach (XmlNode xmlNode in currentConditionsNodeList)
                {

                    tempC = xmlNode["temp_C"].InnerText;


                }
            }
            catch
            {

            }

        }

    }
}

