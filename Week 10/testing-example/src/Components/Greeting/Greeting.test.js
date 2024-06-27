import React from 'react';
import { render, screen, fireEvent } from '@testing-library/react';
import Greeting from './Greeting';

describe('Greeting Component', () => { //describe is used to organize tests, this will be a grouping of greeting tests
  test('renders "Hello World" and "It\'s nice to meet you" initially', () => {

    // AAA
    // Arrange
    render(<Greeting />);

    const headingElement = screen.getByText('Hello World');
    const paragraphElement = screen.getByText("It's nice to meet you");
    const buttonElement = screen.getByRole('button', { name: /change text!/i });

    // Act
    // -no actions in this case, only looking for text on screen

    // Assert
    expect(headingElement).toBeInTheDocument();
    expect(paragraphElement).toBeInTheDocument();
    expect(buttonElement).toBeInTheDocument();
  });

  test('renders "I have been changed" after button click', () => {

    // Arrange
    render(<Greeting/>);

    const buttonElement = screen.getByRole('button', { name: /change text!/i });

    // Act
    fireEvent.click(buttonElement);

    const changedParagraphElement = screen.getByText('I have been changed');

    // Assert
    expect(changedParagraphElement).toBeInTheDocument();

    //Added test from Greeting.tsx
    //fireEvent.click(buttonElement);
    //const changedParagraphElement2 = screen.getByText('I have been changed');
    //expect(changedParagraphElement2).toHaveTextContent("I have been changed");
  });
});