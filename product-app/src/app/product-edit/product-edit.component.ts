import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { ApiService} from '../api.service'
import { Observable } from "rxjs";
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-product-edit',
  templateUrl: './product-edit.component.html',
  styleUrls: ['./product-edit.component.scss']
})
export class ProductEditComponent implements OnInit {
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

  updateProduct() {
    this.productService.updateProduct(this.productId, this.product)
      .subscribe(data => console.log(data), error => console.log(error));
    this.product = new Product();
    this.gotoList();
  }

  onSubmit() {
    this.updateProduct();    
  }

  gotoList() {
    this.router.navigate(['/products']);
  }

}
