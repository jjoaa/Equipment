using EP.Data;
using EP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EP
{
    /// <summary>
    /// AddEquipmentWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddEquipmentWindow : Window
    {
        public AddEquipmentWindow()
        {
            InitializeComponent();
            AcquiredDatePicker.SelectedDate = DateTime.Today;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("장비 이름을 입력하세요.");
                return;
            }

            var equipment = new Equipment
            {
                Name = NameTextBox.Text,
                Code = CodeTextBox.Text,
                Model = ModelTextBox.Text,
                Manufacturer = ManufacturerTextBox.Text,
                AcquiredDate = AcquiredDatePicker.SelectedDate ?? DateTime.Today,
                Location = LocationTextBox.Text,
                Status = StatusTextBox.Text

            };

            try
            {
                using var context = new AppDbContext();
                context.Equipments.Add(equipment);
                context.SaveChanges();

                MessageBox.Show("장비가 추가되었습니다.");
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 실패: " + ex.Message);
            }
        }
    }
}
