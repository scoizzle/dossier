# Fact b9fae046

Store id: 2b9d737b-cf5b-4cda-b63c-f38813ff31fb

## Text

```text
def chain(self, using)
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
- posted_at: `2026-11-09T23:44:58.5432100+00:00`

## Data

```json
{
  "end_line": 171,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 170,
  "symbol": "RawQuery.chain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L171","symbol":"RawQuery.chain"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.chain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 171,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 170,
    "symbol": "RawQuery.chain"
  },
  "id": "2b9d737b-cf5b-4cda-b63c-f38813ff31fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5432100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L171",
        "symbol": "RawQuery.chain"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "371c2205-e048-4a56-9c36-d8152b954487",
  "subject_name": "django/db/models/sql/query::RawQuery.chain",
  "tags": [
    "entity:method"
  ],
  "text": "def chain(self, using)"
}
```
