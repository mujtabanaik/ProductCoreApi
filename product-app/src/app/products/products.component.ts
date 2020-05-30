import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { ApiService} from '../api.service'
import { Router } from '@angular/router';
import { Observable } from "rxjs";

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})

export class ProductsComponent implements OnInit {
  products: Observable<Product[]>;
  productId: number;
  product: Product;
  submitted = false;
  constructor(private productService: ApiService,
    private router: Router) { }
  
  ngOnInit() {
    this.products = this.productService.getProductsList();
  }
  reloadData() {
    this.products = this.productService.getProductsList();
  }

  deleteProduct(id: number) {
    this.productService.deleteProduct(id)
      .subscribe(
        data => {
          console.log(data);
          this.reloadData();
        },
        error => console.log(error));
  }

  updateProduct(id: number){
    this.router.navigate(['product/edit/', id]);
    this.reloadData()
  }
  

  productDetails(id: number){
    this.router.navigate(['product/details/', id]);
  }
}
