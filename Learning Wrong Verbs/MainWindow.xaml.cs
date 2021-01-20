using Learning_Wrong_Verbs.AppData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Learning_Wrong_Verbs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MenuInit();
        }
        //Params
        TableConstructor tableConstructor;
        int taskIndex;
        List<Char> taskChars = new List<char> { };
        List<Char> letters = new List<char> { 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'K', 'L', 'M', 'O', 'P', 'R', 'S', 'T', 'U', 'V'};
        List<CheckBox> checkBoxes = new List<CheckBox> { };
        //Menu methods
        public void MenuInit()
        {
            CheckBoxCreation();
            ComboBoxFill();
        }
        public void CheckBoxCreation()
        {
            for (int i = 0; i < letters.Count; i++)
            {
                checkBoxes.Add(new CheckBox());
                checkBoxes[i].Content = letters[i];
            }
        }
        public void ComboBoxFill()
        {
            for(int i = 0; i < checkBoxes.Count; i++)
            {
                comboBox.Items.Add(checkBoxes[i]);
            }
        }
        private void comboBox_DropDownClosed(object sender, EventArgs e)
        {
            string checkedLetters = "";
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].IsChecked == true)
                {
                    checkedLetters += checkBoxes[i].Content;
                    checkedLetters += "   ";
                }
            }
            comboBox.Text = checkedLetters;
        }
        //Tasks methods
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            taskIndex = 0;
            comboBox.Visibility = Visibility.Hidden;
            lettersL.Visibility = Visibility.Hidden;
            startBtn.Visibility = Visibility.Hidden;
            quitBtn.Visibility = Visibility.Hidden;

            dataGrid.Visibility = Visibility.Visible;
            nextBtn.Visibility = Visibility.Visible;
            quitBtn_Copy.Visibility = Visibility.Visible;

            DataGridFill();
            DataGridVisio();
        }
        public void DataGridFill()
        {

            if(taskIndex == 0)
            {
                taskChars.Clear();
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (checkBoxes[i].IsChecked == true)
                    {
                        taskChars.Add((char)checkBoxes[i].Content);
                    }
                }
                tableConstructor = new TableConstructor();
                tableConstructor.makeFirstList(taskChars);
                tableConstructor.makeCheckList(taskChars);
                dataGrid.ItemsSource = tableConstructor.taskVerbs1;

                taskIndex++;
            }
            else if (taskIndex == 1 && CanTurnPage())
            {
                tableConstructor.makeSecondList(taskChars);
                dataGrid.ItemsSource = tableConstructor.taskVerbs2;
                EditColumnsWidth();
                taskIndex++;
            }
            else if (taskIndex == 2 && CanTurnPage())
            {
                tableConstructor.makeThirdList(taskChars);
                dataGrid.ItemsSource = tableConstructor.taskVerbs3;
                EditColumnsWidth();
                taskIndex++;
            }
            else if (taskIndex == 3 && CanTurnPage())
            {
                tableConstructor.makeFourthList(taskChars);
                dataGrid.ItemsSource = tableConstructor.taskVerbs4;
                EditColumnsWidth();
                taskIndex++;
            }
            else if (taskIndex == 4 && CanTurnPage())
            {
                MessageBox.Show("Well done! Mission is complete");
                taskIndex = 0;

                comboBox.Visibility = Visibility.Visible;
                lettersL.Visibility = Visibility.Visible;
                startBtn.Visibility = Visibility.Visible;
                quitBtn.Visibility = Visibility.Visible;

                dataGrid.Visibility = Visibility.Hidden;
                nextBtn.Visibility = Visibility.Hidden;
                quitBtn_Copy.Visibility = Visibility.Hidden;
            }

        }
        public bool CanTurnPage()
        {
            bool ch = false;
            for (int i = 0; i < dataGrid.Items.Count; i++)
            {
                if ((dataGrid.Items[i] as WrongVerb).Right)
                {
                    ch = true;
                }
                else
                {
                    ch = false;
                }
            }
            return ch;
        }
        
        public void DataGridVisio ()
        {
            dataGrid.IsEnabled = true;
            dataGrid.IsReadOnly = false;

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].IsReadOnly = true;
            }
            dataGrid.Columns[taskIndex-1].IsReadOnly = false;
            EditColumnsWidth();
        }
        public void EditColumnsWidth ()
        {
            dataGrid.Columns[0].Width = dataGrid.Width * 0.2;
            dataGrid.Columns[1].Width = dataGrid.Width * 0.2;
            dataGrid.Columns[2].Width = dataGrid.Width * 0.25;
            dataGrid.Columns[3].Width = dataGrid.Width * 0.25;
            dataGrid.Columns[4].Width = dataGrid.Width * 0.1;
            dataGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
        }
        private void dataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                var editedVerb = e.Row.Item as WrongVerb;
                int index = e.Row.GetIndex();
                if(taskIndex == 1)
                {
                    tableConstructor.taskVerbs1[index].Translation = editedVerb.Translation;
                    if (tableConstructor.CheckTranslation(tableConstructor.taskVerbs1[index], index))
                    {
                        (dataGrid.Items[index] as WrongVerb).Right = true;
                        dataGrid.Items.Refresh();
                    }
                    dataGrid.ItemsSource = tableConstructor.taskVerbs1;
                }
                else if (taskIndex == 2)
                {
                    tableConstructor.taskVerbs2[index].FForm = editedVerb.FForm;
                    if (tableConstructor.CheckFForm(tableConstructor.taskVerbs2[index], index))
                    {
                        (dataGrid.Items[index] as WrongVerb).Right = true;
                        dataGrid.Items.Refresh();
                    }
                    dataGrid.ItemsSource = tableConstructor.taskVerbs2;
                }
                else if (taskIndex == 3)
                {
                    tableConstructor.taskVerbs3[index].SForm = editedVerb.SForm;
                    if (tableConstructor.CheckSForm(tableConstructor.taskVerbs3[index], index))
                    {
                        (dataGrid.Items[index] as WrongVerb).Right = true;
                        dataGrid.Items.Refresh();
                    }
                    dataGrid.ItemsSource = tableConstructor.taskVerbs3;
                }
                else if (taskIndex == 4)
                {
                    tableConstructor.taskVerbs4[index].FForm = editedVerb.FForm;
                    if (tableConstructor.CheckTForm(tableConstructor.taskVerbs4[index], index))
                    {
                        (dataGrid.Items[index] as WrongVerb).Right = true;
                        dataGrid.Items.Refresh();
                    }
                    dataGrid.ItemsSource = tableConstructor.taskVerbs4;
                }


            }), System.Windows.Threading.DispatcherPriority.Background);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            DataGridFill();
        }

        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
