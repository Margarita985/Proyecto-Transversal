/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 20/11/2024
 * Time: 08:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Rectangular.
	/// </summary>
	public partial class Rectangular : Form
	{
		public Rectangular()
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
			double baseRectangulo, alturaRectangulo;

            bool esBaseValida = double.TryParse(textBox1.Text, out baseRectangulo);
            bool esAlturaValida = double.TryParse(textBox3.Text, out alturaRectangulo);

            if (esBaseValida && esAlturaValida)
            {

                double area = baseRectangulo * alturaRectangulo;
                

                label4.Text = "Área: " + area.ToString("F2");
            }
            else
            {

                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la base y la altura.");
            }
		}
	}
}
