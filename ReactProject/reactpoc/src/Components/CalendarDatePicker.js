import React from "react";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";
 
 
class CalendarDatePicker extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      startDate: new Date()
    };
    this.handleChange = this.handleChange.bind(this);
  }
 
  handleChange(date) {
    this.setState({
      startDate: date
    });
  }
 
  render() {
    return (
      <label>
      Set date and time
      <DatePicker 
        id = "CalendarTripComponet"
        selected={this.state.startDate}
        onChange={this.handleChange}
        showTimeSelect
        dateFormat="Pp"
      />
      </label>
    );
  }
}


export default CalendarDatePicker