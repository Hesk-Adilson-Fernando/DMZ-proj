using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Planopagt
    {
        [Key]
        public string Planopagtstamp { get; set; }
        public string Planopagstamp { get; set; }
        public string Codcurso { get; set; }
        public string Codturma { get; set; }
        public string Descturma { get; set; }
        public string Turmastamp { get; set; }
        public virtual Planopag Planopag { get; set; }
    }
}