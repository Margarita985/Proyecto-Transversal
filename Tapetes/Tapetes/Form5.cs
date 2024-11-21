/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 19/11/2024
 * Time: 04:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		//aqui recibe los datos del form2
		public string Dato1Recibido{get; set;}
		public string Dato2Recibido{get; set;}
		public string Dato3Recibido{get; set;}
		public string Dato4Recibido{get; set;}
		public string Dato5Recibido{get; set;}
		public string Dato6Recibido{get; set;}
		public string Dato7Recibido{get; set;}
		
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Form5Load(object sender, EventArgs e)
		{
			
			//en esta parte al momento de ya tener todos los datos, lo que se hace es declarar cada cosa con 
			// su precio respectivo y se multiplica por el dato ingresado en el form 2
			int num1=int.Parse(Dato1Recibido);
			int num2=int.Parse(Dato2Recibido);
			int num3=int.Parse(Dato3Recibido);
			int num4=int.Parse(Dato4Recibido);
			int num5=int.Parse(Dato5Recibido);
			int num6=int.Parse(Dato6Recibido);
			int num7=int.Parse(Dato7Recibido);
			
			int BultoAserrin=200;
			int resul1=num1*BultoAserrin;
			
			int litrosPintura=160;
			int relul2=num2*litrosPintura;
			
			int Frutos=280;
			int resul3=num3*Frutos;
			
			int flores=380;
			int resul4=num4*flores;
			
			int Agua=5;
			int result5=num5*Agua;
			
			int ComidaPersonas=150;
			int resul6=num6*ComidaPersonas;
			
			int manodehobra=75;
			int resul7=num7*manodehobra;
			
			//aqui solo se suma todo y el resultado se imprime en un label
			int suma=resul1+relul2+resul3+resul4+result5+resul6+resul7;
				
			label2.Text="$"+suma; 
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//esto nos sirve para cuando se aprete el boton salir automaticamente se 
			// sierre la bentana
			foreach (Form form in Application.OpenForms)
				if(form != this)
			{
				form.Close();
			}
			Application.Exit();
		}
		
	}
}
