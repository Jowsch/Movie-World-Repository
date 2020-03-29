using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class FilmViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsFilm AFilm = new clsFilm();
        AFilm = (clsFilm)Session["AFilm"];
        Response.Write(AFilm.FilmDescription + "<br>");
        Response.Write(AFilm.FilmCertificate + "<br>");
        Response.Write(AFilm.FilmReleaseDate + "<br>");
        Response.Write(AFilm.FilmDepartureDate + "<br>");
        Response.Write(AFilm.FilmShowing);
    }
}