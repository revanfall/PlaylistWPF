using AngleSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlaylistWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (linkField != null)
            {
                var config = Configuration.Default.WithDefaultLoader();

                var document = await BrowsingContext.New(config).OpenAsync(linkField.Text);
                var rows = document.QuerySelectorAll("tr.song");
                var songInfo = rows.Select(row => new SongInfo()
                {

                    Song= row.QuerySelector("td:nth-child(2)")?.TextContent.Trim(),
                    Album = row.QuerySelector("td:nth-child(4)")?.TextContent.Trim(),
                    Artist = row.QuerySelector("td:nth-child(3)")?.TextContent.Trim()

                });
                List<SongInfo> songs = songInfo.ToList();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Artist-{song.Artist} Album-{song.Album} Song-{song.Song}");
                }
                string[] arr = new string[4];

                var gridView = new GridView();
                songView.View = gridView;
                gridView.Columns.Add(new GridViewColumn { Header = "Artist", DisplayMemberBinding = new Binding("Artist") });
                gridView.Columns.Add(new GridViewColumn { Header = "Song", DisplayMemberBinding = new Binding("Song") });
                gridView.Columns.Add(new GridViewColumn { Header = "Album", DisplayMemberBinding = new Binding("Album") });
                    foreach (var song in songs)
                {
                    songView.Items.Add(new SongInfo { Artist = song.Artist, Song = song.Song, Album = song.Album });
                    
                }

            }
            }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            songView.Items.Clear();
          
        }
    }
    }


