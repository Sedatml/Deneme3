using CallCenter.BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter_WEBUI
{
    public partial class Guncelle : System.Web.UI.Page
    {
        MusteriBireyselController mbirc = new MusteriBireyselController();
        BireyUnvanController buc = new BireyUnvanController();
        TelefonController tc = new TelefonController();
        AdresController ac = new AdresController();
        EmailController emc = new EmailController();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                return;
            }
            Getir();
        }


        private void Getir()
        {
            int musteriID = Convert.ToInt32(Request.QueryString["ID"]);
            MusteriBireysel musteriBireyselBilgi = mbirc.Getir(musteriID);

           txtAd.Text= musteriBireyselBilgi.Ad;
           txtTCNO.Text = musteriBireyselBilgi.TC;
           txtSoyad.Text = musteriBireyselBilgi.Soyad;
           txtDogumTarihi.Text = musteriBireyselBilgi.DogumTarihi.ToString();

           BireyselUnvan unvanBilgi = buc.Getir(musteriID);
           ListItem li = new ListItem();
           li.Text = unvanBilgi.Unvan;
           li.Value = unvanBilgi.UnvanID.ToString();
           ddlUnvan.Items.Add(li);
          

           Email mailBilgi = emc.Getir(musteriID);
           txtEmail.Text = mailBilgi.EmailAdres;

           Telefon telefonBilgi = tc.Getir(musteriID);
           txtTelefon.Text = telefonBilgi.Telefon1;

           Adre adresBilgi = ac.Getir(musteriID);
           txtAdres.Text = adresBilgi.Adress;

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Gunclle();
        }

        private void Gunclle()
        {
            int musteriID = Convert.ToInt32(Request.QueryString["ID"]);
            MusteriBireysel musteriGuncelle = new MusteriBireysel();
            musteriGuncelle.Ad = txtAd.Text;
            musteriGuncelle.Soyad = txtSoyad.Text;
            musteriGuncelle.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            musteriGuncelle.TC = txtTCNO.Text;
            musteriGuncelle.MusteriID = musteriID;

            mbirc.Guncelle(musteriGuncelle);

            BireyselUnvan unvanGuncelle = new BireyselUnvan();
           unvanGuncelle.Unvan=ddlUnvan.SelectedItem.ToString();
           unvanGuncelle.UnvanID = musteriID;
            
            buc.Guncelle(unvanGuncelle);

           Email mailBilgi = new Email();
            mailBilgi.EmailAdres= txtEmail.Text ;
            mailBilgi.MusteriID = musteriID;

            emc.Guncelle(mailBilgi);

            Telefon telefonBilgi = new Telefon();
            telefonBilgi.Telefon1 = txtTelefon.Text;
            telefonBilgi.MusteriID = musteriID;

            tc.Guncelle(telefonBilgi);

            Adre adresBilgi = new Adre();
            adresBilgi.Adress = txtAdres.Text;
            adresBilgi.MusteriID = musteriID;

            ac.Guncelle(adresBilgi);
        }
    }
}