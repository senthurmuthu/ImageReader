﻿using System;
using Tesseract;

namespace ImageReader.Domain
{
	public class OCR
	{
		private String caminhoImagem;
		private String idioma;

		public void setImagem(String caminho)
		{
			this.caminhoImagem = caminho;
		}
		public void setIdioma(String linguagem)
		{
			this.idioma = linguagem;
		}

		public String extraiTextoImagem()
		{
			String textoImagem = "";
			string err = "";

			try
			{
				using (var engine = new TesseractEngine("C:/Users/Willyam/Desktop/OCR/ImageReader/ImageReader.Domain/bin/Debug/tessdata", idioma, EngineMode.Default))
				{
					using (var img = Pix.LoadFromFile(caminhoImagem))
					{
						using (var page = engine.Process(img))
						{
							textoImagem = page.GetText();
							//lbPrecisao.Text = Convert.ToString(page.GetMeanConfidence());
							return textoImagem;
						}
					}
				}
			}
			catch (Exception e)
			{
				if (e.InnerException != null) { err = e.InnerException.Message; }

			}
			return err;
		}

        public String ExtraiTxtUsingImg()
        {
            String textoImagem = "";
            string err = "";

            try
            {
                using (var engine = new TesseractEngine("C:/Users/Willyam/Desktop/OCR/ImageReader/ImageReader.Domain/bin/Debug/tessdata", idioma, EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(caminhoImagem))
                    {
                        using (var page = engine.Process(img))
                        {
                            textoImagem = page.GetText();
                            //lbPrecisao.Text = Convert.ToString(page.GetMeanConfidence());
                            return textoImagem;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e.InnerException != null) { err = e.InnerException.Message; }

            }
            return err;
        }
    }
}