import React from 'react';
 
class StateSelector extends React.Component {
  render() {
    return (
        <label>
          State:
          <select id="StateSelectorComponet">
            <option value="Florida">Florida</option>
            <option value="New York">New York</option>
            <option value="Hawai">Hawai</option>
            <option value="Arizona">Arizona</option>
          </select>
        </label>
    );
  }
}

export default StateSelector