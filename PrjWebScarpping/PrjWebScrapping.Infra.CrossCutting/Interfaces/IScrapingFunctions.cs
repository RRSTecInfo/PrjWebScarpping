using PrjWebScrapping.Infra.CrossCutting.Classes;

namespace PrjWebScrapping.Infra.CrossCutting.Interfaces
{
    public interface IScrapingFunctions
    {
        public IList<WebScrapper> GetData(string link);
    }
}
