using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method that gets executed when we double click the Server Control Click Me Button (Event)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void okButton_Click(object sender, EventArgs e)
        {
            //Declaring & assigning the firstName variable which holds whatever alpha numeric
            // charcters an end user has input into the textbox Property  'firstNameTextBox.Text'
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            // Declaring & assigning variable of type string and assigning it the concatenated values 
            string result = "Hello" + firstName + " " + lastName;
            resultLabel.Text = result;
        }
    }
}