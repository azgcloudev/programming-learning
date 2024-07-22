namespace IntroToGenerics
{
    public class Bag<T>
    {
        private T content;
    
        /// <summary>
        /// Initialize a Bag object
        /// </summary>
        /// <param name="initialValue">Initial value for the Bag</param>
        public Bag(T initialValue)
    {
        content = initialValue;
    }

        /// <summary>
        /// Update the content value.
        /// </summary>
        /// <param name="newContent">Value to update the content</param>
        public void UpdateContent(T newContent)
    {
        content = newContent;
    }
    
        /// <summary>
        /// Get the content value
        /// </summary>
        /// <returns>Returns the content value</returns>
        public T GetContent()
    {
        return content;
    }
    }
}