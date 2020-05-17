using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieWorldClasses;

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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 FilmId;

        if(lstFilmList.SelectedIndex != -1)
        {
            FilmId = Convert.ToInt32(lstFilmList.SelectedValue);
            Session["FilmId"] = FilmId;
            Response.Redirect("DeleteAddress.aspx");
        }
        else
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 FilmId;
        if (lstFilmList.SelectedIndex != -1)
        {
            FilmId = Convert.ToInt32(lstFilmList.SelectedIndex);
            Session["FilmId"] = FilmId;
            Response.Redirect("AFilm.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsFilmCollection Films = new clsFilmCollection();
        Films.ReportByFilmName(txtFilmNameFilter.Text);
        lstFilmList.DataSource = Films.FilmList;
        lstFilmList.DataValueField = "FilmId";
        lstFilmList.DataTextField = "FilmName";
        lstFilmList.DataBind();
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsFilmCollection Films = new clsFilmCollection();
        Films.ReportByFilmName("");
        txtFilmNameFilter.Text = "";
        lstFilmList.DataValueField = "FilmId";
        lstFilmList.DataTextField = "FilmName";
        lstFilmList.DataBind();
    }
}