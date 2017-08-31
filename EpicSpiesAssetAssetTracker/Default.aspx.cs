using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpiesAssetAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetArray = new string[0];
                ViewState.Add("Asset Array", assetArray);

                double[] electionsArray = new double[0];
                ViewState.Add("Elections Array", electionsArray);

                double[] actsArray = new double[0];
                ViewState.Add("Acts Array", actsArray);

            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assetArray = (string[])ViewState["Asset Array"];
            Array.Resize(ref assetArray, assetArray.Length + 1);
            int newAsset = assetArray.GetUpperBound(0);
            assetArray[newAsset] = assetNameTextbox.Text;
            ViewState["Asset Array"] = assetArray;

            double[] electionsArray = (double[])ViewState["Elections Array"];
            Array.Resize(ref electionsArray, electionsArray.Length + 1);
            int newElection = electionsArray.GetUpperBound(0);
            electionsArray[newElection] = double.Parse(electionsRiggedTextbox.Text);
            ViewState["Elections Array"] = electionsArray;

            double[] actsArray = (double[])ViewState["Acts Array"];
            Array.Resize(ref actsArray, actsArray.Length + 1);
            int newAct = actsArray.GetUpperBound(0);
            actsArray[newAct] = double.Parse(subterfugeTextBox.Text);
            ViewState["Acts Array"] = actsArray;

            //string lastAsset = assetArray[assetArray.GetUpperBound(0)];

            resultLabel.Text = String.Format("Total Elections Rigged: {0}" +
                "<br />Average Acts of Subterfuge per Asset: {1:N}" +
                "<br />(Last Asset you Added: {2})",
                electionsArray.Sum(),
                actsArray.Average(),
                assetArray[assetArray.GetUpperBound(0)]);

        }
    }
}