import React from 'react';
import { render, fireEvent } from '@testing-library/react';
import Counter from './Counter';

test('renders initial count and buttons', () => {
  // AAA
  // Arange
  //   - Preparing the tests
  // Act
  //   - Doing the action/s
  // Assert
  //   - Verifying the results


  // Arrange
  const { getByText } = render(<Counter />);


  //Act
  //   - There is no act here, it is just a render check


  //Assert
    // Check if the component renders with an initial count of 0
  const countElement = getByText('Count: 0');
  // Test it
  expect(countElement).toBeInTheDocument();

  // Check if the "Increment" and "Decrement" buttons are present
  const incrementButton = getByText('Increment');
  const decrementButton = getByText('Decrement');

  // Test it
  expect(incrementButton).toBeInTheDocument();
  expect(decrementButton).toBeInTheDocument();
});

// New test
test('increments and decrements count when buttons are clicked', () => {

  // Arrange
  const { getByText } = render(<Counter />);

  const incrementButton = getByText('Increment');
  const decrementButton = getByText('Decrement');
  const countElement = getByText('Count: 0');

  // Act
  // Click the "Increment" button
  fireEvent.click(incrementButton);

  // Assert
  expect(countElement).toHaveTextContent('Count: 1'); //will pass
  //expect(countElement).toHaveTextContent('Count: 2'); //will fail as we havent fired another click

  // Click the "Decrement" button
  fireEvent.click(decrementButton);
  expect(countElement).toHaveTextContent('Count: 0');
});