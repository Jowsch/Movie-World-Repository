using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class AFilm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsFilm AFilm = new clsFilm();
        AFilm = (clsFilm)Session["AFilm"];
        Response.Write(AFilm.FilmID);
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        clsFilm AFilm = new clsFilm();
        AFilm.FilmName = txtFilmName.Text;
        AFilm.FilmDescription = txtFilmDesc.Text;
        AFilm.FilmDepartureDate = txtDepartureDate.Text;
        AFilm.FilmReleaseDate = txtRelease.Text;
        AFilm.FilmCertificate = txtCert.Text;
    }
}