import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AccountService } from 'src/app/services/account.service';
import { ThemeService } from 'src/app/services/theme.service';
import { Option } from 'src/app/models/option.model';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
   loggedIn!: boolean;
   options$: Observable<Array<Option>> = this.themeService.getThemeOptions();


  constructor(public accountService: AccountService, private readonly themeService: ThemeService) { }

  ngOnInit(): void {
 // this.getCurrentUser();
 this.themeService.setTheme("deeppurple-amber");
  }

  themeChangeHandler(themeToSet) {
    this.themeService.setTheme(themeToSet);
  }




  login() {
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    })
  }

  logout() {
    this.accountService.logout();
  }


getCurrentUser() {
  this.accountService.currentUser$.subscribe(user=>{
    this.loggedIn=!!user;
  },
  error=>{
    console.log(error);
  }
  )

}

}
