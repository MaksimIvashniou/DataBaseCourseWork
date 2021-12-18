using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WeldingMachines
{
    public class ModelCharacteristic
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("ModelOfWeldingMachineId")]
        public virtual ModelOfWeldingMachine ModelOfWeldingMachine { get; set; }

        [Required]
        public int ModelOfWeldingMachineId { get; set; }

        #endregion Keys

        [Required]
        public int MinVoltage { get; set; }

        [Required]
        public int MinCurrent { get; set; }

        [Required]
        public int MaxVoltage { get; set; }

        [Required]
        public int MaxCurrent { get; set; }

        [Required]
        public int MaxPowerConsuption { get; set; }

        #endregion DB columns
    }
}
