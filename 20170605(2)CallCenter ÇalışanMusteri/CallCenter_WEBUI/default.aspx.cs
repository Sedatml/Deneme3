using CallCenter.BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter_WEBUI
{
    public partial class _default : System.Web.UI.Page
    {
        MusteriBireyselController mbirc = new MusteriBireyselController();
        BireyUnvanController buc = new BireyUnvanController();
        TelefonController tc = new TelefonController();
        AdresController ac = new AdresController();
        EmailController emc = new EmailController();
        MusteriController mc = new MusteriController();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                return;
            }

            UnvanGetir();
        }
       

        private void UnvanGetir()
        {

            ddlUnvan.DataSource = buc.Getir();
            ddlUnvan.DataTextField = "Unvan";
            ddlUnvan.DataValueField = "UnvanID";
            ddlUnvan.DataBind();
           
        }

        private void MusteriEkle()
        {
            //Musteri ID = new Musteri();
            //ID.
            MusteriBireysel musteribirey2 = new MusteriBireysel();
            musteribirey2.Ad = txtAd.Text;
            musteribirey2.Soyad = txtSoyad.Text;
            musteribirey2.TC = txtTCNO.Text;
            musteribirey2.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);

            //Yrni üretilecek olan MusteriID belirler.
            Musteri musteri = new Musteri();
            //musteri=mc.Getir();
          

            musteribirey2.MusteriID = musteri.MusteriID;

            mbirc.Ekle(musteribirey2);

            Telefon telefon = new Telefon();
            telefon.Telefon1 = txtTelefon.Text;

            tc.Ekle(telefon);

            BireyselUnvan unvan = new BireyselUnvan();
            unvan.Unvan = ddlUnvan.SelectedItem.ToString();










        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriEkle();
        }
    }
}