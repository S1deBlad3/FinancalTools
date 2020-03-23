using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_form_2
{
    public partial class Form1 : Form
    {

        public static int anskaffning, ackPlan, ackÖver;

        public static int IBinv;

        public static int inköp, försäljning;

        public static double underlag;



        public static double resultat;


        public static int UBInventarie, UBack;

        public static double MaxÖveravskrivningar;



        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            anskaffning = Convert.ToInt32(AnskaffingBox.Text);
            ackPlan = Convert.ToInt32(PlanenligaBox.Text);
            ackÖver = Convert.ToInt32(ÖveravskrivningarBox.Text);

            IBinv = anskaffning - ackPlan - ackÖver;

            IBInventatrieBox.Text = Convert.ToString(IBinv);
            SkatteBox.Text = Convert.ToString(IBinv);


        }

      

        private void button3_Click(object sender, EventArgs e)
        {


            inköp = Convert.ToInt32(InköpBox.Text);
            försäljning = Convert.ToInt32(FörsäljningBox.Text);

            underlag = (IBinv + inköp - försäljning) * 0.70;

            UnderlagBox.Text = Convert.ToString(underlag);
            IBöverack.Text = Convert.ToString(ackÖver);
            UderlagBox2.Text = Convert.ToString(underlag);
            UBInventarie = IBinv + inköp;
            UBBOX.Text = Convert.ToString(UBInventarie);

        }



       


        private void button4_Click(object sender, EventArgs e)
        {

            IBöverack.Text = Convert.ToString(ackÖver);

           
            UBack = Convert.ToInt32(UBAckBox.Text);



            MaxÖveravskrivningar = UBInventarie - UBack - underlag - ackÖver;

            

            

            resultat = MaxÖveravskrivningar;

            MaxÖveravskriningBox.Text = Convert.ToString(resultat);


            ResultatBox.Text = Convert.ToString(resultat);

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = Convert.ToInt32(resultat);
            

        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            resultat = hScrollBar1.Value;

            ResultatBox.Text = Convert.ToString(resultat);






        }


    }

}
