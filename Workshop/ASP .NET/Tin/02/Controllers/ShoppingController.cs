using Microsoft.AspNetCore.Mvc;

namespace Routing_Workshop.Controllers
{
    /**
     * These simplified e-commerce check-out process tasks are to help 
     * you reinforce the concepts about Action Results,
     * and apply them to generate HTTP Responses. 
     * 
     */
    public class ShoppingController : Controller
    {
        /**
         * Task 4a:
         * Create an action method that receives GET /Shopping/Checkout 
         * requests and generates an OK HTTT Response with an HTML 
         * checkout page. This method should ask the respective view 
         * to generate the page. The view is given at 
         * /Views/Shopping/Checkout.cshtml
         *
         */
        





        /**
         * Task 4b:
         * Create an action method that receives POST /Shopping/Checkout 
         * requests. It receives a paramerter, the delivery address. 
         * If the recieved address is not empty, it generates an Redirect 
         * HTTP Response to the payment page. Otherwise, the method will 
         * load the checkout page for users to enter again.
         */
        







        /**
         * Task 4c
         * Create an action method that recieves GET /Shopping/Payment 
         * requests and generate an OK HTTT Response with an HTML 
         * payment page. This method should ask a view to generate 
         * the page. The view is given at /Views/Shopping/PaymentGateway.cshtml
         */
        







        /**
         * Task 4d
         * Create an action method that receives POST /Shopping/Payment 
         * requests. If the payment information is correct, for example, 
         * the input name is "DipSA" is this simplified case, the method 
         * will redirect users to the order complete page. Otherwise, 
         * the method will load the payment page for users to enter again.
         */
        





        public IActionResult OrderComplete()
        {
            return View();
        }
    }
}
