# Fact 15762306

Store id: d8dc248f-d65a-431f-b455-0caba2dbd493

## Text

```text
def create_sql(self, model, schema_editor, using="", **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.7814690+00:00`

## Data

```json
{
  "end_line": 224,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 186,
  "symbol": "Index.create_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L224","symbol":"Index.create_sql"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.create_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 224,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 186,
    "symbol": "Index.create_sql"
  },
  "id": "d8dc248f-d65a-431f-b455-0caba2dbd493",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.7814690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L224",
        "symbol": "Index.create_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "12956150-6fba-4e7c-ad20-616c4d9f732a",
  "subject_name": "django/db/models/indexes::Index.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor, using=\"\", **kwargs)"
}
```
