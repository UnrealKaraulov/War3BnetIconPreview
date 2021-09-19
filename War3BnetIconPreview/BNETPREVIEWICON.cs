using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace War3BnetIconPreview
{
    public partial class BNETPREVIEWICON : Form
    {
        public BNETPREVIEWICON ( )
        {
            InitializeComponent( );
        }

        [DllImport( "user32.dll" )]
        static extern bool GetCursorPos ( ref Point lpPoint );

        [DllImport( "gdi32.dll" , CharSet = CharSet.Auto , SetLastError = true , ExactSpelling = true )]
        public static extern int BitBlt ( IntPtr hDC , int x , int y , int nWidth , int nHeight , IntPtr hSrcDC , int xSrc , int ySrc , int dwRop );


        Bitmap backgroundimage = null;
        Bitmap icobtn = null;
        Color latestselectedcolor = Color.Transparent;
        bool icoselected = false;

        // Выбор цвета фона
        private void BtnColorSelect_Click ( object sender , EventArgs e )
        {
            // Показать диалог выбора цвета
            SelectBackgroundColor.ShowDialog( );
            // Установить картинку заднего фона (загружается из ресурсов) размером 156х50
            backgroundimage = new Bitmap( Properties.Resources.previewbackground , 156 , 50 );
            // Начать использование Graphics на основе картинки backgroundimage
            using ( Graphics g = Graphics.FromImage( backgroundimage ) )
            {
                // Залить черным цветом
                g.FillRectangle(new SolidBrush(Color.Black),0,0,156,50);
                // Сохранить в latestselectedcolor выбранный цвет
                latestselectedcolor = SelectBackgroundColor.Color;
                // Очистить 
                g.Clear( Color.Transparent );
                IconPreview.BackColor = latestselectedcolor;
                iCONselect.BackColor = SelectBackgroundColor.Color;
                colorpicker.BackColor = SelectBackgroundColor.Color;
                g.DrawImageUnscaled( Properties.Resources.previewbackground , 0 , 7 );
                if ( icoselected )
                {
                    g.DrawImage( iCONselect.BackgroundImage , 5 , 0 , 64 , 50 );
                }
                IconPreview.BackgroundImage = backgroundimage;
            }

        }

        private void BNETPREVIEWICON_Load ( object sender , EventArgs e )
        {
            latestselectedcolor = IconPreview.BackColor;
        }

        private void label1_Click ( object sender , EventArgs e )
        {
            Environment.Exit( 0 );
        }

        private void BtnIconSelect_Click ( object sender , EventArgs e )
        {
            OpenFileDialog fdial = new OpenFileDialog( );
            fdial.Filter = "All bitmap files|*.bmp;*.png;*.jpg;*.jpeg|bmp|*.bmp|jpg|*.jpg|jpg|*.jpeg|png|*.png";
            if ( fdial.ShowDialog( ) == System.Windows.Forms.DialogResult.OK )
            {
                if ( icobtn != null )
                {
                    icobtn.Dispose( );
                    icobtn = null;
                }

                icobtn = ( Bitmap ) Image.FromFile( fdial.FileName );
                icobtn = new Bitmap( icobtn , 64 , 64 );
                icoselected = true;
                iCONselect.BackgroundImage = new Bitmap( icobtn );
            }
        }

        private void BtnColorSelectIconTransparent_Click ( object sender , EventArgs e )
        {
            SelectBackgroundColor.ShowDialog( );
            if ( icobtn != null )
            {
                
                Bitmap tmpbitmap = new Bitmap( icobtn , 64 , 64 );
                int red = SelectBackgroundColor.Color.R;
                int green = SelectBackgroundColor.Color.G;
                int blue = SelectBackgroundColor.Color.B;
                
                for ( int x = 0 ; x < tmpbitmap.Width ; x++ )
                {
                    for ( int y = 0 ; y < tmpbitmap.Height ; y++ )
                    {
                        Color curpix = tmpbitmap.GetPixel( x , y );
                        int power = TransparentPower.Value;
                        int curred = curpix.R;
                        int curgreen = curpix.G;
                        int curblue = curpix.B;

                        if (SelectPowerType.SelectedIndex == -1 || SelectPowerType.SelectedIndex == 0)
                        {
                            if (red - power <= curred && red + power >= curred && green - power <= curgreen && green + power >= curgreen && blue - power <= curblue && blue + power >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                        else if (SelectPowerType.SelectedIndex == 1)
                        {
                            if (red <= curred && red + power >= curred && green <= curgreen && green + power >= curgreen && blue <= curblue && blue + power >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                        else if (SelectPowerType.SelectedIndex == 2 )
                        {
                            if (red - power <= curred && red >= curred && green - power <= curgreen && green >= curgreen && blue - power <= curblue && blue >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                    }
                }


                iCONselect.BackgroundImage = tmpbitmap;

            }


        }

        private void TransparentPower_Scroll ( object sender , EventArgs e )
        {
            if ( icobtn != null )
            {

                Bitmap tmpbitmap = new Bitmap( icobtn , 64 , 64 );
                int red = SelectBackgroundColor.Color.R;
                int green = SelectBackgroundColor.Color.G;
                int blue = SelectBackgroundColor.Color.B;

                for ( int x = 0 ; x < tmpbitmap.Width ; x++ )
                {
                    for ( int y = 0 ; y < tmpbitmap.Height ; y++ )
                    {
                        Color curpix = tmpbitmap.GetPixel( x , y );
                        int power = TransparentPower.Value;
                        int curred = curpix.R;
                        int curgreen = curpix.G;
                        int curblue = curpix.B;

                        if (SelectPowerType.SelectedIndex == -1 || SelectPowerType.SelectedIndex == 0)
                        {
                            if (red - power <= curred && red + power >= curred && green - power <= curgreen && green + power >= curgreen && blue - power <= curblue && blue + power >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                        else if (SelectPowerType.SelectedIndex == 1)
                        {
                            if (red <= curred && red + power >= curred && green <= curgreen && green + power >= curgreen && blue <= curblue && blue + power >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                        else if (SelectPowerType.SelectedIndex == 2)
                        {
                            if (red - power <= curred && red >= curred && green - power <= curgreen && green >= curgreen && blue - power <= curblue && blue >= curblue)
                            {
                                tmpbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }

                    }
                }

                iCONselect.BackgroundImage = tmpbitmap;

            }
        }

        private void timer1_Tick ( object sender , EventArgs e )
        {
            TransparentPower_Scroll( sender , e );
            backgroundimage = new Bitmap( Properties.Resources.previewbackground , 156 , 50 );
            using ( Graphics g = Graphics.FromImage( backgroundimage ) )
            {
                g.FillRectangle( new SolidBrush( Color.Black ) , 0 , 0 , 156 , 50 );
                g.Clear( Color.Transparent );
                IconPreview.BackColor = latestselectedcolor;
                iCONselect.BackColor = SelectBackgroundColor.Color;
                g.DrawImageUnscaled( Properties.Resources.previewbackground , 0 , 7 );
                if ( icoselected )
                {
                    g.DrawImage( iCONselect.BackgroundImage , 5 , 0 , 64 , 50 );
                }
                IconPreview.BackgroundImage = backgroundimage;
            }
        }

        private void BtnSaveIcon_Click ( object sender , EventArgs e )
        {
            SaveFileDialog sdial = new SaveFileDialog( );
            sdial.FileName = "ResultIcon.png";
            if (sdial.ShowDialog( ) == System.Windows.Forms.DialogResult.OK)
            {
                iCONselect.BackgroundImage.Save( sdial.FileName , ImageFormat.Png );
            }

        }

        private void label4_Click ( object sender , EventArgs e )
        {
            ColorPickTimer.Start( );
        }

        private void BNETPREVIEWICON_MouseDown ( object sender , MouseEventArgs e )
        {
            ColorPickTimer.Stop( );
            SelectBackgroundColor.Color = colorpicker.BackColor;
        }

        Bitmap screenPixel = new Bitmap( 1 , 1 , PixelFormat.Format32bppArgb );
        public Color GetColorAt ( Point location )
        {
            using ( Graphics gdest = Graphics.FromImage( screenPixel ) )
            {
                using ( Graphics gsrc = Graphics.FromHwnd( IntPtr.Zero ) )
                {
                    IntPtr hSrcDC = gsrc.GetHdc( );
                    IntPtr hDC = gdest.GetHdc( );
                    int retval = BitBlt( hDC , 0 , 0 , 1 , 1 , hSrcDC , location.X , location.Y , ( int ) CopyPixelOperation.SourceCopy );
                    gdest.ReleaseHdc( );
                    gsrc.ReleaseHdc( );
                }
            }

            return screenPixel.GetPixel( 0 , 0 );
        }

        private void ColorPickTimer_Tick ( object sender , EventArgs e )
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            var c = GetColorAt(cursor);
            colorpicker.BackColor = c;
        }
    }
}
