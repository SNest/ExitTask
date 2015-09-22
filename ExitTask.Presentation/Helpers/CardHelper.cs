namespace ExitTask.Presentation.Helpers
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Web.Mvc;

    using ExitTask.Presentation.Areas.Common.Models;

    using Resources;

    public static class CardHelper
    {
        public static MvcHtmlString TourPreviewCard(this HtmlHelper htmlHelper, TourPreviewViewModel tourPreview)
        {
            var card = new TagBuilder("div");
            card.MergeAttribute("class", "demo-card-square mdl-card mdl-shadow--2dp mdl-cell mdl-cell--12-col");

            var title = new TagBuilder("div");
            title.MergeAttribute("class", "mdl-card__title mdl-card--expand");

            var url = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(tourPreview.Image));

            title.MergeAttribute(
                "style",
                String.Format("background: url('{0}') center right 15% no-repeat #46B6AC;", url));

            var text = new TagBuilder("h2");
            text.MergeAttribute("class", "mdl-card__title-text");
            text.SetInnerText(tourPreview.Name);

            title.InnerHtml = text.ToString();

            var description = new TagBuilder("div");
            description.MergeAttribute("class", "mdl-card__supporting-text");
            description.SetInnerText(tourPreview.Description);

            var action = new TagBuilder("div");
            action.MergeAttribute("class", "mdl-card__actions mdl-card--border");

            var link = new TagBuilder("a");
            link.MergeAttribute("class", "mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect");
            link.MergeAttribute("href", "/Common/Home/TourDetails/" + tourPreview.Id);
            link.SetInnerText(Resource.Details);

            action.InnerHtml = link.ToString();

            card.InnerHtml = title.ToString() + description + action;

            return MvcHtmlString.Create(card.ToString());
        }

        public static MvcHtmlString TourCard(this HtmlHelper htmlHelper, TourViewModel tour)
        {
            var card = new TagBuilder("div");
            card.MergeAttribute("class", "demo-card-square mdl-card mdl-shadow--4dp mdl-cell mdl-cell--12-col");

            var title = new TagBuilder("div");
            title.MergeAttribute("class", "mdl-card__media mdl-color-text--grey-50");

            var url = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(tour.Image));

            title.MergeAttribute(
                "style",
                String.Format("background: url('{0}') center right 15% no-repeat #46B6AC;", url));

            var text = new TagBuilder("h3");
            text.MergeAttribute("class", "mdl-card__title-text");
            text.SetInnerText(tour.Name);

            title.InnerHtml = text.ToString();

            var description = new TagBuilder("div");
            description.MergeAttribute("class", "mdl-color-text--grey-700 mdl-card__supporting-text");
            description.SetInnerText(tour.Description);

            var lName = new TagBuilder("h5");
            lName.SetInnerText(Resource.Name);

            var pName = new TagBuilder("p");
            pName.SetInnerText(tour.Name);

            var lDescription = new TagBuilder("h5");
            lDescription.SetInnerText(Resource.Description);

            var pDescription = new TagBuilder("p");
            pDescription.SetInnerText(tour.Description);

            var lType = new TagBuilder("h5");
            lType.SetInnerText(Resource.Type);

            var pType = new TagBuilder("p");
            pType.SetInnerText(tour.Type.ToString());

            var lBdTime = new TagBuilder("h5");
            lBdTime.SetInnerText(Resource.DepartureDate);

            var pBdTime = new TagBuilder("p");
            pBdTime.SetInnerText(tour.BeginDepartureTime.ToLocalTime().ToString(CultureInfo.InvariantCulture));

            var lBaTime = new TagBuilder("h5");
            lBaTime.SetInnerText(Resource.ArrivalDate);

            var pBaTime = new TagBuilder("p");
            pBaTime.SetInnerText(tour.BeginArrivalTime.ToLocalTime().ToString(CultureInfo.InvariantCulture));

            var lEdTime = new TagBuilder("h5");
            lEdTime.SetInnerText(Resource.DepartureDate);

            var pEdTime = new TagBuilder("p");
            pEdTime.SetInnerText(tour.EndDepartureTime.ToLocalTime().ToString(CultureInfo.InvariantCulture));

            description.InnerHtml = lName.ToString() + pName + lDescription + pDescription + lType + pType + lBdTime + pBdTime + lBaTime + pBaTime;

            card.InnerHtml = title.ToString() + description;

            return MvcHtmlString.Create(card.ToString());
        }
    }
}