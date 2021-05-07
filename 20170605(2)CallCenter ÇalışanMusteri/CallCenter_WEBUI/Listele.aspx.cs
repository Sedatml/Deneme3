using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CallCenter.BLL;

namespace CallCenter_WEBUI
{
    public partial class Listele : System.Web.UI.Page
    {
        MusteriTuruController mtrc = new MusteriTuruController();
        MusteriBireyselController mbc = new MusteriBireyselController();
        MusteriFirmaController mfc = new MusteriFirmaController();  


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate( /*Control Validation Group Name Optional*/ );
                if (Page.IsValid)
                {
                    return;
                }
            }

           
            TipDoldur();
           
        }

        private void TipDoldur()
        {
           ddlTip.DataSource= mtrc.Getir();
           ddlTip.DataTextField = "TipAdi";
           ddlTip.DataValueField = "TipID";
           ddlTip.DataBind();
           ddlTip.Items.Insert(0,new ListItem("Seçiniz","0"));
        }

        protected void ddlTip_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (ddlTip.SelectedIndex==1)
            {
                grvListele.DataSource = mfc.Getir();
                grvListele.DataBind();
            }

            if (ddlTip.SelectedIndex == 2)
            {
                grvListele.DataSource = mbc.Getir();
                grvListele.DataBind();
              
            }
        }

        protected void grvListele_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (ddlTip.SelectedIndex==2)
            {
                string ıd = e.CommandArgument.ToString();
                Response.Redirect("Guncelle.aspx?ID=" + ıd);
            }
            if (ddlTip.SelectedIndex==1)
            {
                string ıd = e.CommandArgument.ToString();
                Response.Redirect("FirmaGuncelle.aspx?ID=" + ıd);
            }
         

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?");
        }

    
    }
}