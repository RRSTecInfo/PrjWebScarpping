using EasyAutomationFramework;
using OpenQA.Selenium;
using PrjWebScrapping.Infra.CrossCutting.Classes;
using PrjWebScrapping.Infra.CrossCutting.Interfaces;

namespace PrjWebScrapping.Infra.CrossCutting.Functions
{
    public class ScrapingFunctions : Web, IScrapingFunctions
    {
        public IList<WebScrapper> GetData(string link)
        {
            if (driver == null)
                StartBrowser();

            var items = new List<WebScrapper>();

            Navigate(link);

            var elements = GetValue(TypeElement.Xpath, "/html/body/div[1]/div[3]/div/div[2]/div")
                               .element.FindElements(By.ClassName("thumbnail"));

            IList<WebScrapper> listWebScrapper = new List<WebScrapper>();

            foreach (var item in elements)
            {
                listWebScrapper.Add(new WebScrapper
                {
                    Id = new Guid,
                    Nome = item.FindElement(By.ClassName("title")).GetAttribute("title"),
                    Descricao = item.FindElement(By.ClassName("description")).Text,
                    Preco = item.FindElement(By.ClassName("price")).Text
                });
            }

            return listWebScrapper; 
        }
    }
}
