using MA_Delivery_Project.DBConnStr;
using MA_Delivery_Project.LabehData.Info;
using MA_Delivery_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.ObjectModelRemoting;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace MA_Delivery_Project.Controllers
{
    public class OrganizationController : Controller
    {
        public  LabehDbConext GetEntities;
        
        public OrganizationController(LabehDbConext context)
        {
            GetEntities = context;//
        }
        public IActionResult Delve() 
        {
          
            try {    
                Organization objCourse = GetEntities.Organizationsa.Single(A => A.ID == 3   );

            GetEntities.Organizationsa.Remove(objCourse);
              
            GetEntities.SaveChanges();
            } 
            catch (Exception ex) 
              { 

              }
          //  ViewBag["dd"] = "ppp";

            return View("");
        }
        public IActionResult BraFun() 
        {
            var y = new AllMod();
            y.OrgsSubList = GetEntities.OrgsSubsa.ToList();

            return View(y);
        }
        
        public IActionResult CommFun() {
            var y = new AllMod();
            y.PaymList = GetEntities.Paymentsa.ToList();
            y.ContList = GetEntities.Contractsa.ToList();

            return View(y);
        }
        public IActionResult PayAll() {
            var lst = new AllMod();
              lst.PaymList =GetEntities.Paymentsa.ToList();
            
            
            return View(lst);
        }
        public IActionResult ContAll()
        {
            var y = new AllMod();
            y.OrgsSubList = GetEntities.OrgsSubsa.ToList();

            return View(y);
        }
        public IActionResult RelatedOrgs()
        {
            var y = new AllMod();
            y.OrgsList = GetEntities.Organizationsa.ToList();
            y.OrgsSubList = GetEntities.OrgsSubsa.ToList();

            return View(y);
        }
            public IActionResult OrgsPlusCat()
        {
            //
            var y = new AllMod();
            y.ContList = GetEntities.Contractsa.ToList();
            y.OrgsList = GetEntities.Organizationsa.ToList();
            y.SubCatS = GetEntities.SubCategoriesa.ToList();

            return View(y);
        }
        public IActionResult ViewOrganize()
        {
             
            var y = new AllMod();
            y.ContList = GetEntities.Contractsa.ToList();
            y.OrgsList = GetEntities.Organizationsa.ToList();
            y.SubCatS = GetEntities.SubCategoriesa.ToList();
         //   var tt = GetEntities.customerCusCatsa.Where(c => c.CustomerID == 9).FirstOrDefault();


            return View(y);
        }
        public IActionResult AddOganization(Organization Org)
        {
            var a =Org.OrganizeCode;
            var b=Org.OrganizeName;

            Organization OrgVal =new Organization();
           
            OrgVal.OrganizeCode = a;
            OrgVal.OrganizeName = b;


            return RedirectToAction("Index");
        }
        public IActionResult AddContract(Contract Cont)
        {
            var Valcode  = Cont.Code;
            var Valowner = Cont.OwnerName;
            var ValDF = Cont.DateFrom;
            var ValDT = Cont.DateTo;
            var Valp1 = Cont.Phone1;
            var Valp2 = Cont.Phone2;


            Contract Con = new Contract();

           


            return RedirectToAction("Index");
        }
        public string AddOrgsCat(SubCategory subc)
        {
            int a = 1;
            string c = subc.SubCatName;
            int vv = subc.OrganizationRef;
            SubCategory Scat = new SubCategory();
            Scat.Code = a;
            Scat.SubCatName = c;
            Scat.OrganizationRef=vv ;
            GetEntities.SubCategoriesa.Add(Scat);
            GetEntities.SaveChanges();
            return "Done";
        }
        public string AddOrgs(Organization orgs) {
            int CCode = orgs.OrganizeCode;//

            string OName = orgs.OrganizeName;//

            Organization OPro = new Organization();//

            OPro.OrganizeCode = CCode;//
            OPro.OrganizeName = OName;//

            GetEntities.Organizationsa.Add(OPro);

            GetEntities.SaveChanges();
            
            return "";
        }
        public string AddContract() {


            return "";
        }
        public string AddRelated( OrgsSub RelatOrg) {
            int C = RelatOrg.OrgsSubCode;
            string N = RelatOrg.OrgsSubName;
            string lat = RelatOrg.Latitiude;
            string lont = RelatOrg.Logtitude;
            int orgsRef = RelatOrg.OrganizationRef;


            OrgsSub AddOrgsRelated = new OrgsSub();


            AddOrgsRelated.OrgsSubCode = C;
            AddOrgsRelated.OrgsSubName = N;
            AddOrgsRelated.Latitiude = lat; 
             AddOrgsRelated.Logtitude = lont;   
            AddOrgsRelated.OrganizationRef = orgsRef;
            GetEntities.OrgsSubsa.Add(AddOrgsRelated);
            GetEntities.SaveChanges();

            return "2222";
        }
        public string ValContAdd(Contract conFu) {
            int C = conFu.Code;
            string On = conFu.OwnerName;
            string OA = conFu.OrganizationAddress;
            string Pn1 = conFu.Phone1;
            string Pn2 = conFu.Phone2;
            string DF = conFu.DateFrom;
            string DT = conFu.DateTo;
            double Cost = conFu.Cost;
            int orsub = conFu.OrgsSubIdRef;
            Contract contobj = new Contract();//
            contobj.Code = C;
            contobj.OwnerName = On; 
            contobj.OrganizationAddress = OA;   
            contobj.Phone1 = Pn1;   
            contobj.Phone2 = Pn2;   
            contobj.DateFrom = DF;  
            contobj.DateTo = DT;    
            contobj.Cost = Cost;    
            contobj.OrgsSubIdRef = orsub;   
            GetEntities.Contractsa.Add(contobj);
            GetEntities.SaveChanges();
            return "nnnn";
        }


        public string  AddPay(Payment pay) {
            int  C = pay.Code;
            string P = pay.PaymentWay;

            Payment CPay = new Payment();
            CPay.Code =  C;
            CPay.PaymentWay =  P;
         
            GetEntities.Paymentsa.Add(CPay);
            
            GetEntities.SaveChanges();
            return C.ToString()+' '+P.ToString();
        }
        public string ValAddBra(Branch Brn) {
           
            string C = Brn.BranchCode;
            string Na = Brn.BranchName;
            string Lat = Brn.latitude;
            string Log = Brn.longtitude;
            int Co = Brn.OrgsSubID;
            Branch BrOb = new Branch();
            BrOb.BranchCode = C;
            BrOb.BranchName = Na;
            BrOb.latitude = Lat;
            BrOb.longtitude = Log;
            BrOb.OrgsSubID = Co;

            GetEntities.Branchesa.Add(BrOb);
            GetEntities.SaveChanges();
               

            return "nnnnm";
        }
        public IActionResult BranchContGet()
        {
            var GetBr = new AllMod();
            GetBr.BranchList = GetEntities.Branchesa.ToList();

            return View (GetBr);
        }
        public string ViewbaseBra(BranchSubOrgsContract objBSOC) {

            int C = objBSOC.BranchId;
            
            var Fees = objBSOC.GenerationFees;
            var sts = objBSOC.Status;

            //

            var selectVal = from item in GetEntities.Branchesa// get orgs
                            where   item.ID == C
                            select item.OrgsSubID;
           
            // int x = int.Parse(selectVal);
      


            return "";
        }

        public string DelVal() {
           
            Organization objCourse = GetEntities.Organizationsa.Single(A => A.ID == 1 && A.OrganizeName!="");
          
            GetEntities.Organizationsa.Remove(objCourse);
            // executes the appropriate commands to implement the changes to the database  
            GetEntities.SaveChanges();
            return "";
        }
    }
}
