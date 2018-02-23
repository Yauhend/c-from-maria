package by.epam.pretraining.task6.model;

public abstract class UserStack {

    int START_SIZE=10;
    int stack[] = new int[START_SIZE];
    int position=-1, currentSize = START_SIZE;

    
    
    abstract public void push(int item) throws MyOwnExcepton;

    abstract public int pop() throws MyOwnExcepton;

    public int peek() throws MyOwnExcepton {
        if (position == -1) {
            throw new MyOwnExcepton("Stack is empty");
        } else {
            return stack[position];
        }
    }

    public int size() {
        return this.position + 1;
    }

    public Boolean isEmpty() {
        return position == -1;
    }

    public Boolean isFool() {
        return position == currentSize - 1;
    }
}
