using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WManufacture.Common.Entity.Companies.WeldingMachines
{
    public class ModelOfWeldingMachine
    {
        #region DB columns

        #region Keys

        [Key]
        public int Id { get; set; }

        [ForeignKey("ModelCharacteristicId")]
        public virtual ModelCharacteristic ModelCharacteristic { get; set; }

        [Required]
        public int ModelCharacteristicId { get; set; }

        #endregion Keys

        [Required]
        public string Name { get; set; }

        #endregion DB columns

        public virtual List<WeldingMachine> WeldingMachines { get; set; }
    }
}
