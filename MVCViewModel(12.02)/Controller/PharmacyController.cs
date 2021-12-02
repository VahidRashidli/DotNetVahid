using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;
namespace MVC
{
    public class PharmacyController : Controller
    {
        public IActionResult Drug()
        {
            Drug drug1 = new Drug { Name = "Kratom" };
            Drug drug2 = new Drug{Name= "LSD" };
            Drug drug3 = new Drug{Name= "MDMA" };
            Drug drug4 = new Drug{Name= "Mescaline " };
            DrugType drugType1 = new DrugType("Depressants");
            DrugType drugType2 = new DrugType("Stimulants");
            drug1.DrugType = drugType1;
            drug2.DrugType = drugType1;
            drug3.DrugType = drugType2;
            drug4.DrugType = drugType2;
            List<Drug> drugs = new List<Drug> { drug1, drug2, drug3, drug4 };
            List<DrugType> drugTypes = new List<DrugType>() { drugType1, drugType2 };
            PharmacyDrugViewModel viewModel = new PharmacyDrugViewModel() {drugs=drugs,drugTypes=drugTypes };
   
            return View(viewModel);
        }
        public IActionResult DrugType()
        {
            DrugType drugType1 = new DrugType("Depressants");
            DrugType drugType2 = new DrugType("Stimulants");
            List<DrugType> drugTypes = new List<DrugType>() { drugType1, drugType2 };
            return View(drugTypes);
        }
    }
}
