using DripStore.Core.Contracts;
using DripStore.Core.Models;
using DripStore.UI;
using DripStore.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace DripStore.UI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexReturnProduct()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> categoryContext = new Mocks.MockContext<ProductCategory>();
            HomeController controller = new HomeController(productContext,categoryContext);
            productContext.Insert(new Product());

            var result = controller.Index() as ViewResult;
            var veiwModel = (ProductListVM)result.ViewData.Model;
        }
    }
    
    
        
        
     
}       