# SportsStore
Chapter 12, 
I'm not sure how the identityUser works or the Roles. I don't like the razer pages. i like the controller to models. I think Microsoft made a cool way of using controllers. But I don't think it'll stick around. They will keep changing it. MVC model has been around since the 70's. It's tried and true in my opinion. 


Chapter 11
One thing I notice was the controller and methods in a class. I found it interesting that the controller is mostly just passing data back and forth bewteen the controller. And if a model needs to make a change the controller pass in info to the class and the method of that class makes the chnage. I always was thinking that the controller did all the moving and changing. EFRepository has a save function and delete function. 
[HttpPost]
        public IActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId); //function in the EFrepostitory
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
        It's a function in a controller calling another function outsides of its domain. It's just passing information. This makes a lot more sense to me after this chapter. Contrllers move things. 
        My question: When do you make the line of what the controller to do? Am I correct in what I'm thinking here?





A redo of chapter 8 and 9
What have an IOrderRepository? I thought this was an Interface and it was just a contract. This has been confusing because the interface holds data.
What is the difference bewteen migration and update data base? Are they both meant to update the whole database in 2 steps?
What does AddTransient do?
Again, what is the Dbset<Orders> do in the ApplicationsDbCOntext?
