using System;
using System.Collections.Generic;
using EPiServer.Framework.Localization;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Framework.Localization;

namespace AlloyTraining.Business.Selectors
{
    public class EnumSelectionFactory<TEnum> : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(
            ExtendedMetadata metadata)
        {
            var values = Enum.GetValues(typeof(TEnum));
            foreach (var value in values)
            {
                yield return new SelectItem
                {
                    //       Text = Enum.GetName(typeof(TEnum), value),
                    Text = GetLocalizeName(value),
                    Value = value
                };
            }
        }

        //to get the localize
        private string GetLocalizeName(object value)
        {
            var staticName = Enum.GetName(typeof(TEnum), value);

            string localizationPath = string.Format(
                "/enum/{0}/{1}",
                typeof(TEnum).Name.ToLowerInvariant(),
                staticName.ToLowerInvariant());

            string localizedName;
            if (LocalizationService.Current.TryGetString(localizationPath, out localizedName))
            {
                return localizedName;
            }

            return staticName;
        }

        // this method exists so that we can localize the string values
        //private string GetValueName(object value)
        //{
        //    var staticName = Enum.GetName(typeof(TEnum), value);

        //    string localizationPath = string.Format(
        //        "/property/enum/{0}/{1}",
        //        typeof(TEnum).Name.ToLowerInvariant(),
        //        staticName.ToLowerInvariant());

        //    string localizedName;
        //    if (LocalizationService.Current.TryGetString(
        //        localizationPath,
        //        out localizedName))
        //    {
        //        return localizedName;
        //    }

        //    return staticName;
        //}
    }
}