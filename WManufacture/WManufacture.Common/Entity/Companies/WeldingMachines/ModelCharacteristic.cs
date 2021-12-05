using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WeldingMachines
{
    public class ModelCharacteristic
    {
        [Key]
        public int Id { get; set; }

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

        [Required]
        public int ModelOfWeldingMachineId { get; set; }

        [ForeignKey("ModelOfWeldingMachineId")]
        public virtual ModelOfWeldingMachine ModelOfWeldingMachine { get; set; }
    }
}
