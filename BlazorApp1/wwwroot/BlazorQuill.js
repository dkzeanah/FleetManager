(function () {
    window.QuillFunctions = {
        createQuill: function (quillElement) {
            var options = {
                debug: 'info',
                modules: {
                    toolbar: '#toolbar'
                },
                placeholder: 'Compose an epic...',
                readOnly: false,
                theme: 'snow'
            };

            // Create a new Quill instance
            var quill = new Quill(quillElement, options);

            // Define functions to get Quill content, text, and HTML
            var getQuillContent = function () {
                return JSON.stringify(quill.getContents());
            };

            var getQuillText = function () {
                return quill.getText();
            };

            var getQuillHTML = function () {

                return quill.root.innerHTML;
            };
             ,
            loadQuillContent: function (quillControl, quillContent) {
                content = JSON.parse(quillContent);
                return quillControl.__quill.setContents(content, 'api');
            },

            // Return these functions for external use
            return {
                getQuillContent: getQuillContent,
                getQuillText: getQuillText,
                getQuillHTML: getQuillHTML
            };
        }
    };
})();
