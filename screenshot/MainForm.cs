/*
 * Created by SharpDevelop.
 * User: KServ
 * Date: 15.02.2021
 * Time: 14:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace screenshot
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			try{	
		       Bitmap captureBitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format64bppPArgb);		
		       Rectangle captureRectangle = Screen.AllScreens[0].Bounds;		
	           Graphics captureGraphics = Graphics.FromImage(captureBitmap);		
		       captureGraphics.CopyFromScreen(captureRectangle.Left,captureRectangle.Top,0,0,captureRectangle.Size);		
		       captureBitmap.Save(@"C:\Users\KServ\Desktop\192837\screenshots\screenshot1.jpg",ImageFormat.Jpeg);
			   MessageBox.Show("Screen Captured");
		
		    }catch (Exception ex){
		        MessageBox.Show(ex.Message);
		    }
		}
	}
}
