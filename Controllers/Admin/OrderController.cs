using Microsoft.AspNetCore.Mvc;
using PRN211_ShoesStore.Models;
using PRN211_ShoesStore.Service.vH.Interface;
using System.Collections.Generic;
using System;
using PRN211_ShoesStore.Service.vH;
using PRN211_ShoesStore.Repository.vH.Interface;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Models.DTO;

namespace PRN211_ShoesStore.Controllers.Admin
{
    [Route("Admin/Order")]

    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderRepository _orderRepository;

		public OrderController(IOrderService orderService, IOrderDetailService orderDetailService, IOrderRepository orderRepository)
		{
			_orderService = orderService;
			_orderDetailService = orderDetailService;
			_orderRepository = orderRepository;
		}

		public IActionResult Index()
        {
            var orders = _orderService.GetAllOrder();
            return View("/ViewsAdmin/Order/Index.cshtml", orders);
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var order = _orderRepository.GetFirstOrDefault(filter: o => o.orderId == id, includeProperties: "user");
            if (order == null)
            {
                return NotFound();
            }
			var orderDetail = _orderDetailService.GetOrderDetailFromOrderIdIncludeShoes(id);
            var OrderDetailsViewDto = new OrderDetailsViewDto
            {
                Order = order,
                OrderDetails = orderDetail
            };
			return View("/ViewsAdmin/Order/Detail.cshtml", OrderDetailsViewDto);
        }

    }
}
