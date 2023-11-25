

namespace GameZone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService _gameService;

        public HomeController(ILogger<HomeController> logger , IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            var games = _gameService.GetAll();

            return View(games);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}