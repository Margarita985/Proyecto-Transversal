/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 20/11/2024
 * Time: 08:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Circular.
	/// </summary>
	public partial class Circular : Form
	{
		public Circular()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form2 form2=new Form2();
			form2.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form1 form1= new Form1();
			form1.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			double radio;
            if (double.TryParse(textBox3.Text, out radio))
            {
                double area = Math.PI * Math.Pow(radio, 2);
                

                label4.Text = "Área: " + area.ToString("F2");
            }
            else
            {

                MessageBox.Show("Por favor, ingrese un valor numérico válido para el radio.");
            }
		}
	}
}
