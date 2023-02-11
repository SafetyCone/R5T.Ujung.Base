using System;using R5T.T0064;


namespace R5T.Ujung
{
    /// <summary>
    /// Generally the "bin" directory.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IBuildOutputDirectoryNameProvider:IServiceDefinition
    {
        string GetBuildOutputDirectoryName();
    }
}
