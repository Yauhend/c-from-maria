package by.epam.pretraining.task6.model;

public class UserFixedStack extends UserStack {

   
    

    @ Override public void push(int item) throws MyOwnExcepton {
        if (position == currentSize - 1) {
            throw new MyOwnExcepton("Stack is full");
        } else {
            stack[++position] = item;
        }

    }

    @ Override public int pop() throws MyOwnExcepton {
        if (position == -1) {
            throw new MyOwnExcepton("Stack is empty");
        } else {
            return stack[position--];
        }

    }
    @Override public int peek() throws MyOwnExcepton {
        if (position == -1) {
            throw new MyOwnExcepton("Stack is empty");
        } else {
            return stack[position];
        }
    }
  
}
