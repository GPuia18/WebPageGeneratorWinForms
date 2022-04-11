using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeneratorAtestat
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Home;
            StreamWriter Pagina1;
            StreamWriter Pagina2;
            StreamWriter Pagina3;
            StreamWriter Contact;
            string titlu=TitluTB.Text;
            string titlubuton1=Buton1TB.Text;
            string titlubuton2=Buton2TB.Text;
            string titlubuton3=Buton3TB.Text;
            string paleta=CuloriCB.Text;
            string culoare_pagina,culoare_nav,culoare_text_nav,culoare_despartire;
            string meniu=TipMeniuCB.Text;
            string tip_meniu;
            string pozitie_meniu = PozitieMeniuCB.Text;
            string pozitietexttitlu=PozTextTitluCB.Text;
            decimal nrbutoane=NumarPagini.Value;
            string Tip = TipSiteCB.Text;
            string logo=LogoTB.Text;
            string pozadescriere=PozaDTB.Text;
            string descriere = DescriereTB.Text;
            string descriere1=Descriere1TB.Text;
            string descriere2=Descriere2TB.Text;
            string descriere3=Descriere3TB.Text;
            string cartonas = TipCartonas.Text;
            string cartonas_gradient;
            string titlu1=Titlu1TB.Text;
            string titlu2=Titlu2TB.Text;
            string titlu3=Titlu3TB.Text;
            string poza1=Poza1TB.Text;
            string poza2=Poza2TB.Text;
            string poza3=Poza3TB.Text;
            string text1=Text1TB.Text;
            string text2=Text2TB.Text;
            string text3=Text3TB.Text;
            string nume=NumeTB.Text, prenume=PrenumeTB.Text, adresa=AdresaTB.Text, numar=NumarTB.Text, mail=MailTB.Text, telefon=TelefonTB.Text;
            Home = File.CreateText("Home.html");
            if(paleta=="Rosu")
            {
                culoare_pagina = "rgba(255,0,0,.3)";
                culoare_nav = "white";
                culoare_despartire = "white";
            }
            else if(paleta=="Galben")
            {
                culoare_pagina = "rgba(255,255,0,.3)";
                culoare_nav = "rgba(0,0,0,.8)";
                culoare_despartire = "rgba(0,0,0,.8)";
            }
            else if(paleta=="Albastru")
            {
                culoare_pagina = "rgba(0,0,255,.3)";
                culoare_nav = "white";
                culoare_despartire = "white";
            }
            else if(paleta=="Verde")
            {
                culoare_pagina = "rgba(0,255,0,.3)";
                culoare_nav = "white";
                culoare_despartire = "rgba(0,0,0,.8)";
            }
            else
            {
                culoare_pagina = "rgba(255,0,255,.3)";
                culoare_nav = "white";
                culoare_despartire = "white";
            }
            if (culoare_nav == "white")
            {
                culoare_text_nav = "black";
            }
            else culoare_text_nav = "white";
            if (meniu == "Top")
            {
                tip_meniu = "relative";
            }
            else tip_meniu = "fixed";
            if(cartonas=="model1")
            {
                cartonas_gradient = "background-image: radial-gradient(rgba(255,255,255,.7),rgba(0,0,0,0)); border-color: "+ culoare_despartire +";";
            }
            else if(cartonas=="model2")
            {
                cartonas_gradient = "background-image: linear-gradient(45deg, " + culoare_pagina + ",rgba(255,255,255,.3)); border-color: " + culoare_despartire + ";";
            }
            else
            {
                cartonas_gradient = "background-image: linear-gradient(115deg, "+ culoare_pagina +",rgba(255,255,255,.3));border-color: "+ culoare_despartire +";";
            }
            if(Tip=="2")
            {
                Home.WriteLine("<!DOCTYPE html>");
                Home.WriteLine("<html lang=\"en\">");
                Home.WriteLine("<head>");
                Home.WriteLine("<meta charset=\"UTF-8\">");
                Home.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                Home.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                Home.WriteLine("<title>"+ titlu +"</title>");
                Home.WriteLine("<link href=\"StyleAtestat1.css\" rel=\"stylesheet\" type=\"text/css\">");
                Home.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                Home.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                Home.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                Home.WriteLine("</head>");
                Home.WriteLine("<body style=\"background-color: "+ culoare_pagina +";\">");
                Home.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, "+ culoare_pagina +",rgba(0,0,0,.0)); border-color: "+ culoare_despartire +";\">");
                Home.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: \"relative;\">");
                if (pozitie_meniu == "Stanga")
                {
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Home.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Home.WriteLine("</div></a>");
                    Home.WriteLine("<div class=\"links\">");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal i = 1; i <= nrbutoane; i++)
                    {
                        if (i == 1) Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (i == 2) Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (i == 3) Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Home.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Home.WriteLine("</div>");
                }
                else
                {
                    Home.WriteLine("<div class=\"links\">");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal i = 1; i <= nrbutoane; i++)
                    {
                        if (i == 1) Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (i == 2) Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (i == 3) Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Home.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Home.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Home.WriteLine("</div></a>");
                }
                Home.WriteLine("</nav>");
                Home.WriteLine("<div class=\"box-titlu\">");
                Home.WriteLine("<h1>"+ titlu +"</h1>");
                Home.WriteLine("</div>");
                Home.WriteLine("<div class=\"box-prezentare-poza\" style=\"border-color: "+ culoare_despartire +";\">");
                if (pozitietexttitlu == "Stanga")
                {
                    Home.WriteLine("<div class=\"box-prezentare\">");
                    Home.WriteLine("<h4 style=\"padding: 20px;\">" + descriere + "</h4>");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<div class=\"box-poza\">");
                    Home.WriteLine("<img src=\"" + pozadescriere + "\" alt=\"PozaSectiune1\" style=\"border-color: " + culoare_despartire + ";\">");
                    Home.WriteLine("</div>");
                }
                else
                {
                    Home.WriteLine("<div class=\"box-poza\">");
                    Home.WriteLine("<img src=\"" + pozadescriere + "\" alt=\"PozaSectiune1\" style=\"border-color: " + culoare_despartire + ";\">");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<div class=\"box-prezentare\">");
                    Home.WriteLine("<h4 style=\"padding: 20px;\">" + descriere + "</h4>");
                    Home.WriteLine("</div>");
                
                }
                Home.WriteLine("</div>");
                Home.WriteLine("</div>");
                Home.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                for (decimal i = 1; i <= nrbutoane; i++)
                {
                    if(i==1)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton1 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere1 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                    else if(i==2)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton2 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere2 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                    else if(i==3)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton3 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere3 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                }
                Home.WriteLine("</div>");
                Home.WriteLine("</body>");
                Home.WriteLine("</html>");
                Home.Close();
                for(decimal i = 1;i <= nrbutoane; i++)
                {
                    if(i==1)
                    {
                        Pagina1 = File.CreateText(titlubuton1 + ".html");
                        Pagina1.WriteLine("<!DOCTYPE html>");
                        Pagina1.WriteLine("<html lang=\"en\">");
                        Pagina1.WriteLine("<head>");
                        Pagina1.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina1.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina1.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                        Pagina1.WriteLine("<title>" + titlu1 + "</title>");
                        Pagina1.WriteLine("<link href=\"StyleAtestat1.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina1.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina1.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina1.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina1.WriteLine("</head>");
                        Pagina1.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina1.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                        Pagina1.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: relative;\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina1.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina1.WriteLine("</div></a>");
                            Pagina1.WriteLine("<div class=\"links\">");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina1.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina1.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina1.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina1.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina1.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina1.WriteLine("<div class=\"links\">");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina1.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina1.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina1.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina1.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina1.WriteLine("</div>");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina1.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina1.WriteLine("</div></a>");
                        }
                        Pagina1.WriteLine("</nav>");
                        Pagina1.WriteLine("<div class=\"box-titlu\">");
                        Pagina1.WriteLine("<h1>" + titlu1 + "</h1>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("<div class=\"box-prezentare-poza\" style=\"padding-bottom: 0px; border-color: " + culoare_despartire + ";\">");
                        Pagina1.WriteLine("<div class=\"box-poza\">");
                        Pagina1.WriteLine("<img src=\"" + poza1 + "\" alt=\"Poza Sectiune1\" style=\"border-color: "+ culoare_despartire +";\">");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));border-top: 0px; padding-top: 20px; border-color: " + culoare_despartire + ";\">");
                        Pagina1.WriteLine("<p class=\"text-sectiune\">"+ text1 +"</p>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("</body>");
                        Pagina1.WriteLine("</html>");
                        Pagina1.Close();
                    }  
                    else if(i==2)
                    {
                        Pagina2 = File.CreateText(titlubuton2 + ".html");
                        Pagina2.WriteLine("<!DOCTYPE html>");
                        Pagina2.WriteLine("<html lang=\"en\">");
                        Pagina2.WriteLine("<head>");
                        Pagina2.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina2.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina2.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                        Pagina2.WriteLine("<title>" + titlu2 + "</title>");
                        Pagina2.WriteLine("<link href=\"StyleAtestat1.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina2.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina2.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina2.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina2.WriteLine("</head>");
                        Pagina2.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina2.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                        Pagina2.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: relative;\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina2.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina2.WriteLine("</div></a>");
                            Pagina2.WriteLine("<div class=\"links\">");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina2.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina2.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina2.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina2.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina2.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina2.WriteLine("<div class=\"links\">");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina2.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina2.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina2.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina2.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina2.WriteLine("</div>");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina2.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina2.WriteLine("</div></a>");
                        }
                        Pagina2.WriteLine("</nav>");
                        Pagina2.WriteLine("<div class=\"box-titlu\">");
                        Pagina2.WriteLine("<h1>" + titlu2 + "</h1>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("<div class=\"box-prezentare-poza\" style=\"padding-bottom: 0px; border-color: " + culoare_despartire + ";\">");
                        Pagina2.WriteLine("<div class=\"box-poza\">");
                        Pagina2.WriteLine("<img src=\"" + poza2 + "\" alt=\"Poza Sectiune1\" style=\"border-color: " + culoare_despartire + ";\">");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));border-top: 0px; padding-top: 20px; border-color: " + culoare_despartire + ";\">");
                        Pagina2.WriteLine("<p class=\"text-sectiune\">" + text2 + "</p>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("</body>");
                        Pagina2.WriteLine("</html>");
                        Pagina2.Close();
                    }
                    else
                    {
                        Pagina3 = File.CreateText(titlubuton3 + ".html");
                        Pagina3.WriteLine("<!DOCTYPE html>");
                        Pagina3.WriteLine("<html lang=\"en\">");
                        Pagina3.WriteLine("<head>");
                        Pagina3.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina3.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina3.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=3.0\">");
                        Pagina3.WriteLine("<title>" + titlu3 + "</title>");
                        Pagina3.WriteLine("<link href=\"StyleAtestat1.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina3.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina3.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina3.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina3.WriteLine("</head>");
                        Pagina3.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina3.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                        Pagina3.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: relative;\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina3.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina3.WriteLine("</div></a>");
                            Pagina3.WriteLine("<div class=\"links\">");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina3.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina3.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina3.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina3.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina3.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina3.WriteLine("<div class=\"links\">");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina3.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina3.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina3.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina3.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina3.WriteLine("</div>");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina3.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina3.WriteLine("</div></a>");
                        }
                        Pagina3.WriteLine("</nav>");
                        Pagina3.WriteLine("<div class=\"box-titlu\">");
                        Pagina3.WriteLine("<h1>" + titlu3 + "</h1>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("<div class=\"box-prezentare-poza\" style=\"padding-bottom: 0px; border-color: " + culoare_despartire + ";\">");
                        Pagina3.WriteLine("<div class=\"box-poza\">");
                        Pagina3.WriteLine("<img src=\"" + poza3 + "\" alt=\"Poza Sectiune3\" style=\"border-color: " + culoare_despartire + ";\">");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));border-top: 0px; padding-top: 20px; border-color: " + culoare_despartire + ";\">");
                        Pagina3.WriteLine("<p class=\"text-sectiune\">" + text3 + "</p>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("</body>");
                        Pagina3.WriteLine("</html>");
                        Pagina3.Close();
                    }
                }
                Contact = File.CreateText("Contact.html");
                Contact.WriteLine("<!DOCTYPE html>");
                Contact.WriteLine("<html lang=\"en\">");
                Contact.WriteLine("<head>");
                Contact.WriteLine("<meta charset=\"UTF-8\">");
                Contact.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                Contact.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=3.0\">");
                Contact.WriteLine("<title>" + titlu3 + "</title>");
                Contact.WriteLine("<link href=\"StyleAtestat1.css\" rel=\"stylesheet\" type=\"text/css\">");
                Contact.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                Contact.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                Contact.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                Contact.WriteLine("</head>");
                Contact.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                Contact.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                Contact.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: relative;\">");
                if (pozitie_meniu == "Stanga")
                {
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Contact.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Contact.WriteLine("</div></a>");
                    Contact.WriteLine("<div class=\"links\">");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal j = 1; j <= nrbutoane; j++)
                    {
                        if (j == 1) Contact.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (j == 2) Contact.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (j == 3) Contact.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Contact.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Contact.WriteLine("</div>");
                }
                else
                {
                    Contact.WriteLine("<div class=\"links\">");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal j = 1; j <= nrbutoane; j++)
                    {
                        if (j == 1) Contact.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (j == 2) Contact.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (j == 3) Contact.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Contact.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Contact.WriteLine("</div>");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Contact.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Contact.WriteLine("</div></a>");
                }
                Contact.WriteLine("</nav>");
                Contact.WriteLine("<div class=\"box-titlu\">");
                Contact.WriteLine("<h1>Contact</h1>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("<div class=\"box-prezentare-poza\" style=\"padding-top:0; border-color: " + culoare_despartire + ";\">");
                Contact.WriteLine("<div class=\"box-prezentare\" style=\"padding-top: 50px;\">");
                Contact.WriteLine("<address style=\"text-align: center;\">");
                Contact.WriteLine("Realiat de: "+ nume +" "+ prenume +" <br>");
                Contact.WriteLine("România <br>");
                Contact.WriteLine(""+ adresa +" <br>");
                Contact.WriteLine("Numărul "+ numar +" <br>");
                Contact.WriteLine("Telefon: "+ telefon +" <br>");
                Contact.WriteLine("E-mail: "+ mail +"");
                Contact.WriteLine("</address>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0)); border-color: " + culoare_despartire + ";\">");
                Contact.WriteLine("<div class=\"container\">");
                Contact.WriteLine("<form action=\"ContactForm.php\">");
                Contact.WriteLine("<label for=\"nume\">Nume</label>");
                Contact.WriteLine("<input type=\"text\" id=\"nume\" name=\"nume\" placeholder=\"Nume...\">");
                Contact.WriteLine("<label for=\"prenume\">Prenume</label>");
                Contact.WriteLine("<input type=\"text\" id=\"prenume\" name=\"prenume\" placeholder=\"Prenume...\">");
                Contact.WriteLine("<label for=\"mail\">E-mail</label>");
                Contact.WriteLine("<input type=\"text\" id=\"mail\" name=\"mail\" placeholder=\"E-mail...\">");
                Contact.WriteLine("<label for=\"mesaj\">Mesaj</label>");
                Contact.WriteLine("<textarea id=\"mesaj\" name=\"mesaj\" placeholder=\"Mesajul tău...\" style=\"height:200px\"></textarea>");
                Contact.WriteLine("<input type=\"submit\" value=\"Submit\">");
                Contact.WriteLine("</form>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</body>");
                Contact.WriteLine("</html>");
                Contact.Close();
            }
            else
            {
                Home.WriteLine("<!DOCTYPE html>");
                Home.WriteLine("<html lang=\"en\">");
                Home.WriteLine("<head>");
                Home.WriteLine("<meta charset=\"UTF-8\">");
                Home.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                Home.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                Home.WriteLine("<title>" + titlu + "</title>");
                Home.WriteLine("<link href=\"StyleAtestat.css\" rel=\"stylesheet\" type=\"text/css\">");
                Home.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                Home.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                Home.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                Home.WriteLine("</head>");
                Home.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                Home.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: " + tip_meniu + ";\">");
                if (pozitie_meniu == "Stanga")
                {
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Home.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Home.WriteLine("</div></a>");
                    Home.WriteLine("<div class=\"links\">");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal i = 1; i <= nrbutoane; i++)
                    {
                        if (i == 1) Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (i == 2) Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (i == 3) Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Home.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Home.WriteLine("</div>");
                }
                else
                {
                    Home.WriteLine("<div class=\"links\">");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal i = 1; i <= nrbutoane; i++)
                    {
                        if (i == 1) Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (i == 2) Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (i == 3) Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Home.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Home.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Home.WriteLine("</div></a>");
                }
                Home.WriteLine("</nav>");
                Home.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0));\">");
                Home.WriteLine("<div class=\"box-titlu\">");
                Home.WriteLine("<h1>" + titlu + "</h1>");
                Home.WriteLine("</div>");
                Home.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                Home.WriteLine("<div class=\"box-prezentare-poza\">");
                if (pozitietexttitlu == "Stanga")
                {
                    Home.WriteLine("<div class=\"box-prezentare\">");
                    Home.WriteLine("<h4 style=\"padding: 20px;\">" + descriere + "</h4>");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<div class=\"box-poza\">");
                    Home.WriteLine("<img src=\"" + pozadescriere + "\" alt=\"PozaSectiune1\" style=\"border-radius: 50px;\">");
                    Home.WriteLine("</div>");
                }
                else
                {
                    Home.WriteLine("<div class=\"box-poza\">");
                    Home.WriteLine("<img src=\"" + pozadescriere + "\" alt=\"PozaSectiune1\" style=\"border-radius: 50px;\">");
                    Home.WriteLine("</div>");
                    Home.WriteLine("<div class=\"box-prezentare\">");
                    Home.WriteLine("<h4 style=\"padding: 20px;\">" + descriere + "</h4>");
                    Home.WriteLine("</div>");

                }
                Home.WriteLine("</div>");
                Home.WriteLine("</div>");
                Home.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                Home.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));\">");
                for (decimal i = 1; i <= nrbutoane; i++)
                {
                    if (i == 1)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton1 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere1 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                    else if (i == 2)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton2 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere2 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                    else if (i == 3)
                    {
                        Home.WriteLine("<div>");
                        Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"sectiune2-titlu\">" + titlubuton3 + "</div></a>");
                        Home.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"cartonas " + cartonas + "\" style=\"" + cartonas_gradient + "\">");
                        Home.WriteLine("<p style=\"padding: 10px;\">" + descriere3 + "</p>");
                        Home.WriteLine("</div></a>");
                        Home.WriteLine("</div>");
                    }
                }
                Home.WriteLine("</div>");
                Home.WriteLine("</body>");
                Home.WriteLine("</html>");
                Home.Close();
                for (decimal i = 1; i <= nrbutoane; i++)
                {
                    if (i == 1)
                    {
                        Pagina1 = File.CreateText(titlubuton1 + ".html");
                        Pagina1.WriteLine("<!DOCTYPE html>");
                        Pagina1.WriteLine("<html lang=\"en\">");
                        Pagina1.WriteLine("<head>");
                        Pagina1.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina1.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina1.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                        Pagina1.WriteLine("<title>" + titlu1 + "</title>");
                        Pagina1.WriteLine("<link href=\"StyleAtestat.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina1.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina1.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina1.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina1.WriteLine("</head>");
                        Pagina1.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina1.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: " + tip_meniu + ";\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina1.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina1.WriteLine("</div></a>");
                            Pagina1.WriteLine("<div class=\"links\">");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina1.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina1.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina1.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina1.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina1.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina1.WriteLine("<div class=\"links\">");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina1.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina1.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina1.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina1.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina1.WriteLine("</div>");
                            Pagina1.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina1.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina1.WriteLine("</div></a>");
                        }
                        Pagina1.WriteLine("</nav>");
                        Pagina1.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina1.WriteLine("<div class=\"box-titlu\">");
                        Pagina1.WriteLine("<h1>" + titlu1 + "</h1>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina1.WriteLine("<div class=\"box-poza\">");
                        Pagina1.WriteLine("<img src=\"" + poza1 + "\" alt=\"Poza Sectiune1\" style=\"margin-top: 50px;\">");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina1.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina1.WriteLine("<p class=\"text-sectiune\">" + text1 + "</p>");
                        Pagina1.WriteLine("</div>");
                        Pagina1.WriteLine("</body>");
                        Pagina1.WriteLine("</html>");
                        Pagina1.Close();
                    }
                    else if (i == 2)
                    {
                        Pagina2 = File.CreateText(titlubuton2 + ".html");
                        Pagina2.WriteLine("<!DOCTYPE html>");
                        Pagina2.WriteLine("<html lang=\"en\">");
                        Pagina2.WriteLine("<head>");
                        Pagina2.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina2.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina2.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                        Pagina2.WriteLine("<title>" + titlu2 + "</title>");
                        Pagina2.WriteLine("<link href=\"StyleAtestat.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina2.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina2.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina2.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina2.WriteLine("</head>");
                        Pagina2.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina2.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: " + tip_meniu + ";\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina2.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina2.WriteLine("</div></a>");
                            Pagina2.WriteLine("<div class=\"links\">");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina2.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina2.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina2.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina2.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina2.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina2.WriteLine("<div class=\"links\">");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina2.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina2.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina2.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina2.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina2.WriteLine("</div>");
                            Pagina2.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina2.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina2.WriteLine("</div></a>");
                        }
                        Pagina2.WriteLine("</nav>");
                        Pagina2.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina2.WriteLine("<div class=\"box-titlu\">");
                        Pagina2.WriteLine("<h1>" + titlu2 + "</h1>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina2.WriteLine("<div class=\"box-poza\">");
                        Pagina2.WriteLine("<img src=\"" + poza2 + "\" alt=\"Poza Sectiune2\" style=\"margin-top: 50px;\">");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina2.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina2.WriteLine("<p class=\"text-sectiune\">" + text2 + "</p>");
                        Pagina2.WriteLine("</div>");
                        Pagina2.WriteLine("</body>");
                        Pagina2.WriteLine("</html>");
                        Pagina2.Close();
                    }
                    else
                    {
                        Pagina3 = File.CreateText(titlubuton3 + ".html");
                        Pagina3.WriteLine("<!DOCTYPE html>");
                        Pagina3.WriteLine("<html lang=\"en\">");
                        Pagina3.WriteLine("<head>");
                        Pagina3.WriteLine("<meta charset=\"UTF-8\">");
                        Pagina3.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                        Pagina3.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=3.0\">");
                        Pagina3.WriteLine("<title>" + titlu3 + "</title>");
                        Pagina3.WriteLine("<link href=\"StyleAtestat.css\" rel=\"stylesheet\" type=\"text/css\">");
                        Pagina3.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                        Pagina3.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                        Pagina3.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                        Pagina3.WriteLine("</head>");
                        Pagina3.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                        Pagina3.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: " + tip_meniu + ";\">");
                        if (pozitie_meniu == "Stanga")
                        {
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina3.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina3.WriteLine("</div></a>");
                            Pagina3.WriteLine("<div class=\"links\">");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina3.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina3.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina3.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina3.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina3.WriteLine("</div>");
                        }
                        else
                        {
                            Pagina3.WriteLine("<div class=\"links\">");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                            for (decimal j = 1; j <= nrbutoane; j++)
                            {
                                if (j == 1) Pagina3.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                                if (j == 2) Pagina3.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                                if (j == 3) Pagina3.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                            }
                            Pagina3.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                            Pagina3.WriteLine("</div>");
                            Pagina3.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                            Pagina3.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                            Pagina3.WriteLine("</div></a>");
                        }
                        Pagina3.WriteLine("</nav>");
                        Pagina3.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina3.WriteLine("<div class=\"box-titlu\">");
                        Pagina3.WriteLine("<h1>" + titlu3 + "</h1>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina3.WriteLine("<div class=\"box-poza\">");
                        Pagina3.WriteLine("<img src=\"" + poza3 + "\" alt=\"Poza Sectiune3\" style=\"margin-top: 50px;\">");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                        Pagina3.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));\">");
                        Pagina3.WriteLine("<p class=\"text-sectiune\">" + text3 + "</p>");
                        Pagina3.WriteLine("</div>");
                        Pagina3.WriteLine("</body>");
                        Pagina3.WriteLine("</html>");
                        Pagina3.Close();
                    }
                }
                Contact = File.CreateText("Contact.html");
                Contact.WriteLine("<!DOCTYPE html>");
                Contact.WriteLine("<html lang=\"en\">");
                Contact.WriteLine("<head>");
                Contact.WriteLine("<meta charset=\"UTF-8\">");
                Contact.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                Contact.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=3.0\">");
                Contact.WriteLine("<title>" + titlu3 + "</title>");
                Contact.WriteLine("<link href=\"StyleAtestat.css\" rel=\"stylesheet\" type=\"text/css\">");
                Contact.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.googleapis.com\">");
                Contact.WriteLine("<link rel=\"preconnect\" href=\"https://fonts.gstatic.com\" crossorigin>");
                Contact.WriteLine("<link href=\"https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,200;0,300;0,500;0,600;1,200;1,300;1,500;1,600&display=swap\" rel=\"stylesheet\">");
                Contact.WriteLine("</head>");
                Contact.WriteLine("<body style=\"background-color: " + culoare_pagina + ";\">");
                Contact.WriteLine("<nav style=\"background-color: " + culoare_nav + "; position: " + tip_meniu + ";\">");
                if (pozitie_meniu == "Stanga")
                {
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Contact.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Contact.WriteLine("</div></a>");
                    Contact.WriteLine("<div class=\"links\">");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal j = 1; j <= nrbutoane; j++)
                    {
                        if (j == 1) Contact.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (j == 2) Contact.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (j == 3) Contact.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Contact.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Contact.WriteLine("</div>");
                }
                else
                {
                    Contact.WriteLine("<div class=\"links\">");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Home</div></a>");
                    for (decimal j = 1; j <= nrbutoane; j++)
                    {
                        if (j == 1) Contact.WriteLine("<a href=\"" + titlubuton1 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton1 + "</div></a>");
                        if (j == 2) Contact.WriteLine("<a href=\"" + titlubuton2 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton2 + "</div></a>");
                        if (j == 3) Contact.WriteLine("<a href=\"" + titlubuton3 + ".html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">" + titlubuton3 + "</div></a>");
                    }
                    Contact.WriteLine("<a href=\"Contact.html\"><div class=\"buton\" style=\"color: " + culoare_text_nav + ";\">Contact</div></a>");
                    Contact.WriteLine("</div>");
                    Contact.WriteLine("<a href=\"Home.html\"><div class=\"logo\">");
                    Contact.WriteLine("<img src=" + logo + " alt=\"Logo\">");
                    Contact.WriteLine("</div></a>");
                }
                Contact.WriteLine("</nav>");
                Contact.WriteLine("<div class=\"sectiune1\" style=\"background-image: linear-gradient(to bottom, " + culoare_pagina + ",rgba(0,0,0,.0));\">");
                Contact.WriteLine("<div class=\"box-titlu\">");
                Contact.WriteLine("<h1>Contact</h1>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                Contact.WriteLine("<div class=\"box-prezentare\" style=\"padding-top: 50px;\">");
                Contact.WriteLine("<address style=\"text-align: center;\">");
                Contact.WriteLine("Realiat de: " + nume + " " + prenume + " <br>");
                Contact.WriteLine("România <br>");
                Contact.WriteLine("" + adresa + " <br>");
                Contact.WriteLine("Numărul " + numar + " <br>");
                Contact.WriteLine("Telefon: " + telefon + " <br>");
                Contact.WriteLine("E-mail: " + mail + "");
                Contact.WriteLine("</address>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("<div class=\"sectionare\" style=\"background-color: " + culoare_despartire + ";\"></div>");
                Contact.WriteLine("<div class=\"sectiune2\" style=\"background-image: linear-gradient(to top," + culoare_pagina + ",rgba(0,0,0,.0));\">");
                Contact.WriteLine("<div class=\"container\">");
                Contact.WriteLine("<form action=\"ContactForm.php\">");
                Contact.WriteLine("<label for=\"nume\">Nume</label>");
                Contact.WriteLine("<input type=\"text\" id=\"nume\" name=\"nume\" placeholder=\"Nume...\">");
                Contact.WriteLine("<label for=\"prenume\">Prenume</label>");
                Contact.WriteLine("<input type=\"text\" id=\"prenume\" name=\"prenume\" placeholder=\"Prenume...\">");
                Contact.WriteLine("<label for=\"mail\">E-mail</label>");
                Contact.WriteLine("<input type=\"text\" id=\"mail\" name=\"mail\" placeholder=\"E-mail...\">");
                Contact.WriteLine("<label for=\"mesaj\">Mesaj</label>");
                Contact.WriteLine("<textarea id=\"mesaj\" name=\"mesaj\" placeholder=\"Mesajul tău...\" style=\"height:200px\"></textarea>");
                Contact.WriteLine("<input type=\"submit\" value=\"Submit\">");
                Contact.WriteLine("</form>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</div>");
                Contact.WriteLine("</body>");
                Contact.WriteLine("</html>");
                Contact.Close();
            }
        }
    }
}
