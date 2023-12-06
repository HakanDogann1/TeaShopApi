using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtoLayer.DTOs
{
    public class UpdateQuestionDto
    {
        public int QuestionId { get; set; }
        public string QuestionDetail { get; set; }
        public string AnswerDetail { get; set; }
    }
}
