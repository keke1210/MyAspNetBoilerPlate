using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using static MyAspNetBoilerPlate.Controllers.PersonsController;

namespace MyAspNetBoilerPlate
{
    public class OdataModelConfigurations : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string routePrefix)
        {
            builder.EntitySet<Person>("Persons");
        }
    }
}
