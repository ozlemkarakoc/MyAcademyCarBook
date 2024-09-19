﻿using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ServiceComponenets
{
    public class _HowItWorksStepComponentPartial : ViewComponent
    {
        private readonly IHowItWorksStepService _howItWorksStepService;

        public _HowItWorksStepComponentPartial(IHowItWorksStepService howItWorksStepService)
        {
            _howItWorksStepService = howItWorksStepService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _howItWorksStepService.TGetListAll();
            return View(values);
        }
    }
}
