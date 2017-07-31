using System;
using System.Collections.Generic;

namespace Nancy.Swagger
{
    [SwaggerApi]
    public interface ISwaggerModelCatalog : IEnumerable<SwaggerModelData>
    {
        SwaggerModelData GetModelForType<T>();
        SwaggerModelData GetModelForType(Type type);

        SwaggerModelData AddModel<T>();        
        void AddModels(params Type[] types);
    }
}