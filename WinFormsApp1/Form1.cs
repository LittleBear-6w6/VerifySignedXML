using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;



namespace WinFormsApp1
{
	public partial class VerifyXMLtool : Form
	{
		public VerifyXMLtool()
		{
			InitializeComponent();
		}

		private void openFileButton_Click (object sender, EventArgs e)
		{
			string docPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = docPath;
			ofd.Title = "開くファイルを選択してください";
			ofd.RestoreDirectory = true;
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				FileName.Text = ofd.FileName;
			}
		}

		private void verfyXML_Click(object sender, EventArgs e)
		{
			verfy(FileName.Text);
		}

		public static void verfy(string signedXmlFilename)
		{
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.PreserveWhitespace = true;
				xmlDoc.Load(signedXmlFilename);

				bool result = VerifyXml(xmlDoc);
				if (result)
				{
					MessageBox.Show("検証正常！", "検証結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("検証異常！", "検証結果", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "異常終了", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static Boolean VerifyXml(XmlDocument doc)
		{
			SignedXml signedXml = new SignedXml(doc);
			XmlNodeList nodeList = doc.GetElementsByTagName("Signature");
			if(nodeList.Count <= 0)
			{
				throw new CryptographicException("検証エラー！<Signature>タグがありません。");
			}
			if (nodeList.Count >= 2)
			{
				throw new CryptographicException("検証エラー！<Signature>タグが2個以上あります。");
			}

			signedXml.LoadXml((XmlElement)nodeList[0]);
			return signedXml.CheckSignature();
		}

		private void closeApp_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
