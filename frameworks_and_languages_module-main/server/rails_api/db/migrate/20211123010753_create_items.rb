class CreateItems < ActiveRecord::Migration[6.1]
  def change
    create_table :items do |t|
      t.string :user_id
      t.string :keywords
      t.string :description
      t.integer :lat
      t.integer :lon

      t.timestamps
    end
  end
end
