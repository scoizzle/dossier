# Fact 18fafa77

Store id: e21b5656-0e58-4190-b89d-b44bf4739270

## Text

```text
def get_fallback_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:52.7780850+00:00`

## Data

```json
{
  "end_line": 272,
  "entity_kind": "method",
  "parent": "TupleLessThan",
  "start_line": 248,
  "symbol": "TupleLessThan.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":248,"selector":"L248-L272","symbol":"TupleLessThan.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThan.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 272,
    "entity_kind": "method",
    "parent": "TupleLessThan",
    "start_line": 248,
    "symbol": "TupleLessThan.get_fallback_sql"
  },
  "id": "e21b5656-0e58-4190-b89d-b44bf4739270",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7780850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 248,
        "selector": "L248-L272",
        "symbol": "TupleLessThan.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "335d1986-9c5d-49ab-8700-a01e01f913bb",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThan.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
