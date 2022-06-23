class ItemController < ApplicationController
  # GET all item data
  def index
    render json: Item.all
  end

  # GET item data by id
  def show
    render json: Item.find(params[:id]), status: :ok
  end

  # GET items posted by user id
  #def show
   # render json: Item.find(params[:user_id]), status: :ok
  #end

  # POST a new item
  def create
    # allows to parse item before saving
    item = Item.create(item_params)
    render json: item, status: :created
  end

  # PUT an item by id
  def update
    # find the item by id
    item = Item.find(params[:id])

    # if updated successfully
    if item.update(item_params)
      render json: item, status: :created
    else
      render json: item.errors, status: :method_not_allowed 
    end
  end

  # DELETE an item by id
  def destroy
    # find the item by the given id and remove it
    Item.find(params[:id]).destroy
    # respond with a 201
    head :created
  end


  private

  # security measure to only allow these parameters to be edited and not the "created at" etc params
  def item_params
    params.require(:item).permit(:user_id, :keywords, :description, :lat, :lon)
  end
  
end
