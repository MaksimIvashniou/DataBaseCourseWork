using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WeldingMachines
{
    public class ModelOfWeldingMachine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ModelCharacteristicId { get; set; }

        [ForeignKey("ModelCharacteristicId")]
        public virtual ModelCharacteristic ModelCharacteristic { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<WeldingMachine> WeldingMachines { get; set; }
    }
}
