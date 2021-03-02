using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.Models
{
    public static class ModelRepository
    {
        public static IEnumerable<Contents> _contents { get; set; }
        static ModelRepository()
        {
            _contents = new List<Contents>()
            {
                new Contents()
                {
                    Id = 1,
                    ContentName = "Shazam",
                    DescriptionLong = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Duis at tellus at urna condimentum. " +
                "Consectetur a erat nam at lectus. Consequat nisl vel pretium lectus quam. " +
                "Cursus turpis massa tincidunt dui. " +
                "Sit amet purus gravida quis blandit turpis cursus in hac. " +
                "At urna condimentum mattis pellentesque id nibh tortor id aliquet. " +
                "Enim facilisis gravida neque convallis a. Sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus. " +
                "Enim neque volutpat ac tincidunt. " +
                "Dui ut ornare lectus sit. At in tellus integer feugiat scelerisque varius morbi enim nunc.</p> " +
                "<p>Pulvinar mattis nunc sed blandit libero. Mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a. " +
                "Eleifend donec pretium vulputate sapien nec sagittis aliquam malesuada. Orci porta non pulvinar neque laoreet suspendisse interdum. " +
                "Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Mollis aliquam ut porttitor leo a diam sollicitudin tempor id. " +
                "Congue quisque egestas diam in arcu cursus euismod." + "Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. " +
                "Dui faucibus in ornare quam viverra orci sagittis. Pharetra magna ac placerat vestibulum lectus. " +
                "Non enim praesent elementum facilisis leo vel fringilla. Egestas sed tempus urna et pharetra pharetra massa. " +
                "Nunc sed velit dignissim sodales. Eros donec ac odio tempor. Tempor commodo ullamcorper a lacus vestibulum sed. " +
                "Facilisis leo vel fringilla est ullamcorper eget nulla. Pharetra magna ac placerat vestibulum lectus mauris ultrices eros in. " +
                "Neque volutpat ac tincidunt vitae semper quis lectus. Orci sagittis eu volutpat odio facilisis mauris sit amet massa.</p>",
                    DescriptionShort = "Shazam",
                    imgUrl = "1.jpg"
                },
                  new Contents()
                {
                    Id = 2,
                    ContentName = "Space",
                    DescriptionLong = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Duis at tellus at urna condimentum. " +
                "Consectetur a erat nam at lectus. Consequat nisl vel pretium lectus quam. " +
                "Cursus turpis massa tincidunt dui. " +
                "Sit amet purus gravida quis blandit turpis cursus in hac. " +
                "At urna condimentum mattis pellentesque id nibh tortor id aliquet. " +
                "Enim facilisis gravida neque convallis a. Sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus. " +
                "Enim neque volutpat ac tincidunt. " +
                "Dui ut ornare lectus sit. At in tellus integer feugiat scelerisque varius morbi enim nunc.</p> " +
                "<p>Pulvinar mattis nunc sed blandit libero. Mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a. " +
                "Eleifend donec pretium vulputate sapien nec sagittis aliquam malesuada. Orci porta non pulvinar neque laoreet suspendisse interdum. " +
                "Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Mollis aliquam ut porttitor leo a diam sollicitudin tempor id. " +
                "Congue quisque egestas diam in arcu cursus euismod." + "Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. " +
                "Dui faucibus in ornare quam viverra orci sagittis. Pharetra magna ac placerat vestibulum lectus. " +
                "Non enim praesent elementum facilisis leo vel fringilla. Egestas sed tempus urna et pharetra pharetra massa. " +
                "Nunc sed velit dignissim sodales. Eros donec ac odio tempor. Tempor commodo ullamcorper a lacus vestibulum sed. " +
                "Facilisis leo vel fringilla est ullamcorper eget nulla. Pharetra magna ac placerat vestibulum lectus mauris ultrices eros in. " +
                "Neque volutpat ac tincidunt vitae semper quis lectus. Orci sagittis eu volutpat odio facilisis mauris sit amet massa.</p>",
                    DescriptionShort = "Space",
                    imgUrl = "1.jpg"
                },
                   new Contents()
                {
                    Id = 1002,
                    ContentName = "Shazam",
                    DescriptionLong = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Duis at tellus at urna condimentum. " +
                "Consectetur a erat nam at lectus. Consequat nisl vel pretium lectus quam. " +
                "Cursus turpis massa tincidunt dui. " +
                "Sit amet purus gravida quis blandit turpis cursus in hac. " +
                "At urna condimentum mattis pellentesque id nibh tortor id aliquet. " +
                "Enim facilisis gravida neque convallis a. Sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus. " +
                "Enim neque volutpat ac tincidunt. " +
                "Dui ut ornare lectus sit. At in tellus integer feugiat scelerisque varius morbi enim nunc.</p> " +
                "<p>Pulvinar mattis nunc sed blandit libero. Mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a. " +
                "Eleifend donec pretium vulputate sapien nec sagittis aliquam malesuada. Orci porta non pulvinar neque laoreet suspendisse interdum. " +
                "Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Mollis aliquam ut porttitor leo a diam sollicitudin tempor id. " +
                "Congue quisque egestas diam in arcu cursus euismod." + "Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. " +
                "Dui faucibus in ornare quam viverra orci sagittis. Pharetra magna ac placerat vestibulum lectus. " +
                "Non enim praesent elementum facilisis leo vel fringilla. Egestas sed tempus urna et pharetra pharetra massa. " +
                "Nunc sed velit dignissim sodales. Eros donec ac odio tempor. Tempor commodo ullamcorper a lacus vestibulum sed. " +
                "Facilisis leo vel fringilla est ullamcorper eget nulla. Pharetra magna ac placerat vestibulum lectus mauris ultrices eros in. " +
                "Neque volutpat ac tincidunt vitae semper quis lectus. Orci sagittis eu volutpat odio facilisis mauris sit amet massa.</p>",
                    DescriptionShort = "Shazam",
                    imgUrl = "1.jpg"
                },
                  new Contents()
                {
                    Id = 1001,
                    ContentName = "Space",
                    DescriptionLong = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Duis at tellus at urna condimentum. " +
                "Consectetur a erat nam at lectus. Consequat nisl vel pretium lectus quam. " +
                "Cursus turpis massa tincidunt dui. " +
                "Sit amet purus gravida quis blandit turpis cursus in hac. " +
                "At urna condimentum mattis pellentesque id nibh tortor id aliquet. " +
                "Enim facilisis gravida neque convallis a. Sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus. " +
                "Enim neque volutpat ac tincidunt. " +
                "Dui ut ornare lectus sit. At in tellus integer feugiat scelerisque varius morbi enim nunc.</p> " +
                "<p>Pulvinar mattis nunc sed blandit libero. Mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a. " +
                "Eleifend donec pretium vulputate sapien nec sagittis aliquam malesuada. Orci porta non pulvinar neque laoreet suspendisse interdum. " +
                "Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Mollis aliquam ut porttitor leo a diam sollicitudin tempor id. " +
                "Congue quisque egestas diam in arcu cursus euismod." + "Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. " +
                "Dui faucibus in ornare quam viverra orci sagittis. Pharetra magna ac placerat vestibulum lectus. " +
                "Non enim praesent elementum facilisis leo vel fringilla. Egestas sed tempus urna et pharetra pharetra massa. " +
                "Nunc sed velit dignissim sodales. Eros donec ac odio tempor. Tempor commodo ullamcorper a lacus vestibulum sed. " +
                "Facilisis leo vel fringilla est ullamcorper eget nulla. Pharetra magna ac placerat vestibulum lectus mauris ultrices eros in. " +
                "Neque volutpat ac tincidunt vitae semper quis lectus. Orci sagittis eu volutpat odio facilisis mauris sit amet massa.</p>",
                    DescriptionShort = "Space",
                    imgUrl = "1.jpg"
                }
            };
        }
    }
}
