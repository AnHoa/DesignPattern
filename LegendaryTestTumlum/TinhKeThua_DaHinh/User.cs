using System;

namespace LegendaryTestTumlum.TinhKeThua_DaHinh
{
    public class User
    {
        private Builder builder;

        public User(Builder builder)
        {
            this.builder = builder;
        }

        public class Builder
        {
            private int id;
            private String name;
            private String email;
            private String birthday;
            private int weight;
            private int height;
            private int groupId;
            private int companyId;

            public Builder setId(int id)
            {
                this.id = id;
                return this;
            }

            public Builder setName(String name)
            {
                this.name = name;
                return this;
            }

            public Builder setEmail(String email)
            {
                this.email = email;
                return this;
            }

            public Builder setBirthday(string birthday)
            {
                this.birthday = birthday;
                return this;
            }
            public Builder setWeight(int weight)
            {
                this.weight = weight;
                return this;
            }

            public Builder setHeight(int height)
            {
                this.height = height;
                return this;
            }

            public Builder setGroupId(int groupId)
            {
                this.groupId = groupId;
                return this;
            }

            public Builder setCompanyId(int companyId)
            {
                this.companyId = companyId;
                return this;
            }

            public User build()
            {
                validate();
                return new User(this);
            }

            private void validate() { }

        }
    }
}
