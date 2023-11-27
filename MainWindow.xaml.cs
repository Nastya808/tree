using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Task rootTask = new Task
            {
                Name = "Game Development",
                Description = "The turtle game"
            };

            Task firstTask = new Task { Name = "-Create a landscape", Description = "" };
            Task secondTask = new Task { Name = "-Create sky and tree textures", Description = "" };
            Task thirdTask = new Task { Name = "-Create hero icons", Description = "" };

            secondTask.Tasks.Add(new Task { Name = "-- Create a sky" });
            secondTask.Tasks.Add(new Task
            {
                Name = "-- Create tree textures",
                Tasks = new List<Task>
                {
                    new Task { Name = "--- Create root" },
                    new Task { Name = "--- Create trunk" },
                    new Task { Name = "--- Create leaves" }
                }
            });

            rootTask.Tasks.Add(firstTask);
            rootTask.Tasks.Add(secondTask);
            rootTask.Tasks.Add(thirdTask);

            treeViewTask.ItemsSource = new List<Task> { rootTask };
        }
    }

    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }

        public Task()
        {
            Tasks = new List<Task>();
        }
    }
}
