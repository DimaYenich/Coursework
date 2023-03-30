using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Teor1 : Form
    {
        public Teor1()
        {
            InitializeComponent();
            north.Visible = true;
            south.Visible = false;
        }

        public Teor1(int number)
        {
            InitializeComponent();
            north.Visible = false;
            south.Visible = true;
            if (number == 2)
                richTextBox1.Text = 
                    "Півде́нна Аме́рика (ісп. América del Sur, Sudamérica, Suramérica, порт. América do Sul, англ. South America, нід. Zuid-Amerika, фр. Amérique du Sud, гуар. Ñembyamérika, кеч. Urin Awya Yala, Urin Amerika) — материк, розташований в Західній, Південній і частково в Північній півкулях планети Земля. На заході омивається водами Тихого океану, на сході — Атлантичного. На півночі з'єднаний Панамським перешийком з Північною Америкою. До складу Південної Америки входить також низка островів. Великі й Малі Антильські острови Карибського моря належать до Північної Америки.\nПлоща континенту — 17,8 млн км²[2] (4-е місце серед континентів), населення — 385 742 554 осіб (2008, 5-е місце серед континентів).\n\nПротяжність з півночі на південь — 7350 км(приблизно).Протяжність із заходу на схід — 4900 км(приблизно).\n\n Всього в Південній Америці розташовано 12 незалежних країн: Аргентина, Болівія, Бразилія, Венесуела, Гаяна, Колумбія, Парагвай, Перу, Суринам, Уругвай,  Чилі, Еквадор. Найбільша південноамериканська країна — Бразилія, її площа 8 515 770 квадратних кілометрів. Плюс залежні території інших країн: Фолклендські Острови, Французька Гвіана, Південна Джорджія та Південні Сандвічеві острови.\n\nБлизько половини населення Південної Америки, живе в Бразилії. Розмовляють тут на місцевому діалекті португальської мови.\n\nНайзнаменитіші водоспади світу також розташовані в Південній Америці. Анхель — найвищий з них, а Ігуасу — найпотужніший.\n\nНайбільша річка в світі протікає по цьому континенту. Амазонка має понад півтисячі приток.";
        }
        private void GoToMain()
        {
            this.Close();
            mainForm main = new mainForm();
            main.Show();
        }
       

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            GoToMain();
        }
    }
}
