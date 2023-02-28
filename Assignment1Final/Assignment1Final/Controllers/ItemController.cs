using Assignment1Final.Models;
using Microsoft.AspNetCore.Mvc;

public class ItemController : Controller
{
    // Manage the items that are created and listed by the controller
    private readonly List<Item> _items = new List<Item>();

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // Creates the item with an image
    [HttpPost]
    public IActionResult Create(Item item, IFormFile image)
    {
        if (ModelState.IsValid)
        {
            // Save the image to the item's Image property as a byte array.
            using (var ms = new MemoryStream())
            {
                image.CopyTo(ms);
                item.Image = ms.ToArray();
            }

            // Set the seller's username.
            item.SellerUsername = User.Identity.Name;

            _items.Add(item);

            return RedirectToAction("Index", "Home");
        }

        return View(item);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        // Checks if the id and seller user is equal to id and a username
        var item = _items.FirstOrDefault(i => i.Id == id && i.SellerUsername == User.Identity.Name);

        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }

    [HttpPost]
    public IActionResult Edit(Item item, IFormFile image)
    {
        // Updates the existing item's properties and image
        var existingItem = _items.FirstOrDefault(i => i.Id == item.Id && i.SellerUsername == User.Identity.Name);

        if (existingItem == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            // If a new image was uploaded, save it to the item's image property as a byte array.
            if (image != null)
            {
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    item.Image = ms.ToArray();
                }
            }

            // Update the item's properties.
            existingItem.Name = item.Name;
            existingItem.Description = item.Description;
            existingItem.MinimumBidAmount = item.MinimumBidAmount;
            existingItem.StartBidDate = item.StartBidDate;
            existingItem.EndBidDate = item.EndBidDate;
            existingItem.Condition = item.Condition;
            existingItem.Category = item.Category;

            return RedirectToAction("Index", "Home");
        }

        return View(item);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        // Checks if the id and seller user is equal to id and a username and deletes it
        var item = _items.FirstOrDefault(i => i.Id == id && i.SellerUsername == User.Identity.Name);

        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }
    // Returns a view for displaying the details of the item.
    public IActionResult Details(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);

        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }

    [HttpGet]
    public IActionResult Search(string searchString, string category, string sortBy)
    {
        // Filter items by search string and/or category
        var filteredItems = _items.Where(item =>
            (string.IsNullOrEmpty(searchString) ||
                item.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(category) || item.Category == category)
        );

        // Sort items by the selected sort option
        switch (sortBy)
        {
            case "name":
                filteredItems = filteredItems.OrderBy(item => item.Name);
                break;
            case "bidAmount":
                filteredItems = filteredItems.OrderBy(item => item.MinimumBidAmount);
                break;
            case "endDate":
                filteredItems = filteredItems.OrderBy(item => item.EndBidDate);
                break;
            default:
                break;
        }

        // Create view model for search results
        var viewModel = new Search
        {
            SearchString = searchString,
            Category = category,
            SortBy = sortBy,
            Items = filteredItems.ToList()
        };

        return View(viewModel);
    }

}