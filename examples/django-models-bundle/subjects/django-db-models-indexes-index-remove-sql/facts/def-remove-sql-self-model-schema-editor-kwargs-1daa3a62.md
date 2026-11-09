# Fact 1daa3a62

Store id: 6d99e16c-365c-49a3-b569-2d2856dffb39

## Text

```text
def remove_sql(self, model, schema_editor, **kwargs)
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
- posted_at: `2026-11-09T23:44:54.6824410+00:00`

## Data

```json
{
  "end_line": 227,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 226,
  "symbol": "Index.remove_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":226,"selector":"L226-L227","symbol":"Index.remove_sql"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.remove_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 227,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 226,
    "symbol": "Index.remove_sql"
  },
  "id": "6d99e16c-365c-49a3-b569-2d2856dffb39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6824410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 226,
        "selector": "L226-L227",
        "symbol": "Index.remove_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "b6f1a181-8dce-442d-86cc-b6a4fa34cc75",
  "subject_name": "django/db/models/indexes::Index.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor, **kwargs)"
}
```
