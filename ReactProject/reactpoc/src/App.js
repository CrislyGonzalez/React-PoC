import React, { Component } from 'react';
import logo from './taxi.jpg';
import './App.css';
import TagTitle from './Components/TagTitle'
import CalendarTripComponet from './Components/CalendarDatePicker'
import StateSelectorComponet from './Components/StateSelector'
import OrigenDestinoTripCompoment from './Components/OrigenDestionationRouteInput'
import MilesAndTimeInputCompoment from './Components/MilesAndTimeInput'


class App extends Component {

   constructor(props) {
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);
  }


  handleSubmit = (event) => {
    event.preventDefault();

    //print compoment
    console.log(event.target.CalendarTripComponet.value);
    console.log(event.target.StateSelectorComponet.value);
    console.log(event.target.OrigenTripCompoment.value);
    console.log(event.target.DestinoTripCompoment.value);
    console.log(event.target.MilesTripComponent.value);
  
    //method get with id
     
    const request = this.makeRequestInInvoiceAPI("http://localhost:47049/api/Meters");
      request.then(value => {
        console.log(value);
      }).catch(error => {
        console.log(error);
    }); 

/*
    //method post
    
    var url = 'http://localhost:47049/api/Meters';
    var data = {
                "DateAndTimeTrip": event.target.CalendarTripComponet.value,
                "StateTrip": event.target.StateSelectorComponet.value,
                "OrigenRouteTrip": event.target.OrigenTripCompoment.value,
                "DestinationRouteTrip": event.target.DestinoTripCompoment.value,
                "MilesTrip": event.target.MilesTripComponent.value
              }
    console.log(data);

    fetch(url,{
      method: 'POST', 
      body: JSON.stringify(data), 
      headers:{
        'Accept': 'application/json',
        'Content-Type': 'application/json'

    }
    }).then(res => res)
      .catch(error => console.error('Error:', error))
      .then(response => console.log('Success:', response));

  */

      //clean form
      event.target.OrigenTripCompoment.value="";
      event.target.DestinoTripCompoment.value="";
      event.target.MilesTripComponent.value="";
  }
  
  

    requestOptionGet = () => {
      return {method: 'GET'}
    }
    

    async makeRequestInInvoiceAPI(endPointParam) {
    try {
      const response = await fetch(endPointParam,this.requestOptionGet());
      return !response.ok ? Promise.reject(response) : response.json();
    } catch (error) {
      return error;
    }
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
          <TagTitle />
          <form onSubmit={this.handleSubmit}> 
                <CalendarTripComponet />
                <StateSelectorComponet />
                <OrigenDestinoTripCompoment />
                <MilesAndTimeInputCompoment/>
                <input type="submit" value="Submit" />
          </form>
        </header>
      </div>
    );
  }
}

export default App;
