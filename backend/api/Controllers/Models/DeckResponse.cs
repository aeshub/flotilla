using Api.Database.Models;
namespace Api.Controllers.Models
{
    public class DeckResponse
    {

        public DeckResponse(Deck deck)
        {
            Id = deck.Id;
            DeckName = deck.Name;
            PlantCode = deck.Plant.PlantCode;
            InstallationCode = deck.Installation.InstallationCode;
            DefaultLocalizationAreaId = deck.DefaultLocalizationArea!.Id;
        }
        public string Id { get; set; }

        public string DeckName { get; set; }

        public string PlantCode { get; set; }

        public string InstallationCode { get; set; }

        public string DefaultLocalizationAreaId { get; set; }
    }
}
