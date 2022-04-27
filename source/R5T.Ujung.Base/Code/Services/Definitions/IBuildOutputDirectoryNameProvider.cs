using System;using R5T.T0064;


namespace R5T.Ujung
{[ServiceDefinitionMarker]
    /// <summary>
    /// Generally the "bin" directory.
    /// </summary>
    public interface IBuildOutputDirectoryNameProvider:IServiceDefinition
    {
        string GetBuildOutputDirectoryName();
    }
}
