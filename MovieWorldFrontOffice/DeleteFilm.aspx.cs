using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

public partial class DeleteFilm : System.Web.UI.Page
{
    Int32 FilmId;

    protected void Page_Load(object sender, EventArgs e)
    {
        FilmId = Convert.ToInt32(Session["FilmId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsFilmCollection FilmCollection = new clsFilmCollection();
        FilmCollection.ThisFilm.Find(FilmId);
        FilmCollection.Delete();
        Response.Redirect("FilmList.aspx");
    }
}