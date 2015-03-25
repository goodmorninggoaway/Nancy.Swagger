﻿using Nancy.Swagger.Services;

namespace Nancy.Swagger.Modules
{
    public class SwaggerModule : NancyModule
    {
        public SwaggerModule(ISwaggerMetadataConverter converter)
            : base(SwaggerConfig.ResourceListingPath)
        {
            Get["/"] = _ => converter.GetSwaggerJson().ToJson();
        }
    }
}