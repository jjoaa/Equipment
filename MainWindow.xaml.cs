using EP.Data;
using EP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace EP
{
    public partial class MainWindow : Window
    {
        private readonly AppDbContext _context;

        public class EquipmentViewModel
        {
            public int Id { get; set; }
            public string DisplayName { get; set; } = string.Empty;
        }

        public MainWindow()
        {
            InitializeComponent();

            _context = new AppDbContext();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var equipmentList = _context.Equipments
                    .Select(e => new EquipmentViewModel
                    {
                        Id = e.Id,
                        DisplayName = $"{e.Name} ({e.Code})"
                    })
                    .ToList();

                EquipmentListBox.ItemsSource = equipmentList;
                EquipmentListBox.DisplayMemberPath = "DisplayName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("장비 목록 불러오기 실패: " + ex.Message);
            }
        }

        private void EquipmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EquipmentListBox.SelectedItem is EquipmentViewModel selectedEquipment)
            {
                try
                {
                    var histories = _context.MaintenanceHistories
                        .Where(h => h.EquipmentId == selectedEquipment.Id)
                        .OrderByDescending(h => h.Date)
                        .ToList();

                    MaintenanceHistoryGrid.ItemsSource = histories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("정비 이력 불러오기 실패: " + ex.Message);
                }
            }
        }
      

        // 정비 이력 목록 불러오기
        private void LoadMaintenanceHistories()
        {
            try
            {
                // 데이터베이스에서 목록 조회
                using var context = new AppDbContext();

                var equipmentList = context.Equipments
                    .Select(e => new EquipmentViewModel
                    {
                        Id = e.Id,
                        DisplayName = $"{e.Name} ({e.Code})"
                    })
                    .ToList();

                EquipmentListBox.ItemsSource = equipmentList;
                EquipmentListBox.DisplayMemberPath = "DisplayName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("목록 불러오기 실패: " + ex.Message);
            }
        }

        //private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        //{
        //    LoadMaintenanceHistories();
        //}

        private void BtnAddLog_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    // 예시: 장비ID 1번, 현재시간, 테스트 데이터로 새 로그 추가
            //    var newLog = new MaintenanceHistory
            //    {
            //        EquipmentId = 1,
            //        Date = DateTime.Now,
            //        Technician = "테스트 정비사",
            //        Description = "테스트로 정비 이력 추가"
            //    };

            //    _context.MaintenanceHistories.Add(newLog);
            //    _context.SaveChanges();

            //    MessageBox.Show("정비 이력 추가 완료");

            //    LoadMaintenanceHistories(); // 추가 후 목록 새로고침
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("정비 이력 추가 실패: " + ex.Message);
            //}

            if (EquipmentListBox.SelectedItem is not EquipmentViewModel selectedEquipment)
            {
                MessageBox.Show("장비를 선택해주세요.");
                return;
            }

            var addWindow = new AddMaintenanceWindow(selectedEquipment.Id);
            if (addWindow.ShowDialog() == true)
            {
                // 새로고침
                EquipmentListBox_SelectionChanged(null, null);
            }
        }

        private void BtnAddEquipment_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddEquipmentWindow();
            if (window.ShowDialog() == true)
            {
                // 장비 목록 새로고침
                //var equipments = _context.Equipments.ToList();
                //EquipmentListBox.ItemsSource = equipments;
                LoadMaintenanceHistories(); // 장비 목록 새로고침
            }
        }
    }
}
