/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 20/11/2024
 * Time: 08:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Cuadrado.
	/// </summary>
	public partial class Cuadrado : Form
	{
		public Cuadrado()
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

            double lado;
            if (double.TryParse(textBox1.Text, out lado))
            {

                double area = Math.Pow(lado, 2);
                

                label4.Text = "Área: " + area.ToString("F2");
            }
            else
            {

                MessageBox.Show("Por favor, ingrese un valor numérico válido para el lado.");
            }
		}
	}
}
