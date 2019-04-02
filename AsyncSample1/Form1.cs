/*
 * 
 *  Source codes under this project is licensed under MIT Project.
 *  Created by: Mirza Ghulam Rasyid
 * 
 * 
 */

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AsyncSample1
{
    public partial class Form1 : Form
    {
        public HashWorker HashWorker { get; set; }
        public Form1()
        {
            InitializeComponent();
            HashWorker = new HashWorker();
        }
        private void ToggleControlsEnabled(bool enabled)
        {
            if (enabled)
            {

                TextBoxHash.Enabled = true;
                ButtonAsyncInvoke.Enabled = true;
                ButtonNonAsyncInvoke.Enabled = true;
            }
            else
            {

                TextBoxHash.Enabled = false;
                ButtonAsyncInvoke.Enabled = false;
                ButtonNonAsyncInvoke.Enabled = false;
            }
        }


        private async void ButtonAsyncInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxResult.Text = "";
                ToggleControlsEnabled(false);
                string text = TextBoxHash.Text;
                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Please fill the text to hash!");
                }
                else
                {
                    //Call the heavy-processing method using wrapper method
                    //that has been modified using async call.
                    //Don't forget to add 'async' keyword to your event-handler!
                    string result = await AsyncHashInvocation(text);
                    TextBoxResult.Text = result;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ToggleControlsEnabled(true);
            }
        }

        private void ButtonNonAsyncInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxResult.Text = "";
                ToggleControlsEnabled(false);
                string text = TextBoxHash.Text;
                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Please fill the text to hash!");
                }
                else
                {
                    //No async wrapper. It will cause freeze in your UI :p
                    string result = HashWorker.HashData(text);
                    TextBoxResult.Text = result;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ToggleControlsEnabled(true);

            }
        }



        #region Methods Wrapper
        public async Task<string> AsyncHashInvocation(string text)
        {
            return await Task.Run<string>(() => HashWorker.HashData(text));
        }
        
        #endregion
    }
}
