using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FilmList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayFilms();
        }
    }

    void DisplayFilms()
    {
        MovieWorldClasses.clsFilmCollection Films = new MovieWorldClasses.clsFilmCollection();
        lstFilmList.DataSource = Films.FilmList;
        lstFilmList.DataValueField = "FilmId";
        lstFilmList.DataTextField = "FilmName";
        lstFilmList.DataBind();
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        Session["FilmName"] = -1;
        Response.Redirect("AFilm.aspx");
    }
}