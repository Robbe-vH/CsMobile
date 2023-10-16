using BindingExamples.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BindingExamples;

public partial class MainPage : ContentPage
{
    private ObservableCollection<Actor> _actorlist;

    public ObservableCollection<Actor> ActorList
    {
        get => _actorlist;
        set { _actorlist = value; }
    }

    public ICommand AddActor { get; private set; }

    private Actor seanC;
    private Actor meganF;

    public MainPage()
    {
        InitializeComponent();

        seanC = new Actor();
        seanC.Name = "Connery";
        seanC.FirstName = "Sean";
        seanC.ProfilePicture = "https://hips.hearstapps.com/hmg-prod/images/gettyimages-74434773.jpg";
        seanC.Birthyear = 1930;

        meganF = new Actor();
        meganF.Name = "Foxx";
        meganF.FirstName = "Megan";
        meganF.ProfilePicture = "https://phantom-marca.unidadeditorial.es/4784ceafff18e09cb6de529e1b451f6f/crop/0x0/827x551/resize/828/f/jpg/assets/multimedia/imagenes/2023/09/05/16939432465871.jpg";
        meganF.Birthyear = 1983;

        _actorlist = new ObservableCollection<Actor>();
        _actorlist.Add(seanC);
        _actorlist.Add(meganF);

        AddActor = new Command(AddActorToList);

        this.BindingContext = this;
    }

    private void AddActorToList()
    {
        Actor jamie = new Actor()
        {
            Name = "Foxx",
            FirstName = "Jamie",
            ProfilePicture = "https://cdn.britannica.com/68/136168-050-BA0F65B3/Jamie-Foxx-2009.jpg",
            Birthyear = 1967
        };

        ActorList.Add(jamie);

        ActorList[0].Birthyear += 1;
    }

    private void DeleteAnActorButton(object sender, EventArgs e)
    {
        Button deletebtn = sender as Button;
        Actor actorToDelete = deletebtn.CommandParameter as Actor;

        if (actorToDelete != null)
        {
            _actorlist.Remove(actorToDelete);
        }
    }
}