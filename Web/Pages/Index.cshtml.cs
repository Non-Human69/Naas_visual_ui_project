using Core_.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly INaasRepository _naasRepository;
        private readonly IHistoryService _historiesService;
        public INaasRepository NaasRepository => _naasRepository;
        public IHistoryService HistoryService => _historiesService;

        public IndexModel(ILogger<IndexModel> logger, INaasRepository naasRepository, IHistoryService historiesService)
        {
            _logger = logger;
            _naasRepository = naasRepository;
            _historiesService = historiesService;
            naasText = _naasRepository.GetNaasData();
            history = _historiesService.GetHistory();
        }
        public void OnGet()
        {
            _historiesService.AddEntry(naasText ?? "No Data");
            RefreshNaasData();
        }

        public void RefreshNaasData()
        {
            _naasRepository.UpdateNaasData();
            naasText = _naasRepository.GetNaasData();
        }

        [BindProperty]
        public string? naasText { get; set; }

        [BindProperty]
        public IEnumerable<string> history { get; set; }
    }
}
