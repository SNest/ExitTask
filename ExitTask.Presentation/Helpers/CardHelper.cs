namespace ExitTask.Presentation.Helpers
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Web.Mvc;

    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Areas.Common.Models;

    using Resources;

    public static class CardHelper
    {
        public static MvcHtmlString TourPreviewCard(this HtmlHelper htmlHelper, TourViewModel tourPreview)
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
            link.MergeAttribute("class", "mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect details-link");
            link.MergeAttribute("href", "/Common/Home/TourDetails/" + tourPreview.Id);
            link.SetInnerText(Resource.Details);

            var fire = new TagBuilder("img");
            fire.MergeAttribute("src", "../Views/../Content/Images/fire.ico");
            fire.MergeAttribute("class", "hot-ico");

            if(tourPreview.State == TourDtoState.Hot)
                action.InnerHtml = "<b>" + tourPreview.FinishCity.Name + " | " + tourPreview.BeginDepartureTime.ToLocalTime().ToString("M") + " - " + tourPreview.EndArrivalTime.ToLocalTime().ToString("M") + "</b>" +  link + fire;
            else
                action.InnerHtml = "<b>" + tourPreview.FinishCity.Name + " | " + tourPreview.BeginDepartureTime.ToLocalTime().ToString("M") + " - " + tourPreview.EndArrivalTime.ToLocalTime().ToString("M") + "</b>" + link;
            card.InnerHtml = title.ToString() + description + action;

            return MvcHtmlString.Create(card.ToString());
        }

        public static MvcHtmlString TourCard(this HtmlHelper htmlHelper, TourViewModel tour)
        {
            var card = new TagBuilder("div");
            card.MergeAttribute("class", "demo-card-square-2 mdl-card mdl-shadow--2dp mdl-cell mdl-cell--12-col");

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

            var pFame = new TagBuilder("p");
            pFame.SetInnerText(tour.Name);

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
            pBdTime.SetInnerText(tour.BeginDepartureTime.ToLocalTime().ToString("d"));

            var lBaTime = new TagBuilder("h5");
            lBaTime.SetInnerText(Resource.ArrivalDate);

            var pBaTime = new TagBuilder("p");
            pBaTime.SetInnerText(tour.BeginArrivalTime.ToLocalTime().ToString("d"));

            var lEdTime = new TagBuilder("h5");
            lEdTime.SetInnerText(Resource.DepartureDate);

            var pEdTime = new TagBuilder("p");
            pEdTime.SetInnerText(tour.EndDepartureTime.ToLocalTime().ToString("d"));


            var lEaTime = new TagBuilder("h5");
            lEaTime.SetInnerText(Resource.ArrivalDate);

            var pEaTime = new TagBuilder("p");
            pEaTime.SetInnerText(tour.EndArrivalTime.ToLocalTime().ToString("d"));


            var lPersonNumber = new TagBuilder("h5");
            lPersonNumber.SetInnerText(Resource.PersonNumber);

            var pPersonNumber = new TagBuilder("p");
            pPersonNumber.SetInnerText(tour.PersonNumber.ToString());


            var lFeeding = new TagBuilder("h5");
            lFeeding.SetInnerText(Resource.Feeding);

            var pFeeding = new TagBuilder("p");
            pFeeding.SetInnerText(tour.Feeding.ToString());


            var lState = new TagBuilder("h5");
            lState.SetInnerText(Resource.State);

            var pState = new TagBuilder("p");
            pState.SetInnerText(tour.State.ToString());


            var lPrice = new TagBuilder("h5");
            lPrice.SetInnerText(Resource.Price);

            var pPrice = new TagBuilder("p");
            pPrice.SetInnerText("$" + tour.Price.ToString(CultureInfo.InvariantCulture));


            var lFinishCityName = new TagBuilder("h5");
            lFinishCityName.SetInnerText(Resource.FinishCity);

            var pFinishCityName = new TagBuilder("p");
            pFinishCityName.SetInnerText(tour.FinishCity.Name);


            var lFinishCityDesc = new TagBuilder("h5");
            lFinishCityDesc.SetInnerText(Resource.Description);

            var pFinishCityDesc = new TagBuilder("p");
            pFinishCityDesc.SetInnerText(tour.FinishCity.Description);


            var book = new TagBuilder("a");
            book.MergeAttribute("class", "mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect details-link");
            book.MergeAttribute("href", "/User/Booking/BookTour/" + tour.Id);
            book.SetInnerText(Resource.Book);


            description.InnerHtml = lName.ToString() + pFame + lDescription + pDescription +
                lType + pType + lBdTime + pBdTime + lBaTime + pBaTime + lEdTime + pEdTime +
                lEaTime + pEaTime + lPersonNumber + pPersonNumber + lFeeding + pFeeding +
                lState + pState + lPrice + pPrice + lFinishCityName + pFinishCityName +
                lFinishCityDesc + pFinishCityDesc;

            card.InnerHtml = title.ToString() + description;

            return MvcHtmlString.Create(card.ToString());
        }
    }
}