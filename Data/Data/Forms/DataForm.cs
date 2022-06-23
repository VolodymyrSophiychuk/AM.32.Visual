using System.Text.Json;
using System.Xml.Serialization;

using Microsoft.EntityFrameworkCore;

using Data.EF;
using Data.Templates;

namespace Data.Forms
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            InitializePanelsField();
        }

        private void SidebarSubmenuLoadItemSelected(object sender, EventArgs args)
        {
            using (LoadFileDialog)
            {
                LoadFileDialog.Filter = "JSON (*.json)|*.json|XML (*.xml)|*.xml";
                if (LoadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(LoadFileDialog.OpenFile()))
                    {
                        if (Path.GetExtension(LoadFileDialog.FileName) == ".json")
                            CurrentForm.FillDataGrid(DeserializeJson(reader));
                        else if (Path.GetExtension(LoadFileDialog.FileName) == ".xml")
                            CurrentForm.FillDataGrid(DeserializeXml(reader));
                    }
                }
            }
        }
        private void SidebarSubmenuLoadDBSelected(object sender, EventArgs args)
        {
            using (LwContext context = new LwContext())
            {
                CurrentForm.FillDataGrid(context.Accountings.ToList());
                CurrentForm.FillSampleGrid(context.Transactions.ToList());
            }
        }
        private void SidebarSubmenuSaveItemSelected(object sender, EventArgs args)
        {
            using (SaveFileDialog)
            {
                SaveFileDialog.Filter = "JSON (*.json)|*.json|XML (*.xml)|*.xml";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(SaveFileDialog.OpenFile()))
                    {
                        if (Path.GetExtension(SaveFileDialog.FileName) == ".json")
                            SerializeJson(writer, CurrentForm.ExtractDataAsJson());
                        else if (Path.GetExtension(SaveFileDialog.FileName) == ".xml")
                            SerializeXml(writer, CurrentForm.ExtractDataAsXml());
                    }
                }
            }
        }
        private void SidebarSubmenuSaveDBSelected(object sender, EventArgs args)
        {
            List<int> preDeleted = CurrentForm.DoesDataGridContainPreDeletedRows();
            List<int> preDeleted2 = CurrentForm.DoesSampleGridContainPreDeletedRows();

            using (LwContext context = new LwContext())
            {
                try
                {
                    if (preDeleted.Count != 0)
                    {
                        int id = 0;
                        foreach (Accounting item in CurrentForm.ExtractDataAsAccountingType())
                        {
                            if (item.Id == preDeleted.Find(t => t == item.Id))
                            {
                                context.Entry(item).State = EntityState.Deleted;
                                context.SaveChanges();
                            }
                            else
                            {
                                context.Entry(item).State = EntityState.Modified;
                                item.Id = ++id;
                            }
                        }
                    }
                    else
                    {
                        foreach (Accounting item in CurrentForm.ExtractDataAsAccountingType())
                            context.Entry(item).State = !context.Accountings.Any(f => f.Id == item.Id) ? EntityState.Added : EntityState.Modified;
                    }
                    context.SaveChanges();
                }
                catch (InvalidOperationException)
                {
                    CurrentForm.Close();
                }
            }
        }

        private void SidebarMenuJsonItemSelected(object sender, EventArgs args)
        {
            SidebarSubmenuChangeVisibility(SidebarJsonSubmenu);
            InitializeForm();
        }
        private void SidebarMenuXmlItemSelected(object sender, EventArgs args)
        {
            SidebarSubmenuChangeVisibility(SidebarXmlSubmenu);
            InitializeForm();
        }
        private void SidebarMenuDatabaseItemSelected(object sender, EventArgs args)
        {
            SidebarSubmenuChangeVisibility(SidebarDatabaseSubmenu);
            InitializeForm(true);
        }

        private void SerializeJson(StreamWriter writer, List<JSONObject> data)
        {
            foreach (JSONObject item in data)
                writer.WriteLine(JsonSerializer.Serialize(item));
        }
        private void SerializeXml(StreamWriter writer, List<XMLObject> data)
        {
            new XmlSerializer(typeof(XMLContainerObject))
                            .Serialize(writer, new XMLContainerObject(data));
        }
        private List<JSONObject> DeserializeJson(StreamReader reader)
        {
            List<JSONObject> data = new List<JSONObject>();

            using (reader)
            {
                while (!reader.EndOfStream)
                    data.Add(JsonSerializer.Deserialize<JSONObject>(reader.ReadLine()!)!);
            }

            return data;
        }
        private List<XMLObject> DeserializeXml(StreamReader reader)
        {
            using (reader)
                return (new XmlSerializer(typeof(XMLContainerObject))
                    .Deserialize(reader) as XMLContainerObject).XMLObjects;
        }

        private void SidebarJsonSampleClick(object sender, EventArgs args)
        {
            List<JSONObject> objects = CurrentForm.ExtractDataAsJson();
            List<NameSample> names = new List<NameSample>();
            List<DateTime> dates = new List<DateTime>();


            DateTime initial = DateTime.Now;
            int average = 0;

            foreach (JSONObject item in objects)
            {
                average += (initial.Year - item.Age.Year);
            }
            foreach (JSONObject item in objects)
            {
                if ((initial.Year - item.Age.Year)
                    < (average / objects.Count))
                {
                    names.Add(new NameSample((item.Firstname, item.Lastname)));
                }
            }

            CurrentForm.FillSampleGrid(names);
        }

        private void SidebarXmlSampleOneClick(object sender, EventArgs args)
        {
            List<XMLObject> objects = CurrentForm.ExtractDataAsXml();
            List<XMLObject> sample = new List<XMLObject>();

            (string town, DateTime date) filter = CurrentForm.ExtractSampleData();
            foreach (XMLObject item in objects)
            {
                if (item.TownName == filter.town && item.CallDate == filter.date)
                {
                    sample.Add(item);
                }
            }

            CurrentForm.FillSampleGrid(sample);
        }
        private void SidebarXlSampleTwoClick(object sender, EventArgs args)
        {
            List<XMLObject> objects = CurrentForm.ExtractDataAsXml();
            List<XMLObject> sample = new List<XMLObject>();

            int duration = 0;

            (string town, DateTime date) filter = CurrentForm.ExtractSampleData();
            foreach (XMLObject item in objects)
            {
                if (item.CallDate == filter.date)
                {
                    if (duration < item.CallDuration)
                        duration = item.CallDuration;
                }
            }
            sample.Add(objects.Find(item => item.CallDuration == duration));

            CurrentForm.FillSampleGrid(sample);
        }
    }
}