/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package by.epam.pretraining.task6.controller;

import by.epam.pretraining.task6.model.MyOwnExcepton;
import by.epam.pretraining.task6.model.UserDynamicStack;
import by.epam.pretraining.task6.model.UserFixedStack;
import by.epam.pretraining.task6.view.View;

/**
 *
 * @author Student
 */
public class Test {

    public static void main(String[] args) {
        UserFixedStack fix = new UserFixedStack();

        try {
            fix.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        try {
            fix.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        try {
            fix.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
        try {
            fix.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
        try {
            
            View.printToConsole(fix.pop());
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
           try {
            
            View.printToConsole(fix.peek());
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
           View.printToConsole(fix.size());
           View.printToConsole(fix.isEmpty());
           View.printToConsole(fix.isFool());

        UserDynamicStack dyn = new UserDynamicStack();
        
        try {
            dyn.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        try {
            dyn.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        try {
            dyn.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
        try {
            dyn.push(10);
            View.printToConsole("Pushed");
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
        try {
            
            View.printToConsole(dyn.pop());
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
        
           try {
            
            View.printToConsole(dyn.peek());
        } catch (MyOwnExcepton e) {
            View.printToConsole(e);
        }
           View.printToConsole(dyn.size());
           View.printToConsole(dyn.isEmpty());
           View.printToConsole(dyn.isFool());
    }
}
