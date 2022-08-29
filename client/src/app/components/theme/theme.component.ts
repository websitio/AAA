import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Option } from 'src/app/models/option.model';
import { ThemeService } from 'src/app/services/theme.service';

@Component({
  selector: 'app-theme',
  templateUrl: './theme.component.html',
  styleUrls: ['./theme.component.css']
})
export class ThemeComponent implements OnInit {

  @Input() options: Array<Option>;
  @Output() themeChange: EventEmitter<string> = new EventEmitter<string>();

  constructor(private themeService: ThemeService) { }

  ngOnInit(): void {}

  changeTheme(themeToSet) {
    this.themeChange.emit(themeToSet);
  }



}
