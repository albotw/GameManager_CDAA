using projet_CDAA_2020_2021.core.jeux;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace GUI
{
    public class PhotoList
    {
        private Dictionary<Jeu, Image> photosJeux;
        private Dictionary<Console, Image> photosConsoles;

        public PhotoList()
        {
            this.photosConsoles = new Dictionary<Console, Image>();
            this.photosJeux = new Dictionary<Jeu, Image>();
        }

        public void Add(object obj, Image photo)
        {
            if (obj.GetType().Equals(typeof(Jeu)))
            {
                photosJeux.Add(obj as Jeu, photo);
            }
            else if (obj.GetType().Equals(typeof(Console)))
            {
                photosConsoles.Add(obj as Console, photo);
            }
        }

        public void Remove(object obj)
        {
            if (obj.GetType().Equals(typeof(Jeu)))
            {
                photosJeux.Remove(obj as Jeu);
            }
            else if (obj.GetType().Equals(typeof(Console)))
            {
                photosConsoles.Remove(obj as Console);
            }
        }

        public Dictionary<Jeu, Image>.ValueCollection GetAllPhotosJeux()
        {
            return photosJeux.Values;
        }

        public Dictionary<Console, Image>.ValueCollection GetAllPhotosConsoles()
        {
            return photosConsoles.Values;
        }

        public Image GetPhotoJeu(Jeu j)
        {
            
        }
    }
}
