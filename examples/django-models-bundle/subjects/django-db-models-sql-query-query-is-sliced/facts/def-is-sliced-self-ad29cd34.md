# Fact ad29cd34

Store id: 205d1b67-58f0-4960-9d8f-277f154cfe4f

## Text

```text
def is_sliced(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.4524650+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2216,
  "symbol": "Query.is_sliced"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2216,"selector":"L2216-L2218","symbol":"Query.is_sliced"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_sliced](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2216,
    "symbol": "Query.is_sliced"
  },
  "id": "205d1b67-58f0-4960-9d8f-277f154cfe4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4524650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2216,
        "selector": "L2216-L2218",
        "symbol": "Query.is_sliced"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "768332d7-748b-4a6e-9975-d5232f034584",
  "subject_name": "django/db/models/sql/query::Query.is_sliced",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_sliced(self)"
}
```
