package by.epam.pretraining.task6.model;

public class UserDynamicStack extends UserStack {

    

    @ Override public void push(int item) throws MyOwnExcepton {
        if (position == currentSize - 1) {
            int temp[] = new int[currentSize + START_SIZE];
            System.arraycopy(stack, 0, temp, 0, currentSize);
            stack = temp;
        }
        stack[++position] = item;

    }

    @ Override public int pop() throws MyOwnExcepton {
        if (position == -1) {
            throw new MyOwnExcepton("Stack is empty");
        } else {
            return stack[position--];
        }
    }

}
