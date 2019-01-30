using System;
using System.Web.Mvc;
using Umbraco.Core;

namespace Football_League_Site.Controllers
{
    public class PostNodesController : Controller
    {
        [HttpGet]
        [ActionName("createTestNode")]
        public bool createNewNode()
        {
            var contentService = ApplicationContext.Current.Services.ContentService;
            var publishDate = DateTime.Now;
            var content = contentService.CreateContent("test13", 1006, "Conent Page");
            content.ReleaseDate = publishDate;
            content.UpdateDate = publishDate;
            content.CreateDate = publishDate;

            content.SetValue("pageTitle", "test13");
            //content.SetValue("Name", "test13");

            var result = contentService.SaveAndPublishWithStatus(content);

            return result;
        }

        [HttpGet]
        [ActionName("testController")]
        public void testController()
        {

        }
    }
}