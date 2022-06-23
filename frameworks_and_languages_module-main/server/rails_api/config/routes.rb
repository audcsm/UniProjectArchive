Rails.application.routes.draw do
  get '/items', to: 'item#index'
  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
  resources :item, only: [:index, :show, :create, :update, :destroy]
end
