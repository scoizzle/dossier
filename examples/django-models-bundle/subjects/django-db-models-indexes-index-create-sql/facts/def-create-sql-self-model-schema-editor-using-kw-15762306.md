# Fact 15762306

Store id: 43d8bb21-b790-444f-ae3f-19429b34afbb

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
- posted_at: `2026-11-09T23:44:54.6792790+00:00`

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
  "id": "43d8bb21-b790-444f-ae3f-19429b34afbb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6792790+00:00"
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
  "subject_id": "4d27843f-7ae7-4c41-8ba6-65c353a96120",
  "subject_name": "django/db/models/indexes::Index.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor, using=\"\", **kwargs)"
}
```
