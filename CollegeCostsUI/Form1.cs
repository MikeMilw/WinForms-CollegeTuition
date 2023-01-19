    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    namespace CollegeCostsUI
    {
        public partial class Form1 : Form
        {

            private int totalTuitionCost;
            List<string> collegeList = new List<string>();
            List<int> inStateTuition = new List<int>();
            List<int> outStateTuition = new List<int>();
            List<int> roomBoard = new List<int>();

        
            //read college information from CSV file
            public void ReadDataFromCSV()
            {
                using (var reader = new StreamReader(@"college_costs.csv"))
                {
                

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        //if college count is zero, this is the title/first line
                        if (collegeList.Count == 0)
                        {
                            line = reader.ReadLine();

                        }
                        var values = line.Split(',');

                        //strip out any double quotes from college name
                        values[0] = values[0].Replace("\"", "");

                        collegeList.Add(values[0]);
                        if (values[1] == "")
                        {
                            values[1] = "0";
                        }
                        inStateTuition.Add(Convert.ToInt32(values[1]));
                        if (values[2] == "")
                            values[2] = values[1];
                        outStateTuition.Add(Convert.ToInt32(values[2]));
                        roomBoard.Add(Convert.ToInt32(values[3]));
                    }
                }
                collegeListBox.DataSource = collegeList;
            }


            public Form1()
            {
                InitializeComponent();
                ReadDataFromCSV();
            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                outStateCheckBox.Checked = !instateCheckbox.Checked;
                UpdateCostsForCollege(collegeListBox.SelectedIndex);
            }

            private void outStateCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                instateCheckbox.Checked = !outStateCheckBox.Checked;
                UpdateCostsForCollege(collegeListBox.SelectedIndex);
            }


            private void includeRoomBoardCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                UpdateCostsForCollege(collegeListBox.SelectedIndex);
            }

            private void collegeListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                UpdateCostsForCollege(collegeListBox.SelectedIndex);
            }

            private void UpdateCostsForCollege(int selectedIndex)
            {
                totalTuitionCost = 0;
                instateTuitionTextBox.Text = inStateTuition[selectedIndex].ToString();
                outStateTuitionTextBox.Text = outStateTuition[selectedIndex].ToString();

                if (instateCheckbox.Checked)
                {
                    totalTuitionCost += inStateTuition[selectedIndex];
                }
                if (outStateCheckBox.Checked)
                {
                    totalTuitionCost += outStateTuition[selectedIndex];
                
                }
                if (includeRoomBoardCheckBox.Checked)
                {
                    totalTuitionCost += roomBoard[selectedIndex];
                    roomBoardTextBox.Text = roomBoard[selectedIndex].ToString();

                }
                totalTuitionTextBox.Text = totalTuitionCost.ToString();
            }

            private void closeButton_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }
