using System.Collections.ObjectModel;

namespace TaskManagementAppMaui;

public partial class MainPage : ContentPage
{

    // Attributes
    private readonly ObservableCollection<Todo> tasks;

    public MainPage()
    {
        InitializeComponent();
        tasks = [];

        todoListView.ItemsSource = tasks;
    }

    

    // Button handler
    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        AddTaskToList();
        todoListEntry.Text = string.Empty;
    }

    private void OnRemoveButtonClicked(object sender, EventArgs e)
    {
        RemoveTaskFromList(sender);
    }

    // ListFunctions
    private void AddTaskToList()
    {
        string taskName = todoListEntry.Text;

        if (taskName != null)
        {
            tasks.Add(new Todo { Name = taskName, });

        }

    }

    private void RemoveTaskFromList(object sender)
    {
        var checkBox = (CheckBox)sender;
        if (checkBox.BindingContext is Todo taskToRemove && checkBox.IsChecked)
        {
            tasks.Remove(taskToRemove);
        }
    }
    
}
public class Todo
{
    public required string Name { get; set; }
}