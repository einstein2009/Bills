using CommunityToolkit.Mvvm.Input;
using Bills.Models;

namespace Bills.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}