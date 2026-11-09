# Fact 2b415402

Store id: 689a7af5-b881-43e9-b89d-927fcac6733a

## Text

```text
def _execute_query(self)
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
- posted_at: `2026-11-09T22:39:51.2133370+00:00`

## Data

```json
{
  "end_line": 225,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 208,
  "symbol": "RawQuery._execute_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":208,"selector":"L208-L225","symbol":"RawQuery._execute_query"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery._execute_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 225,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 208,
    "symbol": "RawQuery._execute_query"
  },
  "id": "689a7af5-b881-43e9-b89d-927fcac6733a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2133370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 208,
        "selector": "L208-L225",
        "symbol": "RawQuery._execute_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "53c02f22-2577-44d7-9e25-da4d53125721",
  "subject_name": "django/db/models/sql/query::RawQuery._execute_query",
  "tags": [
    "entity:method"
  ],
  "text": "def _execute_query(self)"
}
```
