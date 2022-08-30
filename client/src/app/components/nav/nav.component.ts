import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
   loggedIn!: boolean;
    // options$: Observable<Array<Option>> = this.themeService.getThemeOptions();
    //materail related


  constructor(public accountService: AccountService, private router: Router,  ) { }

  ngOnInit(): void {
 // this.getCurrentUser();
 // this.themeService.setTheme("deeppurple-amber");
  }

/*
  themeChangeHandler(themeToSet) {
    this.themeService.setTheme(themeToSet);
  }
  */ 
 //material related

 login() {
  this.accountService.login(this.model).subscribe(response => {
    this.router.navigateByUrl('/categories');
  }, error => {
    console.log(error);
  
  })
}


  // login() {
  //   this.accountService.login(this.model).subscribe(response => {
  //     console.log(response);
  //   }, error => {
  //     console.log(error);
  //   })
  // }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
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
