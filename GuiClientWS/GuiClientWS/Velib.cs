﻿using GuiClientWS.VelibSoapServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiClientWS
{
    public partial class Velib : Form
    {
        Panel panel = new Panel();
        RadioButton searchCity;
        RadioButton searchStation;
        Button confirmButton;
        Button returnButton;
        TextBox cityTextBox;
        TextBox stationTextBox;
        VelibServiceClient client = new VelibServiceClient("service1");
        string result;
        public Velib()
        {
            InitializeComponent();
            CreateWelcomePanel();
            this.Height = 400;
            this.Width = 400;
            returnButton = new Button();
            returnButton.Text = "return";
            returnButton.Size = new Size(50, 30);
            returnButton.Location = new Point(0, 0);
            returnButton.Click += new EventHandler(ReturnButtonClick);
            Controls.Add(InitReturnPanel());
        }

        private Panel InitReturnPanel()
        {
            Panel returnPanel = new Panel();
            returnPanel.Size = new Size(400, 40);
            returnPanel.Location = new Point(0, 0);
            returnPanel.Controls.Add(returnButton);
            return returnPanel;
        }

        private void CreateWelcomePanel()
        {
            Panel welcomePanel = new Panel();
            welcomePanel.Size = new Size(400, 300);
            welcomePanel.Location = new Point(0,40);

            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to Velib\nWhat do yo want to do?";
            welcomeLabel.Size = new Size(200, 40);
            welcomeLabel.Location = new Point((welcomePanel.Width - welcomeLabel.Width) / 2, (welcomePanel.Height - welcomeLabel.Height) / 2 - 90);

            searchCity = new RadioButton();
            searchCity.Size = new Size(200, 40);
            searchCity.Location = new Point((welcomePanel.Width - searchCity.Width) / 2, (welcomePanel.Height - searchCity.Height) / 2 - 50);
            searchCity.Text = "List all stations of a city";

            searchStation = new RadioButton();
            searchStation.Size = new Size(200, 40);
            searchStation.Location = new Point((welcomePanel.Width - searchStation.Width) / 2, (welcomePanel.Height - searchStation.Height) / 2);
            searchStation.Text = "Search for a station by name";

            confirmButton = new Button();
            confirmButton.Size = new Size(200, 50);
            confirmButton.Location = new Point((welcomePanel.Width - confirmButton.Width) / 2, (welcomePanel.Height - confirmButton.Height) / 2 + 50);
            confirmButton.Text = "Confirm";
            confirmButton.Click += new EventHandler(ConfirmButtonClick);

            welcomePanel.Controls.Add(searchCity);
            welcomePanel.Controls.Add(searchStation);
            welcomePanel.Controls.Add(confirmButton);
            welcomePanel.Controls.Add(welcomeLabel);

            panel.Visible = false;
            panel = welcomePanel;
            Controls.Add(panel);
            panel.Visible = true;
        }

        private void CreateSearchCityPanel()
        {
            Panel searchCityPanel = new Panel();
            searchCityPanel.Size = new Size(400, 200);
            searchCityPanel.Location = new Point((this.Width - searchCityPanel.Width) / 2, (this.Height - searchCityPanel.Height) / 2);

            cityTextBox = new TextBox();
            cityTextBox.Size = new Size(300, 40);
            cityTextBox.Text = "Please input the city you want to search for";
            cityTextBox.Location = new Point((searchCityPanel.Width - cityTextBox.Width) / 2, (searchCityPanel.Height - cityTextBox.Height) / 2 - 20);

            confirmButton = new Button();
            confirmButton.Size = new Size(200, 50);
            confirmButton.Text = "Confirm";
            confirmButton.Click += new EventHandler(ConfirmCityButtonClick);
            confirmButton.Location = new Point((searchCityPanel.Width - confirmButton.Width) / 2, (searchCityPanel.Height - confirmButton.Height) / 2 + 50);
            searchCityPanel.Controls.Add(cityTextBox);
            searchCityPanel.Controls.Add(confirmButton);

            panel.Visible = false;
            panel = searchCityPanel;
            Controls.Add(panel);
            panel.Visible = true;
        }

        private void CreateSearchStationPanel()
        {
            Panel searchStationPanel = new Panel();
            searchStationPanel.Size = new Size(400, 300);
            searchStationPanel.Location = new Point((this.Width - searchStationPanel.Width) / 2, (this.Height - searchStationPanel.Height) / 2);

            cityTextBox = new TextBox();
            cityTextBox.Size = new Size(300, 40);
            cityTextBox.Text = "Please input the city you want to search for";
            cityTextBox.Location = new Point((searchStationPanel.Width - cityTextBox.Width) / 2, (searchStationPanel.Height - cityTextBox.Height) / 2 - 100);

            stationTextBox = new TextBox();
            stationTextBox.Size = new Size(300, 40);
            stationTextBox.Text = "Please input the station you want to search for";
            stationTextBox.Location = new Point((searchStationPanel.Width - cityTextBox.Width) / 2, (searchStationPanel.Height - cityTextBox.Height) / 2 - 50);

            confirmButton = new Button();
            confirmButton.Size = new Size(200, 50);
            confirmButton.Text = "Confirm";
            confirmButton.Click += new EventHandler(ConfirmStationButtonClick);
            confirmButton.Location = new Point((searchStationPanel.Width - confirmButton.Width) / 2, (searchStationPanel.Height - confirmButton.Height) / 2 + 50);
            searchStationPanel.Controls.Add(cityTextBox);
            searchStationPanel.Controls.Add(stationTextBox);
            searchStationPanel.Controls.Add(confirmButton);

            panel.Visible = false;
            panel = searchStationPanel;
            Controls.Add(panel);
            panel.Visible = true;
        }

        private void CreateResultPanel()
        {
            Panel resultPanel = new Panel();
            resultPanel.Size = new Size(800, 400);
            resultPanel.Location = new Point((this.Width - resultPanel.Width) / 2, (this.Height - resultPanel.Height) / 2);
            Label resultLabel = new Label();
            resultPanel.Controls.Add(resultLabel);
            resultLabel.AutoSize = true;
            resultPanel.AutoSize = false;
            resultPanel.AutoScroll = true;
            resultLabel.MaximumSize = new Size(800, 0);
            resultLabel.Location = resultLabel.PointToClient(new Point(270, 130));
            resultLabel.Text = result;

            panel.Visible = false;
            panel = resultPanel;
            Controls.Add(panel);
            panel.Visible = true;
        }

        private void ConfirmButtonClick(object sender, EventArgs args)
        {
            if (searchCity.Checked == true)
            {
                CreateSearchCityPanel();
            }

            if (searchStation.Checked == true)
            {
                CreateSearchStationPanel();
            }
        }

        private void ConfirmCityButtonClick(object sender, EventArgs args)
        {
            if (cityTextBox.Text != "")
            {
                result = client.GetStationsOfACity(cityTextBox.Text);
                result += "\n\n\n\n\n\n\n\n\n\n\n\n";
                CreateResultPanel();
            }
            else
            {
                MessageBox.Show("Please input a city");
            }
        }

        private void ConfirmStationButtonClick(object sender, EventArgs args)
        {
            if (cityTextBox.Text != "" && stationTextBox.Text !="")
            {
                result = client.GetStationInfo(cityTextBox.Text, stationTextBox.Text);
                CreateResultPanel();
            }
            else
            {
                MessageBox.Show("Please input a city");
            }
        }

        private void ReturnButtonClick(object sender, EventArgs args)
        {
            CreateWelcomePanel();
        }

        private void Velib_Load(object sender, EventArgs e)
        {

        }
    }
}