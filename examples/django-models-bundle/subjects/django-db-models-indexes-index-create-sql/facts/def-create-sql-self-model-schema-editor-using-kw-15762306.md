# Fact 15762306

Store id: c6b2d4f4-2f8b-455f-997b-d24ba325dc7c

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
- posted_at: `2026-11-09T23:32:02.9145270+00:00`

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
  "id": "c6b2d4f4-2f8b-455f-997b-d24ba325dc7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9145270+00:00"
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
  "subject_id": "89095fd8-e215-4427-bfe6-c271e00e0fd2",
  "subject_name": "django/db/models/indexes::Index.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor, using=\"\", **kwargs)"
}
```
