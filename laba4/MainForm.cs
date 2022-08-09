/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 22-03-2019
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			GenerateMass();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		parall[] p = new parall[10];
		
		void GenerateMass()
		{
			for (int i = 0; i <10; i++) {
				p[i] = new parall();
			}
		}
		private void Button3Click(object sender, EventArgs e)
		{
			try {
				int n = listBox1.SelectedIndex;
				p[n].setA(Convert.ToDouble(textBox1.Text));
				p[n].setB(Convert.ToDouble(textBox2.Text));
				p[n].setC(Convert.ToDouble(textBox3.Text));
				listBox1.Items.Clear();
				for (int i = 0; i < 10; i++ )
				{
					listBox1.Items.Add("Объект " + (i + 1)
					                   +" A: " +p[i].getA().ToString()
					                   +" B: " +p[i].getB().ToString()
					                   +" C: " +p[i].getC().ToString()
					                   +" P: " +p[i].ploschad().ToString()
					                   +" O: " +p[i].obem().ToString());
				}
			}
			catch (IndexOutOfRangeException)
			{
				MessageBox.Show ("Выберите объект ");
			}
			
		}
		private void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			for (int i = 0; i < 10; i++) {
				listBox1.Items.Add("Объект " + (i + 1)
				            		   + "A: " +p[i].getA().ToString()
					                   +" B: " +p[i].getB().ToString()
					                   +" C: " +p[i].getC().ToString()
					                   +" P: " +p[i].ploschad().ToString()
					                   +" O: " +p[i].obem().ToString());
			}
		}
		private void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	private	void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		 
	}
	class parall
	{ 
		private double a, b, c;
		
		public double getA() { return a;}
		public double getB() { return b;}
		public double getC() { return c;}
		
		public void setA (double x)
		{
			if (x > 0)
				a = x;
			else 
				MessageBox.Show("Отрицательное число");
		}
		public void setB (double x)
		{
			if (x > 0)
				b = x;
			else 
				MessageBox.Show("Отрицательное число");
		}
		public void setC (double x)
		{
			if (x > 0)
				c = x;
			else 
				MessageBox.Show("Отрицательное число");
		}
		
		public parall (double aa, double bb, double cc) {a = aa; b = bb; c = cc;}
		public parall () {a = 3; b = 4; c = 5;}

		public double ploschad () {return 2*getC()*(getA()+getB());}
		public double obem () {return getA()*getB()*getC();}
		}
}

