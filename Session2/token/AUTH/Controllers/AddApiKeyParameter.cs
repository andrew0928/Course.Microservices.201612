﻿using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace MeetUp.ApiTokenDemo.AUTH.Controllers
{
    public class AddApiKeyParameter : IOperationFilter
    {
        
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                @default = "APIKEY in HTTP Headers",
                name = "X-APIKEY",
                @in = "header",
                type = "string",
                required = true
            });
        }
    }
}