using System.Collections.ObjectModel;

namespace TaskManagementAppMaui;

public partial class MainPage : ContentPage
{

    // Attributes
    private ObservableCollection<Todo> tasks;

    public MainPage()
    {
        InitializeComponent();
        tasks = new ObservableCollection<Todo>();

        todoListView.ItemsSource = tasks;
    }

    

    // Button handler
    private void onAddButtonClicked(object sender, EventArgs e)
    {
        addTaskToList();
        
    }

    private void onRemoveButtonClicked(object sender, EventArgs e)
    {
        removeTaskFromList(sender);
    }

    // ListFunctions
    private void addTaskToList()
    {
        string taskName = todoListEntry.Text;

        if (taskName != null)
        {
            tasks.Add(new Todo { Name = taskName, });

        }

    }

    private void removeTaskFromList(object sender)
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
    public string Name { get; set; }
}