using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject_cooperatingcrows
{
    public partial class gauthiaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Invokes MinFlips in the class BinaryMatrixFlipper and returns the solution on button press.
        /// </summary>
        /// <param name="sender"> contains a reference to the object</param>
        /// <param name="e"> Contains the event data </param>
        protected void bnSolveBinaryMatrixFlipper_Click(object sender, EventArgs e)
        {
            BinaryMatrixFlipper BinaryMatrixFlipper = new BinaryMatrixFlipper();
            int[][] mat = new int[2][];
            mat[0] = new int[] { 0, 0 };
            mat[1] = new int[] { 0, 1 };
            int numflips = BinaryMatrixFlipper.MinFlips(mat);
            lblBinaryMatrixFlipperSolution.Text = "The number of flips required is " + numflips.ToString();
        }
    }
}