
using System;
using System.Collections.Generic;
namespace task4.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<BlogEntity> BlogEnities { get; set;}
        public List<NewsEntity> NewsEnities { get; set;}
    

    
        public MainWindowViewModel()
        {
            BlogEnities = new List<BlogEntity>()
            {
                new BlogEntity() {Article = "Article 1", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eismod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asperatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi temora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", Tags = new List<string>{"tag1","tag2","tag3"},ImagePath = "picture.png"},
                new BlogEntity() {Article = "Article 2", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla libero massa, laoreet ut urna vel, iaculis tempor felis. Curabitur ut erat quis turpis mattis malesuada et vehicula sem. Sed eget purus purus. Vestibulum justo diam, suscipit vel facilisis in, hendrerit in sem. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Suspendisse potenti. Donec massa nulla, aliquam ut erat non, auctor elementum enim.Duis sit amet magna velit. Morbi molestie, elit a vestibulum suscipit, metus lacus ultricies nulla, id aliquet leo velit id neque. Aenean tempus tristique sodales. Aliquam eu pharetra lorem. Maecenas suscipit quam vel elementum euismod. Donec ornare, diam a congue luctus, purus magna dignissim libero, vel tempus sapien nisi ac mauris. Nunc vehicula accumsan ullamcorper. Morbi non ipsum ac massa auctor semper. Maecenas id iaculis orci. Vivamus egestas mollis maximus. Phasellus et leo sed arcu viverra malesuada a quis magna",Tags = new List<string>{"tag4","tag5","tag6"}, ImagePath = "cat.png"}
            };
            NewsEnities = new List<NewsEntity>()
            {
                new NewsEntity() {Text = "New 1 : Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse", PublishDate = DateTime.Now},
                new NewsEntity() {Text = "New 2 : Nullam interdum lacinia elementum. Maecenas placerat, lectus ut vulputate euismod, tortor eros tincidunt felis, ut fringilla odio lacus sit amet ligula. Sed sagittis libero eleifend justo condimentum, sed tempus diam malesuada. Praesent sed diam consectetur, eleifend tortor in, efficitur arcu.", PublishDate = DateTime.Now.AddDays(-3) }
            };
        }
    }
}


