using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.AspNet.OData;
using RealEstateManager.Models.Data;
using RealEstateManager.Repository;

namespace RealEstateManager.Areas.Public.Controllers
{
    public class EstateApiController : ODataController
    {
       
       private EstatesContext db = new EstatesContext();
       [EnableQuery]
       public IQueryable<Estate> Get()
       {
            return db.DatabaseContext.Estates;
       }
     
    }
}
