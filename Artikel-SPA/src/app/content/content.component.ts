import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {
  content: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getContents();
  }
  getContents() {
    this.http.get('http://localhost:5050/api/contens').subscribe(response => {
      this.content = response;
    }, error => {
      console.log(error);
    });
  }

}
