using System.Diagnostics.CodeAnalysis;
using Roslan.BlazorExtensions.Bootstrap.Components.FileManager;

namespace Roslan.BlazorExtensions.Bootstrap.Components;

public class FileManagerItemClickEventArgs : EventArgs {


    public required FileManagerItem Item { get; set; }




    [SetsRequiredMembers]
    public FileManagerItemClickEventArgs(FileManagerItem item) {
        Item = item;
    }
}