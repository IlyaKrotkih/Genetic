using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Genetic
{
    public partial class FormMain : Form
    {
        private Population pop; // Выбранная популяция.
        private List<Population> iter; // Коллекция популяций.
        private int count; // Число итераций.

        public FormMain()
        {
            InitializeComponent();
        }

        // Методы событий элементов формы.
        private void btnStart_Click(object sender, EventArgs e)
        {
            iter = new List<Population>(); // Инициализируем новый список итераций
            count = Convert.ToInt32(numPopulationCount.Value);
            iter.Add(new Population(count,0)); // Добавляем родительскую популяцию
            for (int i = 1; i < numMaxIteration.Value; i++) // Генерация популяций
            {
                iter.Add(new Population(iter[i - 1].AnswerPopulation,count, i));
            }
            lstIteration.DataSource = iter;
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if (pop == null) return;
            FormList frm = new FormList(pop.CurrentPopulation, "Скрещивание");
            frm.Show();
        }

        private void btnParrents_Click(object sender, EventArgs e)
        {
            if (pop == null) return;
            FormList frm = new FormList(pop.ParrentPopulation, "Родительская популяция");
            frm.Show();
        }

        private void btnMutation_Click(object sender, EventArgs e)
        {
            if (pop == null) return;
            FormList frm = new FormList(pop.MutationPopulation, "Мутация");
            frm.Show();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (pop == null) return;
            FormList frm = new FormList(pop.AnswerPopulation, "Итоговая популяция");
            frm.Show();
        }

        private void lstIteration_SelectedIndexChanged(object sender, EventArgs e)
        {
            pop = lstIteration.SelectedItem as Population; // Выбирает текущую популяцию.
        }

        private void numPopulationCount_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numPopulationCount.Value);
            int ost = count % 2;
            if (ost != 0)// Проверка на четность популяции
                numPopulationCount.Value -= 1; 
        }
    }
}
