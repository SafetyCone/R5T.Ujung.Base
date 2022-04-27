using System;using R5T.T0064;


namespace R5T.Ujung
{[ServiceDefinitionMarker]
    public interface IProjectDirectoryNameProvider:IServiceDefinition
    {
        string GetProjectDirectoryName();
    }
}
