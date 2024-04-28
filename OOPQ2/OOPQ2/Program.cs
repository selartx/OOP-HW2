/****************************************************************************
**					        SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				        BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          Object Oriented Programming
**	
**				ÖDEV NUMARASI:OOPHW2
**				ÖÐRENCÝ ADI:Selva Artunç
**				ÖÐRENCÝ NUMARASI:Homework 2
**				DERS GRUBU:1/C
****************************************************************************/
namespace OOPQ2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}