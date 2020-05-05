using System;


namespace R5T.Ujung
{
    /// <summary>
    /// Generally the "bin" directory.
    /// </summary>
    public interface IBuildOutputDirectoryNameProvider
    {
        string GetBuildOutputDirectoryName();
    }
}
