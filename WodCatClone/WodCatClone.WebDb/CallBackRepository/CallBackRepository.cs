﻿using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.WebDb.CallBackRepository
{
    public class CallBackRepository : ICallBackRepository
    {
        private readonly WodCatCloneContext _context;

        public CallBackRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Question>> GetAllQuestionsAsync()
        {
            return await _context.Question.ToListAsync();
        }

        public async Task<Answer?> GetAnswerAsync(int id)
        {
            return await _context.Answer.FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
