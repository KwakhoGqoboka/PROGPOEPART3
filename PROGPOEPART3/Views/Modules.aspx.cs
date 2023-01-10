using PROGPOEPART3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOEPART3.Views.Home
{
    public partial class Modules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declartions
            string modulecode, modulename;
            string modulestartdate;
            int modulecredits, moduleweeks, modulehours;

            //Assigning declarations to the text boxes for the user to enter
            modulename = ModuleName.Text;
            modulecode = ModuleCode.Text;
            modulestartdate = MStartDate.Text;
            modulecredits = Convert.ToInt32(ModuleCredits.Text);
            moduleweeks = Convert.ToInt32(ModuleWeeks.Text);
            modulehours = Convert.ToInt32(ModuleHours.Text);



            //Call from liabrary class
            List<Liabrary> List = Liabrary.ProgramList;
            try
            {
                Liabrary display = new Liabrary(modulecode, modulename, modulecredits, modulehours, modulestartdate, moduleweeks);
                Liabrary.ProgramList.Add(display);
                display.SelfStudyCalculation();
                display.RemainderCalculation();

                Response.Write(display.ToString());
                display.AddModules();
                Response.Write($"Module {display.ModuleCode} has been added");

            }
            catch (Exception x)
            {
                Response.Write(x.Message);
            }
            
            
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (Liabrary x in Liabrary.ProgramList)
            {
                ProgramList.Items.Add(x.ToString());
            }
        }
    }
}