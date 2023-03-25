using Ex.Facade.Application.FacadePattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex.Facade.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFacadeService _facadeService;

        public ValuesController(IFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpGet]
        public void Login()
        {
            _facadeService.LoginUserService.Execute();
        }
        [HttpPost]
        public void Register()
        {
            _facadeService.RegisterUserService.Execute();
        }
    }
}
