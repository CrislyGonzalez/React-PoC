
import React from 'react';

class OrigenDestionationRouteInput extends React.Component {


  render() {
    return (
      <div>
        <label>
          Origen:
          <input id="OrigenTripCompoment" type="text" />
        </label>
   
        <label>
          Destionation:
          <input id="DestinoTripCompoment" type="text"/>
        </label>
      </div>
    );
  }
}

export default OrigenDestionationRouteInput