# Fact 240e2bd5

Store id: a97840ce-ba3c-440c-87c1-688b37cb55ee

## Text

```text
def base_table(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.7548470+00:00`

## Data

```json
{
  "end_line": 343,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 340,
  "symbol": "Query.base_table"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L343","symbol":"Query.base_table"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.base_table](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 343,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 340,
    "symbol": "Query.base_table"
  },
  "id": "a97840ce-ba3c-440c-87c1-688b37cb55ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7548470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L343",
        "symbol": "Query.base_table"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "599e7858-7d24-439a-bb61-d2105d40b796",
  "subject_name": "django/db/models/sql/query::Query.base_table",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def base_table(self)"
}
```
