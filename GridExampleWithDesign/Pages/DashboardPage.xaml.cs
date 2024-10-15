
using GridExampleWithDesign.Models;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace GridExampleWithDesign.Pages;

public partial class DashboardPage : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; } 
	public DashboardPage()
	{
		
		InitializeComponent();
		LoadData();
        BindingContext = this;
	}

	private void LoadData()
	{
		Profiles = new ObservableCollection<Profile>
		{
			new Profile
			{
				Name = "Imran Khan",
				ProfileImage="im1.jpg",
				NoPhotos=12

			},
            new Profile
            {
                Name = "Rizwan Khan",
                ProfileImage="im2.jpg",
                NoPhotos=2

            },
            new Profile
            {
                Name = "Rehan Khan",
                ProfileImage="im3.jpg",
                NoPhotos=8

            },
            new Profile
            {
                Name = "Irfan",
                ProfileImage="im4.jpg",
                NoPhotos=5

            },
            new Profile
            {
                Name = "Adil Khan",
                ProfileImage="im5.jpg",
                NoPhotos=9

            },
        };
        GeneratedImages = new ObservableCollection<GeneratedImage> 
        { 
            new GeneratedImage
            {
                ImagePath="download5.jpg",
                MainKeyword="Castle",
                Keywords= new List<string>{"Epic, hill, mountain, trees, blue sky" }
            },
            new GeneratedImage
            {
                ImagePath="download1.jpg",
                MainKeyword="Mountains",
                Keywords= new List<string>{"Epic, hill, mountain, trees, blue sky" }
            },
            new GeneratedImage
            {
                ImagePath="download2.jpg",
                MainKeyword="Trees",
                Keywords= new List<string>{"Epic, hill, mountain, trees, blue sky" }
            },
            new GeneratedImage
            {
                ImagePath="download3.jpg",
                MainKeyword="Blu Sky",
                Keywords= new List<string>{"Epic, hill, mountain, trees, blue sky" }
            },
            new GeneratedImage
            {
                ImagePath="download4.jpg",
                MainKeyword="Hill",
                Keywords= new List<string>{"Epic, hill, mountain, trees, blue sky" }
            },



        };
	}
}