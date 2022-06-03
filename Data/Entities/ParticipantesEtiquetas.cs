using Data.Context;
using Data.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utils.Enums;

namespace Data.Entities
{
    public class ParticipantesEtiquetas : UsuarioBase
    {
        [Key]
        public int Id { get; set; }
        public int EtiquetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public int? ParticipanteId { get; set; }
        public Participante Participante { get; set; }
        public int? EquipanteId { get; set; }
        public Equipante Equipante { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}