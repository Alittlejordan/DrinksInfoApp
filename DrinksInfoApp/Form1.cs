using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DrinksInfoApp
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
            InitializeUI();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the category combo box
            PopulateCategories();
        }

        private void InitializeUI()
        {
            // Initialize components

            // Set form properties
            this.Text = "Drink Menu";
            categoryLabel.AutoSize = true;
            drinksLabel.AutoSize = true;
            nameLabel.AutoSize = true;
            typeLabel.AutoSize = true;
            priceLabel.AutoSize = true;

            // Set combo box properties
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            drinksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set text box properties
            nameTextBox.ReadOnly = true;
            typeTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;

            // Add event handlers
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            drinksComboBox.SelectedIndexChanged += drinksComboBox_SelectedIndexChanged;

            // Set form load event
            this.Load += Form1_Load;
        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate the drinks combo box based on the selected category
            PopulateDrinks(categoryComboBox.SelectedItem.ToString());
        }

        private async void drinksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fetch and display drink details
            await DisplayDrinkDetails(drinksComboBox.SelectedItem.ToString());
        }

        private async void PopulateCategories()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make the API request to get categories
                    string url = "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list";
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string jsonString = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject jsonResponse = JObject.Parse(jsonString);

                        // Extract the list of categories
                        JArray categories = (JArray)jsonResponse["drinks"];

                        // Populate the combo box with categories
                        foreach (JToken category in categories)
                        {
                            categoryComboBox.Items.Add(category["strCategory"]);
                        }

                        // Select the first category by default
                        if (categoryComboBox.Items.Count > 0)
                        {
                            categoryComboBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        // Handle the error if the request was not successful
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void PopulateDrinks(string category)
        {
            // Make API request to get drinks based on the selected category and populate the combo box
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make the API request to get drinks based on the selected category
                    string url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?c={category}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string jsonString = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject jsonResponse = JObject.Parse(jsonString);

                        // Extract the list of drinks
                        JArray drinks = (JArray)jsonResponse["drinks"];

                        // Clear the existing items in the drinks combo box
                        drinksComboBox.Items.Clear();

                        // Populate the combo box with drinks
                        foreach (JToken drink in drinks)
                        {
                            drinksComboBox.Items.Add(drink["strDrink"]);
                        }

                        // Select the first drink by default
                        if (drinksComboBox.Items.Count > 0)
                        {
                            drinksComboBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        // Handle the error if the request was not successful
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private async Task DisplayDrinkDetails(string drinkName)
        {
            // Make API request to get drink details and display them in the text boxes
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make the API request to get drink details based on the selected name
                    string url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={drinkName}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string jsonString = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JObject jsonResponse = JObject.Parse(jsonString);

                        // Extract the list of drinks
                        JArray drinks = (JArray)jsonResponse["drinks"];

                        // Get the first drink (assuming there's only one with the given name)
                        if (drinks.Count > 0)
                        {
                            JObject drink = (JObject)drinks[0];

                            // Display drink details in the text boxes
                            nameTextBox.Text = (string)drink["strDrink"];
                            typeTextBox.Text = (string)drink["strCategory"];
                            priceTextBox.Text = (string)drink["strInstructions"]; // Use any property you want

                            // Add additional text boxes for other properties as needed

                            // Load and display the thumbnail image
                            string thumbnailUrl = (string)drink["strDrinkThumb"];
                            LoadThumbnail(thumbnailUrl);
                        }
                    }
                    else
                    {
                        // Handle the error if the request was not successful
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void LoadThumbnail(string thumbnailUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make the API request to get the thumbnail image
                    byte[] imageBytes = await client.GetByteArrayAsync(thumbnailUrl);

                    // Convert the byte array to an Image object
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        Image thumbnailImage = Image.FromStream(ms);

                        // Set the thumbnail image in the PictureBox
                        thumbnailPictureBox.Image = thumbnailImage;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                MessageBox.Show($"An error occurred while loading the thumbnail: {ex.Message}");
            }


        }
    }
}

