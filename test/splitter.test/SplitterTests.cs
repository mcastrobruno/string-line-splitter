using System;
using Xunit;

namespace splitter.test
{
    public class UnitTest1
    {
        //SUT
        private StringSplitter _splitter = new StringSplitter();

        [Fact]
        public void Should_return_empty_when_string_is_empty()
        {
            //act
            var result = _splitter.Split("", 10);

            //assert
            Assert.Equal("", result);
        }


        [Fact]
        public void Should_return_whole_string_when_text_length_is_lower_then_length_to_be_splitted()
        {
            //act
            var result = _splitter.Split("bruno", 10);

            //assert
            Assert.Equal("bruno", result);
        }

        [Fact]
        public void Should_return_two_lines_string_when_text_length_is_1_time_greather_then_length_to_be_splitted()
        {
            //act
            var result = _splitter.Split("saipher test", 7);

            //assert
            Assert.Equal($"saipher{Environment.NewLine}test", result);
        }

        [Fact]
        public void Should_only_split_on_spaces()
        {
            //act
            var result = _splitter.Split("saipherpassoutamanho test", 7);

            //assert
            Assert.Equal($"saipherpassoutamanho{Environment.NewLine}test", result);
        }

        [Fact]
        public void Should_only_split_on_spaces_with_4_words()
        {
            //act
            var result = _splitter.Split("saipherpassoutamanho hue hu", 7);

            //assert
            Assert.Equal($"saipherpassoutamanho{Environment.NewLine}hue hu", result);
        }

        [Fact]
        public void Should_split_when_length_is_10()
        {
            //act
            var result = _splitter.Split("1234 test hue hu", 10);

            //assert
            Assert.Equal($"1234 test{Environment.NewLine}hue hu", result);
        }

          [Fact]
        public void Should_split_when_length_is_4()
        {
            //act
            var result = _splitter.Split("1234 test hue hu", 4);

            //assert
            Assert.Equal($"1234{Environment.NewLine}test{Environment.NewLine}hue{Environment.NewLine}hu", result);
        }
    }
}
