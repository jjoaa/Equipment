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
    /// AddMaintenanceWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddMaintenanceWindow : Window
    {
        private readonly int _equipmentId;

        public AddMaintenanceWindow(int equipmentId)
        {
            InitializeComponent();
            _equipmentId = equipmentId;

            using var context = new AppDbContext();
            var equipment = context.Equipments.FirstOrDefault(e => e.Id == _equipmentId);
            EquipmentTextBox.Text = equipment.Name;
            DatePicker.SelectedDate = DateTime.Now;
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm");
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (DatePicker.SelectedDate == null || string.IsNullOrWhiteSpace(TechnicianTextBox.Text))
            {
                MessageBox.Show("날짜와 정비사를 입력해주세요.");
                return;
            }

            if (!TimeSpan.TryParse(TimeTextBox.Text, out var time))
            {
                MessageBox.Show("시간은 HH:mm 형식으로 입력해주세요 (예: 14:30).");
                return;
            }

            DateTime fullDateTime = DatePicker.SelectedDate.Value.Date + time;
            var nextDueDate = NextDueDatePicker.SelectedDate;

            var newLog = new MaintenanceHistory
            {
                EquipmentId = _equipmentId,
                Date = fullDateTime,
                Technician = TechnicianTextBox.Text,
                Description = DescriptionTextBox.Text,
                NextDueDate = nextDueDate
            };

            try
            {
                using var context = new AppDbContext();
                context.MaintenanceHistories.Add(newLog);
                context.SaveChanges();
                MessageBox.Show("정비 이력이 추가되었습니다.");
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
