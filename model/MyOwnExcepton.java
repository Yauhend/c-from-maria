/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package by.epam.pretraining.task6.model;

/**
 *
 * @author Student
 */
public class MyOwnExcepton extends Exception {
     public  MyOwnExcepton() {
         super ();
    }
    
    public  MyOwnExcepton (String msg){
        super (msg);
    }
    
}
