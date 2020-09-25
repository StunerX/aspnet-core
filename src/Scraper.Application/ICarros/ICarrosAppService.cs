using Microsoft.AspNetCore.Hosting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Scraper.CarAdvertisements;
using Scraper.CarAdvertisements.Dtos;
using Scraper.CarAdvertisements.Interfaces;
using Scraper.ICarros.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scraper.ICarros
{
    public class ICarrosAppService : IICarrosAppService
    {
        private readonly ICarAdvertisementAppService _carAdvertisementAppService;
        public ICarrosAppService(ICarAdvertisementAppService carAdvertisementAppService)
        {
            _carAdvertisementAppService = carAdvertisementAppService;
        }

        public async Task<Guid> Search()
        {
            Guid reference = Guid.NewGuid();

            ChromeOptions options = new ChromeOptions();
            ChromeDriver driver = new ChromeDriver("C:\\playground\\Scraper\\5.7.0\\aspnet-core\\src\\Scraper.Application\\bin\\Debug\\netcoreapp3.1", options);

            driver.Navigate().GoToUrl(AppConsts.ICarrosPage);

            var links = driver.FindElementsByCssSelector(".dados_veiculo a")
                .Select(x => x.GetAttribute("href"))
                .ToList();
            try
            {
                foreach (var link in links)
                {
                    var carAd = await _carAdvertisementAppService.GetByLink(link);
                    if(carAd != null)
                    {
                        continue;
                    }

                    driver.Navigate().GoToUrl(link);

                    var anuncio_id = ((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementsByName('anuncio_id')[0].value").ToString();
                    var anunciante_id = ((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementsByName('anunciante_id')[0].value").ToString();
                    var anunciante_tipo = ((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementsByName('anunciante_tipo')[0].value").ToString();

                    var title = driver.FindElementByClassName("titulo-sm").Text?.Trim();
                    var priceEl = driver.FindElementByClassName("preco").Text?.Trim();
                    decimal price = Convert.ToDecimal(Regex.Match(priceEl.Replace(".", "").Replace(",", "."), @"\d+.+\d").Value);

                    var informacoes = driver.FindElementsByCssSelector(".card-informacoes-basicas li span").Select(x => x.Text);

                    var endereco = ((IJavaScriptExecutor)driver).ExecuteScript("return $('.endereco').text().trim()").ToString();  //driver.FindElementByClassName("endereco").Text?.Trim();
                    var bairro = ((IJavaScriptExecutor)driver).ExecuteScript("return $('.bairro').text().trim()").ToString();  //driver.FindElementByClassName("bairro").Text?.Trim();
                    var cidade = ((IJavaScriptExecutor)driver).ExecuteScript("return $('.cidade').text().trim()").ToString();  //driver.FindElementByClassName("cidade").Text?.Trim();
                    var telefone = ((IJavaScriptExecutor)driver).ExecuteScript("return $('.telefone').text().trim()").ToString();  //driver.FindElementByClassName("telefone").Text?.Trim();

                    var authorName = ((IJavaScriptExecutor)driver).ExecuteScript("return $('.dados-anunciante h4').text().trim()").ToString();

                    var phone = ((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementsByClassName('telefone')[0].textContent.split('Telefone: ').pop()").ToString();


                    decimal km = -1;
                    decimal.TryParse(informacoes.ElementAt(1).Replace(".", "").Replace(",", "."), out km);

                    var carAdvertisement = new CarAdvertisement()
                    {
                        ExternalId = anuncio_id,
                        Link = link,
                        Title = title,
                        Price = price,
                        Year = ElementAt(informacoes, 0),
                        KM = km,
                        Color = ElementAt(informacoes, 2),
                        Gear = ElementAt(informacoes, 3),
                        Door = Convert.ToInt16(string.IsNullOrEmpty(ElementAt(informacoes, 4)) ? "-1" : ElementAt(informacoes, 4)),
                        AuthorId = anunciante_id,
                        Name = authorName,
                        AuthorType = anunciante_tipo,
                        Address = endereco,
                        District = bairro,
                        City = cidade,
                        Phones = phone

                    };

                    await _carAdvertisementAppService.Insert(carAdvertisement);

                }

                return reference;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                driver.Close();
                driver.Quit();
            }

            throw new System.NotImplementedException();
        }

        private string ElementAt(IEnumerable<string> list, int index)
        {
            try
            {
                return list.ElementAt(index);
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }
    }
}
