# Fact 1161ae98

Store id: 6cb5dd68-45bf-45f4-b735-70072fef1d3e

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9751980+00:00`

## Data

```json
{
  "end_line": 537,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 535,
  "symbol": "KeyTransform.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":535,"selector":"L535-L537","symbol":"KeyTransform.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 537,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 535,
    "symbol": "KeyTransform.as_sqlite"
  },
  "id": "6cb5dd68-45bf-45f4-b735-70072fef1d3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9751980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 535,
        "selector": "L535-L537",
        "symbol": "KeyTransform.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "0aac16ca-fd86-4131-911f-1e1da6a0d11f",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
