namespace ClassesTask.Classes;

internal class Film
{
    public string Id { get; private set; }=Guid.NewGuid().ToString();
    public string Name { get; set; }
    public double ImdPoint { get; set; }
    public string Subtitle { get; set; }
}
