import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Helloworld';
  imgUrl = "../assets/bridgeLabz_Logo.png";
  url = "https://www.bridgelabz.com";
  userName: string = "";
  nameError: string = "";

  onClick($event : Event){
    console.log("Save button is clicked", $event);
    window.open(this.url, "_blank");
  }

  onInput(event: Event) {
    const inputElement = event.target as HTMLInputElement;
    this.userName = inputElement.value; 
  
    console.log("Change Event Occurred!", this.userName);
  
    const nameRegex = /^[A-Z]{1}[a-zA-Z\s]{2,}$/;
    if (nameRegex.test(this.userName)) {
      this.nameError = "";
      return;
    }
    this.nameError = "Name is Incorrect!";
  }
  
}
