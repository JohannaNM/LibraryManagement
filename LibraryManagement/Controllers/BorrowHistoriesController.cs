using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
    public class BorrowHistoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BorrowHistoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BorrowHistories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BorrowHistories.Include(b => b.Book).Include(b => b.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BorrowHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowHistory = await _context.BorrowHistories
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .FirstOrDefaultAsync(m => m.BorrowHistoryId == id);
            if (borrowHistory == null)
            {
                return NotFound();
            }

            return View(borrowHistory);
        }

        // GET: BorrowHistories/Create

        public IActionResult Create(int? id)
        {
            if (id == null)
            { return NotFound(); }
            
            var book = _context.Books.Find(id);
            if (book == null)
            { return NotFound(); }

            var borrowHistory = new BorrowHistory { FkBookId = book.BookId, BorrowDate = DateTime.Now, Book = book }; 
            ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title");
            ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName");
            return View(borrowHistory);
        }

        //public IActionResult Create()
        //{
        //    ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title");
        //    ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName");
        //    return View();
        //}

        // POST: BorrowHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorrowHistoryId,FkBookId,FkCustomerId,BorrowDate")] BorrowHistory borrowHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrowHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title", borrowHistory.FkBookId);
            ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", borrowHistory.FkCustomerId);
            borrowHistory.Book = _context.Books.Find(borrowHistory.FkBookId);
            return View(borrowHistory);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("BorrowHistoryId,FkBookId,FkCustomerId,BorrowDate")] BorrowHistory borrowHistory)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(borrowHistory);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title", borrowHistory.FkBookId);
        //    ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", borrowHistory.FkCustomerId);
        //    return View(borrowHistory);
        //}

        // GET: BorrowHistories/Edit/5

        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    BorrowHistory borrowHistory = _context.BorrowHistories
        //        .Include(b => b.Book)
        //        .Include(c => c.Customer)
        //        .Where(b => b.FkBookId == id && b.ActualReturnDate == null)
        //        .FirstOrDefault();
        //    if (borrowHistory == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title", borrowHistory.FkBookId);
        //    ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", borrowHistory.FkCustomerId);
        //    return View(borrowHistory);

        //    //var borrowHistory = await _context.BorrowHistories.FindAsync(id);
        //    //if (borrowHistory == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title", borrowHistory.FkBookId);
        //    //ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", borrowHistory.FkCustomerId);
        //    //return View(borrowHistory);
        //}

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowHistory = await _context.BorrowHistories.FindAsync(id);
            if (borrowHistory == null)
            {
                return NotFound();
            }
            ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title", borrowHistory.FkBookId);
            ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerName", borrowHistory.FkCustomerId);
            return View(borrowHistory);
        }

        // POST: BorrowHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("BorrowHistoryId,FkBookId,FkCustomerId,BorrowDate,ActualReturnDate")] BorrowHistory borrowHistory)
        //{
        //    if (id != borrowHistory.BorrowHistoryId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var borrowHistoryItem = _context.BorrowHistories.Include(i => i.Book)
        //           .FirstOrDefault(i => i.BorrowHistoryId == borrowHistory.BorrowHistoryId);
        //            if (borrowHistoryItem == null)
        //            { return NotFound(); }
        //            borrowHistoryItem.ActualReturnDate = DateTime.Now;
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BorrowHistoryExists(borrowHistory.BorrowHistoryId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Author", borrowHistory.FkBookId);
        //    ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerEmail", borrowHistory.FkCustomerId);
        //    return View(borrowHistory);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BorrowHistoryId,FkBookId,FkCustomerId,BorrowDate,ActualReturnDate")] BorrowHistory borrowHistory)
        {
            if (id != borrowHistory.BorrowHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowHistoryExists(borrowHistory.BorrowHistoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Author", borrowHistory.FkBookId);
            ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerEmail", borrowHistory.FkCustomerId);
            return View(borrowHistory);
        }

        // GET: BorrowHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowHistory = await _context.BorrowHistories
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .FirstOrDefaultAsync(m => m.BorrowHistoryId == id);
            if (borrowHistory == null)
            {
                return NotFound();
            }

            return View(borrowHistory);
        }

        // POST: BorrowHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var borrowHistory = await _context.BorrowHistories.FindAsync(id);
            if (borrowHistory != null)
            {
                _context.BorrowHistories.Remove(borrowHistory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowHistoryExists(int id)
        {
            return _context.BorrowHistories.Any(e => e.BorrowHistoryId == id);
        }
    }
}
