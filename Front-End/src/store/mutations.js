import * as types from "./mutations_type.js";

export const state = {
  shoppingCartInfo: {
    shoppingCartTotalPrice: 0,
    shoppingCartItems: [],
  },
  restaurantList: [],
  tokenInfo: {
    account: "",
    token: "",
    role: 0
  },
  memberInfo: {
    m_name: "",
    m_birthday: "",
    m_email: "",
    m_address: ""
  },
  restaurantInfo: {
    restaurant: {
      restaurantID: "",
      r_name: "",
      r_address: "",
      r_tel: ""
    },
    typeAndMenu: []
  }
};

export const mutations = {
  [types.GET_RESLIST](state, data) {
    state.restaurantList = data;
  },
  [types.GET_RESINFO](state, data) {
    state.restaurantInfo = data;
  },
  [types.SAVE_TOKEN](state, data) {
    state.tokenInfo = data;
  },
  [types.CLEAR_TOKEN](state) {
    state.tokenInfo.token = "";
    state.tokenInfo.account = "";
    state.tokenInfo.role = 0;
  },
  [types.GET_MEMBERINFO](state, data) {
    state.memberInfo = data;
    var birthday = data.m_birthday.split("T");
    state.memberInfo.m_birthday = birthday[0];
  },
  [types.SAVE_SHOPPINGCART](state, item) {
    let itemdata = JSON.parse(JSON.stringify(item));
    let index = state.shoppingCartInfo.shoppingCartItems.findIndex(item => item.name === itemdata.name);
    if (index !== -1) {
      state.shoppingCartInfo.shoppingCartItems[index].number++;
      state.shoppingCartInfo.shoppingCartItems[index].subtotal += item.price;
    } else {
      state.shoppingCartInfo.shoppingCartItems.push(item);
    }
    state.shoppingCartInfo.shoppingCartTotalPrice += item.price;   
    localStorage.setItem("shpopingCart",JSON.stringify(state.shoppingCartInfo));
  },
  [types.MINUS_NUMBER_SHOPPINGCART](state, item) {
    let itemdata = JSON.parse(JSON.stringify(item));
    let index = state.shoppingCartInfo.shoppingCartItems.findIndex(item => item.name === itemdata.name);
    let cartItem = state.shoppingCartInfo.shoppingCartItems[index];
    if (index !== -1 && cartItem.number > 1) {
      cartItem.number--;
      state.shoppingCartInfo.shoppingCartItems[index].subtotal -= item.price;
      state.shoppingCartInfo.shoppingCartTotalPrice -= item.price;
    }
  },
};


