using Noise.Contracts;
using BlazorConfig.Api;
using Microsoft.AspNetCore.Components;

namespace BlazorConfig.Pages
{
    public partial class Index
    {
        [Inject]
        public ApiClient Client { get; set; }

        private IEnumerable<Models> _Models = new List<Models>();

        protected override async Task OnInitializedAsync()
        {
            _Models = await Client.GetModels();
        }
    }
}
