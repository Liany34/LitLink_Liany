using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiscountCodes : BaseEntity
    {
        private string codeText;
        private DateTime? validUntil = null;
        private bool isActive;
        private int amount;

        public string CodeText { get => codeText; set => codeText = value; }
        public DateTime? ValidUntil { get => validUntil; set => validUntil = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int Amount { get => amount; set => amount = value; }

        public override string ToString()
        {
            return $"Code: {codeText}, Valid Until: {(validUntil.HasValue ? validUntil.Value.ToShortDateString() : "N/A")}, Active: {isActive}, Amount: {amount}";
        }
    }
}
