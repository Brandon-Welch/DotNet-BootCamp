//async.test.js
import { render, screen } from '@testing-library/react';
import Async from './Async';

describe('Async Component', () => {
    test('renders post if request succeeds', async () => {

        /* Instead of actually sending a request using out test, we will be mocking its behavior so that an actual network
            request is not sent out
            A simulation of it is instead
            We just want to verify that the response back is handled correctly, not that the request is made successfully
        */

        // Arrange
        window.fetch = jest.fn();
        window.fetch.mockResolvedValueOnce({
            json: async () => [{id: 'p1', title: 'first post'}],
        });

        render(<Async/>);
        // fetch request gets a list
        // We want all the lists on this page
        // but becuase the elemeents are displayed asynchronously, we cannot use getAllByRole as we have to wait 
        // for the promise to resolve and the posts to be updated in order for the component to re-render the new listitems
        const listItemElement = await screen.findAllByRole("listitem");
        
        // Act
        

        // Assert
        // We just want to expect that it is not empty
        expect(listItemElement).not.toHaveLength(0);
    })
})