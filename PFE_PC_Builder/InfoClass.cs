using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE_PC_Builder
{
    public class InfoClass
    {
        public static int SelectedControlID;
        public static string SelectedControlOption1;
        public static string SelectedControlOption2;
        public static float SelectedControlPrice;
        public static string SelectedControlImage;
        //
        public static int CurrentCustomerID;
        public static string CurrentCustomerFName;
        public static string CurrentCustomerLName;
        //
        public static int CPU_ID;
        public static float CPU_Price;

        public static int GPU_ID;
        public static float GPU_Price;

        public static int MEM_ID;
        public static float MEM_Price;

        public static int MB_ID;
        public static float MB_Price;

        public static int STG_ID;
        public static float STG_Price;

        public static int PS_ID;
        public static float PS_Price;

        public static int CPUC_ID;
        public static float CPUC_Price;

        public static int CASE_ID;
        public static float CASE_Price;
        public static string CASE_Image;
        //
        public static int SelectedCartID;
        public static float SelectedCartTotal;
        public static string SelectedCartName;
        //
        public static bool ControlClicked = false;
        public static string LastTable;
        public static Forms.FormBuild BuildForm;
        public static PForms.FormCheckout CheckForm;
        public static PForms.FormProfil ProfilForm;
    }
}
