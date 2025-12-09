using System.Diagnostics.CodeAnalysis;

namespace Roslan.BlazorExtensions.Bootstrap.Components;

public class FileManagerDownloadRequestEventArgs {

    public required FileManagerFile File { get; set; }



    [SetsRequiredMembers]
    public FileManagerDownloadRequestEventArgs(FileManagerFile file) {
        File = file;
    }
}