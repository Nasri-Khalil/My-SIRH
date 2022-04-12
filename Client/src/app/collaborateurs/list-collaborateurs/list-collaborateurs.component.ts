import { Component, OnInit } from '@angular/core';
import { collaborateur } from 'src/app/Models/collaborateur';
import { CollaborateurService } from 'src/app/services/collaborateur.service';

@Component({
  selector: 'app-list-collaborateurs',
  templateUrl: './list-collaborateurs.component.html',
  styleUrls: ['./list-collaborateurs.component.css']
})
export class ListCollaborateursComponent implements OnInit {

  constructor(private service:CollaborateurService) { }
  collaborateurListArray: collaborateur[] = [];
  
  ngOnInit(): void {
    this.getCollaborateurs();
  }
  getCollaborateurs() {
    this.service.getCollaborateurList().subscribe((data) => {
      this.collaborateurListArray = data;
      console.log(data);
    });
  }

}
