using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Genetic
{
    public partial class FormList : Form
    {
        // Конструктор формы, берет список и название.
        public FormList(IEnumerable<PopulationElement> lst, string formname)
        {
            InitializeComponent();
            this.Text = formname;
            try
            {
                foreach (PopulationElement o in lst)// Заполняем таблицу
                {

                    dgvList.Rows.Add(new object[] { String.Concat(o.X),
                    String.Concat(o.Y),
                    o.valX,
                    o.valY,
                    o.D1.ToString("F"),
                    o.D2.ToString("F"),
                    o.F.ToString("F") });
                }
            }
            catch (Exception ex)
            {
                // Сообщение в случае ошибки.
                MessageBox.Show("Неудалось получить список \n " + ex.Message, "Ошибка");
            }
        }
    }
}
