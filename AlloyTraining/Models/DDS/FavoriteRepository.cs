using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Data.Dynamic;

namespace AlloyTraining.Models.DDS
{
    public class FavoriteRepository
    {
        private static DynamicDataStore store
        {
            get
            {
                return DynamicDataStoreFactory.Instance.CreateStore("Favorites", typeof(Favorite));
            }
        }


        public static void Save(Favorite fav)
        {
            if (string.IsNullOrWhiteSpace(fav.UserName))
            {
                throw new NullReferenceException(
                    "Unable to add favorite without user name");
            }
            store.Save(fav);
        }


        public static List<Favorite> GetFavorites(string userName)
        {
            return store.Items<Favorite>()
                .Where(fav => fav.UserName == userName)
                .ToList();
        }

        public static Favorite GetFavorite(
            ContentReference contentReference, string userName)
        {
            return store
                .Items<Favorite>()
                .FirstOrDefault(fav => (fav.UserName == userName) &&
                              (fav.FavoriteContentReference == contentReference));
        }

        public static void Delete(Favorite fav)
        {
            
            store.Delete(fav.Id);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}