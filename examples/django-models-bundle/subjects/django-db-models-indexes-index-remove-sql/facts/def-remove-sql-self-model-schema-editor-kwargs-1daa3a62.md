# Fact 1daa3a62

Store id: c8860712-92e8-4b27-bb7e-382da9548c82

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
- posted_at: `2026-11-09T23:32:02.9176200+00:00`

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
  "id": "c8860712-92e8-4b27-bb7e-382da9548c82",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9176200+00:00"
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
  "subject_id": "2e256972-341b-40e3-91a6-80cfe92108d1",
  "subject_name": "django/db/models/indexes::Index.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor, **kwargs)"
}
```
