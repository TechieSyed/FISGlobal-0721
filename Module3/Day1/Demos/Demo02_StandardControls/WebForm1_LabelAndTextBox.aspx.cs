﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm1_LabelAndTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            int length = txtName.Text.Length;
            lblCount.Text = length.ToString();
        }
    }
}