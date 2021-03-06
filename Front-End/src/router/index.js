import Vue from "vue";
import Router from "vue-router";
import Index from "@/pages/Index";
import OrderList from "@/pages/OrderList";
import Profile from "@/pages/Profile";
import Cart from "@/pages/Cart";
import Validate from "@/pages/Validate";
import Restaurant from "@/pages/Restaurant";
import RestaurantManagement from "@/pages/RestaurantManagement";
import AddRestaurant from "@/pages/AddRestaurant";
import RestaurantDetail from "@/pages/RestaurantDetail";
import ResetPassword from "@/pages/ResetPassword";
import SystemManagement from "@/pages/SystemManagement"
Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [
    {
      path: "*",
      redirect: "/"
    },
    {
      path: "/",
      name: "Index",
      component: Index
    },
    {
      path: "/Validate",
      name: "Validate",
      component: Validate
    },
    {
      path: "/ResetPassword",
      name: "ResetPassword",
      component: ResetPassword
    },
    {
      path: "/OrderList",
      name: "OrderList",
      component: OrderList,
      meta: { requiresAuth: true }
    },
    {
      path: "/Profile",
      name: "Profile",
      component: Profile,
      meta: { requiresAuth: true }
    },
    {
      path: "/Restaurant/:id",
      name: "Restaurant",
      component: Restaurant
    },
    {
      path: "/Cart",
      name: "Cart",
      component: Cart,
      meta: { requiresAuth: true }
    },
    {
      path: "/RestaurantManagement",
      name: "RestaurantManagement",
      component: RestaurantManagement,
      meta: { requiresAuth: true },
      beforeEnter(to, from, next) {
        const tokenInfo = JSON.parse(localStorage.getItem("tokenInfo"));
        if (tokenInfo.role != 0) {
          next();
        }
      }
    },
    {
      path: "/RestaurantDetail/:id",
      name: "RestaurantDetail",
      component: RestaurantDetail,
      meta: { requiresAuth: true }
    },
    {
      path: "/AddRestaurant",
      name: "AddRestaurant",
      component: AddRestaurant,
      meta: { requiresAuth: true }
    },
    {
      path: "/SystemManagement",
      name: "SystemManagement",
      component: SystemManagement,
      meta: { requiresAuth: true }
    }
  ]
});
