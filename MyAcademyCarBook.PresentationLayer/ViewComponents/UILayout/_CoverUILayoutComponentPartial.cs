using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.UILayout
{
    public class _CoverUILayoutComponentPartial : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
