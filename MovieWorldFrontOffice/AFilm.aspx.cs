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
        //clsFilm AFilm = new clsFilm();
        //AFilm = (clsFilm)Session["AFilm"];
        //Response.Write(AFilm.FilmID);
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        clsFilm AFilm = new clsFilm();

        string FilmName = txtFilmName.Text;
        string FilmDescription = txtFilmDesc.Text;
        string FilmCertificate = txtCert.Text;
        string FilmReleaseDate = txtRelease.Text;
        string FilmDepartureDate = txtDeparture.Text;
        Boolean FilmShowing = showingCheck.Checked;
        string Error = "";

        Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
        if (Error == "")
        {
            AFilm.FilmName = FilmName;
            AFilm.FilmDescription = FilmDescription;
            AFilm.FilmCertificate = FilmCertificate;
            AFilm.FilmReleaseDate = Convert.ToDateTime(FilmReleaseDate);
            AFilm.FilmDepartureDate = Convert.ToDateTime(FilmDepartureDate);
            Session["AFilm"] = AFilm;
            Response.Write("FilmViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    //find button
    //add validation to ensure a) if you enter a primary key value for a record that doesn’t exist an error msg appears.
    //b) if you type a text value for the primary key it doesnt let you.
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsFilm AFilm = new clsFilm();
        Int32 FilmId;
        Boolean Found = false;
        FilmId = Convert.ToInt32(txtFilmId.Text);
        Found = AFilm.Find(FilmId);

        if (Found == true)
        {
            //display the values of the properties in the form.
            txtFilmName.Text = AFilm.FilmName;
            txtFilmDesc.Text = AFilm.FilmDescription;
            txtCert.Text = AFilm.FilmCertificate;
            txtRelease.Text = AFilm.FilmReleaseDate.ToString();
            txtDeparture.Text = AFilm.FilmDepartureDate.ToString();
        }
    }
}