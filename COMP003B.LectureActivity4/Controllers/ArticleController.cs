using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity4.Models;

namespace COMP003B.LectureActivity4.Models.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>()
            {
                new Article {Id = 1, Title = "Intro to Razor", Summary = "Learn the basics of Razor syntax"},
                new Article {Id = 2, Title = "Layout and partials", Summary = "Understand Razor layout and reuseable views"},
            };
            return View(articles);

        }
        public IActionResult Details (int id)
        {
            var article = new Article { Id = id, Title = $"Article {id}", Summary = "Detailed content coming soon" };
            return View(article);
        }
    }
}
