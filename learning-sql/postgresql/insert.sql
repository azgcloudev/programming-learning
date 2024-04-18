INSERT INTO
    customer (
        first_name,
        last_name,
        email,
        company,
        street,
        city,
        state,
        zip,
        phone,
        birth_date,
        sex,
        date_entered
    )
VALUES
    (
        'Christopher',
        'Jones',
        'cj@bp.com',
        'BP',
        '347 Cedar St',
        'Lawrenceville',
        'GA',
        '30044',
        '348-848-8291',
        '1938-01-11',
        'M',
        current_timestamp
    );

-- insert a sales person
INSERT INTO
    customer (
        first_name,
        last_name,
        email,
        company,
        street,
        city,
        state,
        zip,
        phone,
        birth_date,
        sex,
        date_entered
    )
VALUES
    (
        'Christopher',
        'Jones',
        'cj@bp.com',
        'BP',
        '347 Cedar St',
        'Lawrenceville',
        'GA',
        '30044',
        '348-848-8291',
        '1938-01-11',
        'M',
        current_timestamp
    );

-- insert types
INSERT INTO
    product_type (name)
VALUES
    ('Business');

INSERT INTO
    product_type (name)
VALUES
    ('Casual');

INSERT INTO
    product_type (name)
VALUES
    ('Athlelic');

-- add products
INSERT INTO
    product
VALUES
    (
        1,
        'Granview',
        'Allen Edmonds',
        'Lorem Isum description'
    ),
    (
        1,
        'Clarkstone',
        'Allen Edmonds',
        'Lorem Isum description'
    ),
    (
        1,
        'Derby',
        'John Varvatos',
        'Lorem Isum description'
    ),
    (
        1,
        'Ramsey',
        'Johnston & Murphy',
        'Leather upper, manmade sole'
    ),
    (
        1,
        'Hollis',
        'Johnston & Murphy',
        'Leather upper, manmade sole'
    ),
    (
        2,
        'Venetian Loafer',
        'Mezlan',
        'Suede upper, leather sole'
    ),
    (
        2,
        'Malek',
        'Johnston & Murphy',
        'Contrast insets at the toe and sides bring updated attitude to...'
    ),
    (
        3,
        'Air Max 27- React',
        'Nike',
        'The reggae inspired Nike Air 270 React fuses forest green with...'
    ),
    (
        3,
        'Joyride',
        'Nike',
        'Tiny foam beads underfoot confirm to your foot for cushioning that stands up...'
    ),
    (
        2,
        'Air Force 1',
        'Nike',
        'A modern take on the icon that blends classic style and fresh, crisp..'
    ),
    (
        3,
        'Ghost 12',
        'Brooks',
        'Just known that it still strikes a just-right balance of DNA LOFT softness...'
    ),
    (
        3,
        'Revel 3',
        'Brooks',
        'Style to spare, now even softer.'
    ),
    (
        3,
        'Glycerin 17',
        'Brooks',
        'A plush fit and super soft transitions make every stride luxurious'
    );