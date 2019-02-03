using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo4DataLib
{
    public class SampleManager
    {

        private List<Group> availableGroups = new List<Group>();
        private List<Software> availableSoftware = new List<Software>();
        private Stock currentStock;
        static Random rand = new Random();

        public Stock CurrentStock { get { return currentStock; } }
        public List<Group> AvailableGroups { get { return availableGroups; } }

        public SampleManager()
        {
            #region Groups and Software
            availableSoftware.Add(new Software("Office Home Edition"));
            availableSoftware.Add(new Software("Office Professional Edition"));
            availableSoftware.Add(new Software("Knue Office Expert Edition"));
            availableSoftware.Add(new Software("Knue Office Beginner Edition"));
            availableSoftware.Add(new Software("Empty Software Package"));


            availableGroups.Add(new Group()
            {
                Name = "Office Software",
                Software = new List<Software>() 
                {
                    availableSoftware[0], 
                    availableSoftware[1] ,
                    availableSoftware[2] ,
                    availableSoftware[3] ,
                    availableSoftware[4] 
                }
            });

            availableSoftware[0].Category = availableGroups.Last();
            availableSoftware[1].Category = availableGroups.Last();
            availableSoftware[2].Category = availableGroups.Last();
            availableSoftware[3].Category = availableGroups.Last();
            availableSoftware[4].Category = availableGroups.Last();


            availableSoftware.Add(new Software("Virus Scan XYZ"));
            availableSoftware.Add(new Software("Super Virus Scan AbCd"));
            availableSoftware.Add(new Software("Average Virus Scan 2 Years"));
            availableSoftware.Add(new Software("Newton Virus Scan 1 Year"));
            availableSoftware.Add(new Software("Newton Virus Scan 2 Year"));
            availableSoftware.Add(new Software("Newton Virus Scan 1 Year, 5 lic."));
            availableSoftware.Add(new Software("Newton Virus Scan 1 Year, 3 lic."));

            availableGroups.Add(new Group()
            {
                Name = "Virus Tools",
                Software = new List<Software>() 
                {
                    availableSoftware[5], 
                    availableSoftware[6] ,
                    availableSoftware[7] ,
                    availableSoftware[8] ,
                    availableSoftware[9] ,
                    availableSoftware[10] ,
                    availableSoftware[11]
                }
            });

            availableSoftware[5].Category = availableGroups.Last();
            availableSoftware[6].Category = availableGroups.Last();
            availableSoftware[7].Category = availableGroups.Last();
            availableSoftware[8].Category = availableGroups.Last();
            availableSoftware[9].Category = availableGroups.Last();
            availableSoftware[10].Category = availableGroups.Last();
            availableSoftware[11].Category = availableGroups.Last();

            availableSoftware.Add(new Software("Coreationl Paint"));
            availableSoftware.Add(new Software("Coreationl Paint Express"));
            availableSoftware.Add(new Software("Coreationl Paint 5 Lic"));
            availableSoftware.Add(new Software("Coreationl Paint 10 Lic"));
            availableSoftware.Add(new Software("Adopi Photo Store"));
            availableSoftware.Add(new Software("Adopi Photo Store Suite"));
            availableSoftware.Add(new Software("Adopi Photo Store Students Edition"));

            availableGroups.Add(new Group()
            {
                Name = "Painting Software",
                Software = new List<Software>() 
                {
                    availableSoftware[12], 
                    availableSoftware[13] ,
                    availableSoftware[14] ,
                    availableSoftware[15] ,
                    availableSoftware[16] ,
                    availableSoftware[17] ,
                    availableSoftware[18]
                }
            });

            availableSoftware[12].Category = availableGroups.Last();
            availableSoftware[13].Category = availableGroups.Last();
            availableSoftware[14].Category = availableGroups.Last();
            availableSoftware[15].Category = availableGroups.Last();
            availableSoftware[16].Category = availableGroups.Last();
            availableSoftware[17].Category = availableGroups.Last();
            availableSoftware[18].Category = availableGroups.Last();

            availableSoftware.Add(new Software("Architect CAD Student Lic"));
            availableSoftware.Add(new Software("Architect CAD Company Lic"));
            availableSoftware.Add(new Software("FlexibleWorks CAD Company Lic"));
            availableSoftware.Add(new Software("FlexibleEdge CAD"));

            availableGroups.Add(new Group()
            {
                Name = "CAD Tools",
                Software = new List<Software>() 
                {
                    availableSoftware[19], 
                    availableSoftware[20] ,
                    availableSoftware[21] ,
                    availableSoftware[22]
                }
            });

            availableSoftware[19].Category = availableGroups.Last();
            availableSoftware[20].Category = availableGroups.Last();
            availableSoftware[21].Category = availableGroups.Last();
            availableSoftware[22].Category = availableGroups.Last();
            #endregion

            currentStock = new Stock();


            foreach (var item in availableSoftware)
            {
                if (rand.Next(1, 20) > 5)
                { //generate 
                    currentStock.OnStock.Add(new StockEntry() { SoftwarePackage = item, Amount = rand.Next(0, 40) });
                }
            }

        }
    }
}
