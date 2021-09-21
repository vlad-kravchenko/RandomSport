using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RandomSport
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Excerice> training = new List<Excerice>();

            training.AddRange(GetExcercises(ExcericeRepository.Excerices.Where(g => g.Group == Group.COMPLEX).ToList(), 2));
            training.AddRange(GetExcercises(ExcericeRepository.Excerices.Where(g => g.Group == Group.CORE).ToList(), 2));
            training.AddRange(GetExcercises(ExcericeRepository.Excerices.Where(g => g.Group == Group.LEGS).ToList(), 2));
            training.AddRange(GetExcercises(ExcericeRepository.Excerices.Where(g => g.Group == Group.UPPER).ToList(), 2));
            training = training.OrderByDescending(g => g.Current).ToList();
            training.AddRange(GetExcercises(ExcericeRepository.Excerices.Where(g => g.Group == Group.STRETCHING).ToList(), 2));

            MainList.ItemsSource = training;
        }

        private IEnumerable<Excerice> GetExcercises(List<Excerice> groupItems, int count)
        {
            List<Excerice> result = new List<Excerice>();
            Random rand = new Random();
            while (result.Count < count)
            {
                int index = rand.Next(0, groupItems.Count);
                Excerice item = groupItems[index];
                if (!result.Contains(item))
                {
                    item.Current = rand.Next(item.Min, item.Max + 1);
                    result.Add(item);
                }
            }
            return result;
        }
    }
}