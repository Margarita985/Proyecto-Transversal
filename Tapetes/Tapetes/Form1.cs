/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 17/11/2024
 * Time: 09:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		
		
		public Form1()
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
			Circular cir= new Circular();
			cir.Show();
			this.Hide();
			
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Cuadrado cuadrado= new Cuadrado();
			cuadrado.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Rectangular rec= new Rectangular();
			rec.Show();
		}
	}
}
