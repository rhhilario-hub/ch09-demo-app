package com.example.demoapp;

import org.springframework.data.jpa.repository.JpaRepository;

interface OrderReposity extends JpaRepository<Order, Long> {
    
}
