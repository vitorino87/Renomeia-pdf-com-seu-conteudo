using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Converte_PDF_Texto
{
    public partial class Form1 : Form
    {
		public List<String> fqn = new List<string>();
		List<String> SubDirs = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertePDF_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
			fqn.Clear();			
			DialogResult dr2 = folderBrowserDialog1.ShowDialog();
			fqn.Add(folderBrowserDialog1.SelectedPath);						
			inFolder(fqn);            
        }

		private List<string> GetOthersFolder(string folder)
		{
			try
			{
				List<string> dir = Directory.GetDirectories(folder).ToList<string>();
				return dir;
			}catch (Exception e)
			{ return null; }			
		}

		private void inFolder(List<string> list)
		{
			foreach(String s in list)
			{
				List<string> a = GetOthersFolder(s);
				if (a != null)
				{
					inFolder(a); //pilha				
					moveFile(s);
				}
			}
		}

		private void moveFile(String s)
		{
			List<string> b = Directory.GetFiles(s).ToList<string>();
			int cont = 1;
			Boolean t = false;
			foreach (String c in b)
			{
				if (c.Contains(".pdf"))
				{
					//char[] k = "\\".ToCharArray();
					//string[] a = c.Split(k);
					//string h = a.Last<string>();

					try
					{																		
						Directory.Move(c, fqn[0] + "\\" + GetNewName(c) + ".pdf");						
					}
					catch (System.IO.IOException e)
					{
						try
						{
							Directory.Move(c, fqn[0] + "\\" + GetNewName(c) + "(" + cont++ + ")" + ".pdf");
						}
						catch(System.IO.IOException f)
						{
							t = true;
						}
						
					}
				}					 																	
			}
			if (t)
			{
				MessageBox.Show("Não foi possível alterar alguns titulos (já estavam alterados)");
			}
		}

		private String GetNewName(String s)
		{
			ConvertePDF pdftxt = new ConvertePDF();
			String titulo = pdftxt.ExtrairTexto_PDF(s).Substring(0,30);
			titulo = titulo.Replace("\n","%");
			return titulo;
		}

		
	}
}
