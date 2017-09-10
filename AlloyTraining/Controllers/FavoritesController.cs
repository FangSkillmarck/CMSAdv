using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.DDS;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer.Core;
using EPiServer.Security;
using EPiServer.Web.Routing;

namespace AlloyTraining.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly UrlResolver _urlResolver;

        public FavoritesController(UrlResolver urlResolver)
        {
            this._urlResolver = urlResolver;
        }
        // GET: Favorite
        public ActionResult Manager(SitePageData currentPage)
        {
            var model = new FavoriteViewModel
            {
                Favorites = FavoriteRepository
                    .GetFavorites(PrincipalInfo.Current.Name),
                CurrentPageContentReference = currentPage.ContentLink
            };



            return PartialView("FavoritesManager", model);
        }

        public void Add(ContentReference page)
        {
            var favorite = FavoriteRepository.GetFavorite(
                page, PrincipalInfo.Current.Name);

            if (favorite == null)
            {
                var newFavorite = new Favorite(page, PrincipalInfo.Current.Name);
                FavoriteRepository.Save(newFavorite);
            }

            Response.Redirect(_urlResolver.GetUrl(page));
        }

        public void Delete(ContentReference page, ContentReference fav)
        {
            var favorite = FavoriteRepository.GetFavorite(
                fav, PrincipalInfo.Current.Name);

            if (favorite != null)
            {
                FavoriteRepository.Delete(favorite);
            }

            Response.Redirect(_urlResolver.GetUrl(page));
        }
    }


}