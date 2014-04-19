using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace CBSData
{
    /// <summary>
    /// de plaats waar taken kunnen uitgevoerd worden als het ophalen van de tabellen.
    /// </summary>
    public class TableManager
    {
        public TableManager()
        {
            
        }
        public TableManager(string url)
        {
            this.URL = url;
        }

        public string URL
        {
            get;
            set;
        }

        public List<string> GetDataProperties()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(this.URL + "DataProperties/");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            // de standaard namespace
            nsmgr.AddNamespace("x", "http://www.w3.org/2005/Atom");
            nsmgr.AddNamespace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");
            nsmgr.AddNamespace("d", "http://schemas.microsoft.com/ado/2007/08/dataservices");

            var nodes = doc.SelectNodes("//x:entry/x:content/m:properties/d:Key", nsmgr);

            List<string> rtw = new List<string>();

            foreach (XmlNode node in nodes)
            {
                rtw.Add(node.InnerText);
            }

            return rtw;


        }

        public int CountRows()
        {
            string link = this.URL + "TypedDataSet/$count";

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(link);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();

            return Convert.ToInt32( content);
        }

        public LocalCatalogTable LocalCatalogTable
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TableData TableData
        {
            get;
            private set;
        }
    
        public void GetAllData(DataCriteria criteria)
        {
            /*var document = XDocument.Load(this.URL);


            var el = document.XPathSelectElements("/feed/entry");

            int aantal = document.XPathSelectElements("/feed/entry").Count();*/

            XmlDocument doc = new XmlDocument();
            doc.Load(this.URL+"TypedDataSet/"+criteria.Query);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            // de standaard namespace
            nsmgr.AddNamespace("x", "http://www.w3.org/2005/Atom");
            nsmgr.AddNamespace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");


            var nodes = doc.DocumentElement.SelectNodes("//x:entry/x:content/m:properties", nsmgr);

            if(nodes.Count>0)
            {
                List<string> header = new List<string>();
                foreach(XmlElement node1 in nodes.Item(0))
                {
                    header.Add(node1.Name.Remove(0,2));
                }

                List<List<object>> rows = new List<List<object>>();
                foreach(XmlNode propertie in nodes)
                {
                    List<object> row = new List<object>();
                    foreach(XmlElement val in propertie)
                    {
                        row.Add(val.InnerText);
                    }
                    rows.Add(row);
                }

                this.TableData = new TableData(header, rows);
            }

            
            
        }
    }
}
