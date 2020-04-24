using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_Stvaranja
{
    class Dataset : ICloneable
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Dataset(Dataset copiedDataset)
        {
            this.data = new List<List<string>>();

            foreach (List<string> list in copiedDataset.data)
            {
                List<string> row = new List<string>();
                foreach (string name in list)
                {
                    row.Add(name);
                }
                this.data.Add(row);
            }
        }

        public object Clone()
        {

            Dataset clone = new Dataset(this);

            /*U ovom slučaju duboko kopiranje daje iste rezultate kao i plitko jer se traži samo testiranje s ispisom.
            Ali u slučaju mijenjanja atributa objekta kod plitkog kopiranja imali bi problem, jer se kod reference tipova
            podataka kopira samo referenca na objekt pa se 2 reference odnose na isti objekt. time se promjenom stanja jednog objekta
            implicitno mijenjaju i ostali objekti s kojima dijeli taj objekt. U tom slučaju nužno je duboko kopiranje radi sprječavanja toga.*/

            return clone;
        }

        
    }
}
