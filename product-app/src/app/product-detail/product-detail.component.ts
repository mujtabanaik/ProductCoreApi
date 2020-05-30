import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { ApiService} from '../api.service'
import { Observable } from "rxjs";
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {

  productId: number;
  product: Product;
  constructor(private route: ActivatedRoute,private router: Router,
    private productService: ApiService) { }


  ngOnInit() {
    this.product = new Product();

    this.productId = this.route.snapshot.params['id'];
    
    this.productService.getProduct(this.productId)
      .subscribe(data => {
        console.log(data)
        this.product = data;
      }, error => console.log(error));
  }

  list(){
    this.router.navigate(['products']);
  }

}
