using ClassesTask.Classes;
using ClassesTask.Managers;



Console.OutputEncoding = System.Text.Encoding.UTF8;
//Film[] film = [new Movie { Name = "Inception", Director = "Nolan", ImdPoint = 9.1 }];
MovieManager movieManager = new MovieManager(
    new Movie { Name = "Inception", Director = "Nolan", ImdPoint = 9.1 }
    );


movieManager.Watching();