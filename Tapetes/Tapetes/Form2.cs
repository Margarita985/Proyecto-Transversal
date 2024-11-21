/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 19/11/2024
 * Time: 03:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
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
		//toda esta parte sirve para captar los datos y poderlos mandar 
        //al form final el cual seria el Form5		
			string dato1=textBox1.Text;
			string dato2=textBox2.Text;
			string dato3=textBox3.Text;
			string dato4=textBox4.Text;
			string dato5=textBox5.Text;
			string dato6=textBox6.Text;
			string dato7=textBox7.Text;
			
			Form5 Resul= new Form5();
			
			Resul.Dato1Recibido=dato1;
			Resul.Dato2Recibido=dato2;
			Resul.Dato3Recibido=dato3;
			Resul.Dato4Recibido=dato4;
			Resul.Dato5Recibido=dato5;
			Resul.Dato6Recibido=dato6;
			Resul.Dato7Recibido=dato7;
			
			Resul.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form1 form1= new Form1();
			form1.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
		  
			
			
		}
	}
}
