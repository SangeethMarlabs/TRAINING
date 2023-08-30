using System;
using System.Linq;
using System.Xml.Linq;

namespace Marlabs_LinqToXML_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myXML = @"<Departments>
                                   <Department>IT</Department>
                                   <Department>HR</Department>
                                   <Department>Sales</Department>
                                   <Department>Finance</Department>
                                   <Department>Accounting</Department>
                             </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new element
            xdoc.Element("Departments").Add(new XElement("Department", "Payroll"));

            //Add new element at first
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            //remove the particular node - sales department
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine($"Department :: {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
