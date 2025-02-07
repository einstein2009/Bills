using CommunityToolkit.Mvvm.Input;
using BillsManager.Models;

namespace BillsManager.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}