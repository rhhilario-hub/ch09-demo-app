package com.example.demoapp;

import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class OrdersController {
    private OrderReposity reposity;

    public OrderController(OrderReposity reposity) {
        this.reposity = reposity;
    }

    @GetMapping("/orders")
    List<Order> all() {
        return repository.findAll();
    }
}
